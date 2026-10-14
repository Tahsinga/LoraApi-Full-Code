using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x02000174 RID: 372
	[DesignerGenerated]
	public partial class ProductsConverted : UserControl
	{
		// Token: 0x0600359C RID: 13724 RVA: 0x001CFF4C File Offset: 0x001CE14C
		public ProductsConverted()
		{
			base.Load += this.ProductsConverted_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x170013EC RID: 5100
		// (get) Token: 0x0600359F RID: 13727 RVA: 0x001D0915 File Offset: 0x001CEB15
		// (set) Token: 0x060035A0 RID: 13728 RVA: 0x001D091F File Offset: 0x001CEB1F
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013ED RID: 5101
		// (get) Token: 0x060035A1 RID: 13729 RVA: 0x001D0928 File Offset: 0x001CEB28
		// (set) Token: 0x060035A2 RID: 13730 RVA: 0x001D0932 File Offset: 0x001CEB32
		internal virtual DataGridView dgvProducts
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013EE RID: 5102
		// (get) Token: 0x060035A3 RID: 13731 RVA: 0x001D093B File Offset: 0x001CEB3B
		// (set) Token: 0x060035A4 RID: 13732 RVA: 0x001D0945 File Offset: 0x001CEB45
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013EF RID: 5103
		// (get) Token: 0x060035A5 RID: 13733 RVA: 0x001D094E File Offset: 0x001CEB4E
		// (set) Token: 0x060035A6 RID: 13734 RVA: 0x001D0958 File Offset: 0x001CEB58
		internal virtual DateTimePicker DTEnddate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013F0 RID: 5104
		// (get) Token: 0x060035A7 RID: 13735 RVA: 0x001D0961 File Offset: 0x001CEB61
		// (set) Token: 0x060035A8 RID: 13736 RVA: 0x001D096B File Offset: 0x001CEB6B
		internal virtual DateTimePicker DTStartdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013F1 RID: 5105
		// (get) Token: 0x060035A9 RID: 13737 RVA: 0x001D0974 File Offset: 0x001CEB74
		// (set) Token: 0x060035AA RID: 13738 RVA: 0x001D097E File Offset: 0x001CEB7E
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013F2 RID: 5106
		// (get) Token: 0x060035AB RID: 13739 RVA: 0x001D0987 File Offset: 0x001CEB87
		// (set) Token: 0x060035AC RID: 13740 RVA: 0x001D0991 File Offset: 0x001CEB91
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013F3 RID: 5107
		// (get) Token: 0x060035AD RID: 13741 RVA: 0x001D099A File Offset: 0x001CEB9A
		// (set) Token: 0x060035AE RID: 13742 RVA: 0x001D09A4 File Offset: 0x001CEBA4
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013F4 RID: 5108
		// (get) Token: 0x060035AF RID: 13743 RVA: 0x001D09AD File Offset: 0x001CEBAD
		// (set) Token: 0x060035B0 RID: 13744 RVA: 0x001D09B8 File Offset: 0x001CEBB8
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

		// Token: 0x170013F5 RID: 5109
		// (get) Token: 0x060035B1 RID: 13745 RVA: 0x001D09FB File Offset: 0x001CEBFB
		// (set) Token: 0x060035B2 RID: 13746 RVA: 0x001D0A08 File Offset: 0x001CEC08
		internal virtual Button Button2
		{
			[CompilerGenerated]
			get
			{
				return this._Button2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button2_Click);
				Button button = this._Button2;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button2 = value;
				button = this._Button2;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x170013F6 RID: 5110
		// (get) Token: 0x060035B3 RID: 13747 RVA: 0x001D0A4B File Offset: 0x001CEC4B
		// (set) Token: 0x060035B4 RID: 13748 RVA: 0x001D0A55 File Offset: 0x001CEC55
		internal virtual SaveFileDialog SaveFileDialog1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013F7 RID: 5111
		// (get) Token: 0x060035B5 RID: 13749 RVA: 0x001D0A5E File Offset: 0x001CEC5E
		// (set) Token: 0x060035B6 RID: 13750 RVA: 0x001D0A68 File Offset: 0x001CEC68
		internal virtual CheckBox chkAll
		{
			[CompilerGenerated]
			get
			{
				return this._chkAll;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkAll_CheckedChanged);
				CheckBox checkBox = this._chkAll;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkAll = value;
				checkBox = this._chkAll;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170013F8 RID: 5112
		// (get) Token: 0x060035B7 RID: 13751 RVA: 0x001D0AAB File Offset: 0x001CECAB
		// (set) Token: 0x060035B8 RID: 13752 RVA: 0x001D0AB5 File Offset: 0x001CECB5
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013F9 RID: 5113
		// (get) Token: 0x060035B9 RID: 13753 RVA: 0x001D0ABE File Offset: 0x001CECBE
		// (set) Token: 0x060035BA RID: 13754 RVA: 0x001D0AC8 File Offset: 0x001CECC8
		internal virtual ComboBox cboType
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013FA RID: 5114
		// (get) Token: 0x060035BB RID: 13755 RVA: 0x001D0AD1 File Offset: 0x001CECD1
		// (set) Token: 0x060035BC RID: 13756 RVA: 0x001D0ADB File Offset: 0x001CECDB
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170013FB RID: 5115
		// (get) Token: 0x060035BD RID: 13757 RVA: 0x001D0AE4 File Offset: 0x001CECE4
		// (set) Token: 0x060035BE RID: 13758 RVA: 0x001D0AF0 File Offset: 0x001CECF0
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

		// Token: 0x060035BF RID: 13759 RVA: 0x001D0B34 File Offset: 0x001CED34
		private void ProductsConverted_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadBranches();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060035C0 RID: 13760 RVA: 0x001D0B84 File Offset: 0x001CED84
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
		}

		// Token: 0x060035C1 RID: 13761 RVA: 0x001D0C24 File Offset: 0x001CEE24
		private void GetConvertedProducts()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "ViewProductsConverted ";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
			sqlCommand.Parameters.AddWithValue("startdate", Convert.ToInt32(this.DTStartdate.Value.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("enddate", Convert.ToInt32(this.DTEnddate.Value.ToString("yyyyMMdd")));
			bool @checked = this.chkAll.Checked;
			if (@checked)
			{
				sqlCommand.Parameters.AddWithValue("isstockin", DBNull.Value);
			}
			else
			{
				sqlCommand.Parameters.AddWithValue("isstockin", RuntimeHelpers.GetObjectValue(Interaction.IIf(Operators.CompareString(this.cboType.Text, "PRODUCTS MADE", false) == 0, 1, 0)));
			}
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.dgvProducts.DataSource = dataTable;
			this.dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		// Token: 0x060035C2 RID: 13762 RVA: 0x001D0DA0 File Offset: 0x001CEFA0
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.GetConvertedProducts();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying data. Detail: " + ex.Message);
			}
		}

		// Token: 0x060035C3 RID: 13763 RVA: 0x001D0DF0 File Offset: 0x001CEFF0
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.dgvProducts.RowCount > 0;
				if (flag)
				{
					this.SaveFileDialog1.Filter = "Excel File|*.xlsx";
					this.SaveFileDialog1.Title = "Save excel file";
					this.SaveFileDialog1.DefaultExt = ".xlsx";
					bool flag2 = this.SaveFileDialog1.ShowDialog() == DialogResult.OK;
					if (flag2)
					{
						this.pf.DATAGRIDVIEW_TO_EXCEL2(this.dgvProducts, this.SaveFileDialog1.FileName, "Sheet1");
						MessageBox.Show("Data Export Done.");
					}
				}
				else
				{
					MessageBox.Show("There are no rows to export.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error exporting to excel. Detail " + ex.Message);
			}
		}

		// Token: 0x060035C4 RID: 13764 RVA: 0x001D0ED0 File Offset: 0x001CF0D0
		private void chkAll_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.chkAll.Checked;
			if (@checked)
			{
				this.cboType.Enabled = false;
			}
			else
			{
				this.cboType.Enabled = true;
			}
		}

		// Token: 0x060035C5 RID: 13765 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label6_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x04001701 RID: 5889
		private string _cnn;

		// Token: 0x04001702 RID: 5890
		private PublicFunctions pf;
	}
}
