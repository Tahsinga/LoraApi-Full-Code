namespace PointOfSale
{
	// Token: 0x02000040 RID: 64
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class DespatchReportForPeriod : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06000E61 RID: 3681 RVA: 0x0008A7BC File Offset: 0x000889BC
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

		// Token: 0x06000E62 RID: 3682 RVA: 0x0008A80C File Offset: 0x00088A0C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.DespatchForPeriodBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.DespatchForPeriodTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.DespatchForPeriodTableAdapter();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.DTEndDate = new global::System.Windows.Forms.DateTimePicker();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.DTStartDate = new global::System.Windows.Forms.DateTimePicker();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.GetCompanyDetailsForCoidBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetCompanyDetailsForCoidTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsForCoidTableAdapter();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.DespatchForPeriodBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsForCoidBindingSource).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.DTEndDate);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.DTStartDate);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1236, 232);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "Despatch";
			reportDataSource.Value = this.DespatchForPeriodBindingSource;
			reportDataSource2.Name = "CompanyDetails";
			reportDataSource2.Value = this.GetCompanyDetailsForCoidBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.DespatchForPeriod.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 232);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(1236, 302);
			this.ReportViewer1.TabIndex = 1;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.DespatchForPeriodBindingSource.DataMember = "DespatchForPeriod";
			this.DespatchForPeriodBindingSource.DataSource = this.POSDataSet;
			this.DespatchForPeriodTableAdapter.ClearBeforeFill = true;
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(657, 93);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(64, 20);
			this.Label3.TabIndex = 47;
			this.Label3.Text = "Branch:";
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(727, 90);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(284, 28);
			this.cboBranch.TabIndex = 46;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(215, 123);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(81, 20);
			this.Label2.TabIndex = 45;
			this.Label2.Text = "End Date:";
			this.DTEndDate.Location = new global::System.Drawing.Point(302, 118);
			this.DTEndDate.Name = "DTEndDate";
			this.DTEndDate.Size = new global::System.Drawing.Size(284, 26);
			this.DTEndDate.TabIndex = 44;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(209, 90);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(87, 20);
			this.Label1.TabIndex = 43;
			this.Label1.Text = "Start Date:";
			this.DTStartDate.Location = new global::System.Drawing.Point(302, 86);
			this.DTStartDate.Name = "DTStartDate";
			this.DTStartDate.Size = new global::System.Drawing.Size(284, 26);
			this.DTStartDate.TabIndex = 42;
			this.Label4.AutoSize = true;
			this.Label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 16f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.Location = new global::System.Drawing.Point(206, 22);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(562, 37);
			this.Label4.TabIndex = 48;
			this.Label4.Text = "DESPATCH REPORT FOR PERIOD";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(302, 150);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(284, 31);
			this.Button1.TabIndex = 49;
			this.Button1.Text = "RUN REPORT";
			this.Button1.UseVisualStyleBackColor = false;
			this.Label5.AutoSize = true;
			this.Label5.BackColor = global::System.Drawing.Color.Red;
			this.Label5.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label5.Location = new global::System.Drawing.Point(1184, 22);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(49, 20);
			this.Label5.TabIndex = 50;
			this.Label5.Text = "Close";
			this.GetCompanyDetailsForCoidBindingSource.DataMember = "GetCompanyDetailsForCoid";
			this.GetCompanyDetailsForCoidBindingSource.DataSource = this.POSDataSet;
			this.GetCompanyDetailsForCoidTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Name = "DespatchReportForPeriod";
			base.Size = new global::System.Drawing.Size(1236, 534);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.DespatchForPeriodBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsForCoidBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040006DC RID: 1756
		private global::System.ComponentModel.IContainer components;
	}
}
