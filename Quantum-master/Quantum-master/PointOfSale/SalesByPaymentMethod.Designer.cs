namespace PointOfSale
{
	// Token: 0x02000197 RID: 407
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SalesByPaymentMethod : global::System.Windows.Forms.UserControl
	{
		// Token: 0x0600484F RID: 18511 RVA: 0x002C04D8 File Offset: 0x002BE6D8
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

		// Token: 0x06004850 RID: 18512 RVA: 0x002C0528 File Offset: 0x002BE728
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.SalesForPeriodByPaymentMethodBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.cboPaymentMethod = new global::System.Windows.Forms.ComboBox();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.chkAllUsers = new global::System.Windows.Forms.CheckBox();
			this.btnRun = new global::System.Windows.Forms.Button();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.cboUsers = new global::System.Windows.Forms.ComboBox();
			this.DTEnddate = new global::System.Windows.Forms.DateTimePicker();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.DTStartdate = new global::System.Windows.Forms.DateTimePicker();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.SalesForPeriodByPaymentMethodTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.SalesForPeriodByPaymentMethodTableAdapter();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesForPeriodByPaymentMethodBindingSource).BeginInit();
			this.GroupBox1.SuspendLayout();
			base.SuspendLayout();
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.SalesForPeriodByPaymentMethodBindingSource.DataMember = "SalesForPeriodByPaymentMethod";
			this.SalesForPeriodByPaymentMethodBindingSource.DataSource = this.POSDataSet;
			this.GroupBox1.BackColor = global::System.Drawing.Color.Cyan;
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Controls.Add(this.cboPaymentMethod);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.chkAllUsers);
			this.GroupBox1.Controls.Add(this.btnRun);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.cboUsers);
			this.GroupBox1.Controls.Add(this.DTEnddate);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.DTStartdate);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1232, 202);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Sales for Period by Payment Method";
			this.Label7.AutoSize = true;
			this.Label7.Location = new global::System.Drawing.Point(11, 157);
			this.Label7.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label7.Name = "Label7";
			this.Label7.Size = new global::System.Drawing.Size(133, 20);
			this.Label7.TabIndex = 22;
			this.Label7.Text = "Payment Method:";
			this.cboPaymentMethod.FormattingEnabled = true;
			this.cboPaymentMethod.Location = new global::System.Drawing.Point(151, 152);
			this.cboPaymentMethod.Name = "cboPaymentMethod";
			this.cboPaymentMethod.Size = new global::System.Drawing.Size(298, 28);
			this.cboPaymentMethod.TabIndex = 21;
			this.Label6.AutoSize = true;
			this.Label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label6.Location = new global::System.Drawing.Point(114, 34);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(663, 29);
			this.Label6.TabIndex = 20;
			this.Label6.Text = "SALES REPORT FOR PERIOD BY PAYMENT METHOD";
			this.Label3.AutoSize = true;
			this.Label3.BackColor = global::System.Drawing.Color.Red;
			this.Label3.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label3.Location = new global::System.Drawing.Point(1180, 22);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(49, 20);
			this.Label3.TabIndex = 19;
			this.Label3.Text = "Close";
			this.chkAllUsers.AutoSize = true;
			this.chkAllUsers.Checked = true;
			this.chkAllUsers.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.chkAllUsers.Location = new global::System.Drawing.Point(891, 116);
			this.chkAllUsers.Name = "chkAllUsers";
			this.chkAllUsers.Size = new global::System.Drawing.Size(107, 24);
			this.chkAllUsers.TabIndex = 18;
			this.chkAllUsers.Text = "All Users?";
			this.chkAllUsers.UseVisualStyleBackColor = true;
			this.btnRun.BackColor = global::System.Drawing.Color.Lime;
			this.btnRun.Location = new global::System.Drawing.Point(587, 148);
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new global::System.Drawing.Size(298, 39);
			this.btnRun.TabIndex = 17;
			this.btnRun.Text = "Run Report";
			this.btnRun.UseVisualStyleBackColor = false;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(530, 119);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(47, 20);
			this.Label2.TabIndex = 16;
			this.Label2.Text = "User:";
			this.cboUsers.FormattingEnabled = true;
			this.cboUsers.Location = new global::System.Drawing.Point(587, 114);
			this.cboUsers.Name = "cboUsers";
			this.cboUsers.Size = new global::System.Drawing.Size(298, 28);
			this.cboUsers.TabIndex = 15;
			this.DTEnddate.Location = new global::System.Drawing.Point(587, 80);
			this.DTEnddate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTEnddate.Name = "DTEnddate";
			this.DTEnddate.Size = new global::System.Drawing.Size(298, 26);
			this.DTEnddate.TabIndex = 14;
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(496, 84);
			this.Label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(81, 20);
			this.Label5.TabIndex = 13;
			this.Label5.Text = "End Date:";
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(79, 120);
			this.Label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(64, 20);
			this.Label4.TabIndex = 12;
			this.Label4.Text = "Branch:";
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(151, 116);
			this.cboBranch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(298, 28);
			this.cboBranch.TabIndex = 11;
			this.DTStartdate.Location = new global::System.Drawing.Point(151, 80);
			this.DTStartdate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTStartdate.Name = "DTStartdate";
			this.DTStartdate.Size = new global::System.Drawing.Size(298, 26);
			this.DTStartdate.TabIndex = 10;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(46, 84);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(94, 20);
			this.Label1.TabIndex = 9;
			this.Label1.Text = "Select date:";
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "CompanyDetails";
			reportDataSource.Value = this.GetCompanyDetailsBindingSource;
			reportDataSource2.Name = "Sales";
			reportDataSource2.Value = this.SalesForPeriodByPaymentMethodBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.SalesByPaymentMethods.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 202);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(1232, 282);
			this.ReportViewer1.TabIndex = 1;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.SalesForPeriodByPaymentMethodTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Name = "SalesByPaymentMethod";
			base.Size = new global::System.Drawing.Size(1232, 484);
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesForPeriodByPaymentMethodBindingSource).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04001FA6 RID: 8102
		private global::System.ComponentModel.IContainer components;
	}
}
