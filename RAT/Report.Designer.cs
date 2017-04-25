namespace RAT
{
    partial class Report
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblWorkEffortRiskFactor = new System.Windows.Forms.Label();
            this.lblLoadDate = new System.Windows.Forms.Label();
            this.dtpLoadDate = new System.Windows.Forms.DateTimePicker();
            this.btnCalculateRisk = new System.Windows.Forms.Button();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.dgvReportData = new System.Windows.Forms.DataGridView();
            this.btnExport = new System.Windows.Forms.Button();
            this.recordIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intersectsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jiraObservationsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStampDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.riskPercentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.riskReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riskReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWorkEffortRiskFactor
            // 
            this.lblWorkEffortRiskFactor.AutoSize = true;
            this.lblWorkEffortRiskFactor.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkEffortRiskFactor.ForeColor = System.Drawing.Color.Black;
            this.lblWorkEffortRiskFactor.Location = new System.Drawing.Point(363, 9);
            this.lblWorkEffortRiskFactor.Name = "lblWorkEffortRiskFactor";
            this.lblWorkEffortRiskFactor.Size = new System.Drawing.Size(322, 32);
            this.lblWorkEffortRiskFactor.TabIndex = 0;
            this.lblWorkEffortRiskFactor.Text = "Work Effort Risk Factor";
            // 
            // lblLoadDate
            // 
            this.lblLoadDate.AutoSize = true;
            this.lblLoadDate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadDate.Location = new System.Drawing.Point(287, 100);
            this.lblLoadDate.Name = "lblLoadDate";
            this.lblLoadDate.Size = new System.Drawing.Size(113, 22);
            this.lblLoadDate.TabIndex = 1;
            this.lblLoadDate.Text = "Load Date : ";
            // 
            // dtpLoadDate
            // 
            this.dtpLoadDate.CustomFormat = "MM/dd/yyyy";
            this.dtpLoadDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLoadDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLoadDate.Location = new System.Drawing.Point(406, 100);
            this.dtpLoadDate.Name = "dtpLoadDate";
            this.dtpLoadDate.Size = new System.Drawing.Size(179, 26);
            this.dtpLoadDate.TabIndex = 2;
            this.dtpLoadDate.ValueChanged += new System.EventHandler(this.dtpLoadDate_ValueChanged);
            // 
            // btnCalculateRisk
            // 
            this.btnCalculateRisk.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateRisk.Location = new System.Drawing.Point(603, 99);
            this.btnCalculateRisk.Name = "btnCalculateRisk";
            this.btnCalculateRisk.Size = new System.Drawing.Size(130, 26);
            this.btnCalculateRisk.TabIndex = 3;
            this.btnCalculateRisk.Text = "Calculate Risk";
            this.btnCalculateRisk.UseVisualStyleBackColor = true;
            this.btnCalculateRisk.Click += new System.EventHandler(this.btnCalculateRisk_Click);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(386, 155);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(0, 19);
            this.lblErrorMessage.TabIndex = 6;
            this.lblErrorMessage.Visible = false;
            // 
            // dgvReportData
            // 
            this.dgvReportData.AllowUserToAddRows = false;
            this.dgvReportData.AllowUserToDeleteRows = false;
            this.dgvReportData.AutoGenerateColumns = false;
            this.dgvReportData.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvReportData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReportData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReportData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReportData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recordIDDataGridViewTextBoxColumn,
            this.restagesDataGridViewTextBoxColumn,
            this.programCountDataGridViewTextBoxColumn,
            this.intersectsDataGridViewTextBoxColumn,
            this.jiraObservationsDataGridViewTextBoxColumn,
            this.timeStampDataGridViewTextBoxColumn,
            this.riskPercentageDataGridViewTextBoxColumn});
            this.dgvReportData.DataSource = this.riskReportBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReportData.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReportData.GridColor = System.Drawing.SystemColors.InactiveBorder;
            this.dgvReportData.Location = new System.Drawing.Point(12, 216);
            this.dgvReportData.MultiSelect = false;
            this.dgvReportData.Name = "dgvReportData";
            this.dgvReportData.ReadOnly = true;
            this.dgvReportData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReportData.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReportData.ShowEditingIcon = false;
            this.dgvReportData.Size = new System.Drawing.Size(1004, 383);
            this.dgvReportData.TabIndex = 7;
            this.dgvReportData.Visible = false;
            this.dgvReportData.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvReportData_CellFormatting);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(814, 99);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(76, 26);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Visible = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // recordIDDataGridViewTextBoxColumn
            // 
            this.recordIDDataGridViewTextBoxColumn.DataPropertyName = "RecordID";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.recordIDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.recordIDDataGridViewTextBoxColumn.HeaderText = "Work Efforts";
            this.recordIDDataGridViewTextBoxColumn.Name = "recordIDDataGridViewTextBoxColumn";
            this.recordIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.recordIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // restagesDataGridViewTextBoxColumn
            // 
            this.restagesDataGridViewTextBoxColumn.DataPropertyName = "Restages";
            this.restagesDataGridViewTextBoxColumn.HeaderText = "Restages";
            this.restagesDataGridViewTextBoxColumn.Name = "restagesDataGridViewTextBoxColumn";
            this.restagesDataGridViewTextBoxColumn.ReadOnly = true;
            this.restagesDataGridViewTextBoxColumn.Width = 120;
            // 
            // programCountDataGridViewTextBoxColumn
            // 
            this.programCountDataGridViewTextBoxColumn.DataPropertyName = "Program_Count";
            this.programCountDataGridViewTextBoxColumn.HeaderText = "Program Count";
            this.programCountDataGridViewTextBoxColumn.Name = "programCountDataGridViewTextBoxColumn";
            this.programCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.programCountDataGridViewTextBoxColumn.Width = 130;
            // 
            // intersectsDataGridViewTextBoxColumn
            // 
            this.intersectsDataGridViewTextBoxColumn.DataPropertyName = "Intersects";
            this.intersectsDataGridViewTextBoxColumn.HeaderText = "Intersects";
            this.intersectsDataGridViewTextBoxColumn.Name = "intersectsDataGridViewTextBoxColumn";
            this.intersectsDataGridViewTextBoxColumn.ReadOnly = true;
            this.intersectsDataGridViewTextBoxColumn.Width = 110;
            // 
            // jiraObservationsDataGridViewTextBoxColumn
            // 
            this.jiraObservationsDataGridViewTextBoxColumn.DataPropertyName = "Jira_Observations";
            this.jiraObservationsDataGridViewTextBoxColumn.HeaderText = "Jira Observation";
            this.jiraObservationsDataGridViewTextBoxColumn.Name = "jiraObservationsDataGridViewTextBoxColumn";
            this.jiraObservationsDataGridViewTextBoxColumn.ReadOnly = true;
            this.jiraObservationsDataGridViewTextBoxColumn.Width = 150;
            // 
            // timeStampDataGridViewTextBoxColumn
            // 
            this.timeStampDataGridViewTextBoxColumn.DataPropertyName = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn.HeaderText = "TimeStamp";
            this.timeStampDataGridViewTextBoxColumn.Name = "timeStampDataGridViewTextBoxColumn";
            this.timeStampDataGridViewTextBoxColumn.ReadOnly = true;
            this.timeStampDataGridViewTextBoxColumn.Width = 130;
            // 
            // riskPercentageDataGridViewTextBoxColumn
            // 
            this.riskPercentageDataGridViewTextBoxColumn.DataPropertyName = "Risk_Percentage";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.riskPercentageDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.riskPercentageDataGridViewTextBoxColumn.HeaderText = "Risk Percentage (%)";
            this.riskPercentageDataGridViewTextBoxColumn.Name = "riskPercentageDataGridViewTextBoxColumn";
            this.riskPercentageDataGridViewTextBoxColumn.ReadOnly = true;
            this.riskPercentageDataGridViewTextBoxColumn.Width = 150;
            // 
            // riskReportBindingSource
            // 
            this.riskReportBindingSource.DataSource = typeof(RAT.RiskReport);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 611);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.dgvReportData);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.btnCalculateRisk);
            this.Controls.Add(this.dtpLoadDate);
            this.Controls.Add(this.lblLoadDate);
            this.Controls.Add(this.lblWorkEffortRiskFactor);
            this.Name = "Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReportData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riskReportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWorkEffortRiskFactor;
        private System.Windows.Forms.Label lblLoadDate;
        private System.Windows.Forms.DateTimePicker dtpLoadDate;
        private System.Windows.Forms.Button btnCalculateRisk;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.DataGridView dgvReportData;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.BindingSource riskReportBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn recordIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn restagesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intersectsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jiraObservationsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeStampDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn riskPercentageDataGridViewTextBoxColumn;
    }
}