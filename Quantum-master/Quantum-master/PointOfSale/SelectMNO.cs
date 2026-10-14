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
	// Token: 0x020001BA RID: 442
	[DesignerGenerated]
	public partial class SelectMNO : Form
	{
		// Token: 0x06004FE9 RID: 20457 RVA: 0x002FBAA4 File Offset: 0x002F9CA4
		public SelectMNO()
		{
			base.Load += this.SelectMNO_Load;
			this.netone_etopup = new eTopUp();
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pfunctions = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17001D5A RID: 7514
		// (get) Token: 0x06004FEC RID: 20460 RVA: 0x002FC49F File Offset: 0x002FA69F
		// (set) Token: 0x06004FED RID: 20461 RVA: 0x002FC4A9 File Offset: 0x002FA6A9
		internal virtual TabControl TabControl1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D5B RID: 7515
		// (get) Token: 0x06004FEE RID: 20462 RVA: 0x002FC4B2 File Offset: 0x002FA6B2
		// (set) Token: 0x06004FEF RID: 20463 RVA: 0x002FC4BC File Offset: 0x002FA6BC
		internal virtual TabPage TabPage1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D5C RID: 7516
		// (get) Token: 0x06004FF0 RID: 20464 RVA: 0x002FC4C5 File Offset: 0x002FA6C5
		// (set) Token: 0x06004FF1 RID: 20465 RVA: 0x002FC4CF File Offset: 0x002FA6CF
		internal virtual Button Button3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D5D RID: 7517
		// (get) Token: 0x06004FF2 RID: 20466 RVA: 0x002FC4D8 File Offset: 0x002FA6D8
		// (set) Token: 0x06004FF3 RID: 20467 RVA: 0x002FC4E2 File Offset: 0x002FA6E2
		internal virtual Button Button2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D5E RID: 7518
		// (get) Token: 0x06004FF4 RID: 20468 RVA: 0x002FC4EB File Offset: 0x002FA6EB
		// (set) Token: 0x06004FF5 RID: 20469 RVA: 0x002FC4F8 File Offset: 0x002FA6F8
		internal virtual Button cmdNetone
		{
			[CompilerGenerated]
			get
			{
				return this._cmdNetone;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button1_Click);
				Button button = this._cmdNetone;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._cmdNetone = value;
				button = this._cmdNetone;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001D5F RID: 7519
		// (get) Token: 0x06004FF6 RID: 20470 RVA: 0x002FC53B File Offset: 0x002FA73B
		// (set) Token: 0x06004FF7 RID: 20471 RVA: 0x002FC545 File Offset: 0x002FA745
		internal virtual TabPage TabPage2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D60 RID: 7520
		// (get) Token: 0x06004FF8 RID: 20472 RVA: 0x002FC54E File Offset: 0x002FA74E
		// (set) Token: 0x06004FF9 RID: 20473 RVA: 0x002FC558 File Offset: 0x002FA758
		internal virtual TabPage TabPage3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D61 RID: 7521
		// (get) Token: 0x06004FFA RID: 20474 RVA: 0x002FC561 File Offset: 0x002FA761
		// (set) Token: 0x06004FFB RID: 20475 RVA: 0x002FC56B File Offset: 0x002FA76B
		internal virtual TabPage TabPage4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D62 RID: 7522
		// (get) Token: 0x06004FFC RID: 20476 RVA: 0x002FC574 File Offset: 0x002FA774
		// (set) Token: 0x06004FFD RID: 20477 RVA: 0x002FC57E File Offset: 0x002FA77E
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D63 RID: 7523
		// (get) Token: 0x06004FFE RID: 20478 RVA: 0x002FC587 File Offset: 0x002FA787
		// (set) Token: 0x06004FFF RID: 20479 RVA: 0x002FC594 File Offset: 0x002FA794
		internal virtual TextBox txtNetoneAirtime
		{
			[CompilerGenerated]
			get
			{
				return this._txtNetoneAirtime;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtNetoneAirtime_KeyPress);
				TextBox textBox = this._txtNetoneAirtime;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtNetoneAirtime = value;
				textBox = this._txtNetoneAirtime;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x17001D64 RID: 7524
		// (get) Token: 0x06005000 RID: 20480 RVA: 0x002FC5D7 File Offset: 0x002FA7D7
		// (set) Token: 0x06005001 RID: 20481 RVA: 0x002FC5E4 File Offset: 0x002FA7E4
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
				EventHandler eventHandler = new EventHandler(this.Button1_Click_1);
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

		// Token: 0x17001D65 RID: 7525
		// (get) Token: 0x06005002 RID: 20482 RVA: 0x002FC627 File Offset: 0x002FA827
		// (set) Token: 0x06005003 RID: 20483 RVA: 0x002FC631 File Offset: 0x002FA831
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D66 RID: 7526
		// (get) Token: 0x06005004 RID: 20484 RVA: 0x002FC63A File Offset: 0x002FA83A
		// (set) Token: 0x06005005 RID: 20485 RVA: 0x002FC644 File Offset: 0x002FA844
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005006 RID: 20486 RVA: 0x002FC650 File Offset: 0x002FA850
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.TabControl1.SelectedTab = this.TabPage1;
				this.netone_agent_balance = Convert.ToDecimal(this.netone_etopup.GetWalletBalance(this.netone_url, this.netone_walletBalRes, this.netone_username, this.netone_pwd, this.netone_etopup.GetNextAgentRefNumber(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch)));
				this.txtNetoneAirtime.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error occurred. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005007 RID: 20487 RVA: 0x002FC70C File Offset: 0x002FA90C
		private void SelectMNO_Load(object sender, EventArgs e)
		{
			try
			{
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error occurred. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005008 RID: 20488 RVA: 0x002FC754 File Offset: 0x002FA954
		private void LoadNetoneDetails()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "NetoneGetURLDetails";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			this.netone_url = Conversions.ToString(dataRow["NetoneURL"]);
			this.netone_username = Conversions.ToString(dataRow["Username"]);
			this.netone_pwd = Conversions.ToString(dataRow["AgentPwd"]);
			this.netone_pinlessRechargeRes = Conversions.ToString(dataRow["PinlessRechargeRes"]);
			this.netone_walletBalRes = Conversions.ToString(dataRow["WalletBalanceRes"]);
			this.netone_userBalRes = Conversions.ToString(dataRow["UserBalanceRes"]);
			this.netone_querytranRes = Conversions.ToString(dataRow["QueryTranRes"]);
		}

		// Token: 0x06005009 RID: 20489 RVA: 0x002FC894 File Offset: 0x002FAA94
		private void txtNetoneAirtime_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
			}
			catch (Exception ex)
			{
				MessageBox.Show("Enter key press error, detail: " + ex.Message);
			}
		}

		// Token: 0x0600500A RID: 20490 RVA: 0x002FC8DC File Offset: 0x002FAADC
		private void ProcessNetoneAirtime()
		{
			bool flag = decimal.Compare(this.netone_agent_balance, new decimal(Convert.ToInt32(this.txtNetoneAirtime.Text))) > 0;
			if (flag)
			{
				DataTable productDetailsByBarCode = this.pfunctions.GetProductDetailsByBarCode("NETONE", MyProject.Forms.Form1.Constring);
				DataRow dataRow = productDetailsByBarCode.Rows[0];
				decimal num = Conversions.ToDecimal(dataRow["TaxRate"]);
				decimal num2 = decimal.Multiply(Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["Cost"])), decimal.Divide(num, 100m));
			}
			else
			{
				MessageBox.Show("Insufficient agent balance for transaction. Agent Balance is: " + this.netone_agent_balance.ToString());
			}
		}

		// Token: 0x0600500B RID: 20491 RVA: 0x00002A30 File Offset: 0x00000C30
		private void Button1_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x040023B3 RID: 9139
		private decimal netone_agent_balance;

		// Token: 0x040023B4 RID: 9140
		private eTopUp netone_etopup;

		// Token: 0x040023B5 RID: 9141
		private string _cnn;

		// Token: 0x040023B6 RID: 9142
		private string netone_url;

		// Token: 0x040023B7 RID: 9143
		private string netone_username;

		// Token: 0x040023B8 RID: 9144
		private string netone_pwd;

		// Token: 0x040023B9 RID: 9145
		private string netone_walletBalRes;

		// Token: 0x040023BA RID: 9146
		private string netone_userBalRes;

		// Token: 0x040023BB RID: 9147
		private string netone_pinlessRechargeRes;

		// Token: 0x040023BC RID: 9148
		private string netone_querytranRes;

		// Token: 0x040023BD RID: 9149
		private PublicFunctions pfunctions;
	}
}
