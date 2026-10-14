using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using PointOfSale.My.Resources;

namespace PointOfSale
{
	// Token: 0x02000089 RID: 137
	[DesignerGenerated]
	public partial class PaymentMethods : Form
	{
		// Token: 0x06001F59 RID: 8025 RVA: 0x00117D70 File Offset: 0x00115F70
		public PaymentMethods()
		{
			base.Load += this.PaymentMethods_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.dat = new DataTable();
			this.publicfunctions = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17000B78 RID: 2936
		// (get) Token: 0x06001F5C RID: 8028 RVA: 0x001188F4 File Offset: 0x00116AF4
		// (set) Token: 0x06001F5D RID: 8029 RVA: 0x001188FE File Offset: 0x00116AFE
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B79 RID: 2937
		// (get) Token: 0x06001F5E RID: 8030 RVA: 0x00118907 File Offset: 0x00116B07
		// (set) Token: 0x06001F5F RID: 8031 RVA: 0x00118914 File Offset: 0x00116B14
		internal virtual DataGridView DataGridView1
		{
			[CompilerGenerated]
			get
			{
				return this._DataGridView1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(this.DataGridView1_CellValidating);
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(this.DataGridView1_CellEndEdit);
				DataGridView dataGridView = this._DataGridView1;
				if (dataGridView != null)
				{
					dataGridView.CellValidating -= dataGridViewCellValidatingEventHandler;
					dataGridView.CellEndEdit -= dataGridViewCellEventHandler;
				}
				this._DataGridView1 = value;
				dataGridView = this._DataGridView1;
				if (dataGridView != null)
				{
					dataGridView.CellValidating += dataGridViewCellValidatingEventHandler;
					dataGridView.CellEndEdit += dataGridViewCellEventHandler;
				}
			}
		}

		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x06001F60 RID: 8032 RVA: 0x00118972 File Offset: 0x00116B72
		// (set) Token: 0x06001F61 RID: 8033 RVA: 0x0011897C File Offset: 0x00116B7C
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

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x06001F62 RID: 8034 RVA: 0x001189BF File Offset: 0x00116BBF
		// (set) Token: 0x06001F63 RID: 8035 RVA: 0x001189C9 File Offset: 0x00116BC9
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x06001F64 RID: 8036 RVA: 0x001189D2 File Offset: 0x00116BD2
		// (set) Token: 0x06001F65 RID: 8037 RVA: 0x001189DC File Offset: 0x00116BDC
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x06001F66 RID: 8038 RVA: 0x001189E5 File Offset: 0x00116BE5
		// (set) Token: 0x06001F67 RID: 8039 RVA: 0x001189EF File Offset: 0x00116BEF
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06001F68 RID: 8040 RVA: 0x001189F8 File Offset: 0x00116BF8
		// (set) Token: 0x06001F69 RID: 8041 RVA: 0x00118A02 File Offset: 0x00116C02
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B7F RID: 2943
		// (get) Token: 0x06001F6A RID: 8042 RVA: 0x00118A0B File Offset: 0x00116C0B
		// (set) Token: 0x06001F6B RID: 8043 RVA: 0x00118A15 File Offset: 0x00116C15
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B80 RID: 2944
		// (get) Token: 0x06001F6C RID: 8044 RVA: 0x00118A1E File Offset: 0x00116C1E
		// (set) Token: 0x06001F6D RID: 8045 RVA: 0x00118A28 File Offset: 0x00116C28
		internal virtual ComboBox cboChange
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x06001F6E RID: 8046 RVA: 0x00118A31 File Offset: 0x00116C31
		// (set) Token: 0x06001F6F RID: 8047 RVA: 0x00118A3B File Offset: 0x00116C3B
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x06001F70 RID: 8048 RVA: 0x00118A44 File Offset: 0x00116C44
		// (set) Token: 0x06001F71 RID: 8049 RVA: 0x00118A50 File Offset: 0x00116C50
		internal virtual PictureBox PictureBox1
		{
			[CompilerGenerated]
			get
			{
				return this._PictureBox1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.PictureBox1_Click);
				PictureBox pictureBox = this._PictureBox1;
				if (pictureBox != null)
				{
					pictureBox.Click -= eventHandler;
				}
				this._PictureBox1 = value;
				pictureBox = this._PictureBox1;
				if (pictureBox != null)
				{
					pictureBox.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x06001F72 RID: 8050 RVA: 0x00118A93 File Offset: 0x00116C93
		// (set) Token: 0x06001F73 RID: 8051 RVA: 0x00118A9D File Offset: 0x00116C9D
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x06001F74 RID: 8052 RVA: 0x00118AA6 File Offset: 0x00116CA6
		// (set) Token: 0x06001F75 RID: 8053 RVA: 0x00118AB0 File Offset: 0x00116CB0
		internal virtual ComboBox cboDisplayRate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x06001F76 RID: 8054 RVA: 0x00118AB9 File Offset: 0x00116CB9
		// (set) Token: 0x06001F77 RID: 8055 RVA: 0x00118AC3 File Offset: 0x00116CC3
		internal virtual CheckBox chkDisplayRate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x06001F78 RID: 8056 RVA: 0x00118ACC File Offset: 0x00116CCC
		// (set) Token: 0x06001F79 RID: 8057 RVA: 0x00118AD6 File Offset: 0x00116CD6
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06001F7A RID: 8058 RVA: 0x00118AE0 File Offset: 0x00116CE0
		private void LoadMethods()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectPaymentMethods";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(this.dat);
			this.DataGridView1.DataSource = this.dat;
			this.DataGridView1.Columns["PaymentMethodID"].ReadOnly = true;
			this.DataGridView1.Columns["coid"].ReadOnly = true;
			this.DataGridView1.Columns["PaymentMethodID"].DefaultCellStyle.BackColor = Color.Gray;
			this.DataGridView1.Columns["coid"].DefaultCellStyle.BackColor = Color.Gray;
			this.DataGridView1.Columns["PaymentMethodID"].HeaderText = "ID";
			this.DataGridView1.Columns["PaymentMethodDesc"].HeaderText = "Payment Method";
			this.DataGridView1.Columns["Uploaded"].Visible = false;
			this.DataGridView1.Columns["DiscountPerc"].Visible = false;
			this.DataGridView1.Columns["FiscalGroup"].HeaderText = "Fiscal Group";
			this.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		// Token: 0x06001F7B RID: 8059 RVA: 0x00118C88 File Offset: 0x00116E88
		private void loadchangepaymentmethods()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectPaymentMethods";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.cboChange.DataSource = dataTable;
			this.cboChange.ValueMember = "PaymentMethodID";
			this.cboChange.DisplayMember = "PaymentMethodDesc";
			bool flag = Operators.CompareString(MyProject.Forms.Form1.ChangePaymentMethod, "", false) != 0;
			if (flag)
			{
				this.cboChange.SelectedIndex = this.cboChange.FindStringExact(MyProject.Forms.Form1.ChangePaymentMethod);
			}
			else
			{
				this.cboChange.SelectedIndex = -1;
			}
		}

		// Token: 0x06001F7C RID: 8060 RVA: 0x00118D84 File Offset: 0x00116F84
		private void loadchangepaymentmethodsDisplay()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectPaymentMethods";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.cboDisplayRate.DataSource = dataTable;
			this.cboDisplayRate.ValueMember = "PaymentMethodID";
			this.cboDisplayRate.DisplayMember = "PaymentMethodDesc";
			checked
			{
				int num = this.cboDisplayRate.Items.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					DataRowView dataRowView = (DataRowView)this.cboDisplayRate.Items[i];
					int num2 = Conversions.ToInteger(dataRowView["PaymentMethodID"]);
					bool flag = num2 == MyProject.Forms.Form1.ReceiptDisplayPaymentMethod;
					if (flag)
					{
						this.cboDisplayRate.SelectedIndex = i;
						break;
					}
				}
			}
		}

		// Token: 0x06001F7D RID: 8061 RVA: 0x00118EA0 File Offset: 0x001170A0
		private void savechanges()
		{
			try
			{
				foreach (object obj in this.dat.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					dataRow["Uploaded"] = 0;
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
			bool flag = this.dat.Rows.Count > 0;
			if (flag)
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "SelectPaymentMethods";
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
				sqlDataAdapter.Fill(dataTable);
				sqlDataAdapter.Update(this.dat);
			}
			else
			{
				MessageBox.Show("No row to update.");
			}
		}

		// Token: 0x06001F7E RID: 8062 RVA: 0x00118FC0 File Offset: 0x001171C0
		private void PaymentMethods_Load(object sender, EventArgs e)
		{
			try
			{
				base.MaximizeBox = false;
				base.MinimizeBox = false;
				base.StartPosition = FormStartPosition.CenterParent;
				bool isbranch = MyProject.Forms.Form1.isbranch;
				if (isbranch)
				{
					MessageBox.Show("You are logged into a branch and cannot edit Payment Methods from there.");
					base.Dispose();
				}
				this.LoadMethods();
				this.loadchangepaymentmethods();
				this.loadchangepaymentmethodsDisplay();
				bool flag = MyProject.Forms.Form1.UseReceiptDisplay == 1;
				if (flag)
				{
					this.chkDisplayRate.Checked = true;
				}
				else
				{
					this.chkDisplayRate.Checked = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error displaying form. Details: " + ex.Message);
			}
		}

		// Token: 0x06001F7F RID: 8063 RVA: 0x00119090 File Offset: 0x00117290
		private void AddUpdateAppSettings(string key, string value)
		{
			Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			KeyValueConfigurationCollection settings = configuration.AppSettings.Settings;
			bool flag = Information.IsNothing(settings[key]);
			if (flag)
			{
				settings.Add(key, value);
			}
			else
			{
				settings[key].Value = value;
			}
			configuration.Save(ConfigurationSaveMode.Modified);
			ConfigurationManager.RefreshSection(configuration.AppSettings.SectionInformation.Name);
		}

		// Token: 0x06001F80 RID: 8064 RVA: 0x001190FC File Offset: 0x001172FC
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.savechanges();
				bool flag = Operators.CompareString(this.cboChange.Text, "", false) != 0;
				if (flag)
				{
					int num = Conversions.ToInteger(this.cboChange.SelectedValue);
					this.AddUpdateAppSettings("ChangePaymentMethod", this.cboChange.Text);
					MyProject.Forms.Form1.ChangePaymentMethod = this.cboChange.Text;
				}
				bool flag2 = Operators.CompareString(this.cboDisplayRate.Text, "", false) != 0;
				if (flag2)
				{
					int num2 = Conversions.ToInteger(this.cboDisplayRate.SelectedValue);
					this.AddUpdateAppSettings("ReceiptDisplayPaymentMethod", Conversions.ToString(num2));
					MyProject.Forms.Form1.ReceiptDisplayPaymentMethod = num2;
				}
				bool @checked = this.chkDisplayRate.Checked;
				if (@checked)
				{
					this.AddUpdateAppSettings("UseReceiptDisplay", Conversions.ToString(1));
					MyProject.Forms.Form1.UseReceiptDisplay = 1;
				}
				else
				{
					this.AddUpdateAppSettings("UseReceiptDisplay", Conversions.ToString(0));
					MyProject.Forms.Form1.UseReceiptDisplay = 0;
				}
				this.publicfunctions.loadmultipaymeths(this._cnn);
				MessageBox.Show("Changes saved succesfully.");
			}
			catch (SqlException ex)
			{
				bool flag3 = ex.Number == 2627;
				if (flag3)
				{
					MessageBox.Show("Please enter different payment method. Already entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show("Error updating data. Retry. Detailed error: " + ex2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06001F81 RID: 8065 RVA: 0x001192DC File Offset: 0x001174DC
		private void PictureBox1_Click(object sender, EventArgs e)
		{
			try
			{
				this.loadchangepaymentmethods();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading change payment methods.");
			}
		}

		// Token: 0x06001F82 RID: 8066 RVA: 0x00119320 File Offset: 0x00117520
		private void DataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			try
			{
				this.DataGridView1.Rows[e.RowIndex].ErrorText = "";
				bool flag = Operators.CompareString(this.DataGridView1.Columns[e.ColumnIndex].Name, "rate", false) == 0;
				if (flag)
				{
					bool isNewRow = this.DataGridView1.Rows[e.RowIndex].IsNewRow;
					if (!isNewRow)
					{
						decimal num;
						bool flag2 = !decimal.TryParse(e.FormattedValue.ToString(), out num) || decimal.Compare(num, 0m) < 0;
						if (flag2)
						{
							e.Cancel = true;
							this.DataGridView1.Rows[e.RowIndex].ErrorText = "the value must be a non-negative decimal";
						}
					}
				}
				else
				{
					bool flag3 = Operators.CompareString(this.DataGridView1.Columns[e.ColumnIndex].Name, "CurrencyEltradeID", false) == 0;
					if (flag3)
					{
						bool isNewRow2 = this.DataGridView1.Rows[e.RowIndex].IsNewRow;
						if (!isNewRow2)
						{
							int num2;
							bool flag4 = !int.TryParse(e.FormattedValue.ToString(), out num2) || num2 < 0;
							if (flag4)
							{
								e.Cancel = true;
								this.DataGridView1.Rows[e.RowIndex].ErrorText = "the value must be a non-negative integer";
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001F83 RID: 8067 RVA: 0x001194D0 File Offset: 0x001176D0
		private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				DataGridView dataGridView = (DataGridView)sender;
				dataGridView.Rows[e.RowIndex].Cells["coid"].Value = MyProject.Forms.Form1.coid;
				dataGridView.Rows[e.RowIndex].Cells["uploaded"].Value = 0;
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x04000EF6 RID: 3830
		private string _cnn;

		// Token: 0x04000EF7 RID: 3831
		private DataTable dat;

		// Token: 0x04000EF8 RID: 3832
		private PublicFunctions publicfunctions;
	}
}
