using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale.POSDataSetTableAdapters
{
	// Token: 0x0200015C RID: 348
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class QueriesTableAdapter : Component
	{
		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x06002E66 RID: 11878 RVA: 0x0018EC08 File Offset: 0x0018CE08
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected IDbCommand[] CommandCollection
		{
			get
			{
				bool flag = this._commandCollection == null;
				if (flag)
				{
					this.InitCommandCollection();
				}
				return this._commandCollection;
			}
		}

		// Token: 0x06002E67 RID: 11879 RVA: 0x0018EC38 File Offset: 0x0018CE38
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new IDbCommand[23];
			this._commandCollection[0] = new SqlCommand();
			((SqlCommand)this._commandCollection[0]).Connection = new SqlConnection(MySettings.Default.POSConnectionString);
			((SqlCommand)this._commandCollection[0]).CommandText = "dbo.CancelSale";
			((SqlCommand)this._commandCollection[0]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)this._commandCollection[0]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[0]).Parameters.Add(new SqlParameter("@invoicenum", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[0]).Parameters.Add(new SqlParameter("@Cancelledby", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[0]).Parameters.Add(new SqlParameter("@datecancelled", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[0]).Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[0]).Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[1] = new SqlCommand();
			((SqlCommand)this._commandCollection[1]).Connection = new SqlConnection(MySettings.Default.POSConnectionString);
			((SqlCommand)this._commandCollection[1]).CommandText = "dbo.DeleteExpense";
			((SqlCommand)this._commandCollection[1]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)this._commandCollection[1]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[1]).Parameters.Add(new SqlParameter("@entryno", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[1]).Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[1]).Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[2] = new SqlCommand();
			((SqlCommand)this._commandCollection[2]).Connection = new SqlConnection(MySettings.Default.POSConnectionString);
			((SqlCommand)this._commandCollection[2]).CommandText = "dbo.DeleteProduct";
			((SqlCommand)this._commandCollection[2]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)this._commandCollection[2]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[2]).Parameters.Add(new SqlParameter("@prodtID", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[3] = new SqlCommand();
			((SqlCommand)this._commandCollection[3]).Connection = new SqlConnection(MySettings.Default.POSConnectionString);
			((SqlCommand)this._commandCollection[3]).CommandText = "dbo.InsertCompanyDetails";
			((SqlCommand)this._commandCollection[3]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)this._commandCollection[3]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[3]).Parameters.Add(new SqlParameter("@coname", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[3]).Parameters.Add(new SqlParameter("@coaddress", SqlDbType.VarChar, 100, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[3]).Parameters.Add(new SqlParameter("@cotel", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[3]).Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[3]).Parameters.Add(new SqlParameter("@branchname", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[4] = new SqlCommand();
			((SqlCommand)this._commandCollection[4]).Connection = new SqlConnection(MySettings.Default.POSConnectionString);
			((SqlCommand)this._commandCollection[4]).CommandText = "dbo.InsertCustomerDetails";
			((SqlCommand)this._commandCollection[4]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)this._commandCollection[4]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[4]).Parameters.Add(new SqlParameter("@CustomerName", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[4]).Parameters.Add(new SqlParameter("@Address", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[4]).Parameters.Add(new SqlParameter("@Mobile", SqlDbType.VarChar, 30, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[4]).Parameters.Add(new SqlParameter("@ContactName", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[4]).Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[4]).Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[4]).Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[5] = new SqlCommand();
			((SqlCommand)this._commandCollection[5]).Connection = new SqlConnection(MySettings.Default.POSConnectionString);
			((SqlCommand)this._commandCollection[5]).CommandText = "dbo.InsertDeletedItem";
			((SqlCommand)this._commandCollection[5]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)this._commandCollection[5]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[5]).Parameters.Add(new SqlParameter("@TBName", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[5]).Parameters.Add(new SqlParameter("@KeyColumn", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[5]).Parameters.Add(new SqlParameter("@KeyColumnType", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[5]).Parameters.Add(new SqlParameter("@KeyValue", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[5]).Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[5]).Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[6] = new SqlCommand();
			((SqlCommand)this._commandCollection[6]).Connection = new SqlConnection(MySettings.Default.POSConnectionString);
			((SqlCommand)this._commandCollection[6]).CommandText = "dbo.InsertNewExpense";
			((SqlCommand)this._commandCollection[6]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)this._commandCollection[6]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[6]).Parameters.Add(new SqlParameter("@expensedate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[6]).Parameters.Add(new SqlParameter("@desc", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[6]).Parameters.Add(new SqlParameter("@cost", SqlDbType.Float, 8, ParameterDirection.Input, 53, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[6]).Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[6]).Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[7] = new SqlCommand();
			((SqlCommand)this._commandCollection[7]).Connection = new SqlConnection(MySettings.Default.POSConnectionString);
			((SqlCommand)this._commandCollection[7]).CommandText = "dbo.InsertNewSale";
			((SqlCommand)this._commandCollection[7]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)this._commandCollection[7]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[7]).Parameters.Add(new SqlParameter("@trandate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[7]).Parameters.Add(new SqlParameter("@invoicenum", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[7]).Parameters.Add(new SqlParameter("@productid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[7]).Parameters.Add(new SqlParameter("@isstockin", SqlDbType.Bit, 1, ParameterDirection.Input, 1, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[7]).Parameters.Add(new SqlParameter("@ref", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[7]).Parameters.Add(new SqlParameter("@quantity", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[7]).Parameters.Add(new SqlParameter("@unitcost", SqlDbType.Float, 8, ParameterDirection.Input, 53, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[7]).Parameters.Add(new SqlParameter("@salesprice", SqlDbType.Float, 8, ParameterDirection.Input, 53, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[7]).Parameters.Add(new SqlParameter("@paymentmethod", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[7]).Parameters.Add(new SqlParameter("@doneby", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[7]).Parameters.Add(new SqlParameter("@donewhen", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[7]).Parameters.Add(new SqlParameter("@trancode", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[7]).Parameters.Add(new SqlParameter("@trantime", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[7]).Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[7]).Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[8] = new SqlCommand();
			((SqlCommand)this._commandCollection[8]).Connection = new SqlConnection(MySettings.Default.POSConnectionString);
			((SqlCommand)this._commandCollection[8]).CommandText = "dbo.InsertNewSale2";
			((SqlCommand)this._commandCollection[8]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)this._commandCollection[8]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[8]).Parameters.Add(new SqlParameter("@trandate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[8]).Parameters.Add(new SqlParameter("@invoicenum", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[8]).Parameters.Add(new SqlParameter("@productid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[8]).Parameters.Add(new SqlParameter("@isstockin", SqlDbType.Bit, 1, ParameterDirection.Input, 1, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[8]).Parameters.Add(new SqlParameter("@ref", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[8]).Parameters.Add(new SqlParameter("@quantity", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[8]).Parameters.Add(new SqlParameter("@unitcost", SqlDbType.Float, 8, ParameterDirection.Input, 53, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[8]).Parameters.Add(new SqlParameter("@salesprice", SqlDbType.Float, 8, ParameterDirection.Input, 53, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[8]).Parameters.Add(new SqlParameter("@paymentmethod", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[8]).Parameters.Add(new SqlParameter("@doneby", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[8]).Parameters.Add(new SqlParameter("@donewhen", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[8]).Parameters.Add(new SqlParameter("@trancode", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[8]).Parameters.Add(new SqlParameter("@prodcode", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[8]).Parameters.Add(new SqlParameter("@trantime", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[8]).Parameters.Add(new SqlParameter("@taxamt", SqlDbType.Float, 8, ParameterDirection.Input, 53, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[8]).Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[8]).Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[9] = new SqlCommand();
			((SqlCommand)this._commandCollection[9]).Connection = new SqlConnection(MySettings.Default.POSConnectionString);
			((SqlCommand)this._commandCollection[9]).CommandText = "dbo.InsertNewStock";
			((SqlCommand)this._commandCollection[9]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)this._commandCollection[9]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[9]).Parameters.Add(new SqlParameter("@trandate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[9]).Parameters.Add(new SqlParameter("@invoicenum", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[9]).Parameters.Add(new SqlParameter("@productid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[9]).Parameters.Add(new SqlParameter("@isstockin", SqlDbType.Bit, 1, ParameterDirection.Input, 1, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[9]).Parameters.Add(new SqlParameter("@ref", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[9]).Parameters.Add(new SqlParameter("@quantity", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[9]).Parameters.Add(new SqlParameter("@cost", SqlDbType.Float, 8, ParameterDirection.Input, 53, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[9]).Parameters.Add(new SqlParameter("@doneby", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[9]).Parameters.Add(new SqlParameter("@donewhen", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[9]).Parameters.Add(new SqlParameter("@trancode", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[9]).Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[9]).Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[10] = new SqlCommand();
			((SqlCommand)this._commandCollection[10]).Connection = new SqlConnection(MySettings.Default.POSConnectionString);
			((SqlCommand)this._commandCollection[10]).CommandText = "dbo.InsertNewStock2";
			((SqlCommand)this._commandCollection[10]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)this._commandCollection[10]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[10]).Parameters.Add(new SqlParameter("@trandate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[10]).Parameters.Add(new SqlParameter("@invoicenum", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[10]).Parameters.Add(new SqlParameter("@productid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[10]).Parameters.Add(new SqlParameter("@isstockin", SqlDbType.Bit, 1, ParameterDirection.Input, 1, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[10]).Parameters.Add(new SqlParameter("@ref", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[10]).Parameters.Add(new SqlParameter("@quantity", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[10]).Parameters.Add(new SqlParameter("@cost", SqlDbType.Float, 8, ParameterDirection.Input, 53, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[10]).Parameters.Add(new SqlParameter("@doneby", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[10]).Parameters.Add(new SqlParameter("@donewhen", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[10]).Parameters.Add(new SqlParameter("@trancode", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[10]).Parameters.Add(new SqlParameter("@productcode", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[10]).Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[10]).Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[11] = new SqlCommand();
			((SqlCommand)this._commandCollection[11]).Connection = new SqlConnection(MySettings.Default.POSConnectionString);
			((SqlCommand)this._commandCollection[11]).CommandText = "dbo.InsertSMSHeaderData";
			((SqlCommand)this._commandCollection[11]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)this._commandCollection[11]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[11]).Parameters.Add(new SqlParameter("@schoolId", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[11]).Parameters.Add(new SqlParameter("@user", SqlDbType.VarChar, 20, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[11]).Parameters.Add(new SqlParameter("@Subject", SqlDbType.VarChar, 250, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[11]).Parameters.Add(new SqlParameter("@BatchDate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[11]).Parameters.Add(new SqlParameter("@BatchNo", SqlDbType.Int, 4, ParameterDirection.InputOutput, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[12] = new SqlCommand();
			((SqlCommand)this._commandCollection[12]).Connection = new SqlConnection(MySettings.Default.POSConnectionString);
			((SqlCommand)this._commandCollection[12]).CommandText = "dbo.SaveCredentials";
			((SqlCommand)this._commandCollection[12]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)this._commandCollection[12]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[12]).Parameters.Add(new SqlParameter("@username", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[12]).Parameters.Add(new SqlParameter("@pwd", SqlDbType.VarChar, int.MaxValue, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[12]).Parameters.Add(new SqlParameter("@isadmin", SqlDbType.Bit, 1, ParameterDirection.Input, 1, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[12]).Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[12]).Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[13] = new SqlCommand();
			((SqlCommand)this._commandCollection[13]).Connection = new SqlConnection(MySettings.Default.POSConnectionString);
			((SqlCommand)this._commandCollection[13]).CommandText = "dbo.SaveKey";
			((SqlCommand)this._commandCollection[13]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)this._commandCollection[13]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[13]).Parameters.Add(new SqlParameter("@serialkey", SqlDbType.VarChar, int.MaxValue, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[14] = new SqlCommand();
			((SqlCommand)this._commandCollection[14]).Connection = new SqlConnection(MySettings.Default.POSConnectionString);
			((SqlCommand)this._commandCollection[14]).CommandText = "dbo.SaveProductDetails";
			((SqlCommand)this._commandCollection[14]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)this._commandCollection[14]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[14]).Parameters.Add(new SqlParameter("@ProductID", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[14]).Parameters.Add(new SqlParameter("@ProductDesc", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[14]).Parameters.Add(new SqlParameter("@ProductCost", SqlDbType.Float, 8, ParameterDirection.Input, 53, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[14]).Parameters.Add(new SqlParameter("@ProductSellingPrice", SqlDbType.Float, 8, ParameterDirection.Input, 53, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[14]).Parameters.Add(new SqlParameter("@ReorderLevel", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[14]).Parameters.Add(new SqlParameter("@DoneBy", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[14]).Parameters.Add(new SqlParameter("@DoneWhen", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[14]).Parameters.Add(new SqlParameter("@taxrate", SqlDbType.Float, 8, ParameterDirection.Input, 53, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[15] = new SqlCommand();
			((SqlCommand)this._commandCollection[15]).Connection = new SqlConnection(MySettings.Default.POSConnectionString);
			((SqlCommand)this._commandCollection[15]).CommandText = "dbo.SP_savesms";
			((SqlCommand)this._commandCollection[15]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)this._commandCollection[15]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[15]).Parameters.Add(new SqlParameter("@Mobi", SqlDbType.NVarChar, 200, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[15]).Parameters.Add(new SqlParameter("@SMS", SqlDbType.NVarChar, 4000, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[15]).Parameters.Add(new SqlParameter("@DateGenerated", SqlDbType.Decimal, 9, ParameterDirection.Input, 12, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[15]).Parameters.Add(new SqlParameter("@SendingDate", SqlDbType.VarChar, 15, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[15]).Parameters.Add(new SqlParameter("@SendingTime", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[15]).Parameters.Add(new SqlParameter("@valdty", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[15]).Parameters.Add(new SqlParameter("@EntryNo", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[15]).Parameters.Add(new SqlParameter("@BatchNo", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[16] = new SqlCommand();
			((SqlCommand)this._commandCollection[16]).Connection = new SqlConnection(MySettings.Default.POSConnectionString);
			((SqlCommand)this._commandCollection[16]).CommandText = "dbo.InsertComputedSalesDayShift1";
			((SqlCommand)this._commandCollection[16]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)this._commandCollection[16]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[16]).Parameters.Add(new SqlParameter("@startdate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[16]).Parameters.Add(new SqlParameter("@enddate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[16]).Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[17] = new SqlCommand();
			((SqlCommand)this._commandCollection[17]).Connection = new SqlConnection(MySettings.Default.POSConnectionString);
			((SqlCommand)this._commandCollection[17]).CommandText = "dbo.InsertComputedSalesDayShift2";
			((SqlCommand)this._commandCollection[17]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)this._commandCollection[17]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[17]).Parameters.Add(new SqlParameter("@startdate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[17]).Parameters.Add(new SqlParameter("@enddate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[17]).Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[18] = new SqlCommand();
			((SqlCommand)this._commandCollection[18]).Connection = new SqlConnection(MySettings.Default.POSConnectionString);
			((SqlCommand)this._commandCollection[18]).CommandText = "dbo.InsertComputedSalesDayShift3";
			((SqlCommand)this._commandCollection[18]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)this._commandCollection[18]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[18]).Parameters.Add(new SqlParameter("@startdate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[18]).Parameters.Add(new SqlParameter("@enddate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[18]).Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[19] = new SqlCommand();
			((SqlCommand)this._commandCollection[19]).Connection = new SqlConnection(MySettings.Default.POSConnectionString);
			((SqlCommand)this._commandCollection[19]).CommandText = "dbo.InsertComputedSalesNightShift1";
			((SqlCommand)this._commandCollection[19]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)this._commandCollection[19]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[19]).Parameters.Add(new SqlParameter("@startdate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[19]).Parameters.Add(new SqlParameter("@enddate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[19]).Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[20] = new SqlCommand();
			((SqlCommand)this._commandCollection[20]).Connection = new SqlConnection(MySettings.Default.POSConnectionString);
			((SqlCommand)this._commandCollection[20]).CommandText = "dbo.InsertComputedSalesNightShift2";
			((SqlCommand)this._commandCollection[20]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)this._commandCollection[20]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[20]).Parameters.Add(new SqlParameter("@startdate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[20]).Parameters.Add(new SqlParameter("@enddate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[20]).Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[21] = new SqlCommand();
			((SqlCommand)this._commandCollection[21]).Connection = new SqlConnection(MySettings.Default.POSConnectionString);
			((SqlCommand)this._commandCollection[21]).CommandText = "dbo.InsertComputedSalesNightShift3";
			((SqlCommand)this._commandCollection[21]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)this._commandCollection[21]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[21]).Parameters.Add(new SqlParameter("@startdate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[21]).Parameters.Add(new SqlParameter("@enddate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[21]).Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[22] = new SqlCommand();
			((SqlCommand)this._commandCollection[22]).Connection = new SqlConnection(MySettings.Default.POSConnectionString);
			((SqlCommand)this._commandCollection[22]).CommandText = "dbo.PCInsertPriceChange";
			((SqlCommand)this._commandCollection[22]).CommandType = CommandType.StoredProcedure;
			((SqlCommand)this._commandCollection[22]).Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[22]).Parameters.Add(new SqlParameter("@productid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[22]).Parameters.Add(new SqlParameter("@qty", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[22]).Parameters.Add(new SqlParameter("@pricechange", SqlDbType.Decimal, 9, ParameterDirection.Input, 18, 2, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[22]).Parameters.Add(new SqlParameter("@doneby", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[22]).Parameters.Add(new SqlParameter("@donewhen", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[22]).Parameters.Add(new SqlParameter("@donetime", SqlDbType.VarChar, 5, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[22]).Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[22]).Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			((SqlCommand)this._commandCollection[22]).Parameters.Add(new SqlParameter("@invoiceno", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002E68 RID: 11880 RVA: 0x00191E30 File Offset: 0x00190030
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int CancelSale(int? invoicenum, string Cancelledby, int? datecancelled, int? coid, string branch)
		{
			SqlCommand sqlCommand = (SqlCommand)this.CommandCollection[0];
			bool flag = invoicenum != null;
			if (flag)
			{
				sqlCommand.Parameters[1].Value = invoicenum.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = Cancelledby == null;
			if (flag2)
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = Cancelledby;
			}
			bool flag3 = datecancelled != null;
			if (flag3)
			{
				sqlCommand.Parameters[3].Value = datecancelled.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag4 = coid != null;
			if (flag4)
			{
				sqlCommand.Parameters[4].Value = coid.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			bool flag5 = branch == null;
			if (flag5)
			{
				sqlCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[5].Value = branch;
			}
			ConnectionState state = sqlCommand.Connection.State;
			bool flag6 = (sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open;
			if (flag6)
			{
				sqlCommand.Connection.Open();
			}
			int num;
			try
			{
				num = sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				bool flag7 = state == ConnectionState.Closed;
				if (flag7)
				{
					sqlCommand.Connection.Close();
				}
			}
			return num;
		}

		// Token: 0x06002E69 RID: 11881 RVA: 0x00192004 File Offset: 0x00190204
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int DeleteExpense(int? entryno, int? coid, string branch)
		{
			SqlCommand sqlCommand = (SqlCommand)this.CommandCollection[1];
			bool flag = entryno != null;
			if (flag)
			{
				sqlCommand.Parameters[1].Value = entryno.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = coid != null;
			if (flag2)
			{
				sqlCommand.Parameters[2].Value = coid.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = branch == null;
			if (flag3)
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = branch;
			}
			ConnectionState state = sqlCommand.Connection.State;
			bool flag4 = (sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open;
			if (flag4)
			{
				sqlCommand.Connection.Open();
			}
			int num;
			try
			{
				num = sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				bool flag5 = state == ConnectionState.Closed;
				if (flag5)
				{
					sqlCommand.Connection.Close();
				}
			}
			return num;
		}

		// Token: 0x06002E6A RID: 11882 RVA: 0x00192154 File Offset: 0x00190354
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int DeleteProduct(int? prodtID)
		{
			SqlCommand sqlCommand = (SqlCommand)this.CommandCollection[2];
			bool flag = prodtID != null;
			if (flag)
			{
				sqlCommand.Parameters[1].Value = prodtID.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			bool flag2 = (sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open;
			if (flag2)
			{
				sqlCommand.Connection.Open();
			}
			int num;
			try
			{
				num = sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				bool flag3 = state == ConnectionState.Closed;
				if (flag3)
				{
					sqlCommand.Connection.Close();
				}
			}
			return num;
		}

		// Token: 0x06002E6B RID: 11883 RVA: 0x00192224 File Offset: 0x00190424
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int InsertCompanyDetails(string coname, string coaddress, string cotel, int? coid, string branchname)
		{
			SqlCommand sqlCommand = (SqlCommand)this.CommandCollection[3];
			bool flag = coname == null;
			if (flag)
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = coname;
			}
			bool flag2 = coaddress == null;
			if (flag2)
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = coaddress;
			}
			bool flag3 = cotel == null;
			if (flag3)
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = cotel;
			}
			bool flag4 = coid != null;
			if (flag4)
			{
				sqlCommand.Parameters[4].Value = coid.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			bool flag5 = branchname == null;
			if (flag5)
			{
				sqlCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[5].Value = branchname;
			}
			ConnectionState state = sqlCommand.Connection.State;
			bool flag6 = (sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open;
			if (flag6)
			{
				sqlCommand.Connection.Open();
			}
			int num;
			try
			{
				num = sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				bool flag7 = state == ConnectionState.Closed;
				if (flag7)
				{
					sqlCommand.Connection.Close();
				}
			}
			return num;
		}

		// Token: 0x06002E6C RID: 11884 RVA: 0x001923DC File Offset: 0x001905DC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int InsertCustomerDetails(string CustomerName, string Address, string Mobile, string ContactName, string Email, int? coid, string branch)
		{
			SqlCommand sqlCommand = (SqlCommand)this.CommandCollection[4];
			bool flag = CustomerName == null;
			if (flag)
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = CustomerName;
			}
			bool flag2 = Address == null;
			if (flag2)
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = Address;
			}
			bool flag3 = Mobile == null;
			if (flag3)
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = Mobile;
			}
			bool flag4 = ContactName == null;
			if (flag4)
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = ContactName;
			}
			bool flag5 = Email == null;
			if (flag5)
			{
				sqlCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[5].Value = Email;
			}
			bool flag6 = coid != null;
			if (flag6)
			{
				sqlCommand.Parameters[6].Value = coid.Value;
			}
			else
			{
				sqlCommand.Parameters[6].Value = DBNull.Value;
			}
			bool flag7 = branch == null;
			if (flag7)
			{
				sqlCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[7].Value = branch;
			}
			ConnectionState state = sqlCommand.Connection.State;
			bool flag8 = (sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open;
			if (flag8)
			{
				sqlCommand.Connection.Open();
			}
			int num;
			try
			{
				num = sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				bool flag9 = state == ConnectionState.Closed;
				if (flag9)
				{
					sqlCommand.Connection.Close();
				}
			}
			return num;
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x00192608 File Offset: 0x00190808
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int InsertDeletedItem(string TBName, string KeyColumn, string KeyColumnType, string KeyValue, int? coid, string branch)
		{
			SqlCommand sqlCommand = (SqlCommand)this.CommandCollection[5];
			bool flag = TBName == null;
			if (flag)
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = TBName;
			}
			bool flag2 = KeyColumn == null;
			if (flag2)
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = KeyColumn;
			}
			bool flag3 = KeyColumnType == null;
			if (flag3)
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = KeyColumnType;
			}
			bool flag4 = KeyValue == null;
			if (flag4)
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = KeyValue;
			}
			bool flag5 = coid != null;
			if (flag5)
			{
				sqlCommand.Parameters[5].Value = coid.Value;
			}
			else
			{
				sqlCommand.Parameters[5].Value = DBNull.Value;
			}
			bool flag6 = branch == null;
			if (flag6)
			{
				sqlCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[6].Value = branch;
			}
			ConnectionState state = sqlCommand.Connection.State;
			bool flag7 = (sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open;
			if (flag7)
			{
				sqlCommand.Connection.Open();
			}
			int num;
			try
			{
				num = sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				bool flag8 = state == ConnectionState.Closed;
				if (flag8)
				{
					sqlCommand.Connection.Close();
				}
			}
			return num;
		}

		// Token: 0x06002E6E RID: 11886 RVA: 0x001927FC File Offset: 0x001909FC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int InsertNewExpense(int? expensedate, string desc, double? cost, int? coid, string branch)
		{
			SqlCommand sqlCommand = (SqlCommand)this.CommandCollection[6];
			bool flag = expensedate != null;
			if (flag)
			{
				sqlCommand.Parameters[1].Value = expensedate.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = desc == null;
			if (flag2)
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = desc;
			}
			bool flag3 = cost != null;
			if (flag3)
			{
				sqlCommand.Parameters[3].Value = cost.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag4 = coid != null;
			if (flag4)
			{
				sqlCommand.Parameters[4].Value = coid.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			bool flag5 = branch == null;
			if (flag5)
			{
				sqlCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[5].Value = branch;
			}
			ConnectionState state = sqlCommand.Connection.State;
			bool flag6 = (sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open;
			if (flag6)
			{
				sqlCommand.Connection.Open();
			}
			int num;
			try
			{
				num = sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				bool flag7 = state == ConnectionState.Closed;
				if (flag7)
				{
					sqlCommand.Connection.Close();
				}
			}
			return num;
		}

		// Token: 0x06002E6F RID: 11887 RVA: 0x001929D0 File Offset: 0x00190BD0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int InsertNewSale(int? trandate, int? invoicenum, int? productid, bool? isstockin, string @ref, int? quantity, double? unitcost, double? salesprice, int? paymentmethod, string doneby, int? donewhen, int? trancode, int? trantime, int? coid, string branch)
		{
			SqlCommand sqlCommand = (SqlCommand)this.CommandCollection[7];
			bool flag = trandate != null;
			if (flag)
			{
				sqlCommand.Parameters[1].Value = trandate.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = invoicenum != null;
			if (flag2)
			{
				sqlCommand.Parameters[2].Value = invoicenum.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = productid != null;
			if (flag3)
			{
				sqlCommand.Parameters[3].Value = productid.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag4 = isstockin != null;
			if (flag4)
			{
				sqlCommand.Parameters[4].Value = isstockin.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			bool flag5 = @ref == null;
			if (flag5)
			{
				sqlCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[5].Value = @ref;
			}
			bool flag6 = quantity != null;
			if (flag6)
			{
				sqlCommand.Parameters[6].Value = quantity.Value;
			}
			else
			{
				sqlCommand.Parameters[6].Value = DBNull.Value;
			}
			bool flag7 = unitcost != null;
			if (flag7)
			{
				sqlCommand.Parameters[7].Value = unitcost.Value;
			}
			else
			{
				sqlCommand.Parameters[7].Value = DBNull.Value;
			}
			bool flag8 = salesprice != null;
			if (flag8)
			{
				sqlCommand.Parameters[8].Value = salesprice.Value;
			}
			else
			{
				sqlCommand.Parameters[8].Value = DBNull.Value;
			}
			bool flag9 = paymentmethod != null;
			if (flag9)
			{
				sqlCommand.Parameters[9].Value = paymentmethod.Value;
			}
			else
			{
				sqlCommand.Parameters[9].Value = DBNull.Value;
			}
			bool flag10 = doneby == null;
			if (flag10)
			{
				sqlCommand.Parameters[10].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[10].Value = doneby;
			}
			bool flag11 = donewhen != null;
			if (flag11)
			{
				sqlCommand.Parameters[11].Value = donewhen.Value;
			}
			else
			{
				sqlCommand.Parameters[11].Value = DBNull.Value;
			}
			bool flag12 = trancode != null;
			if (flag12)
			{
				sqlCommand.Parameters[12].Value = trancode.Value;
			}
			else
			{
				sqlCommand.Parameters[12].Value = DBNull.Value;
			}
			bool flag13 = trantime != null;
			if (flag13)
			{
				sqlCommand.Parameters[13].Value = trantime.Value;
			}
			else
			{
				sqlCommand.Parameters[13].Value = DBNull.Value;
			}
			bool flag14 = coid != null;
			if (flag14)
			{
				sqlCommand.Parameters[14].Value = coid.Value;
			}
			else
			{
				sqlCommand.Parameters[14].Value = DBNull.Value;
			}
			bool flag15 = branch == null;
			if (flag15)
			{
				sqlCommand.Parameters[15].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[15].Value = branch;
			}
			ConnectionState state = sqlCommand.Connection.State;
			bool flag16 = (sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open;
			if (flag16)
			{
				sqlCommand.Connection.Open();
			}
			int num;
			try
			{
				num = sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				bool flag17 = state == ConnectionState.Closed;
				if (flag17)
				{
					sqlCommand.Connection.Close();
				}
			}
			return num;
		}

		// Token: 0x06002E70 RID: 11888 RVA: 0x00192E6C File Offset: 0x0019106C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int InsertNewSale2(int? trandate, int? invoicenum, int? productid, bool? isstockin, string @ref, int? quantity, double? unitcost, double? salesprice, int? paymentmethod, string doneby, int? donewhen, int? trancode, string prodcode, int? trantime, double? taxamt, int? coid, string branch)
		{
			SqlCommand sqlCommand = (SqlCommand)this.CommandCollection[8];
			bool flag = trandate != null;
			if (flag)
			{
				sqlCommand.Parameters[1].Value = trandate.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = invoicenum != null;
			if (flag2)
			{
				sqlCommand.Parameters[2].Value = invoicenum.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = productid != null;
			if (flag3)
			{
				sqlCommand.Parameters[3].Value = productid.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag4 = isstockin != null;
			if (flag4)
			{
				sqlCommand.Parameters[4].Value = isstockin.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			bool flag5 = @ref == null;
			if (flag5)
			{
				sqlCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[5].Value = @ref;
			}
			bool flag6 = quantity != null;
			if (flag6)
			{
				sqlCommand.Parameters[6].Value = quantity.Value;
			}
			else
			{
				sqlCommand.Parameters[6].Value = DBNull.Value;
			}
			bool flag7 = unitcost != null;
			if (flag7)
			{
				sqlCommand.Parameters[7].Value = unitcost.Value;
			}
			else
			{
				sqlCommand.Parameters[7].Value = DBNull.Value;
			}
			bool flag8 = salesprice != null;
			if (flag8)
			{
				sqlCommand.Parameters[8].Value = salesprice.Value;
			}
			else
			{
				sqlCommand.Parameters[8].Value = DBNull.Value;
			}
			bool flag9 = paymentmethod != null;
			if (flag9)
			{
				sqlCommand.Parameters[9].Value = paymentmethod.Value;
			}
			else
			{
				sqlCommand.Parameters[9].Value = DBNull.Value;
			}
			bool flag10 = doneby == null;
			if (flag10)
			{
				sqlCommand.Parameters[10].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[10].Value = doneby;
			}
			bool flag11 = donewhen != null;
			if (flag11)
			{
				sqlCommand.Parameters[11].Value = donewhen.Value;
			}
			else
			{
				sqlCommand.Parameters[11].Value = DBNull.Value;
			}
			bool flag12 = trancode != null;
			if (flag12)
			{
				sqlCommand.Parameters[12].Value = trancode.Value;
			}
			else
			{
				sqlCommand.Parameters[12].Value = DBNull.Value;
			}
			bool flag13 = prodcode == null;
			if (flag13)
			{
				sqlCommand.Parameters[13].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[13].Value = prodcode;
			}
			bool flag14 = trantime != null;
			if (flag14)
			{
				sqlCommand.Parameters[14].Value = trantime.Value;
			}
			else
			{
				sqlCommand.Parameters[14].Value = DBNull.Value;
			}
			bool flag15 = taxamt != null;
			if (flag15)
			{
				sqlCommand.Parameters[15].Value = taxamt.Value;
			}
			else
			{
				sqlCommand.Parameters[15].Value = DBNull.Value;
			}
			bool flag16 = coid != null;
			if (flag16)
			{
				sqlCommand.Parameters[16].Value = coid.Value;
			}
			else
			{
				sqlCommand.Parameters[16].Value = DBNull.Value;
			}
			bool flag17 = branch == null;
			if (flag17)
			{
				sqlCommand.Parameters[17].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[17].Value = branch;
			}
			ConnectionState state = sqlCommand.Connection.State;
			bool flag18 = (sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open;
			if (flag18)
			{
				sqlCommand.Connection.Open();
			}
			int num;
			try
			{
				num = sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				bool flag19 = state == ConnectionState.Closed;
				if (flag19)
				{
					sqlCommand.Connection.Close();
				}
			}
			return num;
		}

		// Token: 0x06002E71 RID: 11889 RVA: 0x00193390 File Offset: 0x00191590
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int InsertNewStock(int? trandate, int? invoicenum, int? productid, bool? isstockin, string @ref, int? quantity, double? cost, string doneby, int? donewhen, int? trancode, int? coid, string branch)
		{
			SqlCommand sqlCommand = (SqlCommand)this.CommandCollection[9];
			bool flag = trandate != null;
			if (flag)
			{
				sqlCommand.Parameters[1].Value = trandate.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = invoicenum != null;
			if (flag2)
			{
				sqlCommand.Parameters[2].Value = invoicenum.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = productid != null;
			if (flag3)
			{
				sqlCommand.Parameters[3].Value = productid.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag4 = isstockin != null;
			if (flag4)
			{
				sqlCommand.Parameters[4].Value = isstockin.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			bool flag5 = @ref == null;
			if (flag5)
			{
				sqlCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[5].Value = @ref;
			}
			bool flag6 = quantity != null;
			if (flag6)
			{
				sqlCommand.Parameters[6].Value = quantity.Value;
			}
			else
			{
				sqlCommand.Parameters[6].Value = DBNull.Value;
			}
			bool flag7 = cost != null;
			if (flag7)
			{
				sqlCommand.Parameters[7].Value = cost.Value;
			}
			else
			{
				sqlCommand.Parameters[7].Value = DBNull.Value;
			}
			bool flag8 = doneby == null;
			if (flag8)
			{
				sqlCommand.Parameters[8].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[8].Value = doneby;
			}
			bool flag9 = donewhen != null;
			if (flag9)
			{
				sqlCommand.Parameters[9].Value = donewhen.Value;
			}
			else
			{
				sqlCommand.Parameters[9].Value = DBNull.Value;
			}
			bool flag10 = trancode != null;
			if (flag10)
			{
				sqlCommand.Parameters[10].Value = trancode.Value;
			}
			else
			{
				sqlCommand.Parameters[10].Value = DBNull.Value;
			}
			bool flag11 = coid != null;
			if (flag11)
			{
				sqlCommand.Parameters[11].Value = coid.Value;
			}
			else
			{
				sqlCommand.Parameters[11].Value = DBNull.Value;
			}
			bool flag12 = branch == null;
			if (flag12)
			{
				sqlCommand.Parameters[12].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[12].Value = branch;
			}
			ConnectionState state = sqlCommand.Connection.State;
			bool flag13 = (sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open;
			if (flag13)
			{
				sqlCommand.Connection.Open();
			}
			int num;
			try
			{
				num = sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				bool flag14 = state == ConnectionState.Closed;
				if (flag14)
				{
					sqlCommand.Connection.Close();
				}
			}
			return num;
		}

		// Token: 0x06002E72 RID: 11890 RVA: 0x00193754 File Offset: 0x00191954
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int InsertNewStock2(int? trandate, int? invoicenum, int? productid, bool? isstockin, string @ref, int? quantity, double? cost, string doneby, int? donewhen, int? trancode, string productcode, int? coid, string branch)
		{
			SqlCommand sqlCommand = (SqlCommand)this.CommandCollection[10];
			bool flag = trandate != null;
			if (flag)
			{
				sqlCommand.Parameters[1].Value = trandate.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = invoicenum != null;
			if (flag2)
			{
				sqlCommand.Parameters[2].Value = invoicenum.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = productid != null;
			if (flag3)
			{
				sqlCommand.Parameters[3].Value = productid.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag4 = isstockin != null;
			if (flag4)
			{
				sqlCommand.Parameters[4].Value = isstockin.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			bool flag5 = @ref == null;
			if (flag5)
			{
				sqlCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[5].Value = @ref;
			}
			bool flag6 = quantity != null;
			if (flag6)
			{
				sqlCommand.Parameters[6].Value = quantity.Value;
			}
			else
			{
				sqlCommand.Parameters[6].Value = DBNull.Value;
			}
			bool flag7 = cost != null;
			if (flag7)
			{
				sqlCommand.Parameters[7].Value = cost.Value;
			}
			else
			{
				sqlCommand.Parameters[7].Value = DBNull.Value;
			}
			bool flag8 = doneby == null;
			if (flag8)
			{
				sqlCommand.Parameters[8].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[8].Value = doneby;
			}
			bool flag9 = donewhen != null;
			if (flag9)
			{
				sqlCommand.Parameters[9].Value = donewhen.Value;
			}
			else
			{
				sqlCommand.Parameters[9].Value = DBNull.Value;
			}
			bool flag10 = trancode != null;
			if (flag10)
			{
				sqlCommand.Parameters[10].Value = trancode.Value;
			}
			else
			{
				sqlCommand.Parameters[10].Value = DBNull.Value;
			}
			bool flag11 = productcode == null;
			if (flag11)
			{
				sqlCommand.Parameters[11].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[11].Value = productcode;
			}
			bool flag12 = coid != null;
			if (flag12)
			{
				sqlCommand.Parameters[12].Value = coid.Value;
			}
			else
			{
				sqlCommand.Parameters[12].Value = DBNull.Value;
			}
			bool flag13 = branch == null;
			if (flag13)
			{
				sqlCommand.Parameters[13].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[13].Value = branch;
			}
			ConnectionState state = sqlCommand.Connection.State;
			bool flag14 = (sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open;
			if (flag14)
			{
				sqlCommand.Connection.Open();
			}
			int num;
			try
			{
				num = sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				bool flag15 = state == ConnectionState.Closed;
				if (flag15)
				{
					sqlCommand.Connection.Close();
				}
			}
			return num;
		}

		// Token: 0x06002E73 RID: 11891 RVA: 0x00193B54 File Offset: 0x00191D54
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int InsertSMSHeaderData(int? schoolId, string user, string Subject, int? BatchDate, ref int? BatchNo)
		{
			SqlCommand sqlCommand = (SqlCommand)this.CommandCollection[11];
			bool flag = schoolId != null;
			if (flag)
			{
				sqlCommand.Parameters[1].Value = schoolId.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = user == null;
			if (flag2)
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = user;
			}
			bool flag3 = Subject == null;
			if (flag3)
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = Subject;
			}
			bool flag4 = BatchDate != null;
			if (flag4)
			{
				sqlCommand.Parameters[4].Value = BatchDate.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			bool flag5 = BatchNo != null;
			if (flag5)
			{
				sqlCommand.Parameters[5].Value = BatchNo.Value;
			}
			else
			{
				sqlCommand.Parameters[5].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			bool flag6 = (sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open;
			if (flag6)
			{
				sqlCommand.Connection.Open();
			}
			int num;
			try
			{
				num = sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				bool flag7 = state == ConnectionState.Closed;
				if (flag7)
				{
					sqlCommand.Connection.Close();
				}
			}
			bool flag8 = sqlCommand.Parameters[5].Value == null || sqlCommand.Parameters[5].Value.GetType() == typeof(DBNull);
			if (flag8)
			{
				BatchNo = null;
			}
			else
			{
				BatchNo = new int?(Conversions.ToInteger(sqlCommand.Parameters[5].Value));
			}
			return num;
		}

		// Token: 0x06002E74 RID: 11892 RVA: 0x00193D94 File Offset: 0x00191F94
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int SaveCredentials(string username, string pwd, bool? isadmin, int? coid, string branch)
		{
			SqlCommand sqlCommand = (SqlCommand)this.CommandCollection[12];
			bool flag = username == null;
			if (flag)
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = username;
			}
			bool flag2 = pwd == null;
			if (flag2)
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = pwd;
			}
			bool flag3 = isadmin != null;
			if (flag3)
			{
				sqlCommand.Parameters[3].Value = isadmin.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag4 = coid != null;
			if (flag4)
			{
				sqlCommand.Parameters[4].Value = coid.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			bool flag5 = branch == null;
			if (flag5)
			{
				sqlCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[5].Value = branch;
			}
			ConnectionState state = sqlCommand.Connection.State;
			bool flag6 = (sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open;
			if (flag6)
			{
				sqlCommand.Connection.Open();
			}
			int num;
			try
			{
				num = sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				bool flag7 = state == ConnectionState.Closed;
				if (flag7)
				{
					sqlCommand.Connection.Close();
				}
			}
			return num;
		}

		// Token: 0x06002E75 RID: 11893 RVA: 0x00193F5C File Offset: 0x0019215C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int SaveKey(string serialkey)
		{
			SqlCommand sqlCommand = (SqlCommand)this.CommandCollection[13];
			bool flag = serialkey == null;
			if (flag)
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = serialkey;
			}
			ConnectionState state = sqlCommand.Connection.State;
			bool flag2 = (sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open;
			if (flag2)
			{
				sqlCommand.Connection.Open();
			}
			int num;
			try
			{
				num = sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				bool flag3 = state == ConnectionState.Closed;
				if (flag3)
				{
					sqlCommand.Connection.Close();
				}
			}
			return num;
		}

		// Token: 0x06002E76 RID: 11894 RVA: 0x00194020 File Offset: 0x00192220
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int SaveProductDetails(int? ProductID, string ProductDesc, double? ProductCost, double? ProductSellingPrice, int? ReorderLevel, string DoneBy, int? DoneWhen, double? taxrate)
		{
			SqlCommand sqlCommand = (SqlCommand)this.CommandCollection[14];
			bool flag = ProductID != null;
			if (flag)
			{
				sqlCommand.Parameters[1].Value = ProductID.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = ProductDesc == null;
			if (flag2)
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = ProductDesc;
			}
			bool flag3 = ProductCost != null;
			if (flag3)
			{
				sqlCommand.Parameters[3].Value = ProductCost.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag4 = ProductSellingPrice != null;
			if (flag4)
			{
				sqlCommand.Parameters[4].Value = ProductSellingPrice.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			bool flag5 = ReorderLevel != null;
			if (flag5)
			{
				sqlCommand.Parameters[5].Value = ReorderLevel.Value;
			}
			else
			{
				sqlCommand.Parameters[5].Value = DBNull.Value;
			}
			bool flag6 = DoneBy == null;
			if (flag6)
			{
				sqlCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[6].Value = DoneBy;
			}
			bool flag7 = DoneWhen != null;
			if (flag7)
			{
				sqlCommand.Parameters[7].Value = DoneWhen.Value;
			}
			else
			{
				sqlCommand.Parameters[7].Value = DBNull.Value;
			}
			bool flag8 = taxrate != null;
			if (flag8)
			{
				sqlCommand.Parameters[8].Value = taxrate.Value;
			}
			else
			{
				sqlCommand.Parameters[8].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			bool flag9 = (sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open;
			if (flag9)
			{
				sqlCommand.Connection.Open();
			}
			int num;
			try
			{
				num = sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				bool flag10 = state == ConnectionState.Closed;
				if (flag10)
				{
					sqlCommand.Connection.Close();
				}
			}
			return num;
		}

		// Token: 0x06002E77 RID: 11895 RVA: 0x001942C8 File Offset: 0x001924C8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int SP_savesms(string Mobi, string SMS, decimal? DateGenerated, string SendingDate, int? SendingTime, int? valdty, int? EntryNo, int? BatchNo)
		{
			SqlCommand sqlCommand = (SqlCommand)this.CommandCollection[15];
			bool flag = Mobi == null;
			if (flag)
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = Mobi;
			}
			bool flag2 = SMS == null;
			if (flag2)
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = SMS;
			}
			bool flag3 = DateGenerated != null;
			if (flag3)
			{
				sqlCommand.Parameters[3].Value = DateGenerated.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag4 = SendingDate == null;
			if (flag4)
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = SendingDate;
			}
			bool flag5 = SendingTime != null;
			if (flag5)
			{
				sqlCommand.Parameters[5].Value = SendingTime.Value;
			}
			else
			{
				sqlCommand.Parameters[5].Value = DBNull.Value;
			}
			bool flag6 = valdty != null;
			if (flag6)
			{
				sqlCommand.Parameters[6].Value = valdty.Value;
			}
			else
			{
				sqlCommand.Parameters[6].Value = DBNull.Value;
			}
			bool flag7 = EntryNo != null;
			if (flag7)
			{
				sqlCommand.Parameters[7].Value = EntryNo.Value;
			}
			else
			{
				sqlCommand.Parameters[7].Value = DBNull.Value;
			}
			bool flag8 = BatchNo != null;
			if (flag8)
			{
				sqlCommand.Parameters[8].Value = BatchNo.Value;
			}
			else
			{
				sqlCommand.Parameters[8].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			bool flag9 = (sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open;
			if (flag9)
			{
				sqlCommand.Connection.Open();
			}
			int num;
			try
			{
				num = sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				bool flag10 = state == ConnectionState.Closed;
				if (flag10)
				{
					sqlCommand.Connection.Close();
				}
			}
			return num;
		}

		// Token: 0x06002E78 RID: 11896 RVA: 0x00194564 File Offset: 0x00192764
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int InsertComputedSalesDayShift1(int? startdate, int? enddate, string branch)
		{
			SqlCommand sqlCommand = (SqlCommand)this.CommandCollection[16];
			bool flag = startdate != null;
			if (flag)
			{
				sqlCommand.Parameters[1].Value = startdate.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = enddate != null;
			if (flag2)
			{
				sqlCommand.Parameters[2].Value = enddate.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = branch == null;
			if (flag3)
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = branch;
			}
			ConnectionState state = sqlCommand.Connection.State;
			bool flag4 = (sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open;
			if (flag4)
			{
				sqlCommand.Connection.Open();
			}
			int num;
			try
			{
				num = sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				bool flag5 = state == ConnectionState.Closed;
				if (flag5)
				{
					sqlCommand.Connection.Close();
				}
			}
			return num;
		}

		// Token: 0x06002E79 RID: 11897 RVA: 0x001946B8 File Offset: 0x001928B8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int InsertComputedSalesDayShift2(int? startdate, int? enddate, string branch)
		{
			SqlCommand sqlCommand = (SqlCommand)this.CommandCollection[17];
			bool flag = startdate != null;
			if (flag)
			{
				sqlCommand.Parameters[1].Value = startdate.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = enddate != null;
			if (flag2)
			{
				sqlCommand.Parameters[2].Value = enddate.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = branch == null;
			if (flag3)
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = branch;
			}
			ConnectionState state = sqlCommand.Connection.State;
			bool flag4 = (sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open;
			if (flag4)
			{
				sqlCommand.Connection.Open();
			}
			int num;
			try
			{
				num = sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				bool flag5 = state == ConnectionState.Closed;
				if (flag5)
				{
					sqlCommand.Connection.Close();
				}
			}
			return num;
		}

		// Token: 0x06002E7A RID: 11898 RVA: 0x0019480C File Offset: 0x00192A0C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int InsertComputedSalesDayShift3(int? startdate, int? enddate, string branch)
		{
			SqlCommand sqlCommand = (SqlCommand)this.CommandCollection[18];
			bool flag = startdate != null;
			if (flag)
			{
				sqlCommand.Parameters[1].Value = startdate.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = enddate != null;
			if (flag2)
			{
				sqlCommand.Parameters[2].Value = enddate.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = branch == null;
			if (flag3)
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = branch;
			}
			ConnectionState state = sqlCommand.Connection.State;
			bool flag4 = (sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open;
			if (flag4)
			{
				sqlCommand.Connection.Open();
			}
			int num;
			try
			{
				num = sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				bool flag5 = state == ConnectionState.Closed;
				if (flag5)
				{
					sqlCommand.Connection.Close();
				}
			}
			return num;
		}

		// Token: 0x06002E7B RID: 11899 RVA: 0x00194960 File Offset: 0x00192B60
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int InsertComputedSalesNightShift1(int? startdate, int? enddate, string branch)
		{
			SqlCommand sqlCommand = (SqlCommand)this.CommandCollection[19];
			bool flag = startdate != null;
			if (flag)
			{
				sqlCommand.Parameters[1].Value = startdate.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = enddate != null;
			if (flag2)
			{
				sqlCommand.Parameters[2].Value = enddate.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = branch == null;
			if (flag3)
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = branch;
			}
			ConnectionState state = sqlCommand.Connection.State;
			bool flag4 = (sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open;
			if (flag4)
			{
				sqlCommand.Connection.Open();
			}
			int num;
			try
			{
				num = sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				bool flag5 = state == ConnectionState.Closed;
				if (flag5)
				{
					sqlCommand.Connection.Close();
				}
			}
			return num;
		}

		// Token: 0x06002E7C RID: 11900 RVA: 0x00194AB4 File Offset: 0x00192CB4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int InsertComputedSalesNightShift2(int? startdate, int? enddate, string branch)
		{
			SqlCommand sqlCommand = (SqlCommand)this.CommandCollection[20];
			bool flag = startdate != null;
			if (flag)
			{
				sqlCommand.Parameters[1].Value = startdate.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = enddate != null;
			if (flag2)
			{
				sqlCommand.Parameters[2].Value = enddate.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = branch == null;
			if (flag3)
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = branch;
			}
			ConnectionState state = sqlCommand.Connection.State;
			bool flag4 = (sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open;
			if (flag4)
			{
				sqlCommand.Connection.Open();
			}
			int num;
			try
			{
				num = sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				bool flag5 = state == ConnectionState.Closed;
				if (flag5)
				{
					sqlCommand.Connection.Close();
				}
			}
			return num;
		}

		// Token: 0x06002E7D RID: 11901 RVA: 0x00194C08 File Offset: 0x00192E08
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int InsertComputedSalesNightShift3(int? startdate, int? enddate, string branch)
		{
			SqlCommand sqlCommand = (SqlCommand)this.CommandCollection[21];
			bool flag = startdate != null;
			if (flag)
			{
				sqlCommand.Parameters[1].Value = startdate.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = enddate != null;
			if (flag2)
			{
				sqlCommand.Parameters[2].Value = enddate.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = branch == null;
			if (flag3)
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = branch;
			}
			ConnectionState state = sqlCommand.Connection.State;
			bool flag4 = (sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open;
			if (flag4)
			{
				sqlCommand.Connection.Open();
			}
			int num;
			try
			{
				num = sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				bool flag5 = state == ConnectionState.Closed;
				if (flag5)
				{
					sqlCommand.Connection.Close();
				}
			}
			return num;
		}

		// Token: 0x06002E7E RID: 11902 RVA: 0x00194D5C File Offset: 0x00192F5C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int PCInsertPriceChange(int? productid, int? qty, decimal? pricechange, string doneby, int? donewhen, string donetime, int? coid, string branch, int? invoiceno)
		{
			SqlCommand sqlCommand = (SqlCommand)this.CommandCollection[22];
			bool flag = productid != null;
			if (flag)
			{
				sqlCommand.Parameters[1].Value = productid.Value;
			}
			else
			{
				sqlCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = qty != null;
			if (flag2)
			{
				sqlCommand.Parameters[2].Value = qty.Value;
			}
			else
			{
				sqlCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = pricechange != null;
			if (flag3)
			{
				sqlCommand.Parameters[3].Value = pricechange.Value;
			}
			else
			{
				sqlCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag4 = doneby == null;
			if (flag4)
			{
				sqlCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[4].Value = doneby;
			}
			bool flag5 = donewhen != null;
			if (flag5)
			{
				sqlCommand.Parameters[5].Value = donewhen.Value;
			}
			else
			{
				sqlCommand.Parameters[5].Value = DBNull.Value;
			}
			bool flag6 = donetime == null;
			if (flag6)
			{
				sqlCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[6].Value = donetime;
			}
			bool flag7 = coid != null;
			if (flag7)
			{
				sqlCommand.Parameters[7].Value = coid.Value;
			}
			else
			{
				sqlCommand.Parameters[7].Value = DBNull.Value;
			}
			bool flag8 = branch == null;
			if (flag8)
			{
				sqlCommand.Parameters[8].Value = DBNull.Value;
			}
			else
			{
				sqlCommand.Parameters[8].Value = branch;
			}
			bool flag9 = invoiceno != null;
			if (flag9)
			{
				sqlCommand.Parameters[9].Value = invoiceno.Value;
			}
			else
			{
				sqlCommand.Parameters[9].Value = DBNull.Value;
			}
			ConnectionState state = sqlCommand.Connection.State;
			bool flag10 = (sqlCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open;
			if (flag10)
			{
				sqlCommand.Connection.Open();
			}
			int num;
			try
			{
				num = sqlCommand.ExecuteNonQuery();
			}
			finally
			{
				bool flag11 = state == ConnectionState.Closed;
				if (flag11)
				{
					sqlCommand.Connection.Close();
				}
			}
			return num;
		}

		// Token: 0x040013EF RID: 5103
		private IDbCommand[] _commandCollection;
	}
}
