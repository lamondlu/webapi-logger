using System;
using System.Collections.Generic;
using System.Text;
using WebApiLogger.Core.Configurations;

namespace WebApiLogger.Connector.RabbitMQ
{
    public class RabbitMQConfiguration : IConfiguration
    {
        public string Url { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string QueueName { get; set; }

        public string SourceName
        {
            get { return "RabbitMQ"; }
        }
    }
}
