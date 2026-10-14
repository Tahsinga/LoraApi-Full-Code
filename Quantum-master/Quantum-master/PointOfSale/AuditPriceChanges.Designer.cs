namespace PointOfSale
{
	// Token: 0x0200000F RID: 15
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class AuditPriceChanges : global::System.Windows.Forms.Form
	{
		// Token: 0x06000296 RID: 662 RVA: 0x00017E34 File Offset: 0x00016034
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

		// Token: 0x06000297 RID: 663 RVA: 0x00017E84 File Offset: 0x00016084
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.Audit_PriceChangesSelectBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.chkAllProducts = new global::System.Windows.Forms.CheckBox();
			this.lblerror = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.lblDesc = new global::System.Windows.Forms.TextBox();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.DGVSearch = new global::System.Windows.Forms.DataGridView();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Label19 = new global::System.Windows.Forms.Label();
			this.txtsearch = new global::System.Windows.Forms.TextBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.DTend = new global::System.Windows.Forms.DateTimePicker();
			this.DTstart = new global::System.Windows.Forms.DateTimePicker();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.Audit_PriceChangesSelectTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.Audit_PriceChangesSelectTableAdapter();
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			((global::System.ComponentModel.ISupportInitialize)this.Audit_PriceChangesSelectBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			this.GroupBox1.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).BeginInit();
			this.Panel1.SuspendLayout();
			base.SuspendLayout();
			this.Audit_PriceChangesSelectBindingSource.DataMember = "Audit_PriceChangesSelect";
			this.Audit_PriceChangesSelectBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.GroupBox1.Controls.Add(this.chkAllProducts);
			this.GroupBox1.Controls.Add(this.lblerror);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.lblDesc);
			this.GroupBox1.Controls.Add(this.GroupBox4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.DTend);
			this.GroupBox1.Controls.Add(this.DTstart);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(871, 242);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.chkAllProducts.AutoSize = true;
			this.chkAllProducts.Location = new global::System.Drawing.Point(403, 163);
			this.chkAllProducts.Name = "chkAllProducts";
			this.chkAllProducts.Size = new global::System.Drawing.Size(127, 17);
			this.chkAllProducts.TabIndex = 33;
			this.chkAllProducts.Text = "View for all products?";
			this.chkAllProducts.UseVisualStyleBackColor = true;
			this.lblerror.AutoSize = true;
			this.lblerror.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lblerror.Location = new global::System.Drawing.Point(315, 226);
			this.lblerror.Name = "lblerror";
			this.lblerror.Size = new global::System.Drawing.Size(16, 13);
			this.lblerror.TabIndex = 32;
			this.lblerror.Text = "...";
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(355, 113);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(35, 13);
			this.Label4.TabIndex = 22;
			this.Label4.Text = "Desc:";
			this.lblDesc.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblDesc.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblDesc.ForeColor = global::System.Drawing.Color.Red;
			this.lblDesc.Location = new global::System.Drawing.Point(396, 107);
			this.lblDesc.Multiline = true;
			this.lblDesc.Name = "lblDesc";
			this.lblDesc.ReadOnly = true;
			this.lblDesc.Size = new global::System.Drawing.Size(463, 42);
			this.lblDesc.TabIndex = 21;
			this.lblDesc.TabStop = false;
			this.GroupBox4.Controls.Add(this.DGVSearch);
			this.GroupBox4.Controls.Add(this.Panel1);
			this.GroupBox4.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.GroupBox4.Location = new global::System.Drawing.Point(3, 16);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Size = new global::System.Drawing.Size(312, 223);
			this.GroupBox4.TabIndex = 20;
			this.GroupBox4.TabStop = false;
			this.DGVSearch.AllowUserToAddRows = false;
			this.DGVSearch.AllowUserToDeleteRows = false;
			this.DGVSearch.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVSearch.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DGVSearch.Location = new global::System.Drawing.Point(3, 80);
			this.DGVSearch.Name = "DGVSearch";
			this.DGVSearch.ReadOnly = true;
			this.DGVSearch.Size = new global::System.Drawing.Size(306, 140);
			this.DGVSearch.TabIndex = 12;
			this.Panel1.Controls.Add(this.Button3);
			this.Panel1.Controls.Add(this.Label19);
			this.Panel1.Controls.Add(this.txtsearch);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel1.Location = new global::System.Drawing.Point(3, 16);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(306, 64);
			this.Panel1.TabIndex = 11;
			this.Button3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button3.Location = new global::System.Drawing.Point(230, 26);
			this.Button3.Name = "Button3";
			this.Button3.Size = new global::System.Drawing.Size(75, 31);
			this.Button3.TabIndex = 13;
			this.Button3.TabStop = false;
			this.Button3.Text = "Show All";
			this.Button3.UseVisualStyleBackColor = true;
			this.Label19.AutoSize = true;
			this.Label19.Location = new global::System.Drawing.Point(2, 7);
			this.Label19.Name = "Label19";
			this.Label19.Size = new global::System.Drawing.Size(249, 13);
			this.Label19.TabIndex = 12;
			this.Label19.Text = "Type in the space to search by product description:";
			this.txtsearch.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtsearch.Location = new global::System.Drawing.Point(5, 28);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new global::System.Drawing.Size(219, 29);
			this.txtsearch.TabIndex = 11;
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(335, 17);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(279, 24);
			this.Label3.TabIndex = 14;
			this.Label3.Text = "View Prices Changes Audit Trail";
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(336, 85);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(55, 13);
			this.Label2.TabIndex = 13;
			this.Label2.Text = "End Date:";
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(332, 59);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(58, 13);
			this.Label1.TabIndex = 12;
			this.Label1.Text = "Start Date:";
			this.DTend.Location = new global::System.Drawing.Point(396, 81);
			this.DTend.Name = "DTend";
			this.DTend.Size = new global::System.Drawing.Size(200, 20);
			this.DTend.TabIndex = 11;
			this.DTstart.Location = new global::System.Drawing.Point(396, 55);
			this.DTstart.Name = "DTstart";
			this.DTstart.Size = new global::System.Drawing.Size(200, 20);
			this.DTstart.TabIndex = 10;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(396, 192);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(122, 23);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "View Report";
			this.Button1.UseVisualStyleBackColor = false;
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "PriceChangeAudits";
			reportDataSource.Value = this.Audit_PriceChangesSelectBindingSource;
			reportDataSource2.Name = "CompanyDetails";
			reportDataSource2.Value = this.GetCompanyDetailsBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.AuditPriceChangesReport.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 242);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(871, 308);
			this.ReportViewer1.TabIndex = 1;
			this.Audit_PriceChangesSelectTableAdapter.ClearBeforeFill = true;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(871, 550);
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Name = "AuditPriceChanges";
			this.Text = "AuditPriceChanges";
			((global::System.ComponentModel.ISupportInitialize)this.Audit_PriceChangesSelectBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox4.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400011E RID: 286
		private global::System.ComponentModel.IContainer components;
	}
}
