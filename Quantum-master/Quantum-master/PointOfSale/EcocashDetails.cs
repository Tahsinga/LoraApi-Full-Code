using System;
using System.Collections;
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
	// Token: 0x02000046 RID: 70
	[DesignerGenerated]
	public partial class EcocashDetails : Form
	{
		// Token: 0x06000F20 RID: 3872 RVA: 0x0008F958 File Offset: 0x0008DB58
		public EcocashDetails()
		{
			base.Load += this.EcocashDetails_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.InitializeComponent();
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06000F23 RID: 3875 RVA: 0x000903F3 File Offset: 0x0008E5F3
		// (set) Token: 0x06000F24 RID: 3876 RVA: 0x000903FD File Offset: 0x0008E5FD
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06000F25 RID: 3877 RVA: 0x00090406 File Offset: 0x0008E606
		// (set) Token: 0x06000F26 RID: 3878 RVA: 0x00090410 File Offset: 0x0008E610
		internal virtual DataGridView dgvAmts
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06000F27 RID: 3879 RVA: 0x00090419 File Offset: 0x0008E619
		// (set) Token: 0x06000F28 RID: 3880 RVA: 0x00090424 File Offset: 0x0008E624
		internal virtual TextBox txtAmount
		{
			[CompilerGenerated]
			get
			{
				return this._txtAmount;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtAmount_KeyPress);
				TextBox textBox = this._txtAmount;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtAmount = value;
				textBox = this._txtAmount;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06000F29 RID: 3881 RVA: 0x00090467 File Offset: 0x0008E667
		// (set) Token: 0x06000F2A RID: 3882 RVA: 0x00090471 File Offset: 0x0008E671
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06000F2B RID: 3883 RVA: 0x0009047A File Offset: 0x0008E67A
		// (set) Token: 0x06000F2C RID: 3884 RVA: 0x00090484 File Offset: 0x0008E684
		internal virtual TextBox txtTranCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06000F2D RID: 3885 RVA: 0x0009048D File Offset: 0x0008E68D
		// (set) Token: 0x06000F2E RID: 3886 RVA: 0x00090497 File Offset: 0x0008E697
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06000F2F RID: 3887 RVA: 0x000904A0 File Offset: 0x0008E6A0
		// (set) Token: 0x06000F30 RID: 3888 RVA: 0x000904AC File Offset: 0x0008E6AC
		internal virtual TextBox txtMobile
		{
			[CompilerGenerated]
			get
			{
				return this._txtMobile;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtMobile_KeyPress);
				TextBox textBox = this._txtMobile;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtMobile = value;
				textBox = this._txtMobile;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06000F31 RID: 3889 RVA: 0x000904EF File Offset: 0x0008E6EF
		// (set) Token: 0x06000F32 RID: 3890 RVA: 0x000904F9 File Offset: 0x0008E6F9
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06000F33 RID: 3891 RVA: 0x00090502 File Offset: 0x0008E702
		// (set) Token: 0x06000F34 RID: 3892 RVA: 0x0009050C File Offset: 0x0008E70C
		internal virtual TextBox txtName
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06000F35 RID: 3893 RVA: 0x00090515 File Offset: 0x0008E715
		// (set) Token: 0x06000F36 RID: 3894 RVA: 0x0009051F File Offset: 0x0008E71F
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06000F37 RID: 3895 RVA: 0x00090528 File Offset: 0x0008E728
		// (set) Token: 0x06000F38 RID: 3896 RVA: 0x00090532 File Offset: 0x0008E732
		internal virtual DataGridViewTextBoxColumn FullName
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06000F39 RID: 3897 RVA: 0x0009053B File Offset: 0x0008E73B
		// (set) Token: 0x06000F3A RID: 3898 RVA: 0x00090545 File Offset: 0x0008E745
		internal virtual DataGridViewTextBoxColumn Mobile
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06000F3B RID: 3899 RVA: 0x0009054E File Offset: 0x0008E74E
		// (set) Token: 0x06000F3C RID: 3900 RVA: 0x00090558 File Offset: 0x0008E758
		internal virtual DataGridViewTextBoxColumn Ref
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06000F3D RID: 3901 RVA: 0x00090561 File Offset: 0x0008E761
		// (set) Token: 0x06000F3E RID: 3902 RVA: 0x0009056B File Offset: 0x0008E76B
		internal virtual DataGridViewTextBoxColumn Amount
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06000F3F RID: 3903 RVA: 0x00090574 File Offset: 0x0008E774
		// (set) Token: 0x06000F40 RID: 3904 RVA: 0x0009057E File Offset: 0x0008E77E
		internal virtual Label lblactual
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06000F41 RID: 3905 RVA: 0x00090587 File Offset: 0x0008E787
		// (set) Token: 0x06000F42 RID: 3906 RVA: 0x00090591 File Offset: 0x0008E791
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06000F43 RID: 3907 RVA: 0x0009059A File Offset: 0x0008E79A
		// (set) Token: 0x06000F44 RID: 3908 RVA: 0x000905A4 File Offset: 0x0008E7A4
		internal virtual Label lblexpected
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06000F45 RID: 3909 RVA: 0x000905AD File Offset: 0x0008E7AD
		// (set) Token: 0x06000F46 RID: 3910 RVA: 0x000905B7 File Offset: 0x0008E7B7
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06000F47 RID: 3911 RVA: 0x000905C0 File Offset: 0x0008E7C0
		// (set) Token: 0x06000F48 RID: 3912 RVA: 0x000905CC File Offset: 0x0008E7CC
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

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06000F49 RID: 3913 RVA: 0x0009060F File Offset: 0x0008E80F
		// (set) Token: 0x06000F4A RID: 3914 RVA: 0x0009061C File Offset: 0x0008E81C
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

		// Token: 0x06000F4B RID: 3915 RVA: 0x00090660 File Offset: 0x0008E860
		private void EcocashDetails_Load(object sender, EventArgs e)
		{
			try
			{
				this.dgvAmts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.txtName.Text = this.fullcusname;
				this.lblexpected.Text = this.ecoexpected.ToString();
				this.txtName.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x000906EC File Offset: 0x0008E8EC
		private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x00090738 File Offset: 0x0008E938
		private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x00090784 File Offset: 0x0008E984
		private void Append()
		{
			string[] array = new string[]
			{
				this.txtName.Text,
				this.txtMobile.Text,
				this.txtTranCode.Text,
				this.txtAmount.Text,
				DateTime.Today.ToString("yyyyMMdd"),
				DateTime.Now.ToString("HH:mm")
			};
			this.dgvAmts.Rows.Add(array);
			decimal num = 0m;
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvAmts.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					num = decimal.Add(num, Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Amount"].Value)));
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
			bool flag = decimal.Compare(num, Convert.ToDecimal(this.lblexpected.Text)) == 0;
			if (flag)
			{
				DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Amounts match. Submit?", MsgBoxStyle.YesNo, null);
				bool flag2 = dialogResult == DialogResult.Yes;
				if (flag2)
				{
					this.InsertDetails();
					base.Dispose();
				}
				else
				{
					this.txtName.Focus();
				}
			}
			else
			{
				bool flag3 = decimal.Compare(num, Convert.ToDecimal(this.lblexpected.Text)) < 0;
				if (flag3)
				{
					this.txtTranCode.Text = "";
					this.txtAmount.Text = "";
					this.txtTranCode.Focus();
				}
				else
				{
					bool flag4 = decimal.Compare(num, Convert.ToDecimal(this.lblexpected.Text)) > 0;
					if (flag4)
					{
						MessageBox.Show("The amount entered exceeds the expected amount. Retry.");
						this.dgvAmts.Rows.RemoveAt(checked(this.dgvAmts.Rows.Count - 1));
						this.txtAmount.Focus();
					}
				}
			}
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x00090998 File Offset: 0x0008EB98
		private void InsertDetails()
		{
			try
			{
				foreach (object obj in ((IEnumerable)this.dgvAmts.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					string text = dataGridViewRow.Cells["FullName"].Value.ToString();
					string text2 = dataGridViewRow.Cells["Mobile"].Value.ToString();
					string text3 = dataGridViewRow.Cells["Ref"].Value.ToString();
					decimal num = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Amount"].Value));
					this.InsertDetailsOperation(this.invoice_number, text, text2, text3, num);
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
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x00090A88 File Offset: 0x0008EC88
		private void InsertDetailsOperation(int invnumber, string thename, string themobile, string theref, decimal theamt)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "InsertEcocashDetails";
			sqlCommand.Parameters.AddWithValue("InvNum", invnumber);
			sqlCommand.Parameters.AddWithValue("Name", thename);
			sqlCommand.Parameters.AddWithValue("Mobile", themobile);
			sqlCommand.Parameters.AddWithValue("Ref", theref);
			sqlCommand.Parameters.AddWithValue("Amount", theamt);
			sqlCommand.Parameters.AddWithValue("thedate", Convert.ToInt32(DateTime.Today.ToString("yyyyMMdd")));
			sqlCommand.Parameters.AddWithValue("thetime", DateTime.Now.ToString("HH:mm"));
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x00090BAC File Offset: 0x0008EDAC
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.Append();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error appending ecocash details. Detail: " + ex.Message);
			}
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x00090BFC File Offset: 0x0008EDFC
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				decimal num = 0m;
				try
				{
					foreach (object obj in ((IEnumerable)this.dgvAmts.Rows))
					{
						DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
						num = decimal.Add(num, Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Amount"].Value)));
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
				bool flag = decimal.Compare(num, Convert.ToDecimal(this.lblexpected.Text)) == 0;
				if (flag)
				{
					this.InsertDetails();
					base.Dispose();
				}
				else
				{
					bool flag2 = decimal.Compare(num, Convert.ToDecimal(this.lblexpected.Text)) < 0;
					if (flag2)
					{
						MessageBox.Show("Amount entered is less than the expected amount. Rectify.");
						this.txtTranCode.Text = "";
						this.txtAmount.Text = "";
						this.txtTranCode.Focus();
					}
					else
					{
						bool flag3 = decimal.Compare(num, Convert.ToDecimal(this.lblexpected.Text)) > 0;
						if (flag3)
						{
							MessageBox.Show("The amount entered exceeds the expected amount. Retry.");
							this.dgvAmts.Rows.RemoveAt(checked(this.dgvAmts.Rows.Count - 1));
							this.txtAmount.Focus();
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error submitting ecocash transaction. Detail: " + ex.Message);
			}
		}

		// Token: 0x04000752 RID: 1874
		public decimal ecoexpected;

		// Token: 0x04000753 RID: 1875
		public string fullcusname;

		// Token: 0x04000754 RID: 1876
		public int invoice_number;

		// Token: 0x04000755 RID: 1877
		private string _cnn;
	}
}
