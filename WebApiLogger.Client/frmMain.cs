using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebApiLogger.Core;

namespace WebApiLogger.Client
{
    public partial class frmLogger : Form
    {
        private List<ILoggerData> _loggerDatas = new List<ILoggerData>();
        private bool _isStart = false;
        private Thread _thread = null;

        private delegate void FlushClient(ILoggerData data);

        private void UpdateListData(ILoggerData data)
        {
            if (this.dgvLogs.InvokeRequired)
            {
                FlushClient fc = new FlushClient(UpdateListData);
                this.Invoke(fc, data);
            }
            else
            {
                _loggerDatas.Add(data);

                var rowId = dgvLogs.Rows.Add();
                dgvLogs.Rows[rowId].Cells[0].Value = data.ID;
                dgvLogs.Rows[rowId].Cells[1].Value = data.Method.ToUpper();
                dgvLogs.Rows[rowId].Cells[2].Value = data.Url;
                dgvLogs.Rows[rowId].Cells[3].Value = data.Result;
                dgvLogs.Rows[rowId].Cells[4].Value = data.StatusCode;
                dgvLogs.Rows[rowId].Cells[5].Value = data.ErrorTrace;
            }
        }


        public frmLogger()
        {
            InitializeComponent();
        }

        private void FrmLogger_Load(object sender, EventArgs e)
        {

        }

        public void Start()
        {
            var factory = new ConnectionFactory() { Uri = new Uri("amqp://172.27.0.189:5672"), UserName = "guest", Password = "guest" };

            IConnection connection = factory.CreateConnection();
            IModel channel = connection.CreateModel();

            var queueName = channel.QueueDeclare().QueueName;

            channel.QueueBind(queue: queueName, exchange: "WebApiLoggerEventQueue", routingKey: "");

            var consumer = new EventingBasicConsumer(channel);

            consumer.Received += (model, ea) =>
            {
                var body = ea.Body;
                var message = Encoding.UTF8.GetString(body);

                var cmd = JsonConvert.DeserializeObject<LoggerData>(message);

                UpdateListData(cmd);
            };

            channel.BasicConsume(queue: queueName, autoAck: true, consumer: consumer);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (!_isStart)
            {
                _isStart = true;
                btnStart.Text = "停止监听";
                _thread = new Thread(Start);

                _thread.Start();
            }
            else
            {
                _isStart = false;
                btnStart.Text = "开始监听";
                _thread.Abort();
                _thread = null;
            }
        }

        private void DgvLogs_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var currentRow = e.RowIndex;

            if (currentRow > -1)
            {
                var id = Guid.Parse(dgvLogs.Rows[currentRow].Cells[0].Value.ToString());

                var currentLog = _loggerDatas.First(p => p.ID == id);

                frmDetail details = new frmDetail(currentLog);
                details.ShowDialog();
            }
        }
    }
}
