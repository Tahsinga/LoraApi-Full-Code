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
	// Token: 0x02000127 RID: 295
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class SalesForProductTableAdapter : Component
	{
		// Token: 0x17001007 RID: 4103
		// (get) Token: 0x06002B11 RID: 11025 RVA: 0x00171A12 File Offset: 0x0016FC12
		// (set) Token: 0x06002B12 RID: 11026 RVA: 0x00171A1C File Offset: 0x0016FC1C
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002B13 RID: 11027 RVA: 0x00171A25 File Offset: 0x0016FC25
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public SalesForProductTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17001008 RID: 4104
		// (get) Token: 0x06002B14 RID: 11028 RVA: 0x00171A38 File Offset: 0x0016FC38
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

		// Token: 0x17001009 RID: 4105
		// (get) Token: 0x06002B15 RID: 11029 RVA: 0x00171A68 File Offset: 0x0016FC68
		// (set) Token: 0x06002B16 RID: 11030 RVA: 0x00171A98 File Offset: 0x0016FC98
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

		// Token: 0x1700100A RID: 4106
		// (get) Token: 0x06002B17 RID: 11031 RVA: 0x00171B5C File Offset: 0x0016FD5C
		// (set) Token: 0x06002B18 RID: 11032 RVA: 0x00171B74 File Offset: 0x0016FD74
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

		// Token: 0x1700100B RID: 4107
		// (get) Token: 0x06002B19 RID: 11033 RVA: 0x00171C5C File Offset: 0x0016FE5C
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

		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x06002B1A RID: 11034 RVA: 0x00171C8C File Offset: 0x0016FE8C
		// (set) Token: 0x06002B1B RID: 11035 RVA: 0x00171CA4 File Offset: 0x0016FEA4
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

		// Token: 0x06002B1C RID: 11036 RVA: 0x00171CB0 File Offset: 0x0016FEB0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "SalesForProduct";
			dataTableMapping.ColumnMappings.Add("Tran_Date", "Tran_Date");
			dataTableMapping.ColumnMappings.Add("Invoice_Number", "Invoice_Number");
			dataTableMapping.ColumnMappings.Add("Unit_Cost", "Unit_Cost");
			dataTableMapping.ColumnMappings.Add("Unit_Selling_Price", "Unit_Selling_Price");
			dataTableMapping.ColumnMappings.Add("Qty_Sold", "Qty_Sold");
			dataTableMapping.ColumnMappings.Add("taxamt", "taxamt");
			dataTableMapping.ColumnMappings.Add("Gross_Profit", "Gross_Profit");
			dataTableMapping.ColumnMappings.Add("Revenue", "Revenue");
			dataTableMapping.ColumnMappings.Add("Customer", "Customer");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002B1D RID: 11037 RVA: 0x00171DC0 File Offset: 0x0016FFC0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002B1E RID: 11038 RVA: 0x00171DE4 File Offset: 0x0016FFE4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.SalesForProduct";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@shiftdateStart", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@shiftdateEnd", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@productid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@iswarehouse", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@batchnumber", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@expirydate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x00172050 File Offset: 0x00170250
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.SalesForProductDataTable dataTable, int? coid, string branch, int? shiftdateStart, int? shiftdateEnd, int? productid, int? iswarehouse, string batchnumber, int? expirydate)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = coid != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = coid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = branch == null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = branch;
			}
			bool flag3 = shiftdateStart != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = shiftdateStart.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag4 = shiftdateEnd != null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = shiftdateEnd.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[4].Value = DBNull.Value;
			}
			bool flag5 = productid != null;
			if (flag5)
			{
				this.Adapter.SelectCommand.Parameters[5].Value = productid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[5].Value = DBNull.Value;
			}
			bool flag6 = iswarehouse != null;
			if (flag6)
			{
				this.Adapter.SelectCommand.Parameters[6].Value = iswarehouse.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[6].Value = DBNull.Value;
			}
			bool flag7 = batchnumber == null;
			if (flag7)
			{
				this.Adapter.SelectCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[7].Value = batchnumber;
			}
			bool flag8 = expirydate != null;
			if (flag8)
			{
				this.Adapter.SelectCommand.Parameters[8].Value = expirydate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[8].Value = DBNull.Value;
			}
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x06002B20 RID: 11040 RVA: 0x00172354 File Offset: 0x00170554
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.SalesForProductDataTable GetData(int? coid, string branch, int? shiftdateStart, int? shiftdateEnd, int? productid, int? iswarehouse, string batchnumber, int? expirydate)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = coid != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = coid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = branch == null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = branch;
			}
			bool flag3 = shiftdateStart != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = shiftdateStart.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag4 = shiftdateEnd != null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = shiftdateEnd.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[4].Value = DBNull.Value;
			}
			bool flag5 = productid != null;
			if (flag5)
			{
				this.Adapter.SelectCommand.Parameters[5].Value = productid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[5].Value = DBNull.Value;
			}
			bool flag6 = iswarehouse != null;
			if (flag6)
			{
				this.Adapter.SelectCommand.Parameters[6].Value = iswarehouse.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[6].Value = DBNull.Value;
			}
			bool flag7 = batchnumber == null;
			if (flag7)
			{
				this.Adapter.SelectCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[7].Value = batchnumber;
			}
			bool flag8 = expirydate != null;
			if (flag8)
			{
				this.Adapter.SelectCommand.Parameters[8].Value = expirydate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[8].Value = DBNull.Value;
			}
			POSDataSet.SalesForProductDataTable salesForProductDataTable = new POSDataSet.SalesForProductDataTable();
			this.Adapter.Fill(salesForProductDataTable);
			return salesForProductDataTable;
		}

		// Token: 0x040012E7 RID: 4839
		private SqlConnection _connection;

		// Token: 0x040012E8 RID: 4840
		private SqlTransaction _transaction;

		// Token: 0x040012E9 RID: 4841
		private SqlCommand[] _commandCollection;

		// Token: 0x040012EA RID: 4842
		private bool _clearBeforeFill;
	}
}
