namespace PointOfSale
{
	// Token: 0x02000047 RID: 71
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class EcocashReceipts : global::System.Windows.Forms.Form
	{
		// Token: 0x06000F54 RID: 3924 RVA: 0x00090DE0 File Offset: 0x0008EFE0
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

		// Token: 0x06000F55 RID: 3925 RVA: 0x00090E30 File Offset: 0x0008F030
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.DTStartdate = new global::System.Windows.Forms.DateTimePicker();
			this.DTEnddate = new global::System.Windows.Forms.DateTimePicker();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.GetEcocashDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetEcocashDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetEcocashDetailsTableAdapter();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetEcocashDetailsBindingSource).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.DTEnddate);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.DTStartdate);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(947, 135);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(35, 56);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(58, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Start Date:";
			this.DTStartdate.Location = new global::System.Drawing.Point(99, 53);
			this.DTStartdate.Name = "DTStartdate";
			this.DTStartdate.Size = new global::System.Drawing.Size(200, 20);
			this.DTStartdate.TabIndex = 1;
			this.DTEnddate.Location = new global::System.Drawing.Point(99, 79);
			this.DTEnddate.Name = "DTEnddate";
			this.DTEnddate.Size = new global::System.Drawing.Size(200, 20);
			this.DTEnddate.TabIndex = 3;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(38, 83);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(55, 13);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "End Date:";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(99, 105);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(101, 23);
			this.Button1.TabIndex = 4;
			this.Button1.Text = "Run Report";
			this.Button1.UseVisualStyleBackColor = false;
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 16f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(33, 16);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(341, 26);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "View Ecocash Receipts for Period";
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "CompanyDetails";
			reportDataSource.Value = this.GetCompanyDetailsBindingSource;
			reportDataSource2.Name = "Ecocash";
			reportDataSource2.Value = this.GetEcocashDetailsBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.EcocashPayments.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 135);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(947, 332);
			this.ReportViewer1.TabIndex = 5;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.GetEcocashDetailsBindingSource.DataMember = "GetEcocashDetails";
			this.GetEcocashDetailsBindingSource.DataSource = this.POSDataSet;
			this.GetEcocashDetailsTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(947, 467);
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Name = "EcocashReceipts";
			this.Text = "Ecocash Receipts for Period";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetEcocashDetailsBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000756 RID: 1878
		private global::System.ComponentModel.IContainer components;
	}
}
