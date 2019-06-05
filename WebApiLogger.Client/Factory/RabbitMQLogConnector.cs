﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using WebApiLogger.Client.Configuration;
using WebApiLogger.Core;

namespace WebApiLogger.Client.Factory
{
    public class RabbitMQLogConnector : ILogConnector
    {
        public string Name
        {
            get { return "RabbitMQ"; }
        }

        public void StartTracking(Action<ILoggerData> callback)
        {
            var factory = new ConnectionFactory()
            {
                Uri = new Uri(ConfigurationAccessor.GetConfig().RabbitMQ.Url),
                UserName = ConfigurationAccessor.GetConfig().RabbitMQ.UserName,
                Password = ConfigurationAccessor.GetConfig().RabbitMQ.Password
            };

            IConnection connection = factory.CreateConnection();
            IModel channel = connection.CreateModel();

            var queueName = channel.QueueDeclare().QueueName;

            channel.QueueBind(queue: queueName, exchange: ConfigurationAccessor.GetConfig().RabbitMQ.QueueName, routingKey: "");

            var consumer = new EventingBasicConsumer(channel);

            consumer.Received += (model, ea) =>
            {
                var body = ea.Body;
                var message = Encoding.UTF8.GetString(body);

                var cmd = JsonConvert.DeserializeObject<LoggerData>(message);

                callback(cmd);
            };

            channel.BasicConsume(queue: queueName, autoAck: true, consumer: consumer);
        }
    }
}
