namespace PointOfSale
{
	// Token: 0x0200003E RID: 62
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class DespatchForCustomer : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06000E0F RID: 3599 RVA: 0x000889F4 File Offset: 0x00086BF4
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

		// Token: 0x06000E10 RID: 3600 RVA: 0x00088A44 File Offset: 0x00086C44
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.GetCompanyDetailsForCoidBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.DespatchForPeriodForCustomerBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.cboCustomers = new global::System.Windows.Forms.ComboBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.DTEnd = new global::System.Windows.Forms.DateTimePicker();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.DTStart = new global::System.Windows.Forms.DateTimePicker();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.GetCompanyDetailsForCoidTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsForCoidTableAdapter();
			this.DespatchForPeriodForCustomerTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.DespatchForPeriodForCustomerTableAdapter();
			this.DespatchForPeriodByInvoiceForCustomerBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.DespatchForPeriodByInvoiceForCustomerTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.DespatchForPeriodByInvoiceForCustomerTableAdapter();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsForCoidBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.DespatchForPeriodForCustomerBindingSource).BeginInit();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DespatchForPeriodByInvoiceForCustomerBindingSource).BeginInit();
			base.SuspendLayout();
			this.GetCompanyDetailsForCoidBindingSource.DataMember = "GetCompanyDetailsForCoid";
			this.GetCompanyDetailsForCoidBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.DespatchForPeriodForCustomerBindingSource.DataMember = "DespatchForPeriodForCustomer";
			this.DespatchForPeriodForCustomerBindingSource.DataSource = this.POSDataSet;
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.cboCustomers);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.DTEnd);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.DTStart);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1120, 190);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Select Date Period and Customer";
			this.Label6.AutoSize = true;
			this.Label6.Location = new global::System.Drawing.Point(557, 115);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(64, 20);
			this.Label6.TabIndex = 49;
			this.Label6.Text = "Branch:";
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(627, 112);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(321, 28);
			this.cboBranch.TabIndex = 48;
			this.Label5.AutoSize = true;
			this.Label5.BackColor = global::System.Drawing.Color.Red;
			this.Label5.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label5.Location = new global::System.Drawing.Point(1068, 22);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(49, 20);
			this.Label5.TabIndex = 8;
			this.Label5.Text = "Close";
			this.Label4.AutoSize = true;
			this.Label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.Location = new global::System.Drawing.Point(145, 22);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(432, 32);
			this.Label4.TabIndex = 7;
			this.Label4.Text = "Despatch Report per Customer";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(150, 146);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(191, 31);
			this.Button1.TabIndex = 6;
			this.Button1.Text = "RUN REPORT";
			this.Button1.UseVisualStyleBackColor = false;
			this.cboCustomers.FormattingEnabled = true;
			this.cboCustomers.Location = new global::System.Drawing.Point(151, 112);
			this.cboCustomers.Name = "cboCustomers";
			this.cboCustomers.Size = new global::System.Drawing.Size(320, 28);
			this.cboCustomers.TabIndex = 5;
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(14, 112);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(131, 20);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "Select Customer:";
			this.DTEnd.Location = new global::System.Drawing.Point(627, 73);
			this.DTEnd.Name = "DTEnd";
			this.DTEnd.Size = new global::System.Drawing.Size(321, 26);
			this.DTEnd.TabIndex = 3;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(540, 77);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(81, 20);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "End Date:";
			this.DTStart.Location = new global::System.Drawing.Point(150, 75);
			this.DTStart.Name = "DTStart";
			this.DTStart.Size = new global::System.Drawing.Size(321, 26);
			this.DTStart.TabIndex = 1;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(57, 79);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(87, 20);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Start Date:";
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "CompanyDetails";
			reportDataSource.Value = this.GetCompanyDetailsForCoidBindingSource;
			reportDataSource2.Name = "Despatch";
			reportDataSource2.Value = this.DespatchForPeriodForCustomerBindingSource;
			reportDataSource3.Name = "InvoiceBreakdown";
			reportDataSource3.Value = this.DespatchForPeriodByInvoiceForCustomerBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource3);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.DespatchForCustomer.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 190);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(1120, 243);
			this.ReportViewer1.TabIndex = 1;
			this.GetCompanyDetailsForCoidTableAdapter.ClearBeforeFill = true;
			this.DespatchForPeriodForCustomerTableAdapter.ClearBeforeFill = true;
			this.DespatchForPeriodByInvoiceForCustomerBindingSource.DataMember = "DespatchForPeriodByInvoiceForCustomer";
			this.DespatchForPeriodByInvoiceForCustomerBindingSource.DataSource = this.POSDataSet;
			this.DespatchForPeriodByInvoiceForCustomerTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Name = "DespatchForCustomer";
			base.Size = new global::System.Drawing.Size(1120, 433);
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsForCoidBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.DespatchForPeriodForCustomerBindingSource).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DespatchForPeriodByInvoiceForCustomerBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040006AE RID: 1710
		private global::System.ComponentModel.IContainer components;
	}
}
