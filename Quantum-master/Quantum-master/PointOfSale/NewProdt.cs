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
	// Token: 0x0200007A RID: 122
	[DesignerGenerated]
	public partial class NewProdt : Form
	{
		// Token: 0x06001A47 RID: 6727 RVA: 0x000F09C8 File Offset: 0x000EEBC8
		public NewProdt()
		{
			base.Load += this.NewProdt_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.publicfunction = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06001A4A RID: 6730 RVA: 0x000F0EDD File Offset: 0x000EF0DD
		// (set) Token: 0x06001A4B RID: 6731 RVA: 0x000F0EE8 File Offset: 0x000EF0E8
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

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06001A4C RID: 6732 RVA: 0x000F0F2B File Offset: 0x000EF12B
		// (set) Token: 0x06001A4D RID: 6733 RVA: 0x000F0F35 File Offset: 0x000EF135
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06001A4E RID: 6734 RVA: 0x000F0F3E File Offset: 0x000EF13E
		// (set) Token: 0x06001A4F RID: 6735 RVA: 0x000F0F48 File Offset: 0x000EF148
		internal virtual TextBox txtdesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06001A50 RID: 6736 RVA: 0x000F0F51 File Offset: 0x000EF151
		// (set) Token: 0x06001A51 RID: 6737 RVA: 0x000F0F5C File Offset: 0x000EF15C
		internal virtual ComboBox cboCategory
		{
			[CompilerGenerated]
			get
			{
				return this._cboCategory;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboCategory_SelectedIndexChanged);
				ComboBox comboBox = this._cboCategory;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboCategory = value;
				comboBox = this._cboCategory;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06001A52 RID: 6738 RVA: 0x000F0F9F File Offset: 0x000EF19F
		// (set) Token: 0x06001A53 RID: 6739 RVA: 0x000F0FA9 File Offset: 0x000EF1A9
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06001A54 RID: 6740 RVA: 0x000F0FB2 File Offset: 0x000EF1B2
		// (set) Token: 0x06001A55 RID: 6741 RVA: 0x000F0FBC File Offset: 0x000EF1BC
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06001A56 RID: 6742 RVA: 0x000F0FC5 File Offset: 0x000EF1C5
		// (set) Token: 0x06001A57 RID: 6743 RVA: 0x000F0FCF File Offset: 0x000EF1CF
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06001A58 RID: 6744 RVA: 0x000F0FD8 File Offset: 0x000EF1D8
		// (set) Token: 0x06001A59 RID: 6745 RVA: 0x000F0FE4 File Offset: 0x000EF1E4
		internal virtual TextBox txtReorder
		{
			[CompilerGenerated]
			get
			{
				return this._txtReorder;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtReorder_KeyPress);
				TextBox textBox = this._txtReorder;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtReorder = value;
				textBox = this._txtReorder;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x000F1028 File Offset: 0x000EF228
		private void NewProdt_Load(object sender, EventArgs e)
		{
			try
			{
				this.LoadCategories();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x000F1078 File Offset: 0x000EF278
		private void LoadCategories()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchCategories";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.cboCategory.DataSource = dataTable;
			this.cboCategory.ValueMember = "CatID";
			this.cboCategory.DisplayMember = "CatDesc";
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x000F1118 File Offset: 0x000EF318
		private void SaveProduct()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertNewProduct";
			sqlCommand.Parameters.AddWithValue("catid", RuntimeHelpers.GetObjectValue(this.cboCategory.SelectedValue));
			sqlCommand.Parameters.AddWithValue("productdesc", this.txtdesc.Text);
			sqlCommand.Parameters.AddWithValue("cost", 0);
			sqlCommand.Parameters.AddWithValue("sellingprice", 0);
			sqlCommand.Parameters.AddWithValue("reorderlevel", Conversion.Val(this.txtReorder.Text));
			sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
			sqlCommand.Parameters.AddWithValue("donewhen", DateTime.Today.ToString("yyyyMMdd"));
			sqlCommand.Parameters.AddWithValue("new_prodtid", this.newID);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				this.newID = Conversions.ToInteger(sqlCommand.ExecuteScalar());
				sqlConnection.Close();
			}
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x000F12A4 File Offset: 0x000EF4A4
		private void txtReorder_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x000F12F0 File Offset: 0x000EF4F0
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.SaveProduct();
				MessageBox.Show("New product ID is: " + Conversions.ToString(this.newID) + ". Details successfully saved.");
				MyProject.Forms.Form1.newProdtID = this.newID;
				base.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving product. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x000F137C File Offset: 0x000EF57C
		private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.txtdesc.Focus();
		}

		// Token: 0x04000CB8 RID: 3256
		private string _cnn;

		// Token: 0x04000CB9 RID: 3257
		private int newID;

		// Token: 0x04000CBA RID: 3258
		private PublicFunctions publicfunction;
	}
}
