using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using WebApiLogger.Core;

namespace WebApiLogger.Host
{
    public class LoggerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly LogSetting _logSetting;

        public LoggerMiddleware(RequestDelegate next, IOptions<LogSetting> logSettingAccessor)
        {
            _next = next;
            _logSetting = logSettingAccessor.Value;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Path.Value.Contains("api"))
            {
                context.Request.EnableBuffering();
                Stream originalBody = context.Response.Body;
                var logger = (ILoggerData)context.RequestServices.GetService(typeof(ILoggerData));

                try
                {
                    BuildRequestLoggerData(context.Request, logger);

                    using (var ms = new MemoryStream())
                    {
                        context.Response.Body = ms;

                        await _next(context);

                        BuildResponseLoggerData(context.Response, ms, logger);

                        ms.Position = 0;
                        await ms.CopyToAsync(originalBody);
                    }
                }
                catch (Exception ex)
                {
                    BuildErrorLoggerData(ex, logger);
                }
                finally
                {
                    context.Response.Body = originalBody;
                    SendEvents(logger);
                }
            }
            else
            {
                await _next(context);
            }
        }

        private void BuildRequestLoggerData(HttpRequest request, ILoggerData logger)
        {
            var sr = new StreamReader(request.Body);

            var content = sr.ReadToEnd();

            if (!string.IsNullOrEmpty(content))
            {
                logger.Body = content;
                request.Body.Position = 0;
            }

            logger.Cookies = CreateCookieString(request.Cookies);
            logger.Url = request.Path;
            logger.Method = request.Method;
            logger.QueryString = request.QueryString.Value;

            if (request.ContentType == "multipart/form-data" || request.ContentType == "application/x-www-form-urlencoded")
            {
                logger.FormData = BuildFormString(request.Form);
            }
        }

        private void BuildErrorLoggerData(Exception exception, ILoggerData logger)
        {
            logger.StatusCode = 500;
            logger.ErrorTrace = exception.StackTrace;

            logger.Error();
        }

        private void BuildResponseLoggerData(HttpResponse response, MemoryStream ms, ILoggerData logger)
        {
            ms.Position = 0;
            logger.ResponseBody = new StreamReader(ms).ReadToEnd();
            logger.StatusCode = response.StatusCode;
            logger.Success();
        }

        private string BuildFormString(IFormCollection formCollection)
        {
            if (formCollection == null) return string.Empty;

            var stringBuilder = new StringBuilder();

            foreach (var item in formCollection)
            {
                stringBuilder.Append($"{item.Key}:{item.Value};");
            }

            return stringBuilder.ToString();
        }

        private string CreateCookieString(IRequestCookieCollection cookieCollection)
        {
            if (cookieCollection == null) return string.Empty;

            var stringBuilder = new StringBuilder();

            foreach (var item in cookieCollection)
            {
                stringBuilder.Append($"{item.Key}:{item.Value};");
            }

            return stringBuilder.ToString();
        }

        private void SendEvents(ILoggerData data)
        {
            var factory = new ConnectionFactory() { Uri = new Uri(_logSetting.RabbitMQUrl), UserName = _logSetting.UserName, Password = _logSetting.Password };

            IConnection connection = factory.CreateConnection();
            IModel channel = connection.CreateModel();


            channel.ExchangeDeclare(_logSetting.QueueName, "fanout");

            var json = JsonConvert.SerializeObject(data);
            var bytes = Encoding.UTF8.GetBytes(json);
            channel.BasicPublish(exchange: _logSetting.QueueName, routingKey: "", basicProperties: null, body: bytes);
        }
    }
}
