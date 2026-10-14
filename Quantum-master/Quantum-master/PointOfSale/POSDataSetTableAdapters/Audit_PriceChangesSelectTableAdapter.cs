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
	// Token: 0x020000F9 RID: 249
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class Audit_PriceChangesSelectTableAdapter : Component
	{
		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x0600282C RID: 10284 RVA: 0x0015A168 File Offset: 0x00158368
		// (set) Token: 0x0600282D RID: 10285 RVA: 0x0015A172 File Offset: 0x00158372
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600282E RID: 10286 RVA: 0x0015A17B File Offset: 0x0015837B
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Audit_PriceChangesSelectTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x0600282F RID: 10287 RVA: 0x0015A190 File Offset: 0x00158390
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

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x06002830 RID: 10288 RVA: 0x0015A1C0 File Offset: 0x001583C0
		// (set) Token: 0x06002831 RID: 10289 RVA: 0x0015A1F0 File Offset: 0x001583F0
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

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x06002832 RID: 10290 RVA: 0x0015A2B4 File Offset: 0x001584B4
		// (set) Token: 0x06002833 RID: 10291 RVA: 0x0015A2CC File Offset: 0x001584CC
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

		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x06002834 RID: 10292 RVA: 0x0015A3B4 File Offset: 0x001585B4
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

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x06002835 RID: 10293 RVA: 0x0015A3E4 File Offset: 0x001585E4
		// (set) Token: 0x06002836 RID: 10294 RVA: 0x0015A3FC File Offset: 0x001585FC
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

		// Token: 0x06002837 RID: 10295 RVA: 0x0015A408 File Offset: 0x00158608
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "Audit_PriceChangesSelect";
			dataTableMapping.ColumnMappings.Add("Entryno", "Entryno");
			dataTableMapping.ColumnMappings.Add("ServerDate", "ServerDate");
			dataTableMapping.ColumnMappings.Add("SystemDate", "SystemDate");
			dataTableMapping.ColumnMappings.Add("IsCostPriceChanged", "IsCostPriceChanged");
			dataTableMapping.ColumnMappings.Add("IsSellingPriceChanged", "IsSellingPriceChanged");
			dataTableMapping.ColumnMappings.Add("IsWholesalePriceChanged", "IsWholesalePriceChanged");
			dataTableMapping.ColumnMappings.Add("IsWholesaleQtyChanged", "IsWholesaleQtyChanged");
			dataTableMapping.ColumnMappings.Add("Old_CostPrice", "Old_CostPrice");
			dataTableMapping.ColumnMappings.Add("New_CostPrice", "New_CostPrice");
			dataTableMapping.ColumnMappings.Add("Old_SellingPrice", "Old_SellingPrice");
			dataTableMapping.ColumnMappings.Add("New_SellingPrice", "New_SellingPrice");
			dataTableMapping.ColumnMappings.Add("Old_WholesalePrice", "Old_WholesalePrice");
			dataTableMapping.ColumnMappings.Add("New_WholesalePrice", "New_WholesalePrice");
			dataTableMapping.ColumnMappings.Add("Old_WholesaleQty", "Old_WholesaleQty");
			dataTableMapping.ColumnMappings.Add("New_WholesaleQty", "New_WholesaleQty");
			dataTableMapping.ColumnMappings.Add("ChangesDoneBy", "ChangesDoneBy");
			dataTableMapping.ColumnMappings.Add("ComputerName", "ComputerName");
			dataTableMapping.ColumnMappings.Add("branch", "branch");
			dataTableMapping.ColumnMappings.Add("coid", "coid");
			dataTableMapping.ColumnMappings.Add("productid", "productid");
			dataTableMapping.ColumnMappings.Add("ProductDesc", "ProductDesc");
			dataTableMapping.ColumnMappings.Add("comment", "comment");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x0015A636 File Offset: 0x00158836
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString1;
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x0015A65C File Offset: 0x0015885C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.Audit_PriceChangesSelect";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@startdate", SqlDbType.DateTime, 8, ParameterDirection.Input, 23, 3, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@enddate", SqlDbType.DateTime, 8, ParameterDirection.Input, 23, 3, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@productid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x0015A818 File Offset: 0x00158A18
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.Audit_PriceChangesSelectDataTable dataTable, DateTime? startdate, DateTime? enddate, string branch, int? coid, int? productid)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = startdate != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = startdate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = enddate != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = enddate.Value;
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
			bool flag4 = coid != null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = coid.Value;
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
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x0600283B RID: 10299 RVA: 0x0015AA18 File Offset: 0x00158C18
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.Audit_PriceChangesSelectDataTable GetData(DateTime? startdate, DateTime? enddate, string branch, int? coid, int? productid)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = startdate != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = startdate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = enddate != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = enddate.Value;
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
			bool flag4 = coid != null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = coid.Value;
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
			POSDataSet.Audit_PriceChangesSelectDataTable audit_PriceChangesSelectDataTable = new POSDataSet.Audit_PriceChangesSelectDataTable();
			this.Adapter.Fill(audit_PriceChangesSelectDataTable);
			return audit_PriceChangesSelectDataTable;
		}

		// Token: 0x04001201 RID: 4609
		private SqlConnection _connection;

		// Token: 0x04001202 RID: 4610
		private SqlTransaction _transaction;

		// Token: 0x04001203 RID: 4611
		private SqlCommand[] _commandCollection;

		// Token: 0x04001204 RID: 4612
		private bool _clearBeforeFill;
	}
}
