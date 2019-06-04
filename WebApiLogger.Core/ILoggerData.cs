using System;
using System.Collections.Generic;
using System.Text;

namespace WebApiLogger.Core
{
    public interface ILoggerData
    {
        Guid ID { get; set; }

        OperationResult Result { get; set; }

        string Method { get; set; }


        string Url { get; set; }


        string IP { get; set; }


        string QueryString { get; set; }


        string FormData { get; set; }


        string Body { get; set; }


        string Cookies { get; set; }

        string ResponseBody { get; set; }

        int StatusCode { get; set; }

        string ErrorTrace { get; set; }

        List<LoggerDataItem> Items { get; set; }


        void AddBusinessLog(string content);


        void AddDbLog(string content);


        void AddNetworkLog(string content);

        void Error();

        void Success();

        void Warning();
    }
}
