namespace PointOfSale
{
	// Token: 0x020001F1 RID: 497
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class StockSheetsWarehouse : global::System.Windows.Forms.Form
	{
		// Token: 0x060057BF RID: 22463 RVA: 0x00326E44 File Offset: 0x00325044
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

		// Token: 0x060057C0 RID: 22464 RVA: 0x00326E94 File Offset: 0x00325094
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.CurrentStockLevelsWarehouseReportBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.chkShowAll = new global::System.Windows.Forms.CheckBox();
			this.chkWithFigures = new global::System.Windows.Forms.CheckBox();
			this.chkBins = new global::System.Windows.Forms.CheckBox();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.cbobins = new global::System.Windows.Forms.ComboBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.DTStartdate = new global::System.Windows.Forms.DateTimePicker();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.CurrentStockLevelsWarehouseReportTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.CurrentStockLevelsWarehouseReportTableAdapter();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.CurrentStockLevelsWarehouseReportBindingSource).BeginInit();
			this.GroupBox1.SuspendLayout();
			base.SuspendLayout();
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.CurrentStockLevelsWarehouseReportBindingSource.DataMember = "CurrentStockLevelsWarehouseReport";
			this.CurrentStockLevelsWarehouseReportBindingSource.DataSource = this.POSDataSet;
			this.GroupBox1.Controls.Add(this.chkShowAll);
			this.GroupBox1.Controls.Add(this.chkWithFigures);
			this.GroupBox1.Controls.Add(this.chkBins);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.cbobins);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.DTStartdate);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Size = new global::System.Drawing.Size(1208, 249);
			this.GroupBox1.TabIndex = 5;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Details";
			this.chkShowAll.AutoSize = true;
			this.chkShowAll.Location = new global::System.Drawing.Point(663, 166);
			this.chkShowAll.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.chkShowAll.Name = "chkShowAll";
			this.chkShowAll.Size = new global::System.Drawing.Size(311, 24);
			this.chkShowAll.TabIndex = 40;
			this.chkShowAll.Text = "Show Products with zero stock balance";
			this.chkShowAll.UseVisualStyleBackColor = true;
			this.chkWithFigures.AutoSize = true;
			this.chkWithFigures.Location = new global::System.Drawing.Point(663, 132);
			this.chkWithFigures.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.chkWithFigures.Name = "chkWithFigures";
			this.chkWithFigures.Size = new global::System.Drawing.Size(191, 24);
			this.chkWithFigures.TabIndex = 39;
			this.chkWithFigures.Text = "With Stock Balances?";
			this.chkWithFigures.UseVisualStyleBackColor = true;
			this.chkBins.AutoSize = true;
			this.chkBins.Location = new global::System.Drawing.Point(446, 131);
			this.chkBins.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.chkBins.Name = "chkBins";
			this.chkBins.Size = new global::System.Drawing.Size(87, 24);
			this.chkBins.TabIndex = 38;
			this.chkBins.Text = "All Bins";
			this.chkBins.UseVisualStyleBackColor = true;
			this.Label6.AutoSize = true;
			this.Label6.Location = new global::System.Drawing.Point(80, 132);
			this.Label6.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(150, 20);
			this.Label6.TabIndex = 37;
			this.Label6.Text = "Select Bin Location:";
			this.cbobins.FormattingEnabled = true;
			this.cbobins.Location = new global::System.Drawing.Point(236, 128);
			this.cbobins.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbobins.Name = "cbobins";
			this.cbobins.Size = new global::System.Drawing.Size(172, 28);
			this.cbobins.TabIndex = 36;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(104, 91);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(122, 20);
			this.Label2.TabIndex = 15;
			this.Label2.Text = "Balances As At:";
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(592, 91);
			this.Label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(60, 20);
			this.Label5.TabIndex = 14;
			this.Label5.Text = "Branch";
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(663, 86);
			this.cboBranch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(256, 28);
			this.cboBranch.TabIndex = 13;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(78, 25);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(592, 32);
			this.Label1.TabIndex = 6;
			this.Label1.Text = "Warehouse Stock Balances Report for Branch";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(236, 168);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(174, 35);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "RUN REPORT";
			this.Button1.UseVisualStyleBackColor = false;
			this.DTStartdate.Location = new global::System.Drawing.Point(236, 88);
			this.DTStartdate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTStartdate.Name = "DTStartdate";
			this.DTStartdate.Size = new global::System.Drawing.Size(298, 26);
			this.DTStartdate.TabIndex = 1;
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "CompanyDetails";
			reportDataSource.Value = this.GetCompanyDetailsBindingSource;
			reportDataSource2.Name = "StockBal";
			reportDataSource2.Value = this.CurrentStockLevelsWarehouseReportBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.StockSheetsWarehouse.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 249);
			this.ReportViewer1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(1208, 520);
			this.ReportViewer1.TabIndex = 6;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.CurrentStockLevelsWarehouseReportTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1208, 769);
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "StockSheetsWarehouse";
			this.Text = "StockSheetsWarehouse";
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.CurrentStockLevelsWarehouseReportBindingSource).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400264C RID: 9804
		private global::System.ComponentModel.IContainer components;
	}
}
