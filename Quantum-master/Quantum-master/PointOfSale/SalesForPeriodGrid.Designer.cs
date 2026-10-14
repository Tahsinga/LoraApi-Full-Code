namespace PointOfSale
{
	// Token: 0x020001A1 RID: 417
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SalesForPeriodGrid : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06004A90 RID: 19088 RVA: 0x002CCDA8 File Offset: 0x002CAFA8
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

		// Token: 0x06004A91 RID: 19089 RVA: 0x002CCDF8 File Offset: 0x002CAFF8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.cboBranches = new global::System.Windows.Forms.ComboBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.DTEnddate = new global::System.Windows.Forms.DateTimePicker();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.DTstartdate = new global::System.Windows.Forms.DateTimePicker();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.SalesForPeriod2BindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.SalesForPeriod2TableAdapter = new global::PointOfSale.POSDataSetTableAdapters.SalesForPeriod2TableAdapter();
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.chkAllBranches = new global::System.Windows.Forms.CheckBox();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesForPeriod2BindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.chkAllBranches);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.cboBranches);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.DTEnddate);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.DTstartdate);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(938, 190);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Label4.AutoSize = true;
			this.Label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 16f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.Location = new global::System.Drawing.Point(3, 16);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(311, 26);
			this.Label4.TabIndex = 7;
			this.Label4.Text = "STOCKS SOLD FOR PERIOD";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(87, 150);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(121, 30);
			this.Button1.TabIndex = 6;
			this.Button1.Text = "Run Report";
			this.Button1.UseVisualStyleBackColor = false;
			this.cboBranches.FormattingEnabled = true;
			this.cboBranches.Location = new global::System.Drawing.Point(87, 123);
			this.cboBranches.Name = "cboBranches";
			this.cboBranches.Size = new global::System.Drawing.Size(121, 21);
			this.cboBranches.TabIndex = 5;
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(37, 126);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(44, 13);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "Branch:";
			this.DTEnddate.Location = new global::System.Drawing.Point(87, 95);
			this.DTEnddate.Name = "DTEnddate";
			this.DTEnddate.Size = new global::System.Drawing.Size(200, 20);
			this.DTEnddate.TabIndex = 3;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(26, 95);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(55, 13);
			this.Label2.TabIndex = 2;
			this.Label2.Text = "End Date:";
			this.DTstartdate.Location = new global::System.Drawing.Point(87, 69);
			this.DTstartdate.Name = "DTstartdate";
			this.DTstartdate.Size = new global::System.Drawing.Size(200, 20);
			this.DTstartdate.TabIndex = 1;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(26, 69);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(58, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Start Date:";
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "Stocks";
			reportDataSource.Value = this.SalesForPeriod2BindingSource;
			reportDataSource2.Name = "CompanyDetails";
			reportDataSource2.Value = this.GetCompanyDetailsBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.StocksSoldForPeriod.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 190);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(938, 143);
			this.ReportViewer1.TabIndex = 2;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.SalesForPeriod2BindingSource.DataMember = "SalesForPeriod2";
			this.SalesForPeriod2BindingSource.DataSource = this.POSDataSet;
			this.SalesForPeriod2TableAdapter.ClearBeforeFill = true;
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.chkAllBranches.AutoSize = true;
			this.chkAllBranches.Location = new global::System.Drawing.Point(214, 126);
			this.chkAllBranches.Name = "chkAllBranches";
			this.chkAllBranches.Size = new global::System.Drawing.Size(91, 17);
			this.chkAllBranches.TabIndex = 8;
			this.chkAllBranches.Text = "All Branches?";
			this.chkAllBranches.UseVisualStyleBackColor = true;
			this.Label5.AutoSize = true;
			this.Label5.BackColor = global::System.Drawing.Color.Red;
			this.Label5.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label5.Location = new global::System.Drawing.Point(902, 16);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(33, 13);
			this.Label5.TabIndex = 9;
			this.Label5.Text = "Close";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Name = "SalesForPeriodGrid";
			base.Size = new global::System.Drawing.Size(938, 333);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesForPeriod2BindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040020B4 RID: 8372
		private global::System.ComponentModel.IContainer components;
	}
}
