using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebApiLogger.Core;

namespace WebApiLogger.Client
{
    public partial class frmDetail : Form
    {
        private ILoggerData _loggerData = null;

        public frmDetail(ILoggerData loggerData)
        {
            _loggerData = loggerData;
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDetail_Load(object sender, EventArgs e)
        {
            lblUrl.Text = $"请求Url: {_loggerData.Url}";

            lblMethod.Text = $"请求方式: {_loggerData.Method.ToUpper().ToString()}";
            lblStatusCode.Text = $"返回状态码：{_loggerData.StatusCode.ToString()}";

            PrepareNetworkLogs(_loggerData);
            PrepareBusinessLogs(_loggerData);
            PrepareDBLogs(_loggerData);

            PrepareFormData(_loggerData);
            PrepareQuerystring(_loggerData);
            PrepareRequestBody(_loggerData);

            tbResponseBody.Text = _loggerData.ResponseBody;
        }

        private void PrepareRequestBody(ILoggerData loggerData)
        {
            if (string.IsNullOrEmpty(loggerData.Body)) return;

            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(loggerData.Body);

            tbRequestBody.Text = stringBuilder.ToString();

        }

        private void PrepareQuerystring(ILoggerData loggerData)
        {
            if (string.IsNullOrEmpty(loggerData.QueryString)) return;

            var stringBuilder = new StringBuilder();

            foreach (var item in loggerData.QueryString.Split(';'))
            {
                var key = item.Split(':')[0];
                var value = item.Split(':')[1];

                stringBuilder.AppendLine($"{key}:{value}");
            }

            tbRequestBody.Text = stringBuilder.ToString();
        }

        private void PrepareFormData(ILoggerData loggerData)
        {
            if (string.IsNullOrEmpty(loggerData.FormData)) return;

            var stringBuilder = new StringBuilder();

            foreach (var item in loggerData.FormData.Split(';'))
            {
                var key = item.Split(':')[0];
                var value = item.Split(':')[1];

                stringBuilder.AppendLine($"{key}:{value}");
            }

            tbRequestBody.Text = stringBuilder.ToString();
        }

        private void PrepareNetworkLogs(ILoggerData loggerData)
        {
            var stringBuilder = new StringBuilder();

            foreach (var item in loggerData.Items.Where(p => p.LogType == LogType.Network))
            {
                stringBuilder.AppendLine($"{item.Content}");
                stringBuilder.AppendLine("-----------------------");
            }

            tbNetworkLogs.Text = stringBuilder.ToString();
        }

        private void PrepareBusinessLogs(ILoggerData loggerData)
        {
            var stringBuilder = new StringBuilder();

            foreach (var item in loggerData.Items.Where(p => p.LogType == LogType.Business))
            {
                stringBuilder.AppendLine($"{item.Content}");
                stringBuilder.AppendLine("-----------------------");
            }

            tbBusinessLogs.Text = stringBuilder.ToString();
        }

        private void PrepareDBLogs(ILoggerData loggerData)
        {
            var stringBuilder = new StringBuilder();

            foreach (var item in loggerData.Items.Where(p => p.LogType == LogType.Query))
            {
                stringBuilder.AppendLine($"{item.Content}");
                stringBuilder.AppendLine("-----------------------");
            }

            tbDBLogs.Text = stringBuilder.ToString();
        }
    }
}
