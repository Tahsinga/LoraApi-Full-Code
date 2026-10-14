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
	// Token: 0x020000B5 RID: 181
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class SP_ViewSMSBatchesTableAdapter : Component
	{
		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x060023EC RID: 9196 RVA: 0x0013A06D File Offset: 0x0013826D
		// (set) Token: 0x060023ED RID: 9197 RVA: 0x0013A077 File Offset: 0x00138277
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060023EE RID: 9198 RVA: 0x0013A080 File Offset: 0x00138280
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public SP_ViewSMSBatchesTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x060023EF RID: 9199 RVA: 0x0013A094 File Offset: 0x00138294
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

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x060023F0 RID: 9200 RVA: 0x0013A0C4 File Offset: 0x001382C4
		// (set) Token: 0x060023F1 RID: 9201 RVA: 0x0013A0F4 File Offset: 0x001382F4
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

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x060023F2 RID: 9202 RVA: 0x0013A1B8 File Offset: 0x001383B8
		// (set) Token: 0x060023F3 RID: 9203 RVA: 0x0013A1D0 File Offset: 0x001383D0
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

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x060023F4 RID: 9204 RVA: 0x0013A2B8 File Offset: 0x001384B8
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

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x060023F5 RID: 9205 RVA: 0x0013A2E8 File Offset: 0x001384E8
		// (set) Token: 0x060023F6 RID: 9206 RVA: 0x0013A300 File Offset: 0x00138500
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

		// Token: 0x060023F7 RID: 9207 RVA: 0x0013A30C File Offset: 0x0013850C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "SP_ViewSMSBatches";
			dataTableMapping.ColumnMappings.Add("Subject", "Subject");
			dataTableMapping.ColumnMappings.Add("SMSBatch", "SMSBatch");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x060023F8 RID: 9208 RVA: 0x0013A382 File Offset: 0x00138582
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString;
		}

		// Token: 0x060023F9 RID: 9209 RVA: 0x0013A3A8 File Offset: 0x001385A8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.SP_ViewSMSBatches";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@Datebefore", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@OrgID", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x060023FA RID: 9210 RVA: 0x0013A4B4 File Offset: 0x001386B4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.SP_ViewSMSBatchesDataTable dataTable, int? Datebefore, int? OrgID)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = Datebefore != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = Datebefore.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = OrgID != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = OrgID.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x0013A5B0 File Offset: 0x001387B0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.SP_ViewSMSBatchesDataTable GetData(int? Datebefore, int? OrgID)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = Datebefore != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = Datebefore.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = OrgID != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = OrgID.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			POSDataSet.SP_ViewSMSBatchesDataTable sp_ViewSMSBatchesDataTable = new POSDataSet.SP_ViewSMSBatchesDataTable();
			this.Adapter.Fill(sp_ViewSMSBatchesDataTable);
			return sp_ViewSMSBatchesDataTable;
		}

		// Token: 0x040010AD RID: 4269
		private SqlConnection _connection;

		// Token: 0x040010AE RID: 4270
		private SqlTransaction _transaction;

		// Token: 0x040010AF RID: 4271
		private SqlCommand[] _commandCollection;

		// Token: 0x040010B0 RID: 4272
		private bool _clearBeforeFill;
	}
}
