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
	// Token: 0x020000B6 RID: 182
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class SP_ViewSMSSentTableAdapter : Component
	{
		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x060023FC RID: 9212 RVA: 0x0013A69C File Offset: 0x0013889C
		// (set) Token: 0x060023FD RID: 9213 RVA: 0x0013A6A6 File Offset: 0x001388A6
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x0013A6AF File Offset: 0x001388AF
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public SP_ViewSMSSentTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000D62 RID: 3426
		// (get) Token: 0x060023FF RID: 9215 RVA: 0x0013A6C4 File Offset: 0x001388C4
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

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x06002400 RID: 9216 RVA: 0x0013A6F4 File Offset: 0x001388F4
		// (set) Token: 0x06002401 RID: 9217 RVA: 0x0013A724 File Offset: 0x00138924
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

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x06002402 RID: 9218 RVA: 0x0013A7E8 File Offset: 0x001389E8
		// (set) Token: 0x06002403 RID: 9219 RVA: 0x0013A800 File Offset: 0x00138A00
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

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x06002404 RID: 9220 RVA: 0x0013A8E8 File Offset: 0x00138AE8
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

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x06002405 RID: 9221 RVA: 0x0013A918 File Offset: 0x00138B18
		// (set) Token: 0x06002406 RID: 9222 RVA: 0x0013A930 File Offset: 0x00138B30
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

		// Token: 0x06002407 RID: 9223 RVA: 0x0013A93C File Offset: 0x00138B3C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "SP_ViewSMSSent";
			dataTableMapping.ColumnMappings.Add("Mobile", "Mobile");
			dataTableMapping.ColumnMappings.Add("SMS", "SMS");
			dataTableMapping.ColumnMappings.Add("Status", "Status");
			dataTableMapping.ColumnMappings.Add("DateGenerated", "DateGenerated");
			dataTableMapping.ColumnMappings.Add("SendingDate", "SendingDate");
			dataTableMapping.ColumnMappings.Add("SendingTime", "SendingTime");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x0013AA0A File Offset: 0x00138C0A
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString;
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x0013AA30 File Offset: 0x00138C30
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.SP_ViewSMSSent";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@BatchNo", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x0013AB04 File Offset: 0x00138D04
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.SP_ViewSMSSentDataTable dataTable, int? BatchNo)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = BatchNo != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = BatchNo.Value;
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

		// Token: 0x0600240B RID: 9227 RVA: 0x0013ABA4 File Offset: 0x00138DA4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.SP_ViewSMSSentDataTable GetData(int? BatchNo)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = BatchNo != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = BatchNo.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			POSDataSet.SP_ViewSMSSentDataTable sp_ViewSMSSentDataTable = new POSDataSet.SP_ViewSMSSentDataTable();
			this.Adapter.Fill(sp_ViewSMSSentDataTable);
			return sp_ViewSMSSentDataTable;
		}

		// Token: 0x040010B2 RID: 4274
		private SqlConnection _connection;

		// Token: 0x040010B3 RID: 4275
		private SqlTransaction _transaction;

		// Token: 0x040010B4 RID: 4276
		private SqlCommand[] _commandCollection;

		// Token: 0x040010B5 RID: 4277
		private bool _clearBeforeFill;
	}
}
