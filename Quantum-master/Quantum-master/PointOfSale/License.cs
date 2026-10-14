using System;
using System.Collections;
using System.Collections.Specialized;
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

namespace PointOfSale
{
	// Token: 0x0200006A RID: 106
	[DesignerGenerated]
	public partial class License : Form
	{
		// Token: 0x06001634 RID: 5684 RVA: 0x000CEE00 File Offset: 0x000CD000
		public License()
		{
			base.Load += this.License_Load;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.Publicfunction = new PublicFunctions();
			this.keymonths = 0;
			this.InitializeComponent();
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06001637 RID: 5687 RVA: 0x000CFC70 File Offset: 0x000CDE70
		// (set) Token: 0x06001638 RID: 5688 RVA: 0x000CFC7A File Offset: 0x000CDE7A
		internal virtual TextBox txtkey5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06001639 RID: 5689 RVA: 0x000CFC83 File Offset: 0x000CDE83
		// (set) Token: 0x0600163A RID: 5690 RVA: 0x000CFC8D File Offset: 0x000CDE8D
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x0600163B RID: 5691 RVA: 0x000CFC96 File Offset: 0x000CDE96
		// (set) Token: 0x0600163C RID: 5692 RVA: 0x000CFCA0 File Offset: 0x000CDEA0
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x0600163D RID: 5693 RVA: 0x000CFCA9 File Offset: 0x000CDEA9
		// (set) Token: 0x0600163E RID: 5694 RVA: 0x000CFCB3 File Offset: 0x000CDEB3
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x0600163F RID: 5695 RVA: 0x000CFCBC File Offset: 0x000CDEBC
		// (set) Token: 0x06001640 RID: 5696 RVA: 0x000CFCC6 File Offset: 0x000CDEC6
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06001641 RID: 5697 RVA: 0x000CFCCF File Offset: 0x000CDECF
		// (set) Token: 0x06001642 RID: 5698 RVA: 0x000CFCD9 File Offset: 0x000CDED9
		internal virtual TextBox txtkey4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06001643 RID: 5699 RVA: 0x000CFCE2 File Offset: 0x000CDEE2
		// (set) Token: 0x06001644 RID: 5700 RVA: 0x000CFCEC File Offset: 0x000CDEEC
		internal virtual TextBox txtkey3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06001645 RID: 5701 RVA: 0x000CFCF5 File Offset: 0x000CDEF5
		// (set) Token: 0x06001646 RID: 5702 RVA: 0x000CFCFF File Offset: 0x000CDEFF
		internal virtual TextBox txtkey2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06001647 RID: 5703 RVA: 0x000CFD08 File Offset: 0x000CDF08
		// (set) Token: 0x06001648 RID: 5704 RVA: 0x000CFD12 File Offset: 0x000CDF12
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06001649 RID: 5705 RVA: 0x000CFD1B File Offset: 0x000CDF1B
		// (set) Token: 0x0600164A RID: 5706 RVA: 0x000CFD28 File Offset: 0x000CDF28
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

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x0600164B RID: 5707 RVA: 0x000CFD6B File Offset: 0x000CDF6B
		// (set) Token: 0x0600164C RID: 5708 RVA: 0x000CFD75 File Offset: 0x000CDF75
		internal virtual TextBox txtkey
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x0600164D RID: 5709 RVA: 0x000CFD7E File Offset: 0x000CDF7E
		// (set) Token: 0x0600164E RID: 5710 RVA: 0x000CFD88 File Offset: 0x000CDF88
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x0600164F RID: 5711 RVA: 0x000CFD91 File Offset: 0x000CDF91
		// (set) Token: 0x06001650 RID: 5712 RVA: 0x000CFD9C File Offset: 0x000CDF9C
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

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06001651 RID: 5713 RVA: 0x000CFDDF File Offset: 0x000CDFDF
		// (set) Token: 0x06001652 RID: 5714 RVA: 0x000CFDE9 File Offset: 0x000CDFE9
		internal virtual TextBox txtexpdate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06001653 RID: 5715 RVA: 0x000CFDF2 File Offset: 0x000CDFF2
		// (set) Token: 0x06001654 RID: 5716 RVA: 0x000CFDFC File Offset: 0x000CDFFC
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06001655 RID: 5717 RVA: 0x000CFE05 File Offset: 0x000CE005
		// (set) Token: 0x06001656 RID: 5718 RVA: 0x000CFE0F File Offset: 0x000CE00F
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06001657 RID: 5719 RVA: 0x000CFE18 File Offset: 0x000CE018
		// (set) Token: 0x06001658 RID: 5720 RVA: 0x000CFE22 File Offset: 0x000CE022
		internal virtual Label Label7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06001659 RID: 5721 RVA: 0x000CFE2B File Offset: 0x000CE02B
		// (set) Token: 0x0600165A RID: 5722 RVA: 0x000CFE35 File Offset: 0x000CE035
		internal virtual Label lblProcessor
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x0600165B RID: 5723 RVA: 0x000CFE3E File Offset: 0x000CE03E
		// (set) Token: 0x0600165C RID: 5724 RVA: 0x000CFE48 File Offset: 0x000CE048
		internal virtual Label lblBoard
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x0600165D RID: 5725 RVA: 0x000CFE51 File Offset: 0x000CE051
		// (set) Token: 0x0600165E RID: 5726 RVA: 0x000CFE5B File Offset: 0x000CE05B
		internal virtual Label lblcompany
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x0600165F RID: 5727 RVA: 0x000CFE64 File Offset: 0x000CE064
		// (set) Token: 0x06001660 RID: 5728 RVA: 0x000CFE6E File Offset: 0x000CE06E
		internal virtual Label lblcoid
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06001661 RID: 5729 RVA: 0x000CFE78 File Offset: 0x000CE078
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = this.VerifyKey();
				if (flag)
				{
					bool flag2 = !this.IsKeyUsed();
					if (flag2)
					{
						string text = string.Concat(new string[]
						{
							this.txtkey.Text,
							this.txtkey2.Text,
							this.txtkey3.Text,
							this.txtkey4.Text,
							this.txtkey5.Text
						});
						string text2 = this.txtkey5.Text;
						DateTime dateTime = DateAndTime.DateAdd(DateInterval.Month, (double)this.keymonths, DateTime.Today);
						this.Publicfunction.AddUpdateAppSettings("License", dateTime.ToString("yyyyMMdd"));
						this.SaveKey(text, dateTime.ToString("yyyyMMdd"));
						MessageBox.Show("Key saved succesfully. Expiry date " + dateTime.ToString("yyyyMMdd"), "Success!", MessageBoxButtons.OK);
						base.Close();
					}
					else
					{
						MessageBox.Show("Key entered has already been used", "Key Used", MessageBoxButtons.OK);
						this.txtkey.Focus();
					}
				}
				else
				{
					MessageBox.Show("Key entered is invalid. Try again.", "Error", MessageBoxButtons.OK);
					this.txtkey.Focus();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("An error has occurred. Restart. Error: " + ex.Message, "Error", MessageBoxButtons.OK);
			}
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x000D0000 File Offset: 0x000CE200
		private bool VerifyKey()
		{
			checked
			{
				bool flag13;
				try
				{
					int num = Convert.ToInt32(this.txtkey.Text.Substring(1, 3));
					int num2 = Convert.ToInt32(this.txtkey2.Text);
					int num3 = Convert.ToInt32(this.txtkey3.Text);
					int num4 = Convert.ToInt32(this.txtkey4.Text);
					string text = this.txtkey5.Text;
					try
					{
						int num5 = (int)Math.Round(Conversion.Val(this.Label7.Text.Substring(1, this.Label7.Text.Length - 1)));
						bool flag = num5 < 0;
						if (flag)
						{
							num5 *= -1;
						}
						else
						{
							bool flag2 = num5 == 0;
							if (flag2)
							{
								num5 = 111;
							}
						}
						int num6 = Convert.ToInt32(num5.ToString().Substring(0, 1));
						bool flag3 = num % num6 > 0;
						if (flag3)
						{
							return false;
						}
					}
					catch (Exception ex)
					{
						return false;
					}
					try
					{
						bool flag4 = num2 % 4 > 0;
						if (flag4)
						{
							return false;
						}
					}
					catch (Exception ex2)
					{
						return false;
					}
					try
					{
						bool flag5 = num3 % 4 > 0;
						if (flag5)
						{
							return false;
						}
					}
					catch (Exception ex3)
					{
						return false;
					}
					try
					{
						string text2 = text.Substring(0, 1);
						bool flag6 = Operators.CompareString(text2, "Z", false) != 0;
						if (flag6)
						{
							return false;
						}
					}
					catch (Exception ex4)
					{
						return false;
					}
					try
					{
						int num7 = Conversions.ToInteger(text.Substring(1, 2));
						int num8 = Conversions.ToInteger(text.Substring(3, 1));
						int num9 = num7 * num8;
						int num10 = Conversions.ToInteger(this.txtkey4.Text.Substring(0, 2));
						int num11 = Conversions.ToInteger(this.txtkey4.Text.Substring(2, 2));
						bool flag7 = num9 != num10;
						if (flag7)
						{
							return false;
						}
						bool flag8 = num10 % num11 > 0;
						if (flag8)
						{
							return false;
						}
						string text3 = this.txtkey.Text.Substring(0, 1);
						bool flag9 = Operators.CompareString(text3, "9", false) == 0;
						if (flag9)
						{
							string text4 = this.txtkey4.Text.Substring(0, 2);
							bool flag10 = Operators.CompareString(text4, "99", false) == 0;
							if (flag10)
							{
								this.keymonths = 1200;
							}
						}
						bool flag11 = this.keymonths == 0;
						if (flag11)
						{
							this.keymonths = (int)Math.Round((double)num10 / (double)num11);
							bool flag12 = this.keymonths <= 0;
							if (flag12)
							{
								return false;
							}
						}
					}
					catch (Exception ex5)
					{
						return false;
					}
					flag13 = true;
				}
				catch (Exception ex6)
				{
					flag13 = false;
				}
				return flag13;
			}
		}

		// Token: 0x06001663 RID: 5731 RVA: 0x000D0384 File Offset: 0x000CE584
		private bool IsKeyUsed()
		{
			string text = string.Concat(new string[]
			{
				this.txtkey.Text,
				this.txtkey2.Text,
				this.txtkey3.Text,
				this.txtkey4.Text,
				this.txtkey5.Text
			});
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchAllKeys";
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				try
				{
					foreach (object obj in dataTable.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						bool flag2 = Operators.CompareString(this.Publicfunction.Decrypt(dataRow["SerialKey"].ToString(), Conversions.ToString(10)), text, false) == 0;
						if (flag2)
						{
							return true;
						}
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
			return false;
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x000D04C4 File Offset: 0x000CE6C4
		private void SaveKey(string key, string expdate)
		{
			string text = this.Publicfunction.Encrypt(key, Conversions.ToString(10));
			string text2 = this.Publicfunction.Encrypt(expdate, Conversions.ToString(10));
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SaveKey";
			sqlCommand.Parameters.AddWithValue("serialkey", text);
			sqlCommand.Parameters.AddWithValue("expdate", text2);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			SqlConnection sqlConnection2 = sqlConnection;
			sqlConnection2.Open();
			sqlCommand.ExecuteNonQuery();
			sqlConnection2.Close();
		}

		// Token: 0x06001665 RID: 5733 RVA: 0x000D05AC File Offset: 0x000CE7AC
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void Button2_Click(object sender, EventArgs e)
		{
			try
			{
				PublicFunctions publicFunctions = new PublicFunctions();
				publicFunctions.Logoff(this._cnn);
				ProjectData.EndApp();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error logging off. Detail: " + ex.Message);
				ProjectData.EndApp();
			}
		}

		// Token: 0x06001666 RID: 5734 RVA: 0x000D0614 File Offset: 0x000CE814
		private string SystemSerialNumber()
		{
			object objectValue = RuntimeHelpers.GetObjectValue(Interaction.GetObject("WinMgmts:", null));
			string text = "";
			object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "InstancesOf", new object[] { "Win32_BaseBoard" }, null, null, null));
			try
			{
				foreach (object obj in ((IEnumerable)objectValue2))
				{
					object objectValue3 = RuntimeHelpers.GetObjectValue(obj);
					text = Conversions.ToString(Operators.ConcatenateObject(text, Operators.ConcatenateObject(", ", NewLateBinding.LateGet(objectValue3, null, "SerialNumber", new object[0], null, null, null))));
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
			bool flag = text.Length > 0;
			if (flag)
			{
				text = text.Substring(2);
			}
			return text;
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x000D06F8 File Offset: 0x000CE8F8
		private string CpuId()
		{
			string text = ".";
			object objectValue = RuntimeHelpers.GetObjectValue(Interaction.GetObject("winmgmts:{impersonationLevel=impersonate}!\\\\" + text + "\\root\\cimv2", null));
			object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, null, "ExecQuery", new object[] { "Select * from Win32_Processor" }, null, null, null));
			string text2 = "";
			try
			{
				foreach (object obj in ((IEnumerable)objectValue2))
				{
					object objectValue3 = RuntimeHelpers.GetObjectValue(obj);
					text2 = Conversions.ToString(Operators.ConcatenateObject(text2 + ", ", NewLateBinding.LateGet(objectValue3, null, "ProcessorId", new object[0], null, null, null)));
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
			bool flag = text2.Length > 0;
			if (flag)
			{
				text2 = text2.Substring(2);
			}
			return text2;
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x000D07F4 File Offset: 0x000CE9F4
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void License_Load(object sender, EventArgs e)
		{
			try
			{
				this.Cursor = Cursors.WaitCursor;
				base.MaximizeBox = false;
				this.lblBoard.Text = this.SystemSerialNumber();
				this.lblProcessor.Text = this.CpuId();
				this.Label7.Text = "v" + Conversions.ToString(this.ConvertStringToInteger(this.lblBoard.Text));
				this.lblcoid.Text = "COID: " + Conversions.ToString(MyProject.Forms.Form1.coid);
				this.lblcompany.Text = "COMPANY: " + MyProject.Forms.Form1.companyname;
				bool flag = this.CheckLicense();
				if (flag)
				{
					this.txtexpdate.Text = Conversions.ToString(MyProject.Forms.Form1.License);
				}
				else
				{
					this.txtexpdate.Text = "0";
				}
				bool flag2 = Operators.CompareString(this.txtexpdate.Text, "0", false) == 0;
				if (flag2)
				{
					bool flag3 = !this.AreThereLicKeys() & !this.AreSalesThere();
					if (flag3)
					{
						string text = "1100200040001212Z043";
						DateTime dateTime = DateAndTime.DateAdd(DateInterval.Month, 1.0, DateTime.Today);
						this.Publicfunction.AddUpdateAppSettings("License", dateTime.ToString("yyyyMMdd"));
						this.SaveKey(text, dateTime.ToString("yyyyMMdd"));
						MessageBox.Show("ONE MONTH license key activated. Let QuantumPOS help your business be better.");
						ProjectData.EndApp();
					}
				}
				this.Cursor = Cursors.Default;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x000D09E0 File Offset: 0x000CEBE0
		private bool AreSalesThere()
		{
			bool flag2;
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.Text;
				sqlCommand.CommandText = string.Concat(new string[]
				{
					"select count(*) as sales_count from movement where trancode=3 and coid=",
					Conversions.ToString(MyProject.Forms.Form1.coid),
					" and branch='",
					MyProject.Forms.Form1.branch,
					"'"
				});
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				sqlDataAdapter.Fill(dataTable);
				DataRow dataRow = dataTable.Rows[0];
				int num = Conversions.ToInteger(dataRow[0]);
				bool flag = num > 0;
				if (flag)
				{
					flag2 = true;
				}
				else
				{
					flag2 = false;
				}
			}
			catch (Exception ex)
			{
				flag2 = true;
			}
			return flag2;
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x000D0AC8 File Offset: 0x000CECC8
		private bool AreThereLicKeys()
		{
			bool flag2;
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this._cnn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.Text;
				sqlCommand.CommandText = string.Concat(new string[]
				{
					"select count(*) from serials where coid=",
					Conversions.ToString(MyProject.Forms.Form1.coid),
					" and branch='",
					MyProject.Forms.Form1.branch,
					"'"
				});
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				sqlDataAdapter.Fill(dataTable);
				DataRow dataRow = dataTable.Rows[0];
				int num = Conversions.ToInteger(dataRow[0]);
				bool flag = num > 0;
				if (flag)
				{
					flag2 = true;
				}
				else
				{
					flag2 = false;
				}
			}
			catch (Exception ex)
			{
				flag2 = true;
			}
			return flag2;
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x000D0BB0 File Offset: 0x000CEDB0
		private int ConvertStringToInteger(string str)
		{
			int num = 0;
			checked
			{
				foreach (char c in str.ToUpper())
				{
					bool flag = Versioned.IsNumeric(c);
					if (!flag)
					{
						num += Convert.ToInt32(Strings.Asc(c) - 65);
					}
				}
				return num;
			}
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x000D0C20 File Offset: 0x000CEE20
		private bool CheckLicense()
		{
			NameValueCollection appSettings = ConfigurationManager.AppSettings;
			bool flag = appSettings.Count > 0;
			bool flag2;
			if (flag)
			{
				foreach (string text in appSettings.AllKeys)
				{
					if (Operators.CompareString(text, "License", false) == 0)
					{
						MyProject.Forms.Form1.License = checked((int)Math.Round(Conversion.Val(appSettings[text])));
					}
				}
				flag2 = true;
			}
			else
			{
				flag2 = false;
			}
			return flag2;
		}

		// Token: 0x04000B2E RID: 2862
		private string _cnn;

		// Token: 0x04000B2F RID: 2863
		private PublicFunctions Publicfunction;

		// Token: 0x04000B30 RID: 2864
		private int keymonths;
	}
}
