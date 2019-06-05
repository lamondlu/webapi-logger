using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiLogger.Client.Factory
{
    public class LogConnectorFactory
    {
        public static ILogConnector GetLogConnector(string name)
        {
            return new RabbitMQLogConnector();
        }
    }
}
