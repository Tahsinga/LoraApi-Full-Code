using System;
using System.Collections;
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
	// Token: 0x02000171 RID: 369
	[DesignerGenerated]
	public partial class ProductOrderComments : Form
	{
		// Token: 0x06003421 RID: 13345 RVA: 0x001C281C File Offset: 0x001C0A1C
		public ProductOrderComments()
		{
			base.Load += this.ProductOrderComments_Load;
			this.comment = "";
			this.productid = 0;
			this._cnn = MyProject.Forms.Form1.Constring;
			this.pf = new PublicFunctions();
			this.InitializeComponent();
		}

		// Token: 0x1700135C RID: 4956
		// (get) Token: 0x06003424 RID: 13348 RVA: 0x001C46F4 File Offset: 0x001C28F4
		// (set) Token: 0x06003425 RID: 13349 RVA: 0x001C46FE File Offset: 0x001C28FE
		internal virtual GroupBox GroupBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700135D RID: 4957
		// (get) Token: 0x06003426 RID: 13350 RVA: 0x001C4707 File Offset: 0x001C2907
		// (set) Token: 0x06003427 RID: 13351 RVA: 0x001C4711 File Offset: 0x001C2911
		internal virtual CheckBox chkSitIn
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700135E RID: 4958
		// (get) Token: 0x06003428 RID: 13352 RVA: 0x001C471A File Offset: 0x001C291A
		// (set) Token: 0x06003429 RID: 13353 RVA: 0x001C4724 File Offset: 0x001C2924
		internal virtual GroupBox GroupBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700135F RID: 4959
		// (get) Token: 0x0600342A RID: 13354 RVA: 0x001C472D File Offset: 0x001C292D
		// (set) Token: 0x0600342B RID: 13355 RVA: 0x001C4737 File Offset: 0x001C2937
		internal virtual RadioButton radSidesNone
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001360 RID: 4960
		// (get) Token: 0x0600342C RID: 13356 RVA: 0x001C4740 File Offset: 0x001C2940
		// (set) Token: 0x0600342D RID: 13357 RVA: 0x001C474A File Offset: 0x001C294A
		internal virtual RadioButton radSidesSalad
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001361 RID: 4961
		// (get) Token: 0x0600342E RID: 13358 RVA: 0x001C4753 File Offset: 0x001C2953
		// (set) Token: 0x0600342F RID: 13359 RVA: 0x001C475D File Offset: 0x001C295D
		internal virtual RadioButton radSidesArchaar
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001362 RID: 4962
		// (get) Token: 0x06003430 RID: 13360 RVA: 0x001C4766 File Offset: 0x001C2966
		// (set) Token: 0x06003431 RID: 13361 RVA: 0x001C4770 File Offset: 0x001C2970
		internal virtual RadioButton radSidesChakalaka
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001363 RID: 4963
		// (get) Token: 0x06003432 RID: 13362 RVA: 0x001C4779 File Offset: 0x001C2979
		// (set) Token: 0x06003433 RID: 13363 RVA: 0x001C4783 File Offset: 0x001C2983
		internal virtual GroupBox GroupBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001364 RID: 4964
		// (get) Token: 0x06003434 RID: 13364 RVA: 0x001C478C File Offset: 0x001C298C
		// (set) Token: 0x06003435 RID: 13365 RVA: 0x001C4796 File Offset: 0x001C2996
		internal virtual RadioButton radCookingRare
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001365 RID: 4965
		// (get) Token: 0x06003436 RID: 13366 RVA: 0x001C479F File Offset: 0x001C299F
		// (set) Token: 0x06003437 RID: 13367 RVA: 0x001C47A9 File Offset: 0x001C29A9
		internal virtual GroupBox GroupBox6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001366 RID: 4966
		// (get) Token: 0x06003438 RID: 13368 RVA: 0x001C47B2 File Offset: 0x001C29B2
		// (set) Token: 0x06003439 RID: 13369 RVA: 0x001C47BC File Offset: 0x001C29BC
		internal virtual RadioButton radSaucesHot
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001367 RID: 4967
		// (get) Token: 0x0600343A RID: 13370 RVA: 0x001C47C5 File Offset: 0x001C29C5
		// (set) Token: 0x0600343B RID: 13371 RVA: 0x001C47CF File Offset: 0x001C29CF
		internal virtual RadioButton radSaucesMild
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001368 RID: 4968
		// (get) Token: 0x0600343C RID: 13372 RVA: 0x001C47D8 File Offset: 0x001C29D8
		// (set) Token: 0x0600343D RID: 13373 RVA: 0x001C47E2 File Offset: 0x001C29E2
		internal virtual RadioButton radSaucesBBQ
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001369 RID: 4969
		// (get) Token: 0x0600343E RID: 13374 RVA: 0x001C47EB File Offset: 0x001C29EB
		// (set) Token: 0x0600343F RID: 13375 RVA: 0x001C47F5 File Offset: 0x001C29F5
		internal virtual GroupBox GroupBox7
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700136A RID: 4970
		// (get) Token: 0x06003440 RID: 13376 RVA: 0x001C47FE File Offset: 0x001C29FE
		// (set) Token: 0x06003441 RID: 13377 RVA: 0x001C4808 File Offset: 0x001C2A08
		internal virtual RadioButton radStarchPap
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700136B RID: 4971
		// (get) Token: 0x06003442 RID: 13378 RVA: 0x001C4811 File Offset: 0x001C2A11
		// (set) Token: 0x06003443 RID: 13379 RVA: 0x001C481B File Offset: 0x001C2A1B
		internal virtual RadioButton radStarchRice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700136C RID: 4972
		// (get) Token: 0x06003444 RID: 13380 RVA: 0x001C4824 File Offset: 0x001C2A24
		// (set) Token: 0x06003445 RID: 13381 RVA: 0x001C482E File Offset: 0x001C2A2E
		internal virtual RadioButton radStarchChips
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700136D RID: 4973
		// (get) Token: 0x06003446 RID: 13382 RVA: 0x001C4837 File Offset: 0x001C2A37
		// (set) Token: 0x06003447 RID: 13383 RVA: 0x001C4841 File Offset: 0x001C2A41
		internal virtual GroupBox GroupBox8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700136E RID: 4974
		// (get) Token: 0x06003448 RID: 13384 RVA: 0x001C484A File Offset: 0x001C2A4A
		// (set) Token: 0x06003449 RID: 13385 RVA: 0x001C4854 File Offset: 0x001C2A54
		internal virtual GroupBox GroupBox5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700136F RID: 4975
		// (get) Token: 0x0600344A RID: 13386 RVA: 0x001C485D File Offset: 0x001C2A5D
		// (set) Token: 0x0600344B RID: 13387 RVA: 0x001C4868 File Offset: 0x001C2A68
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

		// Token: 0x17001370 RID: 4976
		// (get) Token: 0x0600344C RID: 13388 RVA: 0x001C48AB File Offset: 0x001C2AAB
		// (set) Token: 0x0600344D RID: 13389 RVA: 0x001C48B5 File Offset: 0x001C2AB5
		internal virtual TextBox txtGeneral
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001371 RID: 4977
		// (get) Token: 0x0600344E RID: 13390 RVA: 0x001C48BE File Offset: 0x001C2ABE
		// (set) Token: 0x0600344F RID: 13391 RVA: 0x001C48C8 File Offset: 0x001C2AC8
		internal virtual RadioButton RadioButton3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001372 RID: 4978
		// (get) Token: 0x06003450 RID: 13392 RVA: 0x001C48D1 File Offset: 0x001C2AD1
		// (set) Token: 0x06003451 RID: 13393 RVA: 0x001C48DB File Offset: 0x001C2ADB
		internal virtual RadioButton RadioButton2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001373 RID: 4979
		// (get) Token: 0x06003452 RID: 13394 RVA: 0x001C48E4 File Offset: 0x001C2AE4
		// (set) Token: 0x06003453 RID: 13395 RVA: 0x001C48EE File Offset: 0x001C2AEE
		internal virtual RadioButton RadioButton1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001374 RID: 4980
		// (get) Token: 0x06003454 RID: 13396 RVA: 0x001C48F7 File Offset: 0x001C2AF7
		// (set) Token: 0x06003455 RID: 13397 RVA: 0x001C4901 File Offset: 0x001C2B01
		internal virtual Label Label1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001375 RID: 4981
		// (get) Token: 0x06003456 RID: 13398 RVA: 0x001C490A File Offset: 0x001C2B0A
		// (set) Token: 0x06003457 RID: 13399 RVA: 0x001C4914 File Offset: 0x001C2B14
		internal virtual RadioButton RadioButton8
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001376 RID: 4982
		// (get) Token: 0x06003458 RID: 13400 RVA: 0x001C491D File Offset: 0x001C2B1D
		// (set) Token: 0x06003459 RID: 13401 RVA: 0x001C4927 File Offset: 0x001C2B27
		internal virtual RadioButton RadioButton6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001377 RID: 4983
		// (get) Token: 0x0600345A RID: 13402 RVA: 0x001C4930 File Offset: 0x001C2B30
		// (set) Token: 0x0600345B RID: 13403 RVA: 0x001C493A File Offset: 0x001C2B3A
		internal virtual RadioButton RadioButton5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001378 RID: 4984
		// (get) Token: 0x0600345C RID: 13404 RVA: 0x001C4943 File Offset: 0x001C2B43
		// (set) Token: 0x0600345D RID: 13405 RVA: 0x001C494D File Offset: 0x001C2B4D
		internal virtual GroupBox GroupBox9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001379 RID: 4985
		// (get) Token: 0x0600345E RID: 13406 RVA: 0x001C4956 File Offset: 0x001C2B56
		// (set) Token: 0x0600345F RID: 13407 RVA: 0x001C4960 File Offset: 0x001C2B60
		internal virtual RadioButton RadioButton10
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700137A RID: 4986
		// (get) Token: 0x06003460 RID: 13408 RVA: 0x001C4969 File Offset: 0x001C2B69
		// (set) Token: 0x06003461 RID: 13409 RVA: 0x001C4973 File Offset: 0x001C2B73
		internal virtual RadioButton RadioButton9
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700137B RID: 4987
		// (get) Token: 0x06003462 RID: 13410 RVA: 0x001C497C File Offset: 0x001C2B7C
		// (set) Token: 0x06003463 RID: 13411 RVA: 0x001C4986 File Offset: 0x001C2B86
		internal virtual RadioButton radCookingMediumWell
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700137C RID: 4988
		// (get) Token: 0x06003464 RID: 13412 RVA: 0x001C498F File Offset: 0x001C2B8F
		// (set) Token: 0x06003465 RID: 13413 RVA: 0x001C4999 File Offset: 0x001C2B99
		internal virtual RadioButton radCookingMedium
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700137D RID: 4989
		// (get) Token: 0x06003466 RID: 13414 RVA: 0x001C49A2 File Offset: 0x001C2BA2
		// (set) Token: 0x06003467 RID: 13415 RVA: 0x001C49AC File Offset: 0x001C2BAC
		internal virtual CheckBox CheckBox6
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700137E RID: 4990
		// (get) Token: 0x06003468 RID: 13416 RVA: 0x001C49B5 File Offset: 0x001C2BB5
		// (set) Token: 0x06003469 RID: 13417 RVA: 0x001C49BF File Offset: 0x001C2BBF
		internal virtual CheckBox CheckBox5
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x1700137F RID: 4991
		// (get) Token: 0x0600346A RID: 13418 RVA: 0x001C49C8 File Offset: 0x001C2BC8
		// (set) Token: 0x0600346B RID: 13419 RVA: 0x001C49D2 File Offset: 0x001C2BD2
		internal virtual CheckBox CheckBox4
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001380 RID: 4992
		// (get) Token: 0x0600346C RID: 13420 RVA: 0x001C49DB File Offset: 0x001C2BDB
		// (set) Token: 0x0600346D RID: 13421 RVA: 0x001C49E5 File Offset: 0x001C2BE5
		internal virtual CheckBox CheckBox3
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001381 RID: 4993
		// (get) Token: 0x0600346E RID: 13422 RVA: 0x001C49EE File Offset: 0x001C2BEE
		// (set) Token: 0x0600346F RID: 13423 RVA: 0x001C49F8 File Offset: 0x001C2BF8
		internal virtual CheckBox CheckBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001382 RID: 4994
		// (get) Token: 0x06003470 RID: 13424 RVA: 0x001C4A01 File Offset: 0x001C2C01
		// (set) Token: 0x06003471 RID: 13425 RVA: 0x001C4A0B File Offset: 0x001C2C0B
		internal virtual CheckBox CheckBox1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06003472 RID: 13426 RVA: 0x001C4A14 File Offset: 0x001C2C14
		private void ProductOrderComments_Load(object sender, EventArgs e)
		{
			try
			{
				DataTable sideMenuItems = this.GetSideMenuItems(this.productid, MyProject.Forms.Form1.coid);
				try
				{
					foreach (object obj in sideMenuItems.Rows)
					{
						DataRow dataRow = (DataRow)obj;
						string text = dataRow["Side_Menu_Item"].ToString();
						uint num = <PrivateImplementationDetails>.ComputeStringHash(text);
						if (num <= 1876288488U)
						{
							if (num != 8067113U)
							{
								if (num != 100426742U)
								{
									if (num == 1876288488U)
									{
										if (Operators.CompareString(text, "Chip sauce", false) == 0)
										{
											this.GroupBox9.Visible = true;
										}
									}
								}
								else if (Operators.CompareString(text, "Base Options", false) == 0)
								{
									this.GroupBox3.Visible = true;
								}
							}
							else if (Operators.CompareString(text, "Sauces", false) == 0)
							{
								this.GroupBox6.Visible = true;
							}
						}
						else if (num <= 3169702819U)
						{
							if (num != 2590053246U)
							{
								if (num == 3169702819U)
								{
									if (Operators.CompareString(text, "Meat Preparation", false) == 0)
									{
										this.GroupBox4.Visible = true;
									}
								}
							}
							else if (Operators.CompareString(text, "Side", false) == 0)
							{
								this.GroupBox7.Visible = true;
							}
						}
						else if (num != 3200030859U)
						{
							if (num == 3809931772U)
							{
								if (Operators.CompareString(text, "Polony", false) == 0)
								{
									this.GroupBox8.Visible = true;
								}
							}
						}
						else if (Operators.CompareString(text, "Dips", false) == 0)
						{
							this.GroupBox5.Visible = true;
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
				MessageBox.Show("Error loading form. Detail:" + ex.Message);
			}
		}

		// Token: 0x06003473 RID: 13427 RVA: 0x001C4C60 File Offset: 0x001C2E60
		private DataTable GetSideMenuItems(int productid, int coid)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "GetSideMenuforProduct";
			sqlCommand.Parameters.AddWithValue("productid", productid);
			sqlCommand.Parameters.AddWithValue("coid", coid);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			sqlDataAdapter.Fill(dataTable);
			return dataTable;
		}

		// Token: 0x06003474 RID: 13428 RVA: 0x001C4CE0 File Offset: 0x001C2EE0
		private void Button1_Click(object sender, EventArgs e)
		{
			try
			{
				string text = "";
				string text2 = "";
				string text3 = "";
				string text4 = "";
				string text5 = "";
				string text6 = "";
				string text7 = "";
				try
				{
					foreach (object obj in this.GroupBox5.Controls)
					{
						object objectValue = RuntimeHelpers.GetObjectValue(obj);
						bool flag = objectValue is RadioButton;
						if (flag)
						{
							bool flag2 = Conversions.ToBoolean(NewLateBinding.LateGet(objectValue, null, "checked", new object[0], null, null, null));
							if (flag2)
							{
								text5 = Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(objectValue, null, "text", new object[0], null, null, null), " "));
								break;
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
				try
				{
					foreach (object obj2 in this.GroupBox9.Controls)
					{
						object objectValue2 = RuntimeHelpers.GetObjectValue(obj2);
						bool flag3 = objectValue2 is CheckBox;
						if (flag3)
						{
							bool flag4 = Conversions.ToBoolean(NewLateBinding.LateGet(objectValue2, null, "checked", new object[0], null, null, null));
							if (flag4)
							{
								text6 = Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(objectValue2, null, "text", new object[0], null, null, null), " "));
								break;
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
				try
				{
					foreach (object obj3 in this.GroupBox3.Controls)
					{
						object objectValue3 = RuntimeHelpers.GetObjectValue(obj3);
						bool flag5 = objectValue3 is RadioButton;
						if (flag5)
						{
							bool flag6 = Conversions.ToBoolean(NewLateBinding.LateGet(objectValue3, null, "checked", new object[0], null, null, null));
							if (flag6)
							{
								text2 = Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(objectValue3, null, "text", new object[0], null, null, null), " "));
								break;
							}
						}
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
				try
				{
					foreach (object obj4 in this.GroupBox4.Controls)
					{
						object objectValue4 = RuntimeHelpers.GetObjectValue(obj4);
						bool flag7 = objectValue4 is RadioButton;
						if (flag7)
						{
							bool flag8 = Conversions.ToBoolean(NewLateBinding.LateGet(objectValue4, null, "checked", new object[0], null, null, null));
							if (flag8)
							{
								text = Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(objectValue4, null, "text", new object[0], null, null, null), " "));
								break;
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator4;
					if (enumerator4 is IDisposable)
					{
						(enumerator4 as IDisposable).Dispose();
					}
				}
				try
				{
					foreach (object obj5 in this.GroupBox6.Controls)
					{
						object objectValue5 = RuntimeHelpers.GetObjectValue(obj5);
						bool flag9 = objectValue5 is RadioButton;
						if (flag9)
						{
							bool flag10 = Conversions.ToBoolean(NewLateBinding.LateGet(objectValue5, null, "checked", new object[0], null, null, null));
							if (flag10)
							{
								text3 = Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(objectValue5, null, "text", new object[0], null, null, null), " "));
								break;
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator5;
					if (enumerator5 is IDisposable)
					{
						(enumerator5 as IDisposable).Dispose();
					}
				}
				try
				{
					foreach (object obj6 in this.GroupBox7.Controls)
					{
						object objectValue6 = RuntimeHelpers.GetObjectValue(obj6);
						bool flag11 = objectValue6 is RadioButton;
						if (flag11)
						{
							bool flag12 = Conversions.ToBoolean(NewLateBinding.LateGet(objectValue6, null, "checked", new object[0], null, null, null));
							if (flag12)
							{
								text4 = Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(objectValue6, null, "text", new object[0], null, null, null), " "));
								break;
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator6;
					if (enumerator6 is IDisposable)
					{
						(enumerator6 as IDisposable).Dispose();
					}
				}
				try
				{
					foreach (object obj7 in this.GroupBox8.Controls)
					{
						object objectValue7 = RuntimeHelpers.GetObjectValue(obj7);
						bool flag13 = objectValue7 is RadioButton;
						if (flag13)
						{
							bool flag14 = Conversions.ToBoolean(NewLateBinding.LateGet(objectValue7, null, "checked", new object[0], null, null, null));
							if (flag14)
							{
								text7 = Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(objectValue7, null, "text", new object[0], null, null, null), " "));
								break;
							}
						}
					}
				}
				finally
				{
					IEnumerator enumerator7;
					if (enumerator7 is IDisposable)
					{
						(enumerator7 as IDisposable).Dispose();
					}
				}
				string text8 = this.txtGeneral.Text;
				this.comment = string.Concat(new string[] { text5, text2, text, text3, text4, text6, text7, text8 });
				base.DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error. Detail: " + ex.Message);
			}
		}

		// Token: 0x04001675 RID: 5749
		public string comment;

		// Token: 0x04001676 RID: 5750
		public int productid;

		// Token: 0x04001677 RID: 5751
		private string _cnn;

		// Token: 0x04001678 RID: 5752
		private PublicFunctions pf;
	}
}
