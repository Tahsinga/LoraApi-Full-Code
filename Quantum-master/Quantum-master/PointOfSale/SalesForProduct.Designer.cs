namespace PointOfSale
{
	// Token: 0x020001A3 RID: 419
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SalesForProduct : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06004AE2 RID: 19170 RVA: 0x002CED0C File Offset: 0x002CCF0C
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

		// Token: 0x06004AE3 RID: 19171 RVA: 0x002CED5C File Offset: 0x002CCF5C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.SalesForProductBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.cboExpDate = new global::System.Windows.Forms.ComboBox();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.cboBatchNum = new global::System.Windows.Forms.ComboBox();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.txtSearchProductCode = new global::System.Windows.Forms.TextBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.DTEndDate = new global::System.Windows.Forms.DateTimePicker();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.DTStartDate = new global::System.Windows.Forms.DateTimePicker();
			this.lblerror = new global::System.Windows.Forms.Label();
			this.lblDesc = new global::System.Windows.Forms.TextBox();
			this.Panel4 = new global::System.Windows.Forms.Panel();
			this.DGVSearch = new global::System.Windows.Forms.DataGridView();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.Label10 = new global::System.Windows.Forms.Label();
			this.Button4 = new global::System.Windows.Forms.Button();
			this.Label16 = new global::System.Windows.Forms.Label();
			this.txtsearch = new global::System.Windows.Forms.TextBox();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.SalesForProductTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.SalesForProductTableAdapter();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesForProductBindingSource).BeginInit();
			this.Panel1.SuspendLayout();
			this.Panel4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).BeginInit();
			this.GroupBox4.SuspendLayout();
			this.Panel2.SuspendLayout();
			base.SuspendLayout();
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.SalesForProductBindingSource.DataMember = "SalesForProduct";
			this.SalesForProductBindingSource.DataSource = this.POSDataSet;
			this.Panel1.Controls.Add(this.cboExpDate);
			this.Panel1.Controls.Add(this.Label6);
			this.Panel1.Controls.Add(this.cboBatchNum);
			this.Panel1.Controls.Add(this.Label5);
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Controls.Add(this.txtSearchProductCode);
			this.Panel1.Controls.Add(this.Button1);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.cboBranch);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.DTEndDate);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Controls.Add(this.DTStartDate);
			this.Panel1.Controls.Add(this.lblerror);
			this.Panel1.Controls.Add(this.lblDesc);
			this.Panel1.Controls.Add(this.Panel4);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(1410, 297);
			this.Panel1.TabIndex = 0;
			this.cboExpDate.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboExpDate.FormattingEnabled = true;
			this.cboExpDate.Location = new global::System.Drawing.Point(1086, 178);
			this.cboExpDate.Name = "cboExpDate";
			this.cboExpDate.Size = new global::System.Drawing.Size(284, 28);
			this.cboExpDate.TabIndex = 48;
			this.cboExpDate.Visible = false;
			this.Label6.AutoSize = true;
			this.Label6.Location = new global::System.Drawing.Point(937, 183);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(143, 20);
			this.Label6.TabIndex = 47;
			this.Label6.Text = "Select Expiry Date:";
			this.Label6.Visible = false;
			this.cboBatchNum.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboBatchNum.FormattingEnabled = true;
			this.cboBatchNum.Location = new global::System.Drawing.Point(644, 178);
			this.cboBatchNum.Name = "cboBatchNum";
			this.cboBatchNum.Size = new global::System.Drawing.Size(284, 28);
			this.cboBatchNum.TabIndex = 46;
			this.cboBatchNum.Visible = false;
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(475, 181);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(164, 20);
			this.Label5.TabIndex = 45;
			this.Label5.Text = "Select Batch Number:";
			this.Label5.Visible = false;
			this.Label4.AutoSize = true;
			this.Label4.BackColor = global::System.Drawing.Color.Red;
			this.Label4.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.Location = new global::System.Drawing.Point(1334, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(76, 29);
			this.Label4.TabIndex = 44;
			this.Label4.Text = "Close";
			this.txtSearchProductCode.Location = new global::System.Drawing.Point(1086, 212);
			this.txtSearchProductCode.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtSearchProductCode.Name = "txtSearchProductCode";
			this.txtSearchProductCode.Size = new global::System.Drawing.Size(148, 26);
			this.txtSearchProductCode.TabIndex = 43;
			this.txtSearchProductCode.TabStop = false;
			this.txtSearchProductCode.Visible = false;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(644, 212);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(283, 56);
			this.Button1.TabIndex = 42;
			this.Button1.Text = "RUN SALES FOR PRODUCT REPORT";
			this.Button1.UseVisualStyleBackColor = false;
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(574, 147);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(64, 20);
			this.Label3.TabIndex = 41;
			this.Label3.Text = "Branch:";
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(644, 144);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(284, 28);
			this.cboBranch.TabIndex = 40;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(999, 117);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(81, 20);
			this.Label2.TabIndex = 39;
			this.Label2.Text = "End Date:";
			this.DTEndDate.Location = new global::System.Drawing.Point(1086, 112);
			this.DTEndDate.Name = "DTEndDate";
			this.DTEndDate.Size = new global::System.Drawing.Size(284, 26);
			this.DTEndDate.TabIndex = 38;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(551, 116);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(87, 20);
			this.Label1.TabIndex = 37;
			this.Label1.Text = "Start Date:";
			this.DTStartDate.Location = new global::System.Drawing.Point(644, 112);
			this.DTStartDate.Name = "DTStartDate";
			this.DTStartDate.Size = new global::System.Drawing.Size(284, 26);
			this.DTStartDate.TabIndex = 36;
			this.lblerror.AutoSize = true;
			this.lblerror.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lblerror.Location = new global::System.Drawing.Point(472, 277);
			this.lblerror.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblerror.Name = "lblerror";
			this.lblerror.Size = new global::System.Drawing.Size(21, 20);
			this.lblerror.TabIndex = 35;
			this.lblerror.Text = "...";
			this.lblDesc.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblDesc.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblDesc.ForeColor = global::System.Drawing.Color.Red;
			this.lblDesc.Location = new global::System.Drawing.Point(472, 2);
			this.lblDesc.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.lblDesc.Multiline = true;
			this.lblDesc.Name = "lblDesc";
			this.lblDesc.ReadOnly = true;
			this.lblDesc.Size = new global::System.Drawing.Size(900, 99);
			this.lblDesc.TabIndex = 34;
			this.lblDesc.TabStop = false;
			this.Panel4.BackColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.Panel4.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel4.Controls.Add(this.DGVSearch);
			this.Panel4.Controls.Add(this.GroupBox4);
			this.Panel4.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Panel4.Location = new global::System.Drawing.Point(0, 0);
			this.Panel4.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Panel4.Name = "Panel4";
			this.Panel4.Size = new global::System.Drawing.Size(472, 297);
			this.Panel4.TabIndex = 33;
			this.DGVSearch.AllowUserToAddRows = false;
			this.DGVSearch.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVSearch.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DGVSearch.Location = new global::System.Drawing.Point(0, 106);
			this.DGVSearch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DGVSearch.Name = "DGVSearch";
			this.DGVSearch.ReadOnly = true;
			this.DGVSearch.Size = new global::System.Drawing.Size(468, 187);
			this.DGVSearch.TabIndex = 3;
			this.GroupBox4.Controls.Add(this.Label10);
			this.GroupBox4.Controls.Add(this.Button4);
			this.GroupBox4.Controls.Add(this.Label16);
			this.GroupBox4.Controls.Add(this.txtsearch);
			this.GroupBox4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox4.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox4.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox4.Size = new global::System.Drawing.Size(468, 106);
			this.GroupBox4.TabIndex = 0;
			this.GroupBox4.TabStop = false;
			this.Label10.AutoSize = true;
			this.Label10.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 7.5f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label10.ForeColor = global::System.Drawing.Color.Red;
			this.Label10.Location = new global::System.Drawing.Point(388, 20);
			this.Label10.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label10.Name = "Label10";
			this.Label10.Size = new global::System.Drawing.Size(65, 18);
			this.Label10.TabIndex = 48;
			this.Label10.Text = "Page Up";
			this.Button4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button4.Location = new global::System.Drawing.Point(350, 49);
			this.Button4.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button4.Name = "Button4";
			this.Button4.Size = new global::System.Drawing.Size(112, 48);
			this.Button4.TabIndex = 10;
			this.Button4.TabStop = false;
			this.Button4.Text = "Show All";
			this.Button4.UseVisualStyleBackColor = true;
			this.Label16.AutoSize = true;
			this.Label16.Location = new global::System.Drawing.Point(8, 20);
			this.Label16.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label16.Name = "Label16";
			this.Label16.Size = new global::System.Drawing.Size(366, 20);
			this.Label16.TabIndex = 9;
			this.Label16.Text = "Type in the space to search by product description:";
			this.txtsearch.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtsearch.Location = new global::System.Drawing.Point(12, 52);
			this.txtsearch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new global::System.Drawing.Size(326, 39);
			this.txtsearch.TabIndex = 3;
			this.Panel2.Controls.Add(this.ReportViewer1);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Panel2.Location = new global::System.Drawing.Point(0, 297);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(1410, 365);
			this.Panel2.TabIndex = 1;
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "CompanyDetails";
			reportDataSource.Value = this.GetCompanyDetailsBindingSource;
			reportDataSource2.Name = "Sales";
			reportDataSource2.Value = this.SalesForProductBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.SalesForProduct.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 0);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(1410, 365);
			this.ReportViewer1.TabIndex = 0;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.SalesForProductTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.Panel1);
			base.Name = "SalesForProduct";
			base.Size = new global::System.Drawing.Size(1410, 662);
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SalesForProductBindingSource).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel4.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).EndInit();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			this.Panel2.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040020D8 RID: 8408
		private global::System.ComponentModel.IContainer components;
	}
}
