using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualBasic.CompilerServices;
using Newtonsoft.Json;
using PointOfSale.My;
using RestSharp;

namespace PointOfSale
{
	// Token: 0x02000057 RID: 87
	public class eTopUp
	{
		// Token: 0x06001213 RID: 4627 RVA: 0x000AD9AC File Offset: 0x000ABBAC
		public eTopUp()
		{
			this._cnn = MyProject.Forms.Form1.Constring;
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x000AD9CC File Offset: 0x000ABBCC
		public string GetWalletBalance(string url, string resource, string agent, string pwd, string @ref)
		{
			RestClient restClient = new RestClient(url);
			RestRequest restRequest = new RestRequest(resource, Method.GET);
			restRequest.AddHeader("x-agent-reference", @ref);
			restRequest.AddHeader("x-access-password", pwd);
			restRequest.AddHeader("x-access-code", agent);
			IRestResponse<eTopUp.WalletBalance> restResponse = restClient.Execute<eTopUp.WalletBalance>(restRequest);
			string text = restResponse.Content;
			bool isSuccessful = restResponse.IsSuccessful;
			string text2;
			if (isSuccessful)
			{
				bool flag = Operators.CompareString(restResponse.Data.ReplyCode, "2", false) == 0;
				if (flag)
				{
					text2 = restResponse.Data.WalletBalance;
				}
				else
				{
					text2 = "XXXXX" + restResponse.Data.ReplyMsg;
				}
			}
			else
			{
				bool flag2 = Operators.CompareString(text, "", false) == 0;
				if (flag2)
				{
					text2 = "XXXXX Network Error. Retry." + restResponse.ErrorMessage;
				}
				else
				{
					text = text.Substring(1);
					bool flag3 = text.StartsWith("x-agent-reference header can only be used once.");
					if (flag3)
					{
						text2 = "XXXXXreference number has already been used. If error persisting, contact System Administration";
					}
				}
			}
			return text2;
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x000ADAC8 File Offset: 0x000ABCC8
		public string GetUserBalance(string url, string resource, string agent, string pwd, string @ref, string mobilenumber)
		{
			RestClient restClient = new RestClient(url);
			RestRequest restRequest = new RestRequest(resource + "?targetmobile=" + mobilenumber, Method.GET);
			restRequest.AddHeader("x-agent-reference", @ref);
			restRequest.AddHeader("x-access-password", pwd);
			restRequest.AddHeader("x-access-code", agent);
			IRestResponse<eTopUp.UserBalance> restResponse = restClient.Execute<eTopUp.UserBalance>(restRequest);
			string text = restResponse.Content;
			bool flag = Operators.CompareString(text, "", false) == 0;
			string text2;
			if (flag)
			{
				text2 = "XXXXX Network Error. Retry." + restResponse.ErrorMessage;
			}
			else
			{
				text = text.Substring(1);
				bool flag2 = text.StartsWith("x-agent-reference header can only be used once.");
				if (flag2)
				{
					text2 = "XXXXXreference number has already been used. If error persisting, contact System Administration";
				}
				else
				{
					bool flag3 = Operators.CompareString(restResponse.Data.ReplyCode, "2", false) == 0;
					if (flag3)
					{
						text2 = restResponse.Data.MobileBalance;
					}
					else
					{
						bool flag4 = Operators.CompareString(restResponse.Data.ReplyCode, "221", false) == 0;
						if (flag4)
						{
							text2 = "XXXXX Invalid number or balance unavailable. " + restResponse.ErrorMessage;
						}
						else
						{
							text2 = "XXXXX" + restResponse.Data.ReplyMsg;
						}
					}
				}
			}
			return text2;
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x000ADBF8 File Offset: 0x000ABDF8
		public string DoPinlessRecharge(string url, string resource, string agent, string pwd, string @ref, string mobilenumber, string recharge_amount)
		{
			RestClient restClient = new RestClient(url);
			RestRequest restRequest = new RestRequest(resource, Method.POST);
			restRequest.AddHeader("x-agent-reference", @ref);
			restRequest.AddHeader("x-access-password", pwd);
			restRequest.AddHeader("x-access-code", agent);
			restRequest.AddJsonBody(new eTopUp.RechargeBody
			{
				amount = recharge_amount,
				targetMobile = mobilenumber
			});
			IRestResponse<eTopUp.PinlessRecharge> restResponse = restClient.Execute<eTopUp.PinlessRecharge>(restRequest);
			string text = restResponse.Content;
			bool isSuccessful = restResponse.IsSuccessful;
			string text2;
			if (isSuccessful)
			{
				bool flag = Operators.CompareString(restResponse.Data.ReplyCode, "2", false) == 0;
				if (flag)
				{
					text2 = restResponse.Data.ReplyMsg;
				}
				else
				{
					text2 = "XXXXX Error: " + restResponse.ErrorMessage;
				}
			}
			else
			{
				text = text.Substring(1);
				bool flag2 = text.StartsWith("x-agent-reference header can only be used once.");
				if (flag2)
				{
					text2 = "XXXXX reference number has already been used. If error persisting, contact System Administration";
				}
				else
				{
					eTopUp.PinlessRechargeError pinlessRechargeError = JsonConvert.DeserializeObject<eTopUp.PinlessRechargeError>(restResponse.Content);
					string replyMessage = pinlessRechargeError.ReplyMessage;
					text2 = "XXXXX " + replyMessage;
				}
			}
			return text2;
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x000ADD0C File Offset: 0x000ABF0C
		public string QueryOldTransaction(string url, string resource, string agent, string pwd, string @ref, string oldref)
		{
			RestClient restClient = new RestClient(url);
			RestRequest restRequest = new RestRequest(resource + "?agentReference=" + oldref, Method.GET);
			restRequest.AddHeader("x-agent-reference", @ref);
			restRequest.AddHeader("x-access-password", pwd);
			restRequest.AddHeader("x-access-code", agent);
			IRestResponse<eTopUp.QueryTransaction> restResponse = restClient.Execute<eTopUp.QueryTransaction>(restRequest);
			string content = restResponse.Content;
			bool isSuccessful = restResponse.IsSuccessful;
			string text;
			if (isSuccessful)
			{
				bool flag = Operators.CompareString(restResponse.Data.ReplyCode, "2", false) == 0;
				if (flag)
				{
					text = "Previous transaction was a query. Detail: " + restResponse.Data.RawReply;
				}
				else
				{
					bool flag2 = Operators.CompareString(restResponse.Data.ReplyCode, "0", false) == 0;
					if (flag2)
					{
						text = "Previous transaction is pending for action. Detail: " + restResponse.Data.RawReply;
					}
					else
					{
						bool flag3 = Operators.CompareString(restResponse.Data.ReplyCode, "1", false) == 0;
						if (flag3)
						{
							text = "Previous transaction is still being processed. Detail: " + restResponse.Data.RawReply;
						}
						else
						{
							bool flag4 = Operators.CompareString(restResponse.Data.ReplyCode, "3", false) == 0;
							if (flag4)
							{
								text = "previous transaction details were not found. Detail: " + restResponse.Data.RawReply;
							}
							else
							{
								text = restResponse.Data.RawReply;
							}
						}
					}
				}
			}
			else
			{
				text = "XXXXX unspecified error.";
			}
			return text;
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x000ADE78 File Offset: 0x000AC078
		private void UpdateTransaction(DateTime trandate, string trantime, int coid, string branch, string doneby, string machinename, string agentref, string trantype, int issuccessful, string responsecontent, string responsemsg, string responseraw, int responsecode, string responseerrormsg, string mobilenumber, decimal amount)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "NetoneInsertTranDetails";
			sqlCommand.Parameters.AddWithValue("TranDate", trandate);
			sqlCommand.Parameters.AddWithValue("TranTime", trantime);
			sqlCommand.Parameters.AddWithValue("coid", MyProject.Forms.Form1.coid);
			sqlCommand.Parameters.AddWithValue("branch", MyProject.Forms.Form1.branch);
			sqlCommand.Parameters.AddWithValue("DoneBy", doneby);
			sqlCommand.Parameters.AddWithValue("MachineName", machinename);
			sqlCommand.Parameters.AddWithValue("AgentReference", agentref);
			sqlCommand.Parameters.AddWithValue("TranType", trantype);
			sqlCommand.Parameters.AddWithValue("IsSuccessful", issuccessful);
			sqlCommand.Parameters.AddWithValue("ResponseContent", responsecontent);
			sqlCommand.Parameters.AddWithValue("ResponseMsg", responsemsg);
			sqlCommand.Parameters.AddWithValue("ResponseRaw", responseraw);
			sqlCommand.Parameters.AddWithValue("ResponseCode", responsecode);
			sqlCommand.Parameters.AddWithValue("ResponseErrorMsg", responseerrormsg);
			sqlCommand.Parameters.AddWithValue("MobileNumber", mobilenumber);
			sqlCommand.Parameters.AddWithValue("Amount", amount);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x000AE044 File Offset: 0x000AC244
		public string GetNextAgentRefNumber(int coid, string branch)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "NetoneGetNextAgentRef";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			DataTable dataTable = new DataTable();
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
			int num = sqlDataAdapter.Fill(dataTable);
			DataRow dataRow = dataTable.Rows[0];
			string text = dataRow["agentrefnum"].ToString();
			return "QuantumPOS" + coid.ToString() + branch + text;
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x000AE0F4 File Offset: 0x000AC2F4
		public void InsertAgentRefDetails(int coid, string branch, string agentref)
		{
			SqlConnection sqlConnection = new SqlConnection(this._cnn);
			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandType = CommandType.StoredProcedure;
			sqlCommand.CommandText = "NetoneInsertAgentRef";
			sqlCommand.Parameters.AddWithValue("coid", coid);
			sqlCommand.Parameters.AddWithValue("branch", branch);
			sqlCommand.Parameters.AddWithValue("id", agentref);
			using (sqlConnection)
			{
				sqlConnection.Open();
				sqlCommand.ExecuteNonQuery();
				sqlConnection.Close();
			}
		}

		// Token: 0x04000881 RID: 2177
		private string _cnn;

		// Token: 0x02000241 RID: 577
		public class WalletBalance
		{
			// Token: 0x17002369 RID: 9065
			// (get) Token: 0x0600623D RID: 25149 RVA: 0x0037B308 File Offset: 0x00379508
			// (set) Token: 0x0600623E RID: 25150 RVA: 0x0037B312 File Offset: 0x00379512
			public string ReplyCode { get; set; }

			// Token: 0x1700236A RID: 9066
			// (get) Token: 0x0600623F RID: 25151 RVA: 0x0037B31B File Offset: 0x0037951B
			// (set) Token: 0x06006240 RID: 25152 RVA: 0x0037B325 File Offset: 0x00379525
			public string ReplyMsg { get; set; }

			// Token: 0x1700236B RID: 9067
			// (get) Token: 0x06006241 RID: 25153 RVA: 0x0037B32E File Offset: 0x0037952E
			// (set) Token: 0x06006242 RID: 25154 RVA: 0x0037B338 File Offset: 0x00379538
			public string WalletBalance { get; set; }

			// Token: 0x1700236C RID: 9068
			// (get) Token: 0x06006243 RID: 25155 RVA: 0x0037B341 File Offset: 0x00379541
			// (set) Token: 0x06006244 RID: 25156 RVA: 0x0037B34B File Offset: 0x0037954B
			public string AgentReference { get; set; }
		}

		// Token: 0x02000242 RID: 578
		public class UserBalance
		{
			// Token: 0x1700236D RID: 9069
			// (get) Token: 0x06006246 RID: 25158 RVA: 0x0037B354 File Offset: 0x00379554
			// (set) Token: 0x06006247 RID: 25159 RVA: 0x0037B35E File Offset: 0x0037955E
			public string ReplyCode { get; set; }

			// Token: 0x1700236E RID: 9070
			// (get) Token: 0x06006248 RID: 25160 RVA: 0x0037B367 File Offset: 0x00379567
			// (set) Token: 0x06006249 RID: 25161 RVA: 0x0037B371 File Offset: 0x00379571
			public string ReplyMsg { get; set; }

			// Token: 0x1700236F RID: 9071
			// (get) Token: 0x0600624A RID: 25162 RVA: 0x0037B37A File Offset: 0x0037957A
			// (set) Token: 0x0600624B RID: 25163 RVA: 0x0037B384 File Offset: 0x00379584
			public string MobileBalance { get; set; }

			// Token: 0x17002370 RID: 9072
			// (get) Token: 0x0600624C RID: 25164 RVA: 0x0037B38D File Offset: 0x0037958D
			// (set) Token: 0x0600624D RID: 25165 RVA: 0x0037B397 File Offset: 0x00379597
			public string WindowPeriod { get; set; }

			// Token: 0x17002371 RID: 9073
			// (get) Token: 0x0600624E RID: 25166 RVA: 0x0037B3A0 File Offset: 0x003795A0
			// (set) Token: 0x0600624F RID: 25167 RVA: 0x0037B3AA File Offset: 0x003795AA
			public string AgentReference { get; set; }
		}

		// Token: 0x02000243 RID: 579
		public class PinlessRecharge
		{
			// Token: 0x17002372 RID: 9074
			// (get) Token: 0x06006251 RID: 25169 RVA: 0x0037B3B3 File Offset: 0x003795B3
			// (set) Token: 0x06006252 RID: 25170 RVA: 0x0037B3BD File Offset: 0x003795BD
			public string ReplyCode { get; set; }

			// Token: 0x17002373 RID: 9075
			// (get) Token: 0x06006253 RID: 25171 RVA: 0x0037B3C6 File Offset: 0x003795C6
			// (set) Token: 0x06006254 RID: 25172 RVA: 0x0037B3D0 File Offset: 0x003795D0
			public string ReplyMsg { get; set; }

			// Token: 0x17002374 RID: 9076
			// (get) Token: 0x06006255 RID: 25173 RVA: 0x0037B3D9 File Offset: 0x003795D9
			// (set) Token: 0x06006256 RID: 25174 RVA: 0x0037B3E3 File Offset: 0x003795E3
			public string WalletBalance { get; set; }

			// Token: 0x17002375 RID: 9077
			// (get) Token: 0x06006257 RID: 25175 RVA: 0x0037B3EC File Offset: 0x003795EC
			// (set) Token: 0x06006258 RID: 25176 RVA: 0x0037B3F6 File Offset: 0x003795F6
			public string Amount { get; set; }

			// Token: 0x17002376 RID: 9078
			// (get) Token: 0x06006259 RID: 25177 RVA: 0x0037B3FF File Offset: 0x003795FF
			// (set) Token: 0x0600625A RID: 25178 RVA: 0x0037B409 File Offset: 0x00379609
			public string Discount { get; set; }

			// Token: 0x17002377 RID: 9079
			// (get) Token: 0x0600625B RID: 25179 RVA: 0x0037B412 File Offset: 0x00379612
			// (set) Token: 0x0600625C RID: 25180 RVA: 0x0037B41C File Offset: 0x0037961C
			public string InitialBalance { get; set; }

			// Token: 0x17002378 RID: 9080
			// (get) Token: 0x0600625D RID: 25181 RVA: 0x0037B425 File Offset: 0x00379625
			// (set) Token: 0x0600625E RID: 25182 RVA: 0x0037B42F File Offset: 0x0037962F
			public string FinalBalance { get; set; }

			// Token: 0x17002379 RID: 9081
			// (get) Token: 0x0600625F RID: 25183 RVA: 0x0037B438 File Offset: 0x00379638
			// (set) Token: 0x06006260 RID: 25184 RVA: 0x0037B442 File Offset: 0x00379642
			public string Window { get; set; }

			// Token: 0x1700237A RID: 9082
			// (get) Token: 0x06006261 RID: 25185 RVA: 0x0037B44B File Offset: 0x0037964B
			// (set) Token: 0x06006262 RID: 25186 RVA: 0x0037B455 File Offset: 0x00379655
			public string Data { get; set; }

			// Token: 0x1700237B RID: 9083
			// (get) Token: 0x06006263 RID: 25187 RVA: 0x0037B45E File Offset: 0x0037965E
			// (set) Token: 0x06006264 RID: 25188 RVA: 0x0037B468 File Offset: 0x00379668
			public string SMS { get; set; }

			// Token: 0x1700237C RID: 9084
			// (get) Token: 0x06006265 RID: 25189 RVA: 0x0037B471 File Offset: 0x00379671
			// (set) Token: 0x06006266 RID: 25190 RVA: 0x0037B47B File Offset: 0x0037967B
			public string AgentReference { get; set; }

			// Token: 0x1700237D RID: 9085
			// (get) Token: 0x06006267 RID: 25191 RVA: 0x0037B484 File Offset: 0x00379684
			// (set) Token: 0x06006268 RID: 25192 RVA: 0x0037B48E File Offset: 0x0037968E
			public string RechargeID { get; set; }
		}

		// Token: 0x02000244 RID: 580
		public class RechargeBody
		{
			// Token: 0x1700237E RID: 9086
			// (get) Token: 0x0600626A RID: 25194 RVA: 0x0037B497 File Offset: 0x00379697
			// (set) Token: 0x0600626B RID: 25195 RVA: 0x0037B4A1 File Offset: 0x003796A1
			public string amount { get; set; }

			// Token: 0x1700237F RID: 9087
			// (get) Token: 0x0600626C RID: 25196 RVA: 0x0037B4AA File Offset: 0x003796AA
			// (set) Token: 0x0600626D RID: 25197 RVA: 0x0037B4B4 File Offset: 0x003796B4
			public string targetMobile { get; set; }
		}

		// Token: 0x02000245 RID: 581
		public class PinlessRechargeError
		{
			// Token: 0x17002380 RID: 9088
			// (get) Token: 0x0600626F RID: 25199 RVA: 0x0037B4BD File Offset: 0x003796BD
			// (set) Token: 0x06006270 RID: 25200 RVA: 0x0037B4C7 File Offset: 0x003796C7
			public string ReplyCode { get; set; }

			// Token: 0x17002381 RID: 9089
			// (get) Token: 0x06006271 RID: 25201 RVA: 0x0037B4D0 File Offset: 0x003796D0
			// (set) Token: 0x06006272 RID: 25202 RVA: 0x0037B4DA File Offset: 0x003796DA
			public string ReplyMessage { get; set; }
		}

		// Token: 0x02000246 RID: 582
		public class QueryTransaction
		{
			// Token: 0x17002382 RID: 9090
			// (get) Token: 0x06006274 RID: 25204 RVA: 0x0037B4E3 File Offset: 0x003796E3
			// (set) Token: 0x06006275 RID: 25205 RVA: 0x0037B4ED File Offset: 0x003796ED
			public string ReplyCode { get; set; }

			// Token: 0x17002383 RID: 9091
			// (get) Token: 0x06006276 RID: 25206 RVA: 0x0037B4F6 File Offset: 0x003796F6
			// (set) Token: 0x06006277 RID: 25207 RVA: 0x0037B500 File Offset: 0x00379700
			public string ReplyMSg { get; set; }

			// Token: 0x17002384 RID: 9092
			// (get) Token: 0x06006278 RID: 25208 RVA: 0x0037B509 File Offset: 0x00379709
			// (set) Token: 0x06006279 RID: 25209 RVA: 0x0037B513 File Offset: 0x00379713
			public string OriginalAgentReference { get; set; }

			// Token: 0x17002385 RID: 9093
			// (get) Token: 0x0600627A RID: 25210 RVA: 0x0037B51C File Offset: 0x0037971C
			// (set) Token: 0x0600627B RID: 25211 RVA: 0x0037B526 File Offset: 0x00379726
			public string RawReply { get; set; }

			// Token: 0x17002386 RID: 9094
			// (get) Token: 0x0600627C RID: 25212 RVA: 0x0037B52F File Offset: 0x0037972F
			// (set) Token: 0x0600627D RID: 25213 RVA: 0x0037B539 File Offset: 0x00379739
			public string AgentReference { get; set; }
		}
	}
}
