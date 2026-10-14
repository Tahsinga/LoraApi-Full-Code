using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x0200004C RID: 76
	[DesignerGenerated]
	public partial class EditComment : Form
	{
		// Token: 0x0600100B RID: 4107 RVA: 0x00097B98 File Offset: 0x00095D98
		public EditComment()
		{
			base.Load += this.EditComment_Load;
			this.InitializeComponent();
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x0600100E RID: 4110 RVA: 0x00098251 File Offset: 0x00096451
		// (set) Token: 0x0600100F RID: 4111 RVA: 0x0009825B File Offset: 0x0009645B
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x06001010 RID: 4112 RVA: 0x00098264 File Offset: 0x00096464
		// (set) Token: 0x06001011 RID: 4113 RVA: 0x0009826E File Offset: 0x0009646E
		internal virtual TextBox txtCustomer
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x06001012 RID: 4114 RVA: 0x00098277 File Offset: 0x00096477
		// (set) Token: 0x06001013 RID: 4115 RVA: 0x00098281 File Offset: 0x00096481
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x06001014 RID: 4116 RVA: 0x0009828A File Offset: 0x0009648A
		// (set) Token: 0x06001015 RID: 4117 RVA: 0x00098294 File Offset: 0x00096494
		internal virtual TextBox txtInvDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x06001016 RID: 4118 RVA: 0x0009829D File Offset: 0x0009649D
		// (set) Token: 0x06001017 RID: 4119 RVA: 0x000982A8 File Offset: 0x000964A8
		internal virtual Label Label3
		{
			[CompilerGenerated]
			get
			{
				return this._Label3;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label3_Click);
				Label label = this._Label3;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label3 = value;
				label = this._Label3;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x06001018 RID: 4120 RVA: 0x000982EB File Offset: 0x000964EB
		// (set) Token: 0x06001019 RID: 4121 RVA: 0x000982F5 File Offset: 0x000964F5
		internal virtual TextBox txtInvNum
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x0600101A RID: 4122 RVA: 0x000982FE File Offset: 0x000964FE
		// (set) Token: 0x0600101B RID: 4123 RVA: 0x00098308 File Offset: 0x00096508
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x0600101C RID: 4124 RVA: 0x00098311 File Offset: 0x00096511
		// (set) Token: 0x0600101D RID: 4125 RVA: 0x0009831B File Offset: 0x0009651B
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x0600101E RID: 4126 RVA: 0x00098324 File Offset: 0x00096524
		// (set) Token: 0x0600101F RID: 4127 RVA: 0x0009832E File Offset: 0x0009652E
		internal virtual DataGridView dgvComments
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06001020 RID: 4128 RVA: 0x00098337 File Offset: 0x00096537
		// (set) Token: 0x06001021 RID: 4129 RVA: 0x00098344 File Offset: 0x00096544
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

		// Token: 0x06001022 RID: 4130 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x00098388 File Offset: 0x00096588
		private void EditComment_Load(object sender, EventArgs e)
		{
			try
			{
				this.txtCustomer.Text = this.invcustomer;
				this.txtInvNum.Text = Conversions.ToString(this.invnum);
				CultureInfo invariantCulture = CultureInfo.InvariantCulture;
				string text = Conversions.ToString(this.invdate);
				string text2 = "yyyyMMdd";
				DateTime dateTime = DateTime.ParseExact(text, text2, invariantCulture);
				this.txtInvDate.Text = dateTime.ToLongDateString();
				this.LoadInvs();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x00098438 File Offset: 0x00096638
		private void LoadInvs()
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"Select entryno, p.productdesc,m.quantity,m.comments from movement m inner join products p on m.productid=p.productid where invoicenum=",
				Conversions.ToString(this.invnum),
				" and coid=",
				Conversions.ToString(MyProject.Forms.Form1.coid),
				" and trancode=3 and branch='",
				MyProject.Forms.Form1.branch,
				"'"
			});
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.dgvComments.DataSource = dataTable;
			this.dgvComments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvComments.Columns["productdesc"].ReadOnly = true;
			this.dgvComments.Columns["quantity"].ReadOnly = true;
			this.dgvComments.Columns["productdesc"].DefaultCellStyle.BackColor = Color.LightGray;
			this.dgvComments.Columns["quantity"].DefaultCellStyle.BackColor = Color.LightGray;
			this.dgvComments.Columns["entryno"].Visible = false;
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x000985A4 File Offset: 0x000967A4
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvComments.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						this.UpdateInvComment(Conversions.ToInteger(dataGridViewRow.Cells["entryno"].Value), Conversions.ToString(dataGridViewRow.Cells["comments"].Value), MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch);
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
				MessageBox.Show("Comments updated.");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Saving changes failed. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x0009869C File Offset: 0x0009689C
		private void UpdateInvComment(int entryno, string newcomment, int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "UpdateInvComment";
			sqlCommand.Parameters.AddWithValue("entryno", entryno);
			sqlCommand.Parameters.AddWithValue("newcomment", newcomment);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x040007B5 RID: 1973
		public int invnum;

		// Token: 0x040007B6 RID: 1974
		public int invdate;

		// Token: 0x040007B7 RID: 1975
		public string invcustomer;
	}
}
