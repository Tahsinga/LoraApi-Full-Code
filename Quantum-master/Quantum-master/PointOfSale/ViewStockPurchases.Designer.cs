namespace PointOfSale
{
	// Token: 0x02000218 RID: 536
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ViewStockPurchases : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06006035 RID: 24629 RVA: 0x0036F404 File Offset: 0x0036D604
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

		// Token: 0x06006036 RID: 24630 RVA: 0x0036F454 File Offset: 0x0036D654
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.FetchStockPurchasesBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.DTEnddate = new global::System.Windows.Forms.DateTimePicker();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.DTStartdate = new global::System.Windows.Forms.DateTimePicker();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.FetchStockPurchasesTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.FetchStockPurchasesTableAdapter();
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.PrintDocument1 = new global::System.Drawing.Printing.PrintDocument();
			this.FetchStockPurchasesGroupedTaxBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.FetchStockPurchasesGroupedTaxTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.FetchStockPurchasesGroupedTaxTableAdapter();
			((global::System.ComponentModel.ISupportInitialize)this.FetchStockPurchasesBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.FetchStockPurchasesGroupedTaxBindingSource).BeginInit();
			base.SuspendLayout();
			this.FetchStockPurchasesBindingSource.DataMember = "FetchStockPurchases";
			this.FetchStockPurchasesBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
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
			this.GroupBox1.Size = new global::System.Drawing.Size(1516, 214);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Button2.BackColor = global::System.Drawing.SystemColors.Control;
			this.Button2.Location = new global::System.Drawing.Point(632, 152);
			this.Button2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(207, 35);
			this.Button2.TabIndex = 20;
			this.Button2.Text = "Print on Receipt Printer";
			this.Button2.UseVisualStyleBackColor = false;
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(36, 157);
			this.Label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(60, 20);
			this.Label5.TabIndex = 19;
			this.Label5.Text = "Branch";
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(106, 152);
			this.cboBranch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(298, 28);
			this.cboBranch.TabIndex = 18;
			this.Label4.AutoSize = true;
			this.Label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.Location = new global::System.Drawing.Point(531, 18);
			this.Label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(357, 32);
			this.Label4.TabIndex = 17;
			this.Label4.Text = "Stock Purchases for Period";
			this.Label3.AutoSize = true;
			this.Label3.BackColor = global::System.Drawing.Color.Red;
			this.Label3.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label3.Location = new global::System.Drawing.Point(1463, 24);
			this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(49, 20);
			this.Label3.TabIndex = 16;
			this.Label3.Text = "Close";
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(15, 117);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(81, 20);
			this.Label2.TabIndex = 15;
			this.Label2.Text = "End Date:";
			this.DTEnddate.Location = new global::System.Drawing.Point(106, 112);
			this.DTEnddate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTEnddate.Name = "DTEnddate";
			this.DTEnddate.Size = new global::System.Drawing.Size(298, 26);
			this.DTEnddate.TabIndex = 14;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(416, 152);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(207, 35);
			this.Button1.TabIndex = 13;
			this.Button1.Text = "RUN REPORT";
			this.Button1.UseVisualStyleBackColor = false;
			this.DTStartdate.Location = new global::System.Drawing.Point(106, 72);
			this.DTStartdate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTStartdate.Name = "DTStartdate";
			this.DTStartdate.Size = new global::System.Drawing.Size(298, 26);
			this.DTStartdate.TabIndex = 12;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(10, 77);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(87, 20);
			this.Label1.TabIndex = 11;
			this.Label1.Text = "Start Date:";
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "CompanyDetails";
			reportDataSource.Value = this.GetCompanyDetailsBindingSource;
			reportDataSource2.Name = "Purchases";
			reportDataSource2.Value = this.FetchStockPurchasesBindingSource;
			reportDataSource3.Name = "TAXGROUPS";
			reportDataSource3.Value = this.FetchStockPurchasesGroupedTaxBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource3);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.StockPurchsesReport.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 214);
			this.ReportViewer1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(1516, 381);
			this.ReportViewer1.TabIndex = 1;
			this.FetchStockPurchasesTableAdapter.ClearBeforeFill = true;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.FetchStockPurchasesGroupedTaxBindingSource.DataMember = "FetchStockPurchasesGroupedTax";
			this.FetchStockPurchasesGroupedTaxBindingSource.DataSource = this.POSDataSet;
			this.FetchStockPurchasesGroupedTaxTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "ViewStockPurchases";
			base.Size = new global::System.Drawing.Size(1516, 595);
			((global::System.ComponentModel.ISupportInitialize)this.FetchStockPurchasesBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.FetchStockPurchasesGroupedTaxBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04002A49 RID: 10825
		private global::System.ComponentModel.IContainer components;
	}
}
