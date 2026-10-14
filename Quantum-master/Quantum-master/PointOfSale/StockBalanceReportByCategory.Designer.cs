namespace PointOfSale
{
	// Token: 0x020001E3 RID: 483
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class StockBalanceReportByCategory : global::System.Windows.Forms.UserControl
	{
		// Token: 0x060054BC RID: 21692 RVA: 0x003110AC File Offset: 0x0030F2AC
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

		// Token: 0x060054BD RID: 21693 RVA: 0x003110FC File Offset: 0x0030F2FC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.chkBranches = new global::System.Windows.Forms.CheckBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.chkCat = new global::System.Windows.Forms.CheckBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.cboCategories = new global::System.Windows.Forms.ComboBox();
			this.chkWithFigures = new global::System.Windows.Forms.CheckBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.chkBins = new global::System.Windows.Forms.CheckBox();
			this.DTStartdate = new global::System.Windows.Forms.DateTimePicker();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.cbobins = new global::System.Windows.Forms.ComboBox();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.cboWithStockBalOnly = new global::System.Windows.Forms.CheckBox();
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.StockBalancesReportBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.StockBalancesReportTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.StockBalancesReportTableAdapter();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.StockBalancesReportBindingSource).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.cboWithStockBalOnly);
			this.GroupBox1.Controls.Add(this.chkBranches);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.chkCat);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.cboCategories);
			this.GroupBox1.Controls.Add(this.chkWithFigures);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.chkBins);
			this.GroupBox1.Controls.Add(this.DTStartdate);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.cbobins);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Size = new global::System.Drawing.Size(1516, 294);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.chkBranches.AutoSize = true;
			this.chkBranches.Location = new global::System.Drawing.Point(801, 128);
			this.chkBranches.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.chkBranches.Name = "chkBranches";
			this.chkBranches.Size = new global::System.Drawing.Size(133, 24);
			this.chkBranches.TabIndex = 54;
			this.chkBranches.Text = "All Branches?";
			this.chkBranches.UseVisualStyleBackColor = true;
			this.chkBranches.Visible = false;
			this.Label4.AutoSize = true;
			this.Label4.BackColor = global::System.Drawing.Color.Red;
			this.Label4.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label4.Location = new global::System.Drawing.Point(1463, 24);
			this.Label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(49, 20);
			this.Label4.TabIndex = 53;
			this.Label4.Text = "Close";
			this.chkCat.AutoSize = true;
			this.chkCat.Location = new global::System.Drawing.Point(584, 172);
			this.chkCat.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.chkCat.Name = "chkCat";
			this.chkCat.Size = new global::System.Drawing.Size(142, 24);
			this.chkCat.TabIndex = 52;
			this.chkCat.Text = "All Categories?";
			this.chkCat.UseVisualStyleBackColor = true;
			this.chkCat.Visible = false;
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(218, 174);
			this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(139, 20);
			this.Label3.TabIndex = 51;
			this.Label3.Text = "Select Categories:";
			this.cboCategories.FormattingEnabled = true;
			this.cboCategories.Location = new global::System.Drawing.Point(374, 169);
			this.cboCategories.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboCategories.Name = "cboCategories";
			this.cboCategories.Size = new global::System.Drawing.Size(172, 28);
			this.cboCategories.TabIndex = 50;
			this.chkWithFigures.AutoSize = true;
			this.chkWithFigures.Checked = true;
			this.chkWithFigures.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.chkWithFigures.Location = new global::System.Drawing.Point(1207, 150);
			this.chkWithFigures.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.chkWithFigures.Name = "chkWithFigures";
			this.chkWithFigures.Size = new global::System.Drawing.Size(191, 24);
			this.chkWithFigures.TabIndex = 49;
			this.chkWithFigures.Text = "With Stock Balances?";
			this.chkWithFigures.UseVisualStyleBackColor = true;
			this.chkWithFigures.Visible = false;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(368, 25);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(462, 32);
			this.Label1.TabIndex = 42;
			this.Label1.Text = "Stock Balances Report by Category";
			this.chkBins.AutoSize = true;
			this.chkBins.Checked = true;
			this.chkBins.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.chkBins.Location = new global::System.Drawing.Point(584, 131);
			this.chkBins.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.chkBins.Name = "chkBins";
			this.chkBins.Size = new global::System.Drawing.Size(96, 24);
			this.chkBins.TabIndex = 48;
			this.chkBins.Text = "All Bins?";
			this.chkBins.UseVisualStyleBackColor = true;
			this.chkBins.Visible = false;
			this.DTStartdate.Location = new global::System.Drawing.Point(374, 88);
			this.DTStartdate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTStartdate.Name = "DTStartdate";
			this.DTStartdate.Size = new global::System.Drawing.Size(298, 26);
			this.DTStartdate.TabIndex = 40;
			this.Label6.AutoSize = true;
			this.Label6.Location = new global::System.Drawing.Point(218, 132);
			this.Label6.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(150, 20);
			this.Label6.TabIndex = 47;
			this.Label6.Text = "Select Bin Location:";
			this.Label6.Visible = false;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(374, 214);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(174, 35);
			this.Button1.TabIndex = 41;
			this.Button1.Text = "RUN REPORT";
			this.Button1.UseVisualStyleBackColor = false;
			this.cbobins.FormattingEnabled = true;
			this.cbobins.Location = new global::System.Drawing.Point(374, 128);
			this.cbobins.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbobins.Name = "cbobins";
			this.cbobins.Size = new global::System.Drawing.Size(172, 28);
			this.cbobins.TabIndex = 46;
			this.cbobins.Visible = false;
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(801, 86);
			this.cboBranch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(256, 28);
			this.cboBranch.TabIndex = 43;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(242, 91);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(122, 20);
			this.Label2.TabIndex = 45;
			this.Label2.Text = "Balances As At:";
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(730, 91);
			this.Label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(60, 20);
			this.Label5.TabIndex = 44;
			this.Label5.Text = "Branch";
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "CompanyDetails";
			reportDataSource.Value = this.GetCompanyDetailsBindingSource;
			reportDataSource2.Name = "Stocks";
			reportDataSource2.Value = this.StockBalancesReportBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.StockBalByCategory.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 294);
			this.ReportViewer1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(1516, 357);
			this.ReportViewer1.TabIndex = 1;
			this.cboWithStockBalOnly.AutoSize = true;
			this.cboWithStockBalOnly.Location = new global::System.Drawing.Point(801, 174);
			this.cboWithStockBalOnly.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboWithStockBalOnly.Name = "cboWithStockBalOnly";
			this.cboWithStockBalOnly.Size = new global::System.Drawing.Size(334, 24);
			this.cboWithStockBalOnly.TabIndex = 55;
			this.cboWithStockBalOnly.Text = "Show products with a Stock Balance only?";
			this.cboWithStockBalOnly.UseVisualStyleBackColor = true;
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.StockBalancesReportBindingSource.DataMember = "StockBalancesReport";
			this.StockBalancesReportBindingSource.DataSource = this.POSDataSet;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.StockBalancesReportTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "StockBalanceReportByCategory";
			base.Size = new global::System.Drawing.Size(1516, 651);
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.StockBalancesReportBindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040024FC RID: 9468
		private global::System.ComponentModel.IContainer components;
	}
}
