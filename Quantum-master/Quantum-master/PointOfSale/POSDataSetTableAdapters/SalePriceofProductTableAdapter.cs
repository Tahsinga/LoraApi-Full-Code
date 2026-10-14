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
	// Token: 0x020000A8 RID: 168
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class SalePriceofProductTableAdapter : Component
	{
		// Token: 0x17000D0D RID: 3341
		// (get) Token: 0x0600231C RID: 8988 RVA: 0x001351AB File Offset: 0x001333AB
		// (set) Token: 0x0600231D RID: 8989 RVA: 0x001351B5 File Offset: 0x001333B5
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600231E RID: 8990 RVA: 0x001351BE File Offset: 0x001333BE
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public SalePriceofProductTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x0600231F RID: 8991 RVA: 0x001351D0 File Offset: 0x001333D0
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

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x06002320 RID: 8992 RVA: 0x00135200 File Offset: 0x00133400
		// (set) Token: 0x06002321 RID: 8993 RVA: 0x00135230 File Offset: 0x00133430
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

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x06002322 RID: 8994 RVA: 0x001352F4 File Offset: 0x001334F4
		// (set) Token: 0x06002323 RID: 8995 RVA: 0x0013530C File Offset: 0x0013350C
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

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x06002324 RID: 8996 RVA: 0x001353F4 File Offset: 0x001335F4
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

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x06002325 RID: 8997 RVA: 0x00135424 File Offset: 0x00133624
		// (set) Token: 0x06002326 RID: 8998 RVA: 0x0013543C File Offset: 0x0013363C
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

		// Token: 0x06002327 RID: 8999 RVA: 0x00135448 File Offset: 0x00133648
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "SalePriceofProduct";
			dataTableMapping.ColumnMappings.Add("SellingPrice", "SellingPrice");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002328 RID: 9000 RVA: 0x001354A8 File Offset: 0x001336A8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString;
		}

		// Token: 0x06002329 RID: 9001 RVA: 0x001354CC File Offset: 0x001336CC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.SalePriceofProduct";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@productid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x0600232A RID: 9002 RVA: 0x001355A0 File Offset: 0x001337A0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.SalePriceofProductDataTable dataTable, int? productid)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = productid != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = productid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x0600232B RID: 9003 RVA: 0x00135640 File Offset: 0x00133840
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.SalePriceofProductDataTable GetData(int? productid)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = productid != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = productid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			POSDataSet.SalePriceofProductDataTable salePriceofProductDataTable = new POSDataSet.SalePriceofProductDataTable();
			this.Adapter.Fill(salePriceofProductDataTable);
			return salePriceofProductDataTable;
		}

		// Token: 0x0400106C RID: 4204
		private SqlConnection _connection;

		// Token: 0x0400106D RID: 4205
		private SqlTransaction _transaction;

		// Token: 0x0400106E RID: 4206
		private SqlCommand[] _commandCollection;

		// Token: 0x0400106F RID: 4207
		private bool _clearBeforeFill;
	}
}
