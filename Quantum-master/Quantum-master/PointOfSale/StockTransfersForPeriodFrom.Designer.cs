namespace PointOfSale
{
	// Token: 0x020001F9 RID: 505
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class StockTransfersForPeriodFrom : global::System.Windows.Forms.Form
	{
		// Token: 0x06005A76 RID: 23158 RVA: 0x00343300 File Offset: 0x00341500
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06005A77 RID: 23159 RVA: 0x00343350 File Offset: 0x00341550
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.lblBranchTo = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.DTEnddate = new global::System.Windows.Forms.DateTimePicker();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.DTStartdate = new global::System.Windows.Forms.DateTimePicker();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.FetchTransferDetailsFromForPeriodBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.FetchTransferDetailsFromForPeriodTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.FetchTransferDetailsFromForPeriodTableAdapter();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchTransferDetailsFromForPeriodBindingSource).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.lblBranchTo);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.DTEnddate);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.DTStartdate);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Size = new global::System.Drawing.Size(1321, 214);
			this.GroupBox1.TabIndex = 1;
			this.GroupBox1.TabStop = false;
			this.lblBranchTo.AutoSize = true;
			this.lblBranchTo.Location = new global::System.Drawing.Point(669, 108);
			this.lblBranchTo.Name = "lblBranchTo";
			this.lblBranchTo.Size = new global::System.Drawing.Size(21, 20);
			this.lblBranchTo.TabIndex = 21;
			this.lblBranchTo.Text = "...";
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(423, 106);
			this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(220, 20);
			this.Label3.TabIndex = 20;
			this.Label3.Text = "Branch Stocks Transfered To:";
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(423, 146);
			this.Label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(239, 20);
			this.Label5.TabIndex = 18;
			this.Label5.Text = "Branch Stocks Transfered From:";
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(670, 140);
			this.cboBranch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(243, 28);
			this.cboBranch.TabIndex = 17;
			this.Label4.AutoSize = true;
			this.Label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.Location = new global::System.Drawing.Point(21, 38);
			this.Label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(351, 32);
			this.Label4.TabIndex = 16;
			this.Label4.Text = "Stock Transfers For Period";
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(22, 146);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(81, 20);
			this.Label2.TabIndex = 15;
			this.Label2.Text = "End Date:";
			this.DTEnddate.Location = new global::System.Drawing.Point(114, 142);
			this.DTEnddate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTEnddate.Name = "DTEnddate";
			this.DTEnddate.Size = new global::System.Drawing.Size(298, 26);
			this.DTEnddate.TabIndex = 14;
			this.Button1.Location = new global::System.Drawing.Point(924, 138);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(207, 35);
			this.Button1.TabIndex = 13;
			this.Button1.Text = "RUN REPORT";
			this.Button1.UseVisualStyleBackColor = true;
			this.DTStartdate.Location = new global::System.Drawing.Point(114, 102);
			this.DTStartdate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTStartdate.Name = "DTStartdate";
			this.DTStartdate.Size = new global::System.Drawing.Size(298, 26);
			this.DTStartdate.TabIndex = 12;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(18, 106);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(87, 20);
			this.Label1.TabIndex = 11;
			this.Label1.Text = "Start Date:";
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "CompanyDetails";
			reportDataSource.Value = this.GetCompanyDetailsBindingSource;
			reportDataSource2.Name = "Transfers";
			reportDataSource2.Value = this.FetchTransferDetailsFromForPeriodBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.StockTransfersForPeriodFrom.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 214);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(1321, 557);
			this.ReportViewer1.TabIndex = 2;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.FetchTransferDetailsFromForPeriodBindingSource.DataMember = "FetchTransferDetailsFromForPeriod";
			this.FetchTransferDetailsFromForPeriodBindingSource.DataSource = this.POSDataSet;
			this.FetchTransferDetailsFromForPeriodTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1321, 771);
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Name = "StockTransfersForPeriodFrom";
			this.Text = "StockTransfersForPeriodFrom";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchTransferDetailsFromForPeriodBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400277D RID: 10109
		private global::System.ComponentModel.IContainer components;
	}
}
