namespace PointOfSale
{
	// Token: 0x0200017B RID: 379
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class PurchaseReturnsForSupplier : global::System.Windows.Forms.UserControl
	{
		// Token: 0x060037DD RID: 14301 RVA: 0x001E7810 File Offset: 0x001E5A10
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

		// Token: 0x060037DE RID: 14302 RVA: 0x001E7860 File Offset: 0x001E5A60
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.PurchaseReturnsForSupplierBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.DTEnddate = new global::System.Windows.Forms.DateTimePicker();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.DTStartdate = new global::System.Windows.Forms.DateTimePicker();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.DGVPurchases = new global::System.Windows.Forms.DataGridView();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.PurchaseReturnsForSupplierTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.PurchaseReturnsForSupplierTableAdapter();
			this.Label2 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.PurchaseReturnsForSupplierBindingSource).BeginInit();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DGVPurchases).BeginInit();
			base.SuspendLayout();
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.PurchaseReturnsForSupplierBindingSource.DataMember = "PurchaseReturnsForSupplier";
			this.PurchaseReturnsForSupplierBindingSource.DataSource = this.POSDataSet;
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.DTEnddate);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.DTStartdate);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox1.Size = new global::System.Drawing.Size(1544, 143);
			this.GroupBox1.TabIndex = 1;
			this.GroupBox1.TabStop = false;
			this.Button1.Location = new global::System.Drawing.Point(1224, 78);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(153, 35);
			this.Button1.TabIndex = 21;
			this.Button1.Text = "View Returns";
			this.Button1.UseVisualStyleBackColor = true;
			this.DTEnddate.Location = new global::System.Drawing.Point(550, 78);
			this.DTEnddate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTEnddate.Name = "DTEnddate";
			this.DTEnddate.Size = new global::System.Drawing.Size(298, 26);
			this.DTEnddate.TabIndex = 20;
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(459, 83);
			this.Label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(81, 20);
			this.Label5.TabIndex = 19;
			this.Label5.Text = "End Date:";
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(876, 83);
			this.Label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(60, 20);
			this.Label4.TabIndex = 18;
			this.Label4.Text = "Branch";
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(946, 78);
			this.cboBranch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(256, 28);
			this.cboBranch.TabIndex = 17;
			this.DTStartdate.Location = new global::System.Drawing.Point(114, 78);
			this.DTStartdate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTStartdate.Name = "DTStartdate";
			this.DTStartdate.Size = new global::System.Drawing.Size(298, 26);
			this.DTStartdate.TabIndex = 16;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(9, 83);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(94, 20);
			this.Label1.TabIndex = 15;
			this.Label1.Text = "Select date:";
			this.Label7.AutoSize = true;
			this.Label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label7.Location = new global::System.Drawing.Point(9, 25);
			this.Label7.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label7.Name = "Label7";
			this.Label7.Size = new global::System.Drawing.Size(482, 26);
			this.Label7.TabIndex = 14;
			this.Label7.Text = "PRINT PURCHASE RETURNS VOUCHERS";
			this.GroupBox2.Controls.Add(this.DGVPurchases);
			this.GroupBox2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox2.Location = new global::System.Drawing.Point(0, 143);
			this.GroupBox2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox2.Size = new global::System.Drawing.Size(1544, 249);
			this.GroupBox2.TabIndex = 2;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Purchase Returns for period";
			this.DGVPurchases.AllowUserToAddRows = false;
			this.DGVPurchases.AllowUserToDeleteRows = false;
			this.DGVPurchases.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVPurchases.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.DGVPurchases.Location = new global::System.Drawing.Point(4, 24);
			this.DGVPurchases.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DGVPurchases.Name = "DGVPurchases";
			this.DGVPurchases.ReadOnly = true;
			this.DGVPurchases.Size = new global::System.Drawing.Size(846, 220);
			this.DGVPurchases.TabIndex = 23;
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "CompanyDetails";
			reportDataSource.Value = this.GetCompanyDetailsBindingSource;
			reportDataSource2.Name = "PurchaseReturns";
			reportDataSource2.Value = this.PurchaseReturnsForSupplierBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.PurchaseReturnsForSupplier.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 392);
			this.ReportViewer1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(1544, 462);
			this.ReportViewer1.TabIndex = 3;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.PurchaseReturnsForSupplierTableAdapter.ClearBeforeFill = true;
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Red;
			this.Label2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label2.Location = new global::System.Drawing.Point(1491, 24);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(49, 20);
			this.Label2.TabIndex = 22;
			this.Label2.Text = "Close";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox2);
			base.Controls.Add(this.GroupBox1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "PurchaseReturnsForSupplier";
			base.Size = new global::System.Drawing.Size(1544, 854);
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.PurchaseReturnsForSupplierBindingSource).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.DGVPurchases).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040017A7 RID: 6055
		private global::System.ComponentModel.IContainer components;
	}
}
