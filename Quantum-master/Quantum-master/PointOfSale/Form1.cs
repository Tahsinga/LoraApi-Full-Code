using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using PointOfSale.My;
using PointOfSale.My.Resources;
using RevmaxAPI;

namespace PointOfSale
{
	// Token: 0x0200005C RID: 92
	[DesignerGenerated]
	public partial class Form1 : Form
	{
		// Token: 0x0600134A RID: 4938 RVA: 0x000B74B0 File Offset: 0x000B56B0
		public Form1()
		{
			base.Load += this.Form1_Load;
			base.FormClosing += this.Form1_FormClosing;
			this.QRCodeSize = 600;
			this.ReceiptSpacingSize = 40;
			this.isEditable = 0;
			this.tipamt = 0m;
			this.dbconn_count = 0;
			this.publicfunction = new PublicFunctions();
			this.IsAdmin = false;
			this.IsSupervisor = false;
			this.License = 0;
			this.PrinterName = "";
			this.BarCode = 0;
			this.coid = 0;
			this.branch = "";
			this.NegativeStock = 0;
			this.shiftdate = 0;
			this.ReceiptSize80 = 1;
			this.FiscalcomPortNum = 0;
			this.FiscalcomPortSpeed = 0;
			this.PrintFiscal = 0;
			this.ChangePaymentMethod = "";
			this.MarkUp = 0m;
			this.SearchCustomer = "";
			this.SearchCustomerEntryno = 0;
			this.CollectEcocashDetails = 0;
			this.tillchangeprice = 0;
			this.IsWarehouse = 0;
			this.DefaultSearchDesc = 1;
			this.OpenImpReports = 0;
			this.ShowLowStockAtStartUp = 0;
			this.AllowTellerToViewStockBalances = 1;
			this.ReceiptDisplayPaymentMethod = 0;
			this.UseReceiptDisplay = 0;
			this.OnlineSearchOptimised = 0;
			this.ShowPaymentMethodsOnReceipt = 0;
			this.NumOfReceiptsPrint = 0;
			this.ChangeToWholesalePriceForQty = 0;
			this.IsWholesaleShop = 0;
			this.AllowSalesonComputer = 1;
			this.suppliername = "";
			this.ShowSpecialPrice = 0;
			this.showproductconversion = 0;
			this.DateChange = 0;
			this.backdatevalue = 0;
			this.DONOTLinkProductCreditWithInvoice = 0;
			this.ConsultantSalesOnly = 0;
			this.datPriceBranches = new DataTable();
			this.useManagedLogins = 0;
			this.lastBranchLoggedin = "";
			this.AllowInvDiscount = 0;
			this.UseCollections = 0;
			this.basecurrency = "";
			this.isRestaurant = 0;
			this.DiscountApproved = 0;
			this.DiscountApprovedPerc = 0m;
			this.DiscountApprovedAmt = 0m;
			this.discountApprovedIsPerc = false;
			this.discountApprovedIncrease = false;
			this.Approvedby = "";
			this.PricesAreAfterTax = 0;
			this.FiscalEltrade = 0;
			this.FiscalRevmax = 0;
			this.DiscountLimitPayMethods = 0;
			this.DiscountPayMethod = 0;
			this.RevmaxDeviceSerial = "";
			this.DiscountEditingAllowed = 0;
			this.InvDiscountEditingAllowed = 0;
			this.RecordConsultant = 0;
			this.AllowAccountSales = 0;
			this.MultiPayMethodsDAT = new DataTable();
			this.Multipay_amtpaid = 0m;
			this.pf = new PublicFunctions();
			this.FSBarcode = 0m;
			this.FSPrice = 0m;
			this.FSDesc = 0m;
			this.FSCompany = 0m;
			this.FSBarcodesymbology = 0;
			this.FSStartingPoint = 0;
			this.OtherProductDetail = 0;
			this.OtherDetail = "";
			this.ReceiptFontSize = 7;
			this.FiscalEltradeESD = 0;
			this.istouchscreen = 0;
			this.usingTables = 0;
			this.usingBarcodePrintingScale = 0;
			this.BarcodePrintingScaleWeight = 0;
			this.BarcodePrintingScalePrice = 0;
			this.ReceiptsOptional = 0;
			this.SHowCustomersInSalesForm = 0;
			this.DecimalPlaces = 4;
			this.CalcBackwards = 0;
			this.PrintToFile = 0;
			this.PrintFilePath = "";
			this.showfooter = 0;
			this.FiscalEltradeESDSerial = "";
			this.SelectA4InvatPOS = 0;
			this.datSelectedCategories = new DataTable();
			this.datSelectedCategoriesStockTake = new DataTable();
			this.defaultReceiptPrinter = "";
			this.defaultSecondaryPrinter = "";
			this.defaultSecondaryPrinterCaption = "";
			this.btnFontSize = 0;
			this.btnSpace = 0;
			this.btnHeight = 0;
			this.btnWidth = 0;
			this.btnCountperLine = 0;
			this.HasSecondScreen = 0;
			this.salesdatagrid = new DataTable();
			this.AdvertPath = "";
			this.UseConnectedScale = 0;
			this.tare = 0m;
			this.ConnectedScalePortNum = 0;
			this.DontAutoAppendAfterBarcodeSearch = 0;
			this.osk = "C:\\Windows\\System32\\osk.exe";
			this.BarFastExchange = 0;
			this.UseApprovals = 0;
			this.DisableQuotations = 0;
			this.pendinginv_paymethodid = "";
			this.DefaultSellingQty = 1;
			this.InvoiceHeaderText = "FISCAL TAX INVOICE";
			this.PrintBarcodeInvNumber = 0;
			this.DontShowQuotationsOnSalesForm = 0;
			this.calcLxWTOTAL = 0m;
			this.calcLxWLength = 0m;
			this.calcLxWWidth = 0m;
			this.autoBreakCase = 0;
			this.BillTrips = 0;
			this.useprintercategories = 0;
			this.AllowDirectPriceEditing = 0;
			this.dgvQuotations = new DataGridView();
			this.openFromQuotes = 0;
			this.autoOpenSalesForm = 0;
			this.quotationnumber = 0;
			this.useOldPrintingService = 0;
			this.receipt_copy_name = "";
			this.qtypurchased = 0m;
			this.supplierselected = "";
			this.hascustomerdisplayvfd = 0;
			this.customerdisplayvfdMessage = "Thank you";
			this.customerdisplayCOMPORT = "COM6";
			this.IsBlindCashUp = 0;
			this.FSYconame = 0m;
			this.FSYbarcode = 15m;
			this.FSYbarcodetext = 37m;
			this.FSYprice = 48m;
			this.FSYDesc = 80m;
			this.FSYDescLineLen = 30m;
			this.selectedbactchnum = "";
			this.selectedexpirydate = 0;
			this.approve_till_void = 0;
			this.approved = false;
			this.inv_template_normal = 0;
			this.inv_template_pharma = 0;
			this.inv_template_incotex = 0;
			this.inv_template_revmax = 0;
			this.inv_template_lea = 0;
			this.inv_template_tongaat = 0;
			this.deposits_inuse = 0;
			this.deposits_1dayvalid = 0;
			this.FSYPriceBold = 0;
			this.FSYDescBold = 0;
			this.FSYConameBold = 0;
			this.ShowCostPrice = 0;
			this.FirstRunStockTake = false;
			this.MaxDiscPerc = 0m;
			this.ConsultantDefaultToUsername = 0;
			this.new_consultant = "";
			this.receipt_template = "NORMAL";
			this.DisableEditingPendingInv = 0;
			this.ShiftClosedUseNExtDay = 0;
			this.InterfacedFiscalSaveas = "txt";
			this.ref2 = "";
			this.pendinginvoice_entryno = 0;
			this.pendinginvoice_ref = 0;
			this.VerificationWeightOK = false;
			this.RevmaxTest = 0;
			this.UsePriceMatrix = 0;
			this.DailyDBBackUp = 0;
			this.inv_template_FDMS = 0;
			this.inv_template_GetPro = 0;
			this.isZimraVirtFiscal = 0;
			this.serialNumberName = "";
			this.datSerials = new DataTable();
			this.datSerialsSelect4Sales = new DataTable();
			this.kduID = 0;
			this.ShowOrderNo = 0;
			this.inv_template_Binum = 0;
			this.inv_template_Farhan = 0;
			this.hidevat = 0;
			this.scaleType = 3;
			this.receiveSerialPortData = true;
			this.serialRestrictQtyTextBox = 0;
			this.usePacketSizes = 0;
			this.receipt_logo_space = 0;
			this.InitializeComponent();
		}

		// Token: 0x0600134B RID: 4939
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern bool Wow64DisableWow64FsRedirection(ref long oldvalue);

		// Token: 0x0600134C RID: 4940
		[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern bool Wow64EnableWow64FsRedirection(ref long oldvalue);

		// Token: 0x0600134D RID: 4941 RVA: 0x000B7B4C File Offset: 0x000B5D4C
		private void Button2_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x000B7B58 File Offset: 0x000B5D58
		private void SetMaxDisc()
		{
			try
			{
				SqlConnection sqlConnection = new SqlConnection(this.Constring);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				DataTable dataTable = new DataTable();
				sqlCommand.CommandType = CommandType.Text;
				sqlCommand.CommandText = string.Concat(new string[]
				{
					"Select maxdisc from branches where coid=",
					Conversions.ToString(this.coid),
					" and branch='",
					this.branch,
					"' "
				});
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				sqlDataAdapter.Fill(dataTable);
				bool flag = dataTable.Rows.Count > 0;
				if (flag)
				{
					DataRow dataRow = dataTable.Rows[0];
					this.MaxDiscPerc = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["maxdisc"])), 0, RuntimeHelpers.GetObjectValue(dataRow["maxdisc"])));
				}
				else
				{
					this.MaxDiscPerc = 0m;
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x000B7C6C File Offset: 0x000B5E6C
		private void Button1_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					bool flag = (Operators.CompareString(this.cboCompany.Text, "", false) == 0) | (Operators.CompareString(this.cboBranch.Text, "", false) == 0);
					if (flag)
					{
						MessageBox.Show("Please select the company and branch first.");
					}
					else
					{
						this.coid = this.coid;
						this.publicfunction.AddUpdateAppSettings("coid", Conversions.ToString(this.coid));
						this.publicfunction.ReadAllSettings();
						this.branch = this.cboBranch.Text;
						this.AdditionalSettingsDAT = this.pf.AdditionalSettingsGetAll(this.coid, this.branch, this.Constring);
						this.lblerr.Text = "";
						bool flag2 = this.ValidateCredentials(Strings.Trim(this.txtUsername.Text), this.publicfunction.Encrypt(this.txtPwd.Text, Conversions.ToString(this.coid)), this.cboBranch.Text);
						if (flag2)
						{
							bool flag3 = this.useManagedLogins == 1;
							if (flag3)
							{
								bool flag4 = this.CheckIfLoggedIn();
								if (flag4)
								{
									MessageBox.Show("User is already logged in.");
									return;
								}
								this.EffectLogin();
							}
							this.publicfunction.AddUpdateAppSettings("lastBranchLoggedin", this.branch);
							this.lastBranchLoggedin = this.branch;
							int num = Conversions.ToInteger(DateTime.Today.ToString("yyyyMMdd"));
							this.License = this.GetLicense();
							bool flag5 = num > this.License;
							if (flag5)
							{
								MessageBox.Show("Please enter a valid License Key for this application in the following form.", "Error", MessageBoxButtons.OK);
								PointOfSale.License license = new PointOfSale.License();
								license.ShowDialog(this);
								license.Dispose();
								base.Close();
							}
							else
							{
								int num2 = this.License - num;
								bool flag6 = num2 <= 7;
								if (flag6)
								{
									MessageBox.Show("There are " + Conversions.ToString(num2) + " days remaining before your license expires. Please renew your application license.", "License Notice", MessageBoxButtons.OK);
								}
								bool flag7 = Operators.CompareString(this.cboMode.Text, "Normal", false) == 0;
								if (flag7)
								{
									this.basecurrency = this.publicfunction.GetBaseCurrency(this.coid, this.Constring);
									this.branch = this.cboBranch.Text;
									this.FirstRunStockTake = this.pf.CheckIfFirstBalRun(this.coid, this.branch, this.Constring);
									bool flag8 = !this.FirstRunStockTake;
									if (flag8)
									{
										DialogResult dialogResult = (DialogResult)Interaction.MsgBox("Do you want to intialise stock balances for quick retrieval? This may take a long time depending.", MsgBoxStyle.YesNo, null);
										bool flag9 = dialogResult == DialogResult.Yes;
										if (flag9)
										{
											Cursor.Current = Cursors.WaitCursor;
											SqlConnection sqlConnection = new SqlConnection(this.Constring);
											SqlCommand sqlCommand = sqlConnection.CreateCommand();
											sqlCommand.CommandType = CommandType.StoredProcedure;
											sqlCommand.CommandText = "SetQuickStockBal";
											sqlCommand.CommandTimeout = 0;
											sqlCommand.Parameters.AddWithValue("coid", this.coid);
											sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
											sqlCommand.Parameters.AddWithValue("iswarehouse", this.IsWarehouse);
											using (sqlConnection)
											{
												sqlConnection.Open();
												sqlCommand.ExecuteNonQuery();
												sqlConnection.Close();
											}
											Cursor.Current = Cursors.Default;
											MessageBox.Show("First run for quick stock balance run successfully.");
										}
									}
									this.SetMaxDisc();
									this.SetAdditionalSettings();
									this.isbranch = this.checkIfBranch(this.coid, this.branch);
									bool flag10 = Operators.CompareString(this.pf.AdditionalSettings2Check(this.coid, this.branch, "EnablePacketSizes", this.Constring), "1", false) == 0;
									if (flag10)
									{
										this.usePacketSizes = 1;
									}
									else
									{
										this.usePacketSizes = 0;
									}
									this.receipt_logo_space = (int)Math.Round(Conversion.Val(this.pf.AdditionalSettings2Check(this.coid, this.branch, "LogoSpacePadding", this.Constring)));
									this.ReceiptSpacingSize = (int)Math.Round(Conversion.Val(this.pf.AdditionalSettings2Check(this.coid, this.branch, "ReceiptSpacingSize", this.Constring)));
									int num3 = (int)Math.Round(Conversion.Val(this.pf.AdditionalSettings2Check(this.coid, this.branch, "QRCodeSize", this.Constring)));
									bool flag11 = num3 == 0;
									if (!flag11)
									{
										this.QRCodeSize = num3;
									}
									MyProject.Forms.MainMenu.Show();
									this.txtUsername.Text = "";
									this.txtPwd.Text = "";
									this.cboBranch.SelectedIndex = -1;
									this.cboCompany.SelectedIndex = -1;
									base.Hide();
									bool flag12 = this.pf.CheckIfDBBackupSet(this.coid, this.Constring);
									if (flag12)
									{
										this.RunExecuteDatabaseBackup();
									}
								}
								else
								{
									bool flag13 = Operators.CompareString(this.cboMode.Text, "Self Service Kiosk", false) == 0;
									if (flag13)
									{
										MyProject.Forms.ViewPricesAvailability.Show();
										base.Hide();
									}
								}
							}
						}
						else
						{
							MessageBox.Show("Invalid log in details supplied. Retry.");
						}
					}
				}
				catch (SqlException ex)
				{
					Cursor.Current = Cursors.Default;
					MessageBox.Show("A network or database availability related error has occured. Log in failed. Detail: " + ex.Message);
				}
				catch (Exception ex2)
				{
					Cursor.Current = Cursors.Default;
					MessageBox.Show("log in failed. Retry. Detail: " + ex2.Message);
				}
			}
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x000B8294 File Offset: 0x000B6494
		private void CheckAppUpdate()
		{
			checked
			{
				try
				{
					int num = 0;
					string text = MyProject.Computer.FileSystem.ReadAllText("C:\\Quantum\\currentversion.txt");
					num = (int)Math.Round(Conversion.Val(text));
					try
					{
						MyProject.Computer.Network.DownloadFile("http://www.parts247.co.zw/QuantumUpdates/onlineversion.txt", "C:\\Quantum\\onlineversion.txt");
					}
					catch (Exception ex)
					{
						try
						{
							MyProject.Computer.FileSystem.DeleteFile("C:\\Quantum\\onlineversion.txt");
							MyProject.Computer.Network.DownloadFile("http://www.parts247.co.zw/QuantumUpdates/onlineversion.txt", "C:\\Quantum\\onlineversion.txt");
						}
						catch (Exception ex2)
						{
						}
					}
					string text2 = MyProject.Computer.FileSystem.ReadAllText("C:\\Quantum\\onlineversion.txt");
					int num2 = (int)Math.Round(Conversion.Val(text2));
					MyProject.Computer.FileSystem.DeleteFile("C:\\Quantum\\onlineversion.txt");
					bool flag = num2 > num;
					if (flag)
					{
						try
						{
							MyProject.Computer.Network.DownloadFile("http://www.parts247.co.zw/QuantumUpdates/QuantumPOS Installer.zip", "C:\\Quantum\\QuantumPOS Installer.zip");
						}
						catch (Exception ex3)
						{
							try
							{
								MyProject.Computer.FileSystem.DeleteFile("C:\\Quantum\\QuantumPOS Installer.zip");
								MyProject.Computer.Network.DownloadFile("http://www.parts247.co.zw/QuantumUpdates/QuantumPOS Installer.zip", "C:\\Quantum\\QuantumPOS Installer.zip");
							}
							catch (Exception ex4)
							{
							}
						}
						MyProject.Computer.FileSystem.DeleteDirectory("C:\\Quantum\\Application Files", DeleteDirectoryOption.DeleteAllContents);
						MyProject.Computer.FileSystem.DeleteFile("C:\\Quantum\\PointOfSale.application");
						string text3 = "C:\\Quantum\\QuantumPOS Installer.zip";
						string text4 = "C:\\Quantum";
						ZipFile.ExtractToDirectory(text3, text4);
						MyProject.Computer.FileSystem.DeleteFile("C:\\Quantum\\QuantumPOS Installer.zip");
						MyProject.Computer.FileSystem.WriteAllText("C:\\Quantum\\currentversion.txt", text2, false);
					}
				}
				catch (Exception ex5)
				{
				}
			}
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x000B84F0 File Offset: 0x000B66F0
		private bool checkIfBranch(int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			DataTable dataTable = new DataTable();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"select ishq from branches where coid=",
				Conversions.ToString(coid),
				" and branch='",
				branch,
				"'"
			});
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			bool flag = dataTable.Rows.Count > 0;
			bool flag4;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				bool flag2 = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ishq"])), true, RuntimeHelpers.GetObjectValue(dataRow["ishq"])));
				bool flag3 = flag2;
				flag4 = !flag3;
			}
			else
			{
				flag4 = false;
			}
			return flag4;
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x000B85DC File Offset: 0x000B67DC
		private bool ValidateCredentials(string uname, string pwd, string branch)
		{
			bool flag = false;
			SqlConnection sqlConnection = new SqlConnection(this.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			DataTable dataTable = new DataTable();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CheckUsername";
			sqlCommand.Parameters.AddWithValue("username", uname);
			sqlCommand.Parameters.AddWithValue("pwd", pwd);
			sqlCommand.Parameters.AddWithValue("coid", this.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			bool flag2 = dataTable.Rows.Count > 0;
			if (flag2)
			{
				DataRow dataRow = dataTable.Rows[0];
				bool flag3 = Conversions.ToBoolean(dataRow["IsActive"]);
				if (flag3)
				{
					bool flag4 = Operators.CompareString(uname, dataRow["username"].ToString(), false) == 0;
					if (flag4)
					{
						bool flag5 = Conversions.ToBoolean(dataRow["IsAllBranches"]);
						if (flag5)
						{
							flag = true;
							this.username = uname;
							bool flag6 = Conversions.ToBoolean(dataRow["isadmin"]);
							if (flag6)
							{
								this.IsAdmin = true;
							}
							else
							{
								this.IsAdmin = false;
							}
							bool flag7 = Conversions.ToBoolean(dataRow["issup"]);
							if (flag7)
							{
								this.IsSupervisor = true;
							}
							else
							{
								this.IsSupervisor = false;
							}
						}
						else
						{
							bool flag8 = Operators.CompareString(dataRow["branch"].ToString(), this.cboBranch.Text, false) == 0;
							if (flag8)
							{
								flag = true;
								this.username = uname;
								bool flag9 = Conversions.ToBoolean(dataRow["isadmin"]);
								if (flag9)
								{
									this.IsAdmin = true;
								}
								else
								{
									this.IsAdmin = false;
								}
								bool flag10 = Conversions.ToBoolean(dataRow["issup"]);
								if (flag10)
								{
									this.IsSupervisor = true;
								}
								else
								{
									this.IsSupervisor = false;
								}
							}
							else
							{
								flag = false;
								MessageBox.Show("Invalid username or branch");
							}
						}
					}
					else
					{
						flag = false;
					}
				}
				else
				{
					flag = false;
					MessageBox.Show("User is deactivated.");
				}
			}
			return flag;
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x000B8800 File Offset: 0x000B6A00
		private int GetLicense()
		{
			int num2;
			try
			{
				int num = 0;
				SqlConnection sqlConnection = new SqlConnection(this.Constring);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				DataTable dataTable = new DataTable();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "GetLatestKey";
				sqlCommand.Parameters.AddWithValue("coid", this.coid);
				sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				sqlDataAdapter.Fill(dataTable);
				bool flag = dataTable.Rows.Count > 0;
				if (flag)
				{
					DataRow dataRow = dataTable.Rows[0];
					string text = this.publicfunction.Decrypt(dataRow["ExpiryDate"].ToString(), Conversions.ToString(10));
					num = Conversions.ToInteger(text);
				}
				num2 = num;
			}
			catch (Exception ex)
			{
				num2 = 0;
			}
			return num2;
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x000B8908 File Offset: 0x000B6B08
		private void LoadBranches()
		{
			SqlConnection sqlConnection = new SqlConnection(this.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchBranchesVisible";
			sqlCommand.Parameters.AddWithValue("coid", this.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.allBranches = dataTable;
			this.cboBranch.DataSource = this.allBranches;
			this.cboBranch.ValueMember = "branch";
			this.cboBranch.DisplayMember = "branch";
			bool flag = dataTable.Rows.Count > 1;
			if (flag)
			{
				string text = this.lastBranchLoggedin;
				this.cboBranch.SelectedIndex = this.cboBranch.FindStringExact(text);
			}
			else
			{
				this.cboBranch.SelectedIndex = 0;
			}
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x000B89F0 File Offset: 0x000B6BF0
		private void loadcompanies()
		{
			SqlConnection sqlConnection = new SqlConnection(this.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectVisibleCompanies";
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			this.cboCompany.DataSource = dataTable;
			this.cboCompany.ValueMember = "CompanyID";
			this.cboCompany.DisplayMember = "Company";
		}

		// Token: 0x06001356 RID: 4950 RVA: 0x000B8A6C File Offset: 0x000B6C6C
		private void Form1_Load(object sender, EventArgs e)
		{
			try
			{
				this.cboMode.SelectedIndex = 0;
				base.AcceptButton = this.Button1;
				bool flag = !this.publicfunction.ReadAllSettings();
				if (flag)
				{
					MessageBox.Show("Connection Settings have not yet been set.");
					DBConnections dbconnections = new DBConnections();
					dbconnections.ShowDialog(this);
					dbconnections.Dispose();
					GeneralSettings generalSettings = new GeneralSettings();
					generalSettings.ShowDialog(this);
					generalSettings.Dispose();
				}
				this.loadcompanies();
				this.LoadBranches();
				this.CreateDefaultAdminUser();
				this.pf.loadmultipaymeths(this.Constring);
				try
				{
					bool flag2 = (this.PrintFiscal == 1) & (this.FiscalRevmax == 1);
					if (flag2)
					{
						this.myrevmax = new Revmaxlib();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Revamx error. Please check of the Revmax device is connected and setup correctly or try again. Detail: " + ex.Message);
				}
				bool flag3 = this.istouchscreen == 1;
				if (flag3)
				{
					bool is64BitOperatingSystem = Environment.Is64BitOperatingSystem;
					if (is64BitOperatingSystem)
					{
						long num;
						bool flag4 = Form1.Wow64DisableWow64FsRedirection(ref num);
						if (flag4)
						{
							Process.Start(this.osk);
							Form1.Wow64EnableWow64FsRedirection(ref num);
						}
					}
					else
					{
						Process.Start(this.osk);
					}
				}
				CultureInfo cultureInfo = (CultureInfo)Thread.CurrentThread.CurrentCulture.Clone();
				cultureInfo.NumberFormat.NumberDecimalSeparator = ".";
				cultureInfo.NumberFormat.CurrencyDecimalSeparator = ".";
				cultureInfo.NumberFormat.CurrencyDecimalDigits = 2;
				cultureInfo.NumberFormat.CurrencyGroupSeparator = ",";
				cultureInfo.NumberFormat.NumberGroupSeparator = ",";
				Thread.CurrentThread.CurrentCulture = cultureInfo;
			}
			catch (Exception ex2)
			{
				MessageBox.Show("Error occurre. Detail: " + ex2.Message);
			}
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x000B8C78 File Offset: 0x000B6E78
		private void CreateDefaultAdminUser()
		{
			try
			{
				DataTable coids = this.pf.GetCoids(this.Constring);
				try
				{
					foreach (object obj in coids.Rows)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(obj);
						int num = Conversions.ToInteger(NewLateBinding.LateIndexGet(objectValue, new object[] { "companyid" }, null));
						string text = Conversions.ToString(NewLateBinding.LateIndexGet(objectValue, new object[] { "Company" }, null));
						bool flag = this.pf.IsUserAdminCreated(num, this.Constring);
						if (!flag)
						{
							PasswordForm passwordForm = new PasswordForm();
							passwordForm.coname = "";
							bool flag2 = passwordForm.ShowDialog() == DialogResult.OK;
							if (flag2)
							{
								this.publicfunction.SaveCredentials("Admin", this.publicfunction.Encrypt(passwordForm.EnteredPassword, Conversions.ToString(num)), true, true, "", true, "Default Admin", Convert.ToInt32(DateTime.Today.ToString("yyyyMMdd")), "Default", this.Constring, num);
								MessageBox.Show("Admin password set.");
							}
							else
							{
								MessageBox.Show("Password entry cancelled.");
							}
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
			catch (Exception ex)
			{
				MessageBox.Show("Admin user creation error. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x000B8E2C File Offset: 0x000B702C
		private string[] GetComapnyID(string search, string[] strArr)
		{
			SqlConnection sqlConnection = new SqlConnection(this.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectCompanyByName";
			sqlCommand.Parameters.AddWithValue("search", search);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			string[] array;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				strArr[0] = dataRow["Company"].ToString();
				strArr[1] = dataRow["CompanyID"].ToString();
				array = strArr;
			}
			else
			{
				array = strArr;
			}
			return array;
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x000B8ED8 File Offset: 0x000B70D8
		private void cboCompany_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				bool flag = Information.IsNothing(RuntimeHelpers.GetObjectValue(this.cboCompany.SelectedValue));
				if (!flag)
				{
					this.coid = Conversions.ToInteger(this.cboCompany.SelectedValue);
					this.companyname = this.cboCompany.Text;
					this.LoadBranches();
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x000B8F58 File Offset: 0x000B7158
		private void Button3_Click(object sender, EventArgs e)
		{
			try
			{
				string[] array = new string[2];
				array = this.GetComapnyID(this.cboCompany.Text, array);
				bool flag = Information.IsNothing(array[0]);
				if (flag)
				{
					MessageBox.Show("Company not found.");
				}
				else
				{
					this.coid = Convert.ToInt32(array[1]);
					this.LoadBranches();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading branches. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600135B RID: 4955 RVA: 0x000B8FEC File Offset: 0x000B71EC
		private bool CheckIfLoggedIn()
		{
			SqlConnection sqlConnection = new SqlConnection(this.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CheckLogin";
			sqlCommand.Parameters.AddWithValue("coid", this.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
			sqlCommand.Parameters.AddWithValue("username", this.username);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			bool flag3;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				bool flag2 = Convert.ToInt32(RuntimeHelpers.GetObjectValue(dataRow["login_status"])) == 1;
				flag3 = flag2;
			}
			else
			{
				flag3 = false;
			}
			return flag3;
		}

		// Token: 0x0600135C RID: 4956 RVA: 0x000B90D0 File Offset: 0x000B72D0
		private void EffectLogin()
		{
			SqlConnection sqlConnection = new SqlConnection(this.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "EffectLogin";
			sqlCommand.Parameters.AddWithValue("coid", this.coid);
			sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
			sqlCommand.Parameters.AddWithValue("username", this.username);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x000B918C File Offset: 0x000B738C
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			try
			{
				bool flag = this.useManagedLogins == 1;
				if (flag)
				{
					SqlConnection sqlConnection = new SqlConnection(this.Constring);
					SqlCommand sqlCommand = sqlConnection.CreateCommand();
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.CommandText = "EffectLogoff";
					sqlCommand.Parameters.AddWithValue("coid", this.coid);
					sqlCommand.Parameters.AddWithValue("branch", this.cboBranch.Text);
					sqlCommand.Parameters.AddWithValue("username", this.txtUsername.Text);
					using (sqlConnection)
					{
						sqlConnection.Open();
						sqlCommand.ExecuteNonQuery();
						sqlConnection.Close();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error closing form. Detail: " + ex.Message);
			}
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x000B9294 File Offset: 0x000B7494
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		private void Label7_Click(object sender, EventArgs e)
		{
			checked
			{
				try
				{
					this.dbconn_count++;
					bool flag = this.dbconn_count == 5;
					if (flag)
					{
						DBConnections dbconnections = new DBConnections();
						dbconnections.ShowDialog();
						ProjectData.EndApp();
					}
				}
				catch (Exception ex)
				{
				}
			}
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x00002A30 File Offset: 0x00000C30
		private void txtUsername_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06001360 RID: 4960 RVA: 0x000B92F8 File Offset: 0x000B74F8
		private void Button4_Click(object sender, EventArgs e)
		{
			try
			{
				DialogNumeric dialogNumeric = new DialogNumeric();
				bool flag = dialogNumeric.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					this.txtUsername.Text = dialogNumeric.lblamt.Text;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Keypad error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001361 RID: 4961 RVA: 0x000B936C File Offset: 0x000B756C
		private void Button5_Click(object sender, EventArgs e)
		{
			try
			{
				DialogNumeric dialogNumeric = new DialogNumeric();
				bool flag = dialogNumeric.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					this.txtPwd.Text = dialogNumeric.lblamt.Text;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Keypad error. Details: " + ex.Message);
			}
		}

		// Token: 0x06001362 RID: 4962 RVA: 0x000B93E0 File Offset: 0x000B75E0
		private void Button6_Click(object sender, EventArgs e)
		{
			try
			{
				About about = new About();
				about.ShowDialog(this);
				about.Dispose();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading About page. Detail: " + ex.Message);
			}
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x000B943C File Offset: 0x000B763C
		private void RunExecuteDatabaseBackup()
		{
			Thread thread = new Thread(new ThreadStart(this.LongRunningTask));
			thread.Start();
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x000B9464 File Offset: 0x000B7664
		private void LongRunningTask()
		{
			try
			{
				string constring = this.Constring;
				string text = string.Concat(new string[]
				{
					"\\\\",
					this.publicfunction.GetServerName(constring),
					"\\c$\\Quantum\\DBBackup",
					this.coid.ToString(),
					this.branch.ToString()
				});
				bool flag = !Directory.Exists(text);
				if (flag)
				{
					Directory.CreateDirectory(text);
				}
				string text2 = "DatabaseBackup_" + DateTime.Now.ToString("yyyyMMdd") + ".bak";
				string text3 = Path.Combine(text, text2);
				bool flag2 = File.Exists(text3);
				if (!flag2)
				{
					string databaseName = this.publicfunction.GetDatabaseName(constring);
					using (SqlConnection sqlConnection = new SqlConnection(constring))
					{
						string text4 = string.Format("BACKUP DATABASE {0} TO DISK = '{1}'", databaseName, text3);
						using (SqlCommand sqlCommand = new SqlCommand(text4, sqlConnection))
						{
							sqlConnection.Open();
							sqlCommand.ExecuteNonQuery();
							sqlConnection.Close();
						}
					}
					MessageBox.Show("Database backup completed successfully!");
					this.publicfunction.DeleteOldBackupFiles(text, 3);
				}
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x000B95F8 File Offset: 0x000B77F8
		private void SetAdditionalSettings()
		{
			DataTable additionalSettings = this.pf.GetAdditionalSettings(this.Constring, this.coid, this.branch);
			bool flag = additionalSettings.Rows.Count > 0;
			if (flag)
			{
				DataRow dataRow = additionalSettings.Rows[0];
				this.serialNumberName = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["SerialNumberName"])), "", RuntimeHelpers.GetObjectValue(dataRow["SerialNumberName"])));
				this.ShowOrderNo = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["ShowOrderNo"])), 0, RuntimeHelpers.GetObjectValue(dataRow["ShowOrderNo"])));
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x06001368 RID: 4968 RVA: 0x000BA4B1 File Offset: 0x000B86B1
		// (set) Token: 0x06001369 RID: 4969 RVA: 0x000BA4BB File Offset: 0x000B86BB
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000709 RID: 1801
		// (get) Token: 0x0600136A RID: 4970 RVA: 0x000BA4C4 File Offset: 0x000B86C4
		// (set) Token: 0x0600136B RID: 4971 RVA: 0x000BA4D0 File Offset: 0x000B86D0
		internal virtual TextBox txtUsername
		{
			[CompilerGenerated]
			get
			{
				return this._txtUsername;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.txtUsername_Enter);
				TextBox textBox = this._txtUsername;
				if (textBox != null)
				{
					textBox.Enter -= eventHandler;
				}
				this._txtUsername = value;
				textBox = this._txtUsername;
				if (textBox != null)
				{
					textBox.Enter += eventHandler;
				}
			}
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x0600136C RID: 4972 RVA: 0x000BA513 File Offset: 0x000B8713
		// (set) Token: 0x0600136D RID: 4973 RVA: 0x000BA520 File Offset: 0x000B8720
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

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x0600136E RID: 4974 RVA: 0x000BA563 File Offset: 0x000B8763
		// (set) Token: 0x0600136F RID: 4975 RVA: 0x000BA56D File Offset: 0x000B876D
		internal virtual TextBox txtPwd
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x06001370 RID: 4976 RVA: 0x000BA576 File Offset: 0x000B8776
		// (set) Token: 0x06001371 RID: 4977 RVA: 0x000BA580 File Offset: 0x000B8780
		internal virtual Label Label2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x06001372 RID: 4978 RVA: 0x000BA589 File Offset: 0x000B8789
		// (set) Token: 0x06001373 RID: 4979 RVA: 0x000BA594 File Offset: 0x000B8794
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

		// Token: 0x1700070E RID: 1806
		// (get) Token: 0x06001374 RID: 4980 RVA: 0x000BA5D7 File Offset: 0x000B87D7
		// (set) Token: 0x06001375 RID: 4981 RVA: 0x000BA5E1 File Offset: 0x000B87E1
		internal virtual Label Label3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700070F RID: 1807
		// (get) Token: 0x06001376 RID: 4982 RVA: 0x000BA5EA File Offset: 0x000B87EA
		// (set) Token: 0x06001377 RID: 4983 RVA: 0x000BA5F4 File Offset: 0x000B87F4
		internal virtual Label lblerr
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000710 RID: 1808
		// (get) Token: 0x06001378 RID: 4984 RVA: 0x000BA5FD File Offset: 0x000B87FD
		// (set) Token: 0x06001379 RID: 4985 RVA: 0x000BA607 File Offset: 0x000B8807
		internal virtual ComboBox cboBranch
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x0600137A RID: 4986 RVA: 0x000BA610 File Offset: 0x000B8810
		// (set) Token: 0x0600137B RID: 4987 RVA: 0x000BA61A File Offset: 0x000B881A
		internal virtual Label Label4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x0600137C RID: 4988 RVA: 0x000BA623 File Offset: 0x000B8823
		// (set) Token: 0x0600137D RID: 4989 RVA: 0x000BA62D File Offset: 0x000B882D
		internal virtual Label Label5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000713 RID: 1811
		// (get) Token: 0x0600137E RID: 4990 RVA: 0x000BA636 File Offset: 0x000B8836
		// (set) Token: 0x0600137F RID: 4991 RVA: 0x000BA640 File Offset: 0x000B8840
		internal virtual ComboBox cboMode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000714 RID: 1812
		// (get) Token: 0x06001380 RID: 4992 RVA: 0x000BA649 File Offset: 0x000B8849
		// (set) Token: 0x06001381 RID: 4993 RVA: 0x000BA653 File Offset: 0x000B8853
		internal virtual Label Label6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06001382 RID: 4994 RVA: 0x000BA65C File Offset: 0x000B885C
		// (set) Token: 0x06001383 RID: 4995 RVA: 0x000BA668 File Offset: 0x000B8868
		internal virtual ComboBox cboCompany
		{
			[CompilerGenerated]
			get
			{
				return this._cboCompany;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.cboCompany_SelectedIndexChanged);
				ComboBox comboBox = this._cboCompany;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged -= eventHandler;
				}
				this._cboCompany = value;
				comboBox = this._cboCompany;
				if (comboBox != null)
				{
					comboBox.SelectedIndexChanged += eventHandler;
				}
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06001384 RID: 4996 RVA: 0x000BA6AB File Offset: 0x000B88AB
		// (set) Token: 0x06001385 RID: 4997 RVA: 0x000BA6B8 File Offset: 0x000B88B8
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

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06001386 RID: 4998 RVA: 0x000BA6FB File Offset: 0x000B88FB
		// (set) Token: 0x06001387 RID: 4999 RVA: 0x000BA708 File Offset: 0x000B8908
		internal virtual Label Label7
		{
			[CompilerGenerated]
			get
			{
				return this._Label7;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Label7_Click);
				Label label = this._Label7;
				if (label != null)
				{
					label.Click -= eventHandler;
				}
				this._Label7 = value;
				label = this._Label7;
				if (label != null)
				{
					label.Click += eventHandler;
				}
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06001388 RID: 5000 RVA: 0x000BA74B File Offset: 0x000B894B
		// (set) Token: 0x06001389 RID: 5001 RVA: 0x000BA755 File Offset: 0x000B8955
		internal virtual Label Label8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x0600138A RID: 5002 RVA: 0x000BA75E File Offset: 0x000B895E
		// (set) Token: 0x0600138B RID: 5003 RVA: 0x000BA768 File Offset: 0x000B8968
		internal virtual Button Button4
		{
			[CompilerGenerated]
			get
			{
				return this._Button4;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button4_Click);
				Button button = this._Button4;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button4 = value;
				button = this._Button4;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x0600138C RID: 5004 RVA: 0x000BA7AB File Offset: 0x000B89AB
		// (set) Token: 0x0600138D RID: 5005 RVA: 0x000BA7B8 File Offset: 0x000B89B8
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

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x0600138E RID: 5006 RVA: 0x000BA7FB File Offset: 0x000B89FB
		// (set) Token: 0x0600138F RID: 5007 RVA: 0x000BA808 File Offset: 0x000B8A08
		internal virtual Button Button6
		{
			[CompilerGenerated]
			get
			{
				return this._Button6;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Button6_Click);
				Button button = this._Button6;
				if (button != null)
				{
					button.Click -= eventHandler;
				}
				this._Button6 = value;
				button = this._Button6;
				if (button != null)
				{
					button.Click += eventHandler;
				}
			}
		}

		// Token: 0x04000909 RID: 2313
		public int QRCodeSize;

		// Token: 0x0400090A RID: 2314
		public int ReceiptSpacingSize;

		// Token: 0x0400090B RID: 2315
		public int isEditable;

		// Token: 0x0400090C RID: 2316
		public decimal tipamt;

		// Token: 0x0400090D RID: 2317
		public string Constring;

		// Token: 0x0400090E RID: 2318
		private int dbconn_count;

		// Token: 0x0400090F RID: 2319
		private PublicFunctions publicfunction;

		// Token: 0x04000910 RID: 2320
		public bool IsAdmin;

		// Token: 0x04000911 RID: 2321
		public bool IsSupervisor;

		// Token: 0x04000912 RID: 2322
		public string username;

		// Token: 0x04000913 RID: 2323
		public string StockValuation;

		// Token: 0x04000914 RID: 2324
		public int newProdtID;

		// Token: 0x04000915 RID: 2325
		public string newProdtCode;

		// Token: 0x04000916 RID: 2326
		public int License;

		// Token: 0x04000917 RID: 2327
		public string BusType;

		// Token: 0x04000918 RID: 2328
		public string PrinterName;

		// Token: 0x04000919 RID: 2329
		public int PrintReceipt;

		// Token: 0x0400091A RID: 2330
		public int PrintInvoice;

		// Token: 0x0400091B RID: 2331
		public int BarCode;

		// Token: 0x0400091C RID: 2332
		public int coid;

		// Token: 0x0400091D RID: 2333
		public string branch;

		// Token: 0x0400091E RID: 2334
		public int NegativeStock;

		// Token: 0x0400091F RID: 2335
		public int shiftdate;

		// Token: 0x04000920 RID: 2336
		public int ReceiptSize80;

		// Token: 0x04000921 RID: 2337
		public int FiscalcomPortNum;

		// Token: 0x04000922 RID: 2338
		public int FiscalcomPortSpeed;

		// Token: 0x04000923 RID: 2339
		public int PrintFiscal;

		// Token: 0x04000924 RID: 2340
		public string ChangePaymentMethod;

		// Token: 0x04000925 RID: 2341
		public decimal MarkUp;

		// Token: 0x04000926 RID: 2342
		public string SearchCustomer;

		// Token: 0x04000927 RID: 2343
		public int SearchCustomerEntryno;

		// Token: 0x04000928 RID: 2344
		public int CollectEcocashDetails;

		// Token: 0x04000929 RID: 2345
		public int TillPointPriceChange;

		// Token: 0x0400092A RID: 2346
		public int tillchangeprice;

		// Token: 0x0400092B RID: 2347
		public string PrinterCable;

		// Token: 0x0400092C RID: 2348
		public string ReceiptFootnote;

		// Token: 0x0400092D RID: 2349
		public int IsWarehouse;

		// Token: 0x0400092E RID: 2350
		public DataTable SelectedBatch;

		// Token: 0x0400092F RID: 2351
		public int DefaultSearchDesc;

		// Token: 0x04000930 RID: 2352
		public int OpenImpReports;

		// Token: 0x04000931 RID: 2353
		public int ShowLowStockAtStartUp;

		// Token: 0x04000932 RID: 2354
		public int AllowTellerToViewStockBalances;

		// Token: 0x04000933 RID: 2355
		public int ReceiptDisplayPaymentMethod;

		// Token: 0x04000934 RID: 2356
		public int UseReceiptDisplay;

		// Token: 0x04000935 RID: 2357
		public int OnlineSearchOptimised;

		// Token: 0x04000936 RID: 2358
		public int ShowPaymentMethodsOnReceipt;

		// Token: 0x04000937 RID: 2359
		public int NumOfReceiptsPrint;

		// Token: 0x04000938 RID: 2360
		public int ChangeToWholesalePriceForQty;

		// Token: 0x04000939 RID: 2361
		public int IsWholesaleShop;

		// Token: 0x0400093A RID: 2362
		public int AllowSalesonComputer;

		// Token: 0x0400093B RID: 2363
		public DataTable PendingItemsDAT;

		// Token: 0x0400093C RID: 2364
		public string custid;

		// Token: 0x0400093D RID: 2365
		public string suppliername;

		// Token: 0x0400093E RID: 2366
		public int ShowSpecialPrice;

		// Token: 0x0400093F RID: 2367
		public string companyname;

		// Token: 0x04000940 RID: 2368
		public int showproductconversion;

		// Token: 0x04000941 RID: 2369
		public int DateChange;

		// Token: 0x04000942 RID: 2370
		public int backdatevalue;

		// Token: 0x04000943 RID: 2371
		public int DONOTLinkProductCreditWithInvoice;

		// Token: 0x04000944 RID: 2372
		public int ConsultantSalesOnly;

		// Token: 0x04000945 RID: 2373
		public DataTable datPriceBranches;

		// Token: 0x04000946 RID: 2374
		public int useManagedLogins;

		// Token: 0x04000947 RID: 2375
		public string lastBranchLoggedin;

		// Token: 0x04000948 RID: 2376
		public int AllowInvDiscount;

		// Token: 0x04000949 RID: 2377
		public int UseCollections;

		// Token: 0x0400094A RID: 2378
		public DataTable allBranches;

		// Token: 0x0400094B RID: 2379
		public string basecurrency;

		// Token: 0x0400094C RID: 2380
		public int isRestaurant;

		// Token: 0x0400094D RID: 2381
		public int DiscountApproved;

		// Token: 0x0400094E RID: 2382
		public decimal DiscountApprovedPerc;

		// Token: 0x0400094F RID: 2383
		public decimal DiscountApprovedAmt;

		// Token: 0x04000950 RID: 2384
		public bool discountApprovedIsPerc;

		// Token: 0x04000951 RID: 2385
		public bool discountApprovedIncrease;

		// Token: 0x04000952 RID: 2386
		public string Approvedby;

		// Token: 0x04000953 RID: 2387
		public int PricesAreAfterTax;

		// Token: 0x04000954 RID: 2388
		public int FiscalEltrade;

		// Token: 0x04000955 RID: 2389
		public int FiscalRevmax;

		// Token: 0x04000956 RID: 2390
		public int DiscountLimitPayMethods;

		// Token: 0x04000957 RID: 2391
		public int DiscountPayMethod;

		// Token: 0x04000958 RID: 2392
		public string RevmaxDeviceSerial;

		// Token: 0x04000959 RID: 2393
		public int DiscountEditingAllowed;

		// Token: 0x0400095A RID: 2394
		public int InvDiscountEditingAllowed;

		// Token: 0x0400095B RID: 2395
		public int RecordConsultant;

		// Token: 0x0400095C RID: 2396
		public int AllowAccountSales;

		// Token: 0x0400095D RID: 2397
		public DataTable MultiPayMethodsDAT;

		// Token: 0x0400095E RID: 2398
		public decimal Multipay_amtpaid;

		// Token: 0x0400095F RID: 2399
		private PublicFunctions pf;

		// Token: 0x04000960 RID: 2400
		public decimal FSBarcode;

		// Token: 0x04000961 RID: 2401
		public decimal FSPrice;

		// Token: 0x04000962 RID: 2402
		public decimal FSDesc;

		// Token: 0x04000963 RID: 2403
		public decimal FSCompany;

		// Token: 0x04000964 RID: 2404
		public int FSBarcodesymbology;

		// Token: 0x04000965 RID: 2405
		public int FSStartingPoint;

		// Token: 0x04000966 RID: 2406
		public Revmaxlib myrevmax;

		// Token: 0x04000967 RID: 2407
		public int OtherProductDetail;

		// Token: 0x04000968 RID: 2408
		public string OtherDetail;

		// Token: 0x04000969 RID: 2409
		public int ReceiptFontSize;

		// Token: 0x0400096A RID: 2410
		public int FiscalEltradeESD;

		// Token: 0x0400096B RID: 2411
		public int istouchscreen;

		// Token: 0x0400096C RID: 2412
		public int usingTables;

		// Token: 0x0400096D RID: 2413
		public int usingBarcodePrintingScale;

		// Token: 0x0400096E RID: 2414
		public int BarcodePrintingScaleWeight;

		// Token: 0x0400096F RID: 2415
		public int BarcodePrintingScalePrice;

		// Token: 0x04000970 RID: 2416
		public int ReceiptsOptional;

		// Token: 0x04000971 RID: 2417
		public int SHowCustomersInSalesForm;

		// Token: 0x04000972 RID: 2418
		public int DecimalPlaces;

		// Token: 0x04000973 RID: 2419
		public int CalcBackwards;

		// Token: 0x04000974 RID: 2420
		public int PrintToFile;

		// Token: 0x04000975 RID: 2421
		public string PrintFilePath;

		// Token: 0x04000976 RID: 2422
		public int showfooter;

		// Token: 0x04000977 RID: 2423
		public string FiscalEltradeESDSerial;

		// Token: 0x04000978 RID: 2424
		public int SelectA4InvatPOS;

		// Token: 0x04000979 RID: 2425
		public DataTable datSelectedCategories;

		// Token: 0x0400097A RID: 2426
		public DataTable datSelectedCategoriesStockTake;

		// Token: 0x0400097B RID: 2427
		public string defaultReceiptPrinter;

		// Token: 0x0400097C RID: 2428
		public string defaultSecondaryPrinter;

		// Token: 0x0400097D RID: 2429
		public string defaultSecondaryPrinterCaption;

		// Token: 0x0400097E RID: 2430
		public int btnFontSize;

		// Token: 0x0400097F RID: 2431
		public int btnSpace;

		// Token: 0x04000980 RID: 2432
		public int btnHeight;

		// Token: 0x04000981 RID: 2433
		public int btnWidth;

		// Token: 0x04000982 RID: 2434
		public int btnCountperLine;

		// Token: 0x04000983 RID: 2435
		public int HasSecondScreen;

		// Token: 0x04000984 RID: 2436
		public DataTable salesdatagrid;

		// Token: 0x04000985 RID: 2437
		public string AdvertPath;

		// Token: 0x04000986 RID: 2438
		public int UseConnectedScale;

		// Token: 0x04000987 RID: 2439
		public decimal tare;

		// Token: 0x04000988 RID: 2440
		public int ConnectedScalePortNum;

		// Token: 0x04000989 RID: 2441
		public int DontAutoAppendAfterBarcodeSearch;

		// Token: 0x0400098A RID: 2442
		private string osk;

		// Token: 0x0400098B RID: 2443
		public int BarFastExchange;

		// Token: 0x0400098C RID: 2444
		public int UseApprovals;

		// Token: 0x0400098D RID: 2445
		public int DisableQuotations;

		// Token: 0x0400098E RID: 2446
		public string pendinginv_paymethodid;

		// Token: 0x0400098F RID: 2447
		public int DefaultSellingQty;

		// Token: 0x04000990 RID: 2448
		public string InvoiceHeaderText;

		// Token: 0x04000991 RID: 2449
		public int PrintBarcodeInvNumber;

		// Token: 0x04000992 RID: 2450
		public int DontShowQuotationsOnSalesForm;

		// Token: 0x04000993 RID: 2451
		public decimal calcLxWTOTAL;

		// Token: 0x04000994 RID: 2452
		public decimal calcLxWLength;

		// Token: 0x04000995 RID: 2453
		public decimal calcLxWWidth;

		// Token: 0x04000996 RID: 2454
		public int autoBreakCase;

		// Token: 0x04000997 RID: 2455
		public int BillTrips;

		// Token: 0x04000998 RID: 2456
		public int useprintercategories;

		// Token: 0x04000999 RID: 2457
		public int AllowDirectPriceEditing;

		// Token: 0x0400099A RID: 2458
		public DataGridView dgvQuotations;

		// Token: 0x0400099B RID: 2459
		public int openFromQuotes;

		// Token: 0x0400099C RID: 2460
		public int autoOpenSalesForm;

		// Token: 0x0400099D RID: 2461
		public int quotationnumber;

		// Token: 0x0400099E RID: 2462
		public int useOldPrintingService;

		// Token: 0x0400099F RID: 2463
		public string receipt_copy_name;

		// Token: 0x040009A0 RID: 2464
		public decimal qtypurchased;

		// Token: 0x040009A1 RID: 2465
		public string supplierselected;

		// Token: 0x040009A2 RID: 2466
		public int hascustomerdisplayvfd;

		// Token: 0x040009A3 RID: 2467
		public string customerdisplayvfdMessage;

		// Token: 0x040009A4 RID: 2468
		public string customerdisplayCOMPORT;

		// Token: 0x040009A5 RID: 2469
		public int IsBlindCashUp;

		// Token: 0x040009A6 RID: 2470
		public decimal FSYconame;

		// Token: 0x040009A7 RID: 2471
		public decimal FSYbarcode;

		// Token: 0x040009A8 RID: 2472
		public decimal FSYbarcodetext;

		// Token: 0x040009A9 RID: 2473
		public decimal FSYprice;

		// Token: 0x040009AA RID: 2474
		public decimal FSYDesc;

		// Token: 0x040009AB RID: 2475
		public decimal FSYDescLineLen;

		// Token: 0x040009AC RID: 2476
		public string selectedbactchnum;

		// Token: 0x040009AD RID: 2477
		public int selectedexpirydate;

		// Token: 0x040009AE RID: 2478
		public int approve_till_void;

		// Token: 0x040009AF RID: 2479
		public bool approved;

		// Token: 0x040009B0 RID: 2480
		public int inv_template_normal;

		// Token: 0x040009B1 RID: 2481
		public int inv_template_pharma;

		// Token: 0x040009B2 RID: 2482
		public int inv_template_incotex;

		// Token: 0x040009B3 RID: 2483
		public int inv_template_revmax;

		// Token: 0x040009B4 RID: 2484
		public int inv_template_lea;

		// Token: 0x040009B5 RID: 2485
		public int inv_template_tongaat;

		// Token: 0x040009B6 RID: 2486
		public int deposits_inuse;

		// Token: 0x040009B7 RID: 2487
		public int deposits_1dayvalid;

		// Token: 0x040009B8 RID: 2488
		public int FSYPriceBold;

		// Token: 0x040009B9 RID: 2489
		public int FSYDescBold;

		// Token: 0x040009BA RID: 2490
		public int FSYConameBold;

		// Token: 0x040009BB RID: 2491
		public int ShowCostPrice;

		// Token: 0x040009BC RID: 2492
		public bool FirstRunStockTake;

		// Token: 0x040009BD RID: 2493
		public decimal MaxDiscPerc;

		// Token: 0x040009BE RID: 2494
		public int ConsultantDefaultToUsername;

		// Token: 0x040009BF RID: 2495
		public string new_consultant;

		// Token: 0x040009C0 RID: 2496
		public string receipt_template;

		// Token: 0x040009C1 RID: 2497
		public int DisableEditingPendingInv;

		// Token: 0x040009C2 RID: 2498
		public int ShiftClosedUseNExtDay;

		// Token: 0x040009C3 RID: 2499
		public string InterfacedFiscalSaveas;

		// Token: 0x040009C4 RID: 2500
		public string ref2;

		// Token: 0x040009C5 RID: 2501
		public int pendinginvoice_entryno;

		// Token: 0x040009C6 RID: 2502
		public int pendinginvoice_ref;

		// Token: 0x040009C7 RID: 2503
		public bool VerificationWeightOK;

		// Token: 0x040009C8 RID: 2504
		public int RevmaxTest;

		// Token: 0x040009C9 RID: 2505
		public int UsePriceMatrix;

		// Token: 0x040009CA RID: 2506
		public int DailyDBBackUp;

		// Token: 0x040009CB RID: 2507
		public int inv_template_FDMS;

		// Token: 0x040009CC RID: 2508
		public int inv_template_GetPro;

		// Token: 0x040009CD RID: 2509
		public int isZimraVirtFiscal;

		// Token: 0x040009CE RID: 2510
		public string serialNumberName;

		// Token: 0x040009CF RID: 2511
		public DataTable datSerials;

		// Token: 0x040009D0 RID: 2512
		public DataTable datSerialsSelect4Sales;

		// Token: 0x040009D1 RID: 2513
		public int kduID;

		// Token: 0x040009D2 RID: 2514
		public int ShowOrderNo;

		// Token: 0x040009D3 RID: 2515
		public int inv_template_Binum;

		// Token: 0x040009D4 RID: 2516
		public int inv_template_Farhan;

		// Token: 0x040009D5 RID: 2517
		public int hidevat;

		// Token: 0x040009D6 RID: 2518
		public int scaleType;

		// Token: 0x040009D7 RID: 2519
		public bool receiveSerialPortData;

		// Token: 0x040009D8 RID: 2520
		public int serialRestrictQtyTextBox;

		// Token: 0x040009D9 RID: 2521
		public DataTable AdditionalSettingsDAT;

		// Token: 0x040009DA RID: 2522
		public int usePacketSizes;

		// Token: 0x040009DB RID: 2523
		public bool isbranch;

		// Token: 0x040009DC RID: 2524
		public int receipt_logo_space;
	}
}
