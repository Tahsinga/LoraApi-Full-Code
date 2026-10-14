using System;
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
	// Token: 0x02000161 RID: 353
	[DesignerGenerated]
	public partial class PriceMatrix : Form
	{
		// Token: 0x06002F05 RID: 12037 RVA: 0x00198470 File Offset: 0x00196670
		public PriceMatrix()
		{
			this.pf = new PublicFunctions();
			this._cnn = MyProject.Forms.Form1.Constring;
			this.currentID = 0;
			this.InitializeComponent();
		}

		// Token: 0x1700117C RID: 4476
		// (get) Token: 0x06002F08 RID: 12040 RVA: 0x00199530 File Offset: 0x00197730
		// (set) Token: 0x06002F09 RID: 12041 RVA: 0x0019953A File Offset: 0x0019773A
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700117D RID: 4477
		// (get) Token: 0x06002F0A RID: 12042 RVA: 0x00199543 File Offset: 0x00197743
		// (set) Token: 0x06002F0B RID: 12043 RVA: 0x00199550 File Offset: 0x00197750
		internal virtual DataGridView dgvPrice
		{
			[CompilerGenerated]
			get
			{
				return this._dgvPrice;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.dgvPrice_CellContentClick);
				DataGridView dataGridView = this._dgvPrice;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick -= dataGridViewCellEventHandler;
				}
				this._dgvPrice = value;
				dataGridView = this._dgvPrice;
				if (dataGridView != null)
				{
					dataGridView.CellContentClick += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x1700117E RID: 4478
		// (get) Token: 0x06002F0C RID: 12044 RVA: 0x00199593 File Offset: 0x00197793
		// (set) Token: 0x06002F0D RID: 12045 RVA: 0x0019959D File Offset: 0x0019779D
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700117F RID: 4479
		// (get) Token: 0x06002F0E RID: 12046 RVA: 0x001995A6 File Offset: 0x001977A6
		// (set) Token: 0x06002F0F RID: 12047 RVA: 0x001995B0 File Offset: 0x001977B0
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
				KeyEventHandler keyEventHandler = new KeyEventHandler(this.DGVSearch_KeyDown);
				DataGridView dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.CellEnter -= dataGridViewCellEventHandler;
					dataGridView.KeyDown -= keyEventHandler;
				}
				this._DGVSearch = value;
				dataGridView = this._DGVSearch;
				if (dataGridView != null)
				{
					dataGridView.CellEnter += dataGridViewCellEventHandler;
					dataGridView.KeyDown += keyEventHandler;
				}
			}
		}

		// Token: 0x17001180 RID: 4480
		// (get) Token: 0x06002F10 RID: 12048 RVA: 0x0019960E File Offset: 0x0019780E
		// (set) Token: 0x06002F11 RID: 12049 RVA: 0x00199618 File Offset: 0x00197818
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001181 RID: 4481
		// (get) Token: 0x06002F12 RID: 12050 RVA: 0x00199621 File Offset: 0x00197821
		// (set) Token: 0x06002F13 RID: 12051 RVA: 0x0019962C File Offset: 0x0019782C
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

		// Token: 0x17001182 RID: 4482
		// (get) Token: 0x06002F14 RID: 12052 RVA: 0x0019966F File Offset: 0x0019786F
		// (set) Token: 0x06002F15 RID: 12053 RVA: 0x00199679 File Offset: 0x00197879
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001183 RID: 4483
		// (get) Token: 0x06002F16 RID: 12054 RVA: 0x00199682 File Offset: 0x00197882
		// (set) Token: 0x06002F17 RID: 12055 RVA: 0x0019968C File Offset: 0x0019788C
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

		// Token: 0x17001184 RID: 4484
		// (get) Token: 0x06002F18 RID: 12056 RVA: 0x001996CF File Offset: 0x001978CF
		// (set) Token: 0x06002F19 RID: 12057 RVA: 0x001996D9 File Offset: 0x001978D9
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001185 RID: 4485
		// (get) Token: 0x06002F1A RID: 12058 RVA: 0x001996E2 File Offset: 0x001978E2
		// (set) Token: 0x06002F1B RID: 12059 RVA: 0x001996EC File Offset: 0x001978EC
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

		// Token: 0x17001186 RID: 4486
		// (get) Token: 0x06002F1C RID: 12060 RVA: 0x0019972F File Offset: 0x0019792F
		// (set) Token: 0x06002F1D RID: 12061 RVA: 0x00199739 File Offset: 0x00197939
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001187 RID: 4487
		// (get) Token: 0x06002F1E RID: 12062 RVA: 0x00199742 File Offset: 0x00197942
		// (set) Token: 0x06002F1F RID: 12063 RVA: 0x0019974C File Offset: 0x0019794C
		internal virtual TextBox txtSellingPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001188 RID: 4488
		// (get) Token: 0x06002F20 RID: 12064 RVA: 0x00199755 File Offset: 0x00197955
		// (set) Token: 0x06002F21 RID: 12065 RVA: 0x0019975F File Offset: 0x0019795F
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001189 RID: 4489
		// (get) Token: 0x06002F22 RID: 12066 RVA: 0x00199768 File Offset: 0x00197968
		// (set) Token: 0x06002F23 RID: 12067 RVA: 0x00199772 File Offset: 0x00197972
		internal virtual TextBox lblDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700118A RID: 4490
		// (get) Token: 0x06002F24 RID: 12068 RVA: 0x0019977B File Offset: 0x0019797B
		// (set) Token: 0x06002F25 RID: 12069 RVA: 0x00199788 File Offset: 0x00197988
		internal virtual Label Label2
		{
			[CompilerGenerated]
			get
			{
				return this._Label2;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label2_Click);
				Label label = this._Label2;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label2 = value;
				label = this._Label2;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700118B RID: 4491
		// (get) Token: 0x06002F26 RID: 12070 RVA: 0x001997CB File Offset: 0x001979CB
		// (set) Token: 0x06002F27 RID: 12071 RVA: 0x001997D5 File Offset: 0x001979D5
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700118C RID: 4492
		// (get) Token: 0x06002F28 RID: 12072 RVA: 0x001997DE File Offset: 0x001979DE
		// (set) Token: 0x06002F29 RID: 12073 RVA: 0x001997E8 File Offset: 0x001979E8
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

		// Token: 0x1700118D RID: 4493
		// (get) Token: 0x06002F2A RID: 12074 RVA: 0x0019982B File Offset: 0x00197A2B
		// (set) Token: 0x06002F2B RID: 12075 RVA: 0x00199835 File Offset: 0x00197A35
		internal virtual TextBox txtNewPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700118E RID: 4494
		// (get) Token: 0x06002F2C RID: 12076 RVA: 0x0019983E File Offset: 0x00197A3E
		// (set) Token: 0x06002F2D RID: 12077 RVA: 0x00199848 File Offset: 0x00197A48
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700118F RID: 4495
		// (get) Token: 0x06002F2E RID: 12078 RVA: 0x00199851 File Offset: 0x00197A51
		// (set) Token: 0x06002F2F RID: 12079 RVA: 0x0019985B File Offset: 0x00197A5B
		internal virtual TextBox txtTo
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001190 RID: 4496
		// (get) Token: 0x06002F30 RID: 12080 RVA: 0x00199864 File Offset: 0x00197A64
		// (set) Token: 0x06002F31 RID: 12081 RVA: 0x0019986E File Offset: 0x00197A6E
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001191 RID: 4497
		// (get) Token: 0x06002F32 RID: 12082 RVA: 0x00199877 File Offset: 0x00197A77
		// (set) Token: 0x06002F33 RID: 12083 RVA: 0x00199881 File Offset: 0x00197A81
		internal virtual TextBox txtFrom
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001192 RID: 4498
		// (get) Token: 0x06002F34 RID: 12084 RVA: 0x0019988A File Offset: 0x00197A8A
		// (set) Token: 0x06002F35 RID: 12085 RVA: 0x00199894 File Offset: 0x00197A94
		internal virtual TextBox txtSearchProductID
		{
			[CompilerGenerated]
			get
			{
				return this._txtSearchProductID;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtSearchProductID_KeyPress);
				EventHandler eventHandler = new EventHandler(this.txtSearchProductID_TextChanged);
				TextBox textBox = this._txtSearchProductID;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
					textBox.TextChanged -= eventHandler;
				}
				this._txtSearchProductID = value;
				textBox = this._txtSearchProductID;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
					textBox.TextChanged += eventHandler;
				}
			}
		}

		// Token: 0x17001193 RID: 4499
		// (get) Token: 0x06002F36 RID: 12086 RVA: 0x001998F2 File Offset: 0x00197AF2
		// (set) Token: 0x06002F37 RID: 12087 RVA: 0x001998FC File Offset: 0x00197AFC
		internal virtual Label lblerror
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001194 RID: 4500
		// (get) Token: 0x06002F38 RID: 12088 RVA: 0x00199905 File Offset: 0x00197B05
		// (set) Token: 0x06002F39 RID: 12089 RVA: 0x00199910 File Offset: 0x00197B10
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

		// Token: 0x06002F3A RID: 12090 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06002F3B RID: 12091 RVA: 0x00199954 File Offset: 0x00197B54
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = checked(this.pf.InsertPriceMatrix(this.currentID, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, (int)Math.Round(Conversion.Val(this.txtFrom.Text)), (int)Math.Round(Conversion.Val(this.txtTo.Text)), new decimal(Conversion.Val(this.txtNewPrice.Text)), MyProject.Forms.Form1.Constring, MyProject.Forms.Form1.username, DateTime.Now, Environment.MachineName));
				if (flag)
				{
					MessageBox.Show("Product prices set successfully.");
					this.txtFrom.Text = "";
					this.txtTo.Text = "";
					this.txtNewPrice.Text = "";
					this.loadPriceMatrix();
				}
				else
				{
					MessageBox.Show("Error setting prices. ");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving price matrix. Detail: " + ex.Message);
			}
		}

		// Token: 0x06002F3C RID: 12092 RVA: 0x00199A8C File Offset: 0x00197C8C
		private void loadPriceMatrix()
		{
			this.dgvPrice.Columns.Clear();
			this.dgvPrice.DataSource = this.pf.getPriceMatrix(this.currentID, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, MyProject.Forms.Form1.Constring);
			this.dgvPrice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvPrice.Columns["ID"].Visible = false;
			this.dgvPrice.Columns["isactive"].Visible = false;
			this.dgvPrice.Columns["createdby"].Visible = false;
			this.dgvPrice.Columns["createddate"].Visible = false;
			this.dgvPrice.Columns["createdmachine"].Visible = false;
			this.dgvPrice.Columns["coid"].Visible = false;
			this.dgvPrice.Columns["branch"].Visible = false;
			DataGridViewButtonColumn dataGridViewButtonColumn = new DataGridViewButtonColumn();
			dataGridViewButtonColumn.HeaderText = "Delete";
			dataGridViewButtonColumn.Text = "Delete";
			dataGridViewButtonColumn.Name = "Delete";
			dataGridViewButtonColumn.UseColumnTextForButtonValue = true;
			this.dgvPrice.Columns.Add(dataGridViewButtonColumn);
		}

		// Token: 0x06002F3D RID: 12093 RVA: 0x00199C0C File Offset: 0x00197E0C
		private void FetchProdtDetailsBYCode(string prodtcode)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByCode";
			sqlCommand.Parameters.AddWithValue("productcode", prodtcode);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.lblDesc.Text = Conversions.ToString(dataRow["ProductDesc"]);
				this.currentID = Conversions.ToInteger(dataRow["ProductID"]);
				this.txtSellingPrice.Text = Conversions.ToString(dataRow["SellingPrice"]);
			}
			else
			{
				this.lblDesc.Text = "Nothing found matching that product ID";
				this.currentID = 0;
			}
		}

		// Token: 0x06002F3E RID: 12094 RVA: 0x00002A30 File Offset: 0x00000C30
		private void txtSearchProductID_KeyPress(object sender, KeyPressEventArgs e)
		{
		}

		// Token: 0x06002F3F RID: 12095 RVA: 0x00199D18 File Offset: 0x00197F18
		private void txtSearchProductID_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.FetchProdtDetails(checked((int)Math.Round(Conversion.Val(this.txtSearchProductID.Text))));
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching by ID. Detail: " + ex.Message, "Error");
			}
		}

		// Token: 0x06002F40 RID: 12096 RVA: 0x00199D84 File Offset: 0x00197F84
		private void FetchProdtDetails(int prodtid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByID";
			sqlCommand.Parameters.AddWithValue("prodtID", prodtid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.lblDesc.Text = Conversions.ToString(dataRow["ProductDesc"]);
				this.currentID = Conversions.ToInteger(dataRow["ProductID"]);
				this.txtSellingPrice.Text = Conversions.ToString(dataRow["SellingPrice"]);
			}
			else
			{
				this.lblDesc.Text = "Nothing found matching that product ID";
				this.currentID = 0;
			}
		}

		// Token: 0x06002F41 RID: 12097 RVA: 0x00199E94 File Offset: 0x00198094
		private void DGVSearch_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					string text = Conversions.ToString(this.DGVSearch.Rows[e.RowIndex].Cells["ProductCode"].Value);
					this.txtSearchProductCode.Text = text;
				}
			}
			catch (Exception ex)
			{
				this.lblerror.Text = "Error: " + ex.Message;
			}
		}

		// Token: 0x06002F42 RID: 12098 RVA: 0x00199F54 File Offset: 0x00198154
		private void txtsearch_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.lblerror.Text = "...";
				this.SearchByDescAdvanced(this.txtsearch.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error searching. Detail: " + ex.Message);
			}
		}

		// Token: 0x06002F43 RID: 12099 RVA: 0x00199FC0 File Offset: 0x001981C0
		private void SearchByDescAdvanced(string searchtext)
		{
			string[] array = searchtext.Split(new char[] { ' ' });
			int num = 1;
			DataTable dataTable = new DataTable();
			checked
			{
				foreach (string text in array)
				{
					bool flag = num == 1;
					if (flag)
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
				bool flag2 = dataTable.Rows.Count > 0;
				if (flag2)
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
		}

		// Token: 0x06002F44 RID: 12100 RVA: 0x0019A0CC File Offset: 0x001982CC
		private object searchDat(DataTable dt, string column, string value)
		{
			PriceMatrix._Closure$__117-0 CS$<>8__locals1 = new PriceMatrix._Closure$__117-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_column = column;
			CS$<>8__locals1.$VB$Local_value = value;
			DataTable dataTable = dt.Clone();
			dt.CaseSensitive = false;
			try
			{
				foreach (DataRow dataRow in dt.Rows.Cast<object>().Select<object, DataRow>((PriceMatrix._Closure$__.$I117-0 == null) ? (PriceMatrix._Closure$__.$I117-0 = (object row1) => (DataRow)row1) : PriceMatrix._Closure$__.$I117-0).Where<DataRow>((CS$<>8__locals1.$I1 == null) ? (CS$<>8__locals1.$I1 = (DataRow row1) => Conversions.ToBoolean(NewLateBinding.LateGet(row1[CS$<>8__locals1.$VB$Local_column], null, "Contains", new object[] { CS$<>8__locals1.$VB$Local_value.ToUpper() }, null, null, null))) : CS$<>8__locals1.$I1))
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

		// Token: 0x06002F45 RID: 12101 RVA: 0x0019A1A8 File Offset: 0x001983A8
		private DataTable searchDB(string searchtext)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SearchProduct2";
			sqlCommand.Parameters.AddWithValue("search", searchtext);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06002F46 RID: 12102 RVA: 0x0019A230 File Offset: 0x00198430
		private void SearchBarCode(int prodtID)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByID2";
			sqlCommand.Parameters.AddWithValue("prodtID", prodtID);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				this.lblDesc.Text = Conversions.ToString(Operators.AddObject(Operators.AddObject(dataRow["ProductDesc"], " "), dataRow["ProductDesc2"]));
				this.txtSearchProductID.Text = Conversions.ToString(dataRow["ProductID"]);
			}
			else
			{
				this.txtSearchProductCode.Text = "";
			}
		}

		// Token: 0x06002F47 RID: 12103 RVA: 0x0019A33C File Offset: 0x0019853C
		private void DGVSearch_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				bool flag = e.KeyCode == Keys.Return;
				if (flag)
				{
					e.Handled = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Key down error. Ignore");
			}
		}

		// Token: 0x06002F48 RID: 12104 RVA: 0x0019A390 File Offset: 0x00198590
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

		// Token: 0x06002F49 RID: 12105 RVA: 0x0019A3F0 File Offset: 0x001985F0
		private void FetchAllProducts()
		{
			this.lblerror.Text = "...";
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectAllProducts3";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
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
				this.DGVSearch.Columns["Unit_of_Measure"].Visible = false;
				this.DGVSearch.Columns["Bin_Location"].Visible = false;
				this.DGVSearch.Columns["Product_Desc2"].Visible = false;
				this.DGVSearch.Columns["Wholesale_Selling_Price"].Visible = false;
				this.DGVSearch.Columns["Wholesale_Qty"].Visible = false;
				this.DGVSearch.Columns["Tax_Percentage"].Visible = false;
				this.DGVSearch.Columns["Is_Active"].Visible = false;
				this.DGVSearch.Columns["Special_Price"].Visible = false;
				this.DGVSearch.Columns["PRODUCTEXPIRES"].Visible = false;
				this.DGVSearch.Columns["DifferentPricesPerBranch"].Visible = false;
				this.DGVSearch.Columns["Is_Ingridient"].Visible = false;
				this.DGVSearch.Columns["Unlimited_Stock_Item"].Visible = false;
			}
			else
			{
				this.lblerror.Text = "No products match your search.";
			}
		}

		// Token: 0x06002F4A RID: 12106 RVA: 0x0019A6A8 File Offset: 0x001988A8
		private void txtSearchProductCode_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.FetchProdtDetailsBYCode(this.txtSearchProductCode.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error occurred searching by code. Detail: " + ex.Message, "Error");
			}
		}

		// Token: 0x06002F4B RID: 12107 RVA: 0x0019A708 File Offset: 0x00198908
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				this.loadPriceMatrix();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error showing price matrix.");
			}
		}

		// Token: 0x06002F4C RID: 12108 RVA: 0x0019A74C File Offset: 0x0019894C
		private void dgvPrice_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				bool flag = (dataGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn) & (e.RowIndex >= 0);
				if (flag)
				{
					bool flag2 = Operators.CompareString(dataGridView.Columns[e.ColumnIndex].Name, "Delete", false) == 0;
					if (flag2)
					{
						this.DeletePrice(Conversions.ToInteger(this.dgvPrice.Rows[e.RowIndex].Cells["ID"].Value));
						MessageBox.Show("Deleted successfully.");
						this.loadPriceMatrix();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error occurred. Detail: " + ex.Message);
			}
		}

		// Token: 0x06002F4D RID: 12109 RVA: 0x0019A838 File Offset: 0x00198A38
		private void DeletePrice(int ID)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "update pricematrix set isactive=0 where ID=" + Conversions.ToString(ID);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x04001444 RID: 5188
		private PublicFunctions pf;

		// Token: 0x04001445 RID: 5189
		private string _cnn;

		// Token: 0x04001446 RID: 5190
		private int currentID;
	}
}
