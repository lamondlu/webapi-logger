using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiLogger.Core.Configurations
{
    public interface IConfiguration
    {
        string SourceName { get; }
    }
}
