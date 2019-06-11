using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiLogger.Core;

namespace WebApiLogger.Core.Connectors
{
    public interface ILogConnector
    {
        string Name { get; }

        void StartTracking(Action<ILoggerData> callback);
    }
}
