namespace PointOfSale
{
	// Token: 0x02000039 RID: 57
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class CustomerListBySales : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06000C54 RID: 3156 RVA: 0x0007A818 File Offset: 0x00078A18
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

		// Token: 0x06000C55 RID: 3157 RVA: 0x0007A868 File Offset: 0x00078A68
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.DTEnddate = new global::System.Windows.Forms.DateTimePicker();
			this.DTStartdate = new global::System.Windows.Forms.DateTimePicker();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.SelectCustomersBySales2BindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.SelectCustomersBySales2TableAdapter = new global::PointOfSale.POSDataSetTableAdapters.SelectCustomersBySales2TableAdapter();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SelectCustomersBySales2BindingSource).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.DTEnddate);
			this.GroupBox1.Controls.Add(this.DTStartdate);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(937, 107);
			this.GroupBox1.TabIndex = 3;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Details";
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(308, 73);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(41, 13);
			this.Label5.TabIndex = 14;
			this.Label5.Text = "Branch";
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(355, 70);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(172, 21);
			this.cboBranch.TabIndex = 13;
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(328, 16);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(267, 24);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "Current Customer List By Sales";
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Red;
			this.Label2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label2.Location = new global::System.Drawing.Point(901, 16);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(33, 13);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "Close";
			this.Button1.Location = new global::System.Drawing.Point(533, 70);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(138, 23);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "RUN REPORT";
			this.Button1.UseVisualStyleBackColor = true;
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "CompanyDetails";
			reportDataSource.Value = this.GetCompanyDetailsBindingSource;
			reportDataSource2.Name = "CustomerListBySales";
			reportDataSource2.Value = this.SelectCustomersBySales2BindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.CustomerListBySales.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 107);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(937, 330);
			this.ReportViewer1.TabIndex = 4;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(17, 73);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(55, 13);
			this.Label1.TabIndex = 18;
			this.Label1.Text = "End Date:";
			this.DTEnddate.Location = new global::System.Drawing.Point(78, 70);
			this.DTEnddate.Name = "DTEnddate";
			this.DTEnddate.Size = new global::System.Drawing.Size(200, 20);
			this.DTEnddate.TabIndex = 17;
			this.DTStartdate.Location = new global::System.Drawing.Point(78, 47);
			this.DTStartdate.Name = "DTStartdate";
			this.DTStartdate.Size = new global::System.Drawing.Size(200, 20);
			this.DTStartdate.TabIndex = 16;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(14, 50);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(58, 13);
			this.Label4.TabIndex = 15;
			this.Label4.Text = "Start Date:";
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.SelectCustomersBySales2BindingSource.DataMember = "SelectCustomersBySales2";
			this.SelectCustomersBySales2BindingSource.DataSource = this.POSDataSet;
			this.SelectCustomersBySales2TableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Name = "CustomerListBySales";
			base.Size = new global::System.Drawing.Size(937, 437);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SelectCustomersBySales2BindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040005D4 RID: 1492
		private global::System.ComponentModel.IContainer components;
	}
}
