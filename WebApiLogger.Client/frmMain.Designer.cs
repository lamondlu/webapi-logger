namespace WebApiLogger.Client
{
    partial class frmLogger
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
            this.btnStart = new System.Windows.Forms.Button();
            this.gbLogs = new System.Windows.Forms.GroupBox();
            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.事件源配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAboutUs = new System.Windows.Forms.ToolStripMenuItem();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(930, 29);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 39);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start tracking";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // gbLogs
            // 
            this.gbLogs.Controls.Add(this.dgvLogs);
            this.gbLogs.Location = new System.Drawing.Point(14, 69);
            this.gbLogs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbLogs.Name = "gbLogs";
            this.gbLogs.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbLogs.Size = new System.Drawing.Size(1031, 446);
            this.gbLogs.TabIndex = 3;
            this.gbLogs.TabStop = false;
            this.gbLogs.Text = "Logs";
            // 
            // dgvLogs
            // 
            this.dgvLogs.AllowUserToAddRows = false;
            this.dgvLogs.AllowUserToDeleteRows = false;
            this.dgvLogs.AllowUserToResizeColumns = false;
            this.dgvLogs.AllowUserToResizeRows = false;
            this.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLogs.Location = new System.Drawing.Point(3, 20);
            this.dgvLogs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.ReadOnly = true;
            this.dgvLogs.RowHeadersVisible = false;
            this.dgvLogs.RowHeadersWidth = 51;
            this.dgvLogs.RowTemplate.Height = 27;
            this.dgvLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLogs.Size = new System.Drawing.Size(1025, 422);
            this.dgvLogs.TabIndex = 0;
            this.dgvLogs.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvLogs_CellMouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem,
            this.tsmiAboutUs});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1060, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.事件源配置ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.设置ToolStripMenuItem.Text = "Settings";
            // 
            // 事件源配置ToolStripMenuItem
            // 
            this.事件源配置ToolStripMenuItem.Name = "事件源配置ToolStripMenuItem";
            this.事件源配置ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.事件源配置ToolStripMenuItem.Text = "Data Source";
            // 
            // tsmiAboutUs
            // 
            this.tsmiAboutUs.Name = "tsmiAboutUs";
            this.tsmiAboutUs.Size = new System.Drawing.Size(72, 20);
            this.tsmiAboutUs.Text = "About Me";
            this.tsmiAboutUs.Click += new System.EventHandler(this.tsmiAboutUs_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "Request ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Method";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Url";
            this.Column2.HeaderText = "Request URL";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Result";
            this.Column3.HeaderText = "Result";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "StatusCode";
            this.Column4.HeaderText = "Status Code";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // frmLogger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 528);
            this.Controls.Add(this.gbLogs);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogger";
            this.Text = "ASP.NET Core Logger";
            this.Load += new System.EventHandler(this.FrmLogger_Load);
            this.gbLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox gbLogs;
        private System.Windows.Forms.DataGridView dgvLogs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 事件源配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAboutUs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

