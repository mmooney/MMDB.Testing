namespace MMDB.Testing.WebsiteBeaterUpper
{
	partial class MainForm
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
			this.label1 = new System.Windows.Forms.Label();
			this._cboUrl = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this._numThreadCount = new System.Windows.Forms.NumericUpDown();
			this._numRunsPerThreadCount = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this._btnGo = new System.Windows.Forms.Button();
			this._grdData = new System.Windows.Forms.DataGridView();
			this._btnCancel = new System.Windows.Forms.Button();
			this._colThreadNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._colThreadID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._colRequestedCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._colRunsComplete = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._colFailedCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._colSuccessCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._colRunsRemainingCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._colAverageResponseTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this._numThreadCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._numRunsPerThreadCount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._grdData)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(76, 15);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "URL:";
			// 
			// _cboUrl
			// 
			this._cboUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._cboUrl.FormattingEnabled = true;
			this._cboUrl.Location = new System.Drawing.Point(110, 13);
			this._cboUrl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this._cboUrl.Name = "_cboUrl";
			this._cboUrl.Size = new System.Drawing.Size(552, 21);
			this._cboUrl.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(34, 41);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "# Of Threads:";
			// 
			// _numThreadCount
			// 
			this._numThreadCount.Location = new System.Drawing.Point(110, 37);
			this._numThreadCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this._numThreadCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this._numThreadCount.Name = "_numThreadCount";
			this._numThreadCount.Size = new System.Drawing.Size(90, 20);
			this._numThreadCount.TabIndex = 3;
			this._numThreadCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// _numRunsPerThreadCount
			// 
			this._numRunsPerThreadCount.Location = new System.Drawing.Point(110, 58);
			this._numRunsPerThreadCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this._numRunsPerThreadCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this._numRunsPerThreadCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this._numRunsPerThreadCount.Name = "_numRunsPerThreadCount";
			this._numRunsPerThreadCount.Size = new System.Drawing.Size(90, 20);
			this._numRunsPerThreadCount.TabIndex = 5;
			this._numRunsPerThreadCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(11, 59);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(98, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "# Of Runs/Thread:";
			// 
			// _btnGo
			// 
			this._btnGo.Enabled = false;
			this._btnGo.Location = new System.Drawing.Point(209, 84);
			this._btnGo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this._btnGo.Name = "_btnGo";
			this._btnGo.Size = new System.Drawing.Size(94, 34);
			this._btnGo.TabIndex = 6;
			this._btnGo.Text = "Giddy Up";
			this._btnGo.UseVisualStyleBackColor = true;
			this._btnGo.Click += new System.EventHandler(this._btnGo_Click);
			// 
			// _grdData
			// 
			this._grdData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._colThreadNumber,
            this._colThreadID,
            this._colRequestedCount,
            this._colRunsComplete,
            this._colFailedCount,
            this._colSuccessCount,
            this._colRunsRemainingCount,
            this._colAverageResponseTime});
			this._grdData.Location = new System.Drawing.Point(20, 122);
			this._grdData.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this._grdData.Name = "_grdData";
			this._grdData.RowTemplate.Height = 24;
			this._grdData.Size = new System.Drawing.Size(641, 260);
			this._grdData.TabIndex = 7;
			// 
			// _btnCancel
			// 
			this._btnCancel.Enabled = false;
			this._btnCancel.Location = new System.Drawing.Point(307, 84);
			this._btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this._btnCancel.Name = "_btnCancel";
			this._btnCancel.Size = new System.Drawing.Size(101, 34);
			this._btnCancel.TabIndex = 8;
			this._btnCancel.Text = "Stop It";
			this._btnCancel.UseVisualStyleBackColor = true;
			this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
			// 
			// _colThreadNumber
			// 
			this._colThreadNumber.DataPropertyName = "ThreadNumber";
			this._colThreadNumber.HeaderText = "Thread#";
			this._colThreadNumber.Name = "_colThreadNumber";
			this._colThreadNumber.ReadOnly = true;
			// 
			// _colThreadID
			// 
			this._colThreadID.DataPropertyName = "ThreadId";
			this._colThreadID.HeaderText = "Thread ID";
			this._colThreadID.Name = "_colThreadID";
			this._colThreadID.ReadOnly = true;
			// 
			// _colRequestedCount
			// 
			this._colRequestedCount.DataPropertyName = "RequestedRunCount";
			this._colRequestedCount.HeaderText = "Runs Requested";
			this._colRequestedCount.Name = "_colRequestedCount";
			this._colRequestedCount.ReadOnly = true;
			// 
			// _colRunsComplete
			// 
			this._colRunsComplete.DataPropertyName = "CompleteCount";
			this._colRunsComplete.HeaderText = "Runs Complete";
			this._colRunsComplete.Name = "_colRunsComplete";
			this._colRunsComplete.ReadOnly = true;
			// 
			// _colFailedCount
			// 
			this._colFailedCount.DataPropertyName = "FailedCount";
			this._colFailedCount.HeaderText = "Failed";
			this._colFailedCount.Name = "_colFailedCount";
			this._colFailedCount.ReadOnly = true;
			// 
			// _colSuccessCount
			// 
			this._colSuccessCount.DataPropertyName = "SuccessCount";
			this._colSuccessCount.HeaderText = "Success";
			this._colSuccessCount.Name = "_colSuccessCount";
			this._colSuccessCount.ReadOnly = true;
			// 
			// _colRunsRemainingCount
			// 
			this._colRunsRemainingCount.DataPropertyName = "RemainingCount";
			this._colRunsRemainingCount.HeaderText = "Remaining";
			this._colRunsRemainingCount.Name = "_colRunsRemainingCount";
			this._colRunsRemainingCount.ReadOnly = true;
			// 
			// _colAverageResponseTime
			// 
			this._colAverageResponseTime.DataPropertyName = "AverageResponseTimeMilliseconds";
			this._colAverageResponseTime.HeaderText = "Avg Response Time";
			this._colAverageResponseTime.Name = "_colAverageResponseTime";
			this._colAverageResponseTime.ReadOnly = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 401);
			this.Controls.Add(this._btnCancel);
			this.Controls.Add(this._grdData);
			this.Controls.Add(this._btnGo);
			this.Controls.Add(this._numRunsPerThreadCount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this._numThreadCount);
			this.Controls.Add(this.label2);
			this.Controls.Add(this._cboUrl);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "MainForm";
			this.Text = "Website Beater Upper";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			((System.ComponentModel.ISupportInitialize)(this._numThreadCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._numRunsPerThreadCount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._grdData)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox _cboUrl;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown _numThreadCount;
		private System.Windows.Forms.NumericUpDown _numRunsPerThreadCount;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button _btnGo;
		private System.Windows.Forms.DataGridView _grdData;
		private System.Windows.Forms.Button _btnCancel;
		private System.Windows.Forms.DataGridViewTextBoxColumn _colThreadNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn _colThreadID;
		private System.Windows.Forms.DataGridViewTextBoxColumn _colRequestedCount;
		private System.Windows.Forms.DataGridViewTextBoxColumn _colRunsComplete;
		private System.Windows.Forms.DataGridViewTextBoxColumn _colFailedCount;
		private System.Windows.Forms.DataGridViewTextBoxColumn _colSuccessCount;
		private System.Windows.Forms.DataGridViewTextBoxColumn _colRunsRemainingCount;
		private System.Windows.Forms.DataGridViewTextBoxColumn _colAverageResponseTime;
	}
}

