using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WebApiLogger.Client.Configuration
{
    public class ConfigurationAccessor
    {
        private static string _configPath = "config.json";
        private static Configuration _current = null;

        private static string LoadContent()
        {
            using (var sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + _configPath))
            {
                var content = sr.ReadToEnd();

                return content;
            }
        }

        public static Configuration GetConfig()
        {
            if (_current == null)
            {
                var content = LoadContent();
                _current = JsonConvert.DeserializeObject<Configuration>(content);
            }

            return _current;
        }
    }

    public class Configuration
    {
        public string Source { get; set; }

        public RabbitMQConfiguration RabbitMQ { get; set; }
    }

    public class RabbitMQConfiguration
    {
        public string Url { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string QueueName { get; set; }
    }
}
