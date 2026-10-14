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
	// Token: 0x0200013A RID: 314
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class ShiftSalesForPERIODTableAdapter : Component
	{
		// Token: 0x17001079 RID: 4217
		// (get) Token: 0x06002C41 RID: 11329 RVA: 0x0017B9E7 File Offset: 0x00179BE7
		// (set) Token: 0x06002C42 RID: 11330 RVA: 0x0017B9F1 File Offset: 0x00179BF1
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002C43 RID: 11331 RVA: 0x0017B9FA File Offset: 0x00179BFA
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public ShiftSalesForPERIODTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x1700107A RID: 4218
		// (get) Token: 0x06002C44 RID: 11332 RVA: 0x0017BA0C File Offset: 0x00179C0C
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

		// Token: 0x1700107B RID: 4219
		// (get) Token: 0x06002C45 RID: 11333 RVA: 0x0017BA3C File Offset: 0x00179C3C
		// (set) Token: 0x06002C46 RID: 11334 RVA: 0x0017BA6C File Offset: 0x00179C6C
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

		// Token: 0x1700107C RID: 4220
		// (get) Token: 0x06002C47 RID: 11335 RVA: 0x0017BB30 File Offset: 0x00179D30
		// (set) Token: 0x06002C48 RID: 11336 RVA: 0x0017BB48 File Offset: 0x00179D48
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

		// Token: 0x1700107D RID: 4221
		// (get) Token: 0x06002C49 RID: 11337 RVA: 0x0017BC30 File Offset: 0x00179E30
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

		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x06002C4A RID: 11338 RVA: 0x0017BC60 File Offset: 0x00179E60
		// (set) Token: 0x06002C4B RID: 11339 RVA: 0x0017BC78 File Offset: 0x00179E78
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

		// Token: 0x06002C4C RID: 11340 RVA: 0x0017BC84 File Offset: 0x00179E84
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "ShiftSalesForPERIOD";
			dataTableMapping.ColumnMappings.Add("productcode", "productcode");
			dataTableMapping.ColumnMappings.Add("Product_Description", "Product_Description");
			dataTableMapping.ColumnMappings.Add("Alternate_Description", "Alternate_Description");
			dataTableMapping.ColumnMappings.Add("Quantity_Sold", "Quantity_Sold");
			dataTableMapping.ColumnMappings.Add("Revenue", "Revenue");
			dataTableMapping.ColumnMappings.Add("Gross", "Gross");
			dataTableMapping.ColumnMappings.Add("WholeSalePriceUsed", "WholeSalePriceUsed");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002C4D RID: 11341 RVA: 0x0017BD68 File Offset: 0x00179F68
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002C4E RID: 11342 RVA: 0x0017BD8C File Offset: 0x00179F8C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.ShiftSalesForPERIOD";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@shiftdatestart", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@shiftdateend", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@reduce_cost_by_tax", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@bytime", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@starttime", SqlDbType.DateTime, 8, ParameterDirection.Input, 23, 3, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@endtime", SqlDbType.DateTime, 8, ParameterDirection.Input, 23, 3, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002C4F RID: 11343 RVA: 0x0017BFF4 File Offset: 0x0017A1F4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.ShiftSalesForPERIODDataTable dataTable, int? shiftdatestart, int? shiftdateend, int? coid, string branch, int? reduce_cost_by_tax, int? bytime, DateTime? starttime, DateTime? endtime)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = shiftdatestart != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = shiftdatestart.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = shiftdateend != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = shiftdateend.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = coid != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = coid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag4 = branch == null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[4].Value = branch;
			}
			bool flag5 = reduce_cost_by_tax != null;
			if (flag5)
			{
				this.Adapter.SelectCommand.Parameters[5].Value = reduce_cost_by_tax.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[5].Value = DBNull.Value;
			}
			bool flag6 = bytime != null;
			if (flag6)
			{
				this.Adapter.SelectCommand.Parameters[6].Value = bytime.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[6].Value = DBNull.Value;
			}
			bool flag7 = starttime != null;
			if (flag7)
			{
				this.Adapter.SelectCommand.Parameters[7].Value = starttime.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[7].Value = DBNull.Value;
			}
			bool flag8 = endtime != null;
			if (flag8)
			{
				this.Adapter.SelectCommand.Parameters[8].Value = endtime.Value;
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

		// Token: 0x06002C50 RID: 11344 RVA: 0x0017C308 File Offset: 0x0017A508
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.ShiftSalesForPERIODDataTable GetData(int? shiftdatestart, int? shiftdateend, int? coid, string branch, int? reduce_cost_by_tax, int? bytime, DateTime? starttime, DateTime? endtime)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = shiftdatestart != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = shiftdatestart.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = shiftdateend != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = shiftdateend.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = coid != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = coid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag4 = branch == null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[4].Value = branch;
			}
			bool flag5 = reduce_cost_by_tax != null;
			if (flag5)
			{
				this.Adapter.SelectCommand.Parameters[5].Value = reduce_cost_by_tax.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[5].Value = DBNull.Value;
			}
			bool flag6 = bytime != null;
			if (flag6)
			{
				this.Adapter.SelectCommand.Parameters[6].Value = bytime.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[6].Value = DBNull.Value;
			}
			bool flag7 = starttime != null;
			if (flag7)
			{
				this.Adapter.SelectCommand.Parameters[7].Value = starttime.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[7].Value = DBNull.Value;
			}
			bool flag8 = endtime != null;
			if (flag8)
			{
				this.Adapter.SelectCommand.Parameters[8].Value = endtime.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[8].Value = DBNull.Value;
			}
			POSDataSet.ShiftSalesForPERIODDataTable shiftSalesForPERIODDataTable = new POSDataSet.ShiftSalesForPERIODDataTable();
			this.Adapter.Fill(shiftSalesForPERIODDataTable);
			return shiftSalesForPERIODDataTable;
		}

		// Token: 0x04001346 RID: 4934
		private SqlConnection _connection;

		// Token: 0x04001347 RID: 4935
		private SqlTransaction _transaction;

		// Token: 0x04001348 RID: 4936
		private SqlCommand[] _commandCollection;

		// Token: 0x04001349 RID: 4937
		private bool _clearBeforeFill;
	}
}
