using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x02000084 RID: 132
	[DesignerGenerated]
	public partial class PacketSizesLinkToProduct : UserControl
	{
		// Token: 0x06001E63 RID: 7779 RVA: 0x0010EF94 File Offset: 0x0010D194
		public PacketSizesLinkToProduct()
		{
			base.Load += this.PacketSizesLinkToProduct_Load;
			this.pf = new PublicFunctions();
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x06001E66 RID: 7782 RVA: 0x00110462 File Offset: 0x0010E662
		// (set) Token: 0x06001E67 RID: 7783 RVA: 0x0011046C File Offset: 0x0010E66C
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x06001E68 RID: 7784 RVA: 0x00110475 File Offset: 0x0010E675
		// (set) Token: 0x06001E69 RID: 7785 RVA: 0x0011047F File Offset: 0x0010E67F
		internal virtual Panel Panel2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x06001E6A RID: 7786 RVA: 0x00110488 File Offset: 0x0010E688
		// (set) Token: 0x06001E6B RID: 7787 RVA: 0x00110494 File Offset: 0x0010E694
		internal virtual DataGridView DGVSearch
		{
			[CompilerGenerated]
			get
			{
				return this._DGVSearch;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DGVSearch_CellEnter);
				DataGridView dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.CellEnter -= dataGridViewCellEventHandler;
				}
				this._DGVSearch = value;
				dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.CellEnter += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x06001E6C RID: 7788 RVA: 0x001104D7 File Offset: 0x0010E6D7
		// (set) Token: 0x06001E6D RID: 7789 RVA: 0x001104E1 File Offset: 0x0010E6E1
		internal virtual GroupBox GroupBox6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06001E6E RID: 7790 RVA: 0x001104EA File Offset: 0x0010E6EA
		// (set) Token: 0x06001E6F RID: 7791 RVA: 0x001104F4 File Offset: 0x0010E6F4
		internal virtual Panel Panel7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06001E70 RID: 7792 RVA: 0x001104FD File Offset: 0x0010E6FD
		// (set) Token: 0x06001E71 RID: 7793 RVA: 0x00110507 File Offset: 0x0010E707
		internal virtual Label Label20
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06001E72 RID: 7794 RVA: 0x00110510 File Offset: 0x0010E710
		// (set) Token: 0x06001E73 RID: 7795 RVA: 0x0011051A File Offset: 0x0010E71A
		internal virtual TextBox txtBarCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06001E74 RID: 7796 RVA: 0x00110523 File Offset: 0x0010E723
		// (set) Token: 0x06001E75 RID: 7797 RVA: 0x0011052D File Offset: 0x0010E72D
		internal virtual Label Label24
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06001E76 RID: 7798 RVA: 0x00110536 File Offset: 0x0010E736
		// (set) Token: 0x06001E77 RID: 7799 RVA: 0x00110540 File Offset: 0x0010E740
		internal virtual Label Label34
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06001E78 RID: 7800 RVA: 0x00110549 File Offset: 0x0010E749
		// (set) Token: 0x06001E79 RID: 7801 RVA: 0x00110554 File Offset: 0x0010E754
		internal virtual Button Button3
		{
			[CompilerGenerated]
			get
			{
				return this._Button3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button3_Click);
				Button button = this._Button3;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button3 = value;
				button = this._Button3;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06001E7A RID: 7802 RVA: 0x00110597 File Offset: 0x0010E797
		// (set) Token: 0x06001E7B RID: 7803 RVA: 0x001105A1 File Offset: 0x0010E7A1
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x06001E7C RID: 7804 RVA: 0x001105AA File Offset: 0x0010E7AA
		// (set) Token: 0x06001E7D RID: 7805 RVA: 0x001105B4 File Offset: 0x0010E7B4
		internal virtual TextBox txtsearch
		{
			[CompilerGenerated]
			get
			{
				return this._txtsearch;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtsearch_TextChanged);
				TextBox textBox = this._txtsearch;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtsearch = value;
				textBox = this._txtsearch;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06001E7E RID: 7806 RVA: 0x001105F7 File Offset: 0x0010E7F7
		// (set) Token: 0x06001E7F RID: 7807 RVA: 0x00110601 File Offset: 0x0010E801
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06001E80 RID: 7808 RVA: 0x0011060A File Offset: 0x0010E80A
		// (set) Token: 0x06001E81 RID: 7809 RVA: 0x00110614 File Offset: 0x0010E814
		internal virtual TextBox txtSearchProductCode
		{
			[CompilerGenerated]
			get
			{
				return this._txtSearchProductCode;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtSearchProductCode_TextChanged);
				TextBox textBox = this._txtSearchProductCode;
				if (textBox != null)
				{
					textBox.TextChanged -= eventHandler;
				}
				this._txtSearchProductCode = value;
				textBox = this._txtSearchProductCode;
				if (textBox != null)
				{
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06001E82 RID: 7810 RVA: 0x00110657 File Offset: 0x0010E857
		// (set) Token: 0x06001E83 RID: 7811 RVA: 0x00110664 File Offset: 0x0010E864
		internal virtual Label Label9
		{
			[CompilerGenerated]
			get
			{
				return this._Label9;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label9_Click);
				Label label = this._Label9;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label9 = value;
				label = this._Label9;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06001E84 RID: 7812 RVA: 0x001106A7 File Offset: 0x0010E8A7
		// (set) Token: 0x06001E85 RID: 7813 RVA: 0x001106B4 File Offset: 0x0010E8B4
		internal virtual Button Button4
		{
			[CompilerGenerated]
			get
			{
				return this._Button4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button4_Click);
				Button button = this._Button4;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button4 = value;
				button = this._Button4;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x06001E86 RID: 7814 RVA: 0x001106F7 File Offset: 0x0010E8F7
		// (set) Token: 0x06001E87 RID: 7815 RVA: 0x00110704 File Offset: 0x0010E904
		internal virtual ComboBox cboPSGroups
		{
			[CompilerGenerated]
			get
			{
				return this._cboPSGroups;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboPSGroups_SelectedIndexChanged);
				ComboBox comboBox = this._cboPSGroups;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboPSGroups = value;
				comboBox = this._cboPSGroups;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x06001E88 RID: 7816 RVA: 0x00110747 File Offset: 0x0010E947
		// (set) Token: 0x06001E89 RID: 7817 RVA: 0x00110751 File Offset: 0x0010E951
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x06001E8A RID: 7818 RVA: 0x0011075A File Offset: 0x0010E95A
		// (set) Token: 0x06001E8B RID: 7819 RVA: 0x00110764 File Offset: 0x0010E964
		internal virtual Button Button2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x06001E8C RID: 7820 RVA: 0x0011076D File Offset: 0x0010E96D
		// (set) Token: 0x06001E8D RID: 7821 RVA: 0x00110778 File Offset: 0x0010E978
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

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x06001E8E RID: 7822 RVA: 0x001107BB File Offset: 0x0010E9BB
		// (set) Token: 0x06001E8F RID: 7823 RVA: 0x001107C5 File Offset: 0x0010E9C5
		internal virtual TextBox txtDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x06001E90 RID: 7824 RVA: 0x001107CE File Offset: 0x0010E9CE
		// (set) Token: 0x06001E91 RID: 7825 RVA: 0x001107D8 File Offset: 0x0010E9D8
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06001E92 RID: 7826 RVA: 0x001107E1 File Offset: 0x0010E9E1
		// (set) Token: 0x06001E93 RID: 7827 RVA: 0x001107EC File Offset: 0x0010E9EC
		internal virtual DataGridView dgvPSPrices
		{
			[CompilerGenerated]
			get
			{
				return this._dgvPSPrices;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvPSPrices_CellEndEdit);
				DataGridView dataGridView = this._dgvPSPrices;
				if (dataGridView != null)
				{
					dataGridView.CellEndEdit -= dataGridViewCellEventHandler;
				}
				this._dgvPSPrices = value;
				dataGridView = this._dgvPSPrices;
				if (dataGridView != null)
				{
					dataGridView.CellEndEdit += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x06001E94 RID: 7828 RVA: 0x0011082F File Offset: 0x0010EA2F
		// (set) Token: 0x06001E95 RID: 7829 RVA: 0x00110839 File Offset: 0x0010EA39
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x06001E96 RID: 7830 RVA: 0x00110842 File Offset: 0x0010EA42
		// (set) Token: 0x06001E97 RID: 7831 RVA: 0x0011084C File Offset: 0x0010EA4C
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x06001E98 RID: 7832 RVA: 0x00110855 File Offset: 0x0010EA55
		// (set) Token: 0x06001E99 RID: 7833 RVA: 0x0011085F File Offset: 0x0010EA5F
		internal virtual ComboBox cboBranches
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06001E9A RID: 7834 RVA: 0x00110868 File Offset: 0x0010EA68
		// (set) Token: 0x06001E9B RID: 7835 RVA: 0x00110872 File Offset: 0x0010EA72
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06001E9C RID: 7836 RVA: 0x0011087B File Offset: 0x0010EA7B
		// (set) Token: 0x06001E9D RID: 7837 RVA: 0x00110888 File Offset: 0x0010EA88
		internal virtual Button Button5
		{
			[CompilerGenerated]
			get
			{
				return this._Button5;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button5_Click);
				Button button = this._Button5;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button5 = value;
				button = this._Button5;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x000140EE File Offset: 0x000122EE
		private void Label9_Click(object sender, EventArgs e)
		{
			base.Dispose();
		}

		// Token: 0x06001E9F RID: 7839 RVA: 0x001108CC File Offset: 0x0010EACC
		private void LoadPSGroups()
		{
			DataTable packetSizeGroups = this.pf.getPacketSizeGroups(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.Constring);
			this.cboPSGroups.DataSource = packetSizeGroups;
			this.cboPSGroups.DisplayMember = "PSGroupName";
			this.cboPSGroups.ValueMember = "GroupID";
			this.cboPSGroups.SelectedIndex = -1;
		}

		// Token: 0x06001EA0 RID: 7840 RVA: 0x00110940 File Offset: 0x0010EB40
		private void PacketSizesLinkToProduct_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadPSGroups();
				this.LoadBranches();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001EA1 RID: 7841 RVA: 0x00110998 File Offset: 0x0010EB98
		private void LoadBranches()
		{
			DataTable branches = this.pf.GetBranches(MyProject.Forms.Form1.Constring);
			this.cboBranches.DataSource = branches;
			this.cboBranches.DisplayMember = "Branch";
			this.cboBranches.ValueMember = "Branch";
			this.cboBranches.SelectedIndex = -1;
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x00110A00 File Offset: 0x0010EC00
		private void txtsearch_TextChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = MyProject.Forms.Form1.OnlineSearchOptimised == 0;
				if (flag)
				{
					this.lblerror.Text = "...";
					this.SearchByDescAdvanced(this.txtsearch.Text);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x00110A88 File Offset: 0x0010EC88
		private void SearchByDesc(string searchtext)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SearchProduct2";
			sqlCommand.Parameters.AddWithValue("search", searchtext);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.DGVSearch.DataSource = dataTable;
				this.DGVSearch.Columns["ProductCode"].Visible = false;
				this.DGVSearch.Columns["ProductID"].Visible = false;
				this.DGVSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			}
			else
			{
				this.lblerror.Text = "No products match your search.";
			}
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x00110B80 File Offset: 0x0010ED80
		private void SearchByDescAdvanced(string searchtext)
		{
			bool flag = Operators.CompareString(searchtext, "", false) == 0;
			checked
			{
				if (!flag)
				{
					Cursor.Current = Cursors.WaitCursor;
					string[] array = searchtext.Split(new char[] { ' ' });
					int num = 1;
					DataTable dataTable = new DataTable();
					foreach (string text in array)
					{
						bool flag2 = num == 1;
						if (flag2)
						{
							dataTable = this.searchDB(text);
						}
						else
						{
							DataTable dataTable2 = new DataTable();
							dataTable2 = (DataTable)this.searchDat(dataTable, "ProductDesc", text);
							dataTable = dataTable2;
						}
						num++;
					}
					bool flag3 = dataTable.Rows.Count > 0;
					if (flag3)
					{
						this.DGVSearch.DataSource = dataTable;
						this.DGVSearch.Columns["ProductCode"].Visible = false;
						this.DGVSearch.Columns["ProductID"].Visible = false;
						this.DGVSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
					}
					else
					{
						this.lblerror.Text = "No products match your search.";
					}
					Cursor.Current = Cursors.Default;
				}
			}
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x00110CBC File Offset: 0x0010EEBC
		private object searchDat(DataTable dt, string column, string value)
		{
			PacketSizesLinkToProduct._Closure$__127-0 CS$<>8__locals1 = new PacketSizesLinkToProduct._Closure$__127-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_column = column;
			CS$<>8__locals1.$VB$Local_value = value;
			DataTable dataTable = dt.Clone();
			dt.CaseSensitive = false;
			try
			{
				foreach (DataRow dataRow in dt.Rows.Cast<object>().Select<object, DataRow>((PacketSizesLinkToProduct._Closure$__.$I127-0 == null) ? (PacketSizesLinkToProduct._Closure$__.$I127-0 = (object row1) => (DataRow)row1) : PacketSizesLinkToProduct._Closure$__.$I127-0).Where<DataRow>((CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = (DataRow row1) => Conversions.ToBoolean(NewLateBinding.LateGet(row1[CS$<>8__locals1.$VB$Local_column], null, "Contains", new object[] { CS$<>8__locals1.$VB$Local_value.ToUpper() }, null, null, null))) : CS$<>8__locals1.$I1))
				{
					dataTable.ImportRow(dataRow);
				}
			}
			finally
			{
				IEnumerator<DataRow> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			return dataTable;
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x00110D98 File Offset: 0x0010EF98
		private DataTable searchDB(string searchtext)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SearchProduct2";
			sqlCommand.Parameters.AddWithValue("search", searchtext);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("isingridient", 0);
			sqlCommand.Parameters.AddWithValue("username", MyProject.Forms.Form1.username);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x00110E58 File Offset: 0x0010F058
		private void FetchAllProducts()
		{
			this.lblerror.Text = "...";
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectAllProducts2";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("isingridient", 0);
			sqlCommand.Parameters.AddWithValue("username", MyProject.Forms.Form1.username);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				this.DGVSearch.DataSource = dataTable;
				this.DGVSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.DGVSearch.Columns["CatDesc"].Visible = false;
				this.DGVSearch.Columns["Reorder_Level"].Visible = false;
				this.DGVSearch.Columns["Unit_Selling_Price"].Visible = false;
				this.DGVSearch.Columns["Unit_Cost"].Visible = false;
				this.DGVSearch.Columns["ProductID"].Visible = false;
				this.DGVSearch.Columns["ProductCode"].Visible = false;
				this.DGVSearch.Columns["Tax_Percentage"].Visible = false;
				this.DGVSearch.Columns["Bin_Location"].Visible = false;
				this.DGVSearch.Columns["Unit_of_Measure"].Visible = false;
				this.DGVSearch.Columns["SpecialPrice"].Visible = false;
			}
			else
			{
				this.lblerror.Text = "No products match your search.";
			}
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x00111068 File Offset: 0x0010F268
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				this.lblerror.Text = "...";
				this.FetchAllProducts();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x001110C8 File Offset: 0x0010F2C8
		private void DGVSearch_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					int num = Conversions.ToInteger(this.DGVSearch.Rows[e.RowIndex].Cells["ProductID"].Value);
					this.txtSearchProductCode.Text = Conversions.ToString(num);
				}
			}
			catch (Exception ex)
			{
				this.lblerror.Text = "Error: " + ex.Message;
			}
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x0011118C File Offset: 0x0010F38C
		private void SearchBarCode(int prodtID)
		{
			bool flag = prodtID == 0;
			if (flag)
			{
				this.txtSearchProductCode.Text = "";
			}
			else
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "FetchProductByID2";
				sqlCommand.Parameters.AddWithValue("prodtID", prodtID);
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				sqlCommand.Parameters.AddWithValue("isingridient", 0);
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				int num = sqlDataAdapter.Fill(dataTable);
				bool flag2 = num > 0;
				if (flag2)
				{
					DataRow dataRow = dataTable.Rows[0];
					this.txtDesc.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow["ProductDesc"], "("), Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ProductDesc2"])), "", RuntimeHelpers.GetObjectValue(dataRow["ProductDesc2"]))), ")"));
					this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
					this.CurrentCode = Conversions.ToString(dataRow["ProductCode"]);
				}
				else
				{
					this.txtSearchProductCode.Text = "";
				}
			}
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x00111314 File Offset: 0x0010F514
		private void SearchProductCode(string prodtcode, int use_price_from_scale = 0, decimal price_from_scale = 0m, decimal qty_from_scale = 0m)
		{
			bool flag = (Operators.CompareString(prodtcode, "0", false) == 0) | (Operators.CompareString(prodtcode, "", false) == 0);
			if (flag)
			{
				this.txtSearchProductCode.Text = "";
			}
			else
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "FetchProductByCode2";
				sqlCommand.Parameters.AddWithValue("productcode", prodtcode);
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				sqlCommand.Parameters.AddWithValue("isingridient", 0);
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				int num = sqlDataAdapter.Fill(dataTable);
				bool flag2 = num > 0;
				if (flag2)
				{
					DataRow dataRow = dataTable.Rows[0];
					int num2 = Conversions.ToInteger(dataRow["catid"]);
					bool flag3 = !this.pf.IsCATIDForUser(MyProject.Forms.Form1.username, MyProject.Forms.Form1.coid, num2, this._cnn);
					if (flag3)
					{
						MessageBox.Show("Product is restricted for this user.");
					}
					else
					{
						this.txtDesc.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(dataRow["ProductDesc"], "("), Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ProductDesc2"])), "", RuntimeHelpers.GetObjectValue(dataRow["ProductDesc2"]))), ")"));
						this.CurrentID = Conversions.ToInteger(dataRow["ProductID"]);
						this.CurrentCode = Conversions.ToString(dataRow["ProductCode"]);
					}
				}
				else
				{
					this.txtSearchProductCode.Text = "";
					bool flag4 = MyProject.Forms.Form1.DefaultSearchDesc == 1;
					if (flag4)
					{
						this.txtsearch.Focus();
					}
					else
					{
						this.txtBarCode.Text = "";
						this.txtBarCode.Select(0, this.txtBarCode.Text.Length);
						this.txtBarCode.Focus();
					}
				}
			}
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x00111574 File Offset: 0x0010F774
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			bool flag3;
			try
			{
				bool flag = msg.WParam.ToInt32() == 33;
				if (flag)
				{
					this.txtsearch.Focus();
				}
				else
				{
					bool flag2 = msg.WParam.ToInt32() == 112;
					if (flag2)
					{
						this.txtBarCode.Text = "";
						this.txtBarCode.Focus();
					}
				}
				flag3 = base.ProcessCmdKey(ref msg, keyData);
			}
			catch (Exception ex)
			{
			}
			return flag3;
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x0011160C File Offset: 0x0010F80C
		private void txtSearchProductCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.txtDesc.Text = "No product matches your search.";
				bool flag = Operators.CompareString(this.txtSearchProductCode.Text, " ", false) != 0;
				if (flag)
				{
					this.SearchBarCode(Conversions.ToInteger(Interaction.IIf(Operators.CompareString(this.txtSearchProductCode.Text, "", false) == 0, 0, Conversion.Val(this.txtSearchProductCode.Text))));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Details: " + ex.Message, "Error");
			}
		}

		// Token: 0x06001EAE RID: 7854 RVA: 0x001116D0 File Offset: 0x0010F8D0
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.cboBranches.Text, "", false) == 0;
				if (flag)
				{
					MessageBox.Show("Please select the branch first.");
				}
				else
				{
					bool flag2 = this.CurrentID == 0;
					if (flag2)
					{
						MessageBox.Show("Please select a product first.");
					}
					else
					{
						this.LoadPSForProduct();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x00111764 File Offset: 0x0010F964
		private void LoadPSForProduct()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "PacketSizeBranchPricesGet";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranches.Text);
			sqlCommand.Parameters.AddWithValue("productid", this.CurrentID);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.dgvPSPrices.DataSource = dataTable;
			this.dgvPSPrices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvPSPrices.Columns["entryno"].Visible = false;
			this.dgvPSPrices.Columns["groupid"].Visible = false;
			this.dgvPSPrices.Columns["packetsizesentryno"].Visible = false;
			this.dgvPSPrices.Columns["branch"].ReadOnly = true;
			this.dgvPSPrices.Columns["branch"].DefaultCellStyle.BackColor = Color.LightGray;
			this.dgvPSPrices.Columns["productid"].ReadOnly = true;
			this.dgvPSPrices.Columns["productid"].DefaultCellStyle.BackColor = Color.LightGray;
			this.dgvPSPrices.Columns["packetsizeqty"].ReadOnly = true;
			this.dgvPSPrices.Columns["packetsizeqty"].DefaultCellStyle.BackColor = Color.LightGray;
			this.dgvPSPrices.Columns["packetsizename"].ReadOnly = true;
			this.dgvPSPrices.Columns["packetsizename"].DefaultCellStyle.BackColor = Color.LightGray;
			this.dgvPSPrices.Columns["psgroupname"].ReadOnly = true;
			this.dgvPSPrices.Columns["psgroupname"].DefaultCellStyle.BackColor = Color.LightGray;
			bool flag = dataTable.Rows.Count > 0;
			if (flag)
			{
				MessageBox.Show("Packet Sizes for product loaded");
			}
			else
			{
				MessageBox.Show("There are no Packet Sizes set for this product and branch");
			}
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x001119F0 File Offset: 0x0010FBF0
		private void cboPSGroups_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x00002A30 File Offset: 0x00000C30
		private void LoadPSGroupsintoGrid(int groupid)
		{
		}

		// Token: 0x06001EB2 RID: 7858 RVA: 0x00111A24 File Offset: 0x0010FC24
		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.cboPSGroups.SelectedIndex == -1;
				if (flag)
				{
					MessageBox.Show("Please select a Packet Size Group first.");
				}
				else
				{
					bool flag2 = Operators.CompareString(this.cboBranches.Text, "", false) == 0;
					if (flag2)
					{
						MessageBox.Show("Select the branch first.");
					}
					else
					{
						bool flag3 = this.CurrentID == 0;
						if (flag3)
						{
							MessageBox.Show("Please select a product first.");
						}
						else
						{
							DataTable dataTable = this.pf.PacketSizesGetListforGroup(Conversions.ToInteger(this.cboPSGroups.SelectedValue), MyProject.Forms.Form1.Constring);
							SqlConnection sqlConnection = new SqlConnection(this._cnn);
							SqlCommand sqlCommand = sqlConnection.CreateCommand();
							sqlCommand.Connection = sqlConnection;
							sqlCommand.Connection.Open();
							SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunProductDetailsSave");
							sqlCommand.Transaction = sqlTransaction;
							try
							{
								sqlCommand.Parameters.Clear();
								sqlCommand.CommandType = CommandType.Text;
								sqlCommand.CommandText = "delete PacketSizeBranchPrices where coid=" + Conversions.ToString(MyProject.Forms.Form1.coid) + " and productid=" + Conversions.ToString(this.CurrentID);
								sqlCommand.ExecuteNonQuery();
								try
								{
									foreach (object obj in dataTable.Rows)
									{
										DataRow dataRow = (DataRow)obj;
										sqlCommand.Parameters.Clear();
										sqlCommand.CommandType = CommandType.StoredProcedure;
										sqlCommand.CommandText = "PacketSizeInsertforProduct";
										sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
										sqlCommand.Parameters.AddWithValue("branch", this.cboBranches.Text);
										sqlCommand.Parameters.AddWithValue("productid", this.CurrentID);
										sqlCommand.Parameters.AddWithValue("sellingpriceperunit", 0);
										sqlCommand.Parameters.AddWithValue("groupid", Conversions.ToInteger(this.cboPSGroups.SelectedValue));
										sqlCommand.Parameters.AddWithValue("packetsizesentryno", RuntimeHelpers.GetObjectValue(dataRow["packetsizeentryno"]));
										sqlCommand.ExecuteNonQuery();
									}
								}
								finally
								{
									IEnumerator enumerator;
									if (enumerator is IDisposable)
									{
										(enumerator as IDisposable).Dispose();
									}
								}
								sqlTransaction.Commit();
								sqlCommand.Connection.Close();
								this.LoadPSForProduct();
								MessageBox.Show("Packet Sizes for Product Loaded. SET PRICES NOW.");
							}
							catch (Exception ex)
							{
								MessageBox.Show("Error saving Packet Size details for product. Detail: " + ex.Message);
							}
						}
					}
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show("Error applying Packet Size group details to product. Detail: " + ex2.Message);
			}
		}

		// Token: 0x06001EB3 RID: 7859 RVA: 0x00111D54 File Offset: 0x0010FF54
		private void dgvPSPrices_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				this.dgvPSPrices.Rows[e.RowIndex].Cells["sellingpriceperunit"].Value = Operators.DivideObject(this.dgvPSPrices.Rows[e.RowIndex].Cells["PackPrice"].Value, this.dgvPSPrices.Rows[e.RowIndex].Cells["PacketSizeQty"].Value);
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001EB4 RID: 7860 RVA: 0x00111E0C File Offset: 0x0011000C
		private void Button4_Click(object sender, EventArgs e)
		{
			bool flag = this.dgvPSPrices.Rows.Count == 0;
			if (flag)
			{
				MessageBox.Show("No prices set.");
			}
			else
			{
				Branches branches = new Branches();
				branches.branches_header = "Select Branches to apply Price to";
				branches.ShowDialog(this);
				branches.Dispose();
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.Connection = sqlConnection;
				sqlCommand.Connection.Open();
				SqlTransaction sqlTransaction = sqlConnection.BeginTransaction("RunProductDetailsSave");
				sqlCommand.Transaction = sqlTransaction;
				try
				{
					try
					{
						foreach (object obj in MyProject.Forms.Form1.datPriceBranches.Rows)
						{
							DataRow dataRow = (DataRow)obj;
							try
							{
								foreach (object obj2 in ((IEnumerable)this.dgvPSPrices.Rows))
								{
									DataGridViewRow dataGridViewRow = (DataGridViewRow)obj2;
									sqlCommand.Parameters.Clear();
									sqlCommand.CommandType = CommandType.StoredProcedure;
									sqlCommand.CommandText = "PacketSizeUpdateforProduct";
									sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
									sqlCommand.Parameters.AddWithValue("productid", Conversions.ToInteger(dataGridViewRow.Cells["productid"].Value));
									sqlCommand.Parameters.AddWithValue("branch", RuntimeHelpers.GetObjectValue(dataRow["branch"]));
									sqlCommand.Parameters.AddWithValue("groupid", Conversions.ToInteger(dataGridViewRow.Cells["groupid"].Value));
									sqlCommand.Parameters.AddWithValue("packetsizesentryno", Conversions.ToInteger(dataGridViewRow.Cells["packetsizesentryno"].Value));
									sqlCommand.Parameters.AddWithValue("entryno", Conversions.ToInteger(dataGridViewRow.Cells["entryno"].Value));
									sqlCommand.Parameters.AddWithValue("sellingprice", Conversions.ToDecimal(dataGridViewRow.Cells["sellingpriceperunit"].Value));
									sqlCommand.ExecuteNonQuery();
								}
							}
							finally
							{
								IEnumerator enumerator2;
								if (enumerator2 is IDisposable)
								{
									(enumerator2 as IDisposable).Dispose();
								}
							}
						}
					}
					finally
					{
						IEnumerator enumerator;
						if (enumerator is IDisposable)
						{
							(enumerator as IDisposable).Dispose();
						}
					}
					sqlTransaction.Commit();
					sqlCommand.Connection.Close();
					MessageBox.Show("Packet Prices changed.");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error updating packet prices. Detail: " + ex.Message);
				}
			}
		}

		// Token: 0x04000E8F RID: 3727
		private PublicFunctions pf;

		// Token: 0x04000E90 RID: 3728
		private string _cnn;

		// Token: 0x04000E91 RID: 3729
		private int CurrentID;

		// Token: 0x04000E92 RID: 3730
		private string CurrentCode;
	}
}
