using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WebApiLogger.Connector.RabbitMQ;
using WebApiLogger.Core.Configurations;

namespace WebApiLogger.Client.Configuration
{
    public class ConfigurationAccessor
    {
        private static string _configPath = "config.json";
        private static IConfiguration _current = null;

        private static string LoadContent()
        {
            using (var sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + _configPath))
            {
                var content = sr.ReadToEnd();

                return content;
            }
        }

        public static IConfiguration GetConfig()
        {
            if (_current == null)
            {
                var content = LoadContent();

                JObject config = JObject.Parse(content);

                if (config["Source"].ToString() == "RabbitMQ")
                {
                    _current = JsonConvert.DeserializeObject<RabbitMQConfiguration>(config["RabbitMQ"].ToString());
                }
                else
                {
                    throw new Exception();
                }
            }

            return _current;
        }
    }
}
