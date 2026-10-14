namespace PointOfSale
{
	// Token: 0x020001E4 RID: 484
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class StockBalances : global::System.Windows.Forms.UserControl
	{
		// Token: 0x060054F2 RID: 21746 RVA: 0x00312BC8 File Offset: 0x00310DC8
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

		// Token: 0x060054F3 RID: 21747 RVA: 0x00312C18 File Offset: 0x00310E18
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.ReportFetchAllProductBalsAsAtBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.chkActive = new global::System.Windows.Forms.CheckBox();
			this.chkShowWithBal = new global::System.Windows.Forms.CheckBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.DTStartdate = new global::System.Windows.Forms.DateTimePicker();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.ReportFetchAllProductBalsAsAtTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.ReportFetchAllProductBalsAsAtTableAdapter();
			this.chkUseActual = new global::System.Windows.Forms.CheckBox();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ReportFetchAllProductBalsAsAtBindingSource).BeginInit();
			this.GroupBox1.SuspendLayout();
			base.SuspendLayout();
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.ReportFetchAllProductBalsAsAtBindingSource.DataMember = "ReportFetchAllProductBalsAsAt";
			this.ReportFetchAllProductBalsAsAtBindingSource.DataSource = this.POSDataSet;
			this.GroupBox1.Controls.Add(this.chkUseActual);
			this.GroupBox1.Controls.Add(this.chkActive);
			this.GroupBox1.Controls.Add(this.chkShowWithBal);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.DTStartdate);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Size = new global::System.Drawing.Size(1473, 145);
			this.GroupBox1.TabIndex = 2;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Details";
			this.chkActive.AutoSize = true;
			this.chkActive.Location = new global::System.Drawing.Point(861, 100);
			this.chkActive.Name = "chkActive";
			this.chkActive.Size = new global::System.Drawing.Size(319, 24);
			this.chkActive.TabIndex = 17;
			this.chkActive.Text = "Show both active and inactive products?";
			this.chkActive.UseVisualStyleBackColor = true;
			this.chkShowWithBal.AutoSize = true;
			this.chkShowWithBal.Location = new global::System.Drawing.Point(861, 70);
			this.chkShowWithBal.Name = "chkShowWithBal";
			this.chkShowWithBal.Size = new global::System.Drawing.Size(324, 24);
			this.chkShowWithBal.TabIndex = 16;
			this.chkShowWithBal.Text = "Show products with stock balances only?";
			this.chkShowWithBal.UseVisualStyleBackColor = true;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(20, 91);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(122, 20);
			this.Label2.TabIndex = 15;
			this.Label2.Text = "Balances As At:";
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(508, 91);
			this.Label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(60, 20);
			this.Label5.TabIndex = 14;
			this.Label5.Text = "Branch";
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(579, 86);
			this.cboBranch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(256, 28);
			this.cboBranch.TabIndex = 13;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(495, 25);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(440, 32);
			this.Label1.TabIndex = 6;
			this.Label1.Text = "Stock Balances Report for Branch";
			this.Label3.AutoSize = true;
			this.Label3.BackColor = global::System.Drawing.Color.Red;
			this.Label3.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label3.Location = new global::System.Drawing.Point(1420, 24);
			this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(49, 20);
			this.Label3.TabIndex = 5;
			this.Label3.Text = "Close";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(1221, 82);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(174, 35);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "RUN REPORT";
			this.Button1.UseVisualStyleBackColor = false;
			this.DTStartdate.Location = new global::System.Drawing.Point(152, 88);
			this.DTStartdate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTStartdate.Name = "DTStartdate";
			this.DTStartdate.Size = new global::System.Drawing.Size(298, 26);
			this.DTStartdate.TabIndex = 1;
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "CompanyDetails";
			reportDataSource.Value = this.GetCompanyDetailsBindingSource;
			reportDataSource2.Name = "StockBalances";
			reportDataSource2.Value = this.ReportFetchAllProductBalsAsAtBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.StockBal.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 145);
			this.ReportViewer1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(1473, 409);
			this.ReportViewer1.TabIndex = 3;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.ReportFetchAllProductBalsAsAtTableAdapter.ClearBeforeFill = true;
			this.chkUseActual.AutoSize = true;
			this.chkUseActual.Checked = true;
			this.chkUseActual.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.chkUseActual.Location = new global::System.Drawing.Point(169, 56);
			this.chkUseActual.Name = "chkUseActual";
			this.chkUseActual.Size = new global::System.Drawing.Size(267, 24);
			this.chkUseActual.TabIndex = 18;
			this.chkUseActual.Text = "Use Current Running Bal (faster)";
			this.chkUseActual.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "StockBalances";
			base.Size = new global::System.Drawing.Size(1473, 554);
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ReportFetchAllProductBalsAsAtBindingSource).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04002516 RID: 9494
		private global::System.ComponentModel.IContainer components;
	}
}
