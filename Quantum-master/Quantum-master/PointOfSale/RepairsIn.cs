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
	// Token: 0x02000182 RID: 386
	[DesignerGenerated]
	public partial class RepairsIn : UserControl
	{
		// Token: 0x0600394D RID: 14669 RVA: 0x001F306E File Offset: 0x001F126E
		public RepairsIn()
		{
			base.Load += this.RepairsIn_Load;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x17001522 RID: 5410
		// (get) Token: 0x06003950 RID: 14672 RVA: 0x001F4667 File Offset: 0x001F2867
		// (set) Token: 0x06003951 RID: 14673 RVA: 0x001F4671 File Offset: 0x001F2871
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001523 RID: 5411
		// (get) Token: 0x06003952 RID: 14674 RVA: 0x001F467A File Offset: 0x001F287A
		// (set) Token: 0x06003953 RID: 14675 RVA: 0x001F4684 File Offset: 0x001F2884
		internal virtual Label Label1
		{
			[CompilerGenerated]
			get
			{
				return this._Label1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label1_Click);
				Label label = this._Label1;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label1 = value;
				label = this._Label1;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x17001524 RID: 5412
		// (get) Token: 0x06003954 RID: 14676 RVA: 0x001F46C7 File Offset: 0x001F28C7
		// (set) Token: 0x06003955 RID: 14677 RVA: 0x001F46D1 File Offset: 0x001F28D1
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001525 RID: 5413
		// (get) Token: 0x06003956 RID: 14678 RVA: 0x001F46DA File Offset: 0x001F28DA
		// (set) Token: 0x06003957 RID: 14679 RVA: 0x001F46E4 File Offset: 0x001F28E4
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001526 RID: 5414
		// (get) Token: 0x06003958 RID: 14680 RVA: 0x001F46ED File Offset: 0x001F28ED
		// (set) Token: 0x06003959 RID: 14681 RVA: 0x001F46F7 File Offset: 0x001F28F7
		internal virtual TextBox txtAddress
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001527 RID: 5415
		// (get) Token: 0x0600395A RID: 14682 RVA: 0x001F4700 File Offset: 0x001F2900
		// (set) Token: 0x0600395B RID: 14683 RVA: 0x001F470A File Offset: 0x001F290A
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001528 RID: 5416
		// (get) Token: 0x0600395C RID: 14684 RVA: 0x001F4713 File Offset: 0x001F2913
		// (set) Token: 0x0600395D RID: 14685 RVA: 0x001F471D File Offset: 0x001F291D
		internal virtual TextBox txtMobile
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001529 RID: 5417
		// (get) Token: 0x0600395E RID: 14686 RVA: 0x001F4726 File Offset: 0x001F2926
		// (set) Token: 0x0600395F RID: 14687 RVA: 0x001F4730 File Offset: 0x001F2930
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700152A RID: 5418
		// (get) Token: 0x06003960 RID: 14688 RVA: 0x001F4739 File Offset: 0x001F2939
		// (set) Token: 0x06003961 RID: 14689 RVA: 0x001F4743 File Offset: 0x001F2943
		internal virtual TextBox txtCustomerName
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700152B RID: 5419
		// (get) Token: 0x06003962 RID: 14690 RVA: 0x001F474C File Offset: 0x001F294C
		// (set) Token: 0x06003963 RID: 14691 RVA: 0x001F4756 File Offset: 0x001F2956
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700152C RID: 5420
		// (get) Token: 0x06003964 RID: 14692 RVA: 0x001F475F File Offset: 0x001F295F
		// (set) Token: 0x06003965 RID: 14693 RVA: 0x001F4769 File Offset: 0x001F2969
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700152D RID: 5421
		// (get) Token: 0x06003966 RID: 14694 RVA: 0x001F4772 File Offset: 0x001F2972
		// (set) Token: 0x06003967 RID: 14695 RVA: 0x001F477C File Offset: 0x001F297C
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700152E RID: 5422
		// (get) Token: 0x06003968 RID: 14696 RVA: 0x001F4785 File Offset: 0x001F2985
		// (set) Token: 0x06003969 RID: 14697 RVA: 0x001F478F File Offset: 0x001F298F
		internal virtual TextBox txtIssues
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700152F RID: 5423
		// (get) Token: 0x0600396A RID: 14698 RVA: 0x001F4798 File Offset: 0x001F2998
		// (set) Token: 0x0600396B RID: 14699 RVA: 0x001F47A2 File Offset: 0x001F29A2
		internal virtual Label Label9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001530 RID: 5424
		// (get) Token: 0x0600396C RID: 14700 RVA: 0x001F47AB File Offset: 0x001F29AB
		// (set) Token: 0x0600396D RID: 14701 RVA: 0x001F47B5 File Offset: 0x001F29B5
		internal virtual TextBox txtSerial
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001531 RID: 5425
		// (get) Token: 0x0600396E RID: 14702 RVA: 0x001F47BE File Offset: 0x001F29BE
		// (set) Token: 0x0600396F RID: 14703 RVA: 0x001F47C8 File Offset: 0x001F29C8
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001532 RID: 5426
		// (get) Token: 0x06003970 RID: 14704 RVA: 0x001F47D1 File Offset: 0x001F29D1
		// (set) Token: 0x06003971 RID: 14705 RVA: 0x001F47DB File Offset: 0x001F29DB
		internal virtual TextBox txtProductDesc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001533 RID: 5427
		// (get) Token: 0x06003972 RID: 14706 RVA: 0x001F47E4 File Offset: 0x001F29E4
		// (set) Token: 0x06003973 RID: 14707 RVA: 0x001F47EE File Offset: 0x001F29EE
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001534 RID: 5428
		// (get) Token: 0x06003974 RID: 14708 RVA: 0x001F47F7 File Offset: 0x001F29F7
		// (set) Token: 0x06003975 RID: 14709 RVA: 0x001F4801 File Offset: 0x001F2A01
		internal virtual Label Label10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001535 RID: 5429
		// (get) Token: 0x06003976 RID: 14710 RVA: 0x001F480A File Offset: 0x001F2A0A
		// (set) Token: 0x06003977 RID: 14711 RVA: 0x001F4814 File Offset: 0x001F2A14
		internal virtual DateTimePicker DTDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001536 RID: 5430
		// (get) Token: 0x06003978 RID: 14712 RVA: 0x001F481D File Offset: 0x001F2A1D
		// (set) Token: 0x06003979 RID: 14713 RVA: 0x001F4827 File Offset: 0x001F2A27
		internal virtual Label Label14
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001537 RID: 5431
		// (get) Token: 0x0600397A RID: 14714 RVA: 0x001F4830 File Offset: 0x001F2A30
		// (set) Token: 0x0600397B RID: 14715 RVA: 0x001F483A File Offset: 0x001F2A3A
		internal virtual Label Label13
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001538 RID: 5432
		// (get) Token: 0x0600397C RID: 14716 RVA: 0x001F4843 File Offset: 0x001F2A43
		// (set) Token: 0x0600397D RID: 14717 RVA: 0x001F484D File Offset: 0x001F2A4D
		internal virtual Label Label12
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001539 RID: 5433
		// (get) Token: 0x0600397E RID: 14718 RVA: 0x001F4856 File Offset: 0x001F2A56
		// (set) Token: 0x0600397F RID: 14719 RVA: 0x001F4860 File Offset: 0x001F2A60
		internal virtual Label Label17
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700153A RID: 5434
		// (get) Token: 0x06003980 RID: 14720 RVA: 0x001F4869 File Offset: 0x001F2A69
		// (set) Token: 0x06003981 RID: 14721 RVA: 0x001F4873 File Offset: 0x001F2A73
		internal virtual Label Label16
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700153B RID: 5435
		// (get) Token: 0x06003982 RID: 14722 RVA: 0x001F487C File Offset: 0x001F2A7C
		// (set) Token: 0x06003983 RID: 14723 RVA: 0x001F4886 File Offset: 0x001F2A86
		internal virtual Label Label15
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700153C RID: 5436
		// (get) Token: 0x06003984 RID: 14724 RVA: 0x001F488F File Offset: 0x001F2A8F
		// (set) Token: 0x06003985 RID: 14725 RVA: 0x001F4899 File Offset: 0x001F2A99
		internal virtual ComboBox cboAssigned
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700153D RID: 5437
		// (get) Token: 0x06003986 RID: 14726 RVA: 0x001F48A2 File Offset: 0x001F2AA2
		// (set) Token: 0x06003987 RID: 14727 RVA: 0x001F48AC File Offset: 0x001F2AAC
		internal virtual Label Label11
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700153E RID: 5438
		// (get) Token: 0x06003988 RID: 14728 RVA: 0x001F48B5 File Offset: 0x001F2AB5
		// (set) Token: 0x06003989 RID: 14729 RVA: 0x001F48BF File Offset: 0x001F2ABF
		internal virtual ComboBox cboUsers
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700153F RID: 5439
		// (get) Token: 0x0600398A RID: 14730 RVA: 0x001F48C8 File Offset: 0x001F2AC8
		// (set) Token: 0x0600398B RID: 14731 RVA: 0x001F48D4 File Offset: 0x001F2AD4
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

		// Token: 0x17001540 RID: 5440
		// (get) Token: 0x0600398C RID: 14732 RVA: 0x001F4917 File Offset: 0x001F2B17
		// (set) Token: 0x0600398D RID: 14733 RVA: 0x001F4921 File Offset: 0x001F2B21
		internal virtual TextBox txtAmtCharged
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001541 RID: 5441
		// (get) Token: 0x0600398E RID: 14734 RVA: 0x001F492A File Offset: 0x001F2B2A
		// (set) Token: 0x0600398F RID: 14735 RVA: 0x001F4934 File Offset: 0x001F2B34
		internal virtual Label Label19
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001542 RID: 5442
		// (get) Token: 0x06003990 RID: 14736 RVA: 0x001F493D File Offset: 0x001F2B3D
		// (set) Token: 0x06003991 RID: 14737 RVA: 0x001F4947 File Offset: 0x001F2B47
		internal virtual Label Label18
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001543 RID: 5443
		// (get) Token: 0x06003992 RID: 14738 RVA: 0x001F4950 File Offset: 0x001F2B50
		// (set) Token: 0x06003993 RID: 14739 RVA: 0x001F495A File Offset: 0x001F2B5A
		internal virtual ComboBox cboPayMeth
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06003994 RID: 14740 RVA: 0x001F4964 File Offset: 0x001F2B64
		private void Label1_Click(object sender, EventArgs e)
		{
			try
			{
				base.Dispose();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06003995 RID: 14741 RVA: 0x001F499C File Offset: 0x001F2B9C
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Operators.CompareString(this.txtCustomerName.Text, "", false) == 0;
				if (flag)
				{
					MessageBox.Show("Please enter the Customer Name first.");
				}
				else
				{
					bool flag2 = Operators.CompareString(this.txtMobile.Text, "", false) == 0;
					if (flag2)
					{
						MessageBox.Show("Please enter the Customer Mobile number first.");
					}
					else
					{
						bool flag3 = Operators.CompareString(this.txtProductDesc.Text, "", false) == 0;
						if (flag3)
						{
							MessageBox.Show("Please enter the product description first.");
						}
						else
						{
							bool flag4 = Operators.CompareString(this.txtSerial.Text, "", false) == 0;
							if (flag4)
							{
								MessageBox.Show("Enter the product serial number.");
							}
							else
							{
								bool flag5 = Operators.CompareString(this.txtIssues.Text, "", false) == 0;
								if (flag5)
								{
									MessageBox.Show("Please enter the Issues.");
								}
								else
								{
									bool flag6 = this.cboAssigned.SelectedIndex < 1;
									if (flag6)
									{
										MessageBox.Show("Please select the Technician Assigned.");
									}
									else
									{
										bool flag7 = this.cboUsers.SelectedIndex < 1;
										if (flag7)
										{
											MessageBox.Show("Please select the who received the products.");
										}
										else
										{
											int num = 0;
											SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
											SqlCommand sqlCommand = sqlConnection.CreateCommand();
											sqlCommand.CommandType = CommandType.StoredProcedure;
											sqlCommand.CommandText = "RepairsCreate";
											sqlCommand.Parameters.AddWithValue("customername", this.txtCustomerName.Text);
											sqlCommand.Parameters.AddWithValue("mobile", this.txtMobile.Text);
											sqlCommand.Parameters.AddWithValue("customeraddress", this.txtAddress.Text);
											sqlCommand.Parameters.AddWithValue("productdesc", this.txtProductDesc.Text);
											sqlCommand.Parameters.AddWithValue("issues", this.txtIssues.Text);
											sqlCommand.Parameters.AddWithValue("serial", this.txtSerial.Text);
											sqlCommand.Parameters.AddWithValue("datein", this.DTDate.Value);
											sqlCommand.Parameters.AddWithValue("tech", this.cboAssigned.Text);
											sqlCommand.Parameters.AddWithValue("receivedby", this.cboUsers.Text);
											sqlCommand.Parameters.AddWithValue("amountcharged", Conversion.Val(this.txtAmtCharged.Text));
											sqlCommand.Parameters.AddWithValue("paymethodid", Conversions.ToInteger(this.cboPayMeth.SelectedValue));
											sqlCommand.Parameters.AddWithValue("rate", 1);
											sqlCommand.Parameters.AddWithValue("doneby", MyProject.Forms.Form1.username);
											sqlCommand.Parameters.AddWithValue("machinename", Environment.MachineName);
											sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
											sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
											sqlCommand.Parameters.AddWithValue("new_checkinid", num);
											using (sqlConnection)
											{
												sqlConnection.Open();
												num = Conversions.ToInteger(sqlCommand.ExecuteScalar());
												sqlConnection.Close();
											}
											RepairsCheckIn repairsCheckIn = new RepairsCheckIn();
											repairsCheckIn.CheckInEntryno = num;
											repairsCheckIn.ShowDialog(this);
											repairsCheckIn.Dispose();
											base.Dispose();
										}
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error saving. Detail: " + ex.Message);
			}
		}

		// Token: 0x06003996 RID: 14742 RVA: 0x001F4DBC File Offset: 0x001F2FBC
		private void RepairsIn_Load(object sender, EventArgs e)
		{
			try
			{
				DataTable users = this.pf.GetUsers(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.Constring);
				this.cboUsers.DataSource = users;
				this.cboUsers.ValueMember = "Username";
				this.cboUsers.DisplayMember = "Username";
				this.cboUsers.SelectedIndex = -1;
				DataTable users2 = this.pf.GetUsers(MyProject.Forms.Form1.coid, MyProject.Forms.Form1.Constring);
				this.cboAssigned.DataSource = users2;
				this.cboAssigned.ValueMember = "Username";
				this.cboAssigned.DisplayMember = "Username";
				this.cboUsers.SelectedIndex = -1;
				DataTable paymentMethods = this.pf.GetPaymentMethods(MyProject.Forms.Form1.Constring);
				this.cboPayMeth.DataSource = paymentMethods;
				this.cboPayMeth.ValueMember = "PaymentMethodID";
				this.cboPayMeth.DisplayMember = "PaymentMethodDesc";
				this.cboUsers.SelectedIndex = -1;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Details: " + ex.Message);
			}
		}

		// Token: 0x0400188A RID: 6282
		private PublicFunctions pf;
	}
}
