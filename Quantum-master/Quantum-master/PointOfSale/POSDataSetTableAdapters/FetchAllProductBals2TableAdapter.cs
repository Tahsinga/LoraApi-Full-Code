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
	// Token: 0x020000C5 RID: 197
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class FetchAllProductBals2TableAdapter : Component
	{
		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x060024EC RID: 9452 RVA: 0x001416B2 File Offset: 0x0013F8B2
		// (set) Token: 0x060024ED RID: 9453 RVA: 0x001416BC File Offset: 0x0013F8BC
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060024EE RID: 9454 RVA: 0x001416C5 File Offset: 0x0013F8C5
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public FetchAllProductBals2TableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x060024EF RID: 9455 RVA: 0x001416D8 File Offset: 0x0013F8D8
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

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x060024F0 RID: 9456 RVA: 0x00141708 File Offset: 0x0013F908
		// (set) Token: 0x060024F1 RID: 9457 RVA: 0x00141738 File Offset: 0x0013F938
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

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x060024F2 RID: 9458 RVA: 0x001417FC File Offset: 0x0013F9FC
		// (set) Token: 0x060024F3 RID: 9459 RVA: 0x00141814 File Offset: 0x0013FA14
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

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x060024F4 RID: 9460 RVA: 0x001418FC File Offset: 0x0013FAFC
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

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x060024F5 RID: 9461 RVA: 0x0014192C File Offset: 0x0013FB2C
		// (set) Token: 0x060024F6 RID: 9462 RVA: 0x00141944 File Offset: 0x0013FB44
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

		// Token: 0x060024F7 RID: 9463 RVA: 0x00141950 File Offset: 0x0013FB50
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "FetchAllProductBals2";
			dataTableMapping.ColumnMappings.Add("ProductID", "ProductID");
			dataTableMapping.ColumnMappings.Add("ProductCode", "ProductCode");
			dataTableMapping.ColumnMappings.Add("ProductDesc", "ProductDesc");
			dataTableMapping.ColumnMappings.Add("StockBalance", "StockBalance");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x060024F8 RID: 9464 RVA: 0x001419F2 File Offset: 0x0013FBF2
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString;
		}

		// Token: 0x060024F9 RID: 9465 RVA: 0x00141A18 File Offset: 0x0013FC18
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.FetchAllProductBals2";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x060024FA RID: 9466 RVA: 0x00141B24 File Offset: 0x0013FD24
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.FetchAllProductBals2DataTable dataTable, int? coid, string branch)
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
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x060024FB RID: 9467 RVA: 0x00141C14 File Offset: 0x0013FE14
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.FetchAllProductBals2DataTable GetData(int? coid, string branch)
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
			POSDataSet.FetchAllProductBals2DataTable fetchAllProductBals2DataTable = new POSDataSet.FetchAllProductBals2DataTable();
			this.Adapter.Fill(fetchAllProductBals2DataTable);
			return fetchAllProductBals2DataTable;
		}

		// Token: 0x040010FD RID: 4349
		private SqlConnection _connection;

		// Token: 0x040010FE RID: 4350
		private SqlTransaction _transaction;

		// Token: 0x040010FF RID: 4351
		private SqlCommand[] _commandCollection;

		// Token: 0x04001100 RID: 4352
		private bool _clearBeforeFill;
	}
}
