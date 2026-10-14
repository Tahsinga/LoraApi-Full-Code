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
	// Token: 0x020001FE RID: 510
	[DesignerGenerated]
	public partial class Suppliers : Form
	{
		// Token: 0x06005BAD RID: 23469 RVA: 0x0034C8F4 File Offset: 0x0034AAF4
		public Suppliers()
		{
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x1700210B RID: 8459
		// (get) Token: 0x06005BB0 RID: 23472 RVA: 0x0034D647 File Offset: 0x0034B847
		// (set) Token: 0x06005BB1 RID: 23473 RVA: 0x0034D651 File Offset: 0x0034B851
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700210C RID: 8460
		// (get) Token: 0x06005BB2 RID: 23474 RVA: 0x0034D65A File Offset: 0x0034B85A
		// (set) Token: 0x06005BB3 RID: 23475 RVA: 0x0034D664 File Offset: 0x0034B864
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700210D RID: 8461
		// (get) Token: 0x06005BB4 RID: 23476 RVA: 0x0034D66D File Offset: 0x0034B86D
		// (set) Token: 0x06005BB5 RID: 23477 RVA: 0x0034D678 File Offset: 0x0034B878
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

		// Token: 0x1700210E RID: 8462
		// (get) Token: 0x06005BB6 RID: 23478 RVA: 0x0034D6BB File Offset: 0x0034B8BB
		// (set) Token: 0x06005BB7 RID: 23479 RVA: 0x0034D6C5 File Offset: 0x0034B8C5
		internal virtual TextBox txtComments
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700210F RID: 8463
		// (get) Token: 0x06005BB8 RID: 23480 RVA: 0x0034D6CE File Offset: 0x0034B8CE
		// (set) Token: 0x06005BB9 RID: 23481 RVA: 0x0034D6D8 File Offset: 0x0034B8D8
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002110 RID: 8464
		// (get) Token: 0x06005BBA RID: 23482 RVA: 0x0034D6E1 File Offset: 0x0034B8E1
		// (set) Token: 0x06005BBB RID: 23483 RVA: 0x0034D6EB File Offset: 0x0034B8EB
		internal virtual TextBox txtAddress
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002111 RID: 8465
		// (get) Token: 0x06005BBC RID: 23484 RVA: 0x0034D6F4 File Offset: 0x0034B8F4
		// (set) Token: 0x06005BBD RID: 23485 RVA: 0x0034D6FE File Offset: 0x0034B8FE
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002112 RID: 8466
		// (get) Token: 0x06005BBE RID: 23486 RVA: 0x0034D707 File Offset: 0x0034B907
		// (set) Token: 0x06005BBF RID: 23487 RVA: 0x0034D711 File Offset: 0x0034B911
		internal virtual TextBox txtEmail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002113 RID: 8467
		// (get) Token: 0x06005BC0 RID: 23488 RVA: 0x0034D71A File Offset: 0x0034B91A
		// (set) Token: 0x06005BC1 RID: 23489 RVA: 0x0034D724 File Offset: 0x0034B924
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002114 RID: 8468
		// (get) Token: 0x06005BC2 RID: 23490 RVA: 0x0034D72D File Offset: 0x0034B92D
		// (set) Token: 0x06005BC3 RID: 23491 RVA: 0x0034D737 File Offset: 0x0034B937
		internal virtual TextBox txtContactNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002115 RID: 8469
		// (get) Token: 0x06005BC4 RID: 23492 RVA: 0x0034D740 File Offset: 0x0034B940
		// (set) Token: 0x06005BC5 RID: 23493 RVA: 0x0034D74A File Offset: 0x0034B94A
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002116 RID: 8470
		// (get) Token: 0x06005BC6 RID: 23494 RVA: 0x0034D753 File Offset: 0x0034B953
		// (set) Token: 0x06005BC7 RID: 23495 RVA: 0x0034D75D File Offset: 0x0034B95D
		internal virtual TextBox txtContactPerson
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002117 RID: 8471
		// (get) Token: 0x06005BC8 RID: 23496 RVA: 0x0034D766 File Offset: 0x0034B966
		// (set) Token: 0x06005BC9 RID: 23497 RVA: 0x0034D770 File Offset: 0x0034B970
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002118 RID: 8472
		// (get) Token: 0x06005BCA RID: 23498 RVA: 0x0034D779 File Offset: 0x0034B979
		// (set) Token: 0x06005BCB RID: 23499 RVA: 0x0034D783 File Offset: 0x0034B983
		internal virtual TextBox txtCoName
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17002119 RID: 8473
		// (get) Token: 0x06005BCC RID: 23500 RVA: 0x0034D78C File Offset: 0x0034B98C
		// (set) Token: 0x06005BCD RID: 23501 RVA: 0x0034D796 File Offset: 0x0034B996
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700211A RID: 8474
		// (get) Token: 0x06005BCE RID: 23502 RVA: 0x0034D79F File Offset: 0x0034B99F
		// (set) Token: 0x06005BCF RID: 23503 RVA: 0x0034D7A9 File Offset: 0x0034B9A9
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700211B RID: 8475
		// (get) Token: 0x06005BD0 RID: 23504 RVA: 0x0034D7B2 File Offset: 0x0034B9B2
		// (set) Token: 0x06005BD1 RID: 23505 RVA: 0x0034D7BC File Offset: 0x0034B9BC
		internal virtual TextBox txtDetail1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700211C RID: 8476
		// (get) Token: 0x06005BD2 RID: 23506 RVA: 0x0034D7C5 File Offset: 0x0034B9C5
		// (set) Token: 0x06005BD3 RID: 23507 RVA: 0x0034D7CF File Offset: 0x0034B9CF
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700211D RID: 8477
		// (get) Token: 0x06005BD4 RID: 23508 RVA: 0x0034D7D8 File Offset: 0x0034B9D8
		// (set) Token: 0x06005BD5 RID: 23509 RVA: 0x0034D7E2 File Offset: 0x0034B9E2
		internal virtual TextBox txtTaxNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700211E RID: 8478
		// (get) Token: 0x06005BD6 RID: 23510 RVA: 0x0034D7EB File Offset: 0x0034B9EB
		// (set) Token: 0x06005BD7 RID: 23511 RVA: 0x0034D7F5 File Offset: 0x0034B9F5
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005BD8 RID: 23512 RVA: 0x0034D800 File Offset: 0x0034BA00
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "SaveSupplierDetails";
				sqlCommand.Parameters.AddWithValue("suppliername", this.txtCoName.Text);
				sqlCommand.Parameters.AddWithValue("contactperson", this.txtContactPerson.Text);
				sqlCommand.Parameters.AddWithValue("address", this.txtAddress.Text);
				sqlCommand.Parameters.AddWithValue("contactnumber", this.txtContactNumber.Text);
				sqlCommand.Parameters.AddWithValue("Email", this.txtEmail.Text);
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				sqlCommand.Parameters.AddWithValue("comments", this.txtComments.Text);
				sqlCommand.Parameters.AddWithValue("taxnumber", this.txtTaxNumber.Text);
				sqlCommand.Parameters.AddWithValue("detail1", this.txtDetail1.Text);
				using (sqlConnection)
				{
					sqlConnection.Open();
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
				}
				MessageBox.Show("Supplier details saved successfully.");
				MyProject.Forms.Form1.suppliername = this.txtCoName.Text;
				this.txtCoName.Text = "";
				this.txtContactPerson.Text = "";
				this.txtAddress.Text = "";
				this.txtContactNumber.Text = "";
				this.txtEmail.Text = "";
				this.txtComments.Text = "";
				this.txtTaxNumber.Text = "";
				this.txtDetail1.Text = "";
				base.Dispose();
			}
			catch (SqlException ex)
			{
				bool flag = ex.Number == 2601;
				if (flag)
				{
					MessageBox.Show("Supplier already exists in the system", "Supplier error", MessageBoxButtons.OK);
				}
				else
				{
					MessageBox.Show("An error has occured. Contact your system administrator. Detailed error: " + ex.Message, "Error", MessageBoxButtons.OK);
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show("Error saving supplier details. " + ex2.Message);
			}
		}

		// Token: 0x0400282C RID: 10284
		private string _cnn;
	}
}
