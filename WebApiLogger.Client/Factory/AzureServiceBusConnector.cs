using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiLogger.Core;

namespace WebApiLogger.Client.Factory
{
    public class AzureServiceBusConnector : ILogConnector
    {
        public string Name { get; }

        public void StartTracking(Action<ILoggerData> callback)
        {
            throw new NotImplementedException();
        }
    }
}
