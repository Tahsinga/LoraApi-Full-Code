namespace PointOfSale
{
	// Token: 0x02000219 RID: 537
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ViewStockTransfers : global::System.Windows.Forms.UserControl
	{
		// Token: 0x0600606A RID: 24682 RVA: 0x00371028 File Offset: 0x0036F228
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

		// Token: 0x0600606B RID: 24683 RVA: 0x00371078 File Offset: 0x0036F278
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.FetchTransferDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.FetchBranchToforTransferBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.FetchBranchFromforTransferBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.FetchTransferDetailsToBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.cboPrinters = new global::System.Windows.Forms.ComboBox();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.txtFontSize = new global::System.Windows.Forms.TextBox();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.DTEndDate = new global::System.Windows.Forms.DateTimePicker();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.DTStartDate = new global::System.Windows.Forms.DateTimePicker();
			this.cboTransfers = new global::System.Windows.Forms.ComboBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.FetchTransferDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.FetchTransferDetailsTableAdapter();
			this.FetchBranchToforTransferTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.FetchBranchToforTransferTableAdapter();
			this.FetchBranchFromforTransferTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.FetchBranchFromforTransferTableAdapter();
			this.FetchTransferDetailsToTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.FetchTransferDetailsToTableAdapter();
			this.PrintDocument1 = new global::System.Drawing.Printing.PrintDocument();
			this.chkShowCost = new global::System.Windows.Forms.CheckBox();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchTransferDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchBranchToforTransferBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchBranchFromforTransferBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchTransferDetailsToBindingSource).BeginInit();
			this.GroupBox1.SuspendLayout();
			this.Panel1.SuspendLayout();
			base.SuspendLayout();
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.FetchTransferDetailsBindingSource.DataMember = "FetchTransferDetails";
			this.FetchTransferDetailsBindingSource.DataSource = this.POSDataSet;
			this.FetchBranchToforTransferBindingSource.DataMember = "FetchBranchToforTransfer";
			this.FetchBranchToforTransferBindingSource.DataSource = this.POSDataSet;
			this.FetchBranchFromforTransferBindingSource.DataMember = "FetchBranchFromforTransfer";
			this.FetchBranchFromforTransferBindingSource.DataSource = this.POSDataSet;
			this.FetchTransferDetailsToBindingSource.DataMember = "FetchTransferDetailsTo";
			this.FetchTransferDetailsToBindingSource.DataSource = this.POSDataSet;
			this.GroupBox1.Controls.Add(this.chkShowCost);
			this.GroupBox1.Controls.Add(this.Panel1);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.DTEndDate);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.DTStartDate);
			this.GroupBox1.Controls.Add(this.cboTransfers);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Size = new global::System.Drawing.Size(1396, 298);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Panel1.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 192);
			this.Panel1.Controls.Add(this.cboPrinters);
			this.Panel1.Controls.Add(this.Label7);
			this.Panel1.Controls.Add(this.Button3);
			this.Panel1.Controls.Add(this.txtFontSize);
			this.Panel1.Controls.Add(this.Label6);
			this.Panel1.Location = new global::System.Drawing.Point(515, 226);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(874, 61);
			this.Panel1.TabIndex = 47;
			this.cboPrinters.FormattingEnabled = true;
			this.cboPrinters.Location = new global::System.Drawing.Point(554, 19);
			this.cboPrinters.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboPrinters.Name = "cboPrinters";
			this.cboPrinters.Size = new global::System.Drawing.Size(316, 28);
			this.cboPrinters.TabIndex = 45;
			this.Label7.AutoSize = true;
			this.Label7.Location = new global::System.Drawing.Point(487, 22);
			this.Label7.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label7.Name = "Label7";
			this.Label7.Size = new global::System.Drawing.Size(59, 20);
			this.Label7.TabIndex = 46;
			this.Label7.Text = "Printer:";
			this.Button3.Location = new global::System.Drawing.Point(6, 15);
			this.Button3.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button3.Name = "Button3";
			this.Button3.Size = new global::System.Drawing.Size(300, 35);
			this.Button3.TabIndex = 10;
			this.Button3.Text = "Print on Receipt Printer";
			this.Button3.UseVisualStyleBackColor = true;
			this.txtFontSize.Location = new global::System.Drawing.Point(402, 19);
			this.txtFontSize.Name = "txtFontSize";
			this.txtFontSize.Size = new global::System.Drawing.Size(57, 26);
			this.txtFontSize.TabIndex = 11;
			this.txtFontSize.Text = "8";
			this.Label6.AutoSize = true;
			this.Label6.Location = new global::System.Drawing.Point(314, 22);
			this.Label6.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(81, 20);
			this.Label6.TabIndex = 12;
			this.Label6.Text = "Font Size:";
			this.Label5.AutoSize = true;
			this.Label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label5.Location = new global::System.Drawing.Point(434, 25);
			this.Label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(411, 32);
			this.Label5.TabIndex = 9;
			this.Label5.Text = "View Stock Transfers for Period";
			this.Button2.Location = new global::System.Drawing.Point(197, 252);
			this.Button2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(300, 35);
			this.Button2.TabIndex = 8;
			this.Button2.Text = "View Transfer Report";
			this.Button2.UseVisualStyleBackColor = true;
			this.Label4.AutoSize = true;
			this.Label4.BackColor = global::System.Drawing.Color.Red;
			this.Label4.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label4.Location = new global::System.Drawing.Point(1343, 24);
			this.Label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(49, 20);
			this.Label4.TabIndex = 7;
			this.Label4.Text = "Close";
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(7, 215);
			this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(180, 20);
			this.Label3.TabIndex = 6;
			this.Label3.Text = "Select Transfer from list:";
			this.Button1.Location = new global::System.Drawing.Point(197, 166);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(300, 35);
			this.Button1.TabIndex = 5;
			this.Button1.Text = "Reload Transfer List";
			this.Button1.UseVisualStyleBackColor = true;
			this.DTEndDate.Location = new global::System.Drawing.Point(197, 126);
			this.DTEndDate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTEndDate.Name = "DTEndDate";
			this.DTEndDate.Size = new global::System.Drawing.Size(298, 26);
			this.DTEndDate.TabIndex = 4;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(51, 131);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(130, 20);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "Select End Date:";
			this.DTStartDate.Location = new global::System.Drawing.Point(197, 86);
			this.DTStartDate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTStartDate.Name = "DTStartDate";
			this.DTStartDate.Size = new global::System.Drawing.Size(298, 26);
			this.DTStartDate.TabIndex = 2;
			this.cboTransfers.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboTransfers.FormattingEnabled = true;
			this.cboTransfers.Location = new global::System.Drawing.Point(197, 211);
			this.cboTransfers.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboTransfers.Name = "cboTransfers";
			this.cboTransfers.Size = new global::System.Drawing.Size(298, 28);
			this.cboTransfers.TabIndex = 1;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(51, 91);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(136, 20);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Select Start Date:";
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "CompanyDetails";
			reportDataSource.Value = this.GetCompanyDetailsBindingSource;
			reportDataSource2.Name = "TransferDetails";
			reportDataSource2.Value = this.FetchTransferDetailsBindingSource;
			reportDataSource3.Name = "BranchTo";
			reportDataSource3.Value = this.FetchBranchToforTransferBindingSource;
			reportDataSource4.Name = "BranchFrom";
			reportDataSource4.Value = this.FetchBranchFromforTransferBindingSource;
			reportDataSource5.Name = "TransferTo";
			reportDataSource5.Value = this.FetchTransferDetailsToBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource3);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource4);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource5);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.StocksTransfered.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 298);
			this.ReportViewer1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(1396, 344);
			this.ReportViewer1.TabIndex = 26;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.FetchTransferDetailsTableAdapter.ClearBeforeFill = true;
			this.FetchBranchToforTransferTableAdapter.ClearBeforeFill = true;
			this.FetchBranchFromforTransferTableAdapter.ClearBeforeFill = true;
			this.FetchTransferDetailsToTableAdapter.ClearBeforeFill = true;
			this.chkShowCost.AutoSize = true;
			this.chkShowCost.Location = new global::System.Drawing.Point(16, 258);
			this.chkShowCost.Name = "chkShowCost";
			this.chkShowCost.Size = new global::System.Drawing.Size(174, 24);
			this.chkShowCost.TabIndex = 48;
			this.chkShowCost.Text = "Show Selling Price?";
			this.chkShowCost.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "ViewStockTransfers";
			base.Size = new global::System.Drawing.Size(1396, 642);
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchTransferDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchBranchToforTransferBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchBranchFromforTransferBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchTransferDetailsToBindingSource).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04002A67 RID: 10855
		private global::System.ComponentModel.IContainer components;
	}
}
