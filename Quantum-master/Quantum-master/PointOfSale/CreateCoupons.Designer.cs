namespace PointOfSale
{
	// Token: 0x02000030 RID: 48
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class CreateCoupons : global::System.Windows.Forms.UserControl
	{
		// Token: 0x0600098C RID: 2444 RVA: 0x0005AE14 File Offset: 0x00059014
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

		// Token: 0x0600098D RID: 2445 RVA: 0x0005AE64 File Offset: 0x00059064
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.SelectCouponsbyRefNameBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label8 = new global::System.Windows.Forms.Label();
			this.lblerror = new global::System.Windows.Forms.Label();
			this.txtproductID = new global::System.Windows.Forms.TextBox();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.cboCoupons = new global::System.Windows.Forms.ComboBox();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.Label5 = new global::System.Windows.Forms.Label();
			this.txtProductDesc = new global::System.Windows.Forms.TextBox();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.DGVSearch = new global::System.Windows.Forms.DataGridView();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Label19 = new global::System.Windows.Forms.Label();
			this.txtsearch = new global::System.Windows.Forms.TextBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.txtPercentage = new global::System.Windows.Forms.TextBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.txyQty = new global::System.Windows.Forms.TextBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.txtQtyRequired = new global::System.Windows.Forms.TextBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.txtRef = new global::System.Windows.Forms.TextBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.SelectCouponsbyRefNameTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.SelectCouponsbyRefNameTableAdapter();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SelectCouponsbyRefNameBindingSource).BeginInit();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.Panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).BeginInit();
			this.GroupBox4.SuspendLayout();
			base.SuspendLayout();
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.SelectCouponsbyRefNameBindingSource.DataMember = "SelectCouponsbyRefName";
			this.SelectCouponsbyRefNameBindingSource.DataSource = this.POSDataSet;
			this.GroupBox1.Controls.Add(this.Label8);
			this.GroupBox1.Controls.Add(this.lblerror);
			this.GroupBox1.Controls.Add(this.txtproductID);
			this.GroupBox1.Controls.Add(this.GroupBox2);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.Label5);
			this.GroupBox1.Controls.Add(this.txtProductDesc);
			this.GroupBox1.Controls.Add(this.Panel2);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.txtPercentage);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.txyQty);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.txtQtyRequired);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.txtRef);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(909, 207);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Label8.AutoSize = true;
			this.Label8.BackColor = global::System.Drawing.Color.Red;
			this.Label8.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label8.Location = new global::System.Drawing.Point(873, 16);
			this.Label8.Name = "Label8";
			this.Label8.Size = new global::System.Drawing.Size(33, 13);
			this.Label8.TabIndex = 37;
			this.Label8.Text = "Close";
			this.lblerror.AutoSize = true;
			this.lblerror.Location = new global::System.Drawing.Point(357, 189);
			this.lblerror.Name = "lblerror";
			this.lblerror.Size = new global::System.Drawing.Size(16, 13);
			this.lblerror.TabIndex = 36;
			this.lblerror.Text = "...";
			this.txtproductID.Location = new global::System.Drawing.Point(715, 47);
			this.txtproductID.Name = "txtproductID";
			this.txtproductID.Size = new global::System.Drawing.Size(100, 20);
			this.txtproductID.TabIndex = 35;
			this.txtproductID.Visible = false;
			this.GroupBox2.Controls.Add(this.Label7);
			this.GroupBox2.Controls.Add(this.cboCoupons);
			this.GroupBox2.Controls.Add(this.Button2);
			this.GroupBox2.Location = new global::System.Drawing.Point(679, 87);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new global::System.Drawing.Size(213, 112);
			this.GroupBox2.TabIndex = 34;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Reprint Coupons";
			this.Label7.AutoSize = true;
			this.Label7.Location = new global::System.Drawing.Point(60, 32);
			this.Label7.Name = "Label7";
			this.Label7.Size = new global::System.Drawing.Size(77, 13);
			this.Label7.TabIndex = 33;
			this.Label7.Text = "Select Coupon";
			this.cboCoupons.FormattingEnabled = true;
			this.cboCoupons.Location = new global::System.Drawing.Point(6, 48);
			this.cboCoupons.Name = "cboCoupons";
			this.cboCoupons.Size = new global::System.Drawing.Size(201, 21);
			this.cboCoupons.TabIndex = 2;
			this.Button2.Location = new global::System.Drawing.Point(54, 81);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(110, 23);
			this.Button2.TabIndex = 1;
			this.Button2.Text = "Reprint Coupons";
			this.Button2.UseVisualStyleBackColor = true;
			this.Label6.AutoSize = true;
			this.Label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label6.Location = new global::System.Drawing.Point(355, 18);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(363, 24);
			this.Label6.TabIndex = 33;
			this.Label6.Text = "Select Products for Discount Coupons";
			this.Label5.AutoSize = true;
			this.Label5.Location = new global::System.Drawing.Point(382, 154);
			this.Label5.Name = "Label5";
			this.Label5.Size = new global::System.Drawing.Size(100, 13);
			this.Label5.TabIndex = 32;
			this.Label5.Text = "Product Description";
			this.txtProductDesc.Enabled = false;
			this.txtProductDesc.Location = new global::System.Drawing.Point(488, 151);
			this.txtProductDesc.Name = "txtProductDesc";
			this.txtProductDesc.Size = new global::System.Drawing.Size(185, 20);
			this.txtProductDesc.TabIndex = 31;
			this.Panel2.BackColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.Panel2.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel2.Controls.Add(this.DGVSearch);
			this.Panel2.Controls.Add(this.GroupBox4);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Panel2.Location = new global::System.Drawing.Point(3, 16);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(348, 188);
			this.Panel2.TabIndex = 30;
			this.DGVSearch.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVSearch.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DGVSearch.Location = new global::System.Drawing.Point(0, 69);
			this.DGVSearch.Name = "DGVSearch";
			this.DGVSearch.ReadOnly = true;
			this.DGVSearch.Size = new global::System.Drawing.Size(344, 115);
			this.DGVSearch.StandardTab = true;
			this.DGVSearch.TabIndex = 1;
			this.GroupBox4.Controls.Add(this.Button3);
			this.GroupBox4.Controls.Add(this.Label19);
			this.GroupBox4.Controls.Add(this.txtsearch);
			this.GroupBox4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox4.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Size = new global::System.Drawing.Size(344, 69);
			this.GroupBox4.TabIndex = 0;
			this.GroupBox4.TabStop = false;
			this.Button3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button3.Location = new global::System.Drawing.Point(233, 32);
			this.Button3.Name = "Button3";
			this.Button3.Size = new global::System.Drawing.Size(75, 31);
			this.Button3.TabIndex = 10;
			this.Button3.TabStop = false;
			this.Button3.Text = "Show All";
			this.Button3.UseVisualStyleBackColor = true;
			this.Label19.AutoSize = true;
			this.Label19.Location = new global::System.Drawing.Point(5, 13);
			this.Label19.Name = "Label19";
			this.Label19.Size = new global::System.Drawing.Size(249, 13);
			this.Label19.TabIndex = 9;
			this.Label19.Text = "Type in the space to search by product description:";
			this.txtsearch.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtsearch.Location = new global::System.Drawing.Point(8, 34);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new global::System.Drawing.Size(219, 29);
			this.txtsearch.TabIndex = 0;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(422, 128);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(107, 13);
			this.Label4.TabIndex = 8;
			this.Label4.Text = "Discount Percentage";
			this.txtPercentage.Location = new global::System.Drawing.Point(535, 125);
			this.txtPercentage.Name = "txtPercentage";
			this.txtPercentage.Size = new global::System.Drawing.Size(138, 20);
			this.txtPercentage.TabIndex = 7;
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(383, 99);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(146, 13);
			this.Label3.TabIndex = 6;
			this.Label3.Text = "Number of Discount Coupons";
			this.txyQty.Location = new global::System.Drawing.Point(535, 99);
			this.txyQty.Name = "txyQty";
			this.txyQty.Size = new global::System.Drawing.Size(138, 20);
			this.txyQty.TabIndex = 5;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(357, 76);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(172, 13);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "Quantity Required to justify coupon";
			this.txtQtyRequired.Location = new global::System.Drawing.Point(535, 73);
			this.txtQtyRequired.Name = "txtQtyRequired";
			this.txtQtyRequired.Size = new global::System.Drawing.Size(138, 20);
			this.txtQtyRequired.TabIndex = 3;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(357, 50);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(125, 13);
			this.Label1.TabIndex = 2;
			this.Label1.Text = "Discount Coupons Name";
			this.txtRef.Location = new global::System.Drawing.Point(488, 50);
			this.txtRef.Name = "txtRef";
			this.txtRef.Size = new global::System.Drawing.Size(185, 20);
			this.txtRef.TabIndex = 1;
			this.Button1.Location = new global::System.Drawing.Point(488, 177);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(185, 23);
			this.Button1.TabIndex = 0;
			this.Button1.Text = "Create Coupons";
			this.Button1.UseVisualStyleBackColor = true;
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "CompanyDetails";
			reportDataSource.Value = this.GetCompanyDetailsBindingSource;
			reportDataSource2.Name = "Coupons";
			reportDataSource2.Value = this.SelectCouponsbyRefNameBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.PrintCoupons.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 207);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(909, 150);
			this.ReportViewer1.TabIndex = 2;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.SelectCouponsbyRefNameTableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Name = "CreateCoupons";
			base.Size = new global::System.Drawing.Size(909, 357);
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SelectCouponsbyRefNameBindingSource).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).EndInit();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400047B RID: 1147
		private global::System.ComponentModel.IContainer components;
	}
}
