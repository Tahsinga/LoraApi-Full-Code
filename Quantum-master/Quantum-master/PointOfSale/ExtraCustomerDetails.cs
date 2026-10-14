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
	// Token: 0x0200005A RID: 90
	[DesignerGenerated]
	public partial class ExtraCustomerDetails : Form
	{
		// Token: 0x060012B1 RID: 4785 RVA: 0x000B326C File Offset: 0x000B146C
		public ExtraCustomerDetails()
		{
			base.Load += this.ExtraCustomerDetails_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.currCusGroup = "";
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x060012B4 RID: 4788 RVA: 0x000B4783 File Offset: 0x000B2983
		// (set) Token: 0x060012B5 RID: 4789 RVA: 0x000B478D File Offset: 0x000B298D
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x060012B6 RID: 4790 RVA: 0x000B4796 File Offset: 0x000B2996
		// (set) Token: 0x060012B7 RID: 4791 RVA: 0x000B47A0 File Offset: 0x000B29A0
		internal virtual TextBox txttel
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x060012B8 RID: 4792 RVA: 0x000B47A9 File Offset: 0x000B29A9
		// (set) Token: 0x060012B9 RID: 4793 RVA: 0x000B47B3 File Offset: 0x000B29B3
		internal virtual TextBox txtEmail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x060012BA RID: 4794 RVA: 0x000B47BC File Offset: 0x000B29BC
		// (set) Token: 0x060012BB RID: 4795 RVA: 0x000B47C6 File Offset: 0x000B29C6
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x060012BC RID: 4796 RVA: 0x000B47CF File Offset: 0x000B29CF
		// (set) Token: 0x060012BD RID: 4797 RVA: 0x000B47DC File Offset: 0x000B29DC
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

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x060012BE RID: 4798 RVA: 0x000B481F File Offset: 0x000B2A1F
		// (set) Token: 0x060012BF RID: 4799 RVA: 0x000B4829 File Offset: 0x000B2A29
		internal virtual TextBox txtcustomername
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x060012C0 RID: 4800 RVA: 0x000B4832 File Offset: 0x000B2A32
		// (set) Token: 0x060012C1 RID: 4801 RVA: 0x000B483C File Offset: 0x000B2A3C
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x060012C2 RID: 4802 RVA: 0x000B4845 File Offset: 0x000B2A45
		// (set) Token: 0x060012C3 RID: 4803 RVA: 0x000B484F File Offset: 0x000B2A4F
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x060012C4 RID: 4804 RVA: 0x000B4858 File Offset: 0x000B2A58
		// (set) Token: 0x060012C5 RID: 4805 RVA: 0x000B4862 File Offset: 0x000B2A62
		internal virtual ComboBox cboCustomerGroups
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x060012C6 RID: 4806 RVA: 0x000B486B File Offset: 0x000B2A6B
		// (set) Token: 0x060012C7 RID: 4807 RVA: 0x000B4878 File Offset: 0x000B2A78
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

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x060012C8 RID: 4808 RVA: 0x000B48BB File Offset: 0x000B2ABB
		// (set) Token: 0x060012C9 RID: 4809 RVA: 0x000B48C5 File Offset: 0x000B2AC5
		internal virtual TextBox txtAddress
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x060012CA RID: 4810 RVA: 0x000B48CE File Offset: 0x000B2ACE
		// (set) Token: 0x060012CB RID: 4811 RVA: 0x000B48D8 File Offset: 0x000B2AD8
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x060012CC RID: 4812 RVA: 0x000B48E1 File Offset: 0x000B2AE1
		// (set) Token: 0x060012CD RID: 4813 RVA: 0x000B48EB File Offset: 0x000B2AEB
		internal virtual TextBox txtInvDetails1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x060012CE RID: 4814 RVA: 0x000B48F4 File Offset: 0x000B2AF4
		// (set) Token: 0x060012CF RID: 4815 RVA: 0x000B48FE File Offset: 0x000B2AFE
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006D6 RID: 1750
		// (get) Token: 0x060012D0 RID: 4816 RVA: 0x000B4907 File Offset: 0x000B2B07
		// (set) Token: 0x060012D1 RID: 4817 RVA: 0x000B4911 File Offset: 0x000B2B11
		internal virtual TextBox txtInvDetails2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x060012D2 RID: 4818 RVA: 0x000B491A File Offset: 0x000B2B1A
		// (set) Token: 0x060012D3 RID: 4819 RVA: 0x000B4924 File Offset: 0x000B2B24
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x060012D4 RID: 4820 RVA: 0x000B492D File Offset: 0x000B2B2D
		// (set) Token: 0x060012D5 RID: 4821 RVA: 0x000B4937 File Offset: 0x000B2B37
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x060012D6 RID: 4822 RVA: 0x000B4940 File Offset: 0x000B2B40
		// (set) Token: 0x060012D7 RID: 4823 RVA: 0x000B494A File Offset: 0x000B2B4A
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x060012D8 RID: 4824 RVA: 0x000B4953 File Offset: 0x000B2B53
		// (set) Token: 0x060012D9 RID: 4825 RVA: 0x000B495D File Offset: 0x000B2B5D
		internal virtual TextBox txtBPNum
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x060012DA RID: 4826 RVA: 0x000B4966 File Offset: 0x000B2B66
		// (set) Token: 0x060012DB RID: 4827 RVA: 0x000B4970 File Offset: 0x000B2B70
		internal virtual Label lblbpnum
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x060012DC RID: 4828 RVA: 0x000B4979 File Offset: 0x000B2B79
		// (set) Token: 0x060012DD RID: 4829 RVA: 0x000B4983 File Offset: 0x000B2B83
		internal virtual TextBox txtVATNum
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x060012DE RID: 4830 RVA: 0x000B498C File Offset: 0x000B2B8C
		// (set) Token: 0x060012DF RID: 4831 RVA: 0x000B4996 File Offset: 0x000B2B96
		internal virtual Label lblvatnum
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x060012E0 RID: 4832 RVA: 0x000B499F File Offset: 0x000B2B9F
		// (set) Token: 0x060012E1 RID: 4833 RVA: 0x000B49A9 File Offset: 0x000B2BA9
		internal virtual TextBox txtContact
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x060012E2 RID: 4834 RVA: 0x000B49B2 File Offset: 0x000B2BB2
		// (set) Token: 0x060012E3 RID: 4835 RVA: 0x000B49BC File Offset: 0x000B2BBC
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x060012E4 RID: 4836 RVA: 0x000B49C5 File Offset: 0x000B2BC5
		// (set) Token: 0x060012E5 RID: 4837 RVA: 0x000B49CF File Offset: 0x000B2BCF
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x060012E6 RID: 4838 RVA: 0x000B49D8 File Offset: 0x000B2BD8
		// (set) Token: 0x060012E7 RID: 4839 RVA: 0x000B49E2 File Offset: 0x000B2BE2
		internal virtual ComboBox cboProvince
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x060012E8 RID: 4840 RVA: 0x000B49EB File Offset: 0x000B2BEB
		// (set) Token: 0x060012E9 RID: 4841 RVA: 0x000B49F5 File Offset: 0x000B2BF5
		internal virtual TextBox txtStreetNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x060012EA RID: 4842 RVA: 0x000B49FE File Offset: 0x000B2BFE
		// (set) Token: 0x060012EB RID: 4843 RVA: 0x000B4A08 File Offset: 0x000B2C08
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x060012EC RID: 4844 RVA: 0x000B4A11 File Offset: 0x000B2C11
		// (set) Token: 0x060012ED RID: 4845 RVA: 0x000B4A1B File Offset: 0x000B2C1B
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x060012EE RID: 4846 RVA: 0x000B4A24 File Offset: 0x000B2C24
		// (set) Token: 0x060012EF RID: 4847 RVA: 0x000B4A2E File Offset: 0x000B2C2E
		internal virtual ComboBox cboCity
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x060012F0 RID: 4848 RVA: 0x000B4A37 File Offset: 0x000B2C37
		// (set) Token: 0x060012F1 RID: 4849 RVA: 0x000B4A41 File Offset: 0x000B2C41
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x060012F2 RID: 4850 RVA: 0x000B4A4A File Offset: 0x000B2C4A
		// (set) Token: 0x060012F3 RID: 4851 RVA: 0x000B4A54 File Offset: 0x000B2C54
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x060012F4 RID: 4852 RVA: 0x000B4A5D File Offset: 0x000B2C5D
		// (set) Token: 0x060012F5 RID: 4853 RVA: 0x000B4A67 File Offset: 0x000B2C67
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060012F6 RID: 4854 RVA: 0x000B4A70 File Offset: 0x000B2C70
		private void ExtraCustomerDetails_Load(object sender, EventArgs e)
		{
			try
			{
				base.MaximizeBox = false;
				this.setBPName();
				this.LoadCustomerGroups();
				this.cboCity.DataSource = this.pf.GetZimCities(MyProject.Forms.Form1.Constring);
				this.cboCity.DisplayMember = "City";
				this.cboCity.ValueMember = "City";
				DataTable customerDetails = this.pf.GetCustomerDetails(this._cnn, this.txtcustomername.Text, MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch);
				bool flag = customerDetails.Rows.Count > 0;
				if (flag)
				{
					DataRow dataRow = customerDetails.Rows[0];
					this.txtEmail.Text = Conversions.ToString(dataRow["Email"]);
					this.txtAddress.Text = Conversions.ToString(dataRow["Address"]);
					this.txtInvDetails1.Text = Conversions.ToString(dataRow["InvoiceDetails1"]);
					this.txtInvDetails2.Text = Conversions.ToString(dataRow["InvoiceDetails2"]);
					this.txttel.Text = Conversions.ToString(dataRow["Mobile"]);
					this.txtBPNum.Text = dataRow["BPNumber"].ToString();
					this.txtVATNum.Text = dataRow["VATNumber"].ToString();
					this.txtContact.Text = dataRow["ContactName"].ToString();
					this.cboProvince.Text = dataRow["Province"].ToString();
					this.cboCity.SelectedIndex = this.cboCity.FindStringExact(dataRow["City"].ToString());
					this.txtStreetNumber.Text = dataRow["StreetNumber"].ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail:  " + ex.Message);
			}
		}

		// Token: 0x060012F7 RID: 4855 RVA: 0x000B4CC0 File Offset: 0x000B2EC0
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.cboCustomerGroups.SelectedValue == null;
				if (flag)
				{
					MessageBox.Show("Please select a customer group first.");
				}
				else
				{
					bool flag2 = (Operators.CompareString(this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "LeafbrightA4", MyProject.Forms.Form1.Constring), "1", false) == 0) | (Operators.CompareString(this.pf.AdditionalSettings2Check(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, "Leafbright80", MyProject.Forms.Form1.Constring), "1", false) == 0);
					if (flag2)
					{
						bool flag3 = Operators.CompareString(this.txtStreetNumber.Text, "", false) == 0;
						if (flag3)
						{
							MessageBox.Show("Please enter the Street Number.");
							return;
						}
						bool flag4 = Operators.CompareString(this.txtAddress.Text, "", false) == 0;
						if (flag4)
						{
							MessageBox.Show("Please enter the Address.");
							return;
						}
						bool flag5 = Operators.CompareString(this.cboCity.Text, "", false) == 0;
						if (flag5)
						{
							MessageBox.Show("Please select or type a City name.");
							return;
						}
						bool flag6 = Operators.CompareString(this.cboProvince.Text, "", false) == 0;
						if (flag6)
						{
							MessageBox.Show("Please select or type the Province name.");
							return;
						}
					}
					SqlConnection sqlConnection = new SqlConnection(this._cnn);
					SqlCommand sqlCommand = sqlConnection.CreateCommand();
					sqlCommand.CommandType = CommandType.Text;
					sqlCommand.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("update CustomerDetails set customergroupid=", this.cboCustomerGroups.SelectedValue), ", Mobile='"), this.txttel.Text), "', Email='"), this.txtEmail.Text), "', InvoiceDetails1='"), this.txtInvDetails1.Text), "', InvoiceDetails2='"), this.txtInvDetails2.Text), "', [Address]='"), this.txtAddress.Text), "', BPNumber= '"), this.txtBPNum.Text), "', vatnumber='"), this.txtVATNum.Text), "',contactname='"), this.txtContact.Text), "', province='"), this.cboProvince.Text), "'"), ", streetnumber='"), this.txtStreetNumber.Text), "', city='"), this.cboCity.Text), "' where coid="), MyProject.Forms.Form1.coid), " and customername='"), this.txtcustomername.Text), "' "));
					using (sqlConnection)
					{
						sqlConnection.Open();
						sqlCommand.ExecuteNonQuery();
						sqlConnection.Close();
					}
					MessageBox.Show("Customer Details updated.");
					base.DialogResult = DialogResult.OK;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error updating customer details. Desc: " + ex.Message);
			}
		}

		// Token: 0x060012F8 RID: 4856 RVA: 0x000B5098 File Offset: 0x000B3298
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				CustomerGroups customerGroups = new CustomerGroups();
				customerGroups.ShowDialog(this);
				customerGroups.Dispose();
				this.LoadCustomerGroups();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading Expenses Categories form. Detail: " + ex.Message);
			}
		}

		// Token: 0x060012F9 RID: 4857 RVA: 0x000B50FC File Offset: 0x000B32FC
		private void LoadCustomerGroups()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "Select * from CustomerCategoryNames where coid=" + Conversions.ToString(MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			int num = sqlDataAdapter.Fill(dataTable);
			this.cboCustomerGroups.DataSource = dataTable;
			this.cboCustomerGroups.ValueMember = "ID";
			this.cboCustomerGroups.DisplayMember = "CategoryName";
			bool flag = num > 1;
			if (flag)
			{
				this.cboCustomerGroups.SelectedIndex = -1;
			}
		}

		// Token: 0x060012FA RID: 4858 RVA: 0x000B51AC File Offset: 0x000B33AC
		private void setBPName()
		{
			DataTable branchDetails = this.pf.GetBranchDetails(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, MyProject.Forms.Form1.Constring);
			DataRow dataRow = branchDetails.Rows[0];
			this.lblbpnum.Text = dataRow["BPNumber_name"].ToString();
			this.lblvatnum.Text = dataRow["VATNumber_name"].ToString();
		}

		// Token: 0x040008E4 RID: 2276
		private string _cnn;

		// Token: 0x040008E5 RID: 2277
		public string currCusGroup;

		// Token: 0x040008E6 RID: 2278
		private PublicFunctions pf;
	}
}
