namespace WebApiLogger.Client
{
    partial class frmDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabInfo = new System.Windows.Forms.TabControl();
            this.tpNetwork = new System.Windows.Forms.TabPage();
            this.tp = new System.Windows.Forms.TabPage();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabDB = new System.Windows.Forms.TabPage();
            this.tbNetworkLogs = new System.Windows.Forms.TextBox();
            this.tbBusinessLogs = new System.Windows.Forms.TextBox();
            this.tbDBLogs = new System.Windows.Forms.TextBox();
            this.tabFormData = new System.Windows.Forms.TabPage();
            this.tabQueryString = new System.Windows.Forms.TabPage();
            this.tabRequestBody = new System.Windows.Forms.TabPage();
            this.tbFormData = new System.Windows.Forms.TextBox();
            this.tbQueryString = new System.Windows.Forms.TextBox();
            this.tbRequestBody = new System.Windows.Forms.TextBox();
            this.tabResponseBody = new System.Windows.Forms.TabPage();
            this.tbResponseBody = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.tabError = new System.Windows.Forms.TabPage();
            this.tbError = new System.Windows.Forms.TextBox();
            this.lblUrlValue = new System.Windows.Forms.Label();
            this.lblMethod = new System.Windows.Forms.Label();
            this.lblStatusCode = new System.Windows.Forms.Label();
            this.tabInfo.SuspendLayout();
            this.tpNetwork.SuspendLayout();
            this.tp.SuspendLayout();
            this.tabDB.SuspendLayout();
            this.tabFormData.SuspendLayout();
            this.tabQueryString.SuspendLayout();
            this.tabRequestBody.SuspendLayout();
            this.tabResponseBody.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabError.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.tpNetwork);
            this.tabInfo.Controls.Add(this.tp);
            this.tabInfo.Controls.Add(this.tabDB);
            this.tabInfo.Controls.Add(this.tabFormData);
            this.tabInfo.Controls.Add(this.tabQueryString);
            this.tabInfo.Controls.Add(this.tabRequestBody);
            this.tabInfo.Controls.Add(this.tabResponseBody);
            this.tabInfo.Controls.Add(this.tabError);
            this.tabInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabInfo.Location = new System.Drawing.Point(11, 181);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.SelectedIndex = 0;
            this.tabInfo.Size = new System.Drawing.Size(852, 444);
            this.tabInfo.TabIndex = 0;
            // 
            // tpNetwork
            // 
            this.tpNetwork.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpNetwork.Controls.Add(this.tbNetworkLogs);
            this.tpNetwork.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tpNetwork.Location = new System.Drawing.Point(4, 29);
            this.tpNetwork.Name = "tpNetwork";
            this.tpNetwork.Padding = new System.Windows.Forms.Padding(3);
            this.tpNetwork.Size = new System.Drawing.Size(844, 411);
            this.tpNetwork.TabIndex = 0;
            this.tpNetwork.Text = "网络日志";
            this.tpNetwork.UseVisualStyleBackColor = true;
            // 
            // tp
            // 
            this.tp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tp.Controls.Add(this.tbBusinessLogs);
            this.tp.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tp.Location = new System.Drawing.Point(4, 25);
            this.tp.Name = "tp";
            this.tp.Padding = new System.Windows.Forms.Padding(3);
            this.tp.Size = new System.Drawing.Size(756, 540);
            this.tp.TabIndex = 1;
            this.tp.Text = "业务日志";
            this.tp.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.Location = new System.Drawing.Point(774, 631);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 41);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // tabDB
            // 
            this.tabDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabDB.Controls.Add(this.tbDBLogs);
            this.tabDB.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabDB.Location = new System.Drawing.Point(4, 25);
            this.tabDB.Name = "tabDB";
            this.tabDB.Padding = new System.Windows.Forms.Padding(3);
            this.tabDB.Size = new System.Drawing.Size(736, 342);
            this.tabDB.TabIndex = 2;
            this.tabDB.Text = "数据库日志";
            this.tabDB.UseVisualStyleBackColor = true;
            // 
            // tbNetworkLogs
            // 
            this.tbNetworkLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbNetworkLogs.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbNetworkLogs.Location = new System.Drawing.Point(3, 3);
            this.tbNetworkLogs.Multiline = true;
            this.tbNetworkLogs.Name = "tbNetworkLogs";
            this.tbNetworkLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNetworkLogs.Size = new System.Drawing.Size(836, 403);
            this.tbNetworkLogs.TabIndex = 0;
            // 
            // tbBusinessLogs
            // 
            this.tbBusinessLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBusinessLogs.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbBusinessLogs.Location = new System.Drawing.Point(3, 3);
            this.tbBusinessLogs.Multiline = true;
            this.tbBusinessLogs.Name = "tbBusinessLogs";
            this.tbBusinessLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbBusinessLogs.Size = new System.Drawing.Size(748, 532);
            this.tbBusinessLogs.TabIndex = 1;
            // 
            // tbDBLogs
            // 
            this.tbDBLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDBLogs.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbDBLogs.Location = new System.Drawing.Point(3, 3);
            this.tbDBLogs.Multiline = true;
            this.tbDBLogs.Name = "tbDBLogs";
            this.tbDBLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDBLogs.Size = new System.Drawing.Size(728, 334);
            this.tbDBLogs.TabIndex = 2;
            // 
            // tabFormData
            // 
            this.tabFormData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabFormData.Controls.Add(this.tbFormData);
            this.tabFormData.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabFormData.Location = new System.Drawing.Point(4, 25);
            this.tabFormData.Name = "tabFormData";
            this.tabFormData.Padding = new System.Windows.Forms.Padding(3);
            this.tabFormData.Size = new System.Drawing.Size(732, 469);
            this.tabFormData.TabIndex = 3;
            this.tabFormData.Text = "Form-Data";
            this.tabFormData.UseVisualStyleBackColor = true;
            // 
            // tabQueryString
            // 
            this.tabQueryString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabQueryString.Controls.Add(this.tbQueryString);
            this.tabQueryString.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabQueryString.Location = new System.Drawing.Point(4, 25);
            this.tabQueryString.Name = "tabQueryString";
            this.tabQueryString.Padding = new System.Windows.Forms.Padding(3);
            this.tabQueryString.Size = new System.Drawing.Size(732, 469);
            this.tabQueryString.TabIndex = 4;
            this.tabQueryString.Text = "QueryString";
            this.tabQueryString.UseVisualStyleBackColor = true;
            // 
            // tabRequestBody
            // 
            this.tabRequestBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabRequestBody.Controls.Add(this.tbRequestBody);
            this.tabRequestBody.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabRequestBody.Location = new System.Drawing.Point(4, 29);
            this.tabRequestBody.Name = "tabRequestBody";
            this.tabRequestBody.Padding = new System.Windows.Forms.Padding(3);
            this.tabRequestBody.Size = new System.Drawing.Size(844, 411);
            this.tabRequestBody.TabIndex = 5;
            this.tabRequestBody.Text = "Request Body";
            this.tabRequestBody.UseVisualStyleBackColor = true;
            // 
            // tbFormData
            // 
            this.tbFormData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbFormData.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbFormData.Location = new System.Drawing.Point(3, 3);
            this.tbFormData.Multiline = true;
            this.tbFormData.Name = "tbFormData";
            this.tbFormData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbFormData.Size = new System.Drawing.Size(724, 461);
            this.tbFormData.TabIndex = 3;
            // 
            // tbQueryString
            // 
            this.tbQueryString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbQueryString.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbQueryString.Location = new System.Drawing.Point(3, 3);
            this.tbQueryString.Multiline = true;
            this.tbQueryString.Name = "tbQueryString";
            this.tbQueryString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbQueryString.Size = new System.Drawing.Size(724, 461);
            this.tbQueryString.TabIndex = 3;
            // 
            // tbRequestBody
            // 
            this.tbRequestBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRequestBody.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbRequestBody.Location = new System.Drawing.Point(3, 3);
            this.tbRequestBody.Multiline = true;
            this.tbRequestBody.Name = "tbRequestBody";
            this.tbRequestBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbRequestBody.Size = new System.Drawing.Size(836, 403);
            this.tbRequestBody.TabIndex = 3;
            // 
            // tabResponseBody
            // 
            this.tabResponseBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabResponseBody.Controls.Add(this.tbResponseBody);
            this.tabResponseBody.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabResponseBody.Location = new System.Drawing.Point(4, 29);
            this.tabResponseBody.Name = "tabResponseBody";
            this.tabResponseBody.Padding = new System.Windows.Forms.Padding(3);
            this.tabResponseBody.Size = new System.Drawing.Size(844, 411);
            this.tabResponseBody.TabIndex = 6;
            this.tabResponseBody.Text = "Response Body";
            this.tabResponseBody.UseVisualStyleBackColor = true;
            // 
            // tbResponseBody
            // 
            this.tbResponseBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbResponseBody.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbResponseBody.Location = new System.Drawing.Point(3, 3);
            this.tbResponseBody.Multiline = true;
            this.tbResponseBody.Name = "tbResponseBody";
            this.tbResponseBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbResponseBody.Size = new System.Drawing.Size(836, 403);
            this.tbResponseBody.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblStatusCode);
            this.groupBox1.Controls.Add(this.lblMethod);
            this.groupBox1.Controls.Add(this.lblUrlValue);
            this.groupBox1.Controls.Add(this.lblUrl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(16, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 149);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " 请求基本信息";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(29, 36);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(68, 20);
            this.lblUrl.TabIndex = 3;
            this.lblUrl.Text = "请求Url: ";
            // 
            // tabError
            // 
            this.tabError.Controls.Add(this.tbError);
            this.tabError.Location = new System.Drawing.Point(4, 29);
            this.tabError.Name = "tabError";
            this.tabError.Padding = new System.Windows.Forms.Padding(3);
            this.tabError.Size = new System.Drawing.Size(844, 411);
            this.tabError.TabIndex = 7;
            this.tabError.Text = "错误信息";
            this.tabError.UseVisualStyleBackColor = true;
            // 
            // tbError
            // 
            this.tbError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbError.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbError.Location = new System.Drawing.Point(3, 3);
            this.tbError.Multiline = true;
            this.tbError.Name = "tbError";
            this.tbError.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbError.Size = new System.Drawing.Size(838, 405);
            this.tbError.TabIndex = 6;
            // 
            // lblUrlValue
            // 
            this.lblUrlValue.AutoSize = true;
            this.lblUrlValue.Location = new System.Drawing.Point(103, 36);
            this.lblUrlValue.Name = "lblUrlValue";
            this.lblUrlValue.Size = new System.Drawing.Size(0, 20);
            this.lblUrlValue.TabIndex = 4;
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Location = new System.Drawing.Point(29, 72);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(77, 20);
            this.lblMethod.TabIndex = 5;
            this.lblMethod.Text = "请求方式: ";
            // 
            // lblStatusCode
            // 
            this.lblStatusCode.AutoSize = true;
            this.lblStatusCode.Location = new System.Drawing.Point(29, 106);
            this.lblStatusCode.Name = "lblStatusCode";
            this.lblStatusCode.Size = new System.Drawing.Size(99, 20);
            this.lblStatusCode.TabIndex = 6;
            this.lblStatusCode.Text = "返回状态码：";
            // 
            // frmDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 687);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.tabInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDetail";
            this.Text = "详细信息";
            this.Load += new System.EventHandler(this.FrmDetail_Load);
            this.tabInfo.ResumeLayout(false);
            this.tpNetwork.ResumeLayout(false);
            this.tpNetwork.PerformLayout();
            this.tp.ResumeLayout(false);
            this.tp.PerformLayout();
            this.tabDB.ResumeLayout(false);
            this.tabDB.PerformLayout();
            this.tabFormData.ResumeLayout(false);
            this.tabFormData.PerformLayout();
            this.tabQueryString.ResumeLayout(false);
            this.tabQueryString.PerformLayout();
            this.tabRequestBody.ResumeLayout(false);
            this.tabRequestBody.PerformLayout();
            this.tabResponseBody.ResumeLayout(false);
            this.tabResponseBody.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabError.ResumeLayout(false);
            this.tabError.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabInfo;
        private System.Windows.Forms.TabPage tpNetwork;
        private System.Windows.Forms.TabPage tp;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabPage tabDB;
        private System.Windows.Forms.TextBox tbNetworkLogs;
        private System.Windows.Forms.TextBox tbBusinessLogs;
        private System.Windows.Forms.TextBox tbDBLogs;
        private System.Windows.Forms.TabPage tabFormData;
        private System.Windows.Forms.TabPage tabQueryString;
        private System.Windows.Forms.TabPage tabRequestBody;
        private System.Windows.Forms.TextBox tbFormData;
        private System.Windows.Forms.TextBox tbQueryString;
        private System.Windows.Forms.TextBox tbRequestBody;
        private System.Windows.Forms.TabPage tabResponseBody;
        private System.Windows.Forms.TextBox tbResponseBody;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TabPage tabError;
        private System.Windows.Forms.TextBox tbError;
        private System.Windows.Forms.Label lblUrlValue;
        private System.Windows.Forms.Label lblStatusCode;
        private System.Windows.Forms.Label lblMethod;
    }
}