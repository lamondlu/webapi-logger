using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiLogger.Core
{
    public class LoggerData : ILoggerData
    {
        public LoggerData()
        {
            Items = new List<LoggerDataItem>();
            ID = Guid.NewGuid();
        }

        public List<LoggerDataItem> Items { get; set; }

        public Guid ID
        {
            get; set;
        }

        public OperationResult Result { get; set; }

        public string Method { get; set; }


        public string Url { get; set; }


        public string IP { get; set; }


        public string QueryString { get; set; }


        public string FormData { get; set; }


        public string Body { get; set; }

        public string ResponseBody { get; set; }

        public int StatusCode { get; set; }

        public string ErrorTrace { get; set; }


        public string Cookies { get; set; }


        public void AddBusinessLog(string content)
        {
            Items.Add(new LoggerDataItem(LogType.Business, content));
        }

        public void AddDbLog(string content)
        {
            Items.Add(new LoggerDataItem(LogType.Query, content));
        }

        public void AddNetworkLog(string content)
        {
            Items.Add(new LoggerDataItem(LogType.Network, content));
        }

        public void Error()
        {
            Result = OperationResult.Error;
        }

        public void Success()
        {
            Result = OperationResult.Success;
        }

        public void Warning()
        {
            Result = OperationResult.Warning;
        }
    }
}
