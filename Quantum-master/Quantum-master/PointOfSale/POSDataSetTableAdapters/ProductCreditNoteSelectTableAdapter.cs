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
	// Token: 0x02000126 RID: 294
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class ProductCreditNoteSelectTableAdapter : Component
	{
		// Token: 0x17001001 RID: 4097
		// (get) Token: 0x06002B01 RID: 11009 RVA: 0x00171063 File Offset: 0x0016F263
		// (set) Token: 0x06002B02 RID: 11010 RVA: 0x0017106D File Offset: 0x0016F26D
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002B03 RID: 11011 RVA: 0x00171076 File Offset: 0x0016F276
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public ProductCreditNoteSelectTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17001002 RID: 4098
		// (get) Token: 0x06002B04 RID: 11012 RVA: 0x00171088 File Offset: 0x0016F288
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

		// Token: 0x17001003 RID: 4099
		// (get) Token: 0x06002B05 RID: 11013 RVA: 0x001710B8 File Offset: 0x0016F2B8
		// (set) Token: 0x06002B06 RID: 11014 RVA: 0x001710E8 File Offset: 0x0016F2E8
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

		// Token: 0x17001004 RID: 4100
		// (get) Token: 0x06002B07 RID: 11015 RVA: 0x001711AC File Offset: 0x0016F3AC
		// (set) Token: 0x06002B08 RID: 11016 RVA: 0x001711C4 File Offset: 0x0016F3C4
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

		// Token: 0x17001005 RID: 4101
		// (get) Token: 0x06002B09 RID: 11017 RVA: 0x001712AC File Offset: 0x0016F4AC
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

		// Token: 0x17001006 RID: 4102
		// (get) Token: 0x06002B0A RID: 11018 RVA: 0x001712DC File Offset: 0x0016F4DC
		// (set) Token: 0x06002B0B RID: 11019 RVA: 0x001712F4 File Offset: 0x0016F4F4
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

		// Token: 0x06002B0C RID: 11020 RVA: 0x00171300 File Offset: 0x0016F500
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "ProductCreditNoteSelect";
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
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002B0D RID: 11021 RVA: 0x00171518 File Offset: 0x0016F718
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002B0E RID: 11022 RVA: 0x0017153C File Offset: 0x0016F73C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.ProductCreditNoteSelect";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@invoicenum", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@donotlinkinv", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@oginvnum", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002B0F RID: 11023 RVA: 0x001716BC File Offset: 0x0016F8BC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.ProductCreditNoteSelectDataTable dataTable, int? invoicenum, int? coid, int? donotlinkinv, int? oginvnum)
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
			bool flag3 = donotlinkinv != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = donotlinkinv.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag4 = oginvnum != null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = oginvnum.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[4].Value = DBNull.Value;
			}
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x06002B10 RID: 11024 RVA: 0x00171870 File Offset: 0x0016FA70
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.ProductCreditNoteSelectDataTable GetData(int? invoicenum, int? coid, int? donotlinkinv, int? oginvnum)
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
			bool flag3 = donotlinkinv != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = donotlinkinv.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag4 = oginvnum != null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = oginvnum.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[4].Value = DBNull.Value;
			}
			POSDataSet.ProductCreditNoteSelectDataTable productCreditNoteSelectDataTable = new POSDataSet.ProductCreditNoteSelectDataTable();
			this.Adapter.Fill(productCreditNoteSelectDataTable);
			return productCreditNoteSelectDataTable;
		}

		// Token: 0x040012E2 RID: 4834
		private SqlConnection _connection;

		// Token: 0x040012E3 RID: 4835
		private SqlTransaction _transaction;

		// Token: 0x040012E4 RID: 4836
		private SqlCommand[] _commandCollection;

		// Token: 0x040012E5 RID: 4837
		private bool _clearBeforeFill;
	}
}
