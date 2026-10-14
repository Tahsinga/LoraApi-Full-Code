using System;
using System.CodeDom.Compiler;
using System.Data;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace PointOfSale.QuantumPOSService
{
	// Token: 0x020001D9 RID: 473
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class ServiceClient : ClientBase<IService>, IService
	{
		// Token: 0x06005224 RID: 21028 RVA: 0x00301D59 File Offset: 0x002FFF59
		public ServiceClient()
		{
		}

		// Token: 0x06005225 RID: 21029 RVA: 0x00301D63 File Offset: 0x002FFF63
		public ServiceClient(string endpointConfigurationName)
			: base(endpointConfigurationName)
		{
		}

		// Token: 0x06005226 RID: 21030 RVA: 0x00301D6E File Offset: 0x002FFF6E
		public ServiceClient(string endpointConfigurationName, string remoteAddress)
			: base(endpointConfigurationName, remoteAddress)
		{
		}

		// Token: 0x06005227 RID: 21031 RVA: 0x00301D7A File Offset: 0x002FFF7A
		public ServiceClient(string endpointConfigurationName, EndpointAddress remoteAddress)
			: base(endpointConfigurationName, remoteAddress)
		{
		}

		// Token: 0x06005228 RID: 21032 RVA: 0x00301D86 File Offset: 0x002FFF86
		public ServiceClient(Binding binding, EndpointAddress remoteAddress)
			: base(binding, remoteAddress)
		{
		}

		// Token: 0x06005229 RID: 21033 RVA: 0x00301D94 File Offset: 0x002FFF94
		public ManuFormula D_ManuFormula(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_ManuFormula(uname, value, branch, coid);
		}

		// Token: 0x0600522A RID: 21034 RVA: 0x00301DB8 File Offset: 0x002FFFB8
		public Task<ManuFormula> D_ManuFormulaAsync(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_ManuFormulaAsync(uname, value, branch, coid);
		}

		// Token: 0x0600522B RID: 21035 RVA: 0x00301DDC File Offset: 0x002FFFDC
		public ManuIngridients D_ManuIng(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_ManuIng(uname, value, branch, coid);
		}

		// Token: 0x0600522C RID: 21036 RVA: 0x00301E00 File Offset: 0x00300000
		public Task<ManuIngridients> D_ManuIngAsync(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_ManuIngAsync(uname, value, branch, coid);
		}

		// Token: 0x0600522D RID: 21037 RVA: 0x00301E24 File Offset: 0x00300024
		public Users D_users(string uname, string value, string downloadingbranch, int coid, Guid new_guid)
		{
			return base.Channel.D_users(uname, value, downloadingbranch, coid, new_guid);
		}

		// Token: 0x0600522E RID: 21038 RVA: 0x00301E48 File Offset: 0x00300048
		public Task<Users> D_usersAsync(string uname, string value, string downloadingbranch, int coid, Guid new_guid)
		{
			return base.Channel.D_usersAsync(uname, value, downloadingbranch, coid, new_guid);
		}

		// Token: 0x0600522F RID: 21039 RVA: 0x00301E6C File Offset: 0x0030006C
		public ExpenseCat D_ExpenseCat(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_ExpenseCat(uname, value, branch, coid);
		}

		// Token: 0x06005230 RID: 21040 RVA: 0x00301E90 File Offset: 0x00300090
		public Task<ExpenseCat> D_ExpenseCatAsync(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_ExpenseCatAsync(uname, value, branch, coid);
		}

		// Token: 0x06005231 RID: 21041 RVA: 0x00301EB4 File Offset: 0x003000B4
		public CusDetails D_CustomerDetails(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_CustomerDetails(uname, value, branch, coid);
		}

		// Token: 0x06005232 RID: 21042 RVA: 0x00301ED8 File Offset: 0x003000D8
		public Task<CusDetails> D_CustomerDetailsAsync(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_CustomerDetailsAsync(uname, value, branch, coid);
		}

		// Token: 0x06005233 RID: 21043 RVA: 0x00301EFC File Offset: 0x003000FC
		public BillingTerms D_BillingTerms(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_BillingTerms(uname, value, branch, coid);
		}

		// Token: 0x06005234 RID: 21044 RVA: 0x00301F20 File Offset: 0x00300120
		public Task<BillingTerms> D_BillingTermsAsync(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_BillingTermsAsync(uname, value, branch, coid);
		}

		// Token: 0x06005235 RID: 21045 RVA: 0x00301F44 File Offset: 0x00300144
		public BillingLog D_BillingLog(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_BillingLog(uname, value, branch, coid);
		}

		// Token: 0x06005236 RID: 21046 RVA: 0x00301F68 File Offset: 0x00300168
		public Task<BillingLog> D_BillingLogAsync(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_BillingLogAsync(uname, value, branch, coid);
		}

		// Token: 0x06005237 RID: 21047 RVA: 0x00301F8C File Offset: 0x0030018C
		public bool D_MvtData_Confirm(string uname, string value, string branch, int coid, string brservername, DateTime brdownloadtime)
		{
			return base.Channel.D_MvtData_Confirm(uname, value, branch, coid, brservername, brdownloadtime);
		}

		// Token: 0x06005238 RID: 21048 RVA: 0x00301FB4 File Offset: 0x003001B4
		public Task<bool> D_MvtData_ConfirmAsync(string uname, string value, string branch, int coid, string brservername, DateTime brdownloadtime)
		{
			return base.Channel.D_MvtData_ConfirmAsync(uname, value, branch, coid, brservername, brdownloadtime);
		}

		// Token: 0x06005239 RID: 21049 RVA: 0x00301FDC File Offset: 0x003001DC
		public bool D_MvtData_Confirm2(string uname, string value, string branch, int coid, string brservername, string brdownloadtime, int isbranch)
		{
			return base.Channel.D_MvtData_Confirm2(uname, value, branch, coid, brservername, brdownloadtime, isbranch);
		}

		// Token: 0x0600523A RID: 21050 RVA: 0x00302004 File Offset: 0x00300204
		public Task<bool> D_MvtData_Confirm2Async(string uname, string value, string branch, int coid, string brservername, string brdownloadtime, int isbranch)
		{
			return base.Channel.D_MvtData_Confirm2Async(uname, value, branch, coid, brservername, brdownloadtime, isbranch);
		}

		// Token: 0x0600523B RID: 21051 RVA: 0x0030202C File Offset: 0x0030022C
		public bool D_Cats2_Confirm(string uname, string value, string branch, int coid, string brservername, string brdownloadtime)
		{
			return base.Channel.D_Cats2_Confirm(uname, value, branch, coid, brservername, brdownloadtime);
		}

		// Token: 0x0600523C RID: 21052 RVA: 0x00302054 File Offset: 0x00300254
		public Task<bool> D_Cats2_ConfirmAsync(string uname, string value, string branch, int coid, string brservername, string brdownloadtime)
		{
			return base.Channel.D_Cats2_ConfirmAsync(uname, value, branch, coid, brservername, brdownloadtime);
		}

		// Token: 0x0600523D RID: 21053 RVA: 0x0030207C File Offset: 0x0030027C
		public bool D_PaymethActual2_Confirm(string uname, string value, string branch, int coid, string brservername, DateTime brdownloadtime)
		{
			return base.Channel.D_PaymethActual2_Confirm(uname, value, branch, coid, brservername, brdownloadtime);
		}

		// Token: 0x0600523E RID: 21054 RVA: 0x003020A4 File Offset: 0x003002A4
		public Task<bool> D_PaymethActual2_ConfirmAsync(string uname, string value, string branch, int coid, string brservername, DateTime brdownloadtime)
		{
			return base.Channel.D_PaymethActual2_ConfirmAsync(uname, value, branch, coid, brservername, brdownloadtime);
		}

		// Token: 0x0600523F RID: 21055 RVA: 0x003020CC File Offset: 0x003002CC
		public bool D_Paymeths_Confirm(string uname, string value, string branch, int coid, string brservername, Guid brdownloadtime)
		{
			return base.Channel.D_Paymeths_Confirm(uname, value, branch, coid, brservername, brdownloadtime);
		}

		// Token: 0x06005240 RID: 21056 RVA: 0x003020F4 File Offset: 0x003002F4
		public Task<bool> D_Paymeths_ConfirmAsync(string uname, string value, string branch, int coid, string brservername, Guid brdownloadtime)
		{
			return base.Channel.D_Paymeths_ConfirmAsync(uname, value, branch, coid, brservername, brdownloadtime);
		}

		// Token: 0x06005241 RID: 21057 RVA: 0x0030211C File Offset: 0x0030031C
		public bool D_Paymethactual_Confirm(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_Paymethactual_Confirm(uname, value, branch, coid);
		}

		// Token: 0x06005242 RID: 21058 RVA: 0x00302140 File Offset: 0x00300340
		public Task<bool> D_Paymethactual_ConfirmAsync(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_Paymethactual_ConfirmAsync(uname, value, branch, coid);
		}

		// Token: 0x06005243 RID: 21059 RVA: 0x00302164 File Offset: 0x00300364
		public bool D_BranchPrices_Confirm(string uname, string value, string branch, int coid, int theentryno)
		{
			return base.Channel.D_BranchPrices_Confirm(uname, value, branch, coid, theentryno);
		}

		// Token: 0x06005244 RID: 21060 RVA: 0x00302188 File Offset: 0x00300388
		public Task<bool> D_BranchPrices_ConfirmAsync(string uname, string value, string branch, int coid, int theentryno)
		{
			return base.Channel.D_BranchPrices_ConfirmAsync(uname, value, branch, coid, theentryno);
		}

		// Token: 0x06005245 RID: 21061 RVA: 0x003021AC File Offset: 0x003003AC
		public bool D_BranchProductDetails_Confirm(string uname, string value, string branch, int coid, int theentryno)
		{
			return base.Channel.D_BranchProductDetails_Confirm(uname, value, branch, coid, theentryno);
		}

		// Token: 0x06005246 RID: 21062 RVA: 0x003021D0 File Offset: 0x003003D0
		public Task<bool> D_BranchProductDetails_ConfirmAsync(string uname, string value, string branch, int coid, int theentryno)
		{
			return base.Channel.D_BranchProductDetails_ConfirmAsync(uname, value, branch, coid, theentryno);
		}

		// Token: 0x06005247 RID: 21063 RVA: 0x003021F4 File Offset: 0x003003F4
		public bool D_CustomerDetails_Confirm(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_CustomerDetails_Confirm(uname, value, branch, coid);
		}

		// Token: 0x06005248 RID: 21064 RVA: 0x00302218 File Offset: 0x00300418
		public Task<bool> D_CustomerDetails_ConfirmAsync(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_CustomerDetails_ConfirmAsync(uname, value, branch, coid);
		}

		// Token: 0x06005249 RID: 21065 RVA: 0x0030223C File Offset: 0x0030043C
		public bool D_BillingLog_Confirm(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_BillingLog_Confirm(uname, value, branch, coid);
		}

		// Token: 0x0600524A RID: 21066 RVA: 0x00302260 File Offset: 0x00300460
		public Task<bool> D_BillingLog_ConfirmAsync(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_BillingLog_ConfirmAsync(uname, value, branch, coid);
		}

		// Token: 0x0600524B RID: 21067 RVA: 0x00302284 File Offset: 0x00300484
		public bool D_users_Confirm(string uname, string value, string downloadingbranch, int coid, Guid brguid, string brservername)
		{
			return base.Channel.D_users_Confirm(uname, value, downloadingbranch, coid, brguid, brservername);
		}

		// Token: 0x0600524C RID: 21068 RVA: 0x003022AC File Offset: 0x003004AC
		public Task<bool> D_users_ConfirmAsync(string uname, string value, string downloadingbranch, int coid, Guid brguid, string brservername)
		{
			return base.Channel.D_users_ConfirmAsync(uname, value, downloadingbranch, coid, brguid, brservername);
		}

		// Token: 0x0600524D RID: 21069 RVA: 0x003022D4 File Offset: 0x003004D4
		public bool FetchProducts_Confirm(string uname, string value, string branch, int coid, DateTime hquploadtime)
		{
			return base.Channel.FetchProducts_Confirm(uname, value, branch, coid, hquploadtime);
		}

		// Token: 0x0600524E RID: 21070 RVA: 0x003022F8 File Offset: 0x003004F8
		public Task<bool> FetchProducts_ConfirmAsync(string uname, string value, string branch, int coid, DateTime hquploadtime)
		{
			return base.Channel.FetchProducts_ConfirmAsync(uname, value, branch, coid, hquploadtime);
		}

		// Token: 0x0600524F RID: 21071 RVA: 0x0030231C File Offset: 0x0030051C
		public bool D_Cats_Confirm(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_Cats_Confirm(uname, value, branch, coid);
		}

		// Token: 0x06005250 RID: 21072 RVA: 0x00302340 File Offset: 0x00300540
		public Task<bool> D_Cats_ConfirmAsync(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_Cats_ConfirmAsync(uname, value, branch, coid);
		}

		// Token: 0x06005251 RID: 21073 RVA: 0x00302364 File Offset: 0x00300564
		public bool D_PayMeths_Coonfirm(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_PayMeths_Coonfirm(uname, value, branch, coid);
		}

		// Token: 0x06005252 RID: 21074 RVA: 0x00302388 File Offset: 0x00300588
		public Task<bool> D_PayMeths_CoonfirmAsync(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_PayMeths_CoonfirmAsync(uname, value, branch, coid);
		}

		// Token: 0x06005253 RID: 21075 RVA: 0x003023AC File Offset: 0x003005AC
		public bool D_ExpenseCat_Confirm(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_ExpenseCat_Confirm(uname, value, branch, coid);
		}

		// Token: 0x06005254 RID: 21076 RVA: 0x003023D0 File Offset: 0x003005D0
		public Task<bool> D_ExpenseCat_ConfirmAsync(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_ExpenseCat_ConfirmAsync(uname, value, branch, coid);
		}

		// Token: 0x06005255 RID: 21077 RVA: 0x003023F4 File Offset: 0x003005F4
		public bool D_ManuFormulas_Confirm(string uname, string value, string branch, int coid, string brservername, string brdownloadtime)
		{
			return base.Channel.D_ManuFormulas_Confirm(uname, value, branch, coid, brservername, brdownloadtime);
		}

		// Token: 0x06005256 RID: 21078 RVA: 0x0030241C File Offset: 0x0030061C
		public Task<bool> D_ManuFormulas_ConfirmAsync(string uname, string value, string branch, int coid, string brservername, string brdownloadtime)
		{
			return base.Channel.D_ManuFormulas_ConfirmAsync(uname, value, branch, coid, brservername, brdownloadtime);
		}

		// Token: 0x06005257 RID: 21079 RVA: 0x00302444 File Offset: 0x00300644
		public bool D_ManuIng_Confirm(string uname, string value, string branch, int coid, string brservername, string brdownloadtime)
		{
			return base.Channel.D_ManuIng_Confirm(uname, value, branch, coid, brservername, brdownloadtime);
		}

		// Token: 0x06005258 RID: 21080 RVA: 0x0030246C File Offset: 0x0030066C
		public Task<bool> D_ManuIng_ConfirmAsync(string uname, string value, string branch, int coid, string brservername, string brdownloadtime)
		{
			return base.Channel.D_ManuIng_ConfirmAsync(uname, value, branch, coid, brservername, brdownloadtime);
		}

		// Token: 0x06005259 RID: 21081 RVA: 0x00302494 File Offset: 0x00300694
		public bool D_BillingTerms_Confirm(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_BillingTerms_Confirm(uname, value, branch, coid);
		}

		// Token: 0x0600525A RID: 21082 RVA: 0x003024B8 File Offset: 0x003006B8
		public Task<bool> D_BillingTerms_ConfirmAsync(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_BillingTerms_ConfirmAsync(uname, value, branch, coid);
		}

		// Token: 0x0600525B RID: 21083 RVA: 0x003024DC File Offset: 0x003006DC
		public bool UpdateLog(string uname, string value, string branch, int coid, DateTime lastseen)
		{
			return base.Channel.UpdateLog(uname, value, branch, coid, lastseen);
		}

		// Token: 0x0600525C RID: 21084 RVA: 0x00302500 File Offset: 0x00300700
		public Task<bool> UpdateLogAsync(string uname, string value, string branch, int coid, DateTime lastseen)
		{
			return base.Channel.UpdateLogAsync(uname, value, branch, coid, lastseen);
		}

		// Token: 0x0600525D RID: 21085 RVA: 0x00302524 File Offset: 0x00300724
		public string UploadManuFormulas(string uname, string value, int coid, string branch, int productid, string formulaname, string comments, string doneby, int donedate, int uploaded, int entryno, int backofficeproductiononly, string hqservername, string hquploadtime)
		{
			return base.Channel.UploadManuFormulas(uname, value, coid, branch, productid, formulaname, comments, doneby, donedate, uploaded, entryno, backofficeproductiononly, hqservername, hquploadtime);
		}

		// Token: 0x0600525E RID: 21086 RVA: 0x0030255C File Offset: 0x0030075C
		public Task<string> UploadManuFormulasAsync(string uname, string value, int coid, string branch, int productid, string formulaname, string comments, string doneby, int donedate, int uploaded, int entryno, int backofficeproductiononly, string hqservername, string hquploadtime)
		{
			return base.Channel.UploadManuFormulasAsync(uname, value, coid, branch, productid, formulaname, comments, doneby, donedate, uploaded, entryno, backofficeproductiononly, hqservername, hquploadtime);
		}

		// Token: 0x0600525F RID: 21087 RVA: 0x00302594 File Offset: 0x00300794
		public string UploadManuIng(string uname, string value, int coid, string branch, int entryno, string formulaname, int productid, decimal qty, string doneby, int donedate, int uploaded, string hqservername, string hquploadtime)
		{
			return base.Channel.UploadManuIng(uname, value, coid, branch, entryno, formulaname, productid, qty, doneby, donedate, uploaded, hqservername, hquploadtime);
		}

		// Token: 0x06005260 RID: 21088 RVA: 0x003025C8 File Offset: 0x003007C8
		public Task<string> UploadManuIngAsync(string uname, string value, int coid, string branch, int entryno, string formulaname, int productid, decimal qty, string doneby, int donedate, int uploaded, string hqservername, string hquploadtime)
		{
			return base.Channel.UploadManuIngAsync(uname, value, coid, branch, entryno, formulaname, productid, qty, doneby, donedate, uploaded, hqservername, hquploadtime);
		}

		// Token: 0x06005261 RID: 21089 RVA: 0x003025FC File Offset: 0x003007FC
		public ManuFormulas D_ManuFormulas(string uname, string value, string branch, int coid, string brservername, string brdownloadtime)
		{
			return base.Channel.D_ManuFormulas(uname, value, branch, coid, brservername, brdownloadtime);
		}

		// Token: 0x06005262 RID: 21090 RVA: 0x00302624 File Offset: 0x00300824
		public Task<ManuFormulas> D_ManuFormulasAsync(string uname, string value, string branch, int coid, string brservername, string brdownloadtime)
		{
			return base.Channel.D_ManuFormulasAsync(uname, value, branch, coid, brservername, brdownloadtime);
		}

		// Token: 0x06005263 RID: 21091 RVA: 0x0030264C File Offset: 0x0030084C
		public ManuIng D_ManuIngs(string uname, string value, string branch, int coid, string brservername, string brdownloadtime)
		{
			return base.Channel.D_ManuIngs(uname, value, branch, coid, brservername, brdownloadtime);
		}

		// Token: 0x06005264 RID: 21092 RVA: 0x00302674 File Offset: 0x00300874
		public Task<ManuIng> D_ManuIngsAsync(string uname, string value, string branch, int coid, string brservername, string brdownloadtime)
		{
			return base.Channel.D_ManuIngsAsync(uname, value, branch, coid, brservername, brdownloadtime);
		}

		// Token: 0x06005265 RID: 21093 RVA: 0x0030269C File Offset: 0x0030089C
		public bool GetData(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, decimal qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt)
		{
			return base.Channel.GetData(uname, value, entryno, invnum, trandate, prodid, isstockin, @ref, qty, cost, sellingprice, doneby, donewhen, paymeth, trancode, datecancelled, cancelledby, prodcode, trandesc, uploaded, trantime, coid, branch, taxamt);
		}

		// Token: 0x06005266 RID: 21094 RVA: 0x003026E8 File Offset: 0x003008E8
		public Task<bool> GetDataAsync(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, decimal qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt)
		{
			return base.Channel.GetDataAsync(uname, value, entryno, invnum, trandate, prodid, isstockin, @ref, qty, cost, sellingprice, doneby, donewhen, paymeth, trancode, datecancelled, cancelledby, prodcode, trandesc, uploaded, trantime, coid, branch, taxamt);
		}

		// Token: 0x06005267 RID: 21095 RVA: 0x00302734 File Offset: 0x00300934
		public string GetData3(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, decimal qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, int uploade2, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty, string Suppliername, string saletype, int usereceiptdisplay, int receiptdisplaymethod, int receiptdisplayrate, decimal discountamt, string consultant, string collection, decimal invdiscount, string discountdesc, int collected, decimal collectedqty, string collecteddate, string collectedby, string collectionEnteredBy, string collectionmachinename, int collectioncompleted, string collectioncompleteddate, string collectioncompletedenteredby, string hqservername, DateTime hquploadtime)
		{
			return base.Channel.GetData3(uname, value, entryno, invnum, trandate, prodid, isstockin, @ref, qty, cost, sellingprice, doneby, donewhen, paymeth, trancode, datecancelled, cancelledby, prodcode, trandesc, uploaded, trantime, coid, branch, taxamt, shift, shiftdate, uploade2, otherdetail, batchnumber, expirydate, iswholesaleprice, iswholesalepriceqty, Suppliername, saletype, usereceiptdisplay, receiptdisplaymethod, receiptdisplayrate, discountamt, consultant, collection, invdiscount, discountdesc, collected, collectedqty, collecteddate, collectedby, collectionEnteredBy, collectionmachinename, collectioncompleted, collectioncompleteddate, collectioncompletedenteredby, hqservername, hquploadtime);
		}

		// Token: 0x06005268 RID: 21096 RVA: 0x003027B8 File Offset: 0x003009B8
		public Task<string> GetData3Async(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, decimal qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, int uploade2, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty, string Suppliername, string saletype, int usereceiptdisplay, int receiptdisplaymethod, int receiptdisplayrate, decimal discountamt, string consultant, string collection, decimal invdiscount, string discountdesc, int collected, decimal collectedqty, string collecteddate, string collectedby, string collectionEnteredBy, string collectionmachinename, int collectioncompleted, string collectioncompleteddate, string collectioncompletedenteredby, string hqservername, DateTime hquploadtime)
		{
			return base.Channel.GetData3Async(uname, value, entryno, invnum, trandate, prodid, isstockin, @ref, qty, cost, sellingprice, doneby, donewhen, paymeth, trancode, datecancelled, cancelledby, prodcode, trandesc, uploaded, trantime, coid, branch, taxamt, shift, shiftdate, uploade2, otherdetail, batchnumber, expirydate, iswholesaleprice, iswholesalepriceqty, Suppliername, saletype, usereceiptdisplay, receiptdisplaymethod, receiptdisplayrate, discountamt, consultant, collection, invdiscount, discountdesc, collected, collectedqty, collecteddate, collectedby, collectionEnteredBy, collectionmachinename, collectioncompleted, collectioncompleteddate, collectioncompletedenteredby, hqservername, hquploadtime);
		}

		// Token: 0x06005269 RID: 21097 RVA: 0x0030283C File Offset: 0x00300A3C
		public string GetData4(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, decimal qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, int uploade2, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty, string Suppliername, string saletype, int usereceiptdisplay, int receiptdisplaymethod, decimal receiptdisplayrate, decimal discountamt, string consultant, string collection, decimal invdiscount, string discountdesc, int collected, decimal collectedqty, string collecteddate, string collectedby, string collectionEnteredBy, string collectionmachinename, int collectioncompleted, string collectioncompleteddate, string collectioncompletedenteredby, string hqservername, DateTime hquploadtime)
		{
			return base.Channel.GetData4(uname, value, entryno, invnum, trandate, prodid, isstockin, @ref, qty, cost, sellingprice, doneby, donewhen, paymeth, trancode, datecancelled, cancelledby, prodcode, trandesc, uploaded, trantime, coid, branch, taxamt, shift, shiftdate, uploade2, otherdetail, batchnumber, expirydate, iswholesaleprice, iswholesalepriceqty, Suppliername, saletype, usereceiptdisplay, receiptdisplaymethod, receiptdisplayrate, discountamt, consultant, collection, invdiscount, discountdesc, collected, collectedqty, collecteddate, collectedby, collectionEnteredBy, collectionmachinename, collectioncompleted, collectioncompleteddate, collectioncompletedenteredby, hqservername, hquploadtime);
		}

		// Token: 0x0600526A RID: 21098 RVA: 0x003028C0 File Offset: 0x00300AC0
		public Task<string> GetData4Async(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, decimal qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, int uploade2, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty, string Suppliername, string saletype, int usereceiptdisplay, int receiptdisplaymethod, decimal receiptdisplayrate, decimal discountamt, string consultant, string collection, decimal invdiscount, string discountdesc, int collected, decimal collectedqty, string collecteddate, string collectedby, string collectionEnteredBy, string collectionmachinename, int collectioncompleted, string collectioncompleteddate, string collectioncompletedenteredby, string hqservername, DateTime hquploadtime)
		{
			return base.Channel.GetData4Async(uname, value, entryno, invnum, trandate, prodid, isstockin, @ref, qty, cost, sellingprice, doneby, donewhen, paymeth, trancode, datecancelled, cancelledby, prodcode, trandesc, uploaded, trantime, coid, branch, taxamt, shift, shiftdate, uploade2, otherdetail, batchnumber, expirydate, iswholesaleprice, iswholesalepriceqty, Suppliername, saletype, usereceiptdisplay, receiptdisplaymethod, receiptdisplayrate, discountamt, consultant, collection, invdiscount, discountdesc, collected, collectedqty, collecteddate, collectedby, collectionEnteredBy, collectionmachinename, collectioncompleted, collectioncompleteddate, collectioncompletedenteredby, hqservername, hquploadtime);
		}

		// Token: 0x0600526B RID: 21099 RVA: 0x00302944 File Offset: 0x00300B44
		public string GetData5(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, decimal qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, int uploade2, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty, string Suppliername, string saletype, int usereceiptdisplay, int receiptdisplaymethod, decimal receiptdisplayrate, decimal discountamt, string consultant, string collection, decimal invdiscount, string discountdesc, int collected, decimal collectedqty, string collecteddate, string collectedby, string collectionEnteredBy, string collectionmachinename, int collectioncompleted, string collectioncompleteddate, string collectioncompletedenteredby, string hqservername, DateTime hquploadtime, string comments)
		{
			return base.Channel.GetData5(uname, value, entryno, invnum, trandate, prodid, isstockin, @ref, qty, cost, sellingprice, doneby, donewhen, paymeth, trancode, datecancelled, cancelledby, prodcode, trandesc, uploaded, trantime, coid, branch, taxamt, shift, shiftdate, uploade2, otherdetail, batchnumber, expirydate, iswholesaleprice, iswholesalepriceqty, Suppliername, saletype, usereceiptdisplay, receiptdisplaymethod, receiptdisplayrate, discountamt, consultant, collection, invdiscount, discountdesc, collected, collectedqty, collecteddate, collectedby, collectionEnteredBy, collectionmachinename, collectioncompleted, collectioncompleteddate, collectioncompletedenteredby, hqservername, hquploadtime, comments);
		}

		// Token: 0x0600526C RID: 21100 RVA: 0x003029CC File Offset: 0x00300BCC
		public Task<string> GetData5Async(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, decimal qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, int uploade2, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty, string Suppliername, string saletype, int usereceiptdisplay, int receiptdisplaymethod, decimal receiptdisplayrate, decimal discountamt, string consultant, string collection, decimal invdiscount, string discountdesc, int collected, decimal collectedqty, string collecteddate, string collectedby, string collectionEnteredBy, string collectionmachinename, int collectioncompleted, string collectioncompleteddate, string collectioncompletedenteredby, string hqservername, DateTime hquploadtime, string comments)
		{
			return base.Channel.GetData5Async(uname, value, entryno, invnum, trandate, prodid, isstockin, @ref, qty, cost, sellingprice, doneby, donewhen, paymeth, trancode, datecancelled, cancelledby, prodcode, trandesc, uploaded, trantime, coid, branch, taxamt, shift, shiftdate, uploade2, otherdetail, batchnumber, expirydate, iswholesaleprice, iswholesalepriceqty, Suppliername, saletype, usereceiptdisplay, receiptdisplaymethod, receiptdisplayrate, discountamt, consultant, collection, invdiscount, discountdesc, collected, collectedqty, collecteddate, collectedby, collectionEnteredBy, collectionmachinename, collectioncompleted, collectioncompleteddate, collectioncompletedenteredby, hqservername, hquploadtime, comments);
		}

		// Token: 0x0600526D RID: 21101 RVA: 0x00302A54 File Offset: 0x00300C54
		public string GetData6(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, decimal qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, int uploade2, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty, string Suppliername, string saletype, int usereceiptdisplay, int receiptdisplaymethod, decimal receiptdisplayrate, decimal discountamt, string consultant, string collection, decimal invdiscount, string discountdesc, int collected, decimal collectedqty, string collecteddate, string collectedby, string collectionEnteredBy, string collectionmachinename, int collectioncompleted, string collectioncompleteddate, string collectioncompletedenteredby, string hqservername, DateTime hquploadtime, string comments, bool isbranch)
		{
			return base.Channel.GetData6(uname, value, entryno, invnum, trandate, prodid, isstockin, @ref, qty, cost, sellingprice, doneby, donewhen, paymeth, trancode, datecancelled, cancelledby, prodcode, trandesc, uploaded, trantime, coid, branch, taxamt, shift, shiftdate, uploade2, otherdetail, batchnumber, expirydate, iswholesaleprice, iswholesalepriceqty, Suppliername, saletype, usereceiptdisplay, receiptdisplaymethod, receiptdisplayrate, discountamt, consultant, collection, invdiscount, discountdesc, collected, collectedqty, collecteddate, collectedby, collectionEnteredBy, collectionmachinename, collectioncompleted, collectioncompleteddate, collectioncompletedenteredby, hqservername, hquploadtime, comments, isbranch);
		}

		// Token: 0x0600526E RID: 21102 RVA: 0x00302ADC File Offset: 0x00300CDC
		public Task<string> GetData6Async(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, decimal qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, int uploade2, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty, string Suppliername, string saletype, int usereceiptdisplay, int receiptdisplaymethod, decimal receiptdisplayrate, decimal discountamt, string consultant, string collection, decimal invdiscount, string discountdesc, int collected, decimal collectedqty, string collecteddate, string collectedby, string collectionEnteredBy, string collectionmachinename, int collectioncompleted, string collectioncompleteddate, string collectioncompletedenteredby, string hqservername, DateTime hquploadtime, string comments, bool isbranch)
		{
			return base.Channel.GetData6Async(uname, value, entryno, invnum, trandate, prodid, isstockin, @ref, qty, cost, sellingprice, doneby, donewhen, paymeth, trancode, datecancelled, cancelledby, prodcode, trandesc, uploaded, trantime, coid, branch, taxamt, shift, shiftdate, uploade2, otherdetail, batchnumber, expirydate, iswholesaleprice, iswholesalepriceqty, Suppliername, saletype, usereceiptdisplay, receiptdisplaymethod, receiptdisplayrate, discountamt, consultant, collection, invdiscount, discountdesc, collected, collectedqty, collecteddate, collectedby, collectionEnteredBy, collectionmachinename, collectioncompleted, collectioncompleteddate, collectioncompletedenteredby, hqservername, hquploadtime, comments, isbranch);
		}

		// Token: 0x0600526F RID: 21103 RVA: 0x00302B64 File Offset: 0x00300D64
		public string GetData7(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, decimal qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, int uploade2, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty, string Suppliername, string saletype, int usereceiptdisplay, int receiptdisplaymethod, decimal receiptdisplayrate, decimal discountamt, string consultant, string collection, decimal invdiscount, string discountdesc, int collected, decimal collectedqty, string collecteddate, string collectedby, string collectionEnteredBy, string collectionmachinename, int collectioncompleted, string collectioncompleteddate, string collectioncompletedenteredby, string hqservername, DateTime hquploadtime, string comments, bool isbranch)
		{
			return base.Channel.GetData7(uname, value, entryno, invnum, trandate, prodid, isstockin, @ref, qty, cost, sellingprice, doneby, donewhen, paymeth, trancode, datecancelled, cancelledby, prodcode, trandesc, uploaded, trantime, coid, branch, taxamt, shift, shiftdate, uploade2, otherdetail, batchnumber, expirydate, iswholesaleprice, iswholesalepriceqty, Suppliername, saletype, usereceiptdisplay, receiptdisplaymethod, receiptdisplayrate, discountamt, consultant, collection, invdiscount, discountdesc, collected, collectedqty, collecteddate, collectedby, collectionEnteredBy, collectionmachinename, collectioncompleted, collectioncompleteddate, collectioncompletedenteredby, hqservername, hquploadtime, comments, isbranch);
		}

		// Token: 0x06005270 RID: 21104 RVA: 0x00302BEC File Offset: 0x00300DEC
		public Task<string> GetData7Async(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, decimal qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, int uploade2, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty, string Suppliername, string saletype, int usereceiptdisplay, int receiptdisplaymethod, decimal receiptdisplayrate, decimal discountamt, string consultant, string collection, decimal invdiscount, string discountdesc, int collected, decimal collectedqty, string collecteddate, string collectedby, string collectionEnteredBy, string collectionmachinename, int collectioncompleted, string collectioncompleteddate, string collectioncompletedenteredby, string hqservername, DateTime hquploadtime, string comments, bool isbranch)
		{
			return base.Channel.GetData7Async(uname, value, entryno, invnum, trandate, prodid, isstockin, @ref, qty, cost, sellingprice, doneby, donewhen, paymeth, trancode, datecancelled, cancelledby, prodcode, trandesc, uploaded, trantime, coid, branch, taxamt, shift, shiftdate, uploade2, otherdetail, batchnumber, expirydate, iswholesaleprice, iswholesalepriceqty, Suppliername, saletype, usereceiptdisplay, receiptdisplaymethod, receiptdisplayrate, discountamt, consultant, collection, invdiscount, discountdesc, collected, collectedqty, collecteddate, collectedby, collectionEnteredBy, collectionmachinename, collectioncompleted, collectioncompleteddate, collectioncompletedenteredby, hqservername, hquploadtime, comments, isbranch);
		}

		// Token: 0x06005271 RID: 21105 RVA: 0x00302C74 File Offset: 0x00300E74
		public string GetData8(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, decimal qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, int uploade2, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty, string Suppliername, string saletype, int usereceiptdisplay, int receiptdisplaymethod, decimal receiptdisplayrate, decimal discountamt, string consultant, string collection, decimal invdiscount, string discountdesc, int collected, decimal collectedqty, string collecteddate, string collectedby, string collectionEnteredBy, string collectionmachinename, int collectioncompleted, string collectioncompleteddate, string collectioncompletedenteredby, string hqservername, DateTime hquploadtime, string comments, bool isbranch, string source_servername)
		{
			return base.Channel.GetData8(uname, value, entryno, invnum, trandate, prodid, isstockin, @ref, qty, cost, sellingprice, doneby, donewhen, paymeth, trancode, datecancelled, cancelledby, prodcode, trandesc, uploaded, trantime, coid, branch, taxamt, shift, shiftdate, uploade2, otherdetail, batchnumber, expirydate, iswholesaleprice, iswholesalepriceqty, Suppliername, saletype, usereceiptdisplay, receiptdisplaymethod, receiptdisplayrate, discountamt, consultant, collection, invdiscount, discountdesc, collected, collectedqty, collecteddate, collectedby, collectionEnteredBy, collectionmachinename, collectioncompleted, collectioncompleteddate, collectioncompletedenteredby, hqservername, hquploadtime, comments, isbranch, source_servername);
		}

		// Token: 0x06005272 RID: 21106 RVA: 0x00302D00 File Offset: 0x00300F00
		public Task<string> GetData8Async(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, decimal qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, int uploade2, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty, string Suppliername, string saletype, int usereceiptdisplay, int receiptdisplaymethod, decimal receiptdisplayrate, decimal discountamt, string consultant, string collection, decimal invdiscount, string discountdesc, int collected, decimal collectedqty, string collecteddate, string collectedby, string collectionEnteredBy, string collectionmachinename, int collectioncompleted, string collectioncompleteddate, string collectioncompletedenteredby, string hqservername, DateTime hquploadtime, string comments, bool isbranch, string source_servername)
		{
			return base.Channel.GetData8Async(uname, value, entryno, invnum, trandate, prodid, isstockin, @ref, qty, cost, sellingprice, doneby, donewhen, paymeth, trancode, datecancelled, cancelledby, prodcode, trandesc, uploaded, trantime, coid, branch, taxamt, shift, shiftdate, uploade2, otherdetail, batchnumber, expirydate, iswholesaleprice, iswholesalepriceqty, Suppliername, saletype, usereceiptdisplay, receiptdisplaymethod, receiptdisplayrate, discountamt, consultant, collection, invdiscount, discountdesc, collected, collectedqty, collecteddate, collectedby, collectionEnteredBy, collectionmachinename, collectioncompleted, collectioncompleteddate, collectioncompletedenteredby, hqservername, hquploadtime, comments, isbranch, source_servername);
		}

		// Token: 0x06005273 RID: 21107 RVA: 0x00302D8C File Offset: 0x00300F8C
		public string GetData9(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, decimal qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, int uploade2, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty, string Suppliername, string saletype, int usereceiptdisplay, int receiptdisplaymethod, decimal receiptdisplayrate, decimal discountamt, string consultant, string collection, decimal invdiscount, string discountdesc, int collected, decimal collectedqty, string collecteddate, string collectedby, string collectionEnteredBy, string collectionmachinename, int collectioncompleted, string collectioncompleteddate, string collectioncompletedenteredby, string hqservername, DateTime hquploadtime, string comments, bool isbranch, string source_servername, int isdownloadedtran, int downloaded_trans_entryno)
		{
			return base.Channel.GetData9(uname, value, entryno, invnum, trandate, prodid, isstockin, @ref, qty, cost, sellingprice, doneby, donewhen, paymeth, trancode, datecancelled, cancelledby, prodcode, trandesc, uploaded, trantime, coid, branch, taxamt, shift, shiftdate, uploade2, otherdetail, batchnumber, expirydate, iswholesaleprice, iswholesalepriceqty, Suppliername, saletype, usereceiptdisplay, receiptdisplaymethod, receiptdisplayrate, discountamt, consultant, collection, invdiscount, discountdesc, collected, collectedqty, collecteddate, collectedby, collectionEnteredBy, collectionmachinename, collectioncompleted, collectioncompleteddate, collectioncompletedenteredby, hqservername, hquploadtime, comments, isbranch, source_servername, isdownloadedtran, downloaded_trans_entryno);
		}

		// Token: 0x06005274 RID: 21108 RVA: 0x00302E1C File Offset: 0x0030101C
		public Task<string> GetData9Async(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, decimal qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, int uploade2, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty, string Suppliername, string saletype, int usereceiptdisplay, int receiptdisplaymethod, decimal receiptdisplayrate, decimal discountamt, string consultant, string collection, decimal invdiscount, string discountdesc, int collected, decimal collectedqty, string collecteddate, string collectedby, string collectionEnteredBy, string collectionmachinename, int collectioncompleted, string collectioncompleteddate, string collectioncompletedenteredby, string hqservername, DateTime hquploadtime, string comments, bool isbranch, string source_servername, int isdownloadedtran, int downloaded_trans_entryno)
		{
			return base.Channel.GetData9Async(uname, value, entryno, invnum, trandate, prodid, isstockin, @ref, qty, cost, sellingprice, doneby, donewhen, paymeth, trancode, datecancelled, cancelledby, prodcode, trandesc, uploaded, trantime, coid, branch, taxamt, shift, shiftdate, uploade2, otherdetail, batchnumber, expirydate, iswholesaleprice, iswholesalepriceqty, Suppliername, saletype, usereceiptdisplay, receiptdisplaymethod, receiptdisplayrate, discountamt, consultant, collection, invdiscount, discountdesc, collected, collectedqty, collecteddate, collectedby, collectionEnteredBy, collectionmachinename, collectioncompleted, collectioncompleteddate, collectioncompletedenteredby, hqservername, hquploadtime, comments, isbranch, source_servername, isdownloadedtran, downloaded_trans_entryno);
		}

		// Token: 0x06005275 RID: 21109 RVA: 0x00302EAC File Offset: 0x003010AC
		public int D_BranchProductDetails_Count(string uname, string value, int coid, string branch)
		{
			return base.Channel.D_BranchProductDetails_Count(uname, value, coid, branch);
		}

		// Token: 0x06005276 RID: 21110 RVA: 0x00302ED0 File Offset: 0x003010D0
		public Task<int> D_BranchProductDetails_CountAsync(string uname, string value, int coid, string branch)
		{
			return base.Channel.D_BranchProductDetails_CountAsync(uname, value, coid, branch);
		}

		// Token: 0x06005277 RID: 21111 RVA: 0x00302EF4 File Offset: 0x003010F4
		public int D_MvtDataCount(string uname, string value, string branch, int coid, string brservername)
		{
			return base.Channel.D_MvtDataCount(uname, value, branch, coid, brservername);
		}

		// Token: 0x06005278 RID: 21112 RVA: 0x00302F18 File Offset: 0x00301118
		public Task<int> D_MvtDataCountAsync(string uname, string value, string branch, int coid, string brservername)
		{
			return base.Channel.D_MvtDataCountAsync(uname, value, branch, coid, brservername);
		}

		// Token: 0x06005279 RID: 21113 RVA: 0x00302F3C File Offset: 0x0030113C
		public CompositeType GetDataUsingDataContract(CompositeType composite)
		{
			return base.Channel.GetDataUsingDataContract(composite);
		}

		// Token: 0x0600527A RID: 21114 RVA: 0x00302F5C File Offset: 0x0030115C
		public Task<CompositeType> GetDataUsingDataContractAsync(CompositeType composite)
		{
			return base.Channel.GetDataUsingDataContractAsync(composite);
		}

		// Token: 0x0600527B RID: 21115 RVA: 0x00302F7C File Offset: 0x0030117C
		public bool LogUpload(string uname, string value, int trandate, int trantime, int numtrans, bool completed, int coid, string branch)
		{
			return base.Channel.LogUpload(uname, value, trandate, trantime, numtrans, completed, coid, branch);
		}

		// Token: 0x0600527C RID: 21116 RVA: 0x00302FA8 File Offset: 0x003011A8
		public Task<bool> LogUploadAsync(string uname, string value, int trandate, int trantime, int numtrans, bool completed, int coid, string branch)
		{
			return base.Channel.LogUploadAsync(uname, value, trandate, trantime, numtrans, completed, coid, branch);
		}

		// Token: 0x0600527D RID: 21117 RVA: 0x00302FD4 File Offset: 0x003011D4
		public CompositeType LogUploadUsingDataContract(CompositeType composite)
		{
			return base.Channel.LogUploadUsingDataContract(composite);
		}

		// Token: 0x0600527E RID: 21118 RVA: 0x00302FF4 File Offset: 0x003011F4
		public Task<CompositeType> LogUploadUsingDataContractAsync(CompositeType composite)
		{
			return base.Channel.LogUploadUsingDataContractAsync(composite);
		}

		// Token: 0x0600527F RID: 21119 RVA: 0x00303014 File Offset: 0x00301214
		public bool UpdateData(int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, int qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt)
		{
			return base.Channel.UpdateData(entryno, invnum, trandate, prodid, isstockin, @ref, qty, cost, sellingprice, doneby, donewhen, paymeth, trancode, datecancelled, cancelledby, prodcode, trandesc, uploaded, trantime, coid, branch, taxamt);
		}

		// Token: 0x06005280 RID: 21120 RVA: 0x0030305C File Offset: 0x0030125C
		public Task<bool> UpdateDataAsync(int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, int qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt)
		{
			return base.Channel.UpdateDataAsync(entryno, invnum, trandate, prodid, isstockin, @ref, qty, cost, sellingprice, doneby, donewhen, paymeth, trancode, datecancelled, cancelledby, prodcode, trandesc, uploaded, trantime, coid, branch, taxamt);
		}

		// Token: 0x06005281 RID: 21121 RVA: 0x003030A4 File Offset: 0x003012A4
		public CompositeType UpdateDataDataContract(CompositeType composite)
		{
			return base.Channel.UpdateDataDataContract(composite);
		}

		// Token: 0x06005282 RID: 21122 RVA: 0x003030C4 File Offset: 0x003012C4
		public Task<CompositeType> UpdateDataDataContractAsync(CompositeType composite)
		{
			return base.Channel.UpdateDataDataContractAsync(composite);
		}

		// Token: 0x06005283 RID: 21123 RVA: 0x003030E4 File Offset: 0x003012E4
		public string GetProdts1(string uname, string value, int productid, int catid, string productdesc, double cost, double sellingprice, int unitsperpack, int reorderlevel, string doneby, string donewhen, string productcode, string barcode, int uploaded, int coid, double taxrate, string UOM)
		{
			return base.Channel.GetProdts1(uname, value, productid, catid, productdesc, cost, sellingprice, unitsperpack, reorderlevel, doneby, donewhen, productcode, barcode, uploaded, coid, taxrate, UOM);
		}

		// Token: 0x06005284 RID: 21124 RVA: 0x00303120 File Offset: 0x00301320
		public Task<string> GetProdts1Async(string uname, string value, int productid, int catid, string productdesc, double cost, double sellingprice, int unitsperpack, int reorderlevel, string doneby, string donewhen, string productcode, string barcode, int uploaded, int coid, double taxrate, string UOM)
		{
			return base.Channel.GetProdts1Async(uname, value, productid, catid, productdesc, cost, sellingprice, unitsperpack, reorderlevel, doneby, donewhen, productcode, barcode, uploaded, coid, taxrate, UOM);
		}

		// Token: 0x06005285 RID: 21125 RVA: 0x0030315C File Offset: 0x0030135C
		public string GetProdts2(string uname, string value, int productid, int catid, string productdesc, double cost, double sellingprice, int unitsperpack, int reorderlevel, string doneby, string donewhen, string productcode, string barcode, int uploaded, int coid, double taxrate, string UOM, decimal sellingpricewholesae, decimal wholesaleqty, int imported, string binlocation, int isactive, string productdesc2, decimal specialprice, int productexpires, int differentpricesperbranch, int isingridientonly, int pharmacydistributioncatgory, int pharmacyisperscription, int isunlimitedstockitem, int trans_entryno)
		{
			return base.Channel.GetProdts2(uname, value, productid, catid, productdesc, cost, sellingprice, unitsperpack, reorderlevel, doneby, donewhen, productcode, barcode, uploaded, coid, taxrate, UOM, sellingpricewholesae, wholesaleqty, imported, binlocation, isactive, productdesc2, specialprice, productexpires, differentpricesperbranch, isingridientonly, pharmacydistributioncatgory, pharmacyisperscription, isunlimitedstockitem, trans_entryno);
		}

		// Token: 0x06005286 RID: 21126 RVA: 0x003031B4 File Offset: 0x003013B4
		public Task<string> GetProdts2Async(string uname, string value, int productid, int catid, string productdesc, double cost, double sellingprice, int unitsperpack, int reorderlevel, string doneby, string donewhen, string productcode, string barcode, int uploaded, int coid, double taxrate, string UOM, decimal sellingpricewholesae, decimal wholesaleqty, int imported, string binlocation, int isactive, string productdesc2, decimal specialprice, int productexpires, int differentpricesperbranch, int isingridientonly, int pharmacydistributioncatgory, int pharmacyisperscription, int isunlimitedstockitem, int trans_entryno)
		{
			return base.Channel.GetProdts2Async(uname, value, productid, catid, productdesc, cost, sellingprice, unitsperpack, reorderlevel, doneby, donewhen, productcode, barcode, uploaded, coid, taxrate, UOM, sellingpricewholesae, wholesaleqty, imported, binlocation, isactive, productdesc2, specialprice, productexpires, differentpricesperbranch, isingridientonly, pharmacydistributioncatgory, pharmacyisperscription, isunlimitedstockitem, trans_entryno);
		}

		// Token: 0x06005287 RID: 21127 RVA: 0x0030320C File Offset: 0x0030140C
		public string GetProductBranchDetails(string uname, string value, int productid, int catid, string productdesc, double cost, double sellingprice, int unitsperpack, int reorderlevel, string doneby, string donewhen, string productcode, string barcode, int uploaded, int coid, double taxrate, string UOM, decimal sellingpricewholesae, decimal wholesaleqty, int imported, string binlocation, int isactive, string productdesc2, decimal specialprice, int productexpires, int differentpricesperbranch, int isingridientonly, int pharmacydistributioncatgory, int pharmacyisperscription, int isunlimitedstockitem, string branch)
		{
			return base.Channel.GetProductBranchDetails(uname, value, productid, catid, productdesc, cost, sellingprice, unitsperpack, reorderlevel, doneby, donewhen, productcode, barcode, uploaded, coid, taxrate, UOM, sellingpricewholesae, wholesaleqty, imported, binlocation, isactive, productdesc2, specialprice, productexpires, differentpricesperbranch, isingridientonly, pharmacydistributioncatgory, pharmacyisperscription, isunlimitedstockitem, branch);
		}

		// Token: 0x06005288 RID: 21128 RVA: 0x00303264 File Offset: 0x00301464
		public Task<string> GetProductBranchDetailsAsync(string uname, string value, int productid, int catid, string productdesc, double cost, double sellingprice, int unitsperpack, int reorderlevel, string doneby, string donewhen, string productcode, string barcode, int uploaded, int coid, double taxrate, string UOM, decimal sellingpricewholesae, decimal wholesaleqty, int imported, string binlocation, int isactive, string productdesc2, decimal specialprice, int productexpires, int differentpricesperbranch, int isingridientonly, int pharmacydistributioncatgory, int pharmacyisperscription, int isunlimitedstockitem, string branch)
		{
			return base.Channel.GetProductBranchDetailsAsync(uname, value, productid, catid, productdesc, cost, sellingprice, unitsperpack, reorderlevel, doneby, donewhen, productcode, barcode, uploaded, coid, taxrate, UOM, sellingpricewholesae, wholesaleqty, imported, binlocation, isactive, productdesc2, specialprice, productexpires, differentpricesperbranch, isingridientonly, pharmacydistributioncatgory, pharmacyisperscription, isunlimitedstockitem, branch);
		}

		// Token: 0x06005289 RID: 21129 RVA: 0x003032BC File Offset: 0x003014BC
		public string UpdateProdts(string uname, string value, int productid, int catid, string productdesc, double cost, double sellingprice, int unitsperpack, int reorderlevel, string doneby, string donewhen, string productcode, string barcode, int uploaded, int coid, double taxrate)
		{
			return base.Channel.UpdateProdts(uname, value, productid, catid, productdesc, cost, sellingprice, unitsperpack, reorderlevel, doneby, donewhen, productcode, barcode, uploaded, coid, taxrate);
		}

		// Token: 0x0600528A RID: 21130 RVA: 0x003032F8 File Offset: 0x003014F8
		public Task<string> UpdateProdtsAsync(string uname, string value, int productid, int catid, string productdesc, double cost, double sellingprice, int unitsperpack, int reorderlevel, string doneby, string donewhen, string productcode, string barcode, int uploaded, int coid, double taxrate)
		{
			return base.Channel.UpdateProdtsAsync(uname, value, productid, catid, productdesc, cost, sellingprice, unitsperpack, reorderlevel, doneby, donewhen, productcode, barcode, uploaded, coid, taxrate);
		}

		// Token: 0x0600528B RID: 21131 RVA: 0x00303334 File Offset: 0x00301534
		public bool GetExpenses(string uname, string value, int ExpenseDate, string Description, double Cost, int entryno, int uploaded, int coid, string branch)
		{
			return base.Channel.GetExpenses(uname, value, ExpenseDate, Description, Cost, entryno, uploaded, coid, branch);
		}

		// Token: 0x0600528C RID: 21132 RVA: 0x00303360 File Offset: 0x00301560
		public Task<bool> GetExpensesAsync(string uname, string value, int ExpenseDate, string Description, double Cost, int entryno, int uploaded, int coid, string branch)
		{
			return base.Channel.GetExpensesAsync(uname, value, ExpenseDate, Description, Cost, entryno, uploaded, coid, branch);
		}

		// Token: 0x0600528D RID: 21133 RVA: 0x0030338C File Offset: 0x0030158C
		public bool GetExpenses2(string uname, string value, int ExpenseDate, string Description, double Cost, int entryno, int uploaded, int coid, string branch, decimal rate, int paymentmethodid, int expensecategoryid, int fromtill, string tilloperator)
		{
			return base.Channel.GetExpenses2(uname, value, ExpenseDate, Description, Cost, entryno, uploaded, coid, branch, rate, paymentmethodid, expensecategoryid, fromtill, tilloperator);
		}

		// Token: 0x0600528E RID: 21134 RVA: 0x003033C4 File Offset: 0x003015C4
		public Task<bool> GetExpenses2Async(string uname, string value, int ExpenseDate, string Description, double Cost, int entryno, int uploaded, int coid, string branch, decimal rate, int paymentmethodid, int expensecategoryid, int fromtill, string tilloperator)
		{
			return base.Channel.GetExpenses2Async(uname, value, ExpenseDate, Description, Cost, entryno, uploaded, coid, branch, rate, paymentmethodid, expensecategoryid, fromtill, tilloperator);
		}

		// Token: 0x0600528F RID: 21135 RVA: 0x003033FC File Offset: 0x003015FC
		public bool UpdateExpenses(string uname, string value, int ExpenseDate, string Description, double Cost, int entryno, int uploaded, int coid, string branch)
		{
			return base.Channel.UpdateExpenses(uname, value, ExpenseDate, Description, Cost, entryno, uploaded, coid, branch);
		}

		// Token: 0x06005290 RID: 21136 RVA: 0x00303428 File Offset: 0x00301628
		public Task<bool> UpdateExpensesAsync(string uname, string value, int ExpenseDate, string Description, double Cost, int entryno, int uploaded, int coid, string branch)
		{
			return base.Channel.UpdateExpensesAsync(uname, value, ExpenseDate, Description, Cost, entryno, uploaded, coid, branch);
		}

		// Token: 0x06005291 RID: 21137 RVA: 0x00303454 File Offset: 0x00301654
		public bool GetCat1(string uname, string value, int CatID, string Description, int uploaded, int coid)
		{
			return base.Channel.GetCat1(uname, value, CatID, Description, uploaded, coid);
		}

		// Token: 0x06005292 RID: 21138 RVA: 0x0030347C File Offset: 0x0030167C
		public Task<bool> GetCat1Async(string uname, string value, int CatID, string Description, int uploaded, int coid)
		{
			return base.Channel.GetCat1Async(uname, value, CatID, Description, uploaded, coid);
		}

		// Token: 0x06005293 RID: 21139 RVA: 0x003034A4 File Offset: 0x003016A4
		public string GetCat2(string uname, string value, int CatID, string Description, int uploaded, int coid, int trans_entryno)
		{
			return base.Channel.GetCat2(uname, value, CatID, Description, uploaded, coid, trans_entryno);
		}

		// Token: 0x06005294 RID: 21140 RVA: 0x003034CC File Offset: 0x003016CC
		public Task<string> GetCat2Async(string uname, string value, int CatID, string Description, int uploaded, int coid, int trans_entryno)
		{
			return base.Channel.GetCat2Async(uname, value, CatID, Description, uploaded, coid, trans_entryno);
		}

		// Token: 0x06005295 RID: 21141 RVA: 0x003034F4 File Offset: 0x003016F4
		public string GetCat3(string uname, string value, int CatID, string Description, int uploaded, int coid, string branch, string hqservername)
		{
			return base.Channel.GetCat3(uname, value, CatID, Description, uploaded, coid, branch, hqservername);
		}

		// Token: 0x06005296 RID: 21142 RVA: 0x00303520 File Offset: 0x00301720
		public Task<string> GetCat3Async(string uname, string value, int CatID, string Description, int uploaded, int coid, string branch, string hqservername)
		{
			return base.Channel.GetCat3Async(uname, value, CatID, Description, uploaded, coid, branch, hqservername);
		}

		// Token: 0x06005297 RID: 21143 RVA: 0x0030354C File Offset: 0x0030174C
		public bool UpdateCat(string uname, string value, int CatID, string Description, int uploaded, int coid)
		{
			return base.Channel.UpdateCat(uname, value, CatID, Description, uploaded, coid);
		}

		// Token: 0x06005298 RID: 21144 RVA: 0x00303574 File Offset: 0x00301774
		public Task<bool> UpdateCatAsync(string uname, string value, int CatID, string Description, int uploaded, int coid)
		{
			return base.Channel.UpdateCatAsync(uname, value, CatID, Description, uploaded, coid);
		}

		// Token: 0x06005299 RID: 21145 RVA: 0x0030359C File Offset: 0x0030179C
		public bool GetCo(string uname, string value, string company, string Address, string tel, int entryno, string BranchName, int CompanyID, int uploaded, int coid, string branch)
		{
			return base.Channel.GetCo(uname, value, company, Address, tel, entryno, BranchName, CompanyID, uploaded, coid, branch);
		}

		// Token: 0x0600529A RID: 21146 RVA: 0x003035CC File Offset: 0x003017CC
		public Task<bool> GetCoAsync(string uname, string value, string company, string Address, string tel, int entryno, string BranchName, int CompanyID, int uploaded, int coid, string branch)
		{
			return base.Channel.GetCoAsync(uname, value, company, Address, tel, entryno, BranchName, CompanyID, uploaded, coid, branch);
		}

		// Token: 0x0600529B RID: 21147 RVA: 0x003035FC File Offset: 0x003017FC
		public bool UpdateCo(string uname, string value, string company, string Address, string tel, int entryno, string BranchName, int CompanyID, int uploaded, int coid, string branch)
		{
			return base.Channel.UpdateCo(uname, value, company, Address, tel, entryno, BranchName, CompanyID, uploaded, coid, branch);
		}

		// Token: 0x0600529C RID: 21148 RVA: 0x0030362C File Offset: 0x0030182C
		public Task<bool> UpdateCoAsync(string uname, string value, string company, string Address, string tel, int entryno, string BranchName, int CompanyID, int uploaded, int coid, string branch)
		{
			return base.Channel.UpdateCoAsync(uname, value, company, Address, tel, entryno, BranchName, CompanyID, uploaded, coid, branch);
		}

		// Token: 0x0600529D RID: 21149 RVA: 0x0030365C File Offset: 0x0030185C
		public bool GetCus(string uname, string value, string CustomerName, string Address, string ContactName, string Mobile, string Email, int Uploaded, int Entryno, int coid, string branch)
		{
			return base.Channel.GetCus(uname, value, CustomerName, Address, ContactName, Mobile, Email, Uploaded, Entryno, coid, branch);
		}

		// Token: 0x0600529E RID: 21150 RVA: 0x0030368C File Offset: 0x0030188C
		public Task<bool> GetCusAsync(string uname, string value, string CustomerName, string Address, string ContactName, string Mobile, string Email, int Uploaded, int Entryno, int coid, string branch)
		{
			return base.Channel.GetCusAsync(uname, value, CustomerName, Address, ContactName, Mobile, Email, Uploaded, Entryno, coid, branch);
		}

		// Token: 0x0600529F RID: 21151 RVA: 0x003036BC File Offset: 0x003018BC
		public bool GetCus2(string uname, string value, string CustomerName, string Address, string ContactName, string Mobile, string Email, int Uploaded, int Entryno, int coid, string branch, string invoicedetails1, string invoicedetails2, int tel, string idnumber, DateTime dob, string sex, DateTime datecreated, string createdby)
		{
			return base.Channel.GetCus2(uname, value, CustomerName, Address, ContactName, Mobile, Email, Uploaded, Entryno, coid, branch, invoicedetails1, invoicedetails2, tel, idnumber, dob, sex, datecreated, createdby);
		}

		// Token: 0x060052A0 RID: 21152 RVA: 0x003036FC File Offset: 0x003018FC
		public Task<bool> GetCus2Async(string uname, string value, string CustomerName, string Address, string ContactName, string Mobile, string Email, int Uploaded, int Entryno, int coid, string branch, string invoicedetails1, string invoicedetails2, int tel, string idnumber, DateTime dob, string sex, DateTime datecreated, string createdby)
		{
			return base.Channel.GetCus2Async(uname, value, CustomerName, Address, ContactName, Mobile, Email, Uploaded, Entryno, coid, branch, invoicedetails1, invoicedetails2, tel, idnumber, dob, sex, datecreated, createdby);
		}

		// Token: 0x060052A1 RID: 21153 RVA: 0x0030373C File Offset: 0x0030193C
		public bool UpdateCus(string uname, string value, string CustomerName, string Address, string ContactName, string Mobile, string Email, int Uploaded, int Entryno, int coid, string branch)
		{
			return base.Channel.UpdateCus(uname, value, CustomerName, Address, ContactName, Mobile, Email, Uploaded, Entryno, coid, branch);
		}

		// Token: 0x060052A2 RID: 21154 RVA: 0x0030376C File Offset: 0x0030196C
		public Task<bool> UpdateCusAsync(string uname, string value, string CustomerName, string Address, string ContactName, string Mobile, string Email, int Uploaded, int Entryno, int coid, string branch)
		{
			return base.Channel.UpdateCusAsync(uname, value, CustomerName, Address, ContactName, Mobile, Email, Uploaded, Entryno, coid, branch);
		}

		// Token: 0x060052A3 RID: 21155 RVA: 0x0030379C File Offset: 0x0030199C
		public bool GetPay1(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, int uploaded, int coid)
		{
			return base.Channel.GetPay1(uname, value, PaymentMethodID, PaymentMethodDesc, uploaded, coid);
		}

		// Token: 0x060052A4 RID: 21156 RVA: 0x003037C4 File Offset: 0x003019C4
		public Task<bool> GetPay1Async(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, int uploaded, int coid)
		{
			return base.Channel.GetPay1Async(uname, value, PaymentMethodID, PaymentMethodDesc, uploaded, coid);
		}

		// Token: 0x060052A5 RID: 21157 RVA: 0x003037EC File Offset: 0x003019EC
		public string GetPay2(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int uploaded, int coid, int fiscalgroup, string currency, decimal discountperc, int trans_entryno)
		{
			return base.Channel.GetPay2(uname, value, PaymentMethodID, PaymentMethodDesc, rate, uploaded, coid, fiscalgroup, currency, discountperc, trans_entryno);
		}

		// Token: 0x060052A6 RID: 21158 RVA: 0x0030381C File Offset: 0x00301A1C
		public Task<string> GetPay2Async(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int uploaded, int coid, int fiscalgroup, string currency, decimal discountperc, int trans_entryno)
		{
			return base.Channel.GetPay2Async(uname, value, PaymentMethodID, PaymentMethodDesc, rate, uploaded, coid, fiscalgroup, currency, discountperc, trans_entryno);
		}

		// Token: 0x060052A7 RID: 21159 RVA: 0x0030384C File Offset: 0x00301A4C
		public string GetPay3(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int uploaded, int coid, int fiscalgroup, string currency, decimal discountperc, int trans_entryno, string branch, string hqservername)
		{
			return base.Channel.GetPay3(uname, value, PaymentMethodID, PaymentMethodDesc, rate, uploaded, coid, fiscalgroup, currency, discountperc, trans_entryno, branch, hqservername);
		}

		// Token: 0x060052A8 RID: 21160 RVA: 0x00303880 File Offset: 0x00301A80
		public Task<string> GetPay3Async(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int uploaded, int coid, int fiscalgroup, string currency, decimal discountperc, int trans_entryno, string branch, string hqservername)
		{
			return base.Channel.GetPay3Async(uname, value, PaymentMethodID, PaymentMethodDesc, rate, uploaded, coid, fiscalgroup, currency, discountperc, trans_entryno, branch, hqservername);
		}

		// Token: 0x060052A9 RID: 21161 RVA: 0x003038B4 File Offset: 0x00301AB4
		public string GetPay4(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int uploaded, int coid, int fiscalgroup, string currency, decimal discountperc, int trans_entryno, string branch, string hqservername, int currencyideltrate)
		{
			return base.Channel.GetPay4(uname, value, PaymentMethodID, PaymentMethodDesc, rate, uploaded, coid, fiscalgroup, currency, discountperc, trans_entryno, branch, hqservername, currencyideltrate);
		}

		// Token: 0x060052AA RID: 21162 RVA: 0x003038EC File Offset: 0x00301AEC
		public Task<string> GetPay4Async(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int uploaded, int coid, int fiscalgroup, string currency, decimal discountperc, int trans_entryno, string branch, string hqservername, int currencyideltrate)
		{
			return base.Channel.GetPay4Async(uname, value, PaymentMethodID, PaymentMethodDesc, rate, uploaded, coid, fiscalgroup, currency, discountperc, trans_entryno, branch, hqservername, currencyideltrate);
		}

		// Token: 0x060052AB RID: 21163 RVA: 0x00303924 File Offset: 0x00301B24
		public bool UpdatePay(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, int uploaded, int coid)
		{
			return base.Channel.UpdatePay(uname, value, PaymentMethodID, PaymentMethodDesc, uploaded, coid);
		}

		// Token: 0x060052AC RID: 21164 RVA: 0x0030394C File Offset: 0x00301B4C
		public Task<bool> UpdatePayAsync(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, int uploaded, int coid)
		{
			return base.Channel.UpdatePayAsync(uname, value, PaymentMethodID, PaymentMethodDesc, uploaded, coid);
		}

		// Token: 0x060052AD RID: 21165 RVA: 0x00303974 File Offset: 0x00301B74
		public bool GetPayActual(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, int InvoiceNumber, double AmountPaid, int EntryNo, int uploaded, int coid, string branch)
		{
			return base.Channel.GetPayActual(uname, value, PaymentMethodID, PaymentMethodDesc, InvoiceNumber, AmountPaid, EntryNo, uploaded, coid, branch);
		}

		// Token: 0x060052AE RID: 21166 RVA: 0x003039A4 File Offset: 0x00301BA4
		public Task<bool> GetPayActualAsync(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, int InvoiceNumber, double AmountPaid, int EntryNo, int uploaded, int coid, string branch)
		{
			return base.Channel.GetPayActualAsync(uname, value, PaymentMethodID, PaymentMethodDesc, InvoiceNumber, AmountPaid, EntryNo, uploaded, coid, branch);
		}

		// Token: 0x060052AF RID: 21167 RVA: 0x003039D4 File Offset: 0x00301BD4
		public bool UpdatePayActual(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, int InvoiceNumber, double AmountPaid, int EntryNo, int uploaded, int coid, string branch)
		{
			return base.Channel.UpdatePayActual(uname, value, PaymentMethodID, PaymentMethodDesc, InvoiceNumber, AmountPaid, EntryNo, uploaded, coid, branch);
		}

		// Token: 0x060052B0 RID: 21168 RVA: 0x00303A04 File Offset: 0x00301C04
		public Task<bool> UpdatePayActualAsync(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, int InvoiceNumber, double AmountPaid, int EntryNo, int uploaded, int coid, string branch)
		{
			return base.Channel.UpdatePayActualAsync(uname, value, PaymentMethodID, PaymentMethodDesc, InvoiceNumber, AmountPaid, EntryNo, uploaded, coid, branch);
		}

		// Token: 0x060052B1 RID: 21169 RVA: 0x00303A34 File Offset: 0x00301C34
		public bool GetDel(string uname, string value, string TBName, string KeyColumn, string KeyColumnType, string KeyValue, int EntryNo, int uploaded, int coid, string branch)
		{
			return base.Channel.GetDel(uname, value, TBName, KeyColumn, KeyColumnType, KeyValue, EntryNo, uploaded, coid, branch);
		}

		// Token: 0x060052B2 RID: 21170 RVA: 0x00303A64 File Offset: 0x00301C64
		public Task<bool> GetDelAsync(string uname, string value, string TBName, string KeyColumn, string KeyColumnType, string KeyValue, int EntryNo, int uploaded, int coid, string branch)
		{
			return base.Channel.GetDelAsync(uname, value, TBName, KeyColumn, KeyColumnType, KeyValue, EntryNo, uploaded, coid, branch);
		}

		// Token: 0x060052B3 RID: 21171 RVA: 0x00303A94 File Offset: 0x00301C94
		public string GetDel2(string uname, string value, string TBName, string KeyColumn, string KeyColumnType, string KeyValue, int EntryNo, int uploaded, int coid, string branch, string hqservername, string hquploadtime)
		{
			return base.Channel.GetDel2(uname, value, TBName, KeyColumn, KeyColumnType, KeyValue, EntryNo, uploaded, coid, branch, hqservername, hquploadtime);
		}

		// Token: 0x060052B4 RID: 21172 RVA: 0x00303AC8 File Offset: 0x00301CC8
		public Task<string> GetDel2Async(string uname, string value, string TBName, string KeyColumn, string KeyColumnType, string KeyValue, int EntryNo, int uploaded, int coid, string branch, string hqservername, string hquploadtime)
		{
			return base.Channel.GetDel2Async(uname, value, TBName, KeyColumn, KeyColumnType, KeyValue, EntryNo, uploaded, coid, branch, hqservername, hquploadtime);
		}

		// Token: 0x060052B5 RID: 21173 RVA: 0x00303AFC File Offset: 0x00301CFC
		public DataTable SalesSumm(string uname, string value, int coid, int theday)
		{
			return base.Channel.SalesSumm(uname, value, coid, theday);
		}

		// Token: 0x060052B6 RID: 21174 RVA: 0x00303B20 File Offset: 0x00301D20
		public Task<DataTable> SalesSummAsync(string uname, string value, int coid, int theday)
		{
			return base.Channel.SalesSummAsync(uname, value, coid, theday);
		}

		// Token: 0x060052B7 RID: 21175 RVA: 0x00303B44 File Offset: 0x00301D44
		public SalesSummaryData GetSalesSummary(string uname, string value, int coid, int theday)
		{
			return base.Channel.GetSalesSummary(uname, value, coid, theday);
		}

		// Token: 0x060052B8 RID: 21176 RVA: 0x00303B68 File Offset: 0x00301D68
		public Task<SalesSummaryData> GetSalesSummaryAsync(string uname, string value, int coid, int theday)
		{
			return base.Channel.GetSalesSummaryAsync(uname, value, coid, theday);
		}

		// Token: 0x060052B9 RID: 21177 RVA: 0x00303B8C File Offset: 0x00301D8C
		public PricesData UpdateProdtPrice(string uname, string value, int coid)
		{
			return base.Channel.UpdateProdtPrice(uname, value, coid);
		}

		// Token: 0x060052BA RID: 21178 RVA: 0x00303BAC File Offset: 0x00301DAC
		public Task<PricesData> UpdateProdtPriceAsync(string uname, string value, int coid)
		{
			return base.Channel.UpdateProdtPriceAsync(uname, value, coid);
		}

		// Token: 0x060052BB RID: 21179 RVA: 0x00303BCC File Offset: 0x00301DCC
		public PaymethrateData UpdatePaymethRates(string uname, string value, int coid)
		{
			return base.Channel.UpdatePaymethRates(uname, value, coid);
		}

		// Token: 0x060052BC RID: 21180 RVA: 0x00303BEC File Offset: 0x00301DEC
		public Task<PaymethrateData> UpdatePaymethRatesAsync(string uname, string value, int coid)
		{
			return base.Channel.UpdatePaymethRatesAsync(uname, value, coid);
		}

		// Token: 0x060052BD RID: 21181 RVA: 0x00303C0C File Offset: 0x00301E0C
		public string CountPriceChanges(string uname, string value, int coid, int theday)
		{
			return base.Channel.CountPriceChanges(uname, value, coid, theday);
		}

		// Token: 0x060052BE RID: 21182 RVA: 0x00303C30 File Offset: 0x00301E30
		public Task<string> CountPriceChangesAsync(string uname, string value, int coid, int theday)
		{
			return base.Channel.CountPriceChangesAsync(uname, value, coid, theday);
		}

		// Token: 0x060052BF RID: 21183 RVA: 0x00303C54 File Offset: 0x00301E54
		public string CountRateChanges(string uname, string value, int coid)
		{
			return base.Channel.CountRateChanges(uname, value, coid);
		}

		// Token: 0x060052C0 RID: 21184 RVA: 0x00303C74 File Offset: 0x00301E74
		public Task<string> CountRateChangesAsync(string uname, string value, int coid)
		{
			return base.Channel.CountRateChangesAsync(uname, value, coid);
		}

		// Token: 0x060052C1 RID: 21185 RVA: 0x00303C94 File Offset: 0x00301E94
		public bool MarkPricesDownloaded(string uname, string value, int coid, int entryno, string dtime, int ddate)
		{
			return base.Channel.MarkPricesDownloaded(uname, value, coid, entryno, dtime, ddate);
		}

		// Token: 0x060052C2 RID: 21186 RVA: 0x00303CBC File Offset: 0x00301EBC
		public Task<bool> MarkPricesDownloadedAsync(string uname, string value, int coid, int entryno, string dtime, int ddate)
		{
			return base.Channel.MarkPricesDownloadedAsync(uname, value, coid, entryno, dtime, ddate);
		}

		// Token: 0x060052C3 RID: 21187 RVA: 0x00303CE4 File Offset: 0x00301EE4
		public bool MarkRatesDownloaded(string uname, string value, int coid, int entryno, string dtime, int ddate)
		{
			return base.Channel.MarkRatesDownloaded(uname, value, coid, entryno, dtime, ddate);
		}

		// Token: 0x060052C4 RID: 21188 RVA: 0x00303D0C File Offset: 0x00301F0C
		public Task<bool> MarkRatesDownloadedAsync(string uname, string value, int coid, int entryno, string dtime, int ddate)
		{
			return base.Channel.MarkRatesDownloadedAsync(uname, value, coid, entryno, dtime, ddate);
		}

		// Token: 0x060052C5 RID: 21189 RVA: 0x00303D34 File Offset: 0x00301F34
		public NewStocksData GetNewStocksPurchased(string uname, string value, int coid)
		{
			return base.Channel.GetNewStocksPurchased(uname, value, coid);
		}

		// Token: 0x060052C6 RID: 21190 RVA: 0x00303D54 File Offset: 0x00301F54
		public Task<NewStocksData> GetNewStocksPurchasedAsync(string uname, string value, int coid)
		{
			return base.Channel.GetNewStocksPurchasedAsync(uname, value, coid);
		}

		// Token: 0x060052C7 RID: 21191 RVA: 0x00303D74 File Offset: 0x00301F74
		public string CountNewStocksPurchased(string uname, string value, int coid, int theday)
		{
			return base.Channel.CountNewStocksPurchased(uname, value, coid, theday);
		}

		// Token: 0x060052C8 RID: 21192 RVA: 0x00303D98 File Offset: 0x00301F98
		public Task<string> CountNewStocksPurchasedAsync(string uname, string value, int coid, int theday)
		{
			return base.Channel.CountNewStocksPurchasedAsync(uname, value, coid, theday);
		}

		// Token: 0x060052C9 RID: 21193 RVA: 0x00303DBC File Offset: 0x00301FBC
		public bool MarkNewStockPurchaseDownloaded(string uname, string value, int coid, int entryno, string dtime, int ddate)
		{
			return base.Channel.MarkNewStockPurchaseDownloaded(uname, value, coid, entryno, dtime, ddate);
		}

		// Token: 0x060052CA RID: 21194 RVA: 0x00303DE4 File Offset: 0x00301FE4
		public Task<bool> MarkNewStockPurchaseDownloadedAsync(string uname, string value, int coid, int entryno, string dtime, int ddate)
		{
			return base.Channel.MarkNewStockPurchaseDownloadedAsync(uname, value, coid, entryno, dtime, ddate);
		}

		// Token: 0x060052CB RID: 21195 RVA: 0x00303E0C File Offset: 0x0030200C
		public NewOnlineStockTransfersData GetNewOnlineStockTransfers(string uname, string value, int coid, string branch, int ishq)
		{
			return base.Channel.GetNewOnlineStockTransfers(uname, value, coid, branch, ishq);
		}

		// Token: 0x060052CC RID: 21196 RVA: 0x00303E30 File Offset: 0x00302030
		public Task<NewOnlineStockTransfersData> GetNewOnlineStockTransfersAsync(string uname, string value, int coid, string branch, int ishq)
		{
			return base.Channel.GetNewOnlineStockTransfersAsync(uname, value, coid, branch, ishq);
		}

		// Token: 0x060052CD RID: 21197 RVA: 0x00303E54 File Offset: 0x00302054
		public bool MarkOnlineStockTransferDownloaded(string uname, string value, int coid, string branch, int entryno, string downloadedtime, string machinename)
		{
			return base.Channel.MarkOnlineStockTransferDownloaded(uname, value, coid, branch, entryno, downloadedtime, machinename);
		}

		// Token: 0x060052CE RID: 21198 RVA: 0x00303E7C File Offset: 0x0030207C
		public Task<bool> MarkOnlineStockTransferDownloadedAsync(string uname, string value, int coid, string branch, int entryno, string downloadedtime, string machinename)
		{
			return base.Channel.MarkOnlineStockTransferDownloadedAsync(uname, value, coid, branch, entryno, downloadedtime, machinename);
		}

		// Token: 0x060052CF RID: 21199 RVA: 0x00303EA4 File Offset: 0x003020A4
		public ConnectedBranchStatus GetConnectedBranchStatus(string uname, string value, int coid)
		{
			return base.Channel.GetConnectedBranchStatus(uname, value, coid);
		}

		// Token: 0x060052D0 RID: 21200 RVA: 0x00303EC4 File Offset: 0x003020C4
		public Task<ConnectedBranchStatus> GetConnectedBranchStatusAsync(string uname, string value, int coid)
		{
			return base.Channel.GetConnectedBranchStatusAsync(uname, value, coid);
		}

		// Token: 0x060052D1 RID: 21201 RVA: 0x00303EE4 File Offset: 0x003020E4
		public bool SetCommandForBranch(string uname, string value, int coid, string branch, string commandname, DateTime trandatetime)
		{
			return base.Channel.SetCommandForBranch(uname, value, coid, branch, commandname, trandatetime);
		}

		// Token: 0x060052D2 RID: 21202 RVA: 0x00303F0C File Offset: 0x0030210C
		public Task<bool> SetCommandForBranchAsync(string uname, string value, int coid, string branch, string commandname, DateTime trandatetime)
		{
			return base.Channel.SetCommandForBranchAsync(uname, value, coid, branch, commandname, trandatetime);
		}

		// Token: 0x060052D3 RID: 21203 RVA: 0x00303F34 File Offset: 0x00302134
		public string GetCommandForBranch(string uname, string value, int coid, string branch)
		{
			return base.Channel.GetCommandForBranch(uname, value, coid, branch);
		}

		// Token: 0x060052D4 RID: 21204 RVA: 0x00303F58 File Offset: 0x00302158
		public Task<string> GetCommandForBranchAsync(string uname, string value, int coid, string branch)
		{
			return base.Channel.GetCommandForBranchAsync(uname, value, coid, branch);
		}

		// Token: 0x060052D5 RID: 21205 RVA: 0x00303F7C File Offset: 0x0030217C
		public string UpdateCommandForBranch(string uname, string value, int coid, string branch, int entryno)
		{
			return base.Channel.UpdateCommandForBranch(uname, value, coid, branch, entryno);
		}

		// Token: 0x060052D6 RID: 21206 RVA: 0x00303FA0 File Offset: 0x003021A0
		public Task<string> UpdateCommandForBranchAsync(string uname, string value, int coid, string branch, int entryno)
		{
			return base.Channel.UpdateCommandForBranchAsync(uname, value, coid, branch, entryno);
		}

		// Token: 0x060052D7 RID: 21207 RVA: 0x00303FC4 File Offset: 0x003021C4
		public bool UpdatePay2(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int uploaded, int coid)
		{
			return base.Channel.UpdatePay2(uname, value, PaymentMethodID, PaymentMethodDesc, rate, uploaded, coid);
		}

		// Token: 0x060052D8 RID: 21208 RVA: 0x00303FEC File Offset: 0x003021EC
		public Task<bool> UpdatePay2Async(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int uploaded, int coid)
		{
			return base.Channel.UpdatePay2Async(uname, value, PaymentMethodID, PaymentMethodDesc, rate, uploaded, coid);
		}

		// Token: 0x060052D9 RID: 21209 RVA: 0x00304014 File Offset: 0x00302214
		public bool GetPayActual2(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int InvoiceNumber, double AmountPaid, int EntryNo, int uploaded, int coid, string branch)
		{
			return base.Channel.GetPayActual2(uname, value, PaymentMethodID, PaymentMethodDesc, rate, InvoiceNumber, AmountPaid, EntryNo, uploaded, coid, branch);
		}

		// Token: 0x060052DA RID: 21210 RVA: 0x00304044 File Offset: 0x00302244
		public Task<bool> GetPayActual2Async(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int InvoiceNumber, double AmountPaid, int EntryNo, int uploaded, int coid, string branch)
		{
			return base.Channel.GetPayActual2Async(uname, value, PaymentMethodID, PaymentMethodDesc, rate, InvoiceNumber, AmountPaid, EntryNo, uploaded, coid, branch);
		}

		// Token: 0x060052DB RID: 21211 RVA: 0x00304074 File Offset: 0x00302274
		public bool GetPayActual3(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int InvoiceNumber, double AmountPaid, int EntryNo, int uploaded, int coid, string branch, decimal disc, string trantype)
		{
			return base.Channel.GetPayActual3(uname, value, PaymentMethodID, PaymentMethodDesc, rate, InvoiceNumber, AmountPaid, EntryNo, uploaded, coid, branch, disc, trantype);
		}

		// Token: 0x060052DC RID: 21212 RVA: 0x003040A8 File Offset: 0x003022A8
		public Task<bool> GetPayActual3Async(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int InvoiceNumber, double AmountPaid, int EntryNo, int uploaded, int coid, string branch, decimal disc, string trantype)
		{
			return base.Channel.GetPayActual3Async(uname, value, PaymentMethodID, PaymentMethodDesc, rate, InvoiceNumber, AmountPaid, EntryNo, uploaded, coid, branch, disc, trantype);
		}

		// Token: 0x060052DD RID: 21213 RVA: 0x003040DC File Offset: 0x003022DC
		public bool GetPayActual4(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int InvoiceNumber, double AmountPaid, int EntryNo, int uploaded, int coid, string branch, decimal disc, string trantype, string hqservername, DateTime hquploadtime)
		{
			return base.Channel.GetPayActual4(uname, value, PaymentMethodID, PaymentMethodDesc, rate, InvoiceNumber, AmountPaid, EntryNo, uploaded, coid, branch, disc, trantype, hqservername, hquploadtime);
		}

		// Token: 0x060052DE RID: 21214 RVA: 0x00304114 File Offset: 0x00302314
		public Task<bool> GetPayActual4Async(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int InvoiceNumber, double AmountPaid, int EntryNo, int uploaded, int coid, string branch, decimal disc, string trantype, string hqservername, DateTime hquploadtime)
		{
			return base.Channel.GetPayActual4Async(uname, value, PaymentMethodID, PaymentMethodDesc, rate, InvoiceNumber, AmountPaid, EntryNo, uploaded, coid, branch, disc, trantype, hqservername, hquploadtime);
		}

		// Token: 0x060052DF RID: 21215 RVA: 0x0030414C File Offset: 0x0030234C
		public bool GetPayActual5(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int InvoiceNumber, double AmountPaid, int EntryNo, int uploaded, int coid, string branch, decimal disc, string trantype, string hqservername, DateTime hquploadtime, int trandate)
		{
			return base.Channel.GetPayActual5(uname, value, PaymentMethodID, PaymentMethodDesc, rate, InvoiceNumber, AmountPaid, EntryNo, uploaded, coid, branch, disc, trantype, hqservername, hquploadtime, trandate);
		}

		// Token: 0x060052E0 RID: 21216 RVA: 0x00304188 File Offset: 0x00302388
		public Task<bool> GetPayActual5Async(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int InvoiceNumber, double AmountPaid, int EntryNo, int uploaded, int coid, string branch, decimal disc, string trantype, string hqservername, DateTime hquploadtime, int trandate)
		{
			return base.Channel.GetPayActual5Async(uname, value, PaymentMethodID, PaymentMethodDesc, rate, InvoiceNumber, AmountPaid, EntryNo, uploaded, coid, branch, disc, trantype, hqservername, hquploadtime, trandate);
		}

		// Token: 0x060052E1 RID: 21217 RVA: 0x003041C4 File Offset: 0x003023C4
		public bool UpdatePayActual2(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int InvoiceNumber, double AmountPaid, int EntryNo, int uploaded, int coid, string branch)
		{
			return base.Channel.UpdatePayActual2(uname, value, PaymentMethodID, PaymentMethodDesc, rate, InvoiceNumber, AmountPaid, EntryNo, uploaded, coid, branch);
		}

		// Token: 0x060052E2 RID: 21218 RVA: 0x003041F4 File Offset: 0x003023F4
		public Task<bool> UpdatePayActual2Async(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int InvoiceNumber, double AmountPaid, int EntryNo, int uploaded, int coid, string branch)
		{
			return base.Channel.UpdatePayActual2Async(uname, value, PaymentMethodID, PaymentMethodDesc, rate, InvoiceNumber, AmountPaid, EntryNo, uploaded, coid, branch);
		}

		// Token: 0x060052E3 RID: 21219 RVA: 0x00304224 File Offset: 0x00302424
		public bool GetData2(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, int qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty)
		{
			return base.Channel.GetData2(uname, value, entryno, invnum, trandate, prodid, isstockin, @ref, qty, cost, sellingprice, doneby, donewhen, paymeth, trancode, datecancelled, cancelledby, prodcode, trandesc, uploaded, trantime, coid, branch, taxamt, shift, shiftdate, otherdetail, batchnumber, expirydate, iswholesaleprice, iswholesalepriceqty);
		}

		// Token: 0x060052E4 RID: 21220 RVA: 0x0030427C File Offset: 0x0030247C
		public Task<bool> GetData2Async(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, int qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty)
		{
			return base.Channel.GetData2Async(uname, value, entryno, invnum, trandate, prodid, isstockin, @ref, qty, cost, sellingprice, doneby, donewhen, paymeth, trancode, datecancelled, cancelledby, prodcode, trandesc, uploaded, trantime, coid, branch, taxamt, shift, shiftdate, otherdetail, batchnumber, expirydate, iswholesaleprice, iswholesalepriceqty);
		}

		// Token: 0x060052E5 RID: 21221 RVA: 0x003042D4 File Offset: 0x003024D4
		public bool UpdateData2(int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, int qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty)
		{
			return base.Channel.UpdateData2(entryno, invnum, trandate, prodid, isstockin, @ref, qty, cost, sellingprice, doneby, donewhen, paymeth, trancode, datecancelled, cancelledby, prodcode, trandesc, uploaded, trantime, coid, branch, taxamt, shift, shiftdate, otherdetail, batchnumber, expirydate, iswholesaleprice, iswholesalepriceqty);
		}

		// Token: 0x060052E6 RID: 21222 RVA: 0x00304328 File Offset: 0x00302528
		public Task<bool> UpdateData2Async(int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, int qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty)
		{
			return base.Channel.UpdateData2Async(entryno, invnum, trandate, prodid, isstockin, @ref, qty, cost, sellingprice, doneby, donewhen, paymeth, trancode, datecancelled, cancelledby, prodcode, trandesc, uploaded, trantime, coid, branch, taxamt, shift, shiftdate, otherdetail, batchnumber, expirydate, iswholesaleprice, iswholesalepriceqty);
		}

		// Token: 0x060052E7 RID: 21223 RVA: 0x0030437C File Offset: 0x0030257C
		public PayMethRates FetchPayMethRatesChanged(string uname, string value, int coid)
		{
			return base.Channel.FetchPayMethRatesChanged(uname, value, coid);
		}

		// Token: 0x060052E8 RID: 21224 RVA: 0x0030439C File Offset: 0x0030259C
		public Task<PayMethRates> FetchPayMethRatesChangedAsync(string uname, string value, int coid)
		{
			return base.Channel.FetchPayMethRatesChangedAsync(uname, value, coid);
		}

		// Token: 0x060052E9 RID: 21225 RVA: 0x003043BC File Offset: 0x003025BC
		public bool UpdatePayMethRatesChanged(string uname, string value, int coid, int entryno, int downloadeddate, string downloadedtime)
		{
			return base.Channel.UpdatePayMethRatesChanged(uname, value, coid, entryno, downloadeddate, downloadedtime);
		}

		// Token: 0x060052EA RID: 21226 RVA: 0x003043E4 File Offset: 0x003025E4
		public Task<bool> UpdatePayMethRatesChangedAsync(string uname, string value, int coid, int entryno, int downloadeddate, string downloadedtime)
		{
			return base.Channel.UpdatePayMethRatesChangedAsync(uname, value, coid, entryno, downloadeddate, downloadedtime);
		}

		// Token: 0x060052EB RID: 21227 RVA: 0x0030440C File Offset: 0x0030260C
		public string MFAuthenticateUser(string uname, string value, string dtime, int ddate, int cardnum, string pin)
		{
			return base.Channel.MFAuthenticateUser(uname, value, dtime, ddate, cardnum, pin);
		}

		// Token: 0x060052EC RID: 21228 RVA: 0x00304434 File Offset: 0x00302634
		public Task<string> MFAuthenticateUserAsync(string uname, string value, string dtime, int ddate, int cardnum, string pin)
		{
			return base.Channel.MFAuthenticateUserAsync(uname, value, dtime, ddate, cardnum, pin);
		}

		// Token: 0x060052ED RID: 21229 RVA: 0x0030445C File Offset: 0x0030265C
		public string FetchUsers(string uname, string value, string username, string password, int isadmin, int entryno, int coid, int issup, string branch, string isallbranches, string realname, string createdby, int datecreated, int isactive, string deactivatedby, int deactivateddate, int uploaded, int trans_entryno, string hqservername, string uploadingbranch)
		{
			return base.Channel.FetchUsers(uname, value, username, password, isadmin, entryno, coid, issup, branch, isallbranches, realname, createdby, datecreated, isactive, deactivatedby, deactivateddate, uploaded, trans_entryno, hqservername, uploadingbranch);
		}

		// Token: 0x060052EE RID: 21230 RVA: 0x003044A0 File Offset: 0x003026A0
		public Task<string> FetchUsersAsync(string uname, string value, string username, string password, int isadmin, int entryno, int coid, int issup, string branch, string isallbranches, string realname, string createdby, int datecreated, int isactive, string deactivatedby, int deactivateddate, int uploaded, int trans_entryno, string hqservername, string uploadingbranch)
		{
			return base.Channel.FetchUsersAsync(uname, value, username, password, isadmin, entryno, coid, issup, branch, isallbranches, realname, createdby, datecreated, isactive, deactivatedby, deactivateddate, uploaded, trans_entryno, hqservername, uploadingbranch);
		}

		// Token: 0x060052EF RID: 21231 RVA: 0x003044E4 File Offset: 0x003026E4
		public string FetchBranchPrices(string uname, string value, int coid, int productid, string branch, decimal sellingprice, decimal wholesaleprice, decimal wholesaleqty, decimal specialprice, int uploaded, string doneby, int donewhen, string hqservername, DateTime hquploadtime)
		{
			return base.Channel.FetchBranchPrices(uname, value, coid, productid, branch, sellingprice, wholesaleprice, wholesaleqty, specialprice, uploaded, doneby, donewhen, hqservername, hquploadtime);
		}

		// Token: 0x060052F0 RID: 21232 RVA: 0x0030451C File Offset: 0x0030271C
		public Task<string> FetchBranchPricesAsync(string uname, string value, int coid, int productid, string branch, decimal sellingprice, decimal wholesaleprice, decimal wholesaleqty, decimal specialprice, int uploaded, string doneby, int donewhen, string hqservername, DateTime hquploadtime)
		{
			return base.Channel.FetchBranchPricesAsync(uname, value, coid, productid, branch, sellingprice, wholesaleprice, wholesaleqty, specialprice, uploaded, doneby, donewhen, hqservername, hquploadtime);
		}

		// Token: 0x060052F1 RID: 21233 RVA: 0x00304554 File Offset: 0x00302754
		public bool FetchExpCategories(string uname, string value, int coid, int expensecatid, string expensecatdesc, int uploaded)
		{
			return base.Channel.FetchExpCategories(uname, value, coid, expensecatid, expensecatdesc, uploaded);
		}

		// Token: 0x060052F2 RID: 21234 RVA: 0x0030457C File Offset: 0x0030277C
		public Task<bool> FetchExpCategoriesAsync(string uname, string value, int coid, int expensecatid, string expensecatdesc, int uploaded)
		{
			return base.Channel.FetchExpCategoriesAsync(uname, value, coid, expensecatid, expensecatdesc, uploaded);
		}

		// Token: 0x060052F3 RID: 21235 RVA: 0x003045A4 File Offset: 0x003027A4
		public bool FetchManuFormula(string uname, string value, int productid, string formulaname, string comments, int coid, string doneby, int donedate, int uploaded)
		{
			return base.Channel.FetchManuFormula(uname, value, productid, formulaname, comments, coid, doneby, donedate, uploaded);
		}

		// Token: 0x060052F4 RID: 21236 RVA: 0x003045D0 File Offset: 0x003027D0
		public Task<bool> FetchManuFormulaAsync(string uname, string value, int productid, string formulaname, string comments, int coid, string doneby, int donedate, int uploaded)
		{
			return base.Channel.FetchManuFormulaAsync(uname, value, productid, formulaname, comments, coid, doneby, donedate, uploaded);
		}

		// Token: 0x060052F5 RID: 21237 RVA: 0x003045FC File Offset: 0x003027FC
		public bool FetchManuIngridient(string uname, string value, int entryno, string formulaname, int productid, decimal qty, int coid, string doneby, int donedate, int uploaded)
		{
			return base.Channel.FetchManuIngridient(uname, value, entryno, formulaname, productid, qty, coid, doneby, donedate, uploaded);
		}

		// Token: 0x060052F6 RID: 21238 RVA: 0x0030462C File Offset: 0x0030282C
		public Task<bool> FetchManuIngridientAsync(string uname, string value, int entryno, string formulaname, int productid, decimal qty, int coid, string doneby, int donedate, int uploaded)
		{
			return base.Channel.FetchManuIngridientAsync(uname, value, entryno, formulaname, productid, qty, coid, doneby, donedate, uploaded);
		}

		// Token: 0x060052F7 RID: 21239 RVA: 0x0030465C File Offset: 0x0030285C
		public CatsData D_Cats(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_Cats(uname, value, branch, coid);
		}

		// Token: 0x060052F8 RID: 21240 RVA: 0x00304680 File Offset: 0x00302880
		public Task<CatsData> D_CatsAsync(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_CatsAsync(uname, value, branch, coid);
		}

		// Token: 0x060052F9 RID: 21241 RVA: 0x003046A4 File Offset: 0x003028A4
		public CatsData D_Cats2(string uname, string value, string branch, int coid, string brdownloadtime, string brservername)
		{
			return base.Channel.D_Cats2(uname, value, branch, coid, brdownloadtime, brservername);
		}

		// Token: 0x060052FA RID: 21242 RVA: 0x003046CC File Offset: 0x003028CC
		public Task<CatsData> D_Cats2Async(string uname, string value, string branch, int coid, string brdownloadtime, string brservername)
		{
			return base.Channel.D_Cats2Async(uname, value, branch, coid, brdownloadtime, brservername);
		}

		// Token: 0x060052FB RID: 21243 RVA: 0x003046F4 File Offset: 0x003028F4
		public Prodts D_Prodts(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_Prodts(uname, value, branch, coid);
		}

		// Token: 0x060052FC RID: 21244 RVA: 0x00304718 File Offset: 0x00302918
		public Task<Prodts> D_ProdtsAsync(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_ProdtsAsync(uname, value, branch, coid);
		}

		// Token: 0x060052FD RID: 21245 RVA: 0x0030473C File Offset: 0x0030293C
		public PayMethRates D_PayMeths(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_PayMeths(uname, value, branch, coid);
		}

		// Token: 0x060052FE RID: 21246 RVA: 0x00304760 File Offset: 0x00302960
		public Task<PayMethRates> D_PayMethsAsync(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_PayMethsAsync(uname, value, branch, coid);
		}

		// Token: 0x060052FF RID: 21247 RVA: 0x00304784 File Offset: 0x00302984
		public Mvt D_MvtData(string uname, string value, string branch, int coid, string brservername, DateTime brdownloadtime)
		{
			return base.Channel.D_MvtData(uname, value, branch, coid, brservername, brdownloadtime);
		}

		// Token: 0x06005300 RID: 21248 RVA: 0x003047AC File Offset: 0x003029AC
		public Task<Mvt> D_MvtDataAsync(string uname, string value, string branch, int coid, string brservername, DateTime brdownloadtime)
		{
			return base.Channel.D_MvtDataAsync(uname, value, branch, coid, brservername, brdownloadtime);
		}

		// Token: 0x06005301 RID: 21249 RVA: 0x003047D4 File Offset: 0x003029D4
		public Mvt D_MvtData2(string uname, string value, string branch, int coid, string brservername, DateTime brdownloadtime, bool isbranch)
		{
			return base.Channel.D_MvtData2(uname, value, branch, coid, brservername, brdownloadtime, isbranch);
		}

		// Token: 0x06005302 RID: 21250 RVA: 0x003047FC File Offset: 0x003029FC
		public Task<Mvt> D_MvtData2Async(string uname, string value, string branch, int coid, string brservername, DateTime brdownloadtime, bool isbranch)
		{
			return base.Channel.D_MvtData2Async(uname, value, branch, coid, brservername, brdownloadtime, isbranch);
		}

		// Token: 0x06005303 RID: 21251 RVA: 0x00304824 File Offset: 0x00302A24
		public Mvt D_MvtData3(string uname, string value, string branch, int coid, string brservername, string brdownloadtime, bool isbranch)
		{
			return base.Channel.D_MvtData3(uname, value, branch, coid, brservername, brdownloadtime, isbranch);
		}

		// Token: 0x06005304 RID: 21252 RVA: 0x0030484C File Offset: 0x00302A4C
		public Task<Mvt> D_MvtData3Async(string uname, string value, string branch, int coid, string brservername, string brdownloadtime, bool isbranch)
		{
			return base.Channel.D_MvtData3Async(uname, value, branch, coid, brservername, brdownloadtime, isbranch);
		}

		// Token: 0x06005305 RID: 21253 RVA: 0x00304874 File Offset: 0x00302A74
		public PayMethActual D_Paymethactual(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_Paymethactual(uname, value, branch, coid);
		}

		// Token: 0x06005306 RID: 21254 RVA: 0x00304898 File Offset: 0x00302A98
		public Task<PayMethActual> D_PaymethactualAsync(string uname, string value, string branch, int coid)
		{
			return base.Channel.D_PaymethactualAsync(uname, value, branch, coid);
		}

		// Token: 0x06005307 RID: 21255 RVA: 0x003048BC File Offset: 0x00302ABC
		public PayMethActual D_Paymethactual2(string uname, string value, string branch, int coid, string brservername, DateTime brdownloadtime)
		{
			return base.Channel.D_Paymethactual2(uname, value, branch, coid, brservername, brdownloadtime);
		}

		// Token: 0x06005308 RID: 21256 RVA: 0x003048E4 File Offset: 0x00302AE4
		public Task<PayMethActual> D_Paymethactual2Async(string uname, string value, string branch, int coid, string brservername, DateTime brdownloadtime)
		{
			return base.Channel.D_Paymethactual2Async(uname, value, branch, coid, brservername, brdownloadtime);
		}

		// Token: 0x06005309 RID: 21257 RVA: 0x0030490C File Offset: 0x00302B0C
		public PayMethz D_Paymethods(string uname, string value, string branch, int coid, string brservername, Guid brdownloadtime)
		{
			return base.Channel.D_Paymethods(uname, value, branch, coid, brservername, brdownloadtime);
		}

		// Token: 0x0600530A RID: 21258 RVA: 0x00304934 File Offset: 0x00302B34
		public Task<PayMethz> D_PaymethodsAsync(string uname, string value, string branch, int coid, string brservername, Guid brdownloadtime)
		{
			return base.Channel.D_PaymethodsAsync(uname, value, branch, coid, brservername, brdownloadtime);
		}

		// Token: 0x0600530B RID: 21259 RVA: 0x0030495C File Offset: 0x00302B5C
		public BranchPrices D_BranchPrices(string uname, string value, string branch, int coid, string brservername, DateTime brdownloadtime)
		{
			return base.Channel.D_BranchPrices(uname, value, branch, coid, brservername, brdownloadtime);
		}

		// Token: 0x0600530C RID: 21260 RVA: 0x00304984 File Offset: 0x00302B84
		public Task<BranchPrices> D_BranchPricesAsync(string uname, string value, string branch, int coid, string brservername, DateTime brdownloadtime)
		{
			return base.Channel.D_BranchPricesAsync(uname, value, branch, coid, brservername, brdownloadtime);
		}

		// Token: 0x0600530D RID: 21261 RVA: 0x003049AC File Offset: 0x00302BAC
		public BranchProductDetails D_BranchProductDetails(string uname, string value, string branch, int coid, string brservername, DateTime brdownloadtime)
		{
			return base.Channel.D_BranchProductDetails(uname, value, branch, coid, brservername, brdownloadtime);
		}

		// Token: 0x0600530E RID: 21262 RVA: 0x003049D4 File Offset: 0x00302BD4
		public Task<BranchProductDetails> D_BranchProductDetailsAsync(string uname, string value, string branch, int coid, string brservername, DateTime brdownloadtime)
		{
			return base.Channel.D_BranchProductDetailsAsync(uname, value, branch, coid, brservername, brdownloadtime);
		}
	}
}
