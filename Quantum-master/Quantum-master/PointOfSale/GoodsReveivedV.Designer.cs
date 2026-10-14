namespace PointOfSale
{
	// Token: 0x02000065 RID: 101
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class GoodsReveivedV : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06001599 RID: 5529 RVA: 0x000CA5E8 File Offset: 0x000C87E8
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

		// Token: 0x0600159A RID: 5530 RVA: 0x000CA638 File Offset: 0x000C8838
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.GetPurchasesForSupplierBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
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
			this.GetPurchasesForSupplierTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetPurchasesForSupplierTableAdapter();
			this.Label2 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetPurchasesForSupplierBindingSource).BeginInit();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DGVPurchases).BeginInit();
			base.SuspendLayout();
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.GetPurchasesForSupplierBindingSource.DataMember = "GetPurchasesForSupplier";
			this.GetPurchasesForSupplierBindingSource.DataSource = this.POSDataSet;
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
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1041, 93);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Button1.Location = new global::System.Drawing.Point(816, 51);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(102, 23);
			this.Button1.TabIndex = 21;
			this.Button1.Text = "View Purchases";
			this.Button1.UseVisualStyleBackColor = true;
			this.DTEnddate.Location = new global::System.Drawing.Point(367, 51);
			this.DTEnddate.Name = "DTEnddate";
			this.DTEnddate.Size = new global::System.Drawing.Size(200, 20);
			this.DTEnddate.TabIndex = 20;
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(306, 54);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(55, 13);
			this.Label5.TabIndex = 19;
			this.Label5.Text = "End Date:";
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(584, 54);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(41, 13);
			this.Label4.TabIndex = 18;
			this.Label4.Text = "Branch";
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(631, 51);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(172, 21);
			this.cboBranch.TabIndex = 17;
			this.DTStartdate.Location = new global::System.Drawing.Point(76, 51);
			this.DTStartdate.Name = "DTStartdate";
			this.DTStartdate.Size = new global::System.Drawing.Size(200, 20);
			this.DTStartdate.TabIndex = 16;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(6, 54);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(64, 13);
			this.Label1.TabIndex = 15;
			this.Label1.Text = "Select date:";
			this.Label7.AutoSize = true;
			this.Label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label7.Location = new global::System.Drawing.Point(6, 16);
			this.Label7.Name = "Label7";
			this.Label7.Size = new global::System.Drawing.Size(310, 18);
			this.Label7.TabIndex = 14;
			this.Label7.Text = "PRINT GOODS RECEIVED VOUCHERS";
			this.GroupBox2.Controls.Add(this.DGVPurchases);
			this.GroupBox2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox2.Location = new global::System.Drawing.Point(0, 93);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new global::System.Drawing.Size(1041, 162);
			this.GroupBox2.TabIndex = 1;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Purchases for period";
			this.DGVPurchases.AllowUserToAddRows = false;
			this.DGVPurchases.AllowUserToDeleteRows = false;
			this.DGVPurchases.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVPurchases.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.DGVPurchases.Location = new global::System.Drawing.Point(3, 16);
			this.DGVPurchases.Name = "DGVPurchases";
			this.DGVPurchases.ReadOnly = true;
			this.DGVPurchases.Size = new global::System.Drawing.Size(564, 143);
			this.DGVPurchases.TabIndex = 23;
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "CompanyDetails";
			reportDataSource.Value = this.GetCompanyDetailsBindingSource;
			reportDataSource2.Name = "Purchases";
			reportDataSource2.Value = this.GetPurchasesForSupplierBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.GoodsReceivedV.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 255);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(1041, 291);
			this.ReportViewer1.TabIndex = 2;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.GetPurchasesForSupplierTableAdapter.ClearBeforeFill = true;
			this.Label2.AutoSize = true;
			this.Label2.BackColor = global::System.Drawing.Color.Red;
			this.Label2.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label2.Location = new global::System.Drawing.Point(1005, 16);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(33, 13);
			this.Label2.TabIndex = 22;
			this.Label2.Text = "Close";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox2);
			base.Controls.Add(this.GroupBox1);
			base.Name = "GoodsReveivedV";
			base.Size = new global::System.Drawing.Size(1041, 546);
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetPurchasesForSupplierBindingSource).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.DGVPurchases).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000AD1 RID: 2769
		private global::System.ComponentModel.IContainer components;
	}
}
