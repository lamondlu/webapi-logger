using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiLogger.Client.Configuration;
using WebApiLogger.Connector.RabbitMQ;
using WebApiLogger.Core.Connectors;

namespace WebApiLogger.Client.Factory
{
    public class LogConnectorFactory
    {
        public static ILogConnector GetLogConnector()
        {
            var config = ConfigurationAccessor.GetConfig();

            if (config.SourceName == "RabbitMQ")
            {
                return new RabbitMQLogConnector(config as RabbitMQConfiguration);
            }


            throw new ConfigurationException("This is no matched connector.");
        }
    }
}
