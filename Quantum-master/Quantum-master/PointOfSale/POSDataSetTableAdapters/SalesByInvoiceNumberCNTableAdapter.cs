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
	// Token: 0x0200012B RID: 299
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class SalesByInvoiceNumberCNTableAdapter : Component
	{
		// Token: 0x1700101F RID: 4127
		// (get) Token: 0x06002B51 RID: 11089 RVA: 0x00173FDC File Offset: 0x001721DC
		// (set) Token: 0x06002B52 RID: 11090 RVA: 0x00173FE6 File Offset: 0x001721E6
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002B53 RID: 11091 RVA: 0x00173FEF File Offset: 0x001721EF
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public SalesByInvoiceNumberCNTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17001020 RID: 4128
		// (get) Token: 0x06002B54 RID: 11092 RVA: 0x00174004 File Offset: 0x00172204
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

		// Token: 0x17001021 RID: 4129
		// (get) Token: 0x06002B55 RID: 11093 RVA: 0x00174034 File Offset: 0x00172234
		// (set) Token: 0x06002B56 RID: 11094 RVA: 0x00174064 File Offset: 0x00172264
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

		// Token: 0x17001022 RID: 4130
		// (get) Token: 0x06002B57 RID: 11095 RVA: 0x00174128 File Offset: 0x00172328
		// (set) Token: 0x06002B58 RID: 11096 RVA: 0x00174140 File Offset: 0x00172340
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

		// Token: 0x17001023 RID: 4131
		// (get) Token: 0x06002B59 RID: 11097 RVA: 0x00174228 File Offset: 0x00172428
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

		// Token: 0x17001024 RID: 4132
		// (get) Token: 0x06002B5A RID: 11098 RVA: 0x00174258 File Offset: 0x00172458
		// (set) Token: 0x06002B5B RID: 11099 RVA: 0x00174270 File Offset: 0x00172470
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

		// Token: 0x06002B5C RID: 11100 RVA: 0x0017427C File Offset: 0x0017247C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "SalesByInvoiceNumberCN";
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
			dataTableMapping.ColumnMappings.Add("comments", "comments");
			dataTableMapping.ColumnMappings.Add("taxexempt", "taxexempt");
			dataTableMapping.ColumnMappings.Add("DiscountAmt", "DiscountAmt");
			dataTableMapping.ColumnMappings.Add("CreditNoteNumber", "CreditNoteNumber");
			dataTableMapping.ColumnMappings.Add("CommentsCR", "CommentsCR");
			dataTableMapping.ColumnMappings.Add("uom", "uom");
			dataTableMapping.ColumnMappings.Add("invdiscount", "invdiscount");
			dataTableMapping.ColumnMappings.Add("SerialNumbers", "SerialNumbers");
			dataTableMapping.ColumnMappings.Add("Comments1", "Comments1");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002B5D RID: 11101 RVA: 0x0017455A File Offset: 0x0017275A
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002B5E RID: 11102 RVA: 0x00174580 File Offset: 0x00172780
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.SalesByInvoiceNumberCN";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@invoicenum", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002B5F RID: 11103 RVA: 0x001746C8 File Offset: 0x001728C8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.SalesByInvoiceNumberCNDataTable dataTable, int? invoicenum, int? coid, string branch)
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

		// Token: 0x06002B60 RID: 11104 RVA: 0x00174814 File Offset: 0x00172A14
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.SalesByInvoiceNumberCNDataTable GetData(int? invoicenum, int? coid, string branch)
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
			POSDataSet.SalesByInvoiceNumberCNDataTable salesByInvoiceNumberCNDataTable = new POSDataSet.SalesByInvoiceNumberCNDataTable();
			this.Adapter.Fill(salesByInvoiceNumberCNDataTable);
			return salesByInvoiceNumberCNDataTable;
		}

		// Token: 0x040012FB RID: 4859
		private SqlConnection _connection;

		// Token: 0x040012FC RID: 4860
		private SqlTransaction _transaction;

		// Token: 0x040012FD RID: 4861
		private SqlCommand[] _commandCollection;

		// Token: 0x040012FE RID: 4862
		private bool _clearBeforeFill;
	}
}
