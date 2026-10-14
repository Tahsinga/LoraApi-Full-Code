namespace PointOfSale
{
	// Token: 0x0200005F RID: 95
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class FrmADF_SalesPurchases3 : global::System.Windows.Forms.Form
	{
		// Token: 0x060013E3 RID: 5091 RVA: 0x000BC954 File Offset: 0x000BAB54
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

		// Token: 0x060013E4 RID: 5092 RVA: 0x000BC9A4 File Offset: 0x000BABA4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.ADF_Purchases_StockValueBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.DTEndDate = new global::System.Windows.Forms.DateTimePicker();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.DTStartdate = new global::System.Windows.Forms.DateTimePicker();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.ADF_Purchases_StockValueTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.ADF_Purchases_StockValueTableAdapter();
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			((global::System.ComponentModel.ISupportInitialize)this.ADF_Purchases_StockValueBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			this.GroupBox1.SuspendLayout();
			base.SuspendLayout();
			this.ADF_Purchases_StockValueBindingSource.DataMember = "ADF_Purchases_StockValue";
			this.ADF_Purchases_StockValueBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.DTEndDate);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.DTStartdate);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1037, 181);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(164, 133);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(200, 23);
			this.Button1.TabIndex = 31;
			this.Button1.Text = "RUN REPORT";
			this.Button1.UseVisualStyleBackColor = false;
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(79, 16);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(367, 24);
			this.Label3.TabIndex = 30;
			this.Label3.Text = "Asset Values, Sales and Purchases Report";
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(117, 109);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(41, 13);
			this.Label5.TabIndex = 29;
			this.Label5.Text = "Branch";
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(164, 106);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(200, 21);
			this.cboBranch.TabIndex = 28;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(103, 83);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(55, 13);
			this.Label1.TabIndex = 27;
			this.Label1.Text = "End Date:";
			this.DTEndDate.Location = new global::System.Drawing.Point(164, 80);
			this.DTEndDate.Name = "DTEndDate";
			this.DTEndDate.Size = new global::System.Drawing.Size(200, 20);
			this.DTEndDate.TabIndex = 26;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(100, 58);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(58, 13);
			this.Label2.TabIndex = 25;
			this.Label2.Text = "Start Date:";
			this.DTStartdate.Location = new global::System.Drawing.Point(164, 54);
			this.DTStartdate.Name = "DTStartdate";
			this.DTStartdate.Size = new global::System.Drawing.Size(200, 20);
			this.DTStartdate.TabIndex = 24;
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "DataSet1";
			reportDataSource.Value = this.ADF_Purchases_StockValueBindingSource;
			reportDataSource2.Name = "CompanyDetails";
			reportDataSource2.Value = this.GetCompanyDetailsBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.Sales_Purchases_Report.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 181);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(1037, 237);
			this.ReportViewer1.TabIndex = 4;
			this.ADF_Purchases_StockValueTableAdapter.ClearBeforeFill = true;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1037, 418);
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Name = "FrmADF_SalesPurchases3";
			this.Text = "FrmADF_SalesPurchases3";
			((global::System.ComponentModel.ISupportInitialize)this.ADF_Purchases_StockValueBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000A19 RID: 2585
		private global::System.ComponentModel.IContainer components;
	}
}
