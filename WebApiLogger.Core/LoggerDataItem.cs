using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiLogger.Core
{
    [Serializable]
    public class LoggerDataItem
    {
        public LoggerDataItem(LogType logType, string content)
        {
            LogType = logType;
            Content = content;
        }

        public LogType LogType { get; set; }

        public string Content { get; set; }
    }
}
