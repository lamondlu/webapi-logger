using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiLogger.Client.Configuration;

namespace WebApiLogger.Client.Factory
{
    public class LogConnectorFactory
    {
        private static List<ILogConnector> _connectors = new List<ILogConnector>()
        {
            new RabbitMQLogConnector()
        };

        public static ILogConnector GetLogConnector()
        {
            var config = ConfigurationAccessor.GetConfig();

            foreach (var connector in _connectors)
            {
                if (config.Source == connector.Name)
                {
                    return connector;
                }
            }

            throw new ConfigurationException("This is no matched connector.");
        }
    }
}
