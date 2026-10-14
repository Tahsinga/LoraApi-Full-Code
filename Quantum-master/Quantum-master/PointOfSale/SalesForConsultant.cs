using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using PointOfSale.POSDataSetTableAdapters;

namespace PointOfSale
{
	// Token: 0x02000199 RID: 409
	[DesignerGenerated]
	public partial class SalesForConsultant : UserControl
	{
		// Token: 0x060048B5 RID: 18613 RVA: 0x002C29A4 File Offset: 0x002C0BA4
		public SalesForConsultant()
		{
			base.Load += this.SalesForConsultant_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17001A73 RID: 6771
		// (get) Token: 0x060048B8 RID: 18616 RVA: 0x002C35AA File Offset: 0x002C17AA
		// (set) Token: 0x060048B9 RID: 18617 RVA: 0x002C35B4 File Offset: 0x002C17B4
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A74 RID: 6772
		// (get) Token: 0x060048BA RID: 18618 RVA: 0x002C35BD File Offset: 0x002C17BD
		// (set) Token: 0x060048BB RID: 18619 RVA: 0x002C35C7 File Offset: 0x002C17C7
		internal virtual ReportViewer ReportViewer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A75 RID: 6773
		// (get) Token: 0x060048BC RID: 18620 RVA: 0x002C35D0 File Offset: 0x002C17D0
		// (set) Token: 0x060048BD RID: 18621 RVA: 0x002C35DA File Offset: 0x002C17DA
		internal virtual BindingSource GetCompanyDetailsBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A76 RID: 6774
		// (get) Token: 0x060048BE RID: 18622 RVA: 0x002C35E3 File Offset: 0x002C17E3
		// (set) Token: 0x060048BF RID: 18623 RVA: 0x002C35ED File Offset: 0x002C17ED
		internal virtual POSDataSet POSDataSet
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A77 RID: 6775
		// (get) Token: 0x060048C0 RID: 18624 RVA: 0x002C35F6 File Offset: 0x002C17F6
		// (set) Token: 0x060048C1 RID: 18625 RVA: 0x002C3600 File Offset: 0x002C1800
		internal virtual BindingSource GetSalesForConsultantBindingSource
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A78 RID: 6776
		// (get) Token: 0x060048C2 RID: 18626 RVA: 0x002C3609 File Offset: 0x002C1809
		// (set) Token: 0x060048C3 RID: 18627 RVA: 0x002C3613 File Offset: 0x002C1813
		internal virtual GetCompanyDetailsTableAdapter GetCompanyDetailsTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A79 RID: 6777
		// (get) Token: 0x060048C4 RID: 18628 RVA: 0x002C361C File Offset: 0x002C181C
		// (set) Token: 0x060048C5 RID: 18629 RVA: 0x002C3626 File Offset: 0x002C1826
		internal virtual GetSalesForConsultantTableAdapter GetSalesForConsultantTableAdapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A7A RID: 6778
		// (get) Token: 0x060048C6 RID: 18630 RVA: 0x002C362F File Offset: 0x002C182F
		// (set) Token: 0x060048C7 RID: 18631 RVA: 0x002C3639 File Offset: 0x002C1839
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A7B RID: 6779
		// (get) Token: 0x060048C8 RID: 18632 RVA: 0x002C3642 File Offset: 0x002C1842
		// (set) Token: 0x060048C9 RID: 18633 RVA: 0x002C364C File Offset: 0x002C184C
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A7C RID: 6780
		// (get) Token: 0x060048CA RID: 18634 RVA: 0x002C3655 File Offset: 0x002C1855
		// (set) Token: 0x060048CB RID: 18635 RVA: 0x002C365F File Offset: 0x002C185F
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A7D RID: 6781
		// (get) Token: 0x060048CC RID: 18636 RVA: 0x002C3668 File Offset: 0x002C1868
		// (set) Token: 0x060048CD RID: 18637 RVA: 0x002C3672 File Offset: 0x002C1872
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A7E RID: 6782
		// (get) Token: 0x060048CE RID: 18638 RVA: 0x002C367B File Offset: 0x002C187B
		// (set) Token: 0x060048CF RID: 18639 RVA: 0x002C3688 File Offset: 0x002C1888
		internal virtual Button Button1
		{
			[CompilerGenerated]
			get
			{
				return this._Button1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button1_Click);
				Button button = this._Button1;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button1 = value;
				button = this._Button1;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001A7F RID: 6783
		// (get) Token: 0x060048D0 RID: 18640 RVA: 0x002C36CB File Offset: 0x002C18CB
		// (set) Token: 0x060048D1 RID: 18641 RVA: 0x002C36D5 File Offset: 0x002C18D5
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A80 RID: 6784
		// (get) Token: 0x060048D2 RID: 18642 RVA: 0x002C36DE File Offset: 0x002C18DE
		// (set) Token: 0x060048D3 RID: 18643 RVA: 0x002C36E8 File Offset: 0x002C18E8
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A81 RID: 6785
		// (get) Token: 0x060048D4 RID: 18644 RVA: 0x002C36F1 File Offset: 0x002C18F1
		// (set) Token: 0x060048D5 RID: 18645 RVA: 0x002C36FB File Offset: 0x002C18FB
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A82 RID: 6786
		// (get) Token: 0x060048D6 RID: 18646 RVA: 0x002C3704 File Offset: 0x002C1904
		// (set) Token: 0x060048D7 RID: 18647 RVA: 0x002C370E File Offset: 0x002C190E
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A83 RID: 6787
		// (get) Token: 0x060048D8 RID: 18648 RVA: 0x002C3717 File Offset: 0x002C1917
		// (set) Token: 0x060048D9 RID: 18649 RVA: 0x002C3721 File Offset: 0x002C1921
		internal virtual ComboBox cboConsultants
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A84 RID: 6788
		// (get) Token: 0x060048DA RID: 18650 RVA: 0x002C372A File Offset: 0x002C192A
		// (set) Token: 0x060048DB RID: 18651 RVA: 0x002C3734 File Offset: 0x002C1934
		internal virtual Label Label6
		{
			[CompilerGenerated]
			get
			{
				return this._Label6;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label6_Click);
				Label label = this._Label6;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label6 = value;
				label = this._Label6;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001A85 RID: 6789
		// (get) Token: 0x060048DC RID: 18652 RVA: 0x002C3777 File Offset: 0x002C1977
		// (set) Token: 0x060048DD RID: 18653 RVA: 0x002C3784 File Offset: 0x002C1984
		internal virtual CheckBox chkAllConsultants
		{
			[CompilerGenerated]
			get
			{
				return this._chkAllConsultants;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkAllConsultants_CheckedChanged);
				CheckBox checkBox = this._chkAllConsultants;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkAllConsultants = value;
				checkBox = this._chkAllConsultants;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17001A86 RID: 6790
		// (get) Token: 0x060048DE RID: 18654 RVA: 0x002C37C7 File Offset: 0x002C19C7
		// (set) Token: 0x060048DF RID: 18655 RVA: 0x002C37D4 File Offset: 0x002C19D4
		internal virtual CheckBox chkAllCategories
		{
			[CompilerGenerated]
			get
			{
				return this._chkAllCategories;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.CheckBox1_CheckedChanged);
				CheckBox checkBox = this._chkAllCategories;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkAllCategories = value;
				checkBox = this._chkAllCategories;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x17001A87 RID: 6791
		// (get) Token: 0x060048E0 RID: 18656 RVA: 0x002C3817 File Offset: 0x002C1A17
		// (set) Token: 0x060048E1 RID: 18657 RVA: 0x002C3821 File Offset: 0x002C1A21
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001A88 RID: 6792
		// (get) Token: 0x060048E2 RID: 18658 RVA: 0x002C382A File Offset: 0x002C1A2A
		// (set) Token: 0x060048E3 RID: 18659 RVA: 0x002C3834 File Offset: 0x002C1A34
		internal virtual ComboBox cboCategory
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060048E4 RID: 18660 RVA: 0x002C3840 File Offset: 0x002C1A40
		private void LoadBranches()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchBranches";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.cboBranch.DataSource = dataTable;
			this.cboBranch.ValueMember = "branch";
			this.cboBranch.DisplayMember = "branch";
			bool flag = MyProject.Forms.Form1.OpenImpReports == 0;
			if (flag)
			{
				int num = this.cboBranch.FindString(MyProject.Forms.Form1.branch);
				this.cboBranch.SelectedIndex = num;
				this.cboBranch.Enabled = false;
			}
		}

		// Token: 0x060048E5 RID: 18661 RVA: 0x002C3930 File Offset: 0x002C1B30
		private void LoadUsers(int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchUsers";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.cboConsultants.DataSource = dataTable;
				this.cboConsultants.DisplayMember = "Username";
				this.cboConsultants.ValueMember = "Username";
			}
		}

		// Token: 0x060048E6 RID: 18662 RVA: 0x002C39D0 File Offset: 0x002C1BD0
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
				this.GetCompanyDetailsTableAdapter.Connection = sqlConnection;
				this.GetSalesForConsultantTableAdapter.Connection = sqlConnection;
				ReportParameter reportParameter = new ReportParameter("startdatedesc", this.DTStartdate.Value.ToShortDateString());
				ReportParameter reportParameter2 = new ReportParameter("enddatedesc", this.DTEnddate.Value.ToShortDateString());
				ReportParameter reportParameter3 = new ReportParameter("Consultant", Conversions.ToString(Interaction.IIf(this.chkAllConsultants.Checked, "All", this.cboConsultants.Text)));
				ReportParameter reportParameter4 = new ReportParameter("Category", Conversions.ToString(Interaction.IIf(this.chkAllCategories.Checked, "All", this.cboCategory.Text)));
				ReportParameter[] array = new ReportParameter[] { reportParameter, reportParameter2, reportParameter3, reportParameter4 };
				this.ReportViewer1.LocalReport.SetParameters(array);
				this.GetCompanyDetailsTableAdapter.Fill(this.POSDataSet.GetCompanyDetails);
				this.GetSalesForConsultantTableAdapter.Fill(this.POSDataSet.GetSalesForConsultant, new int?(Conversions.ToInteger(this.DTStartdate.Value.ToString("yyyyMMdd"))), new int?(Conversions.ToInteger(this.DTEnddate.Value.ToString("yyyyMMdd"))), new int?(MyProject.Forms.Form1.coid), this.cboBranch.Text, Conversions.ToString(Interaction.IIf(this.chkAllConsultants.Checked, null, this.cboConsultants.Text)), (int?)Interaction.IIf(this.chkAllCategories.Checked, null, RuntimeHelpers.GetObjectValue(this.cboCategory.SelectedValue)));
				this.ReportViewer1.RefreshReport();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying report. Detail: " + ex.Message);
			}
		}

		// Token: 0x060048E7 RID: 18663 RVA: 0x002C3C08 File Offset: 0x002C1E08
		private void SalesForConsultant_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
				this.LoadUsers(MyProject.Forms.Form1.coid);
				this.cboCategory.DataSource = this.pf.LoadCategories(this._cnn);
				this.cboCategory.DisplayMember = "CatDesc";
				this.cboCategory.ValueMember = "CatID";
				this.chkAllCategories.Checked = true;
				this.chkAllConsultants.Checked = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060048E8 RID: 18664 RVA: 0x002C3CC8 File Offset: 0x002C1EC8
		private void Label6_Click(object sender, EventArgs e)
		{
			try
			{
				base.Dispose();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x060048E9 RID: 18665 RVA: 0x002C3D00 File Offset: 0x002C1F00
		private void CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.chkAllCategories.Checked;
			if (@checked)
			{
				this.cboCategory.Enabled = false;
			}
			else
			{
				this.cboCategory.Enabled = true;
			}
		}

		// Token: 0x060048EA RID: 18666 RVA: 0x002C3D3C File Offset: 0x002C1F3C
		private void chkAllConsultants_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.chkAllConsultants.Checked;
			if (@checked)
			{
				this.cboConsultants.Enabled = false;
			}
			else
			{
				this.cboConsultants.Enabled = true;
			}
		}

		// Token: 0x04001FEC RID: 8172
		private string _cnn;

		// Token: 0x04001FED RID: 8173
		private PublicFunctions pf;
	}
}
