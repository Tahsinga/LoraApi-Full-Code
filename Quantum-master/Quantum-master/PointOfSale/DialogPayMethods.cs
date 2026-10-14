using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale
{
	// Token: 0x02000044 RID: 68
	[DesignerGenerated]
	public partial class DialogPayMethods : Form
	{
		// Token: 0x06000EEF RID: 3823 RVA: 0x0008E85A File Offset: 0x0008CA5A
		public DialogPayMethods()
		{
			base.Load += this.DialogPayMethods_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.loaded = 0;
			this.InitializeComponent();
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06000EF2 RID: 3826 RVA: 0x0008EAF5 File Offset: 0x0008CCF5
		// (set) Token: 0x06000EF3 RID: 3827 RVA: 0x0008EB00 File Offset: 0x0008CD00
		internal virtual ListBox ListBox1
		{
			[CompilerGenerated]
			get
			{
				return this._ListBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.ListBox1_SelectedIndexChanged);
				ListBox listBox = this._ListBox1;
				if (listBox != null)
				{
					listBox.SelectedIndexChanged -= eventHandler;
				}
				this._ListBox1 = value;
				listBox = this._ListBox1;
				if (listBox != null)
				{
					listBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06000EF4 RID: 3828 RVA: 0x0008EB43 File Offset: 0x0008CD43
		// (set) Token: 0x06000EF5 RID: 3829 RVA: 0x0008EB4D File Offset: 0x0008CD4D
		internal virtual TextBox txtpaymethid
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06000EF6 RID: 3830 RVA: 0x0008EB56 File Offset: 0x0008CD56
		// (set) Token: 0x06000EF7 RID: 3831 RVA: 0x0008EB60 File Offset: 0x0008CD60
		internal virtual TextBox txtpaymethdesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x0008EB6C File Offset: 0x0008CD6C
		private void DialogPayMethods_Load(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "SelectPaymentMethods";
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				sqlDataAdapter.Fill(dataTable);
				this.ListBox1.DataSource = dataTable;
				this.ListBox1.ValueMember = "PaymentMethodID";
				this.ListBox1.DisplayMember = "PaymentMethodDesc";
				this.loaded = 1;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x0008EC4C File Offset: 0x0008CE4C
		private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				int num = Conversions.ToInteger(this.ListBox1.SelectedValue);
				this.txtpaymethid.Text = num.ToString();
				this.txtpaymethdesc.Text = this.ListBox1.GetItemText(RuntimeHelpers.GetObjectValue(this.ListBox1.SelectedItem));
				bool flag = this.loaded == 1;
				if (flag)
				{
					base.DialogResult = DialogResult.OK;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x04000728 RID: 1832
		private string _cnn;

		// Token: 0x04000729 RID: 1833
		private int loaded;
	}
}
