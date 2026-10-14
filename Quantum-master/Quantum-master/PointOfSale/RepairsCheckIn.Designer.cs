namespace PointOfSale
{
	// Token: 0x02000181 RID: 385
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class RepairsCheckIn : global::System.Windows.Forms.Form
	{
		// Token: 0x06003939 RID: 14649 RVA: 0x001F2B18 File Offset: 0x001F0D18
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

		// Token: 0x0600393A RID: 14650 RVA: 0x001F2B68 File Offset: 0x001F0D68
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			global::Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new global::Microsoft.Reporting.WinForms.ReportDataSource();
			this.ReportViewer1 = new global::Microsoft.Reporting.WinForms.ReportViewer();
			this.POSDataSet = new global::PointOfSale.POSDataSet();
			this.GetCompanyDetailsForCoidBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetCompanyDetailsForCoidTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetCompanyDetailsForCoidTableAdapter();
			this.RepairsViewBindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.RepairsViewTableAdapter = new global::PointOfSale.POSDataSetTableAdapters.RepairsViewTableAdapter();
			this.GetBranchDetails1BindingSource = new global::System.Windows.Forms.BindingSource(this.components);
			this.GetBranchDetails1TableAdapter = new global::PointOfSale.POSDataSetTableAdapters.GetBranchDetails1TableAdapter();
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsForCoidBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.RepairsViewBindingSource).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetBranchDetails1BindingSource).BeginInit();
			base.SuspendLayout();
			this.ReportViewer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			reportDataSource.Name = "CompanyDetails";
			reportDataSource.Value = this.GetCompanyDetailsForCoidBindingSource;
			reportDataSource2.Name = "Repairs";
			reportDataSource2.Value = this.RepairsViewBindingSource;
			reportDataSource3.Name = "BranchDetails";
			reportDataSource3.Value = this.GetBranchDetails1BindingSource;
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.ReportViewer1.LocalReport.DataSources.Add(reportDataSource3);
			this.ReportViewer1.LocalReport.ReportEmbeddedResource = "PointOfSale.RepairsCheckIn.rdlc";
			this.ReportViewer1.Location = new global::System.Drawing.Point(0, 0);
			this.ReportViewer1.Name = "ReportViewer1";
			this.ReportViewer1.Size = new global::System.Drawing.Size(1251, 599);
			this.ReportViewer1.TabIndex = 0;
			this.POSDataSet.DataSetName = "POSDataSet";
			this.POSDataSet.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			this.GetCompanyDetailsForCoidBindingSource.DataMember = "GetCompanyDetailsForCoid";
			this.GetCompanyDetailsForCoidBindingSource.DataSource = this.POSDataSet;
			this.GetCompanyDetailsForCoidTableAdapter.ClearBeforeFill = true;
			this.RepairsViewBindingSource.DataMember = "RepairsView";
			this.RepairsViewBindingSource.DataSource = this.POSDataSet;
			this.RepairsViewTableAdapter.ClearBeforeFill = true;
			this.GetBranchDetails1BindingSource.DataMember = "GetBranchDetails1";
			this.GetBranchDetails1BindingSource.DataSource = this.POSDataSet;
			this.GetBranchDetails1TableAdapter.ClearBeforeFill = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1251, 599);
			base.Controls.Add(this.ReportViewer1);
			base.Name = "RepairsCheckIn";
			this.Text = "Repairs Check In";
			((global::System.ComponentModel.ISupportInitialize)this.POSDataSet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetCompanyDetailsForCoidBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.RepairsViewBindingSource).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.GetBranchDetails1BindingSource).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400185C RID: 6236
		private global::System.ComponentModel.IContainer components;
	}
}
