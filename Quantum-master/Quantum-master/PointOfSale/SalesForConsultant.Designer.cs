namespace PointOfSale
{
	// Token: 0x02000199 RID: 409
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SalesForConsultant : global::System.Windows.Forms.UserControl
	{
		// Token: 0x060048B6 RID: 18614 RVA: 0x002C29F4 File Offset: 0x002C0BF4
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

		// Token: 0x060048B7 RID: 18615 RVA: 0x002C2A44 File Offset: 0x002C0C44
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.cboConsultants = new global::System.Windows.Forms.ComboBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.DTEnddate = new global::System.Windows.Forms.DateTimePicker();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.DTStartdate = new global::System.Windows.Forms.DateTimePicker();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.chkAllConsultants = new global::System.Windows.Forms.CheckBox();
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.GetSalesForConsultantBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.GetSalesForConsultantTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetSalesForConsultantTableAdapter();
			this.chkAllCategories = new global::System.Windows.Forms.CheckBox();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.cboCategory = new global::System.Windows.Forms.ComboBox();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetSalesForConsultantBindingSource).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.chkAllCategories);
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Controls.Add(this.cboCategory);
			this.GroupBox1.Controls.Add(this.chkAllConsultants);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.cboConsultants);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.DTEnddate);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.DTStartdate);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1013, 169);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Label6.AutoSize = true;
			this.Label6.BackColor = global::System.Drawing.Color.Red;
			this.Label6.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label6.Location = new global::System.Drawing.Point(977, 16);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(33, 13);
			this.Label6.TabIndex = 21;
			this.Label6.Text = "Close";
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(310, 92);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(60, 13);
			this.Label3.TabIndex = 20;
			this.Label3.Text = "Consultant:";
			this.cboConsultants.FormattingEnabled = true;
			this.cboConsultants.Location = new global::System.Drawing.Point(371, 88);
			this.cboConsultants.Name = "cboConsultants";
			this.cboConsultants.Size = new global::System.Drawing.Size(200, 21);
			this.cboConsultants.TabIndex = 19;
			this.Label4.AutoSize = true;
			this.Label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.Location = new global::System.Drawing.Point(6, 16);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(260, 24);
			this.Label4.TabIndex = 18;
			this.Label4.Text = "Sales by Consultant for Period";
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(614, 66);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(41, 13);
			this.Label5.TabIndex = 17;
			this.Label5.Text = "Branch";
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(661, 63);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(200, 21);
			this.cboBranch.TabIndex = 16;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(310, 65);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(55, 13);
			this.Label2.TabIndex = 15;
			this.Label2.Text = "End Date:";
			this.DTEnddate.Location = new global::System.Drawing.Point(371, 62);
			this.DTEnddate.Name = "DTEnddate";
			this.DTEnddate.Size = new global::System.Drawing.Size(200, 20);
			this.DTEnddate.TabIndex = 14;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(77, 140);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(200, 23);
			this.Button1.TabIndex = 13;
			this.Button1.Text = "RUN REPORT";
			this.Button1.UseVisualStyleBackColor = false;
			this.DTStartdate.Location = new global::System.Drawing.Point(77, 64);
			this.DTStartdate.Name = "DTStartdate";
			this.DTStartdate.Size = new global::System.Drawing.Size(200, 20);
			this.DTStartdate.TabIndex = 12;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(13, 67);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(58, 13);
			this.Label1.TabIndex = 11;
			this.Label1.Text = "Start Date:";
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "CompanyDetails";
			reportDataSource.Value = this.GetCompanyDetailsBindingSource;
			reportDataSource2.Name = "Sales";
			reportDataSource2.Value = this.GetSalesForConsultantBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.SalesForConsultant.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 169);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(1013, 258);
			this.ReportViewer1.TabIndex = 1;
			this.chkAllConsultants.AutoSize = true;
			this.chkAllConsultants.Location = new global::System.Drawing.Point(371, 117);
			this.chkAllConsultants.Name = "chkAllConsultants";
			this.chkAllConsultants.Size = new global::System.Drawing.Size(101, 17);
			this.chkAllConsultants.TabIndex = 22;
			this.chkAllConsultants.Text = "All Consultants?";
			this.chkAllConsultants.UseVisualStyleBackColor = true;
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.GetSalesForConsultantBindingSource.DataMember = "GetSalesForConsultant";
			this.GetSalesForConsultantBindingSource.DataSource = this.POSDataSet;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.GetSalesForConsultantTableAdapter.ClearBeforeFill = true;
			this.chkAllCategories.AutoSize = true;
			this.chkAllCategories.Location = new global::System.Drawing.Point(77, 117);
			this.chkAllCategories.Name = "chkAllCategories";
			this.chkAllCategories.Size = new global::System.Drawing.Size(96, 17);
			this.chkAllCategories.TabIndex = 25;
			this.chkAllCategories.Text = "All Categories?";
			this.chkAllCategories.UseVisualStyleBackColor = true;
			this.Label7.AutoSize = true;
			this.Label7.Location = new global::System.Drawing.Point(19, 94);
			this.Label7.Name = "Label7";
			this.Label7.Size = new global::System.Drawing.Size(52, 13);
			this.Label7.TabIndex = 24;
			this.Label7.Text = "Category:";
			this.cboCategory.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboCategory.FormattingEnabled = true;
			this.cboCategory.Location = new global::System.Drawing.Point(77, 90);
			this.cboCategory.Name = "cboCategory";
			this.cboCategory.Size = new global::System.Drawing.Size(200, 21);
			this.cboCategory.TabIndex = 23;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Name = "SalesForConsultant";
			base.Size = new global::System.Drawing.Size(1013, 427);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetSalesForConsultantBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04001FD5 RID: 8149
		private global::System.ComponentModel.IContainer components;
	}
}
