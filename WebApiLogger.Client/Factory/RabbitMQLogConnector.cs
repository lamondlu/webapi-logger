using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiLogger.Client.Factory
{
    public class RabbitMQLogConnector : ILogConnector
    {
        public string Name
        {
            get { return "RabbitMQ"; }
        }
    }
}
