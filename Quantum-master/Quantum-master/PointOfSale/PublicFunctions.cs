using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using ClosedXML.Excel;
using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using Zen.Barcode;

namespace PointOfSale
{
	// Token: 0x02000178 RID: 376
	public class PublicFunctions
	{
		// Token: 0x060036D6 RID: 14038 RVA: 0x001D97B0 File Offset: 0x001D79B0
		public string Encrypt(string clearText, string SchoolID)
		{
			string text = "gRACE" + SchoolID + "gLORY";
			byte[] bytes = Encoding.Unicode.GetBytes(clearText);
			using (Aes aes = Aes.Create())
			{
				Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(text, new byte[]
				{
					73, 118, 97, 110, 32, 77, 101, 100, 118, 101,
					100, 101, 118
				});
				aes.Key = rfc2898DeriveBytes.GetBytes(32);
				aes.IV = rfc2898DeriveBytes.GetBytes(16);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(bytes, 0, bytes.Length);
						cryptoStream.Close();
					}
					clearText = Convert.ToBase64String(memoryStream.ToArray());
				}
			}
			return clearText;
		}

		// Token: 0x060036D7 RID: 14039 RVA: 0x001D98B4 File Offset: 0x001D7AB4
		public string Decrypt(string cipherText, string SchoolID)
		{
			string text = "gRACE" + SchoolID + "gLORY";
			byte[] array = Convert.FromBase64String(cipherText);
			using (Aes aes = Aes.Create())
			{
				Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(text, new byte[]
				{
					73, 118, 97, 110, 32, 77, 101, 100, 118, 101,
					100, 101, 118
				});
				aes.Key = rfc2898DeriveBytes.GetBytes(32);
				aes.IV = rfc2898DeriveBytes.GetBytes(16);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(array, 0, array.Length);
						cryptoStream.Close();
					}
					cipherText = Encoding.Unicode.GetString(memoryStream.ToArray());
				}
			}
			return cipherText;
		}

		// Token: 0x060036D8 RID: 14040 RVA: 0x001D99B8 File Offset: 0x001D7BB8
		public bool CheckReorderLevel(string con)
		{
			bool flag = false;
			SqlConnection sqlConnection = new SqlConnection(con);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CheckReorderLevel";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag2 = num > 0;
			bool flag4;
			if (flag2)
			{
				try
				{
					foreach (object obj in dataTable.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						bool flag3 = Operators.ConditionalCompareObjectLessEqual(dataRow["Diff"], 0, false);
						if (flag3)
						{
							flag = true;
							return flag;
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
				flag4 = flag;
			}
			else
			{
				flag4 = false;
			}
			return flag4;
		}

		// Token: 0x060036D9 RID: 14041 RVA: 0x001D9ADC File Offset: 0x001D7CDC
		public void AddUpdateAppSettings(string key, string value)
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

		// Token: 0x060036DA RID: 14042 RVA: 0x001D9B48 File Offset: 0x001D7D48
		public bool ReadAllSettings()
		{
			NameValueCollection appSettings = ConfigurationManager.AppSettings;
			bool flag = appSettings.Count > 0;
			checked
			{
				bool flag2;
				if (flag)
				{
					foreach (string text in appSettings.AllKeys)
					{
						uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
						if (num <= 2394307230U)
						{
							if (num <= 1352933066U)
							{
								if (num <= 803315905U)
								{
									if (num <= 480680532U)
									{
										if (num <= 225745039U)
										{
											if (num <= 92592120U)
											{
												if (num != 77409194U)
												{
													if (num == 92592120U)
													{
														if (Operators.CompareString(text, "FiscalEltradeESD", false) == 0)
														{
															MyProject.Forms.Form1.FiscalEltradeESD = (int)Math.Round(Conversion.Val(appSettings[text]));
														}
													}
												}
												else if (Operators.CompareString(text, "CalcBackwards", false) == 0)
												{
													MyProject.Forms.Form1.CalcBackwards = (int)Math.Round(Conversion.Val(appSettings[text]));
												}
											}
											else if (num != 223644866U)
											{
												if (num == 225745039U)
												{
													if (Operators.CompareString(text, "DefaultSearchDesc", false) == 0)
													{
														MyProject.Forms.Form1.DefaultSearchDesc = (int)Math.Round(Conversion.Val(appSettings[text]));
													}
												}
											}
											else if (Operators.CompareString(text, "deposits_1dayvalid", false) == 0)
											{
												MyProject.Forms.Form1.deposits_1dayvalid = (int)Math.Round(Conversion.Val(appSettings[text]));
											}
										}
										else if (num <= 311692465U)
										{
											if (num != 251438078U)
											{
												if (num == 311692465U)
												{
													if (Operators.CompareString(text, "BusType", false) == 0)
													{
														MyProject.Forms.Form1.BusType = appSettings[text];
													}
												}
											}
											else if (Operators.CompareString(text, "NumOfReceiptsPrint", false) == 0)
											{
												MyProject.Forms.Form1.NumOfReceiptsPrint = (int)Math.Round(Conversion.Val(appSettings[text]));
											}
										}
										else if (num != 419284064U)
										{
											if (num == 480680532U)
											{
												if (Operators.CompareString(text, "SelectA4InvatPOS", false) == 0)
												{
													MyProject.Forms.Form1.SelectA4InvatPOS = (int)Math.Round(Conversion.Val(appSettings[text]));
												}
											}
										}
										else if (Operators.CompareString(text, "OnlineSearchOptimised", false) == 0)
										{
											MyProject.Forms.Form1.OnlineSearchOptimised = (int)Math.Round(Conversion.Val(appSettings[text]));
										}
									}
									else if (num <= 737990647U)
									{
										if (num <= 498241091U)
										{
											if (num != 481932390U)
											{
												if (num == 498241091U)
												{
													if (Operators.CompareString(text, "SQLServerConnString", false) == 0)
													{
														MyProject.Forms.Form1.Constring = appSettings[text];
													}
												}
											}
											else if (Operators.CompareString(text, "UseReceiptDisplay", false) == 0)
											{
												MyProject.Forms.Form1.UseReceiptDisplay = (int)Math.Round(Conversion.Val(appSettings[text]));
											}
										}
										else if (num != 737051550U)
										{
											if (num == 737990647U)
											{
												if (Operators.CompareString(text, "deposits_inuse", false) == 0)
												{
													MyProject.Forms.Form1.deposits_inuse = (int)Math.Round(Conversion.Val(appSettings[text]));
												}
											}
										}
										else if (Operators.CompareString(text, "usingTables", false) == 0)
										{
											MyProject.Forms.Form1.usingTables = (int)Math.Round(Conversion.Val(appSettings[text]));
										}
									}
									else if (num <= 753816286U)
									{
										if (num != 750631450U)
										{
											if (num == 753816286U)
											{
												if (Operators.CompareString(text, "AllowSalesonComputer", false) == 0)
												{
													MyProject.Forms.Form1.AllowSalesonComputer = (int)Math.Round(Conversion.Val(appSettings[text]));
												}
											}
										}
										else if (Operators.CompareString(text, "usingBarcodePrintingScale", false) == 0)
										{
											MyProject.Forms.Form1.usingBarcodePrintingScale = (int)Math.Round(Conversion.Val(appSettings[text]));
										}
									}
									else if (num != 780568023U)
									{
										if (num == 803315905U)
										{
											if (Operators.CompareString(text, "CollectEcocashDetails", false) == 0)
											{
												MyProject.Forms.Form1.CollectEcocashDetails = (int)Math.Round(Conversion.Val(appSettings[text]));
											}
										}
									}
									else if (Operators.CompareString(text, "BarCode", false) == 0)
									{
										MyProject.Forms.Form1.BarCode = (int)Math.Round(Conversion.Val(appSettings[text]));
									}
								}
								else if (num <= 1019221482U)
								{
									if (num <= 954666724U)
									{
										if (num <= 933761947U)
										{
											if (num != 844134607U)
											{
												if (num == 933761947U)
												{
													if (Operators.CompareString(text, "ConnectedScalePortNum", false) == 0)
													{
														MyProject.Forms.Form1.ConnectedScalePortNum = (int)Math.Round(Conversion.Val(appSettings[text]));
													}
												}
											}
											else if (Operators.CompareString(text, "AllowAccountSales", false) == 0)
											{
												MyProject.Forms.Form1.AllowAccountSales = (int)Math.Round(Conversion.Val(appSettings[text]));
											}
										}
										else if (num != 935194778U)
										{
											if (num == 954666724U)
											{
												if (Operators.CompareString(text, "License", false) == 0)
												{
													MyProject.Forms.Form1.License = (int)Math.Round(Conversion.Val(appSettings[text]));
												}
											}
										}
										else if (Operators.CompareString(text, "DailyDBBackUp", false) == 0)
										{
											MyProject.Forms.Form1.DailyDBBackUp = (int)Math.Round(Conversion.Val(appSettings[text]));
										}
									}
									else if (num <= 985739750U)
									{
										if (num != 962990655U)
										{
											if (num == 985739750U)
											{
												if (Operators.CompareString(text, "ShowCostPrice", false) == 0)
												{
													MyProject.Forms.Form1.ShowCostPrice = (int)Math.Round(Conversion.Val(appSettings[text]));
												}
											}
										}
										else if (Operators.CompareString(text, "InvDiscountEditingAllowed", false) == 0)
										{
											MyProject.Forms.Form1.InvDiscountEditingAllowed = (int)Math.Round(Conversion.Val(appSettings[text]));
										}
									}
									else if (num != 1008957529U)
									{
										if (num == 1019221482U)
										{
											if (Operators.CompareString(text, "FSYprice", false) == 0)
											{
												MyProject.Forms.Form1.FSYprice = new decimal(Conversion.Val(appSettings[text]));
											}
										}
									}
									else if (Operators.CompareString(text, "autoBreakCase", false) == 0)
									{
										MyProject.Forms.Form1.autoBreakCase = (int)Math.Round(Conversion.Val(appSettings[text]));
									}
								}
								else if (num <= 1211117702U)
								{
									if (num <= 1156895675U)
									{
										if (num != 1052055571U)
										{
											if (num == 1156895675U)
											{
												if (Operators.CompareString(text, "PrintInvoice", false) == 0)
												{
													MyProject.Forms.Form1.PrintInvoice = (int)Math.Round(Conversion.Val(appSettings[text]));
												}
											}
										}
										else if (Operators.CompareString(text, "UseConnectedScale", false) == 0)
										{
											MyProject.Forms.Form1.UseConnectedScale = (int)Math.Round(Conversion.Val(appSettings[text]));
										}
									}
									else if (num != 1199129037U)
									{
										if (num == 1211117702U)
										{
											if (Operators.CompareString(text, "inv_template_incotex", false) == 0)
											{
												MyProject.Forms.Form1.inv_template_incotex = (int)Math.Round(Conversion.Val(appSettings[text]));
											}
										}
									}
									else if (Operators.CompareString(text, "OtherProductDetail", false) == 0)
									{
										MyProject.Forms.Form1.OtherProductDetail = (int)Math.Round(Conversion.Val(appSettings[text]));
									}
								}
								else if (num <= 1221328587U)
								{
									if (num != 1213527530U)
									{
										if (num == 1221328587U)
										{
											if (Operators.CompareString(text, "FiscalComPort", false) == 0)
											{
												MyProject.Forms.Form1.FiscalcomPortNum = (int)Math.Round(Conversion.Val(appSettings[text]));
											}
										}
									}
									else if (Operators.CompareString(text, "defaultReceiptPrinter", false) == 0)
									{
										MyProject.Forms.Form1.defaultReceiptPrinter = appSettings[text];
									}
								}
								else if (num != 1228606118U)
								{
									if (num != 1348239648U)
									{
										if (num == 1352933066U)
										{
											if (Operators.CompareString(text, "inv_template_lea", false) == 0)
											{
												MyProject.Forms.Form1.inv_template_lea = (int)Math.Round(Conversion.Val(appSettings[text]));
											}
										}
									}
									else if (Operators.CompareString(text, "DisableQuotations", false) == 0)
									{
										MyProject.Forms.Form1.DisableQuotations = (int)Math.Round(Conversion.Val(appSettings[text]));
									}
								}
								else if (Operators.CompareString(text, "customerdisplayvfdMessage", false) == 0)
								{
									MyProject.Forms.Form1.customerdisplayvfdMessage = appSettings[text];
								}
							}
							else if (num <= 1826094247U)
							{
								if (num <= 1499870393U)
								{
									if (num <= 1424208668U)
									{
										if (num <= 1401311868U)
										{
											if (num != 1356277917U)
											{
												if (num == 1401311868U)
												{
													if (Operators.CompareString(text, "DecimalPlaces", false) == 0)
													{
														MyProject.Forms.Form1.DecimalPlaces = (int)Math.Round(Conversion.Val(appSettings[text]));
													}
												}
											}
											else if (Operators.CompareString(text, "BarFastExchange", false) == 0)
											{
												MyProject.Forms.Form1.BarFastExchange = (int)Math.Round(Conversion.Val(appSettings[text]));
											}
										}
										else if (num != 1405791441U)
										{
											if (num == 1424208668U)
											{
												if (Operators.CompareString(text, "istouchscreen", false) == 0)
												{
													MyProject.Forms.Form1.istouchscreen = (int)Math.Round(Conversion.Val(appSettings[text]));
												}
											}
										}
										else if (Operators.CompareString(text, "UseCollections", false) == 0)
										{
											MyProject.Forms.Form1.UseCollections = (int)Math.Round(Conversion.Val(appSettings[text]));
										}
									}
									else if (num <= 1472831383U)
									{
										if (num != 1446241639U)
										{
											if (num == 1472831383U)
											{
												if (Operators.CompareString(text, "InterfacedFiscalSaveas", false) == 0)
												{
													MyProject.Forms.Form1.InterfacedFiscalSaveas = appSettings[text];
												}
											}
										}
										else if (Operators.CompareString(text, "IsSupervisor", false) == 0)
										{
											MyProject.Forms.Form1.IsSupervisor = Conversion.Val(appSettings[text]) != 0.0;
										}
									}
									else if (num != 1480150972U)
									{
										if (num == 1499870393U)
										{
											if (Operators.CompareString(text, "hascustomerdisplayvfd", false) == 0)
											{
												MyProject.Forms.Form1.hascustomerdisplayvfd = (int)Math.Round(Conversion.Val(appSettings[text]));
											}
										}
									}
									else if (Operators.CompareString(text, "PrinterName", false) == 0)
									{
										MyProject.Forms.Form1.PrinterName = appSettings[text];
									}
								}
								else if (num <= 1550998576U)
								{
									if (num <= 1528832849U)
									{
										if (num != 1511774186U)
										{
											if (num == 1528832849U)
											{
												if (Operators.CompareString(text, "serialRestrictQtyTextBox", false) == 0)
												{
													MyProject.Forms.Form1.serialRestrictQtyTextBox = (int)Math.Round(Conversion.Val(appSettings[text]));
												}
											}
										}
										else if (Operators.CompareString(text, "FiscalRevmax", false) == 0)
										{
											MyProject.Forms.Form1.FiscalRevmax = (int)Math.Round(Conversion.Val(appSettings[text]));
										}
									}
									else if (num != 1544132415U)
									{
										if (num == 1550998576U)
										{
											if (Operators.CompareString(text, "FSYbarcodetext", false) == 0)
											{
												MyProject.Forms.Form1.FSYbarcodetext = new decimal(Conversion.Val(appSettings[text]));
											}
										}
									}
									else if (Operators.CompareString(text, "btnFontSize", false) == 0)
									{
										MyProject.Forms.Form1.btnFontSize = (int)Math.Round(Conversion.Val(appSettings[text]));
									}
								}
								else if (num <= 1661973875U)
								{
									if (num != 1652028607U)
									{
										if (num == 1661973875U)
										{
											if (Operators.CompareString(text, "ShiftClosedUseNExtDay", false) == 0)
											{
												MyProject.Forms.Form1.ShiftClosedUseNExtDay = (int)Math.Round(Conversion.Val(appSettings[text]));
											}
										}
									}
									else if (Operators.CompareString(text, "btnCountPerLine", false) == 0)
									{
										MyProject.Forms.Form1.btnCountperLine = (int)Math.Round(Conversion.Val(appSettings[text]));
									}
								}
								else if (num != 1701654005U)
								{
									if (num != 1803537079U)
									{
										if (num == 1826094247U)
										{
											if (Operators.CompareString(text, "approve_till_void", false) == 0)
											{
												MyProject.Forms.Form1.approve_till_void = (int)Math.Round(Conversion.Val(appSettings[text]));
											}
										}
									}
									else if (Operators.CompareString(text, "HasSecondScreen", false) == 0)
									{
										MyProject.Forms.Form1.HasSecondScreen = (int)Math.Round(Conversion.Val(appSettings[text]));
									}
								}
								else if (Operators.CompareString(text, "inv_template_revmax", false) == 0)
								{
									MyProject.Forms.Form1.inv_template_revmax = (int)Math.Round(Conversion.Val(appSettings[text]));
								}
							}
							else if (num <= 2185725775U)
							{
								if (num <= 2087075844U)
								{
									if (num <= 2012596825U)
									{
										if (num != 1922638184U)
										{
											if (num == 2012596825U)
											{
												if (Operators.CompareString(text, "scaletype", false) == 0)
												{
													MyProject.Forms.Form1.scaleType = (int)Math.Round(Conversion.Val(appSettings[text]));
												}
											}
										}
										else if (Operators.CompareString(text, "btnHeight", false) == 0)
										{
											MyProject.Forms.Form1.btnHeight = (int)Math.Round(Conversion.Val(appSettings[text]));
										}
									}
									else if (num != 2043680535U)
									{
										if (num == 2087075844U)
										{
											if (Operators.CompareString(text, "BillTrips", false) == 0)
											{
												MyProject.Forms.Form1.BillTrips = (int)Math.Round(Conversion.Val(appSettings[text]));
											}
										}
									}
									else if (Operators.CompareString(text, "FSYbarcode", false) == 0)
									{
										MyProject.Forms.Form1.FSYbarcode = new decimal(Conversion.Val(appSettings[text]));
									}
								}
								else if (num <= 2134737710U)
								{
									if (num != 2104038804U)
									{
										if (num == 2134737710U)
										{
											if (Operators.CompareString(text, "PrintBarcodeInvNumber", false) == 0)
											{
												MyProject.Forms.Form1.PrintBarcodeInvNumber = (int)Math.Round(Conversion.Val(appSettings[text]));
											}
										}
									}
									else if (Operators.CompareString(text, "PricesAreAfterTax", false) == 0)
									{
										MyProject.Forms.Form1.PricesAreAfterTax = (int)Math.Round(Conversion.Val(appSettings[text]));
									}
								}
								else if (num != 2155153564U)
								{
									if (num == 2185725775U)
									{
										if (Operators.CompareString(text, "FSBarcodesymbology", false) == 0)
										{
											MyProject.Forms.Form1.FSBarcodesymbology = (int)Math.Round(Conversion.Val(appSettings[text]));
										}
									}
								}
								else if (Operators.CompareString(text, "ReceiptsOptional", false) == 0)
								{
									MyProject.Forms.Form1.ReceiptsOptional = (int)Math.Round(Conversion.Val(appSettings[text]));
								}
							}
							else if (num <= 2252224455U)
							{
								if (num <= 2219792006U)
								{
									if (num != 2188955198U)
									{
										if (num == 2219792006U)
										{
											if (Operators.CompareString(text, "FSBarcode", false) == 0)
											{
												MyProject.Forms.Form1.FSBarcode = new decimal(Conversion.Val(appSettings[text]));
											}
										}
									}
									else if (Operators.CompareString(text, "receipt_template", false) == 0)
									{
										MyProject.Forms.Form1.receipt_template = appSettings[text];
									}
								}
								else if (num != 2228161292U)
								{
									if (num == 2252224455U)
									{
										if (Operators.CompareString(text, "useOldPrintingService", false) == 0)
										{
											MyProject.Forms.Form1.useOldPrintingService = (int)Math.Round(Conversion.Val(appSettings[text]));
										}
									}
								}
								else if (Operators.CompareString(text, "PrintReceipt", false) == 0)
								{
									MyProject.Forms.Form1.PrintReceipt = (int)Math.Round(Conversion.Val(appSettings[text]));
								}
							}
							else if (num <= 2322293914U)
							{
								if (num != 2293044418U)
								{
									if (num == 2322293914U)
									{
										if (Operators.CompareString(text, "ReceiptSize80", false) == 0)
										{
											MyProject.Forms.Form1.ReceiptSize80 = (int)Math.Round(Conversion.Val(appSettings[text]));
										}
									}
								}
								else if (Operators.CompareString(text, "ConsultantSalesOnly", false) == 0)
								{
									MyProject.Forms.Form1.ConsultantSalesOnly = (int)Math.Round(Conversion.Val(appSettings[text]));
								}
							}
							else if (num != 2374032580U)
							{
								if (num != 2383390730U)
								{
									if (num == 2394307230U)
									{
										if (Operators.CompareString(text, "defaultSecondaryPrinterCaption", false) == 0)
										{
											MyProject.Forms.Form1.defaultSecondaryPrinterCaption = appSettings[text];
										}
									}
								}
								else if (Operators.CompareString(text, "IsBlindCashUp", false) == 0)
								{
									MyProject.Forms.Form1.IsBlindCashUp = (int)Math.Round(Conversion.Val(appSettings[text]));
								}
							}
							else if (Operators.CompareString(text, "ShowCustomersInSalesForm", false) == 0)
							{
								MyProject.Forms.Form1.SHowCustomersInSalesForm = (int)Math.Round(Conversion.Val(appSettings[text]));
							}
						}
						else if (num <= 3437206933U)
						{
							if (num <= 2885944953U)
							{
								if (num <= 2633271865U)
								{
									if (num <= 2521501580U)
									{
										if (num <= 2486435758U)
										{
											if (num != 2484966631U)
											{
												if (num == 2486435758U)
												{
													if (Operators.CompareString(text, "ReceiptDisplayPaymentMethod", false) == 0)
													{
														MyProject.Forms.Form1.ReceiptDisplayPaymentMethod = (int)Math.Round(Conversion.Val(appSettings[text]));
													}
												}
											}
											else if (Operators.CompareString(text, "PrintToFile", false) == 0)
											{
												MyProject.Forms.Form1.PrintToFile = (int)Math.Round(Conversion.Val(appSettings[text]));
											}
										}
										else if (num != 2518433310U)
										{
											if (num == 2521501580U)
											{
												if (Operators.CompareString(text, "useprintercategories", false) == 0)
												{
													MyProject.Forms.Form1.useprintercategories = (int)Math.Round(Conversion.Val(appSettings[text]));
												}
											}
										}
										else if (Operators.CompareString(text, "FiscalSpeed", false) == 0)
										{
											MyProject.Forms.Form1.FiscalcomPortSpeed = (int)Math.Round(Conversion.Val(appSettings[text]));
										}
									}
									else if (num <= 2576361236U)
									{
										if (num != 2567664660U)
										{
											if (num == 2576361236U)
											{
												if (Operators.CompareString(text, "ConsultantDefaultToUsername", false) == 0)
												{
													MyProject.Forms.Form1.ConsultantDefaultToUsername = (int)Math.Round(Conversion.Val(appSettings[text]));
												}
											}
										}
										else if (Operators.CompareString(text, "FSStartingPoint", false) == 0)
										{
											MyProject.Forms.Form1.FSStartingPoint = (int)Math.Round(Conversion.Val(appSettings[text]));
										}
									}
									else if (num != 2602455487U)
									{
										if (num == 2633271865U)
										{
											if (Operators.CompareString(text, "receipt_copy_name", false) == 0)
											{
												MyProject.Forms.Form1.receipt_copy_name = appSettings[text];
											}
										}
									}
									else if (Operators.CompareString(text, "inv_template_normal", false) == 0)
									{
										MyProject.Forms.Form1.inv_template_normal = (int)Math.Round(Conversion.Val(appSettings[text]));
									}
								}
								else if (num <= 2814487668U)
								{
									if (num <= 2792845555U)
									{
										if (num != 2741167119U)
										{
											if (num == 2792845555U)
											{
												if (Operators.CompareString(text, "inv_template_GetPro", false) == 0)
												{
													MyProject.Forms.Form1.inv_template_GetPro = (int)Math.Round(Conversion.Val(appSettings[text]));
												}
											}
										}
										else if (Operators.CompareString(text, "FSYConameBold", false) == 0)
										{
											MyProject.Forms.Form1.FSYConameBold = (int)Math.Round(Conversion.Val(appSettings[text]));
										}
									}
									else if (num != 2804703853U)
									{
										if (num == 2814487668U)
										{
											if (Operators.CompareString(text, "UseApprovals", false) == 0)
											{
												MyProject.Forms.Form1.UseApprovals = (int)Math.Round(Conversion.Val(appSettings[text]));
											}
										}
									}
									else if (Operators.CompareString(text, "MarkUp", false) == 0)
									{
										MyProject.Forms.Form1.MarkUp = new decimal(Conversion.Val(appSettings[text]));
									}
								}
								else if (num <= 2843646322U)
								{
									if (num != 2836974556U)
									{
										if (num == 2843646322U)
										{
											if (Operators.CompareString(text, "AllowInvDiscount", false) == 0)
											{
												MyProject.Forms.Form1.AllowInvDiscount = (int)Math.Round(Conversion.Val(appSettings[text]));
											}
										}
									}
									else if (Operators.CompareString(text, "defaultSecondaryPrinter", false) == 0)
									{
										MyProject.Forms.Form1.defaultSecondaryPrinter = appSettings[text];
									}
								}
								else if (num != 2849082193U)
								{
									if (num != 2851688856U)
									{
										if (num == 2885944953U)
										{
											if (Operators.CompareString(text, "btnWidth", false) == 0)
											{
												MyProject.Forms.Form1.btnWidth = (int)Math.Round(Conversion.Val(appSettings[text]));
											}
										}
									}
									else if (Operators.CompareString(text, "ShowSpecialPrice", false) == 0)
									{
										MyProject.Forms.Form1.ShowSpecialPrice = (int)Math.Round(Conversion.Val(appSettings[text]));
									}
								}
								else if (Operators.CompareString(text, "DontShowQuotationsOnSalesForm", false) == 0)
								{
									MyProject.Forms.Form1.DontShowQuotationsOnSalesForm = (int)Math.Round(Conversion.Val(appSettings[text]));
								}
							}
							else if (num <= 3093087795U)
							{
								if (num <= 3060081067U)
								{
									if (num <= 2969403524U)
									{
										if (num != 2924626419U)
										{
											if (num == 2969403524U)
											{
												if (Operators.CompareString(text, "LinkProductCreditWithInvoice", false) == 0)
												{
													MyProject.Forms.Form1.DONOTLinkProductCreditWithInvoice = (int)Math.Round(Conversion.Val(appSettings[text]));
												}
											}
										}
										else if (Operators.CompareString(text, "FSYDescBold", false) == 0)
										{
											MyProject.Forms.Form1.FSYDescBold = (int)Math.Round(Conversion.Val(appSettings[text]));
										}
									}
									else if (num != 3043091058U)
									{
										if (num == 3060081067U)
										{
											if (Operators.CompareString(text, "ShowPaymentMethodsOnReceipt", false) == 0)
											{
												MyProject.Forms.Form1.ShowPaymentMethodsOnReceipt = (int)Math.Round(Conversion.Val(appSettings[text]));
											}
										}
									}
									else if (Operators.CompareString(text, "ShowLowStockAtStartUp", false) == 0)
									{
										MyProject.Forms.Form1.ShowLowStockAtStartUp = (int)Math.Round(Conversion.Val(appSettings[text]));
									}
								}
								else if (num <= 3074824094U)
								{
									if (num != 3062315333U)
									{
										if (num == 3074824094U)
										{
											if (Operators.CompareString(text, "InvoiceHeaderText", false) == 0)
											{
												MyProject.Forms.Form1.InvoiceHeaderText = appSettings[text];
											}
										}
									}
									else if (Operators.CompareString(text, "branch", false) == 0)
									{
										MyProject.Forms.Form1.branch = appSettings[text];
									}
								}
								else if (num != 3078207362U)
								{
									if (num == 3093087795U)
									{
										if (Operators.CompareString(text, "btnSpace", false) == 0)
										{
											MyProject.Forms.Form1.btnSpace = (int)Math.Round(Conversion.Val(appSettings[text]));
										}
									}
								}
								else if (Operators.CompareString(text, "RevmaxDeviceSerial", false) == 0)
								{
									MyProject.Forms.Form1.RevmaxDeviceSerial = Conversions.ToString(Conversion.Val(appSettings[text]));
								}
							}
							else if (num <= 3219247880U)
							{
								if (num <= 3108773349U)
								{
									if (num != 3093292668U)
									{
										if (num == 3108773349U)
										{
											if (Operators.CompareString(text, "TillPointPriceChange", false) == 0)
											{
												MyProject.Forms.Form1.TillPointPriceChange = (int)Math.Round(Conversion.Val(appSettings[text]));
											}
										}
									}
									else if (Operators.CompareString(text, "AdvertPath", false) == 0)
									{
										MyProject.Forms.Form1.AdvertPath = appSettings[text];
									}
								}
								else if (num != 3169213311U)
								{
									if (num == 3219247880U)
									{
										if (Operators.CompareString(text, "FiscalEltrade", false) == 0)
										{
											MyProject.Forms.Form1.FiscalEltrade = (int)Math.Round(Conversion.Val(appSettings[text]));
										}
									}
								}
								else if (Operators.CompareString(text, "FSDesc", false) == 0)
								{
									MyProject.Forms.Form1.FSDesc = new decimal(Conversion.Val(appSettings[text]));
								}
							}
							else if (num <= 3257144795U)
							{
								if (num != 3250649548U)
								{
									if (num == 3257144795U)
									{
										if (Operators.CompareString(text, "ReceiptFootnote", false) == 0)
										{
											MyProject.Forms.Form1.ReceiptFootnote = appSettings[text];
										}
									}
								}
								else if (Operators.CompareString(text, "inv_template_Farhan", false) == 0)
								{
									MyProject.Forms.Form1.inv_template_Farhan = (int)Math.Round(Conversion.Val(appSettings[text]));
								}
							}
							else if (num != 3313801080U)
							{
								if (num != 3343747106U)
								{
									if (num == 3437206933U)
									{
										if (Operators.CompareString(text, "PrintFilePath", false) == 0)
										{
											MyProject.Forms.Form1.PrintFilePath = appSettings[text];
										}
									}
								}
								else if (Operators.CompareString(text, "DiscountEditingAllowed", false) == 0)
								{
									MyProject.Forms.Form1.DiscountEditingAllowed = (int)Math.Round(Conversion.Val(appSettings[text]));
								}
							}
							else if (Operators.CompareString(text, "UsePriceMatrix", false) == 0)
							{
								MyProject.Forms.Form1.UsePriceMatrix = (int)Math.Round(Conversion.Val(appSettings[text]));
							}
						}
						else if (num <= 3796155076U)
						{
							if (num <= 3601161660U)
							{
								if (num <= 3495208848U)
								{
									if (num <= 3465612743U)
									{
										if (num != 3450591029U)
										{
											if (num == 3465612743U)
											{
												if (Operators.CompareString(text, "inv_template_Binum", false) == 0)
												{
													MyProject.Forms.Form1.inv_template_Binum = (int)Math.Round(Conversion.Val(appSettings[text]));
												}
											}
										}
										else if (Operators.CompareString(text, "DontAutoAppend", false) == 0)
										{
											MyProject.Forms.Form1.DontAutoAppendAfterBarcodeSearch = (int)Math.Round(Conversion.Val(appSettings[text]));
										}
									}
									else if (num != 3477610772U)
									{
										if (num == 3495208848U)
										{
											if (Operators.CompareString(text, "StockValuation", false) == 0)
											{
												MyProject.Forms.Form1.StockValuation = appSettings[text];
											}
										}
									}
									else if (Operators.CompareString(text, "IsWarehouse", false) == 0)
									{
										MyProject.Forms.Form1.IsWarehouse = (int)Math.Round(Conversion.Val(appSettings[text]));
									}
								}
								else if (num <= 3557984000U)
								{
									if (num != 3522512316U)
									{
										if (num == 3557984000U)
										{
											if (Operators.CompareString(text, "FSYDesc", false) == 0)
											{
												MyProject.Forms.Form1.FSYDesc = new decimal(Conversion.Val(appSettings[text]));
											}
										}
									}
									else if (Operators.CompareString(text, "ChangePaymentMethod", false) == 0)
									{
										MyProject.Forms.Form1.ChangePaymentMethod = appSettings[text];
									}
								}
								else if (num != 3587951099U)
								{
									if (num == 3601161660U)
									{
										if (Operators.CompareString(text, "NegativeStock", false) == 0)
										{
											MyProject.Forms.Form1.NegativeStock = (int)Math.Round(Conversion.Val(appSettings[text]));
										}
									}
								}
								else if (Operators.CompareString(text, "useManagedLogins", false) == 0)
								{
									MyProject.Forms.Form1.useManagedLogins = (int)Math.Round(Conversion.Val(appSettings[text]));
								}
							}
							else if (num <= 3642896628U)
							{
								if (num <= 3638360293U)
								{
									if (num != 3631075567U)
									{
										if (num == 3638360293U)
										{
											if (Operators.CompareString(text, "BarcodePrintingScalePrice", false) == 0)
											{
												MyProject.Forms.Form1.BarcodePrintingScalePrice = (int)Math.Round(Conversion.Val(appSettings[text]));
											}
										}
									}
									else if (Operators.CompareString(text, "FSPrice", false) == 0)
									{
										MyProject.Forms.Form1.FSPrice = new decimal(Conversion.Val(appSettings[text]));
									}
								}
								else if (num != 3641901687U)
								{
									if (num == 3642896628U)
									{
										if (Operators.CompareString(text, "lastBranchLoggedin", false) == 0)
										{
											MyProject.Forms.Form1.lastBranchLoggedin = Conversions.ToString(Conversion.Val(appSettings[text]));
										}
									}
								}
								else if (Operators.CompareString(text, "showfooter", false) == 0)
								{
									MyProject.Forms.Form1.showfooter = (int)Math.Round(Conversion.Val(appSettings[text]));
								}
							}
							else if (num <= 3696039370U)
							{
								if (num != 3646338003U)
								{
									if (num == 3696039370U)
									{
										if (Operators.CompareString(text, "coid", false) == 0)
										{
											MyProject.Forms.Form1.coid = (int)Math.Round(Conversion.Val(appSettings[text]));
										}
									}
								}
								else if (Operators.CompareString(text, "ReceiptFontSize", false) == 0)
								{
									MyProject.Forms.Form1.ReceiptFontSize = (int)Math.Round(Conversion.Val(appSettings[text]));
								}
							}
							else if (num != 3744629787U)
							{
								if (num != 3746550109U)
								{
									if (num == 3796155076U)
									{
										if (Operators.CompareString(text, "FSYconame", false) == 0)
										{
											MyProject.Forms.Form1.FSYconame = new decimal(Conversion.Val(appSettings[text]));
										}
									}
								}
								else if (Operators.CompareString(text, "inv_template_pharma", false) == 0)
								{
									MyProject.Forms.Form1.inv_template_pharma = (int)Math.Round(Conversion.Val(appSettings[text]));
								}
							}
							else if (Operators.CompareString(text, "DisableEditingPendingInv", false) == 0)
							{
								MyProject.Forms.Form1.DisableEditingPendingInv = (int)Math.Round(Conversion.Val(appSettings[text]));
							}
						}
						else if (num <= 3951015589U)
						{
							if (num <= 3883512974U)
							{
								if (num <= 3853465316U)
								{
									if (num != 3823417475U)
									{
										if (num == 3853465316U)
										{
											if (Operators.CompareString(text, "inv_template_tongaat", false) == 0)
											{
												MyProject.Forms.Form1.inv_template_tongaat = (int)Math.Round(Conversion.Val(appSettings[text]));
											}
										}
									}
									else if (Operators.CompareString(text, "IsWholesaleShop", false) == 0)
									{
										MyProject.Forms.Form1.IsWholesaleShop = (int)Math.Round(Conversion.Val(appSettings[text]));
									}
								}
								else if (num != 3880758202U)
								{
									if (num == 3883512974U)
									{
										if (Operators.CompareString(text, "inv_template_FDMS", false) == 0)
										{
											MyProject.Forms.Form1.inv_template_FDMS = (int)Math.Round(Conversion.Val(appSettings[text]));
										}
									}
								}
								else if (Operators.CompareString(text, "PrintFiscal", false) == 0)
								{
									MyProject.Forms.Form1.PrintFiscal = (int)Math.Round(Conversion.Val(appSettings[text]));
								}
							}
							else if (num <= 3934861049U)
							{
								if (num != 3889397836U)
								{
									if (num == 3934861049U)
									{
										if (Operators.CompareString(text, "DateChange", false) == 0)
										{
											MyProject.Forms.Form1.DateChange = (int)Math.Round(Conversion.Val(appSettings[text]));
										}
									}
								}
								else if (Operators.CompareString(text, "FiscalEltradeESDSerial", false) == 0)
								{
									MyProject.Forms.Form1.FiscalEltradeESDSerial = appSettings[text];
								}
							}
							else if (num != 3939188397U)
							{
								if (num == 3951015589U)
								{
									if (Operators.CompareString(text, "FSCompany", false) == 0)
									{
										MyProject.Forms.Form1.FSCompany = new decimal(Conversion.Val(appSettings[text]));
									}
								}
							}
							else if (Operators.CompareString(text, "AllowTellerToViewStockBalances", false) == 0)
							{
								MyProject.Forms.Form1.AllowTellerToViewStockBalances = (int)Math.Round(Conversion.Val(appSettings[text]));
							}
						}
						else if (num <= 4114661843U)
						{
							if (num <= 4041499104U)
							{
								if (num != 3975489485U)
								{
									if (num == 4041499104U)
									{
										if (Operators.CompareString(text, "AllowDirectPriceEditing", false) == 0)
										{
											MyProject.Forms.Form1.AllowDirectPriceEditing = (int)Math.Round(Conversion.Val(appSettings[text]));
										}
									}
								}
								else if (Operators.CompareString(text, "customerdisplayCOMPORT", false) == 0)
								{
									MyProject.Forms.Form1.customerdisplayCOMPORT = appSettings[text];
								}
							}
							else if (num != 4112607032U)
							{
								if (num == 4114661843U)
								{
									if (Operators.CompareString(text, "ShowOrderNo", false) == 0)
									{
										MyProject.Forms.Form1.ShowOrderNo = (int)Math.Round(Conversion.Val(appSettings[text]));
									}
								}
							}
							else if (Operators.CompareString(text, "ChangeToWholesalePriceForQty", false) == 0)
							{
								MyProject.Forms.Form1.ChangeToWholesalePriceForQty = (int)Math.Round(Conversion.Val(appSettings[text]));
							}
						}
						else if (num <= 4215364867U)
						{
							if (num != 4160031485U)
							{
								if (num == 4215364867U)
								{
									if (Operators.CompareString(text, "ShowProductConversion", false) == 0)
									{
										MyProject.Forms.Form1.showproductconversion = (int)Math.Round(Conversion.Val(appSettings[text]));
									}
								}
							}
							else if (Operators.CompareString(text, "RecordConsultant", false) == 0)
							{
								MyProject.Forms.Form1.RecordConsultant = (int)Math.Round(Conversion.Val(appSettings[text]));
							}
						}
						else if (num != 4221653254U)
						{
							if (num != 4254423757U)
							{
								if (num == 4280602296U)
								{
									if (Operators.CompareString(text, "BarcodePrintingScaleWeight", false) == 0)
									{
										MyProject.Forms.Form1.BarcodePrintingScaleWeight = (int)Math.Round(Conversion.Val(appSettings[text]));
									}
								}
							}
							else if (Operators.CompareString(text, "FSYPriceBold", false) == 0)
							{
								MyProject.Forms.Form1.FSYPriceBold = (int)Math.Round(Conversion.Val(appSettings[text]));
							}
						}
						else if (Operators.CompareString(text, "IsRestaurant", false) == 0)
						{
							MyProject.Forms.Form1.isRestaurant = (int)Math.Round(Conversion.Val(appSettings[text]));
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
		}

		// Token: 0x060036DB RID: 14043 RVA: 0x001DC694 File Offset: 0x001DA894
		public void SendMailMultipleAttachments(string From, string sendTo, string Subject, string Body, ArrayList AttachmentFiles = null, string CC = "", string BCC = "", string SMTPServer = "")
		{
			SmtpClient smtpClient = new SmtpClient();
			checked
			{
				try
				{
					MailMessage mailMessage = new MailMessage();
					MailMessage mailMessage2 = mailMessage;
					mailMessage2.To.Add(sendTo);
					mailMessage2.From = new MailAddress("noreply@quantumonlinepos.com", "QuantumPOS");
					mailMessage2.Subject = Subject;
					mailMessage2.Body = Body;
					bool flag = AttachmentFiles != null;
					if (flag)
					{
						int num = AttachmentFiles.Count - 1;
						int num2 = num;
						for (int i = 0; i <= num2; i++)
						{
							bool flag2 = this.FileExists(Conversions.ToString(AttachmentFiles[i]));
							if (flag2)
							{
								mailMessage2.Attachments.Add((Attachment)AttachmentFiles[i]);
							}
						}
					}
					bool flag3 = Operators.CompareString(SMTPServer, "", false) != 0;
					if (flag3)
					{
						smtpClient.UseDefaultCredentials = false;
						smtpClient.Credentials = new NetworkCredential("noreply@quantumonlinepos.com", "noreply!@#");
						smtpClient.Port = 8889;
						smtpClient.Host = "mail.quantumonlinepos.com";
					}
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
		}

		// Token: 0x060036DC RID: 14044 RVA: 0x001DC7B8 File Offset: 0x001DA9B8
		private bool FileExists(string FileFullPath)
		{
			bool flag = Operators.CompareString(Strings.Trim(FileFullPath), "", false) == 0;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				FileInfo fileInfo = new FileInfo(FileFullPath);
				flag2 = fileInfo.Exists;
			}
			return flag2;
		}

		// Token: 0x060036DD RID: 14045 RVA: 0x001DC7F4 File Offset: 0x001DA9F4
		public DataTable LoadCategories(string con)
		{
			SqlConnection sqlConnection = new SqlConnection(con);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchCategories";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x060036DE RID: 14046 RVA: 0x001DC868 File Offset: 0x001DAA68
		public DataTable GetCustomerDetails(string con, string customername, int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(con);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchCustomerDetails";
			sqlCommand.Parameters.AddWithValue("customername", customername);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x060036DF RID: 14047 RVA: 0x001DC900 File Offset: 0x001DAB00
		public decimal GetRate(string con, int paymethid)
		{
			bool flag = paymethid == 0;
			decimal num;
			if (flag)
			{
				num = 0m;
			}
			else
			{
				SqlConnection sqlConnection = new SqlConnection(con);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "GetPaymentMethRate";
				sqlCommand.Parameters.AddWithValue("paymethid", paymethid);
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				sqlDataAdapter.Fill(dataTable);
				DataRow dataRow = dataTable.Rows[0];
				num = Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataRow["Rate"]));
			}
			return num;
		}

		// Token: 0x060036E0 RID: 14048 RVA: 0x001DC9C4 File Offset: 0x001DABC4
		public DataTable LoadBranches(string con)
		{
			SqlConnection sqlConnection = new SqlConnection(con);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchBranches";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x060036E1 RID: 14049 RVA: 0x001DCA38 File Offset: 0x001DAC38
		public DataTable GetProductDetailsByBarCode(string code, string con)
		{
			SqlConnection sqlConnection = new SqlConnection(con);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByCode2";
			sqlCommand.Parameters.AddWithValue("productcode", code);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x060036E2 RID: 14050 RVA: 0x001DCABC File Offset: 0x001DACBC
		public DataTable GetAllowedPagesForUsername(string username, string con)
		{
			SqlConnection sqlConnection = new SqlConnection(con);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "AC_SelectAllowedPagesForUser";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("username", username);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x060036E3 RID: 14051 RVA: 0x001DCB40 File Offset: 0x001DAD40
		public bool IsAuthorised(string username, int coid, string RequestedPage, DataTable PermissionsSet)
		{
			bool isAdmin = MyProject.Forms.Form1.IsAdmin;
			bool flag;
			if (isAdmin)
			{
				flag = true;
			}
			else
			{
				bool flag2 = PermissionsSet.Rows.Count > 0;
				if (flag2)
				{
					DataRow[] array = PermissionsSet.Select("AllowedPage='" + RequestedPage + "'");
					DataRow[] array2 = array;
					int num = 0;
					if (num >= array2.Length)
					{
						flag = false;
					}
					else
					{
						DataRow dataRow = array2[num];
						bool flag3 = Operators.CompareString(dataRow[2].ToString(), RequestedPage, false) == 0;
						flag = flag3;
					}
				}
				else
				{
					flag = false;
				}
			}
			return flag;
		}

		// Token: 0x060036E4 RID: 14052 RVA: 0x001DCBE0 File Offset: 0x001DADE0
		public DataTable GetSuppliersList(string con)
		{
			SqlConnection sqlConnection = new SqlConnection(con);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectAllSuppliers";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x060036E5 RID: 14053 RVA: 0x001DCC54 File Offset: 0x001DAE54
		public decimal CalcSupplierBal(string con, int coid, string branch, int supplierid)
		{
			SqlConnection sqlConnection = new SqlConnection(con);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CalcSupplierBal";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("supplierid", supplierid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			bool flag = dataTable.Rows.Count == 1;
			decimal num;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				num = Conversions.ToDecimal(dataRow["Bal"]);
			}
			else
			{
				num = 0m;
			}
			return num;
		}

		// Token: 0x060036E6 RID: 14054 RVA: 0x001DCD20 File Offset: 0x001DAF20
		public bool IsCustomerNew(string CustomerName, string con)
		{
			SqlConnection sqlConnection = new SqlConnection(con);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CountCustomer";
			sqlCommand.Parameters.AddWithValue("CustomerName", CustomerName);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			bool flag3;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				bool flag2 = Operators.ConditionalCompareObjectGreater(dataRow["Customer_Count"], 0, false);
				flag3 = !flag2;
			}
			else
			{
				flag3 = true;
			}
			return flag3;
		}

		// Token: 0x060036E7 RID: 14055 RVA: 0x001DCE08 File Offset: 0x001DB008
		public object GetProdCost(int productid, string con)
		{
			SqlConnection sqlConnection = new SqlConnection(con);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByID";
			sqlCommand.Parameters.AddWithValue("prodtID", productid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				double num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow["Cost"]));
				return num2;
			}
			throw new ArgumentException("Exception Occured- cannot find product");
		}

		// Token: 0x060036E8 RID: 14056 RVA: 0x001DCEEC File Offset: 0x001DB0EC
		public string GetProductCodeFromID(int coid, int productid, string con)
		{
			string text;
			using (SqlConnection sqlConnection = new SqlConnection(con))
			{
				using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
				{
					sqlCommand.CommandType = CommandType.StoredProcedure;
					sqlCommand.CommandText = "FetchProductByID2";
					sqlCommand.Parameters.AddWithValue("coid", coid);
					sqlCommand.Parameters.AddWithValue("prodtID", productid);
					using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
					{
						DataTable dataTable = new DataTable();
						sqlDataAdapter.Fill(dataTable);
						bool flag = dataTable.Rows.Count > 0;
						if (flag)
						{
							DataRow dataRow = dataTable.Rows[0];
							text = Conversions.ToString(dataRow["ProductCode"]);
						}
						else
						{
							text = "";
						}
					}
				}
			}
			return text;
		}

		// Token: 0x060036E9 RID: 14057 RVA: 0x001DCFF4 File Offset: 0x001DB1F4
		public int GetProductIDFromCode(int coid, string productcode, string con)
		{
			SqlConnection sqlConnection = new SqlConnection(con);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchProductByCode2";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("productcode", productcode);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			int num2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				num2 = Conversions.ToInteger(dataRow["ProductID"]);
			}
			else
			{
				MessageBox.Show("Product with product code: " + productcode + " cannot be found. Check.");
				num2 = 0;
			}
			return num2;
		}

		// Token: 0x060036EA RID: 14058 RVA: 0x001DD0B0 File Offset: 0x001DB2B0
		public DataTable GetBinLocs(string con)
		{
			SqlConnection sqlConnection = new SqlConnection(con);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetDistinctBinLocs";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x060036EB RID: 14059 RVA: 0x001DD124 File Offset: 0x001DB324
		public DataRow GetBranchPrices(string con, int productid)
		{
			SqlConnection sqlConnection = new SqlConnection(con);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetBranchPriceForProduct";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			DataRow dataRow2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				dataRow2 = dataRow;
			}
			else
			{
				DataRow dataRow3 = new DataTable
				{
					Columns = 
					{
						{
							"productid",
							typeof(int)
						},
						{
							"sellingprice",
							typeof(decimal)
						},
						{
							"wholesaleprice",
							typeof(decimal)
						},
						{
							"wholesaleqty",
							typeof(decimal)
						},
						{
							"specialprice",
							typeof(decimal)
						}
					},
					Rows = { new object[] { 0, 0, 0, 0, 0 } }
				}.Rows[0];
				dataRow2 = dataRow3;
			}
			return dataRow2;
		}

		// Token: 0x060036EC RID: 14060 RVA: 0x001DD2D4 File Offset: 0x001DB4D4
		public decimal CheckGridProductQuantity(int productid, DataGridView gv)
		{
			bool flag = gv.RowCount > 0;
			checked
			{
				decimal num4;
				if (flag)
				{
					int num = 0;
					decimal num2 = 0m;
					int num3 = gv.RowCount - 1;
					for (int i = 0; i <= num3; i++)
					{
						bool flag2 = Operators.ConditionalCompareObjectEqual(gv.Rows[i].Cells["ProdtID"].Value, productid, false);
						if (flag2)
						{
							bool flag3 = Operators.ConditionalCompareObjectEqual(gv.Rows[i].Cells["Break"].Value, 1, false);
							if (flag3)
							{
								num2 = Conversions.ToDecimal(Operators.AddObject(Operators.SubtractObject(num2, gv.Rows[i].Cells["BreakQty"].Value), gv.Rows[i].Cells["Qty"].Value));
							}
							else
							{
								num2 = Conversions.ToDecimal(Operators.AddObject(num2, gv.Rows[i].Cells["Qty"].Value));
							}
							num = 1;
						}
					}
					bool flag4 = num == 0;
					if (flag4)
					{
						num4 = 0m;
					}
					else
					{
						num4 = num2;
					}
				}
				else
				{
					num4 = 0m;
				}
				return num4;
			}
		}

		// Token: 0x060036ED RID: 14061 RVA: 0x001DD440 File Offset: 0x001DB640
		public DataRow GetProductPayMethodDiscount(string con, int productid, int coid, string branch, int paymentmethodid, decimal baseprice, decimal monorate)
		{
			decimal num = 0m;
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("disc", typeof(decimal));
			dataTable.Columns.Add("oldprice", typeof(decimal));
			dataTable.Columns.Add("paymethod", typeof(int));
			SqlConnection sqlConnection = new SqlConnection(con);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "PaymentMethodDiscountSelectForProduct";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("paymentmethodid", paymentmethodid);
			DataTable dataTable2 = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num2 = sqlDataAdapter.Fill(dataTable2);
			bool flag = num2 > 0;
			if (flag)
			{
				DataRow dataRow = dataTable2.Rows[0];
				num = Conversions.ToDecimal(dataRow["discount"]);
				bool flag2 = Conversions.ToBoolean(dataRow["ispercentage"]);
				bool flag3 = flag2;
				if (flag3)
				{
					num = decimal.Multiply(decimal.Multiply(decimal.Divide(num, 100m), monorate), baseprice);
				}
				else
				{
					num = num;
				}
				dataTable.Rows.Add(new object[] { num, baseprice, paymentmethodid });
			}
			else
			{
				num = 0m;
				dataTable.Rows.Add(new object[] { 0, 0, 0 });
			}
			return dataTable.Rows[0];
		}

		// Token: 0x060036EE RID: 14062 RVA: 0x001DD634 File Offset: 0x001DB834
		public void Logoff(string constring)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "EffectLogoff";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("username", MyProject.Forms.Form1.username);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x060036EF RID: 14063 RVA: 0x001DD700 File Offset: 0x001DB900
		public decimal GetStockAvailable(string constring, int productid, DataGridView dgv, string EA, int isrestaurant, int iswarehouse = 0, bool curr_prod_expires = false, string batchnum = "", int expdate = 0, bool inGrid = false)
		{
			bool flag = isrestaurant == 0;
			decimal num3;
			if (flag)
			{
				decimal num = 0m;
				SqlConnection sqlConnection = new SqlConnection(constring);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "StockBalForProductCurrent";
				sqlCommand.Parameters.AddWithValue("productid", productid);
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
				bool flag2 = iswarehouse == 1 || curr_prod_expires;
				if (flag2)
				{
					sqlCommand.Parameters.AddWithValue("iswarehouse", 1);
					sqlCommand.Parameters.AddWithValue("expdate", expdate);
					sqlCommand.Parameters.AddWithValue("batchnumber", batchnum);
				}
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				using (sqlConnection)
				{
					sqlConnection.Open();
					int num2 = sqlDataAdapter.Fill(dataTable);
					bool flag3 = num2 > 0;
					if (flag3)
					{
						DataRow dataRow = dataTable.Rows[0];
						num = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["stockbal"])), 0, RuntimeHelpers.GetObjectValue(dataRow["stockbal"])));
					}
					else
					{
						num = 0m;
					}
					sqlConnection.Close();
				}
				bool flag4 = dgv.RowCount > 0;
				if (flag4)
				{
					bool flag5 = !inGrid;
					if (flag5)
					{
						num = decimal.Subtract(num, this.CheckGridProductQuantity(productid, dgv));
					}
				}
				bool flag6 = Operators.CompareString(EA, "EA", false) == 0;
				if (flag6)
				{
					num3 = new decimal(Convert.ToInt32(num));
				}
				else
				{
					num3 = num;
				}
			}
			else
			{
				decimal num4 = 0m;
				SqlConnection sqlConnection3 = new SqlConnection(constring);
				SqlCommand sqlCommand2 = sqlConnection3.CreateCommand();
				sqlCommand2.CommandType = CommandType.StoredProcedure;
				sqlCommand2.CommandText = "StockBalForProductWithRestarauntCurrent";
				sqlCommand2.Parameters.AddWithValue("productid", productid);
				sqlCommand2.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				sqlCommand2.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
				DataTable dataTable2 = new DataTable();
				SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(sqlCommand2);
				using (sqlConnection3)
				{
					sqlConnection3.Open();
					int num5 = sqlDataAdapter2.Fill(dataTable2);
					bool flag7 = num5 > 0;
					if (flag7)
					{
						DataRow dataRow2 = dataTable2.Rows[0];
						num4 = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2["stockbal"])), 0, RuntimeHelpers.GetObjectValue(dataRow2["stockbal"])));
					}
					else
					{
						num4 = 0m;
					}
					sqlConnection3.Close();
				}
				bool flag8 = dgv.RowCount > 0;
				if (flag8)
				{
					bool flag9 = !inGrid;
					if (flag9)
					{
						num4 = decimal.Subtract(num4, this.CheckGridProductQuantity(productid, dgv));
					}
				}
				bool flag10 = Operators.CompareString(EA, "EA", false) == 0;
				if (flag10)
				{
					num3 = new decimal(Convert.ToInt32(num4));
				}
				else
				{
					num3 = num4;
				}
			}
			return num3;
		}

		// Token: 0x060036F0 RID: 14064 RVA: 0x001DDA9C File Offset: 0x001DBC9C
		public decimal GetStockBalSimple(string constring, int productid, int coid, string branch)
		{
			decimal num = 0m;
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "StockBalForProduct";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("trandate", DateTime.Today.ToString("yyyyMMdd"));
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			using (sqlConnection)
			{
				sqlConnection.Open();
				int num2 = sqlDataAdapter.Fill(dataTable);
				bool flag = num2 > 0;
				if (flag)
				{
					DataRow dataRow = dataTable.Rows[0];
					num = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["stockbal"])), 0, RuntimeHelpers.GetObjectValue(dataRow["stockbal"])));
				}
				else
				{
					num = 0m;
				}
				sqlConnection.Close();
			}
			return num;
		}

		// Token: 0x060036F1 RID: 14065 RVA: 0x001DDBEC File Offset: 0x001DBDEC
		public decimal GetStockBalSimpleProdCode(string constring, string productcode, int coid, string branch)
		{
			decimal num = 0m;
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "StockBalForProductCurrentProdCode";
			sqlCommand.Parameters.AddWithValue("productcode    ", productcode);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			using (sqlConnection)
			{
				sqlConnection.Open();
				int num2 = sqlDataAdapter.Fill(dataTable);
				bool flag = num2 > 0;
				if (flag)
				{
					DataRow dataRow = dataTable.Rows[0];
					num = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["stockbal"])), 0, RuntimeHelpers.GetObjectValue(dataRow["stockbal"])));
				}
				else
				{
					num = 0m;
				}
				sqlConnection.Close();
			}
			return num;
		}

		// Token: 0x060036F2 RID: 14066 RVA: 0x001DDD10 File Offset: 0x001DBF10
		public DataTable GetStockBalProductCode(string productcode, int coid, string branch, int isrestaurant, string constring)
		{
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("productcode");
			dataTable.Columns.Add("productdesc");
			dataTable.Columns.Add("productbal");
			bool flag = isrestaurant == 0;
			DataTable dataTable3;
			if (flag)
			{
				decimal num = 0m;
				string text = "";
				SqlConnection sqlConnection = new SqlConnection(constring);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "StockBalForProductByCode";
				sqlCommand.Parameters.AddWithValue("productcode", productcode);
				sqlCommand.Parameters.AddWithValue("coid", coid);
				sqlCommand.Parameters.AddWithValue("branch", branch);
				sqlCommand.Parameters.AddWithValue("trandate", DateTime.Today.ToString("yyyyMMdd"));
				DataTable dataTable2 = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				using (sqlConnection)
				{
					sqlConnection.Open();
					int num2 = sqlDataAdapter.Fill(dataTable2);
					bool flag2 = num2 > 0;
					if (flag2)
					{
						DataRow dataRow = dataTable2.Rows[0];
						num = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["stockbal"])), 0, RuntimeHelpers.GetObjectValue(dataRow["stockbal"])));
						text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["productdesc"])), "", RuntimeHelpers.GetObjectValue(dataRow["productdesc"])));
					}
					else
					{
						num = 0m;
					}
					sqlConnection.Close();
				}
				DataRow dataRow2 = dataTable.NewRow();
				dataRow2["productbal"] = num;
				dataRow2["productcode"] = productcode;
				dataRow2["productdesc"] = text;
				dataTable.Rows.Add(dataRow2);
				dataTable3 = dataTable;
			}
			else
			{
				decimal num3 = 0m;
				string text2 = "";
				SqlConnection sqlConnection3 = new SqlConnection(constring);
				SqlCommand sqlCommand2 = sqlConnection3.CreateCommand();
				sqlCommand2.CommandType = CommandType.StoredProcedure;
				sqlCommand2.CommandText = "StockBalForProductWithRestarauntByCode";
				sqlCommand2.Parameters.AddWithValue("productcode", productcode);
				sqlCommand2.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				sqlCommand2.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
				sqlCommand2.Parameters.AddWithValue("trandate", DateTime.Today.ToString("yyyyMMdd"));
				DataTable dataTable4 = new DataTable();
				SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(sqlCommand2);
				using (sqlConnection3)
				{
					sqlConnection3.Open();
					int num4 = sqlDataAdapter2.Fill(dataTable4);
					bool flag3 = num4 > 0;
					if (flag3)
					{
						DataRow dataRow3 = dataTable4.Rows[0];
						num3 = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow3["stockbal"])), 0, RuntimeHelpers.GetObjectValue(dataRow3["stockbal"])));
						text2 = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow3["productdesc"])), "", RuntimeHelpers.GetObjectValue(dataRow3["productdesc"])));
					}
					else
					{
						num3 = 0m;
					}
					sqlConnection3.Close();
				}
				DataRow dataRow4 = dataTable.NewRow();
				dataRow4["productbal"] = num3;
				dataRow4["productcode"] = productcode;
				dataRow4["productdesc"] = text2;
				dataTable.Rows.Add(dataRow4);
				dataTable3 = dataTable;
			}
			return dataTable3;
		}

		// Token: 0x060036F3 RID: 14067 RVA: 0x001DE120 File Offset: 0x001DC320
		public DataTable GetBranches(string conn)
		{
			SqlConnection sqlConnection = new SqlConnection(conn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "Select * from branches where coid=" + MyProject.Forms.Form1.coid.ToString();
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x060036F4 RID: 14068 RVA: 0x001DE188 File Offset: 0x001DC388
		public void DATAGRIDVIEW_TO_EXCEL(DataGridView DGV, string FLE)
		{
			checked
			{
				try
				{
					DataTable dataTable = new DataTable();
					int num = DGV.ColumnCount - 1;
					for (int i = 0; i <= num; i++)
					{
						dataTable.Columns.Add(DGV.Columns[i].Name.ToString());
					}
					int num2 = DGV.Rows.Count - 1;
					for (int j = 0; j <= num2; j++)
					{
						DataRow dataRow = dataTable.NewRow();
						int num3 = DGV.ColumnCount - 1;
						for (int i = 0; i <= num3; i++)
						{
							try
							{
								dataRow[dataTable.Columns[i].ColumnName.ToString()] = DGV.Rows[j].Cells[i].Value.ToString();
							}
							catch (Exception ex)
							{
							}
						}
						dataTable.Rows.Add(dataRow);
					}
					dataTable.AcceptChanges();
					DataSet dataSet = new DataSet();
					dataSet.Tables.Add(dataTable);
					dataTable.WriteXml(FLE);
				}
				catch (Exception ex2)
				{
					Interaction.MsgBox(ex2.ToString(), MsgBoxStyle.OkOnly, null);
				}
			}
		}

		// Token: 0x060036F5 RID: 14069 RVA: 0x001DE2F0 File Offset: 0x001DC4F0
		public void DATAGRIDVIEW_TO_EXCEL2(DataGridView DGV, string FLE, string wksheetname)
		{
			DataTable dataTable = new DataTable();
			try
			{
				foreach (object obj in DGV.Columns)
				{
					DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj;
					dataTable.Columns.Add(dataGridViewColumn.HeaderText, dataGridViewColumn.ValueType);
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
			try
			{
				foreach (object obj2 in ((IEnumerable)DGV.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj2;
					dataTable.Rows.Add(new object[0]);
					try
					{
						foreach (object obj3 in dataGridViewRow.Cells)
						{
							DataGridViewCell dataGridViewCell = (DataGridViewCell)obj3;
							dataTable.Rows[checked(dataTable.Rows.Count - 1)][dataGridViewCell.ColumnIndex] = RuntimeHelpers.GetObjectValue(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataGridViewCell.Value)), "", dataGridViewCell.Value.ToString()));
						}
					}
					finally
					{
						IEnumerator enumerator3;
						if (enumerator3 is IDisposable)
						{
							(enumerator3 as IDisposable).Dispose();
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator2;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			using (XLWorkbook xlworkbook = new XLWorkbook())
			{
				xlworkbook.Worksheets.Add(dataTable, wksheetname);
				xlworkbook.SaveAs(FLE);
			}
		}

		// Token: 0x060036F6 RID: 14070 RVA: 0x001DE4B0 File Offset: 0x001DC6B0
		public void DATAGRIDVIEW_TO_EXCEL_From_DGV_ForStockTake(DataGridView DGV, string FLE, string wksheetname)
		{
			PublicFunctions._Closure$__34-0 CS$<>8__locals1 = new PublicFunctions._Closure$__34-0(CS$<>8__locals1);
			CS$<>8__locals1.$VB$Local_EscapeCsv = ((PublicFunctions._Closure$__.$I34-0 == null) ? (PublicFunctions._Closure$__.$I34-0 = delegate(string value)
			{
				bool flag = value == null;
				string text;
				if (flag)
				{
					text = "";
				}
				else
				{
					string text2 = value.Replace("\"", "\"\"");
					bool flag2 = text2.Contains(",") || text2.Contains("\"") || text2.Contains("\r") || text2.Contains("\n");
					if (flag2)
					{
						text2 = "\"" + text2 + "\"";
					}
					text = text2;
				}
				return text;
			}) : PublicFunctions._Closure$__.$I34-0);
			string[] array = (from DataGridViewColumn header in DGV.Columns
				select CS$<>8__locals1.$VB$Local_EscapeCsv(header.HeaderText)).ToArray<string>();
			IEnumerable<string[]> enumerable = from row in DGV.Rows.Cast<DataGridViewRow>().Where<DataGridViewRow>((PublicFunctions._Closure$__.$I34-2 == null) ? (PublicFunctions._Closure$__.$I34-2 = (DataGridViewRow row) => !row.IsNewRow) : PublicFunctions._Closure$__.$I34-2)
				select Array.ConvertAll<DataGridViewCell, string>(row.Cells.Cast<DataGridViewCell>().ToArray<DataGridViewCell>(), (DataGridViewCell c) => CS$<>8__locals1.$VB$Local_EscapeCsv((c.Value != null) ? c.Value.ToString() : ""));
			using (StreamWriter streamWriter = new StreamWriter(FLE))
			{
				streamWriter.WriteLine(string.Join(",", array));
				try
				{
					foreach (string[] array2 in enumerable)
					{
						streamWriter.WriteLine(string.Join(",", array2));
					}
				}
				finally
				{
					IEnumerator<string[]> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			Interaction.Shell("explorer /select," + FLE, AppWinStyle.NormalFocus, false, -1);
		}

		// Token: 0x060036F7 RID: 14071 RVA: 0x001DE5F4 File Offset: 0x001DC7F4
		public void DATAGRIDVIEW_TO_CSV(DataGridView DGV, string FLE)
		{
			string[] array = DGV.Columns.Cast<DataGridViewColumn>().Select<DataGridViewColumn, string>((PublicFunctions._Closure$__.$I35-0 == null) ? (PublicFunctions._Closure$__.$I35-0 = (DataGridViewColumn header) => header.HeaderText) : PublicFunctions._Closure$__.$I35-0).ToArray<string>();
			IEnumerable<string[]> enumerable = DGV.Rows.Cast<DataGridViewRow>().Where<DataGridViewRow>((PublicFunctions._Closure$__.$I35-1 == null) ? (PublicFunctions._Closure$__.$I35-1 = (DataGridViewRow row) => !row.IsNewRow & row.Visible) : PublicFunctions._Closure$__.$I35-1).Select<DataGridViewRow, string[]>((PublicFunctions._Closure$__.$I35-2 == null) ? (PublicFunctions._Closure$__.$I35-2 = (DataGridViewRow row) => Array.ConvertAll<DataGridViewCell, string>(row.Cells.Cast<DataGridViewCell>().ToArray<DataGridViewCell>(), (PublicFunctions._Closure$__.$I35-3 == null) ? (PublicFunctions._Closure$__.$I35-3 = (DataGridViewCell c) => (c.Value != null) ? c.Value.ToString() : "") : PublicFunctions._Closure$__.$I35-3)) : PublicFunctions._Closure$__.$I35-2);
			using (StreamWriter streamWriter = new StreamWriter(FLE))
			{
				streamWriter.WriteLine(string.Join(",", array));
				try
				{
					foreach (string[] array2 in enumerable)
					{
						streamWriter.WriteLine(string.Join(",", array2));
					}
				}
				finally
				{
					IEnumerator<string[]> enumerator;
					if (enumerator != null)
					{
						enumerator.Dispose();
					}
				}
			}
			int num = Interaction.Shell("explorer /select, " + FLE, AppWinStyle.NormalFocus, false, -1);
		}

		// Token: 0x060036F8 RID: 14072 RVA: 0x001DE738 File Offset: 0x001DC938
		public string GetBaseCurrency(int coid, string constring)
		{
			string text = "";
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetCompanyDetailsForCoid";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			using (sqlConnection)
			{
				sqlConnection.Open();
				int num = sqlDataAdapter.Fill(dataTable);
				bool flag = num > 0;
				if (flag)
				{
					DataRow dataRow = dataTable.Rows[0];
					text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["BaseCurrency"])), "", RuntimeHelpers.GetObjectValue(dataRow["BaseCurrency"])));
				}
				else
				{
					text = "";
				}
				sqlConnection.Close();
			}
			return text;
		}

		// Token: 0x060036F9 RID: 14073 RVA: 0x001DE834 File Offset: 0x001DCA34
		public object GetSystemUsers(string conString, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(conString);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchUsers";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x060036FA RID: 14074 RVA: 0x001DE898 File Offset: 0x001DCA98
		public DataTable GetInvDiscountPerc(int coid, string branch, string constring)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetDiscountPercentage";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x060036FB RID: 14075 RVA: 0x001DE910 File Offset: 0x001DCB10
		public int GetFiscalGroup(int paymentmethodid, string constring)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetFiscalGroup";
			sqlCommand.Parameters.AddWithValue("paymentmethodid", paymentmethodid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			return Conversions.ToInteger(dataRow["FiscalGroup"]);
		}

		// Token: 0x060036FC RID: 14076 RVA: 0x001DE9B8 File Offset: 0x001DCBB8
		public int GetEltradeFiscalCountryID(int paymentmethodid, string constring)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "Select CurrencyIDEltrade from paymentmethods where paymentmethodid = " + paymentmethodid.ToString();
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			int num2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				num2 = Conversions.ToInteger(dataRow["CurrencyIDEltrade"]);
			}
			else
			{
				num2 = 0;
			}
			return num2;
		}

		// Token: 0x060036FD RID: 14077 RVA: 0x001DEA40 File Offset: 0x001DCC40
		public DataTable GetPaymentMethodDetails(int paymentmethodid, string constring)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetPayMethDetails";
			sqlCommand.Parameters.AddWithValue("paymentmethodid", paymentmethodid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x060036FE RID: 14078 RVA: 0x001DEAC8 File Offset: 0x001DCCC8
		public decimal GetRate(int paymentmethodid, string constring)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetPaymentMethRate";
			sqlCommand.Parameters.AddWithValue("paymethid", paymentmethodid);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			return Conversions.ToDecimal(dataRow["Rate"]);
		}

		// Token: 0x060036FF RID: 14079 RVA: 0x001DEB70 File Offset: 0x001DCD70
		public DataTable GetPaymentMethods(string constring)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectPaymentMethods";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06003700 RID: 14080 RVA: 0x001DEBE4 File Offset: 0x001DCDE4
		public void loadmultipaymeths(string constring)
		{
			MyProject.Forms.Form1.MultiPayMethodsDAT.Columns.Clear();
			MyProject.Forms.Form1.MultiPayMethodsDAT.Clear();
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectPaymentMethods";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(MyProject.Forms.Form1.MultiPayMethodsDAT);
			MyProject.Forms.Form1.MultiPayMethodsDAT.Columns.Add("amtpaid");
			MyProject.Forms.Form1.MultiPayMethodsDAT.Columns.Add("equiv");
		}

		// Token: 0x06003701 RID: 14081 RVA: 0x001DECC4 File Offset: 0x001DCEC4
		public DataTable getEltradeSetting(int paymentmethodid, string constring)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "getEltradePortSettings";
			sqlCommand.Parameters.AddWithValue("paymentmethodid", paymentmethodid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06003702 RID: 14082 RVA: 0x001DED28 File Offset: 0x001DCF28
		public DataTable GetDataFromFile(string con, string strpath, string separator)
		{
			StreamReader streamReader = new StreamReader(strpath);
			string text = streamReader.ReadLine();
			string[] array = text.Split(new char[] { Conversions.ToChar(separator) });
			DataTable dataTable = new DataTable();
			foreach (string text2 in array)
			{
				dataTable.Columns.Add(new DataColumn());
			}
			for (;;)
			{
				bool flag = Operators.CompareString(text, string.Empty, false) != 0;
				if (!flag)
				{
					break;
				}
				DataRow dataRow = dataTable.NewRow();
				dataRow.ItemArray = text.Split(new char[] { Conversions.ToChar(separator) });
				dataTable.Rows.Add(dataRow);
				text = streamReader.ReadLine();
			}
			return dataTable;
		}

		// Token: 0x06003703 RID: 14083 RVA: 0x001DEDF8 File Offset: 0x001DCFF8
		public void UpdateProductCodeBase(string con, int coid, decimal code)
		{
			SqlConnection sqlConnection = new SqlConnection(con);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "UpdateProductCodeBase";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("code", code);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06003704 RID: 14084 RVA: 0x001DEE8C File Offset: 0x001DD08C
		public string GetNextProductCode(string con, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(con);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchNextProductCode";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			return this.CalculateEan13(dataRow["NextProductCode"].ToString());
		}

		// Token: 0x06003705 RID: 14085 RVA: 0x001DEF14 File Offset: 0x001DD114
		public DateTime GetCustomerFirstDate(int customerEntryno, int coid, string branch, string conn)
		{
			SqlConnection sqlConnection = new SqlConnection(conn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"select top 1 trandate from Movement where trancode in (3,4) and CustomerEntryNo=",
				Conversions.ToString(customerEntryno),
				" and branch='",
				branch,
				"' and coid=",
				Conversions.ToString(coid),
				" order by entryno desc"
			});
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			DateTime dateTime;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				bool flag2 = Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["trandate"]));
				if (flag2)
				{
					dateTime = Conversions.ToDate("01-01-1901");
				}
				else
				{
					dateTime = DateTime.ParseExact((checked((int)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow["trandate"]))))).ToString(), "yyyyMMdd", CultureInfo.InvariantCulture);
				}
			}
			else
			{
				dateTime = Conversions.ToDate("01-01-1901");
			}
			return dateTime;
		}

		// Token: 0x06003706 RID: 14086 RVA: 0x001DF024 File Offset: 0x001DD224
		public double GetCustomerBillTotal(int customerentryno, int coid, string branch, string conn)
		{
			SqlConnection sqlConnection = new SqlConnection(conn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "BillingCalcAccBalance";
			sqlCommand.Parameters.AddWithValue("customerentryno", customerentryno);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			double num2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				bool flag2 = Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["bal"]));
				if (flag2)
				{
					num2 = 0.0;
				}
				else
				{
					num2 = Conversion.Val(RuntimeHelpers.GetObjectValue(dataRow["bal"]));
				}
			}
			else
			{
				num2 = 0.0;
			}
			return num2;
		}

		// Token: 0x06003707 RID: 14087 RVA: 0x001DF118 File Offset: 0x001DD318
		public DataRow GetCustomerDetails(string customername, string conn)
		{
			SqlConnection sqlConnection = new SqlConnection(conn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchCustomerDetails";
			sqlCommand.Parameters.AddWithValue("Customername", customername);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			DataRow dataRow2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				dataRow2 = dataRow;
			}
			else
			{
				DataTable dataTable2 = new DataTable();
				DataRow dataRow3 = dataTable2.Rows[0];
				dataRow2 = dataRow3;
			}
			return dataRow2;
		}

		// Token: 0x06003708 RID: 14088 RVA: 0x001DF1F4 File Offset: 0x001DD3F4
		public bool isCustomerAccOK(string customername, decimal newtotal, string conn, int coid, string branch)
		{
			DataRow customerDetails = this.GetCustomerDetails(customername, conn);
			decimal num = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(customerDetails["AccountLimit"])), 0, RuntimeHelpers.GetObjectValue(customerDetails["AccountLimit"])));
			bool flag = Conversions.ToBoolean(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(customerDetails["isactive"])), true, RuntimeHelpers.GetObjectValue(customerDetails["isactive"])));
			decimal num2 = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(customerDetails["bal"])), 0, RuntimeHelpers.GetObjectValue(customerDetails["bal"])));
			bool flag2 = flag;
			bool flag4;
			if (flag2)
			{
				bool flag3 = decimal.Compare(num, 0m) == 0;
				if (flag3)
				{
					flag4 = true;
				}
				else
				{
					bool flag5 = decimal.Compare(num, decimal.Add(num2, newtotal)) >= 0;
					flag4 = flag5;
				}
			}
			else
			{
				flag4 = false;
			}
			return flag4;
		}

		// Token: 0x06003709 RID: 14089 RVA: 0x001DF2F8 File Offset: 0x001DD4F8
		public int GetProductCategory(int productid, int coid, string constring)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "Select catid from products where productid = " + productid.ToString() + " and coid=" + coid.ToString();
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			int num2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				num2 = Conversions.ToInteger(dataRow["catid"]);
			}
			else
			{
				num2 = 0;
			}
			return num2;
		}

		// Token: 0x0600370A RID: 14090 RVA: 0x001DF38C File Offset: 0x001DD58C
		public void SaveReportToPDF(ReportViewer viewer, string savePath, int invnumber)
		{
			Report localReport = viewer.LocalReport;
			string text = "PDF";
			string text2 = "";
			string text3 = null;
			string text4 = null;
			string text5 = null;
			string[] array = null;
			Warning[] array2 = null;
			byte[] array3 = localReport.Render(text, text2, out text3, out text4, out text5, out array, out array2);
			using (FileStream fileStream = new FileStream(savePath + "\\" + invnumber.ToString() + ".pdf", FileMode.Create))
			{
				fileStream.Write(array3, 0, array3.Length);
			}
		}

		// Token: 0x0600370B RID: 14091 RVA: 0x001DF414 File Offset: 0x001DD614
		public decimal GetRecipeProductCost(int coid, int productid, string constring, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetRecipeProductCost";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			decimal num2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				num2 = Conversions.ToDecimal(dataRow["ProductCost"]);
			}
			else
			{
				num2 = -2m;
			}
			return num2;
		}

		// Token: 0x0600370C RID: 14092 RVA: 0x001DF4D8 File Offset: 0x001DD6D8
		public string CreateSpacer(int num_of_spaces)
		{
			string text = "";
			checked
			{
				do
				{
					text += " ";
					num_of_spaces--;
				}
				while (num_of_spaces > 0);
				return text;
			}
		}

		// Token: 0x0600370D RID: 14093 RVA: 0x001DF50C File Offset: 0x001DD70C
		public string AirtimeVoucherTEXT(DataTable airtimeDetails, string airtimeType)
		{
			string text = airtimeType;
			text += Environment.NewLine;
			text += Environment.NewLine;
			try
			{
				foreach (object obj in airtimeDetails.Rows)
				{
					DataRow dataRow = (DataRow)obj;
					string text2 = this.Decrypt(Conversions.ToString(dataRow["airtimevoucher"]), Conversions.ToString(MyProject.Forms.Form1.coid));
					text = string.Concat(new string[]
					{
						text,
						"Airtime PIN: ",
						text2,
						Environment.NewLine,
						Environment.NewLine
					});
					text = text + "Denomination: " + dataRow["Denomination"].ToString() + Environment.NewLine;
					text = text + "Serial number: " + dataRow["SerialNumber"].ToString() + Environment.NewLine;
					text = text + "Batch Number: " + dataRow["BatchNumber"].ToString() + Environment.NewLine;
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
			return text;
		}

		// Token: 0x0600370E RID: 14094 RVA: 0x001DF64C File Offset: 0x001DD84C
		public DataTable ConvertDatagridviewToDataTable(DataGridView pDataGridView, bool pColumnNames = true)
		{
			DataTable dataTable = new DataTable();
			try
			{
				foreach (object obj in pDataGridView.Columns)
				{
					DataGridViewColumn dataGridViewColumn = (DataGridViewColumn)obj;
					dataTable.Columns.Add(dataGridViewColumn.Name);
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
			int count = dataTable.Columns.Count;
			try
			{
				foreach (object obj2 in ((IEnumerable)pDataGridView.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj2;
					dataTable.Rows.Add(new object[0]);
					try
					{
						foreach (object obj3 in dataGridViewRow.Cells)
						{
							DataGridViewCell dataGridViewCell = (DataGridViewCell)obj3;
							dataTable.Rows[checked(dataTable.Rows.Count - 1)][dataGridViewCell.ColumnIndex] = dataGridViewCell.Value.ToString();
						}
					}
					finally
					{
						IEnumerator enumerator3;
						if (enumerator3 is IDisposable)
						{
							(enumerator3 as IDisposable).Dispose();
						}
					}
				}
			}
			finally
			{
				IEnumerator enumerator2;
				if (enumerator2 is IDisposable)
				{
					(enumerator2 as IDisposable).Dispose();
				}
			}
			return dataTable;
		}

		// Token: 0x0600370F RID: 14095 RVA: 0x001DF7C0 File Offset: 0x001DD9C0
		public string DS782_ConnectedScale(string rawmsg)
		{
			int num = rawmsg.IndexOf("B");
			bool flag = num != -1;
			string text2;
			if (flag)
			{
				int num2 = rawmsg.IndexOf("T");
				string text = checked(rawmsg.Substring(num + 1, num2 - num));
				text2 = text;
			}
			else
			{
				string text;
				text2 = text;
			}
			return text2;
		}

		// Token: 0x06003710 RID: 14096 RVA: 0x001DF80C File Offset: 0x001DDA0C
		public bool IsCATIDForUser(string username, int coid, int catid, string constring)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchUserCatIDs";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("username", username);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			bool flag3;
			if (flag)
			{
				try
				{
					foreach (object obj in dataTable.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						bool flag2 = Operators.ConditionalCompareObjectEqual(dataRow[0], catid, false);
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
				flag3 = false;
			}
			else
			{
				flag3 = false;
			}
			return flag3;
		}

		// Token: 0x06003711 RID: 14097 RVA: 0x001DF908 File Offset: 0x001DDB08
		public void SaveLogoBMP(string filename, Image image)
		{
			string text = Path.Combine(MyProject.Application.Info.DirectoryPath, filename + ".bmp");
			Bitmap bitmap = new Bitmap(image.Width, image.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			graphics.DrawImageUnscaled(image, Point.Empty);
			graphics.Dispose();
			bitmap.Save(filename, ImageFormat.Jpeg);
			bitmap.Dispose();
		}

		// Token: 0x06003712 RID: 14098 RVA: 0x001DF978 File Offset: 0x001DDB78
		public void DeleteLogoBMP(string filename)
		{
			bool flag = File.Exists(filename);
			if (flag)
			{
				try
				{
					File.Delete(filename);
					MessageBox.Show("File deleted successfully.");
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error deleting file: " + ex.Message);
				}
			}
			else
			{
				MessageBox.Show("File not found.");
			}
		}

		// Token: 0x06003713 RID: 14099 RVA: 0x001DF9F0 File Offset: 0x001DDBF0
		public string RemoveComma(string formattedvalue)
		{
			return formattedvalue.Replace(",", "");
		}

		// Token: 0x06003714 RID: 14100 RVA: 0x001DFA14 File Offset: 0x001DDC14
		public DataTable getAllProductsList(int coid, string constring)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "Select * from products where coid=" + Conversions.ToString(coid) + " order by productdesc";
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06003715 RID: 14101 RVA: 0x001DFA70 File Offset: 0x001DDC70
		public DataRow getProductDetails(int coid, int productid, string constring)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"Select * from products where coid=",
				Conversions.ToString(coid),
				" and productid=",
				Conversions.ToString(productid),
				" order by productdesc"
			});
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			DataRow dataRow2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				dataRow2 = dataRow;
			}
			else
			{
				DataRow dataRow3 = null;
				dataRow2 = dataRow3;
			}
			return dataRow2;
		}

		// Token: 0x06003716 RID: 14102 RVA: 0x001DFB10 File Offset: 0x001DDD10
		public DataTable GetAllCustomers(string constring, int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchAllCustomers";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06003717 RID: 14103 RVA: 0x001DFB88 File Offset: 0x001DDD88
		public string GetUserInput(string msg, string title, string defaultvalue)
		{
			object obj = Interaction.InputBox(msg, title, defaultvalue, -1, -1);
			bool flag = obj == "";
			if (flag)
			{
				obj = defaultvalue;
			}
			bool flag2 = obj == "";
			if (flag2)
			{
				obj = defaultvalue;
			}
			return Conversions.ToString(obj);
		}

		// Token: 0x06003718 RID: 14104 RVA: 0x001DFBC8 File Offset: 0x001DDDC8
		public string RunScript_SQLCMD_Script(string server_name, string db_name, string user_name, string pass_word, bool windowsauth, string workingdir, string scriptname)
		{
			string text2;
			try
			{
				Process process = new Process();
				process.StartInfo.FileName = "sqlcmd.exe";
				if (windowsauth)
				{
					process.StartInfo.Arguments = string.Format("-S {0} -d {1} -i {2} -o output.txt", server_name, db_name, scriptname);
				}
				else
				{
					process.StartInfo.Arguments = string.Format("-S {0} -d {1} -U {2} -P {3} -i {4} -o output.txt", new object[] { server_name, db_name, user_name, pass_word, scriptname });
				}
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.WorkingDirectory = workingdir;
				process.Start();
				process.WaitForExit();
				string text = File.OpenText(workingdir + "\\output.txt").ReadToEnd();
				text2 = "Script Output: " + text;
			}
			catch (Exception ex)
			{
				text2 = "Error occured. Details: " + ex.Message;
			}
			return text2;
		}

		// Token: 0x06003719 RID: 14105 RVA: 0x001DFCD4 File Offset: 0x001DDED4
		public string RunScript_SQLCMD_Query(string server_name, string db_name, string user_name, string pass_word, bool windowsauth, string workingdir, string query)
		{
			string text3;
			try
			{
				string text = workingdir + "\\output.txt";
				bool flag = File.Exists(text);
				if (flag)
				{
					File.WriteAllText(text, "");
				}
				Process process = new Process();
				process.StartInfo.FileName = "sqlcmd.exe";
				if (windowsauth)
				{
					process.StartInfo.Arguments = string.Format("-S {0} -d {1} -q {2} -o output.txt", server_name, db_name, query);
				}
				else
				{
					process.StartInfo.Arguments = string.Format("-S {0} -d {1} -U {2} -P {3} -q {4} -o output.txt", new object[] { server_name, db_name, user_name, pass_word, query });
				}
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.WorkingDirectory = workingdir;
				process.Start();
				process.WaitForExit();
				string text2 = File.OpenText(workingdir + "\\output.txt").ReadToEnd();
				text3 = "Script Output: " + text2;
			}
			catch (Exception ex)
			{
				text3 = "Error occured. Details: " + ex.Message;
			}
			return text3;
		}

		// Token: 0x0600371A RID: 14106 RVA: 0x001DFE08 File Offset: 0x001DE008
		private void ClearCMDSQLOutputFile(string filename_path)
		{
			bool flag = File.Exists(filename_path);
			if (flag)
			{
				File.WriteAllText(filename_path, "");
			}
		}

		// Token: 0x0600371B RID: 14107 RVA: 0x001DFE30 File Offset: 0x001DE030
		public DateTime ReturnDate(string DateString, string format)
		{
			DateTime dateTime = default(DateTime);
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			try
			{
				dateTime = DateTime.ParseExact(DateString, format, invariantCulture);
			}
			catch (Exception ex)
			{
			}
			return dateTime;
		}

		// Token: 0x0600371C RID: 14108 RVA: 0x001DFE80 File Offset: 0x001DE080
		public DataTable GetCustomerByEntryNo(string branch, int coid, int customerEntryNo, string constr)
		{
			SqlConnection sqlConnection = new SqlConnection(constr);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"Select * from CustomerDetails where coid=",
				Conversions.ToString(coid),
				" and branch='",
				branch,
				"' and EntryNo=",
				Conversions.ToString(customerEntryNo)
			});
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x0600371D RID: 14109 RVA: 0x001DFF04 File Offset: 0x001DE104
		public string vIIFDBNullString(object item)
		{
			return Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(item)), "", RuntimeHelpers.GetObjectValue(item)));
		}

		// Token: 0x0600371E RID: 14110 RVA: 0x001DFF38 File Offset: 0x001DE138
		public string vIIFDNBullDec(object item)
		{
			return Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(item)), 0, RuntimeHelpers.GetObjectValue(item)));
		}

		// Token: 0x0600371F RID: 14111 RVA: 0x001DFF6C File Offset: 0x001DE16C
		public string SendEmailNow(string emailfrom, string emailto, string emailsubject, string emailbody, string emailhost, string username, string pwd, bool use_ssl)
		{
			MailMessage mailMessage = new MailMessage();
			mailMessage.From = new MailAddress(emailfrom);
			mailMessage.To.Add(emailto);
			mailMessage.Subject = emailsubject;
			mailMessage.Body = emailbody;
			SmtpClient smtpClient = new SmtpClient(emailhost);
			string text;
			try
			{
				smtpClient.Send(mailMessage);
				text = "Email sent successfully.";
			}
			catch (Exception ex)
			{
				text = "Send failure: " + ex.ToString();
			}
			return text;
		}

		// Token: 0x06003720 RID: 14112 RVA: 0x001DFFF8 File Offset: 0x001DE1F8
		public int GetNextInvNumStockTake(int coid, string branch, string constring)
		{
			int num = 0;
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetNextStockTakeNumber";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("details", string.Concat(new string[]
			{
				DateTime.Now.ToString("yyyyMMdd HH:mm:ss"),
				", ",
				Environment.MachineName,
				", ",
				MyProject.Forms.Form1.username
			}));
			sqlCommand.Parameters.AddWithValue("new_id", num);
			using (sqlConnection)
			{
				sqlConnection.Open();
				num = Conversions.ToInteger(sqlCommand.ExecuteScalar());
				sqlConnection.Close();
			}
			return num;
		}

		// Token: 0x06003721 RID: 14113 RVA: 0x001E010C File Offset: 0x001DE30C
		public byte[] GetPhoto(string filePath)
		{
			FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
			BinaryReader binaryReader = new BinaryReader(fileStream);
			byte[] array = binaryReader.ReadBytes(checked((int)fileStream.Length));
			binaryReader.Close();
			fileStream.Close();
			return array;
		}

		// Token: 0x06003722 RID: 14114 RVA: 0x001E014C File Offset: 0x001DE34C
		public DataTable GetUsers(int coid, string constring)
		{
			SqlConnection sqlConnection = new SqlConnection(MyProject.Forms.Form1.Constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			DataTable dataTable = new DataTable();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FetchUsers";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06003723 RID: 14115 RVA: 0x001E01CC File Offset: 0x001DE3CC
		public bool CheckIfFirstBalRun(int lacoid, string labranch, string constring)
		{
			bool flag4;
			try
			{
				SqlConnection sqlConnection = new SqlConnection(constring);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.Text;
				sqlCommand.CommandText = "select FirstStockBalRun from branches where branch='" + labranch + "' and coid=" + Conversions.ToString(lacoid);
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				int num = sqlDataAdapter.Fill(dataTable);
				bool flag = num > 0;
				if (flag)
				{
					DataRow dataRow = dataTable.Rows[0];
					bool flag2 = Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow[0]));
					bool flag3 = flag2;
					if (flag3)
					{
						flag4 = false;
					}
					else
					{
						int num2 = Conversions.ToInteger(dataRow[0]);
						bool flag5 = num2 == 1;
						if (flag5)
						{
							flag4 = true;
						}
						else
						{
							flag4 = false;
						}
					}
				}
				else
				{
					flag4 = false;
				}
			}
			catch (Exception ex)
			{
				flag4 = false;
			}
			return flag4;
		}

		// Token: 0x06003724 RID: 14116 RVA: 0x001E02F4 File Offset: 0x001DE4F4
		public string CalculateEan13(string twelve_dig_prodcode)
		{
			int num = 0;
			checked
			{
				string text;
				try
				{
					int length = twelve_dig_prodcode.Length;
					for (int i = 1; i <= length; i++)
					{
						int num2 = Convert.ToInt32(twelve_dig_prodcode.Substring(i - 1, 1));
						bool flag = i % 2 == 0;
						if (flag)
						{
							num += num2 * 3;
						}
						else
						{
							num += num2 * 1;
						}
					}
					int num3 = (10 - num % 10) % 10;
					text = twelve_dig_prodcode + Conversions.ToString(num3);
				}
				catch (Exception ex)
				{
					text = twelve_dig_prodcode;
				}
				return text;
			}
		}

		// Token: 0x06003725 RID: 14117 RVA: 0x001E0390 File Offset: 0x001DE590
		public string StringPadCentre(string theText, int maxlength)
		{
			bool flag = theText.Length >= maxlength;
			checked
			{
				if (!flag)
				{
					int length = theText.Length;
					int num = (int)Math.Round((double)(maxlength - length) / 2.0);
					theText = theText.PadLeft(num + length);
					theText = theText.PadRight(num + length);
				}
				return theText;
			}
		}

		// Token: 0x06003726 RID: 14118 RVA: 0x001E03EC File Offset: 0x001DE5EC
		public DataTable GetInvoiceDetails(int coid, string branch, int invoicenum, string constring)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SalesForPeriodByInvoiceDetails";
			sqlCommand.Parameters.AddWithValue("invoicenum", invoicenum);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06003727 RID: 14119 RVA: 0x001E047C File Offset: 0x001DE67C
		public DataTable ReadCVStoDataTable(string filepath)
		{
			StreamReader streamReader = new StreamReader(filepath);
			string text = streamReader.ReadLine();
			string[] array = text.Split(new char[] { ',' });
			DataTable dataTable = new DataTable();
			foreach (string text2 in array)
			{
				dataTable.Columns.Add(new DataColumn());
			}
			for (;;)
			{
				text = streamReader.ReadLine();
				bool flag = Operators.CompareString(text, string.Empty, false) != 0;
				if (!flag)
				{
					break;
				}
				DataRow dataRow = dataTable.NewRow();
				dataRow.ItemArray = text.Split(new char[] { ',' });
				dataTable.Rows.Add(dataRow);
			}
			return dataTable;
		}

		// Token: 0x06003728 RID: 14120 RVA: 0x001E0544 File Offset: 0x001DE744
		public DataTable GetProductDetailsAndBal(int coid, string branch, string productcode, string constring)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetProductDetailAndBalance";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("productcode", productcode);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06003729 RID: 14121 RVA: 0x001E05CC File Offset: 0x001DE7CC
		public DataTable GetProductIngridients(int coid, string branch, int productid, string constring)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectFormulaIngridients";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("formulaname", this.GetProductFormulaName(productid, coid, constring));
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x0600372A RID: 14122 RVA: 0x001E064C File Offset: 0x001DE84C
		public string GetProductFormulaName(int productid, int coid, string constring)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SelectFormulasTop1_pos";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("productid", productid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			string text;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				text = dataRow["FormulaName"].ToString();
			}
			else
			{
				text = "0";
			}
			return text;
		}

		// Token: 0x0600372B RID: 14123 RVA: 0x001E06FC File Offset: 0x001DE8FC
		public DataTable GetAdditionalSettingsPrinters(string conn, int coid, string branch, string receipt_template)
		{
			SqlConnection sqlConnection = new SqlConnection(conn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"Select top 1 * from AdditionalSettings where coid=",
				MyProject.Forms.Form1.coid.ToString(),
				" and branch='",
				branch,
				"' and receipt_template='",
				receipt_template,
				"'"
			});
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x0600372C RID: 14124 RVA: 0x001E0790 File Offset: 0x001DE990
		public DataTable GetAdditionalSettings(string conn, int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(conn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"Select top 1 * from AdditionalSettings where coid=",
				MyProject.Forms.Form1.coid.ToString(),
				" and branch='",
				branch,
				"' order by entryno"
			});
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x0600372D RID: 14125 RVA: 0x001E0818 File Offset: 0x001DEA18
		public bool CheckIfProductExists(int coid, int productid, string constring)
		{
			bool flag = false;
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "Select count(*) from products where productid=" + Conversions.ToString(productid) + " and coid=" + Conversions.ToString(coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			using (sqlConnection)
			{
				sqlConnection.Open();
				int num = sqlDataAdapter.Fill(dataTable);
				bool flag2 = num > 0;
				flag = flag2;
				sqlConnection.Close();
			}
			return flag;
		}

		// Token: 0x0600372E RID: 14126 RVA: 0x001E08C8 File Offset: 0x001DEAC8
		public int GetProductIDFromEntryno(string constring, int coid, int entryno)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "select productid from movement where coid=" + Conversions.ToString(coid) + " and entryno=" + Conversions.ToString(entryno);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			int num2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				num2 = Conversions.ToInteger(dataRow[0]);
			}
			else
			{
				num2 = 0;
			}
			return num2;
		}

		// Token: 0x0600372F RID: 14127 RVA: 0x001E0958 File Offset: 0x001DEB58
		public string GetRevmax8CharCode(string prodcode)
		{
			bool flag = prodcode.Length > 8;
			string text2;
			if (flag)
			{
				string text = prodcode.Substring(0, 8);
				text2 = text;
			}
			else
			{
				text2 = prodcode;
			}
			return text2;
		}

		// Token: 0x06003730 RID: 14128 RVA: 0x001E0988 File Offset: 0x001DEB88
		public bool InsertPriceMatrix(int productid, int coid, string branch, int qtyfrom, int qtyto, decimal sellingprice, string constring, string createdby, DateTime createddate, string createdmachinename)
		{
			bool flag;
			try
			{
				SqlConnection sqlConnection = new SqlConnection(constring);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "InsertPriceMatrix";
				sqlCommand.Parameters.AddWithValue("productid", productid);
				sqlCommand.Parameters.AddWithValue("coid", coid);
				sqlCommand.Parameters.AddWithValue("branch", branch);
				sqlCommand.Parameters.AddWithValue("qtyfrom", qtyfrom);
				sqlCommand.Parameters.AddWithValue("qtyto", qtyto);
				sqlCommand.Parameters.AddWithValue("sellingprice", sellingprice);
				sqlCommand.Parameters.AddWithValue("createdby", createdby);
				sqlCommand.Parameters.AddWithValue("createddate", createddate);
				sqlCommand.Parameters.AddWithValue("createdmachinename", createdmachinename);
				using (sqlConnection)
				{
					sqlConnection.Open();
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
				}
				flag = true;
			}
			catch (Exception ex)
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x06003731 RID: 14129 RVA: 0x001E0AF4 File Offset: 0x001DECF4
		public DataTable getPriceMatrix(int productid, int coid, string branch, string constring)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"select * from PriceMatrix where coid=",
				Conversions.ToString(coid),
				" and productid=",
				Conversions.ToString(productid),
				" and branch='",
				branch,
				"' "
			});
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06003732 RID: 14130 RVA: 0x001E0B80 File Offset: 0x001DED80
		public DateTime convertYYYYDDMM_to_Date(int dateint)
		{
			DateTime dateTime = default(DateTime);
			string text = "yyyyMMdd";
			string text2 = dateint.ToString();
			return DateTime.ParseExact(text2, text, CultureInfo.CurrentCulture);
		}

		// Token: 0x06003733 RID: 14131 RVA: 0x001E0BB8 File Offset: 0x001DEDB8
		public string getPayMethDesc(int paymethID, int coid, string constring)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "select paymentmethoddesc from paymentmethods where coid=" + Conversions.ToString(coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			string text;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				text = Conversions.ToString(dataRow["PaymentMethodDesc"]);
			}
			else
			{
				text = "";
			}
			return text;
		}

		// Token: 0x06003734 RID: 14132 RVA: 0x001E0C44 File Offset: 0x001DEE44
		public decimal GetPriceMatrixForProduct(int coid, string branch, int productid, int qty, string constring)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetPriceMatrix";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("qty", qty);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			decimal num2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				num2 = Conversions.ToDecimal(dataRow["SellingPrice"].ToString());
			}
			else
			{
				num2 = Conversions.ToDecimal("0");
			}
			return num2;
		}

		// Token: 0x06003735 RID: 14133 RVA: 0x001E0D28 File Offset: 0x001DEF28
		public DataTable BatchNumbersForProduct(int coid, string branch, int productid, int startdate, int enddate, string constring)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"select distinct batchnumber from movement where coid=",
				Conversions.ToString(coid),
				" and branch='",
				branch,
				"' and productid=",
				Conversions.ToString(productid),
				" and trandate>=",
				Conversions.ToString(startdate),
				" and trandate<=",
				Conversions.ToString(enddate),
				" and trancode=3"
			});
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06003736 RID: 14134 RVA: 0x001E0DD8 File Offset: 0x001DEFD8
		public DataTable ExpiryDatesForBatch(int coid, string branch, int productid, int startdate, int enddate, string constring, string batchnum)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"select distinct expirydate from movement where coid=",
				Conversions.ToString(coid),
				" and branch='",
				branch,
				"' and productid=",
				Conversions.ToString(productid),
				" and trandate>=",
				Conversions.ToString(startdate),
				" and trandate<=",
				Conversions.ToString(enddate),
				" and trancode=3 and batchnumber='",
				batchnum,
				"'"
			});
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06003737 RID: 14135 RVA: 0x001E0E98 File Offset: 0x001DF098
		public string GetFiscalDay(int coid, string branch, string constring, int invnum)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"select FiscalDayNo from movement where coid=",
				Conversions.ToString(coid),
				" and branch='",
				branch,
				"' and salesno=",
				Conversions.ToString(invnum)
			});
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			string text;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				text = Conversions.ToString(dataRow["FiscalDayNo"]);
			}
			else
			{
				text = "0";
			}
			return text;
		}

		// Token: 0x06003738 RID: 14136 RVA: 0x001E0F4C File Offset: 0x001DF14C
		public string GetDatabaseName(string connectionString)
		{
			string text = string.Empty;
			bool flag = !string.IsNullOrEmpty(connectionString);
			if (flag)
			{
				try
				{
					Regex regex = new Regex("(Initial Catalog=|Database =)([^;]+)");
					Match match = regex.Match(connectionString);
					bool success = match.Success;
					if (success)
					{
						text = match.Groups[2].Value;
					}
				}
				catch (Exception ex)
				{
					text = string.Empty;
				}
			}
			return text.Trim();
		}

		// Token: 0x06003739 RID: 14137 RVA: 0x001E0FDC File Offset: 0x001DF1DC
		public void DeleteOldBackupFiles(string directoryPath, int daysToKeep)
		{
			string[] files = Directory.GetFiles(directoryPath, "*.bak");
			DateTime dateTime = DateTime.Now.AddDays((double)(checked(0 - daysToKeep)));
			foreach (string text in files)
			{
				FileInfo fileInfo = new FileInfo(text);
				bool flag = DateTime.Compare(fileInfo.LastWriteTime, dateTime) < 0;
				if (flag)
				{
					fileInfo.Delete();
				}
			}
		}

		// Token: 0x0600373A RID: 14138 RVA: 0x001E1054 File Offset: 0x001DF254
		public string GetServerName(string connectionString)
		{
			string text = string.Empty;
			bool flag = !string.IsNullOrEmpty(connectionString);
			if (flag)
			{
				try
				{
					Regex regex = new Regex("(Data Source=)([^;]+)");
					Match match = regex.Match(connectionString);
					bool success = match.Success;
					if (success)
					{
						text = match.Groups[2].Value;
						text = text.Substring(0, text.IndexOf("\\"));
					}
				}
				catch (Exception ex)
				{
					text = string.Empty;
				}
			}
			return text.Trim();
		}

		// Token: 0x0600373B RID: 14139 RVA: 0x001E10F4 File Offset: 0x001DF2F4
		public bool CheckIfDBBackupSet(int lacoid, string constring)
		{
			bool flag4;
			try
			{
				SqlConnection sqlConnection = new SqlConnection(constring);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.Text;
				sqlCommand.CommandText = "select top 1 BackupDaily from company where companyid=" + Conversions.ToString(lacoid);
				DataTable dataTable = new DataTable();
				SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
				int num = sqlDataAdapter.Fill(dataTable);
				bool flag = num > 0;
				if (flag)
				{
					DataRow dataRow = dataTable.Rows[0];
					bool flag2 = Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow[0]));
					bool flag3 = flag2;
					if (flag3)
					{
						flag4 = false;
					}
					else
					{
						bool flag5 = Conversions.ToBoolean(dataRow[0]);
						bool flag6 = flag5;
						if (flag6)
						{
							flag4 = true;
						}
						else
						{
							flag4 = false;
						}
					}
				}
				else
				{
					flag4 = false;
				}
			}
			catch (Exception ex)
			{
				flag4 = false;
			}
			return flag4;
		}

		// Token: 0x0600373C RID: 14140 RVA: 0x001E11D0 File Offset: 0x001DF3D0
		public bool SetDBBackup(int coid, bool dodaily, string constring)
		{
			bool flag;
			try
			{
				SqlConnection sqlConnection = new SqlConnection(constring);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.Text;
				if (dodaily)
				{
					sqlCommand.CommandText = "update company set BackUpDaily=1 where companyid=" + Conversions.ToString(coid);
				}
				else
				{
					sqlCommand.CommandText = "update company set BackUpDaily=0 where companyid=" + Conversions.ToString(coid);
				}
				using (sqlConnection)
				{
					sqlConnection.Open();
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
				}
				flag = true;
			}
			catch (Exception ex)
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x0600373D RID: 14141 RVA: 0x001E128C File Offset: 0x001DF48C
		public decimal GetStockAvailableIterate(int productid, int thecoid, string thebranch, string _cnn)
		{
			int num = 0;
			SqlConnection sqlConnection = new SqlConnection(_cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "TotalStockIn";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("coid", thecoid);
			sqlCommand.Parameters.AddWithValue("branch", thebranch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			using (sqlConnection)
			{
				sqlConnection.Open();
				int num2 = sqlDataAdapter.Fill(dataTable);
				bool flag = num2 > 0;
				if (flag)
				{
					DataRow dataRow = dataTable.Rows[0];
					num = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow[0])), 0, RuntimeHelpers.GetObjectValue(dataRow[0])));
				}
				else
				{
					num = 0;
				}
				sqlConnection.Close();
			}
			int num3 = 0;
			SqlConnection sqlConnection3 = new SqlConnection(_cnn);
			SqlCommand sqlCommand2 = sqlConnection3.CreateCommand();
			sqlCommand2.CommandType = CommandType.StoredProcedure;
			sqlCommand2.CommandText = "TotalStockOut";
			sqlCommand2.Parameters.AddWithValue("productid", productid);
			sqlCommand2.Parameters.AddWithValue("coid", thecoid);
			sqlCommand2.Parameters.AddWithValue("branch", thebranch);
			DataTable dataTable2 = new DataTable();
			SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(sqlCommand2);
			using (sqlConnection3)
			{
				sqlConnection3.Open();
				int num4 = sqlDataAdapter2.Fill(dataTable2);
				bool flag2 = num4 > 0;
				if (flag2)
				{
					DataRow dataRow2 = dataTable2.Rows[0];
					num3 = Conversions.ToInteger(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow2[0])), 0, RuntimeHelpers.GetObjectValue(dataRow2[0])));
				}
				else
				{
					num3 = 0;
				}
				sqlConnection3.Close();
			}
			decimal num5 = new decimal(checked(num - num3));
			return num5;
		}

		// Token: 0x0600373E RID: 14142 RVA: 0x001E14B8 File Offset: 0x001DF6B8
		public decimal GetStockBalEntryNo(int thecoid, string thebranch, int productid, int entryno, string _cnn)
		{
			decimal num = 0m;
			SqlConnection sqlConnection = new SqlConnection(_cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "StockBalanceByEntryNo";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("coid", thecoid);
			sqlCommand.Parameters.AddWithValue("branch", thebranch);
			sqlCommand.Parameters.AddWithValue("entryno", entryno);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			using (sqlConnection)
			{
				sqlConnection.Open();
				int num2 = sqlDataAdapter.Fill(dataTable);
				bool flag = num2 > 0;
				if (flag)
				{
					DataRow dataRow = dataTable.Rows[0];
					num = Conversions.ToDecimal(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow[0])), 0, RuntimeHelpers.GetObjectValue(dataRow[0])));
				}
				else
				{
					num = 0m;
				}
				sqlConnection.Close();
			}
			return num;
		}

		// Token: 0x0600373F RID: 14143 RVA: 0x001E15F4 File Offset: 0x001DF7F4
		public int CheckIfIshidaExportOk(string conn, int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(conn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "select count(*) from products where isactive=1 and coid=" + Conversions.ToString(MyProject.Forms.Form1.coid) + " and isscaleproduct=1 and isactive=1 and len(productcode)>" + Conversions.ToString(this.GetBarcodeScaleCodeLen(conn, coid, branch));
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			int num2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				num2 = Conversions.ToInteger(dataRow[0]);
			}
			else
			{
				num2 = 0;
			}
			return num2;
		}

		// Token: 0x06003740 RID: 14144 RVA: 0x001E16C0 File Offset: 0x001DF8C0
		public int GetBarcodeScaleCodeLen(string conn, int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(conn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "BarcodeScaleSettingsSelect";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			int num2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				num2 = Conversions.ToInteger(dataRow["CodeLength"]);
			}
			else
			{
				num2 = 0;
			}
			return num2;
		}

		// Token: 0x06003741 RID: 14145 RVA: 0x001E1764 File Offset: 0x001DF964
		public DataTable GetishidaExportList(string conn)
		{
			SqlConnection sqlConnection = new SqlConnection(conn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "ExportIshidaConnectedScaleSettings";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06003742 RID: 14146 RVA: 0x001E17D8 File Offset: 0x001DF9D8
		public DataTable GetTeraokaExportList(string conn)
		{
			SqlConnection sqlConnection = new SqlConnection(conn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "ExportTeraokaConnectedScaleSettings";
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06003743 RID: 14147 RVA: 0x001E184C File Offset: 0x001DFA4C
		public int IsZimraVIrtualFiscalised(string conn, int coid, string deviceid, DateTime fiscaldate, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(conn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FiscalIsFiscalDayClosed";
			sqlCommand.Parameters.AddWithValue("deviceid", deviceid);
			sqlCommand.Parameters.AddWithValue("fiscaldate", fiscaldate);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			int num2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				num2 = Conversions.ToInteger(dataRow["isficaldayclosed"]);
			}
			else
			{
				num2 = 0;
			}
			return num2;
		}

		// Token: 0x06003744 RID: 14148 RVA: 0x001E192C File Offset: 0x001DFB2C
		public string FiscalGetDeviceID(string conn, string deviceSerial, int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(conn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FiscalGetDeviceID";
			sqlCommand.Parameters.AddWithValue("deviceSerial", deviceSerial);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			string text;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				text = Conversions.ToString(dataRow["deviceID"]);
			}
			else
			{
				text = "";
			}
			return text;
		}

		// Token: 0x06003745 RID: 14149 RVA: 0x001E19F8 File Offset: 0x001DFBF8
		public string FiscalGetDeviceSerial()
		{
			string text;
			try
			{
				SelectQuery selectQuery = new SelectQuery("Win32_bios");
				ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(selectQuery);
				ManagementObject managementObject = new ManagementObject();
				text = managementObject["serialnumber"].ToString();
			}
			catch (Exception ex)
			{
				text = "";
			}
			return text;
		}

		// Token: 0x06003746 RID: 14150 RVA: 0x001E1A5C File Offset: 0x001DFC5C
		private bool FiscalIsDayClosed(string deviceID, DateTime fiscalday, int coid, string branch, string conn)
		{
			SqlConnection sqlConnection = new SqlConnection(conn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FiscalIsFiscalDayClosed";
			sqlCommand.Parameters.AddWithValue("deviceid", deviceID);
			sqlCommand.Parameters.AddWithValue("fiscaldate", fiscalday);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			DataTable dataTable = new DataTable();
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			bool flag3;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				bool flag2 = Operators.ConditionalCompareObjectEqual(dataRow["isficaldayclosed"], 1, false);
				flag3 = flag2;
			}
			else
			{
				flag3 = false;
			}
			return flag3;
		}

		// Token: 0x06003747 RID: 14151 RVA: 0x001E1B50 File Offset: 0x001DFD50
		public string FiscalOpenFiscalDay(string deviceID, DateTime fiscalday, int coid, string branch, string conn)
		{
			bool flag = this.FiscalIsDayClosed(deviceID, fiscalday, coid, branch, conn);
			bool flag2 = flag;
			string text;
			if (flag2)
			{
				text = "FISCAL DAY ALREADY CLOSED";
			}
			else
			{
				SqlConnection sqlConnection = new SqlConnection(conn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "FiscalOpenFiscalDay";
				sqlCommand.Parameters.AddWithValue("deviceid", deviceID);
				sqlCommand.Parameters.AddWithValue("fiscaldate", fiscalday);
				sqlCommand.Parameters.AddWithValue("branch", branch);
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				using (sqlConnection)
				{
					sqlConnection.Open();
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
				}
				text = "DAY OPENED";
			}
			return text;
		}

		// Token: 0x06003748 RID: 14152 RVA: 0x001E1C4C File Offset: 0x001DFE4C
		public string FiscalCloseFiscalDay(string deviceID, DateTime fiscalday, int coid, string branch, string conn)
		{
			bool flag = this.FiscalIsDayClosed(deviceID, fiscalday, coid, branch, conn);
			bool flag2 = flag;
			string text;
			if (flag2)
			{
				text = "FISCAL DAY ALREADY CLOSED";
			}
			else
			{
				SqlConnection sqlConnection = new SqlConnection(conn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "FiscalCloseFiscalDay";
				sqlCommand.Parameters.AddWithValue("deviceid", deviceID);
				sqlCommand.Parameters.AddWithValue("fiscaldate", fiscalday);
				sqlCommand.Parameters.AddWithValue("branch", branch);
				sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
				using (sqlConnection)
				{
					sqlConnection.Open();
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
				}
				text = "";
			}
			return text;
		}

		// Token: 0x06003749 RID: 14153 RVA: 0x001E1D48 File Offset: 0x001DFF48
		public string pstrSystemSerialNumber()
		{
			SelectQuery selectQuery = new SelectQuery("Win32_bios");
			ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(selectQuery);
			string text = "";
			try
			{
				foreach (ManagementBaseObject managementBaseObject in managementObjectSearcher.Get())
				{
					ManagementObject managementObject = (ManagementObject)managementBaseObject;
					text = managementObject["SerialNumber"].ToString();
				}
			}
			finally
			{
				ManagementObjectCollection.ManagementObjectEnumerator enumerator;
				if (enumerator != null)
				{
					((IDisposable)enumerator).Dispose();
				}
			}
			return text;
		}

		// Token: 0x0600374A RID: 14154 RVA: 0x001E1DD0 File Offset: 0x001DFFD0
		public DataTable SearchInvoiceComments(string con, int coid, string branch, string searchtext, int startdate, int enddate, int alldates)
		{
			SqlConnection sqlConnection = new SqlConnection(con);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SearchComments";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("searchtext", searchtext);
			sqlCommand.Parameters.AddWithValue("startdate", startdate);
			sqlCommand.Parameters.AddWithValue("Enddate", enddate);
			sqlCommand.Parameters.AddWithValue("alldates", alldates);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x0600374B RID: 14155 RVA: 0x001E1EA0 File Offset: 0x001E00A0
		public string GetDigSig(int invnum, string branch, int coid, string con)
		{
			SqlConnection sqlConnection = new SqlConnection(con);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = string.Concat(new string[]
			{
				"select top 1 DigSig from movement where invoicenum=",
				invnum.ToString(),
				" and coid=",
				coid.ToString(),
				"and branch='",
				branch,
				"' and trancode=3"
			});
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			string text;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				text = Conversions.ToString(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(dataRow["DigSig"])), "", RuntimeHelpers.GetObjectValue(dataRow["DigSig"])));
			}
			else
			{
				text = "";
			}
			return text;
		}

		// Token: 0x0600374C RID: 14156 RVA: 0x001E1F84 File Offset: 0x001E0184
		public int GetFiscalDayNo(string deviceID, DateTime fiscaldate, string branch, int coid, string con)
		{
			SqlConnection sqlConnection = new SqlConnection(con);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "FiscalGetFiscalDayNo";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("fiscalday", fiscaldate);
			sqlCommand.Parameters.AddWithValue("deviveid", deviceID);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			bool flag = num > 0;
			int num2;
			if (flag)
			{
				DataRow dataRow = dataTable.Rows[0];
				num2 = Conversions.ToInteger(dataRow[0]);
			}
			else
			{
				num2 = 0;
			}
			return num2;
		}

		// Token: 0x0600374D RID: 14157 RVA: 0x001E2050 File Offset: 0x001E0250
		public DataTable LoadKDUs(string con)
		{
			SqlConnection sqlConnection = new SqlConnection(con);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "Select * from KitchenDisplayUnits";
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x0600374E RID: 14158 RVA: 0x001E20A8 File Offset: 0x001E02A8
		public DataTable RunRevmaxDATItems(DataGridView dgv)
		{
			DataTable dataTable = new DataTable();
			dataTable.Columns.Add("ProductCode", typeof(string));
			dataTable.Columns.Add("ProductDesc", typeof(string));
			dataTable.Columns.Add("Qty", typeof(decimal));
			dataTable.Columns.Add("SellingPrice", typeof(decimal));
			dataTable.Columns.Add("Total", typeof(decimal));
			dataTable.Columns.Add("Tax", typeof(decimal));
			dataTable.Columns.Add("Taxr", typeof(decimal));
			try
			{
				foreach (object obj in ((IEnumerable)dgv.Rows))
				{
					DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
					decimal num = Conversions.ToDecimal(dataGridViewRow.Cells["taxr"].Value);
					decimal num2 = Math.Round(Conversions.ToDecimal(dataGridViewRow.Cells["Tax"].Value), 3, MidpointRounding.AwayFromZero);
					decimal num3 = Math.Round(Conversions.ToDecimal(dataGridViewRow.Cells["UnitPrice"].Value), 3, MidpointRounding.AwayFromZero);
					decimal num4 = Math.Round(Conversions.ToDecimal(dataGridViewRow.Cells["Qty"].Value), 3, MidpointRounding.AwayFromZero);
					decimal num5 = decimal.Add(decimal.Multiply(num4, num3), num2);
					dataTable.Rows.Add(new object[]
					{
						this.GetRevmax8CharCode(dataGridViewRow.Cells["HSCode"].Value.ToString()),
						dataGridViewRow.Cells["Desc"].Value,
						Math.Round(Conversions.ToDecimal(dataGridViewRow.Cells["Qty"].Value), 3, MidpointRounding.AwayFromZero),
						Math.Round(Conversions.ToDecimal(dataGridViewRow.Cells["UnitPrice"].Value), 3, MidpointRounding.AwayFromZero),
						Math.Round(Conversions.ToDecimal(dataGridViewRow.Cells["Total"].Value), 3, MidpointRounding.AwayFromZero).ToString(),
						Math.Round(Conversions.ToDecimal(dataGridViewRow.Cells["Tax"].Value), 3, MidpointRounding.AwayFromZero),
						dataGridViewRow.Cells["taxr"].Value
					});
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
			return dataTable;
		}

		// Token: 0x0600374F RID: 14159 RVA: 0x001E2384 File Offset: 0x001E0584
		public string BuildItemsXML(DataTable prodt_items)
		{
			MemoryStream memoryStream = new MemoryStream();
			XmlWriter xmlWriter = XmlWriter.Create(memoryStream, new XmlWriterSettings
			{
				Indent = true,
				OmitXmlDeclaration = true
			});
			xmlWriter.WriteStartDocument(true);
			xmlWriter.WriteStartElement("ITEMS");
			int num = 0;
			checked
			{
				try
				{
					foreach (object obj in prodt_items.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						num++;
						decimal num2 = Conversions.ToDecimal(dataRow["Total"]);
						this.MakeItems(xmlWriter, num, Conversions.ToString(dataRow["ProductCode"]), Conversions.ToString(dataRow["ProductDesc"]), Conversions.ToString(dataRow["ProductDesc"]), Conversions.ToDecimal(dataRow["Qty"]), Conversions.ToDecimal(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[]
						{
							Operators.AddObject(dataRow["SellingPrice"], Operators.MultiplyObject(dataRow["Taxr"], dataRow["SellingPrice"])),
							3,
							MidpointRounding.AwayFromZero
						}, null, null, null)), Conversions.ToDecimal(dataRow["Total"]), Conversions.ToDecimal(dataRow["Tax"]), Conversions.ToDecimal(dataRow["Taxr"]));
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
				xmlWriter.WriteEndElement();
				xmlWriter.WriteEndDocument();
				xmlWriter.Flush();
				StreamReader streamReader = new StreamReader(memoryStream);
				memoryStream.Seek(0L, SeekOrigin.Begin);
				string text = streamReader.ReadToEnd();
				xmlWriter.Close();
				return text;
			}
		}

		// Token: 0x06003750 RID: 14160 RVA: 0x001E2570 File Offset: 0x001E0770
		private void MakeItems(XmlWriter xml_text_writer, int item_number, string item_code, string item_desc, string item_desc2, decimal item_qty, decimal item_price, decimal item_amt, decimal item_tax, decimal item_taxr)
		{
			xml_text_writer.WriteStartElement("ITEM");
			xml_text_writer.WriteStartElement("HH");
			xml_text_writer.WriteString(Conversions.ToString(item_number));
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteStartElement("ITEMCODE");
			xml_text_writer.WriteString(item_code);
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteStartElement("ITEMNAME1");
			xml_text_writer.WriteString(item_desc);
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteStartElement("ITEMNAME2");
			xml_text_writer.WriteString(item_desc2);
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteStartElement("QTY");
			xml_text_writer.WriteString(Conversions.ToString(item_qty));
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteStartElement("PRICE");
			xml_text_writer.WriteString(Conversions.ToString(item_price));
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteStartElement("AMT");
			xml_text_writer.WriteString(Conversions.ToString(item_amt));
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteStartElement("TAX");
			xml_text_writer.WriteString(Conversions.ToString(item_tax));
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteStartElement("TAXR");
			xml_text_writer.WriteString(Conversions.ToString(item_taxr));
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteEndElement();
		}

		// Token: 0x06003751 RID: 14161 RVA: 0x001E26AC File Offset: 0x001E08AC
		private void MakeCurrency(XmlWriter xml_text_writer, string Name, decimal curr_amt, decimal rate)
		{
			xml_text_writer.WriteStartElement("Currency");
			xml_text_writer.WriteStartElement("Name");
			xml_text_writer.WriteString(Name);
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteStartElement("Amount");
			xml_text_writer.WriteString(Conversions.ToString(curr_amt));
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteStartElement("Rate");
			xml_text_writer.WriteString(Conversions.ToString(rate));
			xml_text_writer.WriteEndElement();
			xml_text_writer.WriteEndElement();
		}

		// Token: 0x06003752 RID: 14162 RVA: 0x001E272C File Offset: 0x001E092C
		public string BuildCurrencyXML(string currency_desc, decimal currency_amt, decimal currency_rate)
		{
			MemoryStream memoryStream = new MemoryStream();
			XmlWriter xmlWriter = XmlWriter.Create(memoryStream, new XmlWriterSettings
			{
				Indent = true,
				OmitXmlDeclaration = true
			});
			xmlWriter.WriteStartDocument(true);
			xmlWriter.WriteStartElement("CurrenciesReceived");
			bool flag = Operators.CompareString(currency_desc, "USD", false) == 0;
			if (flag)
			{
				this.MakeCurrency(xmlWriter, "ZWG", 0m, 130m);
				this.MakeCurrency(xmlWriter, currency_desc, currency_amt, currency_rate);
			}
			else
			{
				bool flag2 = Operators.CompareString(currency_desc, "ZWG", false) == 0;
				if (flag2)
				{
					this.MakeCurrency(xmlWriter, currency_desc, currency_amt, currency_rate);
					this.MakeCurrency(xmlWriter, "USD", 0m, 1m);
				}
				else
				{
					MessageBox.Show("Currency is not USD or ZWG. Contact System Developer.");
				}
			}
			xmlWriter.WriteEndElement();
			xmlWriter.WriteEndDocument();
			xmlWriter.Flush();
			StreamReader streamReader = new StreamReader(memoryStream);
			memoryStream.Seek(0L, SeekOrigin.Begin);
			string text = streamReader.ReadToEnd();
			xmlWriter.Close();
			return text;
		}

		// Token: 0x06003753 RID: 14163 RVA: 0x001E2838 File Offset: 0x001E0A38
		public DataTable GetBranchDetails(int thecoid, string thebranch, string constring)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetBranchDetails";
			sqlCommand.Parameters.AddWithValue("coid", thecoid);
			sqlCommand.Parameters.AddWithValue("branch", thebranch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06003754 RID: 14164 RVA: 0x001E28B0 File Offset: 0x001E0AB0
		public bool IsInvoiceFiscalisedRevmax(int coid, string branch, int invnum, string constring)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "IsInvFiscalised";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("invnum", invnum);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable.Rows.Count > 0;
		}

		// Token: 0x06003755 RID: 14165 RVA: 0x001E2958 File Offset: 0x001E0B58
		public bool IsInvoiceFiscalisedRevmaxCredit(int coid, string branch, int invnum, string constring)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "IsInvFiscalisedCredit";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("invnum", invnum);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable.Rows.Count > 0;
		}

		// Token: 0x06003756 RID: 14166 RVA: 0x001E2A00 File Offset: 0x001E0C00
		public DataTable GetSalesInvData(int coid, string branch, int invnum, string constring)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetSalesInvData";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("invnum", invnum);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06003757 RID: 14167 RVA: 0x001E2A90 File Offset: 0x001E0C90
		public void SaveDigSig(Bitmap digsig, int invnum, string branch, int coid, string veri_code, string veri_link, string tax_invnum, string fiscaldayno, string receiptglobalno, string deviceno, string constring)
		{
			byte[] array;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				digsig.Save(memoryStream, ImageFormat.Bmp);
				array = memoryStream.ToArray();
			}
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SaveQRCode";
			sqlCommand.Parameters.AddWithValue("qrcode", array);
			sqlCommand.Parameters.AddWithValue("invnum", invnum);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("verificationlink", veri_link);
			sqlCommand.Parameters.AddWithValue("verificationcode", veri_code);
			sqlCommand.Parameters.AddWithValue("tax_invnum", tax_invnum);
			sqlCommand.Parameters.AddWithValue("FiscalDayNo", fiscaldayno);
			sqlCommand.Parameters.AddWithValue("ReceiptGlobalNo", receiptglobalno);
			sqlCommand.Parameters.AddWithValue("DeviceNo", deviceno);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06003758 RID: 14168 RVA: 0x001E2BF4 File Offset: 0x001E0DF4
		public DataTable GetInvoiceDetails(int invnum, string constring, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetInvoiceDetailsFiscal";
			sqlCommand.Parameters.AddWithValue("invoicenum", invnum);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06003759 RID: 14169 RVA: 0x001E2C90 File Offset: 0x001E0E90
		public DataTable GetPayDetails(int invnum, string constring, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetInvoicePayDetailsFiscal";
			sqlCommand.Parameters.AddWithValue("invoicenum", invnum);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x0600375A RID: 14170 RVA: 0x001E2D2C File Offset: 0x001E0F2C
		public DataTable GetCancelledProducts(int invnum, string constring, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetCancelledInvoiceDetails";
			sqlCommand.Parameters.AddWithValue("invoicenum", invnum);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x0600375B RID: 14171 RVA: 0x001E2DC8 File Offset: 0x001E0FC8
		public DataTable GetZimCities(string constring)
		{
			SqlConnection sqlConnection = new SqlConnection(constring);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.Text;
			sqlCommand.CommandText = "select city from ZimCities";
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x0600375C RID: 14172 RVA: 0x001E2E14 File Offset: 0x001E1014
		public DataTable GetBarcodeScaleSettings(int coid, string branch, string conn)
		{
			SqlConnection sqlConnection = new SqlConnection(conn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "BarcodeScaleSettingsSelect";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x0600375D RID: 14173 RVA: 0x001E2E8C File Offset: 0x001E108C
		public bool AdditionalSettings2Save(int coid, string branch, string SettingName, string SettingValue, string conn)
		{
			bool flag;
			try
			{
				SqlConnection sqlConnection = new SqlConnection(conn);
				SqlCommand sqlCommand = sqlConnection.CreateCommand();
				sqlCommand.CommandType = CommandType.StoredProcedure;
				sqlCommand.CommandText = "SaveAdditionalSetting";
				sqlCommand.Parameters.AddWithValue("SettingName", SettingName);
				sqlCommand.Parameters.AddWithValue("SettingValue", SettingValue);
				sqlCommand.Parameters.AddWithValue("branch", branch);
				sqlCommand.Parameters.AddWithValue("coid", coid);
				using (sqlConnection)
				{
					sqlConnection.Open();
					sqlCommand.ExecuteNonQuery();
					sqlConnection.Close();
				}
				flag = true;
			}
			catch (Exception ex)
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x0600375E RID: 14174 RVA: 0x001E2F68 File Offset: 0x001E1168
		public string AdditionalSettings2Check(int coid, string branch, string SettingName, string conn)
		{
			string text2;
			try
			{
				string text = string.Concat(new string[]
				{
					"coid = ",
					Conversions.ToString(coid),
					" AND branch = '",
					branch,
					"' and SettingName='",
					Strings.Trim(SettingName),
					"'"
				});
				DataRow[] array = MyProject.Forms.Form1.AdditionalSettingsDAT.Select(text);
				bool flag = array.Count<DataRow>() > 0;
				if (flag)
				{
					DataRow dataRow = array[0];
					text2 = Conversions.ToString(dataRow["SettingValue"]);
				}
				else
				{
					text2 = "";
				}
			}
			catch (Exception ex)
			{
				text2 = "";
			}
			return text2;
		}

		// Token: 0x0600375F RID: 14175 RVA: 0x001E3028 File Offset: 0x001E1228
		public DataTable AdditionalSettingsGetAll(int coid, string branch, string conn)
		{
			SqlConnection sqlConnection = new SqlConnection(conn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetAdditionalSetting2";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06003760 RID: 14176 RVA: 0x001E30A0 File Offset: 0x001E12A0
		public DataTable GetSupplierAging(int coid, int supplierid, string conn)
		{
			SqlConnection sqlConnection = new SqlConnection(conn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "CalculateSupplierAgingFIFO";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("supplierid", supplierid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06003761 RID: 14177 RVA: 0x001E311C File Offset: 0x001E131C
		public DataTable getPacketSizeGroups(int coid, string conn)
		{
			DataTable dataTable2;
			using (SqlConnection sqlConnection = new SqlConnection(conn))
			{
				string text = "select * from PacketSizeGroupHeader where coid=@coid";
				using (SqlCommand sqlCommand = new SqlCommand(text, sqlConnection))
				{
					sqlCommand.Parameters.AddWithValue("coid", coid);
					using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
					{
						sqlDataAdapter.SelectCommand = sqlCommand;
						using (DataTable dataTable = new DataTable())
						{
							sqlDataAdapter.Fill(dataTable);
							dataTable2 = dataTable;
						}
					}
				}
			}
			return dataTable2;
		}

		// Token: 0x06003762 RID: 14178 RVA: 0x001E31EC File Offset: 0x001E13EC
		public DataTable PacketSizesGetListforGroup(int groupid, string conn)
		{
			DataTable dataTable2;
			using (SqlConnection sqlConnection = new SqlConnection(conn))
			{
				string text = "select pd.groupid as GroupID,ph.psgroupname as Group_Name,p.packetsizename as Packet_Size_Name,p.packetsizeqty as Packet_Size_Qty,p.entryno as PacketSizeEntryno, pd.entryno from packetsizegroupdetail pd inner join packetsizegroupheader ph on pd.groupid=ph.groupid inner join PacketSizes p on pd.packetsizesentryno=p.entryno where pd.groupid=@groupid";
				using (SqlCommand sqlCommand = new SqlCommand(text, sqlConnection))
				{
					sqlCommand.Parameters.AddWithValue("groupid", groupid);
					using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
					{
						sqlDataAdapter.SelectCommand = sqlCommand;
						using (DataTable dataTable = new DataTable())
						{
							sqlDataAdapter.Fill(dataTable);
							dataTable2 = dataTable;
						}
					}
				}
			}
			return dataTable2;
		}

		// Token: 0x06003763 RID: 14179 RVA: 0x001E32BC File Offset: 0x001E14BC
		public DataTable PacketSizesForProductGet(int coid, string branch, int productid, string conn)
		{
			DataTable dataTable2;
			using (SqlConnection sqlConnection = new SqlConnection(conn))
			{
				string text = "select pb.packetsizesentryno,pb.entryno,p.packetsizename from packetsizebranchprices pb inner join packetsizes p on pb.packetsizesentryno=p.entryno where pb.coid=@coid and p.coid=@coid and productid=@productid and branch=@branch order by p.packetsizeqty desc";
				using (SqlCommand sqlCommand = new SqlCommand(text, sqlConnection))
				{
					sqlCommand.Parameters.AddWithValue("coid", coid);
					sqlCommand.Parameters.AddWithValue("branch", branch);
					sqlCommand.Parameters.AddWithValue("productid", productid);
					using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
					{
						sqlDataAdapter.SelectCommand = sqlCommand;
						using (DataTable dataTable = new DataTable())
						{
							sqlDataAdapter.Fill(dataTable);
							dataTable2 = dataTable;
						}
					}
				}
			}
			return dataTable2;
		}

		// Token: 0x06003764 RID: 14180 RVA: 0x001E33B4 File Offset: 0x001E15B4
		public DataTable PacketSizesGetPrice(int entryno, string conn)
		{
			DataTable dataTable2;
			using (SqlConnection sqlConnection = new SqlConnection(conn))
			{
				string text = "select pb.sellingpriceperunit,p.packetsizeqty from packetsizebranchprices pb inner join packetsizes p on pb.packetsizesentryno=p.entryno where pb.entryno=@entryno";
				using (SqlCommand sqlCommand = new SqlCommand(text, sqlConnection))
				{
					sqlCommand.Parameters.AddWithValue("entryno", entryno);
					using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
					{
						sqlDataAdapter.SelectCommand = sqlCommand;
						using (DataTable dataTable = new DataTable())
						{
							sqlDataAdapter.Fill(dataTable);
							dataTable2 = dataTable;
						}
					}
				}
			}
			return dataTable2;
		}

		// Token: 0x06003765 RID: 14181 RVA: 0x001E3484 File Offset: 0x001E1684
		public Bitmap GenerateQrImage(string content, int targetSize)
		{
			CodeQrBarcodeDraw codeQr = BarcodeDrawFactory.CodeQr;
			Image image = codeQr.Draw(content, 1);
			Bitmap bitmap = new Bitmap(image, new Size(targetSize, targetSize));
			bitmap.SetResolution(300f, 300f);
			return bitmap;
		}

		// Token: 0x06003766 RID: 14182 RVA: 0x001E34C8 File Offset: 0x001E16C8
		public DataTable GetCoids(string conn)
		{
			DataTable dataTable2;
			using (SqlConnection sqlConnection = new SqlConnection(conn))
			{
				string text = "select distinct companyid,company from company";
				using (SqlCommand sqlCommand = new SqlCommand(text, sqlConnection))
				{
					using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
					{
						sqlDataAdapter.SelectCommand = sqlCommand;
						using (DataTable dataTable = new DataTable())
						{
							sqlDataAdapter.Fill(dataTable);
							dataTable2 = dataTable;
						}
					}
				}
			}
			return dataTable2;
		}

		// Token: 0x06003767 RID: 14183 RVA: 0x001E3580 File Offset: 0x001E1780
		public bool IsUserAdminCreated(int coid, string conn)
		{
			bool flag3;
			using (SqlConnection sqlConnection = new SqlConnection(conn))
			{
				string text = "select count(*) from users where coid=" + Conversions.ToString(coid) + " and username='Admin'";
				using (SqlCommand sqlCommand = new SqlCommand(text, sqlConnection))
				{
					using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter())
					{
						sqlDataAdapter.SelectCommand = sqlCommand;
						using (DataTable dataTable = new DataTable())
						{
							sqlDataAdapter.Fill(dataTable);
							bool flag = dataTable.Rows.Count > 0;
							if (flag)
							{
								DataRow dataRow = dataTable.Rows[0];
								bool flag2 = Operators.ConditionalCompareObjectGreater(dataRow[0], 0, false);
								if (flag2)
								{
									flag3 = true;
								}
								else
								{
									flag3 = false;
								}
							}
							else
							{
								flag3 = false;
							}
						}
					}
				}
			}
			return flag3;
		}

		// Token: 0x06003768 RID: 14184 RVA: 0x001E3690 File Offset: 0x001E1890
		public void SaveCredentials(string uname, string pwd, bool isadmin, bool issup, string branch, bool isallbranches, string realname, int datecreated, string createdby, string conn, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(conn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			DataTable dataTable = new DataTable();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "SaveCredentials";
			sqlCommand.Parameters.AddWithValue("username", uname);
			sqlCommand.Parameters.AddWithValue("pwd", pwd);
			sqlCommand.Parameters.AddWithValue("isadmin", isadmin);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("issup", issup);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("isallbranches", isallbranches);
			sqlCommand.Parameters.AddWithValue("realname", realname);
			sqlCommand.Parameters.AddWithValue("datecreated", datecreated);
			sqlCommand.Parameters.AddWithValue("createdby", createdby);
			SqlConnection sqlConnection2 = sqlConnection;
			sqlConnection2.Open();
			sqlCommand.ExecuteNonQuery();
			sqlConnection2.Close();
		}

		// Token: 0x04001779 RID: 6009
		public DataTable menuDat;
	}
}
