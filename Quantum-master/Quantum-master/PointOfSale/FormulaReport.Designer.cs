namespace PointOfSale
{
	// Token: 0x0200005D RID: 93
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class FormulaReport : global::System.Windows.Forms.Form
	{
		// Token: 0x06001391 RID: 5009 RVA: 0x000BA88C File Offset: 0x000B8A8C
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

		// Token: 0x06001392 RID: 5010 RVA: 0x000BA8DC File Offset: 0x000B8ADC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.GetCompanyDetailsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetCompanyDetailsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsTableAdapter();
			this.SelectFormulaIngridientsBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.SelectFormulaIngridientsTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.SelectFormulaIngridientsTableAdapter();
			this.SelectFormulasByNameBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.SelectFormulasByNameTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.SelectFormulasByNameTableAdapter();
			this.Panel2 = new global::System.Windows.Forms.Panel();
			this.DGVSearch = new global::System.Windows.Forms.DataGridView();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Label19 = new global::System.Windows.Forms.Label();
			this.txtsearch = new global::System.Windows.Forms.TextBox();
			this.lblerror = new global::System.Windows.Forms.Label();
			this.txtDesc = new global::System.Windows.Forms.TextBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.cboFormualas = new global::System.Windows.Forms.ComboBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.txtSearchProductCode = new global::System.Windows.Forms.TextBox();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SelectFormulaIngridientsBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.SelectFormulasByNameBindingSource).BeginInit();
			this.Panel2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).BeginInit();
			this.GroupBox4.SuspendLayout();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.txtSearchProductCode);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.cboFormualas);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.txtDesc);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.lblerror);
			this.GroupBox1.Controls.Add(this.Panel2);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1050, 185);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "CompanyDetails";
			reportDataSource.Value = this.GetCompanyDetailsBindingSource;
			reportDataSource2.Name = "manu_detail";
			reportDataSource2.Value = this.SelectFormulaIngridientsBindingSource;
			reportDataSource3.Name = "manu_header";
			reportDataSource3.Value = this.SelectFormulasByNameBindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource3);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.FormulaReport.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 185);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(1050, 411);
			this.ReportViewer1.TabIndex = 1;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.GetCompanyDetailsBindingSource.DataMember = "GetCompanyDetails";
			this.GetCompanyDetailsBindingSource.DataSource = this.POSDataSet;
			this.GetCompanyDetailsTableAdapter.ClearBeforeFill = true;
			this.SelectFormulaIngridientsBindingSource.DataMember = "SelectFormulaIngridients";
			this.SelectFormulaIngridientsBindingSource.DataSource = this.POSDataSet;
			this.SelectFormulaIngridientsTableAdapter.ClearBeforeFill = true;
			this.SelectFormulasByNameBindingSource.DataMember = "SelectFormulasByName";
			this.SelectFormulasByNameBindingSource.DataSource = this.POSDataSet;
			this.SelectFormulasByNameTableAdapter.ClearBeforeFill = true;
			this.Panel2.BackColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.Panel2.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel2.Controls.Add(this.DGVSearch);
			this.Panel2.Controls.Add(this.GroupBox4);
			this.Panel2.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Panel2.Location = new global::System.Drawing.Point(3, 16);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new global::System.Drawing.Size(316, 166);
			this.Panel2.TabIndex = 31;
			this.DGVSearch.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVSearch.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DGVSearch.Location = new global::System.Drawing.Point(0, 69);
			this.DGVSearch.Name = "DGVSearch";
			this.DGVSearch.ReadOnly = true;
			this.DGVSearch.Size = new global::System.Drawing.Size(312, 93);
			this.DGVSearch.StandardTab = true;
			this.DGVSearch.TabIndex = 2;
			this.GroupBox4.Controls.Add(this.Button3);
			this.GroupBox4.Controls.Add(this.Label19);
			this.GroupBox4.Controls.Add(this.txtsearch);
			this.GroupBox4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox4.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Size = new global::System.Drawing.Size(312, 69);
			this.GroupBox4.TabIndex = 1;
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
			this.Label19.TabIndex = 0;
			this.Label19.Text = "Type in the space to search by product description:";
			this.txtsearch.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtsearch.Location = new global::System.Drawing.Point(8, 34);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new global::System.Drawing.Size(219, 29);
			this.txtsearch.TabIndex = 1;
			this.lblerror.AutoSize = true;
			this.lblerror.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lblerror.Location = new global::System.Drawing.Point(319, 169);
			this.lblerror.Name = "lblerror";
			this.lblerror.Size = new global::System.Drawing.Size(16, 13);
			this.lblerror.TabIndex = 61;
			this.lblerror.Text = "...";
			this.txtDesc.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtDesc.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.txtDesc.Enabled = false;
			this.txtDesc.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtDesc.ForeColor = global::System.Drawing.Color.Red;
			this.txtDesc.Location = new global::System.Drawing.Point(319, 33);
			this.txtDesc.Multiline = true;
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.ReadOnly = true;
			this.txtDesc.Size = new global::System.Drawing.Size(728, 54);
			this.txtDesc.TabIndex = 63;
			this.txtDesc.TabStop = false;
			this.Label2.AutoSize = true;
			this.Label2.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(319, 16);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(169, 17);
			this.Label2.TabIndex = 62;
			this.Label2.Text = "PRODUCT TO BE MADE:";
			this.Button2.Location = new global::System.Drawing.Point(435, 93);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(116, 23);
			this.Button2.TabIndex = 71;
			this.Button2.Text = "Load Formula";
			this.Button2.UseVisualStyleBackColor = true;
			this.cboFormualas.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboFormualas.FormattingEnabled = true;
			this.cboFormualas.Location = new global::System.Drawing.Point(435, 122);
			this.cboFormualas.Name = "cboFormualas";
			this.cboFormualas.Size = new global::System.Drawing.Size(168, 21);
			this.cboFormualas.TabIndex = 73;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(349, 125);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(80, 13);
			this.Label1.TabIndex = 72;
			this.Label1.Text = "Select Formula:";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(435, 149);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(116, 23);
			this.Button1.TabIndex = 74;
			this.Button1.Text = "RUN REPORT";
			this.Button1.UseVisualStyleBackColor = false;
			this.txtSearchProductCode.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtSearchProductCode.Location = new global::System.Drawing.Point(692, 112);
			this.txtSearchProductCode.Name = "txtSearchProductCode";
			this.txtSearchProductCode.Size = new global::System.Drawing.Size(122, 26);
			this.txtSearchProductCode.TabIndex = 75;
			this.txtSearchProductCode.TabStop = false;
			this.txtSearchProductCode.Visible = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1050, 596);
			base.Controls.Add(this.ReportViewer1);
			base.Controls.Add(this.GroupBox1);
			base.Name = "FormulaReport";
			this.Text = "Formula Report";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SelectFormulaIngridientsBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.SelectFormulasByNameBindingSource).EndInit();
			this.Panel2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).EndInit();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040009F2 RID: 2546
		private global::System.ComponentModel.IContainer components;
	}
}
