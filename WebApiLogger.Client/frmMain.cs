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
using WebApiLogger.Client.Configuration;
using WebApiLogger.Client.Factory;
using WebApiLogger.Core;

namespace WebApiLogger.Client
{
    public partial class frmLogger : Form
    {
        private List<ILoggerData> _loggerDatas = new List<ILoggerData>();
        private List<int> _successCodes = new List<int> { 200, 201, 204 };
        private bool _isStart = false;
        private Thread _thread = null;
        private bool _onlyError = false;

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
                if (data.Method != "OPTIONS")
                {
                    if (!_successCodes.Contains(data.StatusCode))
                    {
                        data.Result = OperationResult.Error;
                        niErrors.BalloonTipTitle = "Error";
                        niErrors.BalloonTipIcon = ToolTipIcon.Error;
                        niErrors.BalloonTipText = $"An error happened on [{data.Method}]{data.Url}.";
                        niErrors.ShowBalloonTip(10000);
                    }

                    _loggerDatas.Add(data);

                    if (data.Result == OperationResult.Error || !_onlyError)
                    {
                        var rowId = dgvLogs.Rows.Add();
                        dgvLogs.Rows[rowId].Cells[0].Value = data.ID;
                        dgvLogs.Rows[rowId].Cells[1].Value = data.Method.ToUpper();
                        dgvLogs.Rows[rowId].Cells[2].Value = data.Url;
                        dgvLogs.Rows[rowId].Cells[3].Value = data.Result;
                        dgvLogs.Rows[rowId].Cells[4].Value = data.StatusCode;
                    }
                }
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
            LogConnectorFactory.GetLogConnector().StartTracking(UpdateListData);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (!_isStart)
            {
                _isStart = true;
                btnStart.Text = "Stop tracking";
                _thread = new Thread(Start);

                _thread.Start();
            }
            else
            {
                _isStart = false;
                btnStart.Text = "Start tracking";
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

        private void tsmiAboutUs_Click(object sender, EventArgs e)
        {
            frmAbout form = new frmAbout();
            form.ShowDialog();
        }

        private void tsmiDataSourceConfiguration_Click(object sender, EventArgs e)
        {
            frmConfig form = new frmConfig();
            form.ShowDialog();
        }

        private void cbOnlyError_CheckedChanged(object sender, EventArgs e)
        {
            if (cbOnlyError.Checked)
            {
                _onlyError = true;
                //dgvLogs.DataSource = _loggerDatas.Where(p => p.Result == OperationResult.Error).ToList();
            }
            else
            {
                _onlyError = false;
                //dgvLogs.DataSource = _loggerDatas.ToList();
            }
        }
    }
}
