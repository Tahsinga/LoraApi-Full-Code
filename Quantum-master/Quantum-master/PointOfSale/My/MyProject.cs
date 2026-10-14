using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace PointOfSale.My
{
	// Token: 0x02000077 RID: 119
	[StandardModule]
	[HideModuleName]
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	internal sealed class MyProject
	{
		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x060019F2 RID: 6642 RVA: 0x000EEDFC File Offset: 0x000ECFFC
		[HelpKeyword("My.Computer")]
		internal static MyComputer Computer
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_ComputerObjectProvider.GetInstance;
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x060019F3 RID: 6643 RVA: 0x000EEE18 File Offset: 0x000ED018
		[HelpKeyword("My.Application")]
		internal static MyApplication Application
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_AppObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x060019F4 RID: 6644 RVA: 0x000EEE34 File Offset: 0x000ED034
		[HelpKeyword("My.User")]
		internal static User User
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_UserObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x060019F5 RID: 6645 RVA: 0x000EEE50 File Offset: 0x000ED050
		[HelpKeyword("My.Forms")]
		internal static MyProject.MyForms Forms
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyFormsObjectProvider.GetInstance;
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x060019F6 RID: 6646 RVA: 0x000EEE6C File Offset: 0x000ED06C
		[HelpKeyword("My.WebServices")]
		internal static MyProject.MyWebServices WebServices
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyWebServicesObjectProvider.GetInstance;
			}
		}

		// Token: 0x04000C84 RID: 3204
		private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();

		// Token: 0x04000C85 RID: 3205
		private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();

		// Token: 0x04000C86 RID: 3206
		private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();

		// Token: 0x04000C87 RID: 3207
		private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();

		// Token: 0x04000C88 RID: 3208
		private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

		// Token: 0x0200024C RID: 588
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		internal sealed class MyForms
		{
			// Token: 0x06006288 RID: 25224 RVA: 0x0037B60C File Offset: 0x0037980C
			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance) where T : Form, new()
			{
				bool flag = Instance == null || Instance.IsDisposed;
				if (flag)
				{
					bool flag2 = MyProject.MyForms.m_FormBeingCreated != null;
					if (flag2)
					{
						bool flag3 = MyProject.MyForms.m_FormBeingCreated.ContainsKey(typeof(T));
						if (flag3)
						{
							throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
						}
					}
					else
					{
						MyProject.MyForms.m_FormBeingCreated = new Hashtable();
					}
					MyProject.MyForms.m_FormBeingCreated.Add(typeof(T), null);
					try
					{
						return new T();
					}
					catch (TargetInvocationException ex) when (ex.InnerException != null)
					{
						string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[] { ex.InnerException.Message });
						throw new InvalidOperationException(resourceString, ex.InnerException);
					}
					finally
					{
						MyProject.MyForms.m_FormBeingCreated.Remove(typeof(T));
					}
				}
				return Instance;
			}

			// Token: 0x06006289 RID: 25225 RVA: 0x0037B734 File Offset: 0x00379934
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance) where T : Form
			{
				instance.Dispose();
				instance = default(T);
			}

			// Token: 0x0600628A RID: 25226 RVA: 0x0037B74B File Offset: 0x0037994B
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyForms()
			{
			}

			// Token: 0x0600628B RID: 25227 RVA: 0x0037B758 File Offset: 0x00379958
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x0600628C RID: 25228 RVA: 0x0037B778 File Offset: 0x00379978
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x0600628D RID: 25229 RVA: 0x0037B790 File Offset: 0x00379990
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyProject.MyForms);
			}

			// Token: 0x0600628E RID: 25230 RVA: 0x0037B7AC File Offset: 0x003799AC
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x17002387 RID: 9095
			// (get) Token: 0x0600628F RID: 25231 RVA: 0x0037B7C4 File Offset: 0x003799C4
			// (set) Token: 0x06006342 RID: 25410 RVA: 0x0037CAA5 File Offset: 0x0037ACA5
			public About About
			{
				[DebuggerHidden]
				get
				{
					this.m_About = MyProject.MyForms.Create__Instance__<About>(this.m_About);
					return this.m_About;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_About)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<About>(ref this.m_About);
					}
				}
			}

			// Token: 0x17002388 RID: 9096
			// (get) Token: 0x06006290 RID: 25232 RVA: 0x0037B7DF File Offset: 0x003799DF
			// (set) Token: 0x06006343 RID: 25411 RVA: 0x0037CAD1 File Offset: 0x0037ACD1
			public AC_SetRoles AC_SetRoles
			{
				[DebuggerHidden]
				get
				{
					this.m_AC_SetRoles = MyProject.MyForms.Create__Instance__<AC_SetRoles>(this.m_AC_SetRoles);
					return this.m_AC_SetRoles;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_AC_SetRoles)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<AC_SetRoles>(ref this.m_AC_SetRoles);
					}
				}
			}

			// Token: 0x17002389 RID: 9097
			// (get) Token: 0x06006291 RID: 25233 RVA: 0x0037B7FA File Offset: 0x003799FA
			// (set) Token: 0x06006344 RID: 25412 RVA: 0x0037CAFD File Offset: 0x0037ACFD
			public AC_UserPermissions AC_UserPermissions
			{
				[DebuggerHidden]
				get
				{
					this.m_AC_UserPermissions = MyProject.MyForms.Create__Instance__<AC_UserPermissions>(this.m_AC_UserPermissions);
					return this.m_AC_UserPermissions;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_AC_UserPermissions)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<AC_UserPermissions>(ref this.m_AC_UserPermissions);
					}
				}
			}

			// Token: 0x1700238A RID: 9098
			// (get) Token: 0x06006292 RID: 25234 RVA: 0x0037B815 File Offset: 0x00379A15
			// (set) Token: 0x06006345 RID: 25413 RVA: 0x0037CB29 File Offset: 0x0037AD29
			public AccPayment AccPayment
			{
				[DebuggerHidden]
				get
				{
					this.m_AccPayment = MyProject.MyForms.Create__Instance__<AccPayment>(this.m_AccPayment);
					return this.m_AccPayment;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_AccPayment)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<AccPayment>(ref this.m_AccPayment);
					}
				}
			}

			// Token: 0x1700238B RID: 9099
			// (get) Token: 0x06006293 RID: 25235 RVA: 0x0037B830 File Offset: 0x00379A30
			// (set) Token: 0x06006346 RID: 25414 RVA: 0x0037CB55 File Offset: 0x0037AD55
			public AdditionalSettings AdditionalSettings
			{
				[DebuggerHidden]
				get
				{
					this.m_AdditionalSettings = MyProject.MyForms.Create__Instance__<AdditionalSettings>(this.m_AdditionalSettings);
					return this.m_AdditionalSettings;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_AdditionalSettings)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<AdditionalSettings>(ref this.m_AdditionalSettings);
					}
				}
			}

			// Token: 0x1700238C RID: 9100
			// (get) Token: 0x06006294 RID: 25236 RVA: 0x0037B84B File Offset: 0x00379A4B
			// (set) Token: 0x06006347 RID: 25415 RVA: 0x0037CB81 File Offset: 0x0037AD81
			public AddNewProdt AddNewProdt
			{
				[DebuggerHidden]
				get
				{
					this.m_AddNewProdt = MyProject.MyForms.Create__Instance__<AddNewProdt>(this.m_AddNewProdt);
					return this.m_AddNewProdt;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_AddNewProdt)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<AddNewProdt>(ref this.m_AddNewProdt);
					}
				}
			}

			// Token: 0x1700238D RID: 9101
			// (get) Token: 0x06006295 RID: 25237 RVA: 0x0037B866 File Offset: 0x00379A66
			// (set) Token: 0x06006348 RID: 25416 RVA: 0x0037CBAD File Offset: 0x0037ADAD
			public AddNewProdt2 AddNewProdt2
			{
				[DebuggerHidden]
				get
				{
					this.m_AddNewProdt2 = MyProject.MyForms.Create__Instance__<AddNewProdt2>(this.m_AddNewProdt2);
					return this.m_AddNewProdt2;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_AddNewProdt2)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<AddNewProdt2>(ref this.m_AddNewProdt2);
					}
				}
			}

			// Token: 0x1700238E RID: 9102
			// (get) Token: 0x06006296 RID: 25238 RVA: 0x0037B881 File Offset: 0x00379A81
			// (set) Token: 0x06006349 RID: 25417 RVA: 0x0037CBD9 File Offset: 0x0037ADD9
			public ApprovalForm ApprovalForm
			{
				[DebuggerHidden]
				get
				{
					this.m_ApprovalForm = MyProject.MyForms.Create__Instance__<ApprovalForm>(this.m_ApprovalForm);
					return this.m_ApprovalForm;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_ApprovalForm)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ApprovalForm>(ref this.m_ApprovalForm);
					}
				}
			}

			// Token: 0x1700238F RID: 9103
			// (get) Token: 0x06006297 RID: 25239 RVA: 0x0037B89C File Offset: 0x00379A9C
			// (set) Token: 0x0600634A RID: 25418 RVA: 0x0037CC05 File Offset: 0x0037AE05
			public AuditPriceChanges AuditPriceChanges
			{
				[DebuggerHidden]
				get
				{
					this.m_AuditPriceChanges = MyProject.MyForms.Create__Instance__<AuditPriceChanges>(this.m_AuditPriceChanges);
					return this.m_AuditPriceChanges;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_AuditPriceChanges)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<AuditPriceChanges>(ref this.m_AuditPriceChanges);
					}
				}
			}

			// Token: 0x17002390 RID: 9104
			// (get) Token: 0x06006298 RID: 25240 RVA: 0x0037B8B7 File Offset: 0x00379AB7
			// (set) Token: 0x0600634B RID: 25419 RVA: 0x0037CC31 File Offset: 0x0037AE31
			public BackDateValue BackDateValue
			{
				[DebuggerHidden]
				get
				{
					this.m_BackDateValue = MyProject.MyForms.Create__Instance__<BackDateValue>(this.m_BackDateValue);
					return this.m_BackDateValue;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_BackDateValue)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<BackDateValue>(ref this.m_BackDateValue);
					}
				}
			}

			// Token: 0x17002391 RID: 9105
			// (get) Token: 0x06006299 RID: 25241 RVA: 0x0037B8D2 File Offset: 0x00379AD2
			// (set) Token: 0x0600634C RID: 25420 RVA: 0x0037CC5D File Offset: 0x0037AE5D
			public BackUpDB BackUpDB
			{
				[DebuggerHidden]
				get
				{
					this.m_BackUpDB = MyProject.MyForms.Create__Instance__<BackUpDB>(this.m_BackUpDB);
					return this.m_BackUpDB;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_BackUpDB)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<BackUpDB>(ref this.m_BackUpDB);
					}
				}
			}

			// Token: 0x17002392 RID: 9106
			// (get) Token: 0x0600629A RID: 25242 RVA: 0x0037B8ED File Offset: 0x00379AED
			// (set) Token: 0x0600634D RID: 25421 RVA: 0x0037CC89 File Offset: 0x0037AE89
			public BarCodes BarCodes
			{
				[DebuggerHidden]
				get
				{
					this.m_BarCodes = MyProject.MyForms.Create__Instance__<BarCodes>(this.m_BarCodes);
					return this.m_BarCodes;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_BarCodes)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<BarCodes>(ref this.m_BarCodes);
					}
				}
			}

			// Token: 0x17002393 RID: 9107
			// (get) Token: 0x0600629B RID: 25243 RVA: 0x0037B908 File Offset: 0x00379B08
			// (set) Token: 0x0600634E RID: 25422 RVA: 0x0037CCB5 File Offset: 0x0037AEB5
			public BatchSelect BatchSelect
			{
				[DebuggerHidden]
				get
				{
					this.m_BatchSelect = MyProject.MyForms.Create__Instance__<BatchSelect>(this.m_BatchSelect);
					return this.m_BatchSelect;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_BatchSelect)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<BatchSelect>(ref this.m_BatchSelect);
					}
				}
			}

			// Token: 0x17002394 RID: 9108
			// (get) Token: 0x0600629C RID: 25244 RVA: 0x0037B923 File Offset: 0x00379B23
			// (set) Token: 0x0600634F RID: 25423 RVA: 0x0037CCE1 File Offset: 0x0037AEE1
			public BillingEnterPaymentfrm BillingEnterPaymentfrm
			{
				[DebuggerHidden]
				get
				{
					this.m_BillingEnterPaymentfrm = MyProject.MyForms.Create__Instance__<BillingEnterPaymentfrm>(this.m_BillingEnterPaymentfrm);
					return this.m_BillingEnterPaymentfrm;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_BillingEnterPaymentfrm)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<BillingEnterPaymentfrm>(ref this.m_BillingEnterPaymentfrm);
					}
				}
			}

			// Token: 0x17002395 RID: 9109
			// (get) Token: 0x0600629D RID: 25245 RVA: 0x0037B93E File Offset: 0x00379B3E
			// (set) Token: 0x06006350 RID: 25424 RVA: 0x0037CD0D File Offset: 0x0037AF0D
			public BillingTerms BillingTerms
			{
				[DebuggerHidden]
				get
				{
					this.m_BillingTerms = MyProject.MyForms.Create__Instance__<BillingTerms>(this.m_BillingTerms);
					return this.m_BillingTerms;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_BillingTerms)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<BillingTerms>(ref this.m_BillingTerms);
					}
				}
			}

			// Token: 0x17002396 RID: 9110
			// (get) Token: 0x0600629E RID: 25246 RVA: 0x0037B959 File Offset: 0x00379B59
			// (set) Token: 0x06006351 RID: 25425 RVA: 0x0037CD39 File Offset: 0x0037AF39
			public Branches Branches
			{
				[DebuggerHidden]
				get
				{
					this.m_Branches = MyProject.MyForms.Create__Instance__<Branches>(this.m_Branches);
					return this.m_Branches;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Branches)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Branches>(ref this.m_Branches);
					}
				}
			}

			// Token: 0x17002397 RID: 9111
			// (get) Token: 0x0600629F RID: 25247 RVA: 0x0037B974 File Offset: 0x00379B74
			// (set) Token: 0x06006352 RID: 25426 RVA: 0x0037CD65 File Offset: 0x0037AF65
			public BranchPrices BranchPrices
			{
				[DebuggerHidden]
				get
				{
					this.m_BranchPrices = MyProject.MyForms.Create__Instance__<BranchPrices>(this.m_BranchPrices);
					return this.m_BranchPrices;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_BranchPrices)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<BranchPrices>(ref this.m_BranchPrices);
					}
				}
			}

			// Token: 0x17002398 RID: 9112
			// (get) Token: 0x060062A0 RID: 25248 RVA: 0x0037B98F File Offset: 0x00379B8F
			// (set) Token: 0x06006353 RID: 25427 RVA: 0x0037CD91 File Offset: 0x0037AF91
			public BreakProduct BreakProduct
			{
				[DebuggerHidden]
				get
				{
					this.m_BreakProduct = MyProject.MyForms.Create__Instance__<BreakProduct>(this.m_BreakProduct);
					return this.m_BreakProduct;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_BreakProduct)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<BreakProduct>(ref this.m_BreakProduct);
					}
				}
			}

			// Token: 0x17002399 RID: 9113
			// (get) Token: 0x060062A1 RID: 25249 RVA: 0x0037B9AA File Offset: 0x00379BAA
			// (set) Token: 0x06006354 RID: 25428 RVA: 0x0037CDBD File Offset: 0x0037AFBD
			public BulkStockEntry BulkStockEntry
			{
				[DebuggerHidden]
				get
				{
					this.m_BulkStockEntry = MyProject.MyForms.Create__Instance__<BulkStockEntry>(this.m_BulkStockEntry);
					return this.m_BulkStockEntry;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_BulkStockEntry)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<BulkStockEntry>(ref this.m_BulkStockEntry);
					}
				}
			}

			// Token: 0x1700239A RID: 9114
			// (get) Token: 0x060062A2 RID: 25250 RVA: 0x0037B9C5 File Offset: 0x00379BC5
			// (set) Token: 0x06006355 RID: 25429 RVA: 0x0037CDE9 File Offset: 0x0037AFE9
			public CalcLxW CalcLxW
			{
				[DebuggerHidden]
				get
				{
					this.m_CalcLxW = MyProject.MyForms.Create__Instance__<CalcLxW>(this.m_CalcLxW);
					return this.m_CalcLxW;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_CalcLxW)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<CalcLxW>(ref this.m_CalcLxW);
					}
				}
			}

			// Token: 0x1700239B RID: 9115
			// (get) Token: 0x060062A3 RID: 25251 RVA: 0x0037B9E0 File Offset: 0x00379BE0
			// (set) Token: 0x06006356 RID: 25430 RVA: 0x0037CE15 File Offset: 0x0037B015
			public Categories Categories
			{
				[DebuggerHidden]
				get
				{
					this.m_Categories = MyProject.MyForms.Create__Instance__<Categories>(this.m_Categories);
					return this.m_Categories;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Categories)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Categories>(ref this.m_Categories);
					}
				}
			}

			// Token: 0x1700239C RID: 9116
			// (get) Token: 0x060062A4 RID: 25252 RVA: 0x0037B9FB File Offset: 0x00379BFB
			// (set) Token: 0x06006357 RID: 25431 RVA: 0x0037CE41 File Offset: 0x0037B041
			public ChangeExpiryDate ChangeExpiryDate
			{
				[DebuggerHidden]
				get
				{
					this.m_ChangeExpiryDate = MyProject.MyForms.Create__Instance__<ChangeExpiryDate>(this.m_ChangeExpiryDate);
					return this.m_ChangeExpiryDate;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_ChangeExpiryDate)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ChangeExpiryDate>(ref this.m_ChangeExpiryDate);
					}
				}
			}

			// Token: 0x1700239D RID: 9117
			// (get) Token: 0x060062A5 RID: 25253 RVA: 0x0037BA16 File Offset: 0x00379C16
			// (set) Token: 0x06006358 RID: 25432 RVA: 0x0037CE6D File Offset: 0x0037B06D
			public ChangeProductSold ChangeProductSold
			{
				[DebuggerHidden]
				get
				{
					this.m_ChangeProductSold = MyProject.MyForms.Create__Instance__<ChangeProductSold>(this.m_ChangeProductSold);
					return this.m_ChangeProductSold;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_ChangeProductSold)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ChangeProductSold>(ref this.m_ChangeProductSold);
					}
				}
			}

			// Token: 0x1700239E RID: 9118
			// (get) Token: 0x060062A6 RID: 25254 RVA: 0x0037BA31 File Offset: 0x00379C31
			// (set) Token: 0x06006359 RID: 25433 RVA: 0x0037CE99 File Offset: 0x0037B099
			public ChangePwd ChangePwd
			{
				[DebuggerHidden]
				get
				{
					this.m_ChangePwd = MyProject.MyForms.Create__Instance__<ChangePwd>(this.m_ChangePwd);
					return this.m_ChangePwd;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_ChangePwd)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ChangePwd>(ref this.m_ChangePwd);
					}
				}
			}

			// Token: 0x1700239F RID: 9119
			// (get) Token: 0x060062A7 RID: 25255 RVA: 0x0037BA4C File Offset: 0x00379C4C
			// (set) Token: 0x0600635A RID: 25434 RVA: 0x0037CEC5 File Offset: 0x0037B0C5
			public ChangeUserPassword ChangeUserPassword
			{
				[DebuggerHidden]
				get
				{
					this.m_ChangeUserPassword = MyProject.MyForms.Create__Instance__<ChangeUserPassword>(this.m_ChangeUserPassword);
					return this.m_ChangeUserPassword;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_ChangeUserPassword)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ChangeUserPassword>(ref this.m_ChangeUserPassword);
					}
				}
			}

			// Token: 0x170023A0 RID: 9120
			// (get) Token: 0x060062A8 RID: 25256 RVA: 0x0037BA67 File Offset: 0x00379C67
			// (set) Token: 0x0600635B RID: 25435 RVA: 0x0037CEF1 File Offset: 0x0037B0F1
			public CheckBranchStock CheckBranchStock
			{
				[DebuggerHidden]
				get
				{
					this.m_CheckBranchStock = MyProject.MyForms.Create__Instance__<CheckBranchStock>(this.m_CheckBranchStock);
					return this.m_CheckBranchStock;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_CheckBranchStock)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<CheckBranchStock>(ref this.m_CheckBranchStock);
					}
				}
			}

			// Token: 0x170023A1 RID: 9121
			// (get) Token: 0x060062A9 RID: 25257 RVA: 0x0037BA82 File Offset: 0x00379C82
			// (set) Token: 0x0600635C RID: 25436 RVA: 0x0037CF1D File Offset: 0x0037B11D
			public CheckConnectedbranchStatus CheckConnectedbranchStatus
			{
				[DebuggerHidden]
				get
				{
					this.m_CheckConnectedbranchStatus = MyProject.MyForms.Create__Instance__<CheckConnectedbranchStatus>(this.m_CheckConnectedbranchStatus);
					return this.m_CheckConnectedbranchStatus;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_CheckConnectedbranchStatus)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<CheckConnectedbranchStatus>(ref this.m_CheckConnectedbranchStatus);
					}
				}
			}

			// Token: 0x170023A2 RID: 9122
			// (get) Token: 0x060062AA RID: 25258 RVA: 0x0037BA9D File Offset: 0x00379C9D
			// (set) Token: 0x0600635D RID: 25437 RVA: 0x0037CF49 File Offset: 0x0037B149
			public CheckSerialNumber CheckSerialNumber
			{
				[DebuggerHidden]
				get
				{
					this.m_CheckSerialNumber = MyProject.MyForms.Create__Instance__<CheckSerialNumber>(this.m_CheckSerialNumber);
					return this.m_CheckSerialNumber;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_CheckSerialNumber)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<CheckSerialNumber>(ref this.m_CheckSerialNumber);
					}
				}
			}

			// Token: 0x170023A3 RID: 9123
			// (get) Token: 0x060062AB RID: 25259 RVA: 0x0037BAB8 File Offset: 0x00379CB8
			// (set) Token: 0x0600635E RID: 25438 RVA: 0x0037CF75 File Offset: 0x0037B175
			public Collections Collections
			{
				[DebuggerHidden]
				get
				{
					this.m_Collections = MyProject.MyForms.Create__Instance__<Collections>(this.m_Collections);
					return this.m_Collections;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Collections)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Collections>(ref this.m_Collections);
					}
				}
			}

			// Token: 0x170023A4 RID: 9124
			// (get) Token: 0x060062AC RID: 25260 RVA: 0x0037BAD3 File Offset: 0x00379CD3
			// (set) Token: 0x0600635F RID: 25439 RVA: 0x0037CFA1 File Offset: 0x0037B1A1
			public CollectionsByCustomer CollectionsByCustomer
			{
				[DebuggerHidden]
				get
				{
					this.m_CollectionsByCustomer = MyProject.MyForms.Create__Instance__<CollectionsByCustomer>(this.m_CollectionsByCustomer);
					return this.m_CollectionsByCustomer;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_CollectionsByCustomer)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<CollectionsByCustomer>(ref this.m_CollectionsByCustomer);
					}
				}
			}

			// Token: 0x170023A5 RID: 9125
			// (get) Token: 0x060062AD RID: 25261 RVA: 0x0037BAEE File Offset: 0x00379CEE
			// (set) Token: 0x06006360 RID: 25440 RVA: 0x0037CFCD File Offset: 0x0037B1CD
			public CollectionsByCustomerReport CollectionsByCustomerReport
			{
				[DebuggerHidden]
				get
				{
					this.m_CollectionsByCustomerReport = MyProject.MyForms.Create__Instance__<CollectionsByCustomerReport>(this.m_CollectionsByCustomerReport);
					return this.m_CollectionsByCustomerReport;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_CollectionsByCustomerReport)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<CollectionsByCustomerReport>(ref this.m_CollectionsByCustomerReport);
					}
				}
			}

			// Token: 0x170023A6 RID: 9126
			// (get) Token: 0x060062AE RID: 25262 RVA: 0x0037BB09 File Offset: 0x00379D09
			// (set) Token: 0x06006361 RID: 25441 RVA: 0x0037CFF9 File Offset: 0x0037B1F9
			public CollectionsProductBalByCustomer CollectionsProductBalByCustomer
			{
				[DebuggerHidden]
				get
				{
					this.m_CollectionsProductBalByCustomer = MyProject.MyForms.Create__Instance__<CollectionsProductBalByCustomer>(this.m_CollectionsProductBalByCustomer);
					return this.m_CollectionsProductBalByCustomer;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_CollectionsProductBalByCustomer)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<CollectionsProductBalByCustomer>(ref this.m_CollectionsProductBalByCustomer);
					}
				}
			}

			// Token: 0x170023A7 RID: 9127
			// (get) Token: 0x060062AF RID: 25263 RVA: 0x0037BB24 File Offset: 0x00379D24
			// (set) Token: 0x06006362 RID: 25442 RVA: 0x0037D025 File Offset: 0x0037B225
			public Company Company
			{
				[DebuggerHidden]
				get
				{
					this.m_Company = MyProject.MyForms.Create__Instance__<Company>(this.m_Company);
					return this.m_Company;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Company)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Company>(ref this.m_Company);
					}
				}
			}

			// Token: 0x170023A8 RID: 9128
			// (get) Token: 0x060062B0 RID: 25264 RVA: 0x0037BB3F File Offset: 0x00379D3F
			// (set) Token: 0x06006363 RID: 25443 RVA: 0x0037D051 File Offset: 0x0037B251
			public ConfigureShifts ConfigureShifts
			{
				[DebuggerHidden]
				get
				{
					this.m_ConfigureShifts = MyProject.MyForms.Create__Instance__<ConfigureShifts>(this.m_ConfigureShifts);
					return this.m_ConfigureShifts;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_ConfigureShifts)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ConfigureShifts>(ref this.m_ConfigureShifts);
					}
				}
			}

			// Token: 0x170023A9 RID: 9129
			// (get) Token: 0x060062B1 RID: 25265 RVA: 0x0037BB5A File Offset: 0x00379D5A
			// (set) Token: 0x06006364 RID: 25444 RVA: 0x0037D07D File Offset: 0x0037B27D
			public ConsignmentReport ConsignmentReport
			{
				[DebuggerHidden]
				get
				{
					this.m_ConsignmentReport = MyProject.MyForms.Create__Instance__<ConsignmentReport>(this.m_ConsignmentReport);
					return this.m_ConsignmentReport;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_ConsignmentReport)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ConsignmentReport>(ref this.m_ConsignmentReport);
					}
				}
			}

			// Token: 0x170023AA RID: 9130
			// (get) Token: 0x060062B2 RID: 25266 RVA: 0x0037BB75 File Offset: 0x00379D75
			// (set) Token: 0x06006365 RID: 25445 RVA: 0x0037D0A9 File Offset: 0x0037B2A9
			public CreditNote2 CreditNote2
			{
				[DebuggerHidden]
				get
				{
					this.m_CreditNote2 = MyProject.MyForms.Create__Instance__<CreditNote2>(this.m_CreditNote2);
					return this.m_CreditNote2;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_CreditNote2)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<CreditNote2>(ref this.m_CreditNote2);
					}
				}
			}

			// Token: 0x170023AB RID: 9131
			// (get) Token: 0x060062B3 RID: 25267 RVA: 0x0037BB90 File Offset: 0x00379D90
			// (set) Token: 0x06006366 RID: 25446 RVA: 0x0037D0D5 File Offset: 0x0037B2D5
			public CreditNoteGetPro CreditNoteGetPro
			{
				[DebuggerHidden]
				get
				{
					this.m_CreditNoteGetPro = MyProject.MyForms.Create__Instance__<CreditNoteGetPro>(this.m_CreditNoteGetPro);
					return this.m_CreditNoteGetPro;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_CreditNoteGetPro)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<CreditNoteGetPro>(ref this.m_CreditNoteGetPro);
					}
				}
			}

			// Token: 0x170023AC RID: 9132
			// (get) Token: 0x060062B4 RID: 25268 RVA: 0x0037BBAB File Offset: 0x00379DAB
			// (set) Token: 0x06006367 RID: 25447 RVA: 0x0037D101 File Offset: 0x0037B301
			public CS_EODEnter CS_EODEnter
			{
				[DebuggerHidden]
				get
				{
					this.m_CS_EODEnter = MyProject.MyForms.Create__Instance__<CS_EODEnter>(this.m_CS_EODEnter);
					return this.m_CS_EODEnter;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_CS_EODEnter)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<CS_EODEnter>(ref this.m_CS_EODEnter);
					}
				}
			}

			// Token: 0x170023AD RID: 9133
			// (get) Token: 0x060062B5 RID: 25269 RVA: 0x0037BBC6 File Offset: 0x00379DC6
			// (set) Token: 0x06006368 RID: 25448 RVA: 0x0037D12D File Offset: 0x0037B32D
			public CustomerGroups CustomerGroups
			{
				[DebuggerHidden]
				get
				{
					this.m_CustomerGroups = MyProject.MyForms.Create__Instance__<CustomerGroups>(this.m_CustomerGroups);
					return this.m_CustomerGroups;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_CustomerGroups)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<CustomerGroups>(ref this.m_CustomerGroups);
					}
				}
			}

			// Token: 0x170023AE RID: 9134
			// (get) Token: 0x060062B6 RID: 25270 RVA: 0x0037BBE1 File Offset: 0x00379DE1
			// (set) Token: 0x06006369 RID: 25449 RVA: 0x0037D159 File Offset: 0x0037B359
			public DBConnections DBConnections
			{
				[DebuggerHidden]
				get
				{
					this.m_DBConnections = MyProject.MyForms.Create__Instance__<DBConnections>(this.m_DBConnections);
					return this.m_DBConnections;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_DBConnections)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<DBConnections>(ref this.m_DBConnections);
					}
				}
			}

			// Token: 0x170023AF RID: 9135
			// (get) Token: 0x060062B7 RID: 25271 RVA: 0x0037BBFC File Offset: 0x00379DFC
			// (set) Token: 0x0600636A RID: 25450 RVA: 0x0037D185 File Offset: 0x0037B385
			public DeliveryNoteWarehouse DeliveryNoteWarehouse
			{
				[DebuggerHidden]
				get
				{
					this.m_DeliveryNoteWarehouse = MyProject.MyForms.Create__Instance__<DeliveryNoteWarehouse>(this.m_DeliveryNoteWarehouse);
					return this.m_DeliveryNoteWarehouse;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_DeliveryNoteWarehouse)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<DeliveryNoteWarehouse>(ref this.m_DeliveryNoteWarehouse);
					}
				}
			}

			// Token: 0x170023B0 RID: 9136
			// (get) Token: 0x060062B8 RID: 25272 RVA: 0x0037BC17 File Offset: 0x00379E17
			// (set) Token: 0x0600636B RID: 25451 RVA: 0x0037D1B1 File Offset: 0x0037B3B1
			public DespatchNoteForm DespatchNoteForm
			{
				[DebuggerHidden]
				get
				{
					this.m_DespatchNoteForm = MyProject.MyForms.Create__Instance__<DespatchNoteForm>(this.m_DespatchNoteForm);
					return this.m_DespatchNoteForm;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_DespatchNoteForm)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<DespatchNoteForm>(ref this.m_DespatchNoteForm);
					}
				}
			}

			// Token: 0x170023B1 RID: 9137
			// (get) Token: 0x060062B9 RID: 25273 RVA: 0x0037BC32 File Offset: 0x00379E32
			// (set) Token: 0x0600636C RID: 25452 RVA: 0x0037D1DD File Offset: 0x0037B3DD
			public DespatchReprint DespatchReprint
			{
				[DebuggerHidden]
				get
				{
					this.m_DespatchReprint = MyProject.MyForms.Create__Instance__<DespatchReprint>(this.m_DespatchReprint);
					return this.m_DespatchReprint;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_DespatchReprint)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<DespatchReprint>(ref this.m_DespatchReprint);
					}
				}
			}

			// Token: 0x170023B2 RID: 9138
			// (get) Token: 0x060062BA RID: 25274 RVA: 0x0037BC4D File Offset: 0x00379E4D
			// (set) Token: 0x0600636D RID: 25453 RVA: 0x0037D209 File Offset: 0x0037B409
			public DialogNumeric DialogNumeric
			{
				[DebuggerHidden]
				get
				{
					this.m_DialogNumeric = MyProject.MyForms.Create__Instance__<DialogNumeric>(this.m_DialogNumeric);
					return this.m_DialogNumeric;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_DialogNumeric)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<DialogNumeric>(ref this.m_DialogNumeric);
					}
				}
			}

			// Token: 0x170023B3 RID: 9139
			// (get) Token: 0x060062BB RID: 25275 RVA: 0x0037BC68 File Offset: 0x00379E68
			// (set) Token: 0x0600636E RID: 25454 RVA: 0x0037D235 File Offset: 0x0037B435
			public DialogPayMethods DialogPayMethods
			{
				[DebuggerHidden]
				get
				{
					this.m_DialogPayMethods = MyProject.MyForms.Create__Instance__<DialogPayMethods>(this.m_DialogPayMethods);
					return this.m_DialogPayMethods;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_DialogPayMethods)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<DialogPayMethods>(ref this.m_DialogPayMethods);
					}
				}
			}

			// Token: 0x170023B4 RID: 9140
			// (get) Token: 0x060062BC RID: 25276 RVA: 0x0037BC83 File Offset: 0x00379E83
			// (set) Token: 0x0600636F RID: 25455 RVA: 0x0037D261 File Offset: 0x0037B461
			public EcocashDetails EcocashDetails
			{
				[DebuggerHidden]
				get
				{
					this.m_EcocashDetails = MyProject.MyForms.Create__Instance__<EcocashDetails>(this.m_EcocashDetails);
					return this.m_EcocashDetails;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_EcocashDetails)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<EcocashDetails>(ref this.m_EcocashDetails);
					}
				}
			}

			// Token: 0x170023B5 RID: 9141
			// (get) Token: 0x060062BD RID: 25277 RVA: 0x0037BC9E File Offset: 0x00379E9E
			// (set) Token: 0x06006370 RID: 25456 RVA: 0x0037D28D File Offset: 0x0037B48D
			public EcocashReceipts EcocashReceipts
			{
				[DebuggerHidden]
				get
				{
					this.m_EcocashReceipts = MyProject.MyForms.Create__Instance__<EcocashReceipts>(this.m_EcocashReceipts);
					return this.m_EcocashReceipts;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_EcocashReceipts)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<EcocashReceipts>(ref this.m_EcocashReceipts);
					}
				}
			}

			// Token: 0x170023B6 RID: 9142
			// (get) Token: 0x060062BE RID: 25278 RVA: 0x0037BCB9 File Offset: 0x00379EB9
			// (set) Token: 0x06006371 RID: 25457 RVA: 0x0037D2B9 File Offset: 0x0037B4B9
			public EconetVoucherUpload EconetVoucherUpload
			{
				[DebuggerHidden]
				get
				{
					this.m_EconetVoucherUpload = MyProject.MyForms.Create__Instance__<EconetVoucherUpload>(this.m_EconetVoucherUpload);
					return this.m_EconetVoucherUpload;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_EconetVoucherUpload)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<EconetVoucherUpload>(ref this.m_EconetVoucherUpload);
					}
				}
			}

			// Token: 0x170023B7 RID: 9143
			// (get) Token: 0x060062BF RID: 25279 RVA: 0x0037BCD4 File Offset: 0x00379ED4
			// (set) Token: 0x06006372 RID: 25458 RVA: 0x0037D2E5 File Offset: 0x0037B4E5
			public EditBatchNumber EditBatchNumber
			{
				[DebuggerHidden]
				get
				{
					this.m_EditBatchNumber = MyProject.MyForms.Create__Instance__<EditBatchNumber>(this.m_EditBatchNumber);
					return this.m_EditBatchNumber;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_EditBatchNumber)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<EditBatchNumber>(ref this.m_EditBatchNumber);
					}
				}
			}

			// Token: 0x170023B8 RID: 9144
			// (get) Token: 0x060062C0 RID: 25280 RVA: 0x0037BCEF File Offset: 0x00379EEF
			// (set) Token: 0x06006373 RID: 25459 RVA: 0x0037D311 File Offset: 0x0037B511
			public EditBatchNumbers EditBatchNumbers
			{
				[DebuggerHidden]
				get
				{
					this.m_EditBatchNumbers = MyProject.MyForms.Create__Instance__<EditBatchNumbers>(this.m_EditBatchNumbers);
					return this.m_EditBatchNumbers;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_EditBatchNumbers)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<EditBatchNumbers>(ref this.m_EditBatchNumbers);
					}
				}
			}

			// Token: 0x170023B9 RID: 9145
			// (get) Token: 0x060062C1 RID: 25281 RVA: 0x0037BD0A File Offset: 0x00379F0A
			// (set) Token: 0x06006374 RID: 25460 RVA: 0x0037D33D File Offset: 0x0037B53D
			public EditComment EditComment
			{
				[DebuggerHidden]
				get
				{
					this.m_EditComment = MyProject.MyForms.Create__Instance__<EditComment>(this.m_EditComment);
					return this.m_EditComment;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_EditComment)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<EditComment>(ref this.m_EditComment);
					}
				}
			}

			// Token: 0x170023BA RID: 9146
			// (get) Token: 0x060062C2 RID: 25282 RVA: 0x0037BD25 File Offset: 0x00379F25
			// (set) Token: 0x06006375 RID: 25461 RVA: 0x0037D369 File Offset: 0x0037B569
			public EditProductCategory EditProductCategory
			{
				[DebuggerHidden]
				get
				{
					this.m_EditProductCategory = MyProject.MyForms.Create__Instance__<EditProductCategory>(this.m_EditProductCategory);
					return this.m_EditProductCategory;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_EditProductCategory)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<EditProductCategory>(ref this.m_EditProductCategory);
					}
				}
			}

			// Token: 0x170023BB RID: 9147
			// (get) Token: 0x060062C3 RID: 25283 RVA: 0x0037BD40 File Offset: 0x00379F40
			// (set) Token: 0x06006376 RID: 25462 RVA: 0x0037D395 File Offset: 0x0037B595
			public EditProducts EditProducts
			{
				[DebuggerHidden]
				get
				{
					this.m_EditProducts = MyProject.MyForms.Create__Instance__<EditProducts>(this.m_EditProducts);
					return this.m_EditProducts;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_EditProducts)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<EditProducts>(ref this.m_EditProducts);
					}
				}
			}

			// Token: 0x170023BC RID: 9148
			// (get) Token: 0x060062C4 RID: 25284 RVA: 0x0037BD5B File Offset: 0x00379F5B
			// (set) Token: 0x06006377 RID: 25463 RVA: 0x0037D3C1 File Offset: 0x0037B5C1
			public EditProductSupplier EditProductSupplier
			{
				[DebuggerHidden]
				get
				{
					this.m_EditProductSupplier = MyProject.MyForms.Create__Instance__<EditProductSupplier>(this.m_EditProductSupplier);
					return this.m_EditProductSupplier;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_EditProductSupplier)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<EditProductSupplier>(ref this.m_EditProductSupplier);
					}
				}
			}

			// Token: 0x170023BD RID: 9149
			// (get) Token: 0x060062C5 RID: 25285 RVA: 0x0037BD76 File Offset: 0x00379F76
			// (set) Token: 0x06006378 RID: 25464 RVA: 0x0037D3ED File Offset: 0x0037B5ED
			public EditShiftDetail EditShiftDetail
			{
				[DebuggerHidden]
				get
				{
					this.m_EditShiftDetail = MyProject.MyForms.Create__Instance__<EditShiftDetail>(this.m_EditShiftDetail);
					return this.m_EditShiftDetail;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_EditShiftDetail)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<EditShiftDetail>(ref this.m_EditShiftDetail);
					}
				}
			}

			// Token: 0x170023BE RID: 9150
			// (get) Token: 0x060062C6 RID: 25286 RVA: 0x0037BD91 File Offset: 0x00379F91
			// (set) Token: 0x06006379 RID: 25465 RVA: 0x0037D419 File Offset: 0x0037B619
			public eltratefiscaldevice eltratefiscaldevice
			{
				[DebuggerHidden]
				get
				{
					this.m_eltratefiscaldevice = MyProject.MyForms.Create__Instance__<eltratefiscaldevice>(this.m_eltratefiscaldevice);
					return this.m_eltratefiscaldevice;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_eltratefiscaldevice)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<eltratefiscaldevice>(ref this.m_eltratefiscaldevice);
					}
				}
			}

			// Token: 0x170023BF RID: 9151
			// (get) Token: 0x060062C7 RID: 25287 RVA: 0x0037BDAC File Offset: 0x00379FAC
			// (set) Token: 0x0600637A RID: 25466 RVA: 0x0037D445 File Offset: 0x0037B645
			public EmailReports EmailReports
			{
				[DebuggerHidden]
				get
				{
					this.m_EmailReports = MyProject.MyForms.Create__Instance__<EmailReports>(this.m_EmailReports);
					return this.m_EmailReports;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_EmailReports)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<EmailReports>(ref this.m_EmailReports);
					}
				}
			}

			// Token: 0x170023C0 RID: 9152
			// (get) Token: 0x060062C8 RID: 25288 RVA: 0x0037BDC7 File Offset: 0x00379FC7
			// (set) Token: 0x0600637B RID: 25467 RVA: 0x0037D471 File Offset: 0x0037B671
			public EnterSerialNumbers EnterSerialNumbers
			{
				[DebuggerHidden]
				get
				{
					this.m_EnterSerialNumbers = MyProject.MyForms.Create__Instance__<EnterSerialNumbers>(this.m_EnterSerialNumbers);
					return this.m_EnterSerialNumbers;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_EnterSerialNumbers)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<EnterSerialNumbers>(ref this.m_EnterSerialNumbers);
					}
				}
			}

			// Token: 0x170023C1 RID: 9153
			// (get) Token: 0x060062C9 RID: 25289 RVA: 0x0037BDE2 File Offset: 0x00379FE2
			// (set) Token: 0x0600637C RID: 25468 RVA: 0x0037D49D File Offset: 0x0037B69D
			public EODPrintOut EODPrintOut
			{
				[DebuggerHidden]
				get
				{
					this.m_EODPrintOut = MyProject.MyForms.Create__Instance__<EODPrintOut>(this.m_EODPrintOut);
					return this.m_EODPrintOut;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_EODPrintOut)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<EODPrintOut>(ref this.m_EODPrintOut);
					}
				}
			}

			// Token: 0x170023C2 RID: 9154
			// (get) Token: 0x060062CA RID: 25290 RVA: 0x0037BDFD File Offset: 0x00379FFD
			// (set) Token: 0x0600637D RID: 25469 RVA: 0x0037D4C9 File Offset: 0x0037B6C9
			public ExpensesCategories ExpensesCategories
			{
				[DebuggerHidden]
				get
				{
					this.m_ExpensesCategories = MyProject.MyForms.Create__Instance__<ExpensesCategories>(this.m_ExpensesCategories);
					return this.m_ExpensesCategories;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_ExpensesCategories)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ExpensesCategories>(ref this.m_ExpensesCategories);
					}
				}
			}

			// Token: 0x170023C3 RID: 9155
			// (get) Token: 0x060062CB RID: 25291 RVA: 0x0037BE18 File Offset: 0x0037A018
			// (set) Token: 0x0600637E RID: 25470 RVA: 0x0037D4F5 File Offset: 0x0037B6F5
			public ExtraCustomerDetails ExtraCustomerDetails
			{
				[DebuggerHidden]
				get
				{
					this.m_ExtraCustomerDetails = MyProject.MyForms.Create__Instance__<ExtraCustomerDetails>(this.m_ExtraCustomerDetails);
					return this.m_ExtraCustomerDetails;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_ExtraCustomerDetails)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ExtraCustomerDetails>(ref this.m_ExtraCustomerDetails);
					}
				}
			}

			// Token: 0x170023C4 RID: 9156
			// (get) Token: 0x060062CC RID: 25292 RVA: 0x0037BE33 File Offset: 0x0037A033
			// (set) Token: 0x0600637F RID: 25471 RVA: 0x0037D521 File Offset: 0x0037B721
			public FloatManagement FloatManagement
			{
				[DebuggerHidden]
				get
				{
					this.m_FloatManagement = MyProject.MyForms.Create__Instance__<FloatManagement>(this.m_FloatManagement);
					return this.m_FloatManagement;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_FloatManagement)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<FloatManagement>(ref this.m_FloatManagement);
					}
				}
			}

			// Token: 0x170023C5 RID: 9157
			// (get) Token: 0x060062CD RID: 25293 RVA: 0x0037BE4E File Offset: 0x0037A04E
			// (set) Token: 0x06006380 RID: 25472 RVA: 0x0037D54D File Offset: 0x0037B74D
			public Form1 Form1
			{
				[DebuggerHidden]
				get
				{
					this.m_Form1 = MyProject.MyForms.Create__Instance__<Form1>(this.m_Form1);
					return this.m_Form1;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Form1)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Form1>(ref this.m_Form1);
					}
				}
			}

			// Token: 0x170023C6 RID: 9158
			// (get) Token: 0x060062CE RID: 25294 RVA: 0x0037BE69 File Offset: 0x0037A069
			// (set) Token: 0x06006381 RID: 25473 RVA: 0x0037D579 File Offset: 0x0037B779
			public FormulaReport FormulaReport
			{
				[DebuggerHidden]
				get
				{
					this.m_FormulaReport = MyProject.MyForms.Create__Instance__<FormulaReport>(this.m_FormulaReport);
					return this.m_FormulaReport;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_FormulaReport)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<FormulaReport>(ref this.m_FormulaReport);
					}
				}
			}

			// Token: 0x170023C7 RID: 9159
			// (get) Token: 0x060062CF RID: 25295 RVA: 0x0037BE84 File Offset: 0x0037A084
			// (set) Token: 0x06006382 RID: 25474 RVA: 0x0037D5A5 File Offset: 0x0037B7A5
			public frmAccStatement frmAccStatement
			{
				[DebuggerHidden]
				get
				{
					this.m_frmAccStatement = MyProject.MyForms.Create__Instance__<frmAccStatement>(this.m_frmAccStatement);
					return this.m_frmAccStatement;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmAccStatement)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmAccStatement>(ref this.m_frmAccStatement);
					}
				}
			}

			// Token: 0x170023C8 RID: 9160
			// (get) Token: 0x060062D0 RID: 25296 RVA: 0x0037BE9F File Offset: 0x0037A09F
			// (set) Token: 0x06006383 RID: 25475 RVA: 0x0037D5D1 File Offset: 0x0037B7D1
			public FrmADF_SalesPurchases3 FrmADF_SalesPurchases3
			{
				[DebuggerHidden]
				get
				{
					this.m_FrmADF_SalesPurchases3 = MyProject.MyForms.Create__Instance__<FrmADF_SalesPurchases3>(this.m_FrmADF_SalesPurchases3);
					return this.m_FrmADF_SalesPurchases3;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_FrmADF_SalesPurchases3)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<FrmADF_SalesPurchases3>(ref this.m_FrmADF_SalesPurchases3);
					}
				}
			}

			// Token: 0x170023C9 RID: 9161
			// (get) Token: 0x060062D1 RID: 25297 RVA: 0x0037BEBA File Offset: 0x0037A0BA
			// (set) Token: 0x06006384 RID: 25476 RVA: 0x0037D5FD File Offset: 0x0037B7FD
			public frmConfirmAdminUser frmConfirmAdminUser
			{
				[DebuggerHidden]
				get
				{
					this.m_frmConfirmAdminUser = MyProject.MyForms.Create__Instance__<frmConfirmAdminUser>(this.m_frmConfirmAdminUser);
					return this.m_frmConfirmAdminUser;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmConfirmAdminUser)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmConfirmAdminUser>(ref this.m_frmConfirmAdminUser);
					}
				}
			}

			// Token: 0x170023CA RID: 9162
			// (get) Token: 0x060062D2 RID: 25298 RVA: 0x0037BED5 File Offset: 0x0037A0D5
			// (set) Token: 0x06006385 RID: 25477 RVA: 0x0037D629 File Offset: 0x0037B829
			public FRMSearchCustomer FRMSearchCustomer
			{
				[DebuggerHidden]
				get
				{
					this.m_FRMSearchCustomer = MyProject.MyForms.Create__Instance__<FRMSearchCustomer>(this.m_FRMSearchCustomer);
					return this.m_FRMSearchCustomer;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_FRMSearchCustomer)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<FRMSearchCustomer>(ref this.m_FRMSearchCustomer);
					}
				}
			}

			// Token: 0x170023CB RID: 9163
			// (get) Token: 0x060062D3 RID: 25299 RVA: 0x0037BEF0 File Offset: 0x0037A0F0
			// (set) Token: 0x06006386 RID: 25478 RVA: 0x0037D655 File Offset: 0x0037B855
			public frmStockExpiry frmStockExpiry
			{
				[DebuggerHidden]
				get
				{
					this.m_frmStockExpiry = MyProject.MyForms.Create__Instance__<frmStockExpiry>(this.m_frmStockExpiry);
					return this.m_frmStockExpiry;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_frmStockExpiry)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmStockExpiry>(ref this.m_frmStockExpiry);
					}
				}
			}

			// Token: 0x170023CC RID: 9164
			// (get) Token: 0x060062D4 RID: 25300 RVA: 0x0037BF0B File Offset: 0x0037A10B
			// (set) Token: 0x06006387 RID: 25479 RVA: 0x0037D681 File Offset: 0x0037B881
			public GeneralSettings GeneralSettings
			{
				[DebuggerHidden]
				get
				{
					this.m_GeneralSettings = MyProject.MyForms.Create__Instance__<GeneralSettings>(this.m_GeneralSettings);
					return this.m_GeneralSettings;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_GeneralSettings)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<GeneralSettings>(ref this.m_GeneralSettings);
					}
				}
			}

			// Token: 0x170023CD RID: 9165
			// (get) Token: 0x060062D5 RID: 25301 RVA: 0x0037BF26 File Offset: 0x0037A126
			// (set) Token: 0x06006388 RID: 25480 RVA: 0x0037D6AD File Offset: 0x0037B8AD
			public GetNewBatchNumber GetNewBatchNumber
			{
				[DebuggerHidden]
				get
				{
					this.m_GetNewBatchNumber = MyProject.MyForms.Create__Instance__<GetNewBatchNumber>(this.m_GetNewBatchNumber);
					return this.m_GetNewBatchNumber;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_GetNewBatchNumber)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<GetNewBatchNumber>(ref this.m_GetNewBatchNumber);
					}
				}
			}

			// Token: 0x170023CE RID: 9166
			// (get) Token: 0x060062D6 RID: 25302 RVA: 0x0037BF41 File Offset: 0x0037A141
			// (set) Token: 0x06006389 RID: 25481 RVA: 0x0037D6D9 File Offset: 0x0037B8D9
			public KDUs KDUs
			{
				[DebuggerHidden]
				get
				{
					this.m_KDUs = MyProject.MyForms.Create__Instance__<KDUs>(this.m_KDUs);
					return this.m_KDUs;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_KDUs)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<KDUs>(ref this.m_KDUs);
					}
				}
			}

			// Token: 0x170023CF RID: 9167
			// (get) Token: 0x060062D7 RID: 25303 RVA: 0x0037BF5C File Offset: 0x0037A15C
			// (set) Token: 0x0600638A RID: 25482 RVA: 0x0037D705 File Offset: 0x0037B905
			public KitchenDisplay KitchenDisplay
			{
				[DebuggerHidden]
				get
				{
					this.m_KitchenDisplay = MyProject.MyForms.Create__Instance__<KitchenDisplay>(this.m_KitchenDisplay);
					return this.m_KitchenDisplay;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_KitchenDisplay)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<KitchenDisplay>(ref this.m_KitchenDisplay);
					}
				}
			}

			// Token: 0x170023D0 RID: 9168
			// (get) Token: 0x060062D8 RID: 25304 RVA: 0x0037BF77 File Offset: 0x0037A177
			// (set) Token: 0x0600638B RID: 25483 RVA: 0x0037D731 File Offset: 0x0037B931
			public License License
			{
				[DebuggerHidden]
				get
				{
					this.m_License = MyProject.MyForms.Create__Instance__<License>(this.m_License);
					return this.m_License;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_License)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<License>(ref this.m_License);
					}
				}
			}

			// Token: 0x170023D1 RID: 9169
			// (get) Token: 0x060062D9 RID: 25305 RVA: 0x0037BF92 File Offset: 0x0037A192
			// (set) Token: 0x0600638C RID: 25484 RVA: 0x0037D75D File Offset: 0x0037B95D
			public Logins Logins
			{
				[DebuggerHidden]
				get
				{
					this.m_Logins = MyProject.MyForms.Create__Instance__<Logins>(this.m_Logins);
					return this.m_Logins;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Logins)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Logins>(ref this.m_Logins);
					}
				}
			}

			// Token: 0x170023D2 RID: 9170
			// (get) Token: 0x060062DA RID: 25306 RVA: 0x0037BFAD File Offset: 0x0037A1AD
			// (set) Token: 0x0600638D RID: 25485 RVA: 0x0037D789 File Offset: 0x0037B989
			public MainMenu MainMenu
			{
				[DebuggerHidden]
				get
				{
					this.m_MainMenu = MyProject.MyForms.Create__Instance__<MainMenu>(this.m_MainMenu);
					return this.m_MainMenu;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_MainMenu)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<MainMenu>(ref this.m_MainMenu);
					}
				}
			}

			// Token: 0x170023D3 RID: 9171
			// (get) Token: 0x060062DB RID: 25307 RVA: 0x0037BFC8 File Offset: 0x0037A1C8
			// (set) Token: 0x0600638E RID: 25486 RVA: 0x0037D7B5 File Offset: 0x0037B9B5
			public Make_Product Make_Product
			{
				[DebuggerHidden]
				get
				{
					this.m_Make_Product = MyProject.MyForms.Create__Instance__<Make_Product>(this.m_Make_Product);
					return this.m_Make_Product;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Make_Product)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Make_Product>(ref this.m_Make_Product);
					}
				}
			}

			// Token: 0x170023D4 RID: 9172
			// (get) Token: 0x060062DC RID: 25308 RVA: 0x0037BFE3 File Offset: 0x0037A1E3
			// (set) Token: 0x0600638F RID: 25487 RVA: 0x0037D7E1 File Offset: 0x0037B9E1
			public MenuCategories MenuCategories
			{
				[DebuggerHidden]
				get
				{
					this.m_MenuCategories = MyProject.MyForms.Create__Instance__<MenuCategories>(this.m_MenuCategories);
					return this.m_MenuCategories;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_MenuCategories)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<MenuCategories>(ref this.m_MenuCategories);
					}
				}
			}

			// Token: 0x170023D5 RID: 9173
			// (get) Token: 0x060062DD RID: 25309 RVA: 0x0037BFFE File Offset: 0x0037A1FE
			// (set) Token: 0x06006390 RID: 25488 RVA: 0x0037D80D File Offset: 0x0037BA0D
			public MenuProducts MenuProducts
			{
				[DebuggerHidden]
				get
				{
					this.m_MenuProducts = MyProject.MyForms.Create__Instance__<MenuProducts>(this.m_MenuProducts);
					return this.m_MenuProducts;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_MenuProducts)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<MenuProducts>(ref this.m_MenuProducts);
					}
				}
			}

			// Token: 0x170023D6 RID: 9174
			// (get) Token: 0x060062DE RID: 25310 RVA: 0x0037C019 File Offset: 0x0037A219
			// (set) Token: 0x06006391 RID: 25489 RVA: 0x0037D839 File Offset: 0x0037BA39
			public MultiPayMethods MultiPayMethods
			{
				[DebuggerHidden]
				get
				{
					this.m_MultiPayMethods = MyProject.MyForms.Create__Instance__<MultiPayMethods>(this.m_MultiPayMethods);
					return this.m_MultiPayMethods;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_MultiPayMethods)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<MultiPayMethods>(ref this.m_MultiPayMethods);
					}
				}
			}

			// Token: 0x170023D7 RID: 9175
			// (get) Token: 0x060062DF RID: 25311 RVA: 0x0037C034 File Offset: 0x0037A234
			// (set) Token: 0x06006392 RID: 25490 RVA: 0x0037D865 File Offset: 0x0037BA65
			public NegativeStockSetting NegativeStockSetting
			{
				[DebuggerHidden]
				get
				{
					this.m_NegativeStockSetting = MyProject.MyForms.Create__Instance__<NegativeStockSetting>(this.m_NegativeStockSetting);
					return this.m_NegativeStockSetting;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_NegativeStockSetting)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<NegativeStockSetting>(ref this.m_NegativeStockSetting);
					}
				}
			}

			// Token: 0x170023D8 RID: 9176
			// (get) Token: 0x060062E0 RID: 25312 RVA: 0x0037C04F File Offset: 0x0037A24F
			// (set) Token: 0x06006393 RID: 25491 RVA: 0x0037D891 File Offset: 0x0037BA91
			public NewPrescription NewPrescription
			{
				[DebuggerHidden]
				get
				{
					this.m_NewPrescription = MyProject.MyForms.Create__Instance__<NewPrescription>(this.m_NewPrescription);
					return this.m_NewPrescription;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_NewPrescription)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<NewPrescription>(ref this.m_NewPrescription);
					}
				}
			}

			// Token: 0x170023D9 RID: 9177
			// (get) Token: 0x060062E1 RID: 25313 RVA: 0x0037C06A File Offset: 0x0037A26A
			// (set) Token: 0x06006394 RID: 25492 RVA: 0x0037D8BD File Offset: 0x0037BABD
			public NewProdt NewProdt
			{
				[DebuggerHidden]
				get
				{
					this.m_NewProdt = MyProject.MyForms.Create__Instance__<NewProdt>(this.m_NewProdt);
					return this.m_NewProdt;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_NewProdt)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<NewProdt>(ref this.m_NewProdt);
					}
				}
			}

			// Token: 0x170023DA RID: 9178
			// (get) Token: 0x060062E2 RID: 25314 RVA: 0x0037C085 File Offset: 0x0037A285
			// (set) Token: 0x06006395 RID: 25493 RVA: 0x0037D8E9 File Offset: 0x0037BAE9
			public NewProdt2 NewProdt2
			{
				[DebuggerHidden]
				get
				{
					this.m_NewProdt2 = MyProject.MyForms.Create__Instance__<NewProdt2>(this.m_NewProdt2);
					return this.m_NewProdt2;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_NewProdt2)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<NewProdt2>(ref this.m_NewProdt2);
					}
				}
			}

			// Token: 0x170023DB RID: 9179
			// (get) Token: 0x060062E3 RID: 25315 RVA: 0x0037C0A0 File Offset: 0x0037A2A0
			// (set) Token: 0x06006396 RID: 25494 RVA: 0x0037D915 File Offset: 0x0037BB15
			public NewStock NewStock
			{
				[DebuggerHidden]
				get
				{
					this.m_NewStock = MyProject.MyForms.Create__Instance__<NewStock>(this.m_NewStock);
					return this.m_NewStock;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_NewStock)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<NewStock>(ref this.m_NewStock);
					}
				}
			}

			// Token: 0x170023DC RID: 9180
			// (get) Token: 0x060062E4 RID: 25316 RVA: 0x0037C0BB File Offset: 0x0037A2BB
			// (set) Token: 0x06006397 RID: 25495 RVA: 0x0037D941 File Offset: 0x0037BB41
			public NewStock2 NewStock2
			{
				[DebuggerHidden]
				get
				{
					this.m_NewStock2 = MyProject.MyForms.Create__Instance__<NewStock2>(this.m_NewStock2);
					return this.m_NewStock2;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_NewStock2)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<NewStock2>(ref this.m_NewStock2);
					}
				}
			}

			// Token: 0x170023DD RID: 9181
			// (get) Token: 0x060062E5 RID: 25317 RVA: 0x0037C0D6 File Offset: 0x0037A2D6
			// (set) Token: 0x06006398 RID: 25496 RVA: 0x0037D96D File Offset: 0x0037BB6D
			public NewStockUnits NewStockUnits
			{
				[DebuggerHidden]
				get
				{
					this.m_NewStockUnits = MyProject.MyForms.Create__Instance__<NewStockUnits>(this.m_NewStockUnits);
					return this.m_NewStockUnits;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_NewStockUnits)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<NewStockUnits>(ref this.m_NewStockUnits);
					}
				}
			}

			// Token: 0x170023DE RID: 9182
			// (get) Token: 0x060062E6 RID: 25318 RVA: 0x0037C0F1 File Offset: 0x0037A2F1
			// (set) Token: 0x06006399 RID: 25497 RVA: 0x0037D999 File Offset: 0x0037BB99
			public NewStockUnits2 NewStockUnits2
			{
				[DebuggerHidden]
				get
				{
					this.m_NewStockUnits2 = MyProject.MyForms.Create__Instance__<NewStockUnits2>(this.m_NewStockUnits2);
					return this.m_NewStockUnits2;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_NewStockUnits2)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<NewStockUnits2>(ref this.m_NewStockUnits2);
					}
				}
			}

			// Token: 0x170023DF RID: 9183
			// (get) Token: 0x060062E7 RID: 25319 RVA: 0x0037C10C File Offset: 0x0037A30C
			// (set) Token: 0x0600639A RID: 25498 RVA: 0x0037D9C5 File Offset: 0x0037BBC5
			public OtherProductDetail OtherProductDetail
			{
				[DebuggerHidden]
				get
				{
					this.m_OtherProductDetail = MyProject.MyForms.Create__Instance__<OtherProductDetail>(this.m_OtherProductDetail);
					return this.m_OtherProductDetail;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_OtherProductDetail)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<OtherProductDetail>(ref this.m_OtherProductDetail);
					}
				}
			}

			// Token: 0x170023E0 RID: 9184
			// (get) Token: 0x060062E8 RID: 25320 RVA: 0x0037C127 File Offset: 0x0037A327
			// (set) Token: 0x0600639B RID: 25499 RVA: 0x0037D9F1 File Offset: 0x0037BBF1
			public PackSizeCreate PackSizeCreate
			{
				[DebuggerHidden]
				get
				{
					this.m_PackSizeCreate = MyProject.MyForms.Create__Instance__<PackSizeCreate>(this.m_PackSizeCreate);
					return this.m_PackSizeCreate;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_PackSizeCreate)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<PackSizeCreate>(ref this.m_PackSizeCreate);
					}
				}
			}

			// Token: 0x170023E1 RID: 9185
			// (get) Token: 0x060062E9 RID: 25321 RVA: 0x0037C142 File Offset: 0x0037A342
			// (set) Token: 0x0600639C RID: 25500 RVA: 0x0037DA1D File Offset: 0x0037BC1D
			public PasswordForm PasswordForm
			{
				[DebuggerHidden]
				get
				{
					this.m_PasswordForm = MyProject.MyForms.Create__Instance__<PasswordForm>(this.m_PasswordForm);
					return this.m_PasswordForm;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_PasswordForm)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<PasswordForm>(ref this.m_PasswordForm);
					}
				}
			}

			// Token: 0x170023E2 RID: 9186
			// (get) Token: 0x060062EA RID: 25322 RVA: 0x0037C15D File Offset: 0x0037A35D
			// (set) Token: 0x0600639D RID: 25501 RVA: 0x0037DA49 File Offset: 0x0037BC49
			public PayDeposit PayDeposit
			{
				[DebuggerHidden]
				get
				{
					this.m_PayDeposit = MyProject.MyForms.Create__Instance__<PayDeposit>(this.m_PayDeposit);
					return this.m_PayDeposit;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_PayDeposit)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<PayDeposit>(ref this.m_PayDeposit);
					}
				}
			}

			// Token: 0x170023E3 RID: 9187
			// (get) Token: 0x060062EB RID: 25323 RVA: 0x0037C178 File Offset: 0x0037A378
			// (set) Token: 0x0600639E RID: 25502 RVA: 0x0037DA75 File Offset: 0x0037BC75
			public PaymentMethods PaymentMethods
			{
				[DebuggerHidden]
				get
				{
					this.m_PaymentMethods = MyProject.MyForms.Create__Instance__<PaymentMethods>(this.m_PaymentMethods);
					return this.m_PaymentMethods;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_PaymentMethods)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<PaymentMethods>(ref this.m_PaymentMethods);
					}
				}
			}

			// Token: 0x170023E4 RID: 9188
			// (get) Token: 0x060062EC RID: 25324 RVA: 0x0037C193 File Offset: 0x0037A393
			// (set) Token: 0x0600639F RID: 25503 RVA: 0x0037DAA1 File Offset: 0x0037BCA1
			public PayMethRef PayMethRef
			{
				[DebuggerHidden]
				get
				{
					this.m_PayMethRef = MyProject.MyForms.Create__Instance__<PayMethRef>(this.m_PayMethRef);
					return this.m_PayMethRef;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_PayMethRef)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<PayMethRef>(ref this.m_PayMethRef);
					}
				}
			}

			// Token: 0x170023E5 RID: 9189
			// (get) Token: 0x060062ED RID: 25325 RVA: 0x0037C1AE File Offset: 0x0037A3AE
			// (set) Token: 0x060063A0 RID: 25504 RVA: 0x0037DACD File Offset: 0x0037BCCD
			public PendingInvoices PendingInvoices
			{
				[DebuggerHidden]
				get
				{
					this.m_PendingInvoices = MyProject.MyForms.Create__Instance__<PendingInvoices>(this.m_PendingInvoices);
					return this.m_PendingInvoices;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_PendingInvoices)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<PendingInvoices>(ref this.m_PendingInvoices);
					}
				}
			}

			// Token: 0x170023E6 RID: 9190
			// (get) Token: 0x060062EE RID: 25326 RVA: 0x0037C1C9 File Offset: 0x0037A3C9
			// (set) Token: 0x060063A1 RID: 25505 RVA: 0x0037DAF9 File Offset: 0x0037BCF9
			public PriceChangesReport PriceChangesReport
			{
				[DebuggerHidden]
				get
				{
					this.m_PriceChangesReport = MyProject.MyForms.Create__Instance__<PriceChangesReport>(this.m_PriceChangesReport);
					return this.m_PriceChangesReport;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_PriceChangesReport)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<PriceChangesReport>(ref this.m_PriceChangesReport);
					}
				}
			}

			// Token: 0x170023E7 RID: 9191
			// (get) Token: 0x060062EF RID: 25327 RVA: 0x0037C1E4 File Offset: 0x0037A3E4
			// (set) Token: 0x060063A2 RID: 25506 RVA: 0x0037DB25 File Offset: 0x0037BD25
			public PriceChangesReport2 PriceChangesReport2
			{
				[DebuggerHidden]
				get
				{
					this.m_PriceChangesReport2 = MyProject.MyForms.Create__Instance__<PriceChangesReport2>(this.m_PriceChangesReport2);
					return this.m_PriceChangesReport2;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_PriceChangesReport2)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<PriceChangesReport2>(ref this.m_PriceChangesReport2);
					}
				}
			}

			// Token: 0x170023E8 RID: 9192
			// (get) Token: 0x060062F0 RID: 25328 RVA: 0x0037C1FF File Offset: 0x0037A3FF
			// (set) Token: 0x060063A3 RID: 25507 RVA: 0x0037DB51 File Offset: 0x0037BD51
			public PriceList PriceList
			{
				[DebuggerHidden]
				get
				{
					this.m_PriceList = MyProject.MyForms.Create__Instance__<PriceList>(this.m_PriceList);
					return this.m_PriceList;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_PriceList)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<PriceList>(ref this.m_PriceList);
					}
				}
			}

			// Token: 0x170023E9 RID: 9193
			// (get) Token: 0x060062F1 RID: 25329 RVA: 0x0037C21A File Offset: 0x0037A41A
			// (set) Token: 0x060063A4 RID: 25508 RVA: 0x0037DB7D File Offset: 0x0037BD7D
			public PriceMatrix PriceMatrix
			{
				[DebuggerHidden]
				get
				{
					this.m_PriceMatrix = MyProject.MyForms.Create__Instance__<PriceMatrix>(this.m_PriceMatrix);
					return this.m_PriceMatrix;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_PriceMatrix)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<PriceMatrix>(ref this.m_PriceMatrix);
					}
				}
			}

			// Token: 0x170023EA RID: 9194
			// (get) Token: 0x060062F2 RID: 25330 RVA: 0x0037C235 File Offset: 0x0037A435
			// (set) Token: 0x060063A5 RID: 25509 RVA: 0x0037DBA9 File Offset: 0x0037BDA9
			public Printers Printers
			{
				[DebuggerHidden]
				get
				{
					this.m_Printers = MyProject.MyForms.Create__Instance__<Printers>(this.m_Printers);
					return this.m_Printers;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Printers)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Printers>(ref this.m_Printers);
					}
				}
			}

			// Token: 0x170023EB RID: 9195
			// (get) Token: 0x060062F3 RID: 25331 RVA: 0x0037C250 File Offset: 0x0037A450
			// (set) Token: 0x060063A6 RID: 25510 RVA: 0x0037DBD5 File Offset: 0x0037BDD5
			public PrintQuotation PrintQuotation
			{
				[DebuggerHidden]
				get
				{
					this.m_PrintQuotation = MyProject.MyForms.Create__Instance__<PrintQuotation>(this.m_PrintQuotation);
					return this.m_PrintQuotation;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_PrintQuotation)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<PrintQuotation>(ref this.m_PrintQuotation);
					}
				}
			}

			// Token: 0x170023EC RID: 9196
			// (get) Token: 0x060062F4 RID: 25332 RVA: 0x0037C26B File Offset: 0x0037A46B
			// (set) Token: 0x060063A7 RID: 25511 RVA: 0x0037DC01 File Offset: 0x0037BE01
			public PrintReceiptOrInvoice PrintReceiptOrInvoice
			{
				[DebuggerHidden]
				get
				{
					this.m_PrintReceiptOrInvoice = MyProject.MyForms.Create__Instance__<PrintReceiptOrInvoice>(this.m_PrintReceiptOrInvoice);
					return this.m_PrintReceiptOrInvoice;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_PrintReceiptOrInvoice)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<PrintReceiptOrInvoice>(ref this.m_PrintReceiptOrInvoice);
					}
				}
			}

			// Token: 0x170023ED RID: 9197
			// (get) Token: 0x060062F5 RID: 25333 RVA: 0x0037C286 File Offset: 0x0037A486
			// (set) Token: 0x060063A8 RID: 25512 RVA: 0x0037DC2D File Offset: 0x0037BE2D
			public PrintReceipts PrintReceipts
			{
				[DebuggerHidden]
				get
				{
					this.m_PrintReceipts = MyProject.MyForms.Create__Instance__<PrintReceipts>(this.m_PrintReceipts);
					return this.m_PrintReceipts;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_PrintReceipts)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<PrintReceipts>(ref this.m_PrintReceipts);
					}
				}
			}

			// Token: 0x170023EE RID: 9198
			// (get) Token: 0x060062F6 RID: 25334 RVA: 0x0037C2A1 File Offset: 0x0037A4A1
			// (set) Token: 0x060063A9 RID: 25513 RVA: 0x0037DC59 File Offset: 0x0037BE59
			public ProductOrderComments ProductOrderComments
			{
				[DebuggerHidden]
				get
				{
					this.m_ProductOrderComments = MyProject.MyForms.Create__Instance__<ProductOrderComments>(this.m_ProductOrderComments);
					return this.m_ProductOrderComments;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_ProductOrderComments)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ProductOrderComments>(ref this.m_ProductOrderComments);
					}
				}
			}

			// Token: 0x170023EF RID: 9199
			// (get) Token: 0x060062F7 RID: 25335 RVA: 0x0037C2BC File Offset: 0x0037A4BC
			// (set) Token: 0x060063AA RID: 25514 RVA: 0x0037DC85 File Offset: 0x0037BE85
			public ProductPics ProductPics
			{
				[DebuggerHidden]
				get
				{
					this.m_ProductPics = MyProject.MyForms.Create__Instance__<ProductPics>(this.m_ProductPics);
					return this.m_ProductPics;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_ProductPics)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ProductPics>(ref this.m_ProductPics);
					}
				}
			}

			// Token: 0x170023F0 RID: 9200
			// (get) Token: 0x060062F8 RID: 25336 RVA: 0x0037C2D7 File Offset: 0x0037A4D7
			// (set) Token: 0x060063AB RID: 25515 RVA: 0x0037DCB1 File Offset: 0x0037BEB1
			public ProductsCreditedReport ProductsCreditedReport
			{
				[DebuggerHidden]
				get
				{
					this.m_ProductsCreditedReport = MyProject.MyForms.Create__Instance__<ProductsCreditedReport>(this.m_ProductsCreditedReport);
					return this.m_ProductsCreditedReport;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_ProductsCreditedReport)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ProductsCreditedReport>(ref this.m_ProductsCreditedReport);
					}
				}
			}

			// Token: 0x170023F1 RID: 9201
			// (get) Token: 0x060062F9 RID: 25337 RVA: 0x0037C2F2 File Offset: 0x0037A4F2
			// (set) Token: 0x060063AC RID: 25516 RVA: 0x0037DCDD File Offset: 0x0037BEDD
			public PromotionsView PromotionsView
			{
				[DebuggerHidden]
				get
				{
					this.m_PromotionsView = MyProject.MyForms.Create__Instance__<PromotionsView>(this.m_PromotionsView);
					return this.m_PromotionsView;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_PromotionsView)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<PromotionsView>(ref this.m_PromotionsView);
					}
				}
			}

			// Token: 0x170023F2 RID: 9202
			// (get) Token: 0x060062FA RID: 25338 RVA: 0x0037C30D File Offset: 0x0037A50D
			// (set) Token: 0x060063AD RID: 25517 RVA: 0x0037DD09 File Offset: 0x0037BF09
			public PurchaseReturns PurchaseReturns
			{
				[DebuggerHidden]
				get
				{
					this.m_PurchaseReturns = MyProject.MyForms.Create__Instance__<PurchaseReturns>(this.m_PurchaseReturns);
					return this.m_PurchaseReturns;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_PurchaseReturns)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<PurchaseReturns>(ref this.m_PurchaseReturns);
					}
				}
			}

			// Token: 0x170023F3 RID: 9203
			// (get) Token: 0x060062FB RID: 25339 RVA: 0x0037C328 File Offset: 0x0037A528
			// (set) Token: 0x060063AE RID: 25518 RVA: 0x0037DD35 File Offset: 0x0037BF35
			public Quotation Quotation
			{
				[DebuggerHidden]
				get
				{
					this.m_Quotation = MyProject.MyForms.Create__Instance__<Quotation>(this.m_Quotation);
					return this.m_Quotation;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Quotation)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Quotation>(ref this.m_Quotation);
					}
				}
			}

			// Token: 0x170023F4 RID: 9204
			// (get) Token: 0x060062FC RID: 25340 RVA: 0x0037C343 File Offset: 0x0037A543
			// (set) Token: 0x060063AF RID: 25519 RVA: 0x0037DD61 File Offset: 0x0037BF61
			public R_SalesReport R_SalesReport
			{
				[DebuggerHidden]
				get
				{
					this.m_R_SalesReport = MyProject.MyForms.Create__Instance__<R_SalesReport>(this.m_R_SalesReport);
					return this.m_R_SalesReport;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_R_SalesReport)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<R_SalesReport>(ref this.m_R_SalesReport);
					}
				}
			}

			// Token: 0x170023F5 RID: 9205
			// (get) Token: 0x060062FD RID: 25341 RVA: 0x0037C35E File Offset: 0x0037A55E
			// (set) Token: 0x060063B0 RID: 25520 RVA: 0x0037DD8D File Offset: 0x0037BF8D
			public RefundCustomer RefundCustomer
			{
				[DebuggerHidden]
				get
				{
					this.m_RefundCustomer = MyProject.MyForms.Create__Instance__<RefundCustomer>(this.m_RefundCustomer);
					return this.m_RefundCustomer;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_RefundCustomer)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<RefundCustomer>(ref this.m_RefundCustomer);
					}
				}
			}

			// Token: 0x170023F6 RID: 9206
			// (get) Token: 0x060062FE RID: 25342 RVA: 0x0037C379 File Offset: 0x0037A579
			// (set) Token: 0x060063B1 RID: 25521 RVA: 0x0037DDB9 File Offset: 0x0037BFB9
			public RepairsCheckIn RepairsCheckIn
			{
				[DebuggerHidden]
				get
				{
					this.m_RepairsCheckIn = MyProject.MyForms.Create__Instance__<RepairsCheckIn>(this.m_RepairsCheckIn);
					return this.m_RepairsCheckIn;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_RepairsCheckIn)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<RepairsCheckIn>(ref this.m_RepairsCheckIn);
					}
				}
			}

			// Token: 0x170023F7 RID: 9207
			// (get) Token: 0x060062FF RID: 25343 RVA: 0x0037C394 File Offset: 0x0037A594
			// (set) Token: 0x060063B2 RID: 25522 RVA: 0x0037DDE5 File Offset: 0x0037BFE5
			public ReparisCheckOut ReparisCheckOut
			{
				[DebuggerHidden]
				get
				{
					this.m_ReparisCheckOut = MyProject.MyForms.Create__Instance__<ReparisCheckOut>(this.m_ReparisCheckOut);
					return this.m_ReparisCheckOut;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_ReparisCheckOut)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ReparisCheckOut>(ref this.m_ReparisCheckOut);
					}
				}
			}

			// Token: 0x170023F8 RID: 9208
			// (get) Token: 0x06006300 RID: 25344 RVA: 0x0037C3AF File Offset: 0x0037A5AF
			// (set) Token: 0x060063B3 RID: 25523 RVA: 0x0037DE11 File Offset: 0x0037C011
			public RestrictUserCategories RestrictUserCategories
			{
				[DebuggerHidden]
				get
				{
					this.m_RestrictUserCategories = MyProject.MyForms.Create__Instance__<RestrictUserCategories>(this.m_RestrictUserCategories);
					return this.m_RestrictUserCategories;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_RestrictUserCategories)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<RestrictUserCategories>(ref this.m_RestrictUserCategories);
					}
				}
			}

			// Token: 0x170023F9 RID: 9209
			// (get) Token: 0x06006301 RID: 25345 RVA: 0x0037C3CA File Offset: 0x0037A5CA
			// (set) Token: 0x060063B4 RID: 25524 RVA: 0x0037DE3D File Offset: 0x0037C03D
			public Returns Returns
			{
				[DebuggerHidden]
				get
				{
					this.m_Returns = MyProject.MyForms.Create__Instance__<Returns>(this.m_Returns);
					return this.m_Returns;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Returns)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Returns>(ref this.m_Returns);
					}
				}
			}

			// Token: 0x170023FA RID: 9210
			// (get) Token: 0x06006302 RID: 25346 RVA: 0x0037C3E5 File Offset: 0x0037A5E5
			// (set) Token: 0x060063B5 RID: 25525 RVA: 0x0037DE69 File Offset: 0x0037C069
			public sales2TOUCH sales2TOUCH
			{
				[DebuggerHidden]
				get
				{
					this.m_sales2TOUCH = MyProject.MyForms.Create__Instance__<sales2TOUCH>(this.m_sales2TOUCH);
					return this.m_sales2TOUCH;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_sales2TOUCH)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<sales2TOUCH>(ref this.m_sales2TOUCH);
					}
				}
			}

			// Token: 0x170023FB RID: 9211
			// (get) Token: 0x06006303 RID: 25347 RVA: 0x0037C400 File Offset: 0x0037A600
			// (set) Token: 0x060063B6 RID: 25526 RVA: 0x0037DE95 File Offset: 0x0037C095
			public SalesByInvoice SalesByInvoice
			{
				[DebuggerHidden]
				get
				{
					this.m_SalesByInvoice = MyProject.MyForms.Create__Instance__<SalesByInvoice>(this.m_SalesByInvoice);
					return this.m_SalesByInvoice;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SalesByInvoice)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SalesByInvoice>(ref this.m_SalesByInvoice);
					}
				}
			}

			// Token: 0x170023FC RID: 9212
			// (get) Token: 0x06006304 RID: 25348 RVA: 0x0037C41B File Offset: 0x0037A61B
			// (set) Token: 0x060063B7 RID: 25527 RVA: 0x0037DEC1 File Offset: 0x0037C0C1
			public SalesInvoice SalesInvoice
			{
				[DebuggerHidden]
				get
				{
					this.m_SalesInvoice = MyProject.MyForms.Create__Instance__<SalesInvoice>(this.m_SalesInvoice);
					return this.m_SalesInvoice;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SalesInvoice)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SalesInvoice>(ref this.m_SalesInvoice);
					}
				}
			}

			// Token: 0x170023FD RID: 9213
			// (get) Token: 0x06006305 RID: 25349 RVA: 0x0037C436 File Offset: 0x0037A636
			// (set) Token: 0x060063B8 RID: 25528 RVA: 0x0037DEED File Offset: 0x0037C0ED
			public SalesInvoicePortrait SalesInvoicePortrait
			{
				[DebuggerHidden]
				get
				{
					this.m_SalesInvoicePortrait = MyProject.MyForms.Create__Instance__<SalesInvoicePortrait>(this.m_SalesInvoicePortrait);
					return this.m_SalesInvoicePortrait;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SalesInvoicePortrait)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SalesInvoicePortrait>(ref this.m_SalesInvoicePortrait);
					}
				}
			}

			// Token: 0x170023FE RID: 9214
			// (get) Token: 0x06006306 RID: 25350 RVA: 0x0037C451 File Offset: 0x0037A651
			// (set) Token: 0x060063B9 RID: 25529 RVA: 0x0037DF19 File Offset: 0x0037C119
			public SalesInvoicePortraitBinum SalesInvoicePortraitBinum
			{
				[DebuggerHidden]
				get
				{
					this.m_SalesInvoicePortraitBinum = MyProject.MyForms.Create__Instance__<SalesInvoicePortraitBinum>(this.m_SalesInvoicePortraitBinum);
					return this.m_SalesInvoicePortraitBinum;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SalesInvoicePortraitBinum)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SalesInvoicePortraitBinum>(ref this.m_SalesInvoicePortraitBinum);
					}
				}
			}

			// Token: 0x170023FF RID: 9215
			// (get) Token: 0x06006307 RID: 25351 RVA: 0x0037C46C File Offset: 0x0037A66C
			// (set) Token: 0x060063BA RID: 25530 RVA: 0x0037DF45 File Offset: 0x0037C145
			public SalesInvoicePortraitBooking SalesInvoicePortraitBooking
			{
				[DebuggerHidden]
				get
				{
					this.m_SalesInvoicePortraitBooking = MyProject.MyForms.Create__Instance__<SalesInvoicePortraitBooking>(this.m_SalesInvoicePortraitBooking);
					return this.m_SalesInvoicePortraitBooking;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SalesInvoicePortraitBooking)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SalesInvoicePortraitBooking>(ref this.m_SalesInvoicePortraitBooking);
					}
				}
			}

			// Token: 0x17002400 RID: 9216
			// (get) Token: 0x06006308 RID: 25352 RVA: 0x0037C487 File Offset: 0x0037A687
			// (set) Token: 0x060063BB RID: 25531 RVA: 0x0037DF71 File Offset: 0x0037C171
			public SalesInvoicePortraitCN SalesInvoicePortraitCN
			{
				[DebuggerHidden]
				get
				{
					this.m_SalesInvoicePortraitCN = MyProject.MyForms.Create__Instance__<SalesInvoicePortraitCN>(this.m_SalesInvoicePortraitCN);
					return this.m_SalesInvoicePortraitCN;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SalesInvoicePortraitCN)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SalesInvoicePortraitCN>(ref this.m_SalesInvoicePortraitCN);
					}
				}
			}

			// Token: 0x17002401 RID: 9217
			// (get) Token: 0x06006309 RID: 25353 RVA: 0x0037C4A2 File Offset: 0x0037A6A2
			// (set) Token: 0x060063BC RID: 25532 RVA: 0x0037DF9D File Offset: 0x0037C19D
			public SalesInvoicePortraitFarhan SalesInvoicePortraitFarhan
			{
				[DebuggerHidden]
				get
				{
					this.m_SalesInvoicePortraitFarhan = MyProject.MyForms.Create__Instance__<SalesInvoicePortraitFarhan>(this.m_SalesInvoicePortraitFarhan);
					return this.m_SalesInvoicePortraitFarhan;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SalesInvoicePortraitFarhan)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SalesInvoicePortraitFarhan>(ref this.m_SalesInvoicePortraitFarhan);
					}
				}
			}

			// Token: 0x17002402 RID: 9218
			// (get) Token: 0x0600630A RID: 25354 RVA: 0x0037C4BD File Offset: 0x0037A6BD
			// (set) Token: 0x060063BD RID: 25533 RVA: 0x0037DFC9 File Offset: 0x0037C1C9
			public SalesInvoicePortraitFDMS SalesInvoicePortraitFDMS
			{
				[DebuggerHidden]
				get
				{
					this.m_SalesInvoicePortraitFDMS = MyProject.MyForms.Create__Instance__<SalesInvoicePortraitFDMS>(this.m_SalesInvoicePortraitFDMS);
					return this.m_SalesInvoicePortraitFDMS;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SalesInvoicePortraitFDMS)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SalesInvoicePortraitFDMS>(ref this.m_SalesInvoicePortraitFDMS);
					}
				}
			}

			// Token: 0x17002403 RID: 9219
			// (get) Token: 0x0600630B RID: 25355 RVA: 0x0037C4D8 File Offset: 0x0037A6D8
			// (set) Token: 0x060063BE RID: 25534 RVA: 0x0037DFF5 File Offset: 0x0037C1F5
			public SalesInvoicePortraitGetpro SalesInvoicePortraitGetpro
			{
				[DebuggerHidden]
				get
				{
					this.m_SalesInvoicePortraitGetpro = MyProject.MyForms.Create__Instance__<SalesInvoicePortraitGetpro>(this.m_SalesInvoicePortraitGetpro);
					return this.m_SalesInvoicePortraitGetpro;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SalesInvoicePortraitGetpro)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SalesInvoicePortraitGetpro>(ref this.m_SalesInvoicePortraitGetpro);
					}
				}
			}

			// Token: 0x17002404 RID: 9220
			// (get) Token: 0x0600630C RID: 25356 RVA: 0x0037C4F3 File Offset: 0x0037A6F3
			// (set) Token: 0x060063BF RID: 25535 RVA: 0x0037E021 File Offset: 0x0037C221
			public SalesInvoicePortraitInco SalesInvoicePortraitInco
			{
				[DebuggerHidden]
				get
				{
					this.m_SalesInvoicePortraitInco = MyProject.MyForms.Create__Instance__<SalesInvoicePortraitInco>(this.m_SalesInvoicePortraitInco);
					return this.m_SalesInvoicePortraitInco;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SalesInvoicePortraitInco)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SalesInvoicePortraitInco>(ref this.m_SalesInvoicePortraitInco);
					}
				}
			}

			// Token: 0x17002405 RID: 9221
			// (get) Token: 0x0600630D RID: 25357 RVA: 0x0037C50E File Offset: 0x0037A70E
			// (set) Token: 0x060063C0 RID: 25536 RVA: 0x0037E04D File Offset: 0x0037C24D
			public SalesInvoicePortraitLea SalesInvoicePortraitLea
			{
				[DebuggerHidden]
				get
				{
					this.m_SalesInvoicePortraitLea = MyProject.MyForms.Create__Instance__<SalesInvoicePortraitLea>(this.m_SalesInvoicePortraitLea);
					return this.m_SalesInvoicePortraitLea;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SalesInvoicePortraitLea)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SalesInvoicePortraitLea>(ref this.m_SalesInvoicePortraitLea);
					}
				}
			}

			// Token: 0x17002406 RID: 9222
			// (get) Token: 0x0600630E RID: 25358 RVA: 0x0037C529 File Offset: 0x0037A729
			// (set) Token: 0x060063C1 RID: 25537 RVA: 0x0037E079 File Offset: 0x0037C279
			public SalesInvoicePortraitPharma SalesInvoicePortraitPharma
			{
				[DebuggerHidden]
				get
				{
					this.m_SalesInvoicePortraitPharma = MyProject.MyForms.Create__Instance__<SalesInvoicePortraitPharma>(this.m_SalesInvoicePortraitPharma);
					return this.m_SalesInvoicePortraitPharma;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SalesInvoicePortraitPharma)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SalesInvoicePortraitPharma>(ref this.m_SalesInvoicePortraitPharma);
					}
				}
			}

			// Token: 0x17002407 RID: 9223
			// (get) Token: 0x0600630F RID: 25359 RVA: 0x0037C544 File Offset: 0x0037A744
			// (set) Token: 0x060063C2 RID: 25538 RVA: 0x0037E0A5 File Offset: 0x0037C2A5
			public SalesInvoicePortraitTongaat SalesInvoicePortraitTongaat
			{
				[DebuggerHidden]
				get
				{
					this.m_SalesInvoicePortraitTongaat = MyProject.MyForms.Create__Instance__<SalesInvoicePortraitTongaat>(this.m_SalesInvoicePortraitTongaat);
					return this.m_SalesInvoicePortraitTongaat;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SalesInvoicePortraitTongaat)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SalesInvoicePortraitTongaat>(ref this.m_SalesInvoicePortraitTongaat);
					}
				}
			}

			// Token: 0x17002408 RID: 9224
			// (get) Token: 0x06006310 RID: 25360 RVA: 0x0037C55F File Offset: 0x0037A75F
			// (set) Token: 0x060063C3 RID: 25539 RVA: 0x0037E0D1 File Offset: 0x0037C2D1
			public SalesInvoiceRevmax SalesInvoiceRevmax
			{
				[DebuggerHidden]
				get
				{
					this.m_SalesInvoiceRevmax = MyProject.MyForms.Create__Instance__<SalesInvoiceRevmax>(this.m_SalesInvoiceRevmax);
					return this.m_SalesInvoiceRevmax;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SalesInvoiceRevmax)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SalesInvoiceRevmax>(ref this.m_SalesInvoiceRevmax);
					}
				}
			}

			// Token: 0x17002409 RID: 9225
			// (get) Token: 0x06006311 RID: 25361 RVA: 0x0037C57A File Offset: 0x0037A77A
			// (set) Token: 0x060063C4 RID: 25540 RVA: 0x0037E0FD File Offset: 0x0037C2FD
			public SalesInvoiceWholesale SalesInvoiceWholesale
			{
				[DebuggerHidden]
				get
				{
					this.m_SalesInvoiceWholesale = MyProject.MyForms.Create__Instance__<SalesInvoiceWholesale>(this.m_SalesInvoiceWholesale);
					return this.m_SalesInvoiceWholesale;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SalesInvoiceWholesale)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SalesInvoiceWholesale>(ref this.m_SalesInvoiceWholesale);
					}
				}
			}

			// Token: 0x1700240A RID: 9226
			// (get) Token: 0x06006312 RID: 25362 RVA: 0x0037C595 File Offset: 0x0037A795
			// (set) Token: 0x060063C5 RID: 25541 RVA: 0x0037E129 File Offset: 0x0037C329
			public SalesInvPortraitBooking SalesInvPortraitBooking
			{
				[DebuggerHidden]
				get
				{
					this.m_SalesInvPortraitBooking = MyProject.MyForms.Create__Instance__<SalesInvPortraitBooking>(this.m_SalesInvPortraitBooking);
					return this.m_SalesInvPortraitBooking;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SalesInvPortraitBooking)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SalesInvPortraitBooking>(ref this.m_SalesInvPortraitBooking);
					}
				}
			}

			// Token: 0x1700240B RID: 9227
			// (get) Token: 0x06006313 RID: 25363 RVA: 0x0037C5B0 File Offset: 0x0037A7B0
			// (set) Token: 0x060063C6 RID: 25542 RVA: 0x0037E155 File Offset: 0x0037C355
			public SearchComments SearchComments
			{
				[DebuggerHidden]
				get
				{
					this.m_SearchComments = MyProject.MyForms.Create__Instance__<SearchComments>(this.m_SearchComments);
					return this.m_SearchComments;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SearchComments)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SearchComments>(ref this.m_SearchComments);
					}
				}
			}

			// Token: 0x1700240C RID: 9228
			// (get) Token: 0x06006314 RID: 25364 RVA: 0x0037C5CB File Offset: 0x0037A7CB
			// (set) Token: 0x060063C7 RID: 25543 RVA: 0x0037E181 File Offset: 0x0037C381
			public SecondSalesScreen SecondSalesScreen
			{
				[DebuggerHidden]
				get
				{
					this.m_SecondSalesScreen = MyProject.MyForms.Create__Instance__<SecondSalesScreen>(this.m_SecondSalesScreen);
					return this.m_SecondSalesScreen;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SecondSalesScreen)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SecondSalesScreen>(ref this.m_SecondSalesScreen);
					}
				}
			}

			// Token: 0x1700240D RID: 9229
			// (get) Token: 0x06006315 RID: 25365 RVA: 0x0037C5E6 File Offset: 0x0037A7E6
			// (set) Token: 0x060063C8 RID: 25544 RVA: 0x0037E1AD File Offset: 0x0037C3AD
			public SelectBranches SelectBranches
			{
				[DebuggerHidden]
				get
				{
					this.m_SelectBranches = MyProject.MyForms.Create__Instance__<SelectBranches>(this.m_SelectBranches);
					return this.m_SelectBranches;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SelectBranches)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SelectBranches>(ref this.m_SelectBranches);
					}
				}
			}

			// Token: 0x1700240E RID: 9230
			// (get) Token: 0x06006316 RID: 25366 RVA: 0x0037C601 File Offset: 0x0037A801
			// (set) Token: 0x060063C9 RID: 25545 RVA: 0x0037E1D9 File Offset: 0x0037C3D9
			public SelectCategories SelectCategories
			{
				[DebuggerHidden]
				get
				{
					this.m_SelectCategories = MyProject.MyForms.Create__Instance__<SelectCategories>(this.m_SelectCategories);
					return this.m_SelectCategories;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SelectCategories)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SelectCategories>(ref this.m_SelectCategories);
					}
				}
			}

			// Token: 0x1700240F RID: 9231
			// (get) Token: 0x06006317 RID: 25367 RVA: 0x0037C61C File Offset: 0x0037A81C
			// (set) Token: 0x060063CA RID: 25546 RVA: 0x0037E205 File Offset: 0x0037C405
			public SelectKDU SelectKDU
			{
				[DebuggerHidden]
				get
				{
					this.m_SelectKDU = MyProject.MyForms.Create__Instance__<SelectKDU>(this.m_SelectKDU);
					return this.m_SelectKDU;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SelectKDU)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SelectKDU>(ref this.m_SelectKDU);
					}
				}
			}

			// Token: 0x17002410 RID: 9232
			// (get) Token: 0x06006318 RID: 25368 RVA: 0x0037C637 File Offset: 0x0037A837
			// (set) Token: 0x060063CB RID: 25547 RVA: 0x0037E231 File Offset: 0x0037C431
			public SelectMNO SelectMNO
			{
				[DebuggerHidden]
				get
				{
					this.m_SelectMNO = MyProject.MyForms.Create__Instance__<SelectMNO>(this.m_SelectMNO);
					return this.m_SelectMNO;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SelectMNO)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SelectMNO>(ref this.m_SelectMNO);
					}
				}
			}

			// Token: 0x17002411 RID: 9233
			// (get) Token: 0x06006319 RID: 25369 RVA: 0x0037C652 File Offset: 0x0037A852
			// (set) Token: 0x060063CC RID: 25548 RVA: 0x0037E25D File Offset: 0x0037C45D
			public SelectSerialNumbers SelectSerialNumbers
			{
				[DebuggerHidden]
				get
				{
					this.m_SelectSerialNumbers = MyProject.MyForms.Create__Instance__<SelectSerialNumbers>(this.m_SelectSerialNumbers);
					return this.m_SelectSerialNumbers;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SelectSerialNumbers)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SelectSerialNumbers>(ref this.m_SelectSerialNumbers);
					}
				}
			}

			// Token: 0x17002412 RID: 9234
			// (get) Token: 0x0600631A RID: 25370 RVA: 0x0037C66D File Offset: 0x0037A86D
			// (set) Token: 0x060063CD RID: 25549 RVA: 0x0037E289 File Offset: 0x0037C489
			public SelectTable SelectTable
			{
				[DebuggerHidden]
				get
				{
					this.m_SelectTable = MyProject.MyForms.Create__Instance__<SelectTable>(this.m_SelectTable);
					return this.m_SelectTable;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SelectTable)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SelectTable>(ref this.m_SelectTable);
					}
				}
			}

			// Token: 0x17002413 RID: 9235
			// (get) Token: 0x0600631B RID: 25371 RVA: 0x0037C688 File Offset: 0x0037A888
			// (set) Token: 0x060063CE RID: 25550 RVA: 0x0037E2B5 File Offset: 0x0037C4B5
			public SelectUserForm SelectUserForm
			{
				[DebuggerHidden]
				get
				{
					this.m_SelectUserForm = MyProject.MyForms.Create__Instance__<SelectUserForm>(this.m_SelectUserForm);
					return this.m_SelectUserForm;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SelectUserForm)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SelectUserForm>(ref this.m_SelectUserForm);
					}
				}
			}

			// Token: 0x17002414 RID: 9236
			// (get) Token: 0x0600631C RID: 25372 RVA: 0x0037C6A3 File Offset: 0x0037A8A3
			// (set) Token: 0x060063CF RID: 25551 RVA: 0x0037E2E1 File Offset: 0x0037C4E1
			public SendSmS SendSmS
			{
				[DebuggerHidden]
				get
				{
					this.m_SendSmS = MyProject.MyForms.Create__Instance__<SendSmS>(this.m_SendSmS);
					return this.m_SendSmS;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SendSmS)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SendSmS>(ref this.m_SendSmS);
					}
				}
			}

			// Token: 0x17002415 RID: 9237
			// (get) Token: 0x0600631D RID: 25373 RVA: 0x0037C6BE File Offset: 0x0037A8BE
			// (set) Token: 0x060063D0 RID: 25552 RVA: 0x0037E30D File Offset: 0x0037C50D
			public SetCategorySideMenus SetCategorySideMenus
			{
				[DebuggerHidden]
				get
				{
					this.m_SetCategorySideMenus = MyProject.MyForms.Create__Instance__<SetCategorySideMenus>(this.m_SetCategorySideMenus);
					return this.m_SetCategorySideMenus;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SetCategorySideMenus)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SetCategorySideMenus>(ref this.m_SetCategorySideMenus);
					}
				}
			}

			// Token: 0x17002416 RID: 9238
			// (get) Token: 0x0600631E RID: 25374 RVA: 0x0037C6D9 File Offset: 0x0037A8D9
			// (set) Token: 0x060063D1 RID: 25553 RVA: 0x0037E339 File Offset: 0x0037C539
			public SetDiscountPercentage SetDiscountPercentage
			{
				[DebuggerHidden]
				get
				{
					this.m_SetDiscountPercentage = MyProject.MyForms.Create__Instance__<SetDiscountPercentage>(this.m_SetDiscountPercentage);
					return this.m_SetDiscountPercentage;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SetDiscountPercentage)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SetDiscountPercentage>(ref this.m_SetDiscountPercentage);
					}
				}
			}

			// Token: 0x17002417 RID: 9239
			// (get) Token: 0x0600631F RID: 25375 RVA: 0x0037C6F4 File Offset: 0x0037A8F4
			// (set) Token: 0x060063D2 RID: 25554 RVA: 0x0037E365 File Offset: 0x0037C565
			public SetHSCodes SetHSCodes
			{
				[DebuggerHidden]
				get
				{
					this.m_SetHSCodes = MyProject.MyForms.Create__Instance__<SetHSCodes>(this.m_SetHSCodes);
					return this.m_SetHSCodes;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SetHSCodes)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SetHSCodes>(ref this.m_SetHSCodes);
					}
				}
			}

			// Token: 0x17002418 RID: 9240
			// (get) Token: 0x06006320 RID: 25376 RVA: 0x0037C70F File Offset: 0x0037A90F
			// (set) Token: 0x060063D3 RID: 25555 RVA: 0x0037E391 File Offset: 0x0037C591
			public ShiftReportForm ShiftReportForm
			{
				[DebuggerHidden]
				get
				{
					this.m_ShiftReportForm = MyProject.MyForms.Create__Instance__<ShiftReportForm>(this.m_ShiftReportForm);
					return this.m_ShiftReportForm;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_ShiftReportForm)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ShiftReportForm>(ref this.m_ShiftReportForm);
					}
				}
			}

			// Token: 0x17002419 RID: 9241
			// (get) Token: 0x06006321 RID: 25377 RVA: 0x0037C72A File Offset: 0x0037A92A
			// (set) Token: 0x060063D4 RID: 25556 RVA: 0x0037E3BD File Offset: 0x0037C5BD
			public StockAdjustmentsReportCum StockAdjustmentsReportCum
			{
				[DebuggerHidden]
				get
				{
					this.m_StockAdjustmentsReportCum = MyProject.MyForms.Create__Instance__<StockAdjustmentsReportCum>(this.m_StockAdjustmentsReportCum);
					return this.m_StockAdjustmentsReportCum;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_StockAdjustmentsReportCum)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<StockAdjustmentsReportCum>(ref this.m_StockAdjustmentsReportCum);
					}
				}
			}

			// Token: 0x1700241A RID: 9242
			// (get) Token: 0x06006322 RID: 25378 RVA: 0x0037C745 File Offset: 0x0037A945
			// (set) Token: 0x060063D5 RID: 25557 RVA: 0x0037E3E9 File Offset: 0x0037C5E9
			public StockAging StockAging
			{
				[DebuggerHidden]
				get
				{
					this.m_StockAging = MyProject.MyForms.Create__Instance__<StockAging>(this.m_StockAging);
					return this.m_StockAging;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_StockAging)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<StockAging>(ref this.m_StockAging);
					}
				}
			}

			// Token: 0x1700241B RID: 9243
			// (get) Token: 0x06006323 RID: 25379 RVA: 0x0037C760 File Offset: 0x0037A960
			// (set) Token: 0x060063D6 RID: 25558 RVA: 0x0037E415 File Offset: 0x0037C615
			public StockPurchasesforProduct StockPurchasesforProduct
			{
				[DebuggerHidden]
				get
				{
					this.m_StockPurchasesforProduct = MyProject.MyForms.Create__Instance__<StockPurchasesforProduct>(this.m_StockPurchasesforProduct);
					return this.m_StockPurchasesforProduct;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_StockPurchasesforProduct)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<StockPurchasesforProduct>(ref this.m_StockPurchasesforProduct);
					}
				}
			}

			// Token: 0x1700241C RID: 9244
			// (get) Token: 0x06006324 RID: 25380 RVA: 0x0037C77B File Offset: 0x0037A97B
			// (set) Token: 0x060063D7 RID: 25559 RVA: 0x0037E441 File Offset: 0x0037C641
			public StockSheetsWarehouse StockSheetsWarehouse
			{
				[DebuggerHidden]
				get
				{
					this.m_StockSheetsWarehouse = MyProject.MyForms.Create__Instance__<StockSheetsWarehouse>(this.m_StockSheetsWarehouse);
					return this.m_StockSheetsWarehouse;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_StockSheetsWarehouse)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<StockSheetsWarehouse>(ref this.m_StockSheetsWarehouse);
					}
				}
			}

			// Token: 0x1700241D RID: 9245
			// (get) Token: 0x06006325 RID: 25381 RVA: 0x0037C796 File Offset: 0x0037A996
			// (set) Token: 0x060063D8 RID: 25560 RVA: 0x0037E46D File Offset: 0x0037C66D
			public StockTake StockTake
			{
				[DebuggerHidden]
				get
				{
					this.m_StockTake = MyProject.MyForms.Create__Instance__<StockTake>(this.m_StockTake);
					return this.m_StockTake;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_StockTake)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<StockTake>(ref this.m_StockTake);
					}
				}
			}

			// Token: 0x1700241E RID: 9246
			// (get) Token: 0x06006326 RID: 25382 RVA: 0x0037C7B1 File Offset: 0x0037A9B1
			// (set) Token: 0x060063D9 RID: 25561 RVA: 0x0037E499 File Offset: 0x0037C699
			public StockTake1Item StockTake1Item
			{
				[DebuggerHidden]
				get
				{
					this.m_StockTake1Item = MyProject.MyForms.Create__Instance__<StockTake1Item>(this.m_StockTake1Item);
					return this.m_StockTake1Item;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_StockTake1Item)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<StockTake1Item>(ref this.m_StockTake1Item);
					}
				}
			}

			// Token: 0x1700241F RID: 9247
			// (get) Token: 0x06006327 RID: 25383 RVA: 0x0037C7CC File Offset: 0x0037A9CC
			// (set) Token: 0x060063DA RID: 25562 RVA: 0x0037E4C5 File Offset: 0x0037C6C5
			public StockTakeCumulative StockTakeCumulative
			{
				[DebuggerHidden]
				get
				{
					this.m_StockTakeCumulative = MyProject.MyForms.Create__Instance__<StockTakeCumulative>(this.m_StockTakeCumulative);
					return this.m_StockTakeCumulative;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_StockTakeCumulative)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<StockTakeCumulative>(ref this.m_StockTakeCumulative);
					}
				}
			}

			// Token: 0x17002420 RID: 9248
			// (get) Token: 0x06006328 RID: 25384 RVA: 0x0037C7E7 File Offset: 0x0037A9E7
			// (set) Token: 0x060063DB RID: 25563 RVA: 0x0037E4F1 File Offset: 0x0037C6F1
			public StockTakeExcel StockTakeExcel
			{
				[DebuggerHidden]
				get
				{
					this.m_StockTakeExcel = MyProject.MyForms.Create__Instance__<StockTakeExcel>(this.m_StockTakeExcel);
					return this.m_StockTakeExcel;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_StockTakeExcel)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<StockTakeExcel>(ref this.m_StockTakeExcel);
					}
				}
			}

			// Token: 0x17002421 RID: 9249
			// (get) Token: 0x06006329 RID: 25385 RVA: 0x0037C802 File Offset: 0x0037AA02
			// (set) Token: 0x060063DC RID: 25564 RVA: 0x0037E51D File Offset: 0x0037C71D
			public StockTakeWarehouse StockTakeWarehouse
			{
				[DebuggerHidden]
				get
				{
					this.m_StockTakeWarehouse = MyProject.MyForms.Create__Instance__<StockTakeWarehouse>(this.m_StockTakeWarehouse);
					return this.m_StockTakeWarehouse;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_StockTakeWarehouse)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<StockTakeWarehouse>(ref this.m_StockTakeWarehouse);
					}
				}
			}

			// Token: 0x17002422 RID: 9250
			// (get) Token: 0x0600632A RID: 25386 RVA: 0x0037C81D File Offset: 0x0037AA1D
			// (set) Token: 0x060063DD RID: 25565 RVA: 0x0037E549 File Offset: 0x0037C749
			public StockTransfersForPeriod StockTransfersForPeriod
			{
				[DebuggerHidden]
				get
				{
					this.m_StockTransfersForPeriod = MyProject.MyForms.Create__Instance__<StockTransfersForPeriod>(this.m_StockTransfersForPeriod);
					return this.m_StockTransfersForPeriod;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_StockTransfersForPeriod)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<StockTransfersForPeriod>(ref this.m_StockTransfersForPeriod);
					}
				}
			}

			// Token: 0x17002423 RID: 9251
			// (get) Token: 0x0600632B RID: 25387 RVA: 0x0037C838 File Offset: 0x0037AA38
			// (set) Token: 0x060063DE RID: 25566 RVA: 0x0037E575 File Offset: 0x0037C775
			public StockTransfersForPeriodFrom StockTransfersForPeriodFrom
			{
				[DebuggerHidden]
				get
				{
					this.m_StockTransfersForPeriodFrom = MyProject.MyForms.Create__Instance__<StockTransfersForPeriodFrom>(this.m_StockTransfersForPeriodFrom);
					return this.m_StockTransfersForPeriodFrom;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_StockTransfersForPeriodFrom)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<StockTransfersForPeriodFrom>(ref this.m_StockTransfersForPeriodFrom);
					}
				}
			}

			// Token: 0x17002424 RID: 9252
			// (get) Token: 0x0600632C RID: 25388 RVA: 0x0037C853 File Offset: 0x0037AA53
			// (set) Token: 0x060063DF RID: 25567 RVA: 0x0037E5A1 File Offset: 0x0037C7A1
			public SupervisorApproval SupervisorApproval
			{
				[DebuggerHidden]
				get
				{
					this.m_SupervisorApproval = MyProject.MyForms.Create__Instance__<SupervisorApproval>(this.m_SupervisorApproval);
					return this.m_SupervisorApproval;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SupervisorApproval)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SupervisorApproval>(ref this.m_SupervisorApproval);
					}
				}
			}

			// Token: 0x17002425 RID: 9253
			// (get) Token: 0x0600632D RID: 25389 RVA: 0x0037C86E File Offset: 0x0037AA6E
			// (set) Token: 0x060063E0 RID: 25568 RVA: 0x0037E5CD File Offset: 0x0037C7CD
			public SupplierAging SupplierAging
			{
				[DebuggerHidden]
				get
				{
					this.m_SupplierAging = MyProject.MyForms.Create__Instance__<SupplierAging>(this.m_SupplierAging);
					return this.m_SupplierAging;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_SupplierAging)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<SupplierAging>(ref this.m_SupplierAging);
					}
				}
			}

			// Token: 0x17002426 RID: 9254
			// (get) Token: 0x0600632E RID: 25390 RVA: 0x0037C889 File Offset: 0x0037AA89
			// (set) Token: 0x060063E1 RID: 25569 RVA: 0x0037E5F9 File Offset: 0x0037C7F9
			public Suppliers Suppliers
			{
				[DebuggerHidden]
				get
				{
					this.m_Suppliers = MyProject.MyForms.Create__Instance__<Suppliers>(this.m_Suppliers);
					return this.m_Suppliers;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Suppliers)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Suppliers>(ref this.m_Suppliers);
					}
				}
			}

			// Token: 0x17002427 RID: 9255
			// (get) Token: 0x0600632F RID: 25391 RVA: 0x0037C8A4 File Offset: 0x0037AAA4
			// (set) Token: 0x060063E2 RID: 25570 RVA: 0x0037E625 File Offset: 0x0037C825
			public TellerDisbursements TellerDisbursements
			{
				[DebuggerHidden]
				get
				{
					this.m_TellerDisbursements = MyProject.MyForms.Create__Instance__<TellerDisbursements>(this.m_TellerDisbursements);
					return this.m_TellerDisbursements;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_TellerDisbursements)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<TellerDisbursements>(ref this.m_TellerDisbursements);
					}
				}
			}

			// Token: 0x17002428 RID: 9256
			// (get) Token: 0x06006330 RID: 25392 RVA: 0x0037C8BF File Offset: 0x0037AABF
			// (set) Token: 0x060063E3 RID: 25571 RVA: 0x0037E651 File Offset: 0x0037C851
			public TestComport TestComport
			{
				[DebuggerHidden]
				get
				{
					this.m_TestComport = MyProject.MyForms.Create__Instance__<TestComport>(this.m_TestComport);
					return this.m_TestComport;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_TestComport)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<TestComport>(ref this.m_TestComport);
					}
				}
			}

			// Token: 0x17002429 RID: 9257
			// (get) Token: 0x06006331 RID: 25393 RVA: 0x0037C8DA File Offset: 0x0037AADA
			// (set) Token: 0x060063E4 RID: 25572 RVA: 0x0037E67D File Offset: 0x0037C87D
			public TestConnectedScale TestConnectedScale
			{
				[DebuggerHidden]
				get
				{
					this.m_TestConnectedScale = MyProject.MyForms.Create__Instance__<TestConnectedScale>(this.m_TestConnectedScale);
					return this.m_TestConnectedScale;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_TestConnectedScale)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<TestConnectedScale>(ref this.m_TestConnectedScale);
					}
				}
			}

			// Token: 0x1700242A RID: 9258
			// (get) Token: 0x06006332 RID: 25394 RVA: 0x0037C8F5 File Offset: 0x0037AAF5
			// (set) Token: 0x060063E5 RID: 25573 RVA: 0x0037E6A9 File Offset: 0x0037C8A9
			public TIP TIP
			{
				[DebuggerHidden]
				get
				{
					this.m_TIP = MyProject.MyForms.Create__Instance__<TIP>(this.m_TIP);
					return this.m_TIP;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_TIP)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<TIP>(ref this.m_TIP);
					}
				}
			}

			// Token: 0x1700242B RID: 9259
			// (get) Token: 0x06006333 RID: 25395 RVA: 0x0037C910 File Offset: 0x0037AB10
			// (set) Token: 0x060063E6 RID: 25574 RVA: 0x0037E6D5 File Offset: 0x0037C8D5
			public Users Users
			{
				[DebuggerHidden]
				get
				{
					this.m_Users = MyProject.MyForms.Create__Instance__<Users>(this.m_Users);
					return this.m_Users;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Users)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Users>(ref this.m_Users);
					}
				}
			}

			// Token: 0x1700242C RID: 9260
			// (get) Token: 0x06006334 RID: 25396 RVA: 0x0037C92B File Offset: 0x0037AB2B
			// (set) Token: 0x060063E7 RID: 25575 RVA: 0x0037E701 File Offset: 0x0037C901
			public VerifyOpenImpReports VerifyOpenImpReports
			{
				[DebuggerHidden]
				get
				{
					this.m_VerifyOpenImpReports = MyProject.MyForms.Create__Instance__<VerifyOpenImpReports>(this.m_VerifyOpenImpReports);
					return this.m_VerifyOpenImpReports;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_VerifyOpenImpReports)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<VerifyOpenImpReports>(ref this.m_VerifyOpenImpReports);
					}
				}
			}

			// Token: 0x1700242D RID: 9261
			// (get) Token: 0x06006335 RID: 25397 RVA: 0x0037C946 File Offset: 0x0037AB46
			// (set) Token: 0x060063E8 RID: 25576 RVA: 0x0037E72D File Offset: 0x0037C92D
			public Videos Videos
			{
				[DebuggerHidden]
				get
				{
					this.m_Videos = MyProject.MyForms.Create__Instance__<Videos>(this.m_Videos);
					return this.m_Videos;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_Videos)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<Videos>(ref this.m_Videos);
					}
				}
			}

			// Token: 0x1700242E RID: 9262
			// (get) Token: 0x06006336 RID: 25398 RVA: 0x0037C961 File Offset: 0x0037AB61
			// (set) Token: 0x060063E9 RID: 25577 RVA: 0x0037E759 File Offset: 0x0037C959
			public ViewBatchNumberChanges ViewBatchNumberChanges
			{
				[DebuggerHidden]
				get
				{
					this.m_ViewBatchNumberChanges = MyProject.MyForms.Create__Instance__<ViewBatchNumberChanges>(this.m_ViewBatchNumberChanges);
					return this.m_ViewBatchNumberChanges;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_ViewBatchNumberChanges)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ViewBatchNumberChanges>(ref this.m_ViewBatchNumberChanges);
					}
				}
			}

			// Token: 0x1700242F RID: 9263
			// (get) Token: 0x06006337 RID: 25399 RVA: 0x0037C97C File Offset: 0x0037AB7C
			// (set) Token: 0x060063EA RID: 25578 RVA: 0x0037E785 File Offset: 0x0037C985
			public ViewDebitNote ViewDebitNote
			{
				[DebuggerHidden]
				get
				{
					this.m_ViewDebitNote = MyProject.MyForms.Create__Instance__<ViewDebitNote>(this.m_ViewDebitNote);
					return this.m_ViewDebitNote;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_ViewDebitNote)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ViewDebitNote>(ref this.m_ViewDebitNote);
					}
				}
			}

			// Token: 0x17002430 RID: 9264
			// (get) Token: 0x06006338 RID: 25400 RVA: 0x0037C997 File Offset: 0x0037AB97
			// (set) Token: 0x060063EB RID: 25579 RVA: 0x0037E7B1 File Offset: 0x0037C9B1
			public ViewInvoiceDetails ViewInvoiceDetails
			{
				[DebuggerHidden]
				get
				{
					this.m_ViewInvoiceDetails = MyProject.MyForms.Create__Instance__<ViewInvoiceDetails>(this.m_ViewInvoiceDetails);
					return this.m_ViewInvoiceDetails;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_ViewInvoiceDetails)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ViewInvoiceDetails>(ref this.m_ViewInvoiceDetails);
					}
				}
			}

			// Token: 0x17002431 RID: 9265
			// (get) Token: 0x06006339 RID: 25401 RVA: 0x0037C9B2 File Offset: 0x0037ABB2
			// (set) Token: 0x060063EC RID: 25580 RVA: 0x0037E7DD File Offset: 0x0037C9DD
			public ViewPricesAvailability ViewPricesAvailability
			{
				[DebuggerHidden]
				get
				{
					this.m_ViewPricesAvailability = MyProject.MyForms.Create__Instance__<ViewPricesAvailability>(this.m_ViewPricesAvailability);
					return this.m_ViewPricesAvailability;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_ViewPricesAvailability)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ViewPricesAvailability>(ref this.m_ViewPricesAvailability);
					}
				}
			}

			// Token: 0x17002432 RID: 9266
			// (get) Token: 0x0600633A RID: 25402 RVA: 0x0037C9CD File Offset: 0x0037ABCD
			// (set) Token: 0x060063ED RID: 25581 RVA: 0x0037E809 File Offset: 0x0037CA09
			public ViewProductCreditNotes ViewProductCreditNotes
			{
				[DebuggerHidden]
				get
				{
					this.m_ViewProductCreditNotes = MyProject.MyForms.Create__Instance__<ViewProductCreditNotes>(this.m_ViewProductCreditNotes);
					return this.m_ViewProductCreditNotes;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_ViewProductCreditNotes)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ViewProductCreditNotes>(ref this.m_ViewProductCreditNotes);
					}
				}
			}

			// Token: 0x17002433 RID: 9267
			// (get) Token: 0x0600633B RID: 25403 RVA: 0x0037C9E8 File Offset: 0x0037ABE8
			// (set) Token: 0x060063EE RID: 25582 RVA: 0x0037E835 File Offset: 0x0037CA35
			public ViewProducts ViewProducts
			{
				[DebuggerHidden]
				get
				{
					this.m_ViewProducts = MyProject.MyForms.Create__Instance__<ViewProducts>(this.m_ViewProducts);
					return this.m_ViewProducts;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_ViewProducts)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ViewProducts>(ref this.m_ViewProducts);
					}
				}
			}

			// Token: 0x17002434 RID: 9268
			// (get) Token: 0x0600633C RID: 25404 RVA: 0x0037CA03 File Offset: 0x0037AC03
			// (set) Token: 0x060063EF RID: 25583 RVA: 0x0037E861 File Offset: 0x0037CA61
			public ViewProducts2 ViewProducts2
			{
				[DebuggerHidden]
				get
				{
					this.m_ViewProducts2 = MyProject.MyForms.Create__Instance__<ViewProducts2>(this.m_ViewProducts2);
					return this.m_ViewProducts2;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_ViewProducts2)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ViewProducts2>(ref this.m_ViewProducts2);
					}
				}
			}

			// Token: 0x17002435 RID: 9269
			// (get) Token: 0x0600633D RID: 25405 RVA: 0x0037CA1E File Offset: 0x0037AC1E
			// (set) Token: 0x060063F0 RID: 25584 RVA: 0x0037E88D File Offset: 0x0037CA8D
			public ViewPurchaseReturns ViewPurchaseReturns
			{
				[DebuggerHidden]
				get
				{
					this.m_ViewPurchaseReturns = MyProject.MyForms.Create__Instance__<ViewPurchaseReturns>(this.m_ViewPurchaseReturns);
					return this.m_ViewPurchaseReturns;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_ViewPurchaseReturns)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ViewPurchaseReturns>(ref this.m_ViewPurchaseReturns);
					}
				}
			}

			// Token: 0x17002436 RID: 9270
			// (get) Token: 0x0600633E RID: 25406 RVA: 0x0037CA39 File Offset: 0x0037AC39
			// (set) Token: 0x060063F1 RID: 25585 RVA: 0x0037E8B9 File Offset: 0x0037CAB9
			public ViewSelectedCategories ViewSelectedCategories
			{
				[DebuggerHidden]
				get
				{
					this.m_ViewSelectedCategories = MyProject.MyForms.Create__Instance__<ViewSelectedCategories>(this.m_ViewSelectedCategories);
					return this.m_ViewSelectedCategories;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_ViewSelectedCategories)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ViewSelectedCategories>(ref this.m_ViewSelectedCategories);
					}
				}
			}

			// Token: 0x17002437 RID: 9271
			// (get) Token: 0x0600633F RID: 25407 RVA: 0x0037CA54 File Offset: 0x0037AC54
			// (set) Token: 0x060063F2 RID: 25586 RVA: 0x0037E8E5 File Offset: 0x0037CAE5
			public ViewSMSSent ViewSMSSent
			{
				[DebuggerHidden]
				get
				{
					this.m_ViewSMSSent = MyProject.MyForms.Create__Instance__<ViewSMSSent>(this.m_ViewSMSSent);
					return this.m_ViewSMSSent;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_ViewSMSSent)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ViewSMSSent>(ref this.m_ViewSMSSent);
					}
				}
			}

			// Token: 0x17002438 RID: 9272
			// (get) Token: 0x06006340 RID: 25408 RVA: 0x0037CA6F File Offset: 0x0037AC6F
			// (set) Token: 0x060063F3 RID: 25587 RVA: 0x0037E911 File Offset: 0x0037CB11
			public WeightVerificationScale WeightVerificationScale
			{
				[DebuggerHidden]
				get
				{
					this.m_WeightVerificationScale = MyProject.MyForms.Create__Instance__<WeightVerificationScale>(this.m_WeightVerificationScale);
					return this.m_WeightVerificationScale;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_WeightVerificationScale)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<WeightVerificationScale>(ref this.m_WeightVerificationScale);
					}
				}
			}

			// Token: 0x17002439 RID: 9273
			// (get) Token: 0x06006341 RID: 25409 RVA: 0x0037CA8A File Offset: 0x0037AC8A
			// (set) Token: 0x060063F4 RID: 25588 RVA: 0x0037E93D File Offset: 0x0037CB3D
			public ZReport ZReport
			{
				[DebuggerHidden]
				get
				{
					this.m_ZReport = MyProject.MyForms.Create__Instance__<ZReport>(this.m_ZReport);
					return this.m_ZReport;
				}
				[DebuggerHidden]
				set
				{
					if (value != this.m_ZReport)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<ZReport>(ref this.m_ZReport);
					}
				}
			}

			// Token: 0x04002B8D RID: 11149
			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;

			// Token: 0x04002B8E RID: 11150
			[EditorBrowsable(EditorBrowsableState.Never)]
			public About m_About;

			// Token: 0x04002B8F RID: 11151
			[EditorBrowsable(EditorBrowsableState.Never)]
			public AC_SetRoles m_AC_SetRoles;

			// Token: 0x04002B90 RID: 11152
			[EditorBrowsable(EditorBrowsableState.Never)]
			public AC_UserPermissions m_AC_UserPermissions;

			// Token: 0x04002B91 RID: 11153
			[EditorBrowsable(EditorBrowsableState.Never)]
			public AccPayment m_AccPayment;

			// Token: 0x04002B92 RID: 11154
			[EditorBrowsable(EditorBrowsableState.Never)]
			public AdditionalSettings m_AdditionalSettings;

			// Token: 0x04002B93 RID: 11155
			[EditorBrowsable(EditorBrowsableState.Never)]
			public AddNewProdt m_AddNewProdt;

			// Token: 0x04002B94 RID: 11156
			[EditorBrowsable(EditorBrowsableState.Never)]
			public AddNewProdt2 m_AddNewProdt2;

			// Token: 0x04002B95 RID: 11157
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ApprovalForm m_ApprovalForm;

			// Token: 0x04002B96 RID: 11158
			[EditorBrowsable(EditorBrowsableState.Never)]
			public AuditPriceChanges m_AuditPriceChanges;

			// Token: 0x04002B97 RID: 11159
			[EditorBrowsable(EditorBrowsableState.Never)]
			public BackDateValue m_BackDateValue;

			// Token: 0x04002B98 RID: 11160
			[EditorBrowsable(EditorBrowsableState.Never)]
			public BackUpDB m_BackUpDB;

			// Token: 0x04002B99 RID: 11161
			[EditorBrowsable(EditorBrowsableState.Never)]
			public BarCodes m_BarCodes;

			// Token: 0x04002B9A RID: 11162
			[EditorBrowsable(EditorBrowsableState.Never)]
			public BatchSelect m_BatchSelect;

			// Token: 0x04002B9B RID: 11163
			[EditorBrowsable(EditorBrowsableState.Never)]
			public BillingEnterPaymentfrm m_BillingEnterPaymentfrm;

			// Token: 0x04002B9C RID: 11164
			[EditorBrowsable(EditorBrowsableState.Never)]
			public BillingTerms m_BillingTerms;

			// Token: 0x04002B9D RID: 11165
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Branches m_Branches;

			// Token: 0x04002B9E RID: 11166
			[EditorBrowsable(EditorBrowsableState.Never)]
			public BranchPrices m_BranchPrices;

			// Token: 0x04002B9F RID: 11167
			[EditorBrowsable(EditorBrowsableState.Never)]
			public BreakProduct m_BreakProduct;

			// Token: 0x04002BA0 RID: 11168
			[EditorBrowsable(EditorBrowsableState.Never)]
			public BulkStockEntry m_BulkStockEntry;

			// Token: 0x04002BA1 RID: 11169
			[EditorBrowsable(EditorBrowsableState.Never)]
			public CalcLxW m_CalcLxW;

			// Token: 0x04002BA2 RID: 11170
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Categories m_Categories;

			// Token: 0x04002BA3 RID: 11171
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ChangeExpiryDate m_ChangeExpiryDate;

			// Token: 0x04002BA4 RID: 11172
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ChangeProductSold m_ChangeProductSold;

			// Token: 0x04002BA5 RID: 11173
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ChangePwd m_ChangePwd;

			// Token: 0x04002BA6 RID: 11174
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ChangeUserPassword m_ChangeUserPassword;

			// Token: 0x04002BA7 RID: 11175
			[EditorBrowsable(EditorBrowsableState.Never)]
			public CheckBranchStock m_CheckBranchStock;

			// Token: 0x04002BA8 RID: 11176
			[EditorBrowsable(EditorBrowsableState.Never)]
			public CheckConnectedbranchStatus m_CheckConnectedbranchStatus;

			// Token: 0x04002BA9 RID: 11177
			[EditorBrowsable(EditorBrowsableState.Never)]
			public CheckSerialNumber m_CheckSerialNumber;

			// Token: 0x04002BAA RID: 11178
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Collections m_Collections;

			// Token: 0x04002BAB RID: 11179
			[EditorBrowsable(EditorBrowsableState.Never)]
			public CollectionsByCustomer m_CollectionsByCustomer;

			// Token: 0x04002BAC RID: 11180
			[EditorBrowsable(EditorBrowsableState.Never)]
			public CollectionsByCustomerReport m_CollectionsByCustomerReport;

			// Token: 0x04002BAD RID: 11181
			[EditorBrowsable(EditorBrowsableState.Never)]
			public CollectionsProductBalByCustomer m_CollectionsProductBalByCustomer;

			// Token: 0x04002BAE RID: 11182
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Company m_Company;

			// Token: 0x04002BAF RID: 11183
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ConfigureShifts m_ConfigureShifts;

			// Token: 0x04002BB0 RID: 11184
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ConsignmentReport m_ConsignmentReport;

			// Token: 0x04002BB1 RID: 11185
			[EditorBrowsable(EditorBrowsableState.Never)]
			public CreditNote2 m_CreditNote2;

			// Token: 0x04002BB2 RID: 11186
			[EditorBrowsable(EditorBrowsableState.Never)]
			public CreditNoteGetPro m_CreditNoteGetPro;

			// Token: 0x04002BB3 RID: 11187
			[EditorBrowsable(EditorBrowsableState.Never)]
			public CS_EODEnter m_CS_EODEnter;

			// Token: 0x04002BB4 RID: 11188
			[EditorBrowsable(EditorBrowsableState.Never)]
			public CustomerGroups m_CustomerGroups;

			// Token: 0x04002BB5 RID: 11189
			[EditorBrowsable(EditorBrowsableState.Never)]
			public DBConnections m_DBConnections;

			// Token: 0x04002BB6 RID: 11190
			[EditorBrowsable(EditorBrowsableState.Never)]
			public DeliveryNoteWarehouse m_DeliveryNoteWarehouse;

			// Token: 0x04002BB7 RID: 11191
			[EditorBrowsable(EditorBrowsableState.Never)]
			public DespatchNoteForm m_DespatchNoteForm;

			// Token: 0x04002BB8 RID: 11192
			[EditorBrowsable(EditorBrowsableState.Never)]
			public DespatchReprint m_DespatchReprint;

			// Token: 0x04002BB9 RID: 11193
			[EditorBrowsable(EditorBrowsableState.Never)]
			public DialogNumeric m_DialogNumeric;

			// Token: 0x04002BBA RID: 11194
			[EditorBrowsable(EditorBrowsableState.Never)]
			public DialogPayMethods m_DialogPayMethods;

			// Token: 0x04002BBB RID: 11195
			[EditorBrowsable(EditorBrowsableState.Never)]
			public EcocashDetails m_EcocashDetails;

			// Token: 0x04002BBC RID: 11196
			[EditorBrowsable(EditorBrowsableState.Never)]
			public EcocashReceipts m_EcocashReceipts;

			// Token: 0x04002BBD RID: 11197
			[EditorBrowsable(EditorBrowsableState.Never)]
			public EconetVoucherUpload m_EconetVoucherUpload;

			// Token: 0x04002BBE RID: 11198
			[EditorBrowsable(EditorBrowsableState.Never)]
			public EditBatchNumber m_EditBatchNumber;

			// Token: 0x04002BBF RID: 11199
			[EditorBrowsable(EditorBrowsableState.Never)]
			public EditBatchNumbers m_EditBatchNumbers;

			// Token: 0x04002BC0 RID: 11200
			[EditorBrowsable(EditorBrowsableState.Never)]
			public EditComment m_EditComment;

			// Token: 0x04002BC1 RID: 11201
			[EditorBrowsable(EditorBrowsableState.Never)]
			public EditProductCategory m_EditProductCategory;

			// Token: 0x04002BC2 RID: 11202
			[EditorBrowsable(EditorBrowsableState.Never)]
			public EditProducts m_EditProducts;

			// Token: 0x04002BC3 RID: 11203
			[EditorBrowsable(EditorBrowsableState.Never)]
			public EditProductSupplier m_EditProductSupplier;

			// Token: 0x04002BC4 RID: 11204
			[EditorBrowsable(EditorBrowsableState.Never)]
			public EditShiftDetail m_EditShiftDetail;

			// Token: 0x04002BC5 RID: 11205
			[EditorBrowsable(EditorBrowsableState.Never)]
			public eltratefiscaldevice m_eltratefiscaldevice;

			// Token: 0x04002BC6 RID: 11206
			[EditorBrowsable(EditorBrowsableState.Never)]
			public EmailReports m_EmailReports;

			// Token: 0x04002BC7 RID: 11207
			[EditorBrowsable(EditorBrowsableState.Never)]
			public EnterSerialNumbers m_EnterSerialNumbers;

			// Token: 0x04002BC8 RID: 11208
			[EditorBrowsable(EditorBrowsableState.Never)]
			public EODPrintOut m_EODPrintOut;

			// Token: 0x04002BC9 RID: 11209
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ExpensesCategories m_ExpensesCategories;

			// Token: 0x04002BCA RID: 11210
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ExtraCustomerDetails m_ExtraCustomerDetails;

			// Token: 0x04002BCB RID: 11211
			[EditorBrowsable(EditorBrowsableState.Never)]
			public FloatManagement m_FloatManagement;

			// Token: 0x04002BCC RID: 11212
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Form1 m_Form1;

			// Token: 0x04002BCD RID: 11213
			[EditorBrowsable(EditorBrowsableState.Never)]
			public FormulaReport m_FormulaReport;

			// Token: 0x04002BCE RID: 11214
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmAccStatement m_frmAccStatement;

			// Token: 0x04002BCF RID: 11215
			[EditorBrowsable(EditorBrowsableState.Never)]
			public FrmADF_SalesPurchases3 m_FrmADF_SalesPurchases3;

			// Token: 0x04002BD0 RID: 11216
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmConfirmAdminUser m_frmConfirmAdminUser;

			// Token: 0x04002BD1 RID: 11217
			[EditorBrowsable(EditorBrowsableState.Never)]
			public FRMSearchCustomer m_FRMSearchCustomer;

			// Token: 0x04002BD2 RID: 11218
			[EditorBrowsable(EditorBrowsableState.Never)]
			public frmStockExpiry m_frmStockExpiry;

			// Token: 0x04002BD3 RID: 11219
			[EditorBrowsable(EditorBrowsableState.Never)]
			public GeneralSettings m_GeneralSettings;

			// Token: 0x04002BD4 RID: 11220
			[EditorBrowsable(EditorBrowsableState.Never)]
			public GetNewBatchNumber m_GetNewBatchNumber;

			// Token: 0x04002BD5 RID: 11221
			[EditorBrowsable(EditorBrowsableState.Never)]
			public KDUs m_KDUs;

			// Token: 0x04002BD6 RID: 11222
			[EditorBrowsable(EditorBrowsableState.Never)]
			public KitchenDisplay m_KitchenDisplay;

			// Token: 0x04002BD7 RID: 11223
			[EditorBrowsable(EditorBrowsableState.Never)]
			public License m_License;

			// Token: 0x04002BD8 RID: 11224
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Logins m_Logins;

			// Token: 0x04002BD9 RID: 11225
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MainMenu m_MainMenu;

			// Token: 0x04002BDA RID: 11226
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Make_Product m_Make_Product;

			// Token: 0x04002BDB RID: 11227
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MenuCategories m_MenuCategories;

			// Token: 0x04002BDC RID: 11228
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MenuProducts m_MenuProducts;

			// Token: 0x04002BDD RID: 11229
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MultiPayMethods m_MultiPayMethods;

			// Token: 0x04002BDE RID: 11230
			[EditorBrowsable(EditorBrowsableState.Never)]
			public NegativeStockSetting m_NegativeStockSetting;

			// Token: 0x04002BDF RID: 11231
			[EditorBrowsable(EditorBrowsableState.Never)]
			public NewPrescription m_NewPrescription;

			// Token: 0x04002BE0 RID: 11232
			[EditorBrowsable(EditorBrowsableState.Never)]
			public NewProdt m_NewProdt;

			// Token: 0x04002BE1 RID: 11233
			[EditorBrowsable(EditorBrowsableState.Never)]
			public NewProdt2 m_NewProdt2;

			// Token: 0x04002BE2 RID: 11234
			[EditorBrowsable(EditorBrowsableState.Never)]
			public NewStock m_NewStock;

			// Token: 0x04002BE3 RID: 11235
			[EditorBrowsable(EditorBrowsableState.Never)]
			public NewStock2 m_NewStock2;

			// Token: 0x04002BE4 RID: 11236
			[EditorBrowsable(EditorBrowsableState.Never)]
			public NewStockUnits m_NewStockUnits;

			// Token: 0x04002BE5 RID: 11237
			[EditorBrowsable(EditorBrowsableState.Never)]
			public NewStockUnits2 m_NewStockUnits2;

			// Token: 0x04002BE6 RID: 11238
			[EditorBrowsable(EditorBrowsableState.Never)]
			public OtherProductDetail m_OtherProductDetail;

			// Token: 0x04002BE7 RID: 11239
			[EditorBrowsable(EditorBrowsableState.Never)]
			public PackSizeCreate m_PackSizeCreate;

			// Token: 0x04002BE8 RID: 11240
			[EditorBrowsable(EditorBrowsableState.Never)]
			public PasswordForm m_PasswordForm;

			// Token: 0x04002BE9 RID: 11241
			[EditorBrowsable(EditorBrowsableState.Never)]
			public PayDeposit m_PayDeposit;

			// Token: 0x04002BEA RID: 11242
			[EditorBrowsable(EditorBrowsableState.Never)]
			public PaymentMethods m_PaymentMethods;

			// Token: 0x04002BEB RID: 11243
			[EditorBrowsable(EditorBrowsableState.Never)]
			public PayMethRef m_PayMethRef;

			// Token: 0x04002BEC RID: 11244
			[EditorBrowsable(EditorBrowsableState.Never)]
			public PendingInvoices m_PendingInvoices;

			// Token: 0x04002BED RID: 11245
			[EditorBrowsable(EditorBrowsableState.Never)]
			public PriceChangesReport m_PriceChangesReport;

			// Token: 0x04002BEE RID: 11246
			[EditorBrowsable(EditorBrowsableState.Never)]
			public PriceChangesReport2 m_PriceChangesReport2;

			// Token: 0x04002BEF RID: 11247
			[EditorBrowsable(EditorBrowsableState.Never)]
			public PriceList m_PriceList;

			// Token: 0x04002BF0 RID: 11248
			[EditorBrowsable(EditorBrowsableState.Never)]
			public PriceMatrix m_PriceMatrix;

			// Token: 0x04002BF1 RID: 11249
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Printers m_Printers;

			// Token: 0x04002BF2 RID: 11250
			[EditorBrowsable(EditorBrowsableState.Never)]
			public PrintQuotation m_PrintQuotation;

			// Token: 0x04002BF3 RID: 11251
			[EditorBrowsable(EditorBrowsableState.Never)]
			public PrintReceiptOrInvoice m_PrintReceiptOrInvoice;

			// Token: 0x04002BF4 RID: 11252
			[EditorBrowsable(EditorBrowsableState.Never)]
			public PrintReceipts m_PrintReceipts;

			// Token: 0x04002BF5 RID: 11253
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ProductOrderComments m_ProductOrderComments;

			// Token: 0x04002BF6 RID: 11254
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ProductPics m_ProductPics;

			// Token: 0x04002BF7 RID: 11255
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ProductsCreditedReport m_ProductsCreditedReport;

			// Token: 0x04002BF8 RID: 11256
			[EditorBrowsable(EditorBrowsableState.Never)]
			public PromotionsView m_PromotionsView;

			// Token: 0x04002BF9 RID: 11257
			[EditorBrowsable(EditorBrowsableState.Never)]
			public PurchaseReturns m_PurchaseReturns;

			// Token: 0x04002BFA RID: 11258
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Quotation m_Quotation;

			// Token: 0x04002BFB RID: 11259
			[EditorBrowsable(EditorBrowsableState.Never)]
			public R_SalesReport m_R_SalesReport;

			// Token: 0x04002BFC RID: 11260
			[EditorBrowsable(EditorBrowsableState.Never)]
			public RefundCustomer m_RefundCustomer;

			// Token: 0x04002BFD RID: 11261
			[EditorBrowsable(EditorBrowsableState.Never)]
			public RepairsCheckIn m_RepairsCheckIn;

			// Token: 0x04002BFE RID: 11262
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ReparisCheckOut m_ReparisCheckOut;

			// Token: 0x04002BFF RID: 11263
			[EditorBrowsable(EditorBrowsableState.Never)]
			public RestrictUserCategories m_RestrictUserCategories;

			// Token: 0x04002C00 RID: 11264
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Returns m_Returns;

			// Token: 0x04002C01 RID: 11265
			[EditorBrowsable(EditorBrowsableState.Never)]
			public sales2TOUCH m_sales2TOUCH;

			// Token: 0x04002C02 RID: 11266
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SalesByInvoice m_SalesByInvoice;

			// Token: 0x04002C03 RID: 11267
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SalesInvoice m_SalesInvoice;

			// Token: 0x04002C04 RID: 11268
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SalesInvoicePortrait m_SalesInvoicePortrait;

			// Token: 0x04002C05 RID: 11269
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SalesInvoicePortraitBinum m_SalesInvoicePortraitBinum;

			// Token: 0x04002C06 RID: 11270
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SalesInvoicePortraitBooking m_SalesInvoicePortraitBooking;

			// Token: 0x04002C07 RID: 11271
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SalesInvoicePortraitCN m_SalesInvoicePortraitCN;

			// Token: 0x04002C08 RID: 11272
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SalesInvoicePortraitFarhan m_SalesInvoicePortraitFarhan;

			// Token: 0x04002C09 RID: 11273
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SalesInvoicePortraitFDMS m_SalesInvoicePortraitFDMS;

			// Token: 0x04002C0A RID: 11274
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SalesInvoicePortraitGetpro m_SalesInvoicePortraitGetpro;

			// Token: 0x04002C0B RID: 11275
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SalesInvoicePortraitInco m_SalesInvoicePortraitInco;

			// Token: 0x04002C0C RID: 11276
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SalesInvoicePortraitLea m_SalesInvoicePortraitLea;

			// Token: 0x04002C0D RID: 11277
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SalesInvoicePortraitPharma m_SalesInvoicePortraitPharma;

			// Token: 0x04002C0E RID: 11278
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SalesInvoicePortraitTongaat m_SalesInvoicePortraitTongaat;

			// Token: 0x04002C0F RID: 11279
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SalesInvoiceRevmax m_SalesInvoiceRevmax;

			// Token: 0x04002C10 RID: 11280
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SalesInvoiceWholesale m_SalesInvoiceWholesale;

			// Token: 0x04002C11 RID: 11281
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SalesInvPortraitBooking m_SalesInvPortraitBooking;

			// Token: 0x04002C12 RID: 11282
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SearchComments m_SearchComments;

			// Token: 0x04002C13 RID: 11283
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SecondSalesScreen m_SecondSalesScreen;

			// Token: 0x04002C14 RID: 11284
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SelectBranches m_SelectBranches;

			// Token: 0x04002C15 RID: 11285
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SelectCategories m_SelectCategories;

			// Token: 0x04002C16 RID: 11286
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SelectKDU m_SelectKDU;

			// Token: 0x04002C17 RID: 11287
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SelectMNO m_SelectMNO;

			// Token: 0x04002C18 RID: 11288
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SelectSerialNumbers m_SelectSerialNumbers;

			// Token: 0x04002C19 RID: 11289
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SelectTable m_SelectTable;

			// Token: 0x04002C1A RID: 11290
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SelectUserForm m_SelectUserForm;

			// Token: 0x04002C1B RID: 11291
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SendSmS m_SendSmS;

			// Token: 0x04002C1C RID: 11292
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SetCategorySideMenus m_SetCategorySideMenus;

			// Token: 0x04002C1D RID: 11293
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SetDiscountPercentage m_SetDiscountPercentage;

			// Token: 0x04002C1E RID: 11294
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SetHSCodes m_SetHSCodes;

			// Token: 0x04002C1F RID: 11295
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ShiftReportForm m_ShiftReportForm;

			// Token: 0x04002C20 RID: 11296
			[EditorBrowsable(EditorBrowsableState.Never)]
			public StockAdjustmentsReportCum m_StockAdjustmentsReportCum;

			// Token: 0x04002C21 RID: 11297
			[EditorBrowsable(EditorBrowsableState.Never)]
			public StockAging m_StockAging;

			// Token: 0x04002C22 RID: 11298
			[EditorBrowsable(EditorBrowsableState.Never)]
			public StockPurchasesforProduct m_StockPurchasesforProduct;

			// Token: 0x04002C23 RID: 11299
			[EditorBrowsable(EditorBrowsableState.Never)]
			public StockSheetsWarehouse m_StockSheetsWarehouse;

			// Token: 0x04002C24 RID: 11300
			[EditorBrowsable(EditorBrowsableState.Never)]
			public StockTake m_StockTake;

			// Token: 0x04002C25 RID: 11301
			[EditorBrowsable(EditorBrowsableState.Never)]
			public StockTake1Item m_StockTake1Item;

			// Token: 0x04002C26 RID: 11302
			[EditorBrowsable(EditorBrowsableState.Never)]
			public StockTakeCumulative m_StockTakeCumulative;

			// Token: 0x04002C27 RID: 11303
			[EditorBrowsable(EditorBrowsableState.Never)]
			public StockTakeExcel m_StockTakeExcel;

			// Token: 0x04002C28 RID: 11304
			[EditorBrowsable(EditorBrowsableState.Never)]
			public StockTakeWarehouse m_StockTakeWarehouse;

			// Token: 0x04002C29 RID: 11305
			[EditorBrowsable(EditorBrowsableState.Never)]
			public StockTransfersForPeriod m_StockTransfersForPeriod;

			// Token: 0x04002C2A RID: 11306
			[EditorBrowsable(EditorBrowsableState.Never)]
			public StockTransfersForPeriodFrom m_StockTransfersForPeriodFrom;

			// Token: 0x04002C2B RID: 11307
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SupervisorApproval m_SupervisorApproval;

			// Token: 0x04002C2C RID: 11308
			[EditorBrowsable(EditorBrowsableState.Never)]
			public SupplierAging m_SupplierAging;

			// Token: 0x04002C2D RID: 11309
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Suppliers m_Suppliers;

			// Token: 0x04002C2E RID: 11310
			[EditorBrowsable(EditorBrowsableState.Never)]
			public TellerDisbursements m_TellerDisbursements;

			// Token: 0x04002C2F RID: 11311
			[EditorBrowsable(EditorBrowsableState.Never)]
			public TestComport m_TestComport;

			// Token: 0x04002C30 RID: 11312
			[EditorBrowsable(EditorBrowsableState.Never)]
			public TestConnectedScale m_TestConnectedScale;

			// Token: 0x04002C31 RID: 11313
			[EditorBrowsable(EditorBrowsableState.Never)]
			public TIP m_TIP;

			// Token: 0x04002C32 RID: 11314
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Users m_Users;

			// Token: 0x04002C33 RID: 11315
			[EditorBrowsable(EditorBrowsableState.Never)]
			public VerifyOpenImpReports m_VerifyOpenImpReports;

			// Token: 0x04002C34 RID: 11316
			[EditorBrowsable(EditorBrowsableState.Never)]
			public Videos m_Videos;

			// Token: 0x04002C35 RID: 11317
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ViewBatchNumberChanges m_ViewBatchNumberChanges;

			// Token: 0x04002C36 RID: 11318
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ViewDebitNote m_ViewDebitNote;

			// Token: 0x04002C37 RID: 11319
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ViewInvoiceDetails m_ViewInvoiceDetails;

			// Token: 0x04002C38 RID: 11320
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ViewPricesAvailability m_ViewPricesAvailability;

			// Token: 0x04002C39 RID: 11321
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ViewProductCreditNotes m_ViewProductCreditNotes;

			// Token: 0x04002C3A RID: 11322
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ViewProducts m_ViewProducts;

			// Token: 0x04002C3B RID: 11323
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ViewProducts2 m_ViewProducts2;

			// Token: 0x04002C3C RID: 11324
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ViewPurchaseReturns m_ViewPurchaseReturns;

			// Token: 0x04002C3D RID: 11325
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ViewSelectedCategories m_ViewSelectedCategories;

			// Token: 0x04002C3E RID: 11326
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ViewSMSSent m_ViewSMSSent;

			// Token: 0x04002C3F RID: 11327
			[EditorBrowsable(EditorBrowsableState.Never)]
			public WeightVerificationScale m_WeightVerificationScale;

			// Token: 0x04002C40 RID: 11328
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ZReport m_ZReport;
		}

		// Token: 0x0200024D RID: 589
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		internal sealed class MyWebServices
		{
			// Token: 0x060063F5 RID: 25589 RVA: 0x0037E96C File Offset: 0x0037CB6C
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			// Token: 0x060063F6 RID: 25590 RVA: 0x0037E98C File Offset: 0x0037CB8C
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			// Token: 0x060063F7 RID: 25591 RVA: 0x0037E9A4 File Offset: 0x0037CBA4
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			internal new Type GetType()
			{
				return typeof(MyProject.MyWebServices);
			}

			// Token: 0x060063F8 RID: 25592 RVA: 0x0037E9C0 File Offset: 0x0037CBC0
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override string ToString()
			{
				return base.ToString();
			}

			// Token: 0x060063F9 RID: 25593 RVA: 0x0037E9D8 File Offset: 0x0037CBD8
			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance) where T : new()
			{
				bool flag = instance == null;
				T t;
				if (flag)
				{
					t = new T();
				}
				else
				{
					t = instance;
				}
				return t;
			}

			// Token: 0x060063FA RID: 25594 RVA: 0x0037EA01 File Offset: 0x0037CC01
			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			// Token: 0x060063FB RID: 25595 RVA: 0x0037B74B File Offset: 0x0037994B
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyWebServices()
			{
			}
		}

		// Token: 0x0200024E RID: 590
		[EditorBrowsable(EditorBrowsableState.Never)]
		[ComVisible(false)]
		internal sealed class ThreadSafeObjectProvider<T> where T : new()
		{
			// Token: 0x1700243A RID: 9274
			// (get) Token: 0x060063FC RID: 25596 RVA: 0x0037EA0C File Offset: 0x0037CC0C
			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					bool flag = MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null;
					if (flag)
					{
						MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = new T();
					}
					return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
				}
			}

			// Token: 0x060063FD RID: 25597 RVA: 0x0037B74B File Offset: 0x0037994B
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ThreadSafeObjectProvider()
			{
			}

			// Token: 0x04002C41 RID: 11329
			[CompilerGenerated]
			[ThreadStatic]
			private static T m_ThreadStaticValue;
		}
	}
}
