using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PointOfSale.My;

namespace PointOfSale.POSDataSetTableAdapters
{
	// Token: 0x02000141 RID: 321
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class SalesByInvoiceNumberDBTableAdapter : Component
	{
		// Token: 0x170010A3 RID: 4259
		// (get) Token: 0x06002CB5 RID: 11445 RVA: 0x0017F92D File Offset: 0x0017DB2D
		// (set) Token: 0x06002CB6 RID: 11446 RVA: 0x0017F937 File Offset: 0x0017DB37
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002CB7 RID: 11447 RVA: 0x0017F940 File Offset: 0x0017DB40
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public SalesByInvoiceNumberDBTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x170010A4 RID: 4260
		// (get) Token: 0x06002CB8 RID: 11448 RVA: 0x0017F954 File Offset: 0x0017DB54
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected internal SqlDataAdapter Adapter
		{
			get
			{
				bool flag = this._adapter == null;
				if (flag)
				{
					this.InitAdapter();
				}
				return this._adapter;
			}
		}

		// Token: 0x170010A5 RID: 4261
		// (get) Token: 0x06002CB9 RID: 11449 RVA: 0x0017F984 File Offset: 0x0017DB84
		// (set) Token: 0x06002CBA RID: 11450 RVA: 0x0017F9B4 File Offset: 0x0017DBB4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal SqlConnection Connection
		{
			get
			{
				bool flag = this._connection == null;
				if (flag)
				{
					this.InitConnection();
				}
				return this._connection;
			}
			set
			{
				this._connection = value;
				bool flag = this.Adapter.InsertCommand != null;
				if (flag)
				{
					this.Adapter.InsertCommand.Connection = value;
				}
				bool flag2 = this.Adapter.DeleteCommand != null;
				if (flag2)
				{
					this.Adapter.DeleteCommand.Connection = value;
				}
				bool flag3 = this.Adapter.UpdateCommand != null;
				if (flag3)
				{
					this.Adapter.UpdateCommand.Connection = value;
				}
				checked
				{
					for (int i = 0; i < this.CommandCollection.Length; i++)
					{
						bool flag4 = this.CommandCollection[i] != null;
						if (flag4)
						{
							this.CommandCollection[i].Connection = value;
						}
					}
				}
			}
		}

		// Token: 0x170010A6 RID: 4262
		// (get) Token: 0x06002CBB RID: 11451 RVA: 0x0017FA78 File Offset: 0x0017DC78
		// (set) Token: 0x06002CBC RID: 11452 RVA: 0x0017FA90 File Offset: 0x0017DC90
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal SqlTransaction Transaction
		{
			get
			{
				return this._transaction;
			}
			set
			{
				this._transaction = value;
				checked
				{
					for (int i = 0; i < this.CommandCollection.Length; i++)
					{
						this.CommandCollection[i].Transaction = this._transaction;
					}
					bool flag = this.Adapter != null && this.Adapter.DeleteCommand != null;
					if (flag)
					{
						this.Adapter.DeleteCommand.Transaction = this._transaction;
					}
					bool flag2 = this.Adapter != null && this.Adapter.InsertCommand != null;
					if (flag2)
					{
						this.Adapter.InsertCommand.Transaction = this._transaction;
					}
					bool flag3 = this.Adapter != null && this.Adapter.UpdateCommand != null;
					if (flag3)
					{
						this.Adapter.UpdateCommand.Transaction = this._transaction;
					}
				}
			}
		}

		// Token: 0x170010A7 RID: 4263
		// (get) Token: 0x06002CBD RID: 11453 RVA: 0x0017FB78 File Offset: 0x0017DD78
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected SqlCommand[] CommandCollection
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

		// Token: 0x170010A8 RID: 4264
		// (get) Token: 0x06002CBE RID: 11454 RVA: 0x0017FBA8 File Offset: 0x0017DDA8
		// (set) Token: 0x06002CBF RID: 11455 RVA: 0x0017FBC0 File Offset: 0x0017DDC0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool ClearBeforeFill
		{
			get
			{
				return this._clearBeforeFill;
			}
			set
			{
				this._clearBeforeFill = value;
			}
		}

		// Token: 0x06002CC0 RID: 11456 RVA: 0x0017FBCC File Offset: 0x0017DDCC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "SalesByInvoiceNumberDB";
			dataTableMapping.ColumnMappings.Add("Sale_Date", "Sale_Date");
			dataTableMapping.ColumnMappings.Add("Invoice_Number", "Invoice_Number");
			dataTableMapping.ColumnMappings.Add("Product_ID", "Product_ID");
			dataTableMapping.ColumnMappings.Add("Product_Code", "Product_Code");
			dataTableMapping.ColumnMappings.Add("Description", "Description");
			dataTableMapping.ColumnMappings.Add("Quantity", "Quantity");
			dataTableMapping.ColumnMappings.Add("Unit_Selling_Price", "Unit_Selling_Price");
			dataTableMapping.ColumnMappings.Add("Sub_Total", "Sub_Total");
			dataTableMapping.ColumnMappings.Add("Ref", "Ref");
			dataTableMapping.ColumnMappings.Add("ProductCode", "ProductCode");
			dataTableMapping.ColumnMappings.Add("BatchNumber", "BatchNumber");
			dataTableMapping.ColumnMappings.Add("ExpiryDate", "ExpiryDate");
			dataTableMapping.ColumnMappings.Add("DoneBy", "DoneBy");
			dataTableMapping.ColumnMappings.Add("usereceiptdisplay", "usereceiptdisplay");
			dataTableMapping.ColumnMappings.Add("ReceiptDisplayRate", "ReceiptDisplayRate");
			dataTableMapping.ColumnMappings.Add("ReceiptDisplayPaymentMethod", "ReceiptDisplayPaymentMethod");
			dataTableMapping.ColumnMappings.Add("TaxAmt", "TaxAmt");
			dataTableMapping.ColumnMappings.Add("Sub_TotalExcl", "Sub_TotalExcl");
			dataTableMapping.ColumnMappings.Add("ReceiptDisplayPaymentMethod1", "ReceiptDisplayPaymentMethod1");
			dataTableMapping.ColumnMappings.Add("UseReceiptDisplay1", "UseReceiptDisplay1");
			dataTableMapping.ColumnMappings.Add("Invoice_Number_Display", "Invoice_Number_Display");
			dataTableMapping.ColumnMappings.Add("Comments", "Comments");
			dataTableMapping.ColumnMappings.Add("PaymentMethod", "PaymentMethod");
			dataTableMapping.ColumnMappings.Add("ExtendedComment", "ExtendedComment");
			dataTableMapping.ColumnMappings.Add("invdiscount", "invdiscount");
			dataTableMapping.ColumnMappings.Add("taxexempt", "taxexempt");
			dataTableMapping.ColumnMappings.Add("DiscountAmt", "DiscountAmt");
			dataTableMapping.ColumnMappings.Add("uom", "uom");
			dataTableMapping.ColumnMappings.Add("taxrate", "taxrate");
			dataTableMapping.ColumnMappings.Add("OrderNo", "OrderNo");
			dataTableMapping.ColumnMappings.Add("DebitNoteNumber", "DebitNoteNumber");
			dataTableMapping.ColumnMappings.Add("CommentsDB", "CommentsDB");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002CC1 RID: 11457 RVA: 0x0017FED6 File Offset: 0x0017E0D6
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002CC2 RID: 11458 RVA: 0x0017FEFC File Offset: 0x0017E0FC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.SalesByInvoiceNumberDB";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@invoicenum", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002CC3 RID: 11459 RVA: 0x00180044 File Offset: 0x0017E244
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.SalesByInvoiceNumberDBDataTable dataTable, int? invoicenum, int? coid, string branch)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = invoicenum != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = invoicenum.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = coid != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = coid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = branch == null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = branch;
			}
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x06002CC4 RID: 11460 RVA: 0x00180190 File Offset: 0x0017E390
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.SalesByInvoiceNumberDBDataTable GetData(int? invoicenum, int? coid, string branch)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = invoicenum != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = invoicenum.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = coid != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = coid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = branch == null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = branch;
			}
			POSDataSet.SalesByInvoiceNumberDBDataTable salesByInvoiceNumberDBDataTable = new POSDataSet.SalesByInvoiceNumberDBDataTable();
			this.Adapter.Fill(salesByInvoiceNumberDBDataTable);
			return salesByInvoiceNumberDBDataTable;
		}

		// Token: 0x04001369 RID: 4969
		private SqlConnection _connection;

		// Token: 0x0400136A RID: 4970
		private SqlTransaction _transaction;

		// Token: 0x0400136B RID: 4971
		private SqlCommand[] _commandCollection;

		// Token: 0x0400136C RID: 4972
		private bool _clearBeforeFill;
	}
}
