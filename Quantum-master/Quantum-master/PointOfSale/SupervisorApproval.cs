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
using PointOfSale.My.Resources;

namespace PointOfSale
{
	// Token: 0x020001FA RID: 506
	[DesignerGenerated]
	public partial class SupervisorApproval : Form
	{
		// Token: 0x06005A9D RID: 23197 RVA: 0x00344190 File Offset: 0x00342390
		public SupervisorApproval()
		{
			base.Load += this.SupervisorApproval_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.prod_desc = "";
			this.publicfunction = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x1700209F RID: 8351
		// (get) Token: 0x06005AA0 RID: 23200 RVA: 0x003453E1 File Offset: 0x003435E1
		// (set) Token: 0x06005AA1 RID: 23201 RVA: 0x003453EB File Offset: 0x003435EB
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020A0 RID: 8352
		// (get) Token: 0x06005AA2 RID: 23202 RVA: 0x003453F4 File Offset: 0x003435F4
		// (set) Token: 0x06005AA3 RID: 23203 RVA: 0x003453FE File Offset: 0x003435FE
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020A1 RID: 8353
		// (get) Token: 0x06005AA4 RID: 23204 RVA: 0x00345407 File Offset: 0x00343607
		// (set) Token: 0x06005AA5 RID: 23205 RVA: 0x00345411 File Offset: 0x00343611
		internal virtual TextBox txtPassword
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020A2 RID: 8354
		// (get) Token: 0x06005AA6 RID: 23206 RVA: 0x0034541A File Offset: 0x0034361A
		// (set) Token: 0x06005AA7 RID: 23207 RVA: 0x00345424 File Offset: 0x00343624
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020A3 RID: 8355
		// (get) Token: 0x06005AA8 RID: 23208 RVA: 0x0034542D File Offset: 0x0034362D
		// (set) Token: 0x06005AA9 RID: 23209 RVA: 0x00345438 File Offset: 0x00343638
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

		// Token: 0x170020A4 RID: 8356
		// (get) Token: 0x06005AAA RID: 23210 RVA: 0x0034547B File Offset: 0x0034367B
		// (set) Token: 0x06005AAB RID: 23211 RVA: 0x00345488 File Offset: 0x00343688
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

		// Token: 0x170020A5 RID: 8357
		// (get) Token: 0x06005AAC RID: 23212 RVA: 0x003454CB File Offset: 0x003436CB
		// (set) Token: 0x06005AAD RID: 23213 RVA: 0x003454D5 File Offset: 0x003436D5
		internal virtual ComboBox cboDiscount
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020A6 RID: 8358
		// (get) Token: 0x06005AAE RID: 23214 RVA: 0x003454DE File Offset: 0x003436DE
		// (set) Token: 0x06005AAF RID: 23215 RVA: 0x003454E8 File Offset: 0x003436E8
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020A7 RID: 8359
		// (get) Token: 0x06005AB0 RID: 23216 RVA: 0x003454F1 File Offset: 0x003436F1
		// (set) Token: 0x06005AB1 RID: 23217 RVA: 0x003454FC File Offset: 0x003436FC
		internal virtual CheckBox chkLimitPayMethods
		{
			[CompilerGenerated]
			get
			{
				return this._chkLimitPayMethods;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkLimitPayMethods_CheckedChanged);
				CheckBox checkBox = this._chkLimitPayMethods;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkLimitPayMethods = value;
				checkBox = this._chkLimitPayMethods;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170020A8 RID: 8360
		// (get) Token: 0x06005AB2 RID: 23218 RVA: 0x0034553F File Offset: 0x0034373F
		// (set) Token: 0x06005AB3 RID: 23219 RVA: 0x00345549 File Offset: 0x00343749
		internal virtual ComboBox cboPayMethods
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020A9 RID: 8361
		// (get) Token: 0x06005AB4 RID: 23220 RVA: 0x00345552 File Offset: 0x00343752
		// (set) Token: 0x06005AB5 RID: 23221 RVA: 0x0034555C File Offset: 0x0034375C
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020AA RID: 8362
		// (get) Token: 0x06005AB6 RID: 23222 RVA: 0x00345565 File Offset: 0x00343765
		// (set) Token: 0x06005AB7 RID: 23223 RVA: 0x0034556F File Offset: 0x0034376F
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020AB RID: 8363
		// (get) Token: 0x06005AB8 RID: 23224 RVA: 0x00345578 File Offset: 0x00343778
		// (set) Token: 0x06005AB9 RID: 23225 RVA: 0x00345584 File Offset: 0x00343784
		internal virtual TextBox txtDiscAmount
		{
			[CompilerGenerated]
			get
			{
				return this._txtDiscAmount;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				KeyPressEventHandler keyPressEventHandler = new KeyPressEventHandler(this.txtDiscAmount_KeyPress);
				TextBox textBox = this._txtDiscAmount;
				if (textBox != null)
				{
					textBox.KeyPress -= keyPressEventHandler;
				}
				this._txtDiscAmount = value;
				textBox = this._txtDiscAmount;
				if (textBox != null)
				{
					textBox.KeyPress += keyPressEventHandler;
				}
			}
		}

		// Token: 0x170020AC RID: 8364
		// (get) Token: 0x06005ABA RID: 23226 RVA: 0x003455C7 File Offset: 0x003437C7
		// (set) Token: 0x06005ABB RID: 23227 RVA: 0x003455D4 File Offset: 0x003437D4
		internal virtual CheckBox chkPerc
		{
			[CompilerGenerated]
			get
			{
				return this._chkPerc;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.chkPerc_CheckedChanged);
				CheckBox checkBox = this._chkPerc;
				if (checkBox != null)
				{
					checkBox.CheckedChanged -= eventHandler;
				}
				this._chkPerc = value;
				checkBox = this._chkPerc;
				if (checkBox != null)
				{
					checkBox.CheckedChanged += eventHandler;
				}
			}
		}

		// Token: 0x170020AD RID: 8365
		// (get) Token: 0x06005ABC RID: 23228 RVA: 0x00345617 File Offset: 0x00343817
		// (set) Token: 0x06005ABD RID: 23229 RVA: 0x00345624 File Offset: 0x00343824
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

		// Token: 0x170020AE RID: 8366
		// (get) Token: 0x06005ABE RID: 23230 RVA: 0x00345667 File Offset: 0x00343867
		// (set) Token: 0x06005ABF RID: 23231 RVA: 0x00345671 File Offset: 0x00343871
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020AF RID: 8367
		// (get) Token: 0x06005AC0 RID: 23232 RVA: 0x0034567A File Offset: 0x0034387A
		// (set) Token: 0x06005AC1 RID: 23233 RVA: 0x00345684 File Offset: 0x00343884
		internal virtual Label lblSelling
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020B0 RID: 8368
		// (get) Token: 0x06005AC2 RID: 23234 RVA: 0x0034568D File Offset: 0x0034388D
		// (set) Token: 0x06005AC3 RID: 23235 RVA: 0x00345698 File Offset: 0x00343898
		internal virtual Label lblCost
		{
			[CompilerGenerated]
			get
			{
				return this._lblCost;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.lblCost_Click);
				Label label = this._lblCost;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._lblCost = value;
				label = this._lblCost;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x170020B1 RID: 8369
		// (get) Token: 0x06005AC4 RID: 23236 RVA: 0x003456DB File Offset: 0x003438DB
		// (set) Token: 0x06005AC5 RID: 23237 RVA: 0x003456E5 File Offset: 0x003438E5
		internal virtual Label lblProduct
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020B2 RID: 8370
		// (get) Token: 0x06005AC6 RID: 23238 RVA: 0x003456EE File Offset: 0x003438EE
		// (set) Token: 0x06005AC7 RID: 23239 RVA: 0x003456F8 File Offset: 0x003438F8
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020B3 RID: 8371
		// (get) Token: 0x06005AC8 RID: 23240 RVA: 0x00345701 File Offset: 0x00343901
		// (set) Token: 0x06005AC9 RID: 23241 RVA: 0x0034570B File Offset: 0x0034390B
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020B4 RID: 8372
		// (get) Token: 0x06005ACA RID: 23242 RVA: 0x00345714 File Offset: 0x00343914
		// (set) Token: 0x06005ACB RID: 23243 RVA: 0x0034571E File Offset: 0x0034391E
		internal virtual Panel Panel1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020B5 RID: 8373
		// (get) Token: 0x06005ACC RID: 23244 RVA: 0x00345727 File Offset: 0x00343927
		// (set) Token: 0x06005ACD RID: 23245 RVA: 0x00345731 File Offset: 0x00343931
		internal virtual RadioButton radIncrease
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020B6 RID: 8374
		// (get) Token: 0x06005ACE RID: 23246 RVA: 0x0034573A File Offset: 0x0034393A
		// (set) Token: 0x06005ACF RID: 23247 RVA: 0x00345744 File Offset: 0x00343944
		internal virtual RadioButton radReduce
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x170020B7 RID: 8375
		// (get) Token: 0x06005AD0 RID: 23248 RVA: 0x0034574D File Offset: 0x0034394D
		// (set) Token: 0x06005AD1 RID: 23249 RVA: 0x00345758 File Offset: 0x00343958
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

		// Token: 0x170020B8 RID: 8376
		// (get) Token: 0x06005AD2 RID: 23250 RVA: 0x0034579B File Offset: 0x0034399B
		// (set) Token: 0x06005AD3 RID: 23251 RVA: 0x003457A5 File Offset: 0x003439A5
		internal virtual ComboBox cboUsername
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06005AD4 RID: 23252 RVA: 0x003457B0 File Offset: 0x003439B0
		private void SupervisorApproval_Load(object sender, EventArgs e)
		{
			try
			{
				this.cboUsername.DataSource = this.publicfunction.GetUsers(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.Constring);
				this.cboUsername.ValueMember = "Username";
				this.cboUsername.DisplayMember = "Username";
				this.lblProduct.Text = this.prod_desc;
				this.lblCost.Text = this.prod_cost.ToString();
				this.lblSelling.Text = this.prod_selling.ToString();
				base.MaximizeBox = false;
				this.cboDiscount.DataSource = this.pf.GetInvDiscountPerc(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.branch, this._cnn);
				this.cboDiscount.DisplayMember = "DiscountPercentage";
				this.cboDiscount.ValueMember = "DiscountPercentage";
				this.cboDiscount.SelectedIndex = -1;
				this.LoadPayMethods();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005AD5 RID: 23253 RVA: 0x00345914 File Offset: 0x00343B14
		private void LoadPayMethods()
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectPaymentMethods";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			this.cboPayMethods.DataSource = dataTable;
			this.cboPayMethods.DisplayMember = "PaymentMethodDesc";
			this.cboPayMethods.ValueMember = "PaymentMethodID";
		}

		// Token: 0x06005AD6 RID: 23254 RVA: 0x003459B4 File Offset: 0x00343BB4
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = (this.chkPerc.Checked & (Conversion.Val(this.cboDiscount.Text) != 0.0)) | (!this.chkPerc.Checked & (Conversion.Val(this.txtDiscAmount.Text) != 0.0));
				if (flag)
				{
					this.ValidateCredentials(this.cboUsername.Text, this.txtPassword.Text, MyProject.Forms.Form1.branch);
				}
				else
				{
					MessageBox.Show("Please select the discount amount first.");
					this.cboDiscount.Focus();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error checking credentials. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005AD7 RID: 23255 RVA: 0x00345AA0 File Offset: 0x00343CA0
		private void ValidateCredentials(string uname, string pwd, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			DataTable dataTable = new DataTable();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CheckUsername";
			sqlCommand.Parameters.AddWithValue("username", uname);
			sqlCommand.Parameters.AddWithValue("pwd", this.pf.Encrypt(pwd, Conversions.ToString(MyProject.Forms.Form1.coid)));
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			bool flag = dataTable.Rows.Count > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				bool flag2 = Conversions.ToBoolean(dataRow["IsActive"]);
				if (flag2)
				{
					bool flag3 = Operators.CompareString(uname, dataRow["username"].ToString(), false) == 0;
					if (flag3)
					{
						bool flag4 = Conversions.ToBoolean(dataRow["IsAllBranches"]);
						if (flag4)
						{
							bool flag5 = Conversions.ToBoolean(dataRow["isadmin"]);
							if (flag5)
							{
								MyProject.Forms.Form1.DiscountApprovedPerc = new decimal(Conversion.Val(this.cboDiscount.Text));
							}
							bool flag6 = Conversions.ToBoolean(dataRow["issup"]);
							if (flag6)
							{
								MyProject.Forms.Form1.DiscountApprovedPerc = new decimal(Conversion.Val(this.cboDiscount.Text));
							}
							MyProject.Forms.Form1.Approvedby = this.cboUsername.Text;
							bool @checked = this.chkLimitPayMethods.Checked;
							if (@checked)
							{
								MyProject.Forms.Form1.DiscountLimitPayMethods = 1;
								MyProject.Forms.Form1.DiscountPayMethod = Conversions.ToInteger(this.cboPayMethods.SelectedValue);
							}
							bool checked2 = this.chkPerc.Checked;
							if (checked2)
							{
								MyProject.Forms.Form1.discountApprovedIsPerc = true;
							}
							else
							{
								MyProject.Forms.Form1.discountApprovedIsPerc = false;
								MyProject.Forms.Form1.DiscountApprovedAmt = Convert.ToDecimal(this.txtDiscAmount.Text);
							}
							bool checked3 = this.radIncrease.Checked;
							if (checked3)
							{
								MyProject.Forms.Form1.discountApprovedIncrease = true;
							}
							else
							{
								bool checked4 = this.radReduce.Checked;
								if (checked4)
								{
									MyProject.Forms.Form1.discountApprovedIncrease = false;
								}
							}
							MessageBox.Show("DISCOUNT APPROVED.");
							base.Dispose();
						}
						else
						{
							bool flag7 = Operators.CompareString(dataRow["branch"].ToString(), MyProject.Forms.Form1.branch, false) == 0;
							if (flag7)
							{
								bool flag8 = Conversions.ToBoolean(dataRow["isadmin"]) | Conversions.ToBoolean(dataRow["issup"]);
								if (flag8)
								{
									MyProject.Forms.Form1.Approvedby = this.cboUsername.Text;
									bool checked5 = this.chkPerc.Checked;
									if (checked5)
									{
										MyProject.Forms.Form1.discountApprovedIsPerc = true;
										MyProject.Forms.Form1.DiscountApprovedPerc = new decimal(Conversion.Val(this.cboDiscount.Text));
										MyProject.Forms.Form1.DiscountApprovedAmt = 0m;
									}
									else
									{
										MyProject.Forms.Form1.discountApprovedIsPerc = false;
										MyProject.Forms.Form1.DiscountApprovedPerc = 0m;
										MyProject.Forms.Form1.DiscountApprovedAmt = new decimal(Conversion.Val(this.txtDiscAmount.Text));
									}
									bool checked6 = this.chkLimitPayMethods.Checked;
									if (checked6)
									{
										MyProject.Forms.Form1.DiscountLimitPayMethods = 1;
										MyProject.Forms.Form1.DiscountPayMethod = Conversions.ToInteger(this.cboPayMethods.SelectedValue);
									}
									bool checked7 = this.radIncrease.Checked;
									if (checked7)
									{
										MyProject.Forms.Form1.discountApprovedIncrease = true;
									}
									else
									{
										bool checked8 = this.radReduce.Checked;
										if (checked8)
										{
											MyProject.Forms.Form1.discountApprovedIncrease = false;
										}
									}
								}
								MessageBox.Show("DISCOUNT APPROVED.");
								base.Dispose();
							}
							else
							{
								MessageBox.Show("Invalid username or branch");
								MyProject.Forms.Form1.DiscountApproved = 0;
								MyProject.Forms.Form1.DiscountApprovedPerc = 0m;
								MyProject.Forms.Form1.Approvedby = "";
							}
						}
					}
					else
					{
						MessageBox.Show("Invalid username.");
						MyProject.Forms.Form1.DiscountApproved = 0;
						MyProject.Forms.Form1.DiscountApprovedPerc = 0m;
						MyProject.Forms.Form1.Approvedby = "";
					}
				}
				else
				{
					MessageBox.Show("User is deactivated.");
					MyProject.Forms.Form1.DiscountApproved = 0;
					MyProject.Forms.Form1.DiscountApprovedPerc = 0m;
					MyProject.Forms.Form1.Approvedby = "";
				}
			}
			else
			{
				MessageBox.Show("Invalid username and password.");
				MyProject.Forms.Form1.DiscountApproved = 0;
				MyProject.Forms.Form1.DiscountApprovedPerc = 0m;
				MyProject.Forms.Form1.Approvedby = "";
			}
		}

		// Token: 0x06005AD8 RID: 23256 RVA: 0x0034603C File Offset: 0x0034423C
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				MyProject.Forms.Form1.DiscountApproved = 0;
				MessageBox.Show("DISCOUNT NOT APPROVED");
				base.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error. Detail: " + ex.Message);
			}
		}

		// Token: 0x06005AD9 RID: 23257 RVA: 0x003460A8 File Offset: 0x003442A8
		private void chkLimitPayMethods_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chkLimitPayMethods.Checked;
				if (@checked)
				{
					this.Label5.Visible = true;
					this.cboPayMethods.Visible = true;
				}
				else
				{
					this.Label5.Visible = false;
					this.cboPayMethods.Visible = false;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06005ADA RID: 23258 RVA: 0x00346124 File Offset: 0x00344324
		private void chkPerc_CheckedChanged(object sender, EventArgs e)
		{
			try
			{
				bool @checked = this.chkPerc.Checked;
				if (@checked)
				{
					this.Label4.Visible = true;
					this.cboDiscount.Visible = true;
					this.Label6.Visible = false;
					this.txtDiscAmount.Visible = false;
				}
				else
				{
					this.Label4.Visible = false;
					this.cboDiscount.Visible = false;
					this.Label6.Visible = true;
					this.txtDiscAmount.Visible = true;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06005ADB RID: 23259 RVA: 0x003461D4 File Offset: 0x003443D4
		private void txtDiscAmount_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !(char.IsDigit(e.KeyChar) | (Operators.CompareString(Conversions.ToString(e.KeyChar), ".", false) == 0) | (Strings.Asc(e.KeyChar) == 8));
		}

		// Token: 0x06005ADC RID: 23260 RVA: 0x00346220 File Offset: 0x00344420
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				MyProject.Forms.Form1.discountApprovedIsPerc = false;
				MyProject.Forms.Form1.DiscountApprovedAmt = 0m;
				MyProject.Forms.Form1.DiscountApprovedPerc = 0m;
				MyProject.Forms.Form1.Approvedby = "";
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06005ADD RID: 23261 RVA: 0x00002A30 File Offset: 0x00000C30
		private void lblCost_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06005ADE RID: 23262 RVA: 0x003462A0 File Offset: 0x003444A0
		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				DialogNumeric dialogNumeric = new DialogNumeric();
				bool flag = dialogNumeric.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					this.txtDiscAmount.Text = dialogNumeric.lblamt.Text;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Keypad error. Details: " + ex.Message);
			}
		}

		// Token: 0x040027AB RID: 10155
		private string _cnn;

		// Token: 0x040027AC RID: 10156
		private PublicFunctions pf;

		// Token: 0x040027AD RID: 10157
		public string prod_desc;

		// Token: 0x040027AE RID: 10158
		public decimal prod_cost;

		// Token: 0x040027AF RID: 10159
		public decimal prod_selling;

		// Token: 0x040027B0 RID: 10160
		private PublicFunctions publicfunction;
	}
}
