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
	// Token: 0x02000103 RID: 259
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class GetProductPricesTableAdapter : Component
	{
		// Token: 0x17000F2F RID: 3887
		// (get) Token: 0x060028D1 RID: 10449 RVA: 0x0015F9D9 File Offset: 0x0015DBD9
		// (set) Token: 0x060028D2 RID: 10450 RVA: 0x0015F9E3 File Offset: 0x0015DBE3
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060028D3 RID: 10451 RVA: 0x0015F9EC File Offset: 0x0015DBEC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public GetProductPricesTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000F30 RID: 3888
		// (get) Token: 0x060028D4 RID: 10452 RVA: 0x0015FA00 File Offset: 0x0015DC00
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

		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x060028D5 RID: 10453 RVA: 0x0015FA30 File Offset: 0x0015DC30
		// (set) Token: 0x060028D6 RID: 10454 RVA: 0x0015FA60 File Offset: 0x0015DC60
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

		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x060028D7 RID: 10455 RVA: 0x0015FB24 File Offset: 0x0015DD24
		// (set) Token: 0x060028D8 RID: 10456 RVA: 0x0015FB3C File Offset: 0x0015DD3C
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

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x060028D9 RID: 10457 RVA: 0x0015FC24 File Offset: 0x0015DE24
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

		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x060028DA RID: 10458 RVA: 0x0015FC54 File Offset: 0x0015DE54
		// (set) Token: 0x060028DB RID: 10459 RVA: 0x0015FC6C File Offset: 0x0015DE6C
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

		// Token: 0x060028DC RID: 10460 RVA: 0x0015FC78 File Offset: 0x0015DE78
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "GetProductPrices";
			dataTableMapping.ColumnMappings.Add("productdesc", "productdesc");
			dataTableMapping.ColumnMappings.Add("productcode", "productcode");
			dataTableMapping.ColumnMappings.Add("Selling_Price", "Selling_Price");
			dataTableMapping.ColumnMappings.Add("Selling_Price_Wholesale", "Selling_Price_Wholesale");
			dataTableMapping.ColumnMappings.Add("Special_Price", "Special_Price");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x060028DD RID: 10461 RVA: 0x0015FD30 File Offset: 0x0015DF30
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString1;
		}

		// Token: 0x060028DE RID: 10462 RVA: 0x0015FD54 File Offset: 0x0015DF54
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.GetProductPrices";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@paymethid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@catid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x060028DF RID: 10463 RVA: 0x0015FED4 File Offset: 0x0015E0D4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.GetProductPricesDataTable dataTable, int? coid, int? paymethid, int? catid, string branch)
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
			bool flag2 = paymethid != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = paymethid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = catid != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = catid.Value;
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
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x060028E0 RID: 10464 RVA: 0x0016007C File Offset: 0x0015E27C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.GetProductPricesDataTable GetData(int? coid, int? paymethid, int? catid, string branch)
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
			bool flag2 = paymethid != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = paymethid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = catid != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = catid.Value;
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
			POSDataSet.GetProductPricesDataTable getProductPricesDataTable = new POSDataSet.GetProductPricesDataTable();
			this.Adapter.Fill(getProductPricesDataTable);
			return getProductPricesDataTable;
		}

		// Token: 0x04001233 RID: 4659
		private SqlConnection _connection;

		// Token: 0x04001234 RID: 4660
		private SqlTransaction _transaction;

		// Token: 0x04001235 RID: 4661
		private SqlCommand[] _commandCollection;

		// Token: 0x04001236 RID: 4662
		private bool _clearBeforeFill;
	}
}
