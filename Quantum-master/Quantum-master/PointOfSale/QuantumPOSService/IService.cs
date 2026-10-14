using System;
using System.CodeDom.Compiler;
using System.Data;
using System.ServiceModel;
using System.Threading.Tasks;

namespace PointOfSale.QuantumPOSService
{
	// Token: 0x020001D7 RID: 471
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[ServiceContract(ConfigurationName = "QuantumPOSService.IService")]
	public interface IService
	{
		// Token: 0x0600513E RID: 20798
		[OperationContract(Action = "http://tempuri.org/IService/D_ManuFormula", ReplyAction = "http://tempuri.org/IService/D_ManuFormulaResponse")]
		ManuFormula D_ManuFormula(string uname, string value, string branch, int coid);

		// Token: 0x0600513F RID: 20799
		[OperationContract(Action = "http://tempuri.org/IService/D_ManuFormula", ReplyAction = "http://tempuri.org/IService/D_ManuFormulaResponse")]
		Task<ManuFormula> D_ManuFormulaAsync(string uname, string value, string branch, int coid);

		// Token: 0x06005140 RID: 20800
		[OperationContract(Action = "http://tempuri.org/IService/D_ManuIng", ReplyAction = "http://tempuri.org/IService/D_ManuIngResponse")]
		ManuIngridients D_ManuIng(string uname, string value, string branch, int coid);

		// Token: 0x06005141 RID: 20801
		[OperationContract(Action = "http://tempuri.org/IService/D_ManuIng", ReplyAction = "http://tempuri.org/IService/D_ManuIngResponse")]
		Task<ManuIngridients> D_ManuIngAsync(string uname, string value, string branch, int coid);

		// Token: 0x06005142 RID: 20802
		[OperationContract(Action = "http://tempuri.org/IService/D_users", ReplyAction = "http://tempuri.org/IService/D_usersResponse")]
		Users D_users(string uname, string value, string downloadingbranch, int coid, Guid new_guid);

		// Token: 0x06005143 RID: 20803
		[OperationContract(Action = "http://tempuri.org/IService/D_users", ReplyAction = "http://tempuri.org/IService/D_usersResponse")]
		Task<Users> D_usersAsync(string uname, string value, string downloadingbranch, int coid, Guid new_guid);

		// Token: 0x06005144 RID: 20804
		[OperationContract(Action = "http://tempuri.org/IService/D_ExpenseCat", ReplyAction = "http://tempuri.org/IService/D_ExpenseCatResponse")]
		ExpenseCat D_ExpenseCat(string uname, string value, string branch, int coid);

		// Token: 0x06005145 RID: 20805
		[OperationContract(Action = "http://tempuri.org/IService/D_ExpenseCat", ReplyAction = "http://tempuri.org/IService/D_ExpenseCatResponse")]
		Task<ExpenseCat> D_ExpenseCatAsync(string uname, string value, string branch, int coid);

		// Token: 0x06005146 RID: 20806
		[OperationContract(Action = "http://tempuri.org/IService/D_CustomerDetails", ReplyAction = "http://tempuri.org/IService/D_CustomerDetailsResponse")]
		CusDetails D_CustomerDetails(string uname, string value, string branch, int coid);

		// Token: 0x06005147 RID: 20807
		[OperationContract(Action = "http://tempuri.org/IService/D_CustomerDetails", ReplyAction = "http://tempuri.org/IService/D_CustomerDetailsResponse")]
		Task<CusDetails> D_CustomerDetailsAsync(string uname, string value, string branch, int coid);

		// Token: 0x06005148 RID: 20808
		[OperationContract(Action = "http://tempuri.org/IService/D_BillingTerms", ReplyAction = "http://tempuri.org/IService/D_BillingTermsResponse")]
		BillingTerms D_BillingTerms(string uname, string value, string branch, int coid);

		// Token: 0x06005149 RID: 20809
		[OperationContract(Action = "http://tempuri.org/IService/D_BillingTerms", ReplyAction = "http://tempuri.org/IService/D_BillingTermsResponse")]
		Task<BillingTerms> D_BillingTermsAsync(string uname, string value, string branch, int coid);

		// Token: 0x0600514A RID: 20810
		[OperationContract(Action = "http://tempuri.org/IService/D_BillingLog", ReplyAction = "http://tempuri.org/IService/D_BillingLogResponse")]
		BillingLog D_BillingLog(string uname, string value, string branch, int coid);

		// Token: 0x0600514B RID: 20811
		[OperationContract(Action = "http://tempuri.org/IService/D_BillingLog", ReplyAction = "http://tempuri.org/IService/D_BillingLogResponse")]
		Task<BillingLog> D_BillingLogAsync(string uname, string value, string branch, int coid);

		// Token: 0x0600514C RID: 20812
		[OperationContract(Action = "http://tempuri.org/IService/D_MvtData_Confirm", ReplyAction = "http://tempuri.org/IService/D_MvtData_ConfirmResponse")]
		bool D_MvtData_Confirm(string uname, string value, string branch, int coid, string brservername, DateTime brdownloadtime);

		// Token: 0x0600514D RID: 20813
		[OperationContract(Action = "http://tempuri.org/IService/D_MvtData_Confirm", ReplyAction = "http://tempuri.org/IService/D_MvtData_ConfirmResponse")]
		Task<bool> D_MvtData_ConfirmAsync(string uname, string value, string branch, int coid, string brservername, DateTime brdownloadtime);

		// Token: 0x0600514E RID: 20814
		[OperationContract(Action = "http://tempuri.org/IService/D_MvtData_Confirm2", ReplyAction = "http://tempuri.org/IService/D_MvtData_Confirm2Response")]
		bool D_MvtData_Confirm2(string uname, string value, string branch, int coid, string brservername, string brdownloadtime, int isbranch);

		// Token: 0x0600514F RID: 20815
		[OperationContract(Action = "http://tempuri.org/IService/D_MvtData_Confirm2", ReplyAction = "http://tempuri.org/IService/D_MvtData_Confirm2Response")]
		Task<bool> D_MvtData_Confirm2Async(string uname, string value, string branch, int coid, string brservername, string brdownloadtime, int isbranch);

		// Token: 0x06005150 RID: 20816
		[OperationContract(Action = "http://tempuri.org/IService/D_Cats2_Confirm", ReplyAction = "http://tempuri.org/IService/D_Cats2_ConfirmResponse")]
		bool D_Cats2_Confirm(string uname, string value, string branch, int coid, string brservername, string brdownloadtime);

		// Token: 0x06005151 RID: 20817
		[OperationContract(Action = "http://tempuri.org/IService/D_Cats2_Confirm", ReplyAction = "http://tempuri.org/IService/D_Cats2_ConfirmResponse")]
		Task<bool> D_Cats2_ConfirmAsync(string uname, string value, string branch, int coid, string brservername, string brdownloadtime);

		// Token: 0x06005152 RID: 20818
		[OperationContract(Action = "http://tempuri.org/IService/D_PaymethActual2_Confirm", ReplyAction = "http://tempuri.org/IService/D_PaymethActual2_ConfirmResponse")]
		bool D_PaymethActual2_Confirm(string uname, string value, string branch, int coid, string brservername, DateTime brdownloadtime);

		// Token: 0x06005153 RID: 20819
		[OperationContract(Action = "http://tempuri.org/IService/D_PaymethActual2_Confirm", ReplyAction = "http://tempuri.org/IService/D_PaymethActual2_ConfirmResponse")]
		Task<bool> D_PaymethActual2_ConfirmAsync(string uname, string value, string branch, int coid, string brservername, DateTime brdownloadtime);

		// Token: 0x06005154 RID: 20820
		[OperationContract(Action = "http://tempuri.org/IService/D_Paymeths_Confirm", ReplyAction = "http://tempuri.org/IService/D_Paymeths_ConfirmResponse")]
		bool D_Paymeths_Confirm(string uname, string value, string branch, int coid, string brservername, Guid brdownloadtime);

		// Token: 0x06005155 RID: 20821
		[OperationContract(Action = "http://tempuri.org/IService/D_Paymeths_Confirm", ReplyAction = "http://tempuri.org/IService/D_Paymeths_ConfirmResponse")]
		Task<bool> D_Paymeths_ConfirmAsync(string uname, string value, string branch, int coid, string brservername, Guid brdownloadtime);

		// Token: 0x06005156 RID: 20822
		[OperationContract(Action = "http://tempuri.org/IService/D_Paymethactual_Confirm", ReplyAction = "http://tempuri.org/IService/D_Paymethactual_ConfirmResponse")]
		bool D_Paymethactual_Confirm(string uname, string value, string branch, int coid);

		// Token: 0x06005157 RID: 20823
		[OperationContract(Action = "http://tempuri.org/IService/D_Paymethactual_Confirm", ReplyAction = "http://tempuri.org/IService/D_Paymethactual_ConfirmResponse")]
		Task<bool> D_Paymethactual_ConfirmAsync(string uname, string value, string branch, int coid);

		// Token: 0x06005158 RID: 20824
		[OperationContract(Action = "http://tempuri.org/IService/D_BranchPrices_Confirm", ReplyAction = "http://tempuri.org/IService/D_BranchPrices_ConfirmResponse")]
		bool D_BranchPrices_Confirm(string uname, string value, string branch, int coid, int theentryno);

		// Token: 0x06005159 RID: 20825
		[OperationContract(Action = "http://tempuri.org/IService/D_BranchPrices_Confirm", ReplyAction = "http://tempuri.org/IService/D_BranchPrices_ConfirmResponse")]
		Task<bool> D_BranchPrices_ConfirmAsync(string uname, string value, string branch, int coid, int theentryno);

		// Token: 0x0600515A RID: 20826
		[OperationContract(Action = "http://tempuri.org/IService/D_BranchProductDetails_Confirm", ReplyAction = "http://tempuri.org/IService/D_BranchProductDetails_ConfirmResponse")]
		bool D_BranchProductDetails_Confirm(string uname, string value, string branch, int coid, int theentryno);

		// Token: 0x0600515B RID: 20827
		[OperationContract(Action = "http://tempuri.org/IService/D_BranchProductDetails_Confirm", ReplyAction = "http://tempuri.org/IService/D_BranchProductDetails_ConfirmResponse")]
		Task<bool> D_BranchProductDetails_ConfirmAsync(string uname, string value, string branch, int coid, int theentryno);

		// Token: 0x0600515C RID: 20828
		[OperationContract(Action = "http://tempuri.org/IService/D_CustomerDetails_Confirm", ReplyAction = "http://tempuri.org/IService/D_CustomerDetails_ConfirmResponse")]
		bool D_CustomerDetails_Confirm(string uname, string value, string branch, int coid);

		// Token: 0x0600515D RID: 20829
		[OperationContract(Action = "http://tempuri.org/IService/D_CustomerDetails_Confirm", ReplyAction = "http://tempuri.org/IService/D_CustomerDetails_ConfirmResponse")]
		Task<bool> D_CustomerDetails_ConfirmAsync(string uname, string value, string branch, int coid);

		// Token: 0x0600515E RID: 20830
		[OperationContract(Action = "http://tempuri.org/IService/D_BillingLog_Confirm", ReplyAction = "http://tempuri.org/IService/D_BillingLog_ConfirmResponse")]
		bool D_BillingLog_Confirm(string uname, string value, string branch, int coid);

		// Token: 0x0600515F RID: 20831
		[OperationContract(Action = "http://tempuri.org/IService/D_BillingLog_Confirm", ReplyAction = "http://tempuri.org/IService/D_BillingLog_ConfirmResponse")]
		Task<bool> D_BillingLog_ConfirmAsync(string uname, string value, string branch, int coid);

		// Token: 0x06005160 RID: 20832
		[OperationContract(Action = "http://tempuri.org/IService/D_users_Confirm", ReplyAction = "http://tempuri.org/IService/D_users_ConfirmResponse")]
		bool D_users_Confirm(string uname, string value, string downloadingbranch, int coid, Guid brguid, string brservername);

		// Token: 0x06005161 RID: 20833
		[OperationContract(Action = "http://tempuri.org/IService/D_users_Confirm", ReplyAction = "http://tempuri.org/IService/D_users_ConfirmResponse")]
		Task<bool> D_users_ConfirmAsync(string uname, string value, string downloadingbranch, int coid, Guid brguid, string brservername);

		// Token: 0x06005162 RID: 20834
		[OperationContract(Action = "http://tempuri.org/IService/FetchProducts_Confirm", ReplyAction = "http://tempuri.org/IService/FetchProducts_ConfirmResponse")]
		bool FetchProducts_Confirm(string uname, string value, string branch, int coid, DateTime hquploadtime);

		// Token: 0x06005163 RID: 20835
		[OperationContract(Action = "http://tempuri.org/IService/FetchProducts_Confirm", ReplyAction = "http://tempuri.org/IService/FetchProducts_ConfirmResponse")]
		Task<bool> FetchProducts_ConfirmAsync(string uname, string value, string branch, int coid, DateTime hquploadtime);

		// Token: 0x06005164 RID: 20836
		[OperationContract(Action = "http://tempuri.org/IService/D_Cats_Confirm", ReplyAction = "http://tempuri.org/IService/D_Cats_ConfirmResponse")]
		bool D_Cats_Confirm(string uname, string value, string branch, int coid);

		// Token: 0x06005165 RID: 20837
		[OperationContract(Action = "http://tempuri.org/IService/D_Cats_Confirm", ReplyAction = "http://tempuri.org/IService/D_Cats_ConfirmResponse")]
		Task<bool> D_Cats_ConfirmAsync(string uname, string value, string branch, int coid);

		// Token: 0x06005166 RID: 20838
		[OperationContract(Action = "http://tempuri.org/IService/D_PayMeths_Coonfirm", ReplyAction = "http://tempuri.org/IService/D_PayMeths_CoonfirmResponse")]
		bool D_PayMeths_Coonfirm(string uname, string value, string branch, int coid);

		// Token: 0x06005167 RID: 20839
		[OperationContract(Action = "http://tempuri.org/IService/D_PayMeths_Coonfirm", ReplyAction = "http://tempuri.org/IService/D_PayMeths_CoonfirmResponse")]
		Task<bool> D_PayMeths_CoonfirmAsync(string uname, string value, string branch, int coid);

		// Token: 0x06005168 RID: 20840
		[OperationContract(Action = "http://tempuri.org/IService/D_ExpenseCat_Confirm", ReplyAction = "http://tempuri.org/IService/D_ExpenseCat_ConfirmResponse")]
		bool D_ExpenseCat_Confirm(string uname, string value, string branch, int coid);

		// Token: 0x06005169 RID: 20841
		[OperationContract(Action = "http://tempuri.org/IService/D_ExpenseCat_Confirm", ReplyAction = "http://tempuri.org/IService/D_ExpenseCat_ConfirmResponse")]
		Task<bool> D_ExpenseCat_ConfirmAsync(string uname, string value, string branch, int coid);

		// Token: 0x0600516A RID: 20842
		[OperationContract(Action = "http://tempuri.org/IService/D_ManuFormulas_Confirm", ReplyAction = "http://tempuri.org/IService/D_ManuFormulas_ConfirmResponse")]
		bool D_ManuFormulas_Confirm(string uname, string value, string branch, int coid, string brservername, string brdownloadtime);

		// Token: 0x0600516B RID: 20843
		[OperationContract(Action = "http://tempuri.org/IService/D_ManuFormulas_Confirm", ReplyAction = "http://tempuri.org/IService/D_ManuFormulas_ConfirmResponse")]
		Task<bool> D_ManuFormulas_ConfirmAsync(string uname, string value, string branch, int coid, string brservername, string brdownloadtime);

		// Token: 0x0600516C RID: 20844
		[OperationContract(Action = "http://tempuri.org/IService/D_ManuIng_Confirm", ReplyAction = "http://tempuri.org/IService/D_ManuIng_ConfirmResponse")]
		bool D_ManuIng_Confirm(string uname, string value, string branch, int coid, string brservername, string brdownloadtime);

		// Token: 0x0600516D RID: 20845
		[OperationContract(Action = "http://tempuri.org/IService/D_ManuIng_Confirm", ReplyAction = "http://tempuri.org/IService/D_ManuIng_ConfirmResponse")]
		Task<bool> D_ManuIng_ConfirmAsync(string uname, string value, string branch, int coid, string brservername, string brdownloadtime);

		// Token: 0x0600516E RID: 20846
		[OperationContract(Action = "http://tempuri.org/IService/D_BillingTerms_Confirm", ReplyAction = "http://tempuri.org/IService/D_BillingTerms_ConfirmResponse")]
		bool D_BillingTerms_Confirm(string uname, string value, string branch, int coid);

		// Token: 0x0600516F RID: 20847
		[OperationContract(Action = "http://tempuri.org/IService/D_BillingTerms_Confirm", ReplyAction = "http://tempuri.org/IService/D_BillingTerms_ConfirmResponse")]
		Task<bool> D_BillingTerms_ConfirmAsync(string uname, string value, string branch, int coid);

		// Token: 0x06005170 RID: 20848
		[OperationContract(Action = "http://tempuri.org/IService/UpdateLog", ReplyAction = "http://tempuri.org/IService/UpdateLogResponse")]
		bool UpdateLog(string uname, string value, string branch, int coid, DateTime lastseen);

		// Token: 0x06005171 RID: 20849
		[OperationContract(Action = "http://tempuri.org/IService/UpdateLog", ReplyAction = "http://tempuri.org/IService/UpdateLogResponse")]
		Task<bool> UpdateLogAsync(string uname, string value, string branch, int coid, DateTime lastseen);

		// Token: 0x06005172 RID: 20850
		[OperationContract(Action = "http://tempuri.org/IService/UploadManuFormulas", ReplyAction = "http://tempuri.org/IService/UploadManuFormulasResponse")]
		string UploadManuFormulas(string uname, string value, int coid, string branch, int productid, string formulaname, string comments, string doneby, int donedate, int uploaded, int entryno, int backofficeproductiononly, string hqservername, string hquploadtime);

		// Token: 0x06005173 RID: 20851
		[OperationContract(Action = "http://tempuri.org/IService/UploadManuFormulas", ReplyAction = "http://tempuri.org/IService/UploadManuFormulasResponse")]
		Task<string> UploadManuFormulasAsync(string uname, string value, int coid, string branch, int productid, string formulaname, string comments, string doneby, int donedate, int uploaded, int entryno, int backofficeproductiononly, string hqservername, string hquploadtime);

		// Token: 0x06005174 RID: 20852
		[OperationContract(Action = "http://tempuri.org/IService/UploadManuIng", ReplyAction = "http://tempuri.org/IService/UploadManuIngResponse")]
		string UploadManuIng(string uname, string value, int coid, string branch, int entryno, string formulaname, int productid, decimal qty, string doneby, int donedate, int uploaded, string hqservername, string hquploadtime);

		// Token: 0x06005175 RID: 20853
		[OperationContract(Action = "http://tempuri.org/IService/UploadManuIng", ReplyAction = "http://tempuri.org/IService/UploadManuIngResponse")]
		Task<string> UploadManuIngAsync(string uname, string value, int coid, string branch, int entryno, string formulaname, int productid, decimal qty, string doneby, int donedate, int uploaded, string hqservername, string hquploadtime);

		// Token: 0x06005176 RID: 20854
		[OperationContract(Action = "http://tempuri.org/IService/D_ManuFormulas", ReplyAction = "http://tempuri.org/IService/D_ManuFormulasResponse")]
		ManuFormulas D_ManuFormulas(string uname, string value, string branch, int coid, string brservername, string brdownloadtime);

		// Token: 0x06005177 RID: 20855
		[OperationContract(Action = "http://tempuri.org/IService/D_ManuFormulas", ReplyAction = "http://tempuri.org/IService/D_ManuFormulasResponse")]
		Task<ManuFormulas> D_ManuFormulasAsync(string uname, string value, string branch, int coid, string brservername, string brdownloadtime);

		// Token: 0x06005178 RID: 20856
		[OperationContract(Action = "http://tempuri.org/IService/D_ManuIngs", ReplyAction = "http://tempuri.org/IService/D_ManuIngsResponse")]
		ManuIng D_ManuIngs(string uname, string value, string branch, int coid, string brservername, string brdownloadtime);

		// Token: 0x06005179 RID: 20857
		[OperationContract(Action = "http://tempuri.org/IService/D_ManuIngs", ReplyAction = "http://tempuri.org/IService/D_ManuIngsResponse")]
		Task<ManuIng> D_ManuIngsAsync(string uname, string value, string branch, int coid, string brservername, string brdownloadtime);

		// Token: 0x0600517A RID: 20858
		[OperationContract(Action = "http://tempuri.org/IService/GetData", ReplyAction = "http://tempuri.org/IService/GetDataResponse")]
		bool GetData(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, decimal qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt);

		// Token: 0x0600517B RID: 20859
		[OperationContract(Action = "http://tempuri.org/IService/GetData", ReplyAction = "http://tempuri.org/IService/GetDataResponse")]
		Task<bool> GetDataAsync(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, decimal qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt);

		// Token: 0x0600517C RID: 20860
		[OperationContract(Action = "http://tempuri.org/IService/GetData3", ReplyAction = "http://tempuri.org/IService/GetData3Response")]
		string GetData3(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, decimal qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, int uploade2, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty, string Suppliername, string saletype, int usereceiptdisplay, int receiptdisplaymethod, int receiptdisplayrate, decimal discountamt, string consultant, string collection, decimal invdiscount, string discountdesc, int collected, decimal collectedqty, string collecteddate, string collectedby, string collectionEnteredBy, string collectionmachinename, int collectioncompleted, string collectioncompleteddate, string collectioncompletedenteredby, string hqservername, DateTime hquploadtime);

		// Token: 0x0600517D RID: 20861
		[OperationContract(Action = "http://tempuri.org/IService/GetData3", ReplyAction = "http://tempuri.org/IService/GetData3Response")]
		Task<string> GetData3Async(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, decimal qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, int uploade2, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty, string Suppliername, string saletype, int usereceiptdisplay, int receiptdisplaymethod, int receiptdisplayrate, decimal discountamt, string consultant, string collection, decimal invdiscount, string discountdesc, int collected, decimal collectedqty, string collecteddate, string collectedby, string collectionEnteredBy, string collectionmachinename, int collectioncompleted, string collectioncompleteddate, string collectioncompletedenteredby, string hqservername, DateTime hquploadtime);

		// Token: 0x0600517E RID: 20862
		[OperationContract(Action = "http://tempuri.org/IService/GetData4", ReplyAction = "http://tempuri.org/IService/GetData4Response")]
		string GetData4(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, decimal qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, int uploade2, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty, string Suppliername, string saletype, int usereceiptdisplay, int receiptdisplaymethod, decimal receiptdisplayrate, decimal discountamt, string consultant, string collection, decimal invdiscount, string discountdesc, int collected, decimal collectedqty, string collecteddate, string collectedby, string collectionEnteredBy, string collectionmachinename, int collectioncompleted, string collectioncompleteddate, string collectioncompletedenteredby, string hqservername, DateTime hquploadtime);

		// Token: 0x0600517F RID: 20863
		[OperationContract(Action = "http://tempuri.org/IService/GetData4", ReplyAction = "http://tempuri.org/IService/GetData4Response")]
		Task<string> GetData4Async(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, decimal qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, int uploade2, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty, string Suppliername, string saletype, int usereceiptdisplay, int receiptdisplaymethod, decimal receiptdisplayrate, decimal discountamt, string consultant, string collection, decimal invdiscount, string discountdesc, int collected, decimal collectedqty, string collecteddate, string collectedby, string collectionEnteredBy, string collectionmachinename, int collectioncompleted, string collectioncompleteddate, string collectioncompletedenteredby, string hqservername, DateTime hquploadtime);

		// Token: 0x06005180 RID: 20864
		[OperationContract(Action = "http://tempuri.org/IService/GetData5", ReplyAction = "http://tempuri.org/IService/GetData5Response")]
		string GetData5(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, decimal qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, int uploade2, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty, string Suppliername, string saletype, int usereceiptdisplay, int receiptdisplaymethod, decimal receiptdisplayrate, decimal discountamt, string consultant, string collection, decimal invdiscount, string discountdesc, int collected, decimal collectedqty, string collecteddate, string collectedby, string collectionEnteredBy, string collectionmachinename, int collectioncompleted, string collectioncompleteddate, string collectioncompletedenteredby, string hqservername, DateTime hquploadtime, string comments);

		// Token: 0x06005181 RID: 20865
		[OperationContract(Action = "http://tempuri.org/IService/GetData5", ReplyAction = "http://tempuri.org/IService/GetData5Response")]
		Task<string> GetData5Async(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, decimal qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, int uploade2, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty, string Suppliername, string saletype, int usereceiptdisplay, int receiptdisplaymethod, decimal receiptdisplayrate, decimal discountamt, string consultant, string collection, decimal invdiscount, string discountdesc, int collected, decimal collectedqty, string collecteddate, string collectedby, string collectionEnteredBy, string collectionmachinename, int collectioncompleted, string collectioncompleteddate, string collectioncompletedenteredby, string hqservername, DateTime hquploadtime, string comments);

		// Token: 0x06005182 RID: 20866
		[OperationContract(Action = "http://tempuri.org/IService/GetData6", ReplyAction = "http://tempuri.org/IService/GetData6Response")]
		string GetData6(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, decimal qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, int uploade2, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty, string Suppliername, string saletype, int usereceiptdisplay, int receiptdisplaymethod, decimal receiptdisplayrate, decimal discountamt, string consultant, string collection, decimal invdiscount, string discountdesc, int collected, decimal collectedqty, string collecteddate, string collectedby, string collectionEnteredBy, string collectionmachinename, int collectioncompleted, string collectioncompleteddate, string collectioncompletedenteredby, string hqservername, DateTime hquploadtime, string comments, bool isbranch);

		// Token: 0x06005183 RID: 20867
		[OperationContract(Action = "http://tempuri.org/IService/GetData6", ReplyAction = "http://tempuri.org/IService/GetData6Response")]
		Task<string> GetData6Async(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, decimal qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, int uploade2, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty, string Suppliername, string saletype, int usereceiptdisplay, int receiptdisplaymethod, decimal receiptdisplayrate, decimal discountamt, string consultant, string collection, decimal invdiscount, string discountdesc, int collected, decimal collectedqty, string collecteddate, string collectedby, string collectionEnteredBy, string collectionmachinename, int collectioncompleted, string collectioncompleteddate, string collectioncompletedenteredby, string hqservername, DateTime hquploadtime, string comments, bool isbranch);

		// Token: 0x06005184 RID: 20868
		[OperationContract(Action = "http://tempuri.org/IService/GetData7", ReplyAction = "http://tempuri.org/IService/GetData7Response")]
		string GetData7(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, decimal qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, int uploade2, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty, string Suppliername, string saletype, int usereceiptdisplay, int receiptdisplaymethod, decimal receiptdisplayrate, decimal discountamt, string consultant, string collection, decimal invdiscount, string discountdesc, int collected, decimal collectedqty, string collecteddate, string collectedby, string collectionEnteredBy, string collectionmachinename, int collectioncompleted, string collectioncompleteddate, string collectioncompletedenteredby, string hqservername, DateTime hquploadtime, string comments, bool isbranch);

		// Token: 0x06005185 RID: 20869
		[OperationContract(Action = "http://tempuri.org/IService/GetData7", ReplyAction = "http://tempuri.org/IService/GetData7Response")]
		Task<string> GetData7Async(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, decimal qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, int uploade2, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty, string Suppliername, string saletype, int usereceiptdisplay, int receiptdisplaymethod, decimal receiptdisplayrate, decimal discountamt, string consultant, string collection, decimal invdiscount, string discountdesc, int collected, decimal collectedqty, string collecteddate, string collectedby, string collectionEnteredBy, string collectionmachinename, int collectioncompleted, string collectioncompleteddate, string collectioncompletedenteredby, string hqservername, DateTime hquploadtime, string comments, bool isbranch);

		// Token: 0x06005186 RID: 20870
		[OperationContract(Action = "http://tempuri.org/IService/GetData8", ReplyAction = "http://tempuri.org/IService/GetData8Response")]
		string GetData8(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, decimal qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, int uploade2, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty, string Suppliername, string saletype, int usereceiptdisplay, int receiptdisplaymethod, decimal receiptdisplayrate, decimal discountamt, string consultant, string collection, decimal invdiscount, string discountdesc, int collected, decimal collectedqty, string collecteddate, string collectedby, string collectionEnteredBy, string collectionmachinename, int collectioncompleted, string collectioncompleteddate, string collectioncompletedenteredby, string hqservername, DateTime hquploadtime, string comments, bool isbranch, string source_servername);

		// Token: 0x06005187 RID: 20871
		[OperationContract(Action = "http://tempuri.org/IService/GetData8", ReplyAction = "http://tempuri.org/IService/GetData8Response")]
		Task<string> GetData8Async(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, decimal qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, int uploade2, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty, string Suppliername, string saletype, int usereceiptdisplay, int receiptdisplaymethod, decimal receiptdisplayrate, decimal discountamt, string consultant, string collection, decimal invdiscount, string discountdesc, int collected, decimal collectedqty, string collecteddate, string collectedby, string collectionEnteredBy, string collectionmachinename, int collectioncompleted, string collectioncompleteddate, string collectioncompletedenteredby, string hqservername, DateTime hquploadtime, string comments, bool isbranch, string source_servername);

		// Token: 0x06005188 RID: 20872
		[OperationContract(Action = "http://tempuri.org/IService/GetData9", ReplyAction = "http://tempuri.org/IService/GetData9Response")]
		string GetData9(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, decimal qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, int uploade2, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty, string Suppliername, string saletype, int usereceiptdisplay, int receiptdisplaymethod, decimal receiptdisplayrate, decimal discountamt, string consultant, string collection, decimal invdiscount, string discountdesc, int collected, decimal collectedqty, string collecteddate, string collectedby, string collectionEnteredBy, string collectionmachinename, int collectioncompleted, string collectioncompleteddate, string collectioncompletedenteredby, string hqservername, DateTime hquploadtime, string comments, bool isbranch, string source_servername, int isdownloadedtran, int downloaded_trans_entryno);

		// Token: 0x06005189 RID: 20873
		[OperationContract(Action = "http://tempuri.org/IService/GetData9", ReplyAction = "http://tempuri.org/IService/GetData9Response")]
		Task<string> GetData9Async(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, decimal qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, int uploade2, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty, string Suppliername, string saletype, int usereceiptdisplay, int receiptdisplaymethod, decimal receiptdisplayrate, decimal discountamt, string consultant, string collection, decimal invdiscount, string discountdesc, int collected, decimal collectedqty, string collecteddate, string collectedby, string collectionEnteredBy, string collectionmachinename, int collectioncompleted, string collectioncompleteddate, string collectioncompletedenteredby, string hqservername, DateTime hquploadtime, string comments, bool isbranch, string source_servername, int isdownloadedtran, int downloaded_trans_entryno);

		// Token: 0x0600518A RID: 20874
		[OperationContract(Action = "http://tempuri.org/IService/D_BranchProductDetails_Count", ReplyAction = "http://tempuri.org/IService/D_BranchProductDetails_CountResponse")]
		int D_BranchProductDetails_Count(string uname, string value, int coid, string branch);

		// Token: 0x0600518B RID: 20875
		[OperationContract(Action = "http://tempuri.org/IService/D_BranchProductDetails_Count", ReplyAction = "http://tempuri.org/IService/D_BranchProductDetails_CountResponse")]
		Task<int> D_BranchProductDetails_CountAsync(string uname, string value, int coid, string branch);

		// Token: 0x0600518C RID: 20876
		[OperationContract(Action = "http://tempuri.org/IService/D_MvtDataCount", ReplyAction = "http://tempuri.org/IService/D_MvtDataCountResponse")]
		int D_MvtDataCount(string uname, string value, string branch, int coid, string brservername);

		// Token: 0x0600518D RID: 20877
		[OperationContract(Action = "http://tempuri.org/IService/D_MvtDataCount", ReplyAction = "http://tempuri.org/IService/D_MvtDataCountResponse")]
		Task<int> D_MvtDataCountAsync(string uname, string value, string branch, int coid, string brservername);

		// Token: 0x0600518E RID: 20878
		[OperationContract(Action = "http://tempuri.org/IService/GetDataUsingDataContract", ReplyAction = "http://tempuri.org/IService/GetDataUsingDataContractResponse")]
		CompositeType GetDataUsingDataContract(CompositeType composite);

		// Token: 0x0600518F RID: 20879
		[OperationContract(Action = "http://tempuri.org/IService/GetDataUsingDataContract", ReplyAction = "http://tempuri.org/IService/GetDataUsingDataContractResponse")]
		Task<CompositeType> GetDataUsingDataContractAsync(CompositeType composite);

		// Token: 0x06005190 RID: 20880
		[OperationContract(Action = "http://tempuri.org/IService/LogUpload", ReplyAction = "http://tempuri.org/IService/LogUploadResponse")]
		bool LogUpload(string uname, string value, int trandate, int trantime, int numtrans, bool completed, int coid, string branch);

		// Token: 0x06005191 RID: 20881
		[OperationContract(Action = "http://tempuri.org/IService/LogUpload", ReplyAction = "http://tempuri.org/IService/LogUploadResponse")]
		Task<bool> LogUploadAsync(string uname, string value, int trandate, int trantime, int numtrans, bool completed, int coid, string branch);

		// Token: 0x06005192 RID: 20882
		[OperationContract(Action = "http://tempuri.org/IService/LogUploadUsingDataContract", ReplyAction = "http://tempuri.org/IService/LogUploadUsingDataContractResponse")]
		CompositeType LogUploadUsingDataContract(CompositeType composite);

		// Token: 0x06005193 RID: 20883
		[OperationContract(Action = "http://tempuri.org/IService/LogUploadUsingDataContract", ReplyAction = "http://tempuri.org/IService/LogUploadUsingDataContractResponse")]
		Task<CompositeType> LogUploadUsingDataContractAsync(CompositeType composite);

		// Token: 0x06005194 RID: 20884
		[OperationContract(Action = "http://tempuri.org/IService/UpdateData", ReplyAction = "http://tempuri.org/IService/UpdateDataResponse")]
		bool UpdateData(int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, int qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt);

		// Token: 0x06005195 RID: 20885
		[OperationContract(Action = "http://tempuri.org/IService/UpdateData", ReplyAction = "http://tempuri.org/IService/UpdateDataResponse")]
		Task<bool> UpdateDataAsync(int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, int qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt);

		// Token: 0x06005196 RID: 20886
		[OperationContract(Action = "http://tempuri.org/IService/UpdateDataDataContract", ReplyAction = "http://tempuri.org/IService/UpdateDataDataContractResponse")]
		CompositeType UpdateDataDataContract(CompositeType composite);

		// Token: 0x06005197 RID: 20887
		[OperationContract(Action = "http://tempuri.org/IService/UpdateDataDataContract", ReplyAction = "http://tempuri.org/IService/UpdateDataDataContractResponse")]
		Task<CompositeType> UpdateDataDataContractAsync(CompositeType composite);

		// Token: 0x06005198 RID: 20888
		[OperationContract(Action = "http://tempuri.org/IService/GetProdts1", ReplyAction = "http://tempuri.org/IService/GetProdts1Response")]
		string GetProdts1(string uname, string value, int productid, int catid, string productdesc, double cost, double sellingprice, int unitsperpack, int reorderlevel, string doneby, string donewhen, string productcode, string barcode, int uploaded, int coid, double taxrate, string UOM);

		// Token: 0x06005199 RID: 20889
		[OperationContract(Action = "http://tempuri.org/IService/GetProdts1", ReplyAction = "http://tempuri.org/IService/GetProdts1Response")]
		Task<string> GetProdts1Async(string uname, string value, int productid, int catid, string productdesc, double cost, double sellingprice, int unitsperpack, int reorderlevel, string doneby, string donewhen, string productcode, string barcode, int uploaded, int coid, double taxrate, string UOM);

		// Token: 0x0600519A RID: 20890
		[OperationContract(Action = "http://tempuri.org/IService/GetProdts2", ReplyAction = "http://tempuri.org/IService/GetProdts2Response")]
		string GetProdts2(string uname, string value, int productid, int catid, string productdesc, double cost, double sellingprice, int unitsperpack, int reorderlevel, string doneby, string donewhen, string productcode, string barcode, int uploaded, int coid, double taxrate, string UOM, decimal sellingpricewholesae, decimal wholesaleqty, int imported, string binlocation, int isactive, string productdesc2, decimal specialprice, int productexpires, int differentpricesperbranch, int isingridientonly, int pharmacydistributioncatgory, int pharmacyisperscription, int isunlimitedstockitem, int trans_entryno);

		// Token: 0x0600519B RID: 20891
		[OperationContract(Action = "http://tempuri.org/IService/GetProdts2", ReplyAction = "http://tempuri.org/IService/GetProdts2Response")]
		Task<string> GetProdts2Async(string uname, string value, int productid, int catid, string productdesc, double cost, double sellingprice, int unitsperpack, int reorderlevel, string doneby, string donewhen, string productcode, string barcode, int uploaded, int coid, double taxrate, string UOM, decimal sellingpricewholesae, decimal wholesaleqty, int imported, string binlocation, int isactive, string productdesc2, decimal specialprice, int productexpires, int differentpricesperbranch, int isingridientonly, int pharmacydistributioncatgory, int pharmacyisperscription, int isunlimitedstockitem, int trans_entryno);

		// Token: 0x0600519C RID: 20892
		[OperationContract(Action = "http://tempuri.org/IService/GetProductBranchDetails", ReplyAction = "http://tempuri.org/IService/GetProductBranchDetailsResponse")]
		string GetProductBranchDetails(string uname, string value, int productid, int catid, string productdesc, double cost, double sellingprice, int unitsperpack, int reorderlevel, string doneby, string donewhen, string productcode, string barcode, int uploaded, int coid, double taxrate, string UOM, decimal sellingpricewholesae, decimal wholesaleqty, int imported, string binlocation, int isactive, string productdesc2, decimal specialprice, int productexpires, int differentpricesperbranch, int isingridientonly, int pharmacydistributioncatgory, int pharmacyisperscription, int isunlimitedstockitem, string branch);

		// Token: 0x0600519D RID: 20893
		[OperationContract(Action = "http://tempuri.org/IService/GetProductBranchDetails", ReplyAction = "http://tempuri.org/IService/GetProductBranchDetailsResponse")]
		Task<string> GetProductBranchDetailsAsync(string uname, string value, int productid, int catid, string productdesc, double cost, double sellingprice, int unitsperpack, int reorderlevel, string doneby, string donewhen, string productcode, string barcode, int uploaded, int coid, double taxrate, string UOM, decimal sellingpricewholesae, decimal wholesaleqty, int imported, string binlocation, int isactive, string productdesc2, decimal specialprice, int productexpires, int differentpricesperbranch, int isingridientonly, int pharmacydistributioncatgory, int pharmacyisperscription, int isunlimitedstockitem, string branch);

		// Token: 0x0600519E RID: 20894
		[OperationContract(Action = "http://tempuri.org/IService/UpdateProdts", ReplyAction = "http://tempuri.org/IService/UpdateProdtsResponse")]
		string UpdateProdts(string uname, string value, int productid, int catid, string productdesc, double cost, double sellingprice, int unitsperpack, int reorderlevel, string doneby, string donewhen, string productcode, string barcode, int uploaded, int coid, double taxrate);

		// Token: 0x0600519F RID: 20895
		[OperationContract(Action = "http://tempuri.org/IService/UpdateProdts", ReplyAction = "http://tempuri.org/IService/UpdateProdtsResponse")]
		Task<string> UpdateProdtsAsync(string uname, string value, int productid, int catid, string productdesc, double cost, double sellingprice, int unitsperpack, int reorderlevel, string doneby, string donewhen, string productcode, string barcode, int uploaded, int coid, double taxrate);

		// Token: 0x060051A0 RID: 20896
		[OperationContract(Action = "http://tempuri.org/IService/GetExpenses", ReplyAction = "http://tempuri.org/IService/GetExpensesResponse")]
		bool GetExpenses(string uname, string value, int ExpenseDate, string Description, double Cost, int entryno, int uploaded, int coid, string branch);

		// Token: 0x060051A1 RID: 20897
		[OperationContract(Action = "http://tempuri.org/IService/GetExpenses", ReplyAction = "http://tempuri.org/IService/GetExpensesResponse")]
		Task<bool> GetExpensesAsync(string uname, string value, int ExpenseDate, string Description, double Cost, int entryno, int uploaded, int coid, string branch);

		// Token: 0x060051A2 RID: 20898
		[OperationContract(Action = "http://tempuri.org/IService/GetExpenses2", ReplyAction = "http://tempuri.org/IService/GetExpenses2Response")]
		bool GetExpenses2(string uname, string value, int ExpenseDate, string Description, double Cost, int entryno, int uploaded, int coid, string branch, decimal rate, int paymentmethodid, int expensecategoryid, int fromtill, string tilloperator);

		// Token: 0x060051A3 RID: 20899
		[OperationContract(Action = "http://tempuri.org/IService/GetExpenses2", ReplyAction = "http://tempuri.org/IService/GetExpenses2Response")]
		Task<bool> GetExpenses2Async(string uname, string value, int ExpenseDate, string Description, double Cost, int entryno, int uploaded, int coid, string branch, decimal rate, int paymentmethodid, int expensecategoryid, int fromtill, string tilloperator);

		// Token: 0x060051A4 RID: 20900
		[OperationContract(Action = "http://tempuri.org/IService/UpdateExpenses", ReplyAction = "http://tempuri.org/IService/UpdateExpensesResponse")]
		bool UpdateExpenses(string uname, string value, int ExpenseDate, string Description, double Cost, int entryno, int uploaded, int coid, string branch);

		// Token: 0x060051A5 RID: 20901
		[OperationContract(Action = "http://tempuri.org/IService/UpdateExpenses", ReplyAction = "http://tempuri.org/IService/UpdateExpensesResponse")]
		Task<bool> UpdateExpensesAsync(string uname, string value, int ExpenseDate, string Description, double Cost, int entryno, int uploaded, int coid, string branch);

		// Token: 0x060051A6 RID: 20902
		[OperationContract(Action = "http://tempuri.org/IService/GetCat1", ReplyAction = "http://tempuri.org/IService/GetCat1Response")]
		bool GetCat1(string uname, string value, int CatID, string Description, int uploaded, int coid);

		// Token: 0x060051A7 RID: 20903
		[OperationContract(Action = "http://tempuri.org/IService/GetCat1", ReplyAction = "http://tempuri.org/IService/GetCat1Response")]
		Task<bool> GetCat1Async(string uname, string value, int CatID, string Description, int uploaded, int coid);

		// Token: 0x060051A8 RID: 20904
		[OperationContract(Action = "http://tempuri.org/IService/GetCat2", ReplyAction = "http://tempuri.org/IService/GetCat2Response")]
		string GetCat2(string uname, string value, int CatID, string Description, int uploaded, int coid, int trans_entryno);

		// Token: 0x060051A9 RID: 20905
		[OperationContract(Action = "http://tempuri.org/IService/GetCat2", ReplyAction = "http://tempuri.org/IService/GetCat2Response")]
		Task<string> GetCat2Async(string uname, string value, int CatID, string Description, int uploaded, int coid, int trans_entryno);

		// Token: 0x060051AA RID: 20906
		[OperationContract(Action = "http://tempuri.org/IService/GetCat3", ReplyAction = "http://tempuri.org/IService/GetCat3Response")]
		string GetCat3(string uname, string value, int CatID, string Description, int uploaded, int coid, string branch, string hqservername);

		// Token: 0x060051AB RID: 20907
		[OperationContract(Action = "http://tempuri.org/IService/GetCat3", ReplyAction = "http://tempuri.org/IService/GetCat3Response")]
		Task<string> GetCat3Async(string uname, string value, int CatID, string Description, int uploaded, int coid, string branch, string hqservername);

		// Token: 0x060051AC RID: 20908
		[OperationContract(Action = "http://tempuri.org/IService/UpdateCat", ReplyAction = "http://tempuri.org/IService/UpdateCatResponse")]
		bool UpdateCat(string uname, string value, int CatID, string Description, int uploaded, int coid);

		// Token: 0x060051AD RID: 20909
		[OperationContract(Action = "http://tempuri.org/IService/UpdateCat", ReplyAction = "http://tempuri.org/IService/UpdateCatResponse")]
		Task<bool> UpdateCatAsync(string uname, string value, int CatID, string Description, int uploaded, int coid);

		// Token: 0x060051AE RID: 20910
		[OperationContract(Action = "http://tempuri.org/IService/GetCo", ReplyAction = "http://tempuri.org/IService/GetCoResponse")]
		bool GetCo(string uname, string value, string company, string Address, string tel, int entryno, string BranchName, int CompanyID, int uploaded, int coid, string branch);

		// Token: 0x060051AF RID: 20911
		[OperationContract(Action = "http://tempuri.org/IService/GetCo", ReplyAction = "http://tempuri.org/IService/GetCoResponse")]
		Task<bool> GetCoAsync(string uname, string value, string company, string Address, string tel, int entryno, string BranchName, int CompanyID, int uploaded, int coid, string branch);

		// Token: 0x060051B0 RID: 20912
		[OperationContract(Action = "http://tempuri.org/IService/UpdateCo", ReplyAction = "http://tempuri.org/IService/UpdateCoResponse")]
		bool UpdateCo(string uname, string value, string company, string Address, string tel, int entryno, string BranchName, int CompanyID, int uploaded, int coid, string branch);

		// Token: 0x060051B1 RID: 20913
		[OperationContract(Action = "http://tempuri.org/IService/UpdateCo", ReplyAction = "http://tempuri.org/IService/UpdateCoResponse")]
		Task<bool> UpdateCoAsync(string uname, string value, string company, string Address, string tel, int entryno, string BranchName, int CompanyID, int uploaded, int coid, string branch);

		// Token: 0x060051B2 RID: 20914
		[OperationContract(Action = "http://tempuri.org/IService/GetCus", ReplyAction = "http://tempuri.org/IService/GetCusResponse")]
		bool GetCus(string uname, string value, string CustomerName, string Address, string ContactName, string Mobile, string Email, int Uploaded, int Entryno, int coid, string branch);

		// Token: 0x060051B3 RID: 20915
		[OperationContract(Action = "http://tempuri.org/IService/GetCus", ReplyAction = "http://tempuri.org/IService/GetCusResponse")]
		Task<bool> GetCusAsync(string uname, string value, string CustomerName, string Address, string ContactName, string Mobile, string Email, int Uploaded, int Entryno, int coid, string branch);

		// Token: 0x060051B4 RID: 20916
		[OperationContract(Action = "http://tempuri.org/IService/GetCus2", ReplyAction = "http://tempuri.org/IService/GetCus2Response")]
		bool GetCus2(string uname, string value, string CustomerName, string Address, string ContactName, string Mobile, string Email, int Uploaded, int Entryno, int coid, string branch, string invoicedetails1, string invoicedetails2, int tel, string idnumber, DateTime dob, string sex, DateTime datecreated, string createdby);

		// Token: 0x060051B5 RID: 20917
		[OperationContract(Action = "http://tempuri.org/IService/GetCus2", ReplyAction = "http://tempuri.org/IService/GetCus2Response")]
		Task<bool> GetCus2Async(string uname, string value, string CustomerName, string Address, string ContactName, string Mobile, string Email, int Uploaded, int Entryno, int coid, string branch, string invoicedetails1, string invoicedetails2, int tel, string idnumber, DateTime dob, string sex, DateTime datecreated, string createdby);

		// Token: 0x060051B6 RID: 20918
		[OperationContract(Action = "http://tempuri.org/IService/UpdateCus", ReplyAction = "http://tempuri.org/IService/UpdateCusResponse")]
		bool UpdateCus(string uname, string value, string CustomerName, string Address, string ContactName, string Mobile, string Email, int Uploaded, int Entryno, int coid, string branch);

		// Token: 0x060051B7 RID: 20919
		[OperationContract(Action = "http://tempuri.org/IService/UpdateCus", ReplyAction = "http://tempuri.org/IService/UpdateCusResponse")]
		Task<bool> UpdateCusAsync(string uname, string value, string CustomerName, string Address, string ContactName, string Mobile, string Email, int Uploaded, int Entryno, int coid, string branch);

		// Token: 0x060051B8 RID: 20920
		[OperationContract(Action = "http://tempuri.org/IService/GetPay1", ReplyAction = "http://tempuri.org/IService/GetPay1Response")]
		bool GetPay1(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, int uploaded, int coid);

		// Token: 0x060051B9 RID: 20921
		[OperationContract(Action = "http://tempuri.org/IService/GetPay1", ReplyAction = "http://tempuri.org/IService/GetPay1Response")]
		Task<bool> GetPay1Async(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, int uploaded, int coid);

		// Token: 0x060051BA RID: 20922
		[OperationContract(Action = "http://tempuri.org/IService/GetPay2", ReplyAction = "http://tempuri.org/IService/GetPay2Response")]
		string GetPay2(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int uploaded, int coid, int fiscalgroup, string currency, decimal discountperc, int trans_entryno);

		// Token: 0x060051BB RID: 20923
		[OperationContract(Action = "http://tempuri.org/IService/GetPay2", ReplyAction = "http://tempuri.org/IService/GetPay2Response")]
		Task<string> GetPay2Async(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int uploaded, int coid, int fiscalgroup, string currency, decimal discountperc, int trans_entryno);

		// Token: 0x060051BC RID: 20924
		[OperationContract(Action = "http://tempuri.org/IService/GetPay3", ReplyAction = "http://tempuri.org/IService/GetPay3Response")]
		string GetPay3(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int uploaded, int coid, int fiscalgroup, string currency, decimal discountperc, int trans_entryno, string branch, string hqservername);

		// Token: 0x060051BD RID: 20925
		[OperationContract(Action = "http://tempuri.org/IService/GetPay3", ReplyAction = "http://tempuri.org/IService/GetPay3Response")]
		Task<string> GetPay3Async(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int uploaded, int coid, int fiscalgroup, string currency, decimal discountperc, int trans_entryno, string branch, string hqservername);

		// Token: 0x060051BE RID: 20926
		[OperationContract(Action = "http://tempuri.org/IService/GetPay4", ReplyAction = "http://tempuri.org/IService/GetPay4Response")]
		string GetPay4(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int uploaded, int coid, int fiscalgroup, string currency, decimal discountperc, int trans_entryno, string branch, string hqservername, int currencyideltrate);

		// Token: 0x060051BF RID: 20927
		[OperationContract(Action = "http://tempuri.org/IService/GetPay4", ReplyAction = "http://tempuri.org/IService/GetPay4Response")]
		Task<string> GetPay4Async(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int uploaded, int coid, int fiscalgroup, string currency, decimal discountperc, int trans_entryno, string branch, string hqservername, int currencyideltrate);

		// Token: 0x060051C0 RID: 20928
		[OperationContract(Action = "http://tempuri.org/IService/UpdatePay", ReplyAction = "http://tempuri.org/IService/UpdatePayResponse")]
		bool UpdatePay(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, int uploaded, int coid);

		// Token: 0x060051C1 RID: 20929
		[OperationContract(Action = "http://tempuri.org/IService/UpdatePay", ReplyAction = "http://tempuri.org/IService/UpdatePayResponse")]
		Task<bool> UpdatePayAsync(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, int uploaded, int coid);

		// Token: 0x060051C2 RID: 20930
		[OperationContract(Action = "http://tempuri.org/IService/GetPayActual", ReplyAction = "http://tempuri.org/IService/GetPayActualResponse")]
		bool GetPayActual(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, int InvoiceNumber, double AmountPaid, int EntryNo, int uploaded, int coid, string branch);

		// Token: 0x060051C3 RID: 20931
		[OperationContract(Action = "http://tempuri.org/IService/GetPayActual", ReplyAction = "http://tempuri.org/IService/GetPayActualResponse")]
		Task<bool> GetPayActualAsync(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, int InvoiceNumber, double AmountPaid, int EntryNo, int uploaded, int coid, string branch);

		// Token: 0x060051C4 RID: 20932
		[OperationContract(Action = "http://tempuri.org/IService/UpdatePayActual", ReplyAction = "http://tempuri.org/IService/UpdatePayActualResponse")]
		bool UpdatePayActual(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, int InvoiceNumber, double AmountPaid, int EntryNo, int uploaded, int coid, string branch);

		// Token: 0x060051C5 RID: 20933
		[OperationContract(Action = "http://tempuri.org/IService/UpdatePayActual", ReplyAction = "http://tempuri.org/IService/UpdatePayActualResponse")]
		Task<bool> UpdatePayActualAsync(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, int InvoiceNumber, double AmountPaid, int EntryNo, int uploaded, int coid, string branch);

		// Token: 0x060051C6 RID: 20934
		[OperationContract(Action = "http://tempuri.org/IService/GetDel", ReplyAction = "http://tempuri.org/IService/GetDelResponse")]
		bool GetDel(string uname, string value, string TBName, string KeyColumn, string KeyColumnType, string KeyValue, int EntryNo, int uploaded, int coid, string branch);

		// Token: 0x060051C7 RID: 20935
		[OperationContract(Action = "http://tempuri.org/IService/GetDel", ReplyAction = "http://tempuri.org/IService/GetDelResponse")]
		Task<bool> GetDelAsync(string uname, string value, string TBName, string KeyColumn, string KeyColumnType, string KeyValue, int EntryNo, int uploaded, int coid, string branch);

		// Token: 0x060051C8 RID: 20936
		[OperationContract(Action = "http://tempuri.org/IService/GetDel2", ReplyAction = "http://tempuri.org/IService/GetDel2Response")]
		string GetDel2(string uname, string value, string TBName, string KeyColumn, string KeyColumnType, string KeyValue, int EntryNo, int uploaded, int coid, string branch, string hqservername, string hquploadtime);

		// Token: 0x060051C9 RID: 20937
		[OperationContract(Action = "http://tempuri.org/IService/GetDel2", ReplyAction = "http://tempuri.org/IService/GetDel2Response")]
		Task<string> GetDel2Async(string uname, string value, string TBName, string KeyColumn, string KeyColumnType, string KeyValue, int EntryNo, int uploaded, int coid, string branch, string hqservername, string hquploadtime);

		// Token: 0x060051CA RID: 20938
		[OperationContract(Action = "http://tempuri.org/IService/SalesSumm", ReplyAction = "http://tempuri.org/IService/SalesSummResponse")]
		DataTable SalesSumm(string uname, string value, int coid, int theday);

		// Token: 0x060051CB RID: 20939
		[OperationContract(Action = "http://tempuri.org/IService/SalesSumm", ReplyAction = "http://tempuri.org/IService/SalesSummResponse")]
		Task<DataTable> SalesSummAsync(string uname, string value, int coid, int theday);

		// Token: 0x060051CC RID: 20940
		[OperationContract(Action = "http://tempuri.org/IService/GetSalesSummary", ReplyAction = "http://tempuri.org/IService/GetSalesSummaryResponse")]
		SalesSummaryData GetSalesSummary(string uname, string value, int coid, int theday);

		// Token: 0x060051CD RID: 20941
		[OperationContract(Action = "http://tempuri.org/IService/GetSalesSummary", ReplyAction = "http://tempuri.org/IService/GetSalesSummaryResponse")]
		Task<SalesSummaryData> GetSalesSummaryAsync(string uname, string value, int coid, int theday);

		// Token: 0x060051CE RID: 20942
		[OperationContract(Action = "http://tempuri.org/IService/UpdateProdtPrice", ReplyAction = "http://tempuri.org/IService/UpdateProdtPriceResponse")]
		PricesData UpdateProdtPrice(string uname, string value, int coid);

		// Token: 0x060051CF RID: 20943
		[OperationContract(Action = "http://tempuri.org/IService/UpdateProdtPrice", ReplyAction = "http://tempuri.org/IService/UpdateProdtPriceResponse")]
		Task<PricesData> UpdateProdtPriceAsync(string uname, string value, int coid);

		// Token: 0x060051D0 RID: 20944
		[OperationContract(Action = "http://tempuri.org/IService/UpdatePaymethRates", ReplyAction = "http://tempuri.org/IService/UpdatePaymethRatesResponse")]
		PaymethrateData UpdatePaymethRates(string uname, string value, int coid);

		// Token: 0x060051D1 RID: 20945
		[OperationContract(Action = "http://tempuri.org/IService/UpdatePaymethRates", ReplyAction = "http://tempuri.org/IService/UpdatePaymethRatesResponse")]
		Task<PaymethrateData> UpdatePaymethRatesAsync(string uname, string value, int coid);

		// Token: 0x060051D2 RID: 20946
		[OperationContract(Action = "http://tempuri.org/IService/CountPriceChanges", ReplyAction = "http://tempuri.org/IService/CountPriceChangesResponse")]
		string CountPriceChanges(string uname, string value, int coid, int theday);

		// Token: 0x060051D3 RID: 20947
		[OperationContract(Action = "http://tempuri.org/IService/CountPriceChanges", ReplyAction = "http://tempuri.org/IService/CountPriceChangesResponse")]
		Task<string> CountPriceChangesAsync(string uname, string value, int coid, int theday);

		// Token: 0x060051D4 RID: 20948
		[OperationContract(Action = "http://tempuri.org/IService/CountRateChanges", ReplyAction = "http://tempuri.org/IService/CountRateChangesResponse")]
		string CountRateChanges(string uname, string value, int coid);

		// Token: 0x060051D5 RID: 20949
		[OperationContract(Action = "http://tempuri.org/IService/CountRateChanges", ReplyAction = "http://tempuri.org/IService/CountRateChangesResponse")]
		Task<string> CountRateChangesAsync(string uname, string value, int coid);

		// Token: 0x060051D6 RID: 20950
		[OperationContract(Action = "http://tempuri.org/IService/MarkPricesDownloaded", ReplyAction = "http://tempuri.org/IService/MarkPricesDownloadedResponse")]
		bool MarkPricesDownloaded(string uname, string value, int coid, int entryno, string dtime, int ddate);

		// Token: 0x060051D7 RID: 20951
		[OperationContract(Action = "http://tempuri.org/IService/MarkPricesDownloaded", ReplyAction = "http://tempuri.org/IService/MarkPricesDownloadedResponse")]
		Task<bool> MarkPricesDownloadedAsync(string uname, string value, int coid, int entryno, string dtime, int ddate);

		// Token: 0x060051D8 RID: 20952
		[OperationContract(Action = "http://tempuri.org/IService/MarkRatesDownloaded", ReplyAction = "http://tempuri.org/IService/MarkRatesDownloadedResponse")]
		bool MarkRatesDownloaded(string uname, string value, int coid, int entryno, string dtime, int ddate);

		// Token: 0x060051D9 RID: 20953
		[OperationContract(Action = "http://tempuri.org/IService/MarkRatesDownloaded", ReplyAction = "http://tempuri.org/IService/MarkRatesDownloadedResponse")]
		Task<bool> MarkRatesDownloadedAsync(string uname, string value, int coid, int entryno, string dtime, int ddate);

		// Token: 0x060051DA RID: 20954
		[OperationContract(Action = "http://tempuri.org/IService/GetNewStocksPurchased", ReplyAction = "http://tempuri.org/IService/GetNewStocksPurchasedResponse")]
		NewStocksData GetNewStocksPurchased(string uname, string value, int coid);

		// Token: 0x060051DB RID: 20955
		[OperationContract(Action = "http://tempuri.org/IService/GetNewStocksPurchased", ReplyAction = "http://tempuri.org/IService/GetNewStocksPurchasedResponse")]
		Task<NewStocksData> GetNewStocksPurchasedAsync(string uname, string value, int coid);

		// Token: 0x060051DC RID: 20956
		[OperationContract(Action = "http://tempuri.org/IService/CountNewStocksPurchased", ReplyAction = "http://tempuri.org/IService/CountNewStocksPurchasedResponse")]
		string CountNewStocksPurchased(string uname, string value, int coid, int theday);

		// Token: 0x060051DD RID: 20957
		[OperationContract(Action = "http://tempuri.org/IService/CountNewStocksPurchased", ReplyAction = "http://tempuri.org/IService/CountNewStocksPurchasedResponse")]
		Task<string> CountNewStocksPurchasedAsync(string uname, string value, int coid, int theday);

		// Token: 0x060051DE RID: 20958
		[OperationContract(Action = "http://tempuri.org/IService/MarkNewStockPurchaseDownloaded", ReplyAction = "http://tempuri.org/IService/MarkNewStockPurchaseDownloadedResponse")]
		bool MarkNewStockPurchaseDownloaded(string uname, string value, int coid, int entryno, string dtime, int ddate);

		// Token: 0x060051DF RID: 20959
		[OperationContract(Action = "http://tempuri.org/IService/MarkNewStockPurchaseDownloaded", ReplyAction = "http://tempuri.org/IService/MarkNewStockPurchaseDownloadedResponse")]
		Task<bool> MarkNewStockPurchaseDownloadedAsync(string uname, string value, int coid, int entryno, string dtime, int ddate);

		// Token: 0x060051E0 RID: 20960
		[OperationContract(Action = "http://tempuri.org/IService/GetNewOnlineStockTransfers", ReplyAction = "http://tempuri.org/IService/GetNewOnlineStockTransfersResponse")]
		NewOnlineStockTransfersData GetNewOnlineStockTransfers(string uname, string value, int coid, string branch, int ishq);

		// Token: 0x060051E1 RID: 20961
		[OperationContract(Action = "http://tempuri.org/IService/GetNewOnlineStockTransfers", ReplyAction = "http://tempuri.org/IService/GetNewOnlineStockTransfersResponse")]
		Task<NewOnlineStockTransfersData> GetNewOnlineStockTransfersAsync(string uname, string value, int coid, string branch, int ishq);

		// Token: 0x060051E2 RID: 20962
		[OperationContract(Action = "http://tempuri.org/IService/MarkOnlineStockTransferDownloaded", ReplyAction = "http://tempuri.org/IService/MarkOnlineStockTransferDownloadedResponse")]
		bool MarkOnlineStockTransferDownloaded(string uname, string value, int coid, string branch, int entryno, string downloadedtime, string machinename);

		// Token: 0x060051E3 RID: 20963
		[OperationContract(Action = "http://tempuri.org/IService/MarkOnlineStockTransferDownloaded", ReplyAction = "http://tempuri.org/IService/MarkOnlineStockTransferDownloadedResponse")]
		Task<bool> MarkOnlineStockTransferDownloadedAsync(string uname, string value, int coid, string branch, int entryno, string downloadedtime, string machinename);

		// Token: 0x060051E4 RID: 20964
		[OperationContract(Action = "http://tempuri.org/IService/GetConnectedBranchStatus", ReplyAction = "http://tempuri.org/IService/GetConnectedBranchStatusResponse")]
		ConnectedBranchStatus GetConnectedBranchStatus(string uname, string value, int coid);

		// Token: 0x060051E5 RID: 20965
		[OperationContract(Action = "http://tempuri.org/IService/GetConnectedBranchStatus", ReplyAction = "http://tempuri.org/IService/GetConnectedBranchStatusResponse")]
		Task<ConnectedBranchStatus> GetConnectedBranchStatusAsync(string uname, string value, int coid);

		// Token: 0x060051E6 RID: 20966
		[OperationContract(Action = "http://tempuri.org/IService/SetCommandForBranch", ReplyAction = "http://tempuri.org/IService/SetCommandForBranchResponse")]
		bool SetCommandForBranch(string uname, string value, int coid, string branch, string commandname, DateTime trandatetime);

		// Token: 0x060051E7 RID: 20967
		[OperationContract(Action = "http://tempuri.org/IService/SetCommandForBranch", ReplyAction = "http://tempuri.org/IService/SetCommandForBranchResponse")]
		Task<bool> SetCommandForBranchAsync(string uname, string value, int coid, string branch, string commandname, DateTime trandatetime);

		// Token: 0x060051E8 RID: 20968
		[OperationContract(Action = "http://tempuri.org/IService/GetCommandForBranch", ReplyAction = "http://tempuri.org/IService/GetCommandForBranchResponse")]
		string GetCommandForBranch(string uname, string value, int coid, string branch);

		// Token: 0x060051E9 RID: 20969
		[OperationContract(Action = "http://tempuri.org/IService/GetCommandForBranch", ReplyAction = "http://tempuri.org/IService/GetCommandForBranchResponse")]
		Task<string> GetCommandForBranchAsync(string uname, string value, int coid, string branch);

		// Token: 0x060051EA RID: 20970
		[OperationContract(Action = "http://tempuri.org/IService/UpdateCommandForBranch", ReplyAction = "http://tempuri.org/IService/UpdateCommandForBranchResponse")]
		string UpdateCommandForBranch(string uname, string value, int coid, string branch, int entryno);

		// Token: 0x060051EB RID: 20971
		[OperationContract(Action = "http://tempuri.org/IService/UpdateCommandForBranch", ReplyAction = "http://tempuri.org/IService/UpdateCommandForBranchResponse")]
		Task<string> UpdateCommandForBranchAsync(string uname, string value, int coid, string branch, int entryno);

		// Token: 0x060051EC RID: 20972
		[OperationContract(Action = "http://tempuri.org/IService/UpdatePay2", ReplyAction = "http://tempuri.org/IService/UpdatePay2Response")]
		bool UpdatePay2(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int uploaded, int coid);

		// Token: 0x060051ED RID: 20973
		[OperationContract(Action = "http://tempuri.org/IService/UpdatePay2", ReplyAction = "http://tempuri.org/IService/UpdatePay2Response")]
		Task<bool> UpdatePay2Async(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int uploaded, int coid);

		// Token: 0x060051EE RID: 20974
		[OperationContract(Action = "http://tempuri.org/IService/GetPayActual2", ReplyAction = "http://tempuri.org/IService/GetPayActual2Response")]
		bool GetPayActual2(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int InvoiceNumber, double AmountPaid, int EntryNo, int uploaded, int coid, string branch);

		// Token: 0x060051EF RID: 20975
		[OperationContract(Action = "http://tempuri.org/IService/GetPayActual2", ReplyAction = "http://tempuri.org/IService/GetPayActual2Response")]
		Task<bool> GetPayActual2Async(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int InvoiceNumber, double AmountPaid, int EntryNo, int uploaded, int coid, string branch);

		// Token: 0x060051F0 RID: 20976
		[OperationContract(Action = "http://tempuri.org/IService/GetPayActual3", ReplyAction = "http://tempuri.org/IService/GetPayActual3Response")]
		bool GetPayActual3(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int InvoiceNumber, double AmountPaid, int EntryNo, int uploaded, int coid, string branch, decimal disc, string trantype);

		// Token: 0x060051F1 RID: 20977
		[OperationContract(Action = "http://tempuri.org/IService/GetPayActual3", ReplyAction = "http://tempuri.org/IService/GetPayActual3Response")]
		Task<bool> GetPayActual3Async(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int InvoiceNumber, double AmountPaid, int EntryNo, int uploaded, int coid, string branch, decimal disc, string trantype);

		// Token: 0x060051F2 RID: 20978
		[OperationContract(Action = "http://tempuri.org/IService/GetPayActual4", ReplyAction = "http://tempuri.org/IService/GetPayActual4Response")]
		bool GetPayActual4(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int InvoiceNumber, double AmountPaid, int EntryNo, int uploaded, int coid, string branch, decimal disc, string trantype, string hqservername, DateTime hquploadtime);

		// Token: 0x060051F3 RID: 20979
		[OperationContract(Action = "http://tempuri.org/IService/GetPayActual4", ReplyAction = "http://tempuri.org/IService/GetPayActual4Response")]
		Task<bool> GetPayActual4Async(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int InvoiceNumber, double AmountPaid, int EntryNo, int uploaded, int coid, string branch, decimal disc, string trantype, string hqservername, DateTime hquploadtime);

		// Token: 0x060051F4 RID: 20980
		[OperationContract(Action = "http://tempuri.org/IService/GetPayActual5", ReplyAction = "http://tempuri.org/IService/GetPayActual5Response")]
		bool GetPayActual5(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int InvoiceNumber, double AmountPaid, int EntryNo, int uploaded, int coid, string branch, decimal disc, string trantype, string hqservername, DateTime hquploadtime, int trandate);

		// Token: 0x060051F5 RID: 20981
		[OperationContract(Action = "http://tempuri.org/IService/GetPayActual5", ReplyAction = "http://tempuri.org/IService/GetPayActual5Response")]
		Task<bool> GetPayActual5Async(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int InvoiceNumber, double AmountPaid, int EntryNo, int uploaded, int coid, string branch, decimal disc, string trantype, string hqservername, DateTime hquploadtime, int trandate);

		// Token: 0x060051F6 RID: 20982
		[OperationContract(Action = "http://tempuri.org/IService/UpdatePayActual2", ReplyAction = "http://tempuri.org/IService/UpdatePayActual2Response")]
		bool UpdatePayActual2(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int InvoiceNumber, double AmountPaid, int EntryNo, int uploaded, int coid, string branch);

		// Token: 0x060051F7 RID: 20983
		[OperationContract(Action = "http://tempuri.org/IService/UpdatePayActual2", ReplyAction = "http://tempuri.org/IService/UpdatePayActual2Response")]
		Task<bool> UpdatePayActual2Async(string uname, string value, int PaymentMethodID, string PaymentMethodDesc, decimal rate, int InvoiceNumber, double AmountPaid, int EntryNo, int uploaded, int coid, string branch);

		// Token: 0x060051F8 RID: 20984
		[OperationContract(Action = "http://tempuri.org/IService/GetData2", ReplyAction = "http://tempuri.org/IService/GetData2Response")]
		bool GetData2(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, int qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty);

		// Token: 0x060051F9 RID: 20985
		[OperationContract(Action = "http://tempuri.org/IService/GetData2", ReplyAction = "http://tempuri.org/IService/GetData2Response")]
		Task<bool> GetData2Async(string uname, string value, int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, int qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty);

		// Token: 0x060051FA RID: 20986
		[OperationContract(Action = "http://tempuri.org/IService/UpdateData2", ReplyAction = "http://tempuri.org/IService/UpdateData2Response")]
		bool UpdateData2(int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, int qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty);

		// Token: 0x060051FB RID: 20987
		[OperationContract(Action = "http://tempuri.org/IService/UpdateData2", ReplyAction = "http://tempuri.org/IService/UpdateData2Response")]
		Task<bool> UpdateData2Async(int entryno, int invnum, int trandate, int prodid, int isstockin, string @ref, int qty, double cost, double sellingprice, string doneby, int donewhen, int paymeth, int trancode, int datecancelled, string cancelledby, string prodcode, string trandesc, int uploaded, int trantime, int coid, string branch, double taxamt, string shift, int shiftdate, string otherdetail, string batchnumber, int expirydate, int iswholesaleprice, int iswholesalepriceqty);

		// Token: 0x060051FC RID: 20988
		[OperationContract(Action = "http://tempuri.org/IService/FetchPayMethRatesChanged", ReplyAction = "http://tempuri.org/IService/FetchPayMethRatesChangedResponse")]
		PayMethRates FetchPayMethRatesChanged(string uname, string value, int coid);

		// Token: 0x060051FD RID: 20989
		[OperationContract(Action = "http://tempuri.org/IService/FetchPayMethRatesChanged", ReplyAction = "http://tempuri.org/IService/FetchPayMethRatesChangedResponse")]
		Task<PayMethRates> FetchPayMethRatesChangedAsync(string uname, string value, int coid);

		// Token: 0x060051FE RID: 20990
		[OperationContract(Action = "http://tempuri.org/IService/UpdatePayMethRatesChanged", ReplyAction = "http://tempuri.org/IService/UpdatePayMethRatesChangedResponse")]
		bool UpdatePayMethRatesChanged(string uname, string value, int coid, int entryno, int downloadeddate, string downloadedtime);

		// Token: 0x060051FF RID: 20991
		[OperationContract(Action = "http://tempuri.org/IService/UpdatePayMethRatesChanged", ReplyAction = "http://tempuri.org/IService/UpdatePayMethRatesChangedResponse")]
		Task<bool> UpdatePayMethRatesChangedAsync(string uname, string value, int coid, int entryno, int downloadeddate, string downloadedtime);

		// Token: 0x06005200 RID: 20992
		[OperationContract(Action = "http://tempuri.org/IService/MFAuthenticateUser", ReplyAction = "http://tempuri.org/IService/MFAuthenticateUserResponse")]
		string MFAuthenticateUser(string uname, string value, string dtime, int ddate, int cardnum, string pin);

		// Token: 0x06005201 RID: 20993
		[OperationContract(Action = "http://tempuri.org/IService/MFAuthenticateUser", ReplyAction = "http://tempuri.org/IService/MFAuthenticateUserResponse")]
		Task<string> MFAuthenticateUserAsync(string uname, string value, string dtime, int ddate, int cardnum, string pin);

		// Token: 0x06005202 RID: 20994
		[OperationContract(Action = "http://tempuri.org/IService/FetchUsers", ReplyAction = "http://tempuri.org/IService/FetchUsersResponse")]
		string FetchUsers(string uname, string value, string username, string password, int isadmin, int entryno, int coid, int issup, string branch, string isallbranches, string realname, string createdby, int datecreated, int isactive, string deactivatedby, int deactivateddate, int uploaded, int trans_entryno, string hqservername, string uploadingbranch);

		// Token: 0x06005203 RID: 20995
		[OperationContract(Action = "http://tempuri.org/IService/FetchUsers", ReplyAction = "http://tempuri.org/IService/FetchUsersResponse")]
		Task<string> FetchUsersAsync(string uname, string value, string username, string password, int isadmin, int entryno, int coid, int issup, string branch, string isallbranches, string realname, string createdby, int datecreated, int isactive, string deactivatedby, int deactivateddate, int uploaded, int trans_entryno, string hqservername, string uploadingbranch);

		// Token: 0x06005204 RID: 20996
		[OperationContract(Action = "http://tempuri.org/IService/FetchBranchPrices", ReplyAction = "http://tempuri.org/IService/FetchBranchPricesResponse")]
		string FetchBranchPrices(string uname, string value, int coid, int productid, string branch, decimal sellingprice, decimal wholesaleprice, decimal wholesaleqty, decimal specialprice, int uploaded, string doneby, int donewhen, string hqservername, DateTime hquploadtime);

		// Token: 0x06005205 RID: 20997
		[OperationContract(Action = "http://tempuri.org/IService/FetchBranchPrices", ReplyAction = "http://tempuri.org/IService/FetchBranchPricesResponse")]
		Task<string> FetchBranchPricesAsync(string uname, string value, int coid, int productid, string branch, decimal sellingprice, decimal wholesaleprice, decimal wholesaleqty, decimal specialprice, int uploaded, string doneby, int donewhen, string hqservername, DateTime hquploadtime);

		// Token: 0x06005206 RID: 20998
		[OperationContract(Action = "http://tempuri.org/IService/FetchExpCategories", ReplyAction = "http://tempuri.org/IService/FetchExpCategoriesResponse")]
		bool FetchExpCategories(string uname, string value, int coid, int expensecatid, string expensecatdesc, int uploaded);

		// Token: 0x06005207 RID: 20999
		[OperationContract(Action = "http://tempuri.org/IService/FetchExpCategories", ReplyAction = "http://tempuri.org/IService/FetchExpCategoriesResponse")]
		Task<bool> FetchExpCategoriesAsync(string uname, string value, int coid, int expensecatid, string expensecatdesc, int uploaded);

		// Token: 0x06005208 RID: 21000
		[OperationContract(Action = "http://tempuri.org/IService/FetchManuFormula", ReplyAction = "http://tempuri.org/IService/FetchManuFormulaResponse")]
		bool FetchManuFormula(string uname, string value, int productid, string formulaname, string comments, int coid, string doneby, int donedate, int uploaded);

		// Token: 0x06005209 RID: 21001
		[OperationContract(Action = "http://tempuri.org/IService/FetchManuFormula", ReplyAction = "http://tempuri.org/IService/FetchManuFormulaResponse")]
		Task<bool> FetchManuFormulaAsync(string uname, string value, int productid, string formulaname, string comments, int coid, string doneby, int donedate, int uploaded);

		// Token: 0x0600520A RID: 21002
		[OperationContract(Action = "http://tempuri.org/IService/FetchManuIngridient", ReplyAction = "http://tempuri.org/IService/FetchManuIngridientResponse")]
		bool FetchManuIngridient(string uname, string value, int entryno, string formulaname, int productid, decimal qty, int coid, string doneby, int donedate, int uploaded);

		// Token: 0x0600520B RID: 21003
		[OperationContract(Action = "http://tempuri.org/IService/FetchManuIngridient", ReplyAction = "http://tempuri.org/IService/FetchManuIngridientResponse")]
		Task<bool> FetchManuIngridientAsync(string uname, string value, int entryno, string formulaname, int productid, decimal qty, int coid, string doneby, int donedate, int uploaded);

		// Token: 0x0600520C RID: 21004
		[OperationContract(Action = "http://tempuri.org/IService/D_Cats", ReplyAction = "http://tempuri.org/IService/D_CatsResponse")]
		CatsData D_Cats(string uname, string value, string branch, int coid);

		// Token: 0x0600520D RID: 21005
		[OperationContract(Action = "http://tempuri.org/IService/D_Cats", ReplyAction = "http://tempuri.org/IService/D_CatsResponse")]
		Task<CatsData> D_CatsAsync(string uname, string value, string branch, int coid);

		// Token: 0x0600520E RID: 21006
		[OperationContract(Action = "http://tempuri.org/IService/D_Cats2", ReplyAction = "http://tempuri.org/IService/D_Cats2Response")]
		CatsData D_Cats2(string uname, string value, string branch, int coid, string brdownloadtime, string brservername);

		// Token: 0x0600520F RID: 21007
		[OperationContract(Action = "http://tempuri.org/IService/D_Cats2", ReplyAction = "http://tempuri.org/IService/D_Cats2Response")]
		Task<CatsData> D_Cats2Async(string uname, string value, string branch, int coid, string brdownloadtime, string brservername);

		// Token: 0x06005210 RID: 21008
		[OperationContract(Action = "http://tempuri.org/IService/D_Prodts", ReplyAction = "http://tempuri.org/IService/D_ProdtsResponse")]
		Prodts D_Prodts(string uname, string value, string branch, int coid);

		// Token: 0x06005211 RID: 21009
		[OperationContract(Action = "http://tempuri.org/IService/D_Prodts", ReplyAction = "http://tempuri.org/IService/D_ProdtsResponse")]
		Task<Prodts> D_ProdtsAsync(string uname, string value, string branch, int coid);

		// Token: 0x06005212 RID: 21010
		[OperationContract(Action = "http://tempuri.org/IService/D_PayMeths", ReplyAction = "http://tempuri.org/IService/D_PayMethsResponse")]
		PayMethRates D_PayMeths(string uname, string value, string branch, int coid);

		// Token: 0x06005213 RID: 21011
		[OperationContract(Action = "http://tempuri.org/IService/D_PayMeths", ReplyAction = "http://tempuri.org/IService/D_PayMethsResponse")]
		Task<PayMethRates> D_PayMethsAsync(string uname, string value, string branch, int coid);

		// Token: 0x06005214 RID: 21012
		[OperationContract(Action = "http://tempuri.org/IService/D_MvtData", ReplyAction = "http://tempuri.org/IService/D_MvtDataResponse")]
		Mvt D_MvtData(string uname, string value, string branch, int coid, string brservername, DateTime brdownloadtime);

		// Token: 0x06005215 RID: 21013
		[OperationContract(Action = "http://tempuri.org/IService/D_MvtData", ReplyAction = "http://tempuri.org/IService/D_MvtDataResponse")]
		Task<Mvt> D_MvtDataAsync(string uname, string value, string branch, int coid, string brservername, DateTime brdownloadtime);

		// Token: 0x06005216 RID: 21014
		[OperationContract(Action = "http://tempuri.org/IService/D_MvtData2", ReplyAction = "http://tempuri.org/IService/D_MvtData2Response")]
		Mvt D_MvtData2(string uname, string value, string branch, int coid, string brservername, DateTime brdownloadtime, bool isbranch);

		// Token: 0x06005217 RID: 21015
		[OperationContract(Action = "http://tempuri.org/IService/D_MvtData2", ReplyAction = "http://tempuri.org/IService/D_MvtData2Response")]
		Task<Mvt> D_MvtData2Async(string uname, string value, string branch, int coid, string brservername, DateTime brdownloadtime, bool isbranch);

		// Token: 0x06005218 RID: 21016
		[OperationContract(Action = "http://tempuri.org/IService/D_MvtData3", ReplyAction = "http://tempuri.org/IService/D_MvtData3Response")]
		Mvt D_MvtData3(string uname, string value, string branch, int coid, string brservername, string brdownloadtime, bool isbranch);

		// Token: 0x06005219 RID: 21017
		[OperationContract(Action = "http://tempuri.org/IService/D_MvtData3", ReplyAction = "http://tempuri.org/IService/D_MvtData3Response")]
		Task<Mvt> D_MvtData3Async(string uname, string value, string branch, int coid, string brservername, string brdownloadtime, bool isbranch);

		// Token: 0x0600521A RID: 21018
		[OperationContract(Action = "http://tempuri.org/IService/D_Paymethactual", ReplyAction = "http://tempuri.org/IService/D_PaymethactualResponse")]
		PayMethActual D_Paymethactual(string uname, string value, string branch, int coid);

		// Token: 0x0600521B RID: 21019
		[OperationContract(Action = "http://tempuri.org/IService/D_Paymethactual", ReplyAction = "http://tempuri.org/IService/D_PaymethactualResponse")]
		Task<PayMethActual> D_PaymethactualAsync(string uname, string value, string branch, int coid);

		// Token: 0x0600521C RID: 21020
		[OperationContract(Action = "http://tempuri.org/IService/D_Paymethactual2", ReplyAction = "http://tempuri.org/IService/D_Paymethactual2Response")]
		PayMethActual D_Paymethactual2(string uname, string value, string branch, int coid, string brservername, DateTime brdownloadtime);

		// Token: 0x0600521D RID: 21021
		[OperationContract(Action = "http://tempuri.org/IService/D_Paymethactual2", ReplyAction = "http://tempuri.org/IService/D_Paymethactual2Response")]
		Task<PayMethActual> D_Paymethactual2Async(string uname, string value, string branch, int coid, string brservername, DateTime brdownloadtime);

		// Token: 0x0600521E RID: 21022
		[OperationContract(Action = "http://tempuri.org/IService/D_Paymethods", ReplyAction = "http://tempuri.org/IService/D_PaymethodsResponse")]
		PayMethz D_Paymethods(string uname, string value, string branch, int coid, string brservername, Guid brdownloadtime);

		// Token: 0x0600521F RID: 21023
		[OperationContract(Action = "http://tempuri.org/IService/D_Paymethods", ReplyAction = "http://tempuri.org/IService/D_PaymethodsResponse")]
		Task<PayMethz> D_PaymethodsAsync(string uname, string value, string branch, int coid, string brservername, Guid brdownloadtime);

		// Token: 0x06005220 RID: 21024
		[OperationContract(Action = "http://tempuri.org/IService/D_BranchPrices", ReplyAction = "http://tempuri.org/IService/D_BranchPricesResponse")]
		BranchPrices D_BranchPrices(string uname, string value, string branch, int coid, string brservername, DateTime brdownloadtime);

		// Token: 0x06005221 RID: 21025
		[OperationContract(Action = "http://tempuri.org/IService/D_BranchPrices", ReplyAction = "http://tempuri.org/IService/D_BranchPricesResponse")]
		Task<BranchPrices> D_BranchPricesAsync(string uname, string value, string branch, int coid, string brservername, DateTime brdownloadtime);

		// Token: 0x06005222 RID: 21026
		[OperationContract(Action = "http://tempuri.org/IService/D_BranchProductDetails", ReplyAction = "http://tempuri.org/IService/D_BranchProductDetailsResponse")]
		BranchProductDetails D_BranchProductDetails(string uname, string value, string branch, int coid, string brservername, DateTime brdownloadtime);

		// Token: 0x06005223 RID: 21027
		[OperationContract(Action = "http://tempuri.org/IService/D_BranchProductDetails", ReplyAction = "http://tempuri.org/IService/D_BranchProductDetailsResponse")]
		Task<BranchProductDetails> D_BranchProductDetailsAsync(string uname, string value, string branch, int coid, string brservername, DateTime brdownloadtime);
	}
}
