using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiLogger.Host
{
    public class LogSetting
    {
        public string RabbitMQUrl { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string QueueName { get; set; }
    }
}
