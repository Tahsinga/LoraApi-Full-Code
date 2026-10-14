namespace PointOfSale
{
	// Token: 0x0200021B RID: 539
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class WarehouseStockTransfer : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06006161 RID: 24929 RVA: 0x00377DC8 File Offset: 0x00375FC8
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

		// Token: 0x06006162 RID: 24930 RVA: 0x00377E18 File Offset: 0x00376018
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
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.txtRef = new global::System.Windows.Forms.TextBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.lblinfo = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.dgvBranchStock = new global::System.Windows.Forms.DataGridView();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.dgvWarehouse = new global::System.Windows.Forms.DataGridView();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.FetchTransferDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.FetchTransferDetailsTableAdapter();
			this.FetchBranchToforTransferTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.FetchBranchToforTransferTableAdapter();
			this.FetchBranchFromforTransferTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.FetchBranchFromforTransferTableAdapter();
			this.FetchTransferDetailsToTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.FetchTransferDetailsToTableAdapter();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchTransferDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchBranchToforTransferBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchBranchFromforTransferBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchTransferDetailsToBindingSource).BeginInit();
			this.GroupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvBranchStock).BeginInit();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvWarehouse).BeginInit();
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
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(2, 360);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(133, 13);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "Transfer selected stock to:";
			this.Button1.Location = new global::System.Drawing.Point(319, 355);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(75, 23);
			this.Button1.TabIndex = 4;
			this.Button1.Text = "Transfer Selected Stock Items";
			this.Button1.UseVisualStyleBackColor = true;
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(141, 357);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(172, 21);
			this.cboBranch.TabIndex = 9;
			this.txtRef.Location = new global::System.Drawing.Point(141, 331);
			this.txtRef.Name = "txtRef";
			this.txtRef.Size = new global::System.Drawing.Size(253, 20);
			this.txtRef.TabIndex = 8;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(75, 334);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(60, 13);
			this.Label2.TabIndex = 11;
			this.Label2.Text = "Reference:";
			this.lblinfo.AutoSize = true;
			this.lblinfo.Location = new global::System.Drawing.Point(138, 381);
			this.lblinfo.Name = "lblinfo";
			this.lblinfo.Size = new global::System.Drawing.Size(16, 13);
			this.lblinfo.TabIndex = 12;
			this.lblinfo.Text = "...";
			this.Label3.AutoSize = true;
			this.Label3.BackColor = global::System.Drawing.Color.Red;
			this.Label3.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label3.Location = new global::System.Drawing.Point(964, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(33, 13);
			this.Label3.TabIndex = 13;
			this.Label3.Text = "Close";
			this.GroupBox2.Controls.Add(this.dgvBranchStock);
			this.GroupBox2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.GroupBox2.Location = new global::System.Drawing.Point(512, 267);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new global::System.Drawing.Size(452, 398);
			this.GroupBox2.TabIndex = 15;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "...";
			this.dgvBranchStock.AllowUserToAddRows = false;
			this.dgvBranchStock.AllowUserToDeleteRows = false;
			this.dgvBranchStock.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBranchStock.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvBranchStock.Location = new global::System.Drawing.Point(3, 16);
			this.dgvBranchStock.Name = "dgvBranchStock";
			this.dgvBranchStock.ReadOnly = true;
			this.dgvBranchStock.Size = new global::System.Drawing.Size(446, 379);
			this.dgvBranchStock.TabIndex = 0;
			this.dgvBranchStock.TabStop = false;
			this.GroupBox1.Controls.Add(this.dgvWarehouse);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(964, 267);
			this.GroupBox1.TabIndex = 14;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "...";
			this.dgvWarehouse.AllowUserToAddRows = false;
			this.dgvWarehouse.AllowUserToDeleteRows = false;
			this.dgvWarehouse.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvWarehouse.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvWarehouse.Location = new global::System.Drawing.Point(3, 16);
			this.dgvWarehouse.Name = "dgvWarehouse";
			this.dgvWarehouse.Size = new global::System.Drawing.Size(958, 248);
			this.dgvWarehouse.TabIndex = 0;
			this.dgvWarehouse.TabStop = false;
			this.Label4.AutoSize = true;
			this.Label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.Location = new global::System.Drawing.Point(3, 283);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(446, 17);
			this.Label4.TabIndex = 16;
			this.Label4.Text = "TRANSFER STOCK FROM THE WAREHOUSE TO A BRANCH";
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
			this.ReportViewer1.Location = new global::System.Drawing.Point(42, 410);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(407, 197);
			this.ReportViewer1.TabIndex = 26;
			this.ReportViewer1.Visible = false;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.FetchTransferDetailsTableAdapter.ClearBeforeFill = true;
			this.FetchBranchToforTransferTableAdapter.ClearBeforeFill = true;
			this.FetchBranchFromforTransferTableAdapter.ClearBeforeFill = true;
			this.FetchTransferDetailsToTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.Label4);
			base.Controls.Add(this.GroupBox2);
			base.Controls.Add(this.GroupBox1);
			base.Controls.Add(this.Label3);
			base.Controls.Add(this.lblinfo);
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.txtRef);
			base.Controls.Add(this.cboBranch);
			base.Controls.Add(this.Button1);
			base.Controls.Add(this.Label1);
			base.Name = "WarehouseStockTransfer";
			base.Size = new global::System.Drawing.Size(997, 665);
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchTransferDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchBranchToforTransferBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchBranchFromforTransferBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.FetchTransferDetailsToBindingSource).EndInit();
			this.GroupBox2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvBranchStock).EndInit();
			this.GroupBox1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.dgvWarehouse).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04002AD7 RID: 10967
		private global::System.ComponentModel.IContainer components;
	}
}
