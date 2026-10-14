namespace PointOfSale
{
	// Token: 0x02000038 RID: 56
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class CustomerList : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06000C35 RID: 3125 RVA: 0x00079E00 File Offset: 0x00078000
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

		// Token: 0x06000C36 RID: 3126 RVA: 0x00079E50 File Offset: 0x00078050
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.FetchAllCustomersBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.FetchAllCustomersTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.FetchAllCustomersTableAdapter();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchAllCustomersBindingSource).BeginInit();
			this.GroupBox1.SuspendLayout();
			base.SuspendLayout();
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.FetchAllCustomersBindingSource.DataMember = "FetchAllCustomers";
			this.FetchAllCustomersBindingSource.DataSource = this.POSDataSet;
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(993, 90);
			this.GroupBox1.TabIndex = 2;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Details";
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(355, 16);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(281, 24);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "Current Customer List for Branch";
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Red;
			this.Label2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label2.Location = new global::System.Drawing.Point(957, 16);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(33, 13);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "Close";
			this.Button1.Location = new global::System.Drawing.Point(579, 62);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(138, 23);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "RUN REPORT";
			this.Button1.UseVisualStyleBackColor = true;
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "CompanyDetails";
			reportDataSource.Value = this.GetCompanyDetailsBindingSource;
			reportDataSource2.Name = "CustomerList";
			reportDataSource2.Value = this.FetchAllCustomersBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.ListofCustomers.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 90);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(993, 347);
			this.ReportViewer1.TabIndex = 3;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.FetchAllCustomersTableAdapter.ClearBeforeFill = true;
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(354, 66);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(41, 13);
			this.Label5.TabIndex = 12;
			this.Label5.Text = "Branch";
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(401, 63);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(172, 21);
			this.cboBranch.TabIndex = 11;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Name = "CustomerList";
			base.Size = new global::System.Drawing.Size(993, 437);
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchAllCustomersBindingSource).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040005C6 RID: 1478
		private global::System.ComponentModel.IContainer components;
	}
}
