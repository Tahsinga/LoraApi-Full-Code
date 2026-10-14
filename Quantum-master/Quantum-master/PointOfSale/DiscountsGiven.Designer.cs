namespace PointOfSale
{
	// Token: 0x02000045 RID: 69
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class DiscountsGiven : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06000EFB RID: 3835 RVA: 0x0008ED30 File Offset: 0x0008CF30
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

		// Token: 0x06000EFC RID: 3836 RVA: 0x0008ED80 File Offset: 0x0008CF80
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.cboBranches = new global::System.Windows.Forms.ComboBox();
			this.DTEnddate = new global::System.Windows.Forms.DateTimePicker();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.DTStartDate = new global::System.Windows.Forms.DateTimePicker();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.InvDiscountsGivenBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.InvDiscountsGivenTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.InvDiscountsGivenTableAdapter();
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.InvDiscountsGivenBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.cboBranches);
			this.GroupBox1.Controls.Add(this.DTEnddate);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.DTStartDate);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1054, 170);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Label5.AutoSize = true;
			this.Label5.BackColor = global::System.Drawing.Color.Red;
			this.Label5.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label5.Location = new global::System.Drawing.Point(1018, 16);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(33, 13);
			this.Label5.TabIndex = 8;
			this.Label5.Text = "Close";
			this.Label4.AutoSize = true;
			this.Label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.Location = new global::System.Drawing.Point(94, 16);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(297, 24);
			this.Label4.TabIndex = 7;
			this.Label4.Text = "Invoice Discounts Given for Period";
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(87, 105);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(77, 13);
			this.Label3.TabIndex = 6;
			this.Label3.Text = "Select Branch:";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(173, 129);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(200, 23);
			this.Button1.TabIndex = 5;
			this.Button1.Text = "Run Report";
			this.Button1.UseVisualStyleBackColor = false;
			this.cboBranches.FormattingEnabled = true;
			this.cboBranches.Location = new global::System.Drawing.Point(173, 102);
			this.cboBranches.Name = "cboBranches";
			this.cboBranches.Size = new global::System.Drawing.Size(200, 21);
			this.cboBranches.TabIndex = 4;
			this.DTEnddate.Location = new global::System.Drawing.Point(173, 76);
			this.DTEnddate.Name = "DTEnddate";
			this.DTEnddate.Size = new global::System.Drawing.Size(200, 20);
			this.DTEnddate.TabIndex = 3;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(109, 79);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(55, 13);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "End Date:";
			this.DTStartDate.Location = new global::System.Drawing.Point(173, 50);
			this.DTStartDate.Name = "DTStartDate";
			this.DTStartDate.Size = new global::System.Drawing.Size(200, 20);
			this.DTStartDate.TabIndex = 1;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(109, 53);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(58, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Start Date:";
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "InvDisc";
			reportDataSource.Value = this.InvDiscountsGivenBindingSource;
			reportDataSource2.Name = "CompanyDetails";
			reportDataSource2.Value = this.GetCompanyDetailsBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.InvoiceDiscountsGiven.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 170);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(1054, 229);
			this.ReportViewer1.TabIndex = 1;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.InvDiscountsGivenBindingSource.DataMember = "InvDiscountsGiven";
			this.InvDiscountsGivenBindingSource.DataSource = this.POSDataSet;
			this.InvDiscountsGivenTableAdapter.ClearBeforeFill = true;
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Name = "DiscountsGiven";
			base.Size = new global::System.Drawing.Size(1054, 399);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.InvDiscountsGivenBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400072A RID: 1834
		private global::System.ComponentModel.IContainer components;
	}
}
