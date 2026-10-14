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
	// Token: 0x020000F5 RID: 245
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class GetUserForQuotationTableAdapter : Component
	{
		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x060027EC RID: 10220 RVA: 0x00158489 File Offset: 0x00156689
		// (set) Token: 0x060027ED RID: 10221 RVA: 0x00158493 File Offset: 0x00156693
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060027EE RID: 10222 RVA: 0x0015849C File Offset: 0x0015669C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public GetUserForQuotationTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x060027EF RID: 10223 RVA: 0x001584B0 File Offset: 0x001566B0
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

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x060027F0 RID: 10224 RVA: 0x001584E0 File Offset: 0x001566E0
		// (set) Token: 0x060027F1 RID: 10225 RVA: 0x00158510 File Offset: 0x00156710
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

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x060027F2 RID: 10226 RVA: 0x001585D4 File Offset: 0x001567D4
		// (set) Token: 0x060027F3 RID: 10227 RVA: 0x001585EC File Offset: 0x001567EC
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

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x060027F4 RID: 10228 RVA: 0x001586D4 File Offset: 0x001568D4
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

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x060027F5 RID: 10229 RVA: 0x00158704 File Offset: 0x00156904
		// (set) Token: 0x060027F6 RID: 10230 RVA: 0x0015871C File Offset: 0x0015691C
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

		// Token: 0x060027F7 RID: 10231 RVA: 0x00158728 File Offset: 0x00156928
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "GetUserForQuotation";
			dataTableMapping.ColumnMappings.Add("realname", "realname");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x060027F8 RID: 10232 RVA: 0x00158788 File Offset: 0x00156988
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString1;
		}

		// Token: 0x060027F9 RID: 10233 RVA: 0x001587AC File Offset: 0x001569AC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.GetUserForQuotation";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@quotationnum", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x060027FA RID: 10234 RVA: 0x001588B8 File Offset: 0x00156AB8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.GetUserForQuotationDataTable dataTable, int? quotationnum, int? coid)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = quotationnum != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = quotationnum.Value;
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
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x060027FB RID: 10235 RVA: 0x001589B4 File Offset: 0x00156BB4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.GetUserForQuotationDataTable GetData(int? quotationnum, int? coid)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = quotationnum != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = quotationnum.Value;
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
			POSDataSet.GetUserForQuotationDataTable getUserForQuotationDataTable = new POSDataSet.GetUserForQuotationDataTable();
			this.Adapter.Fill(getUserForQuotationDataTable);
			return getUserForQuotationDataTable;
		}

		// Token: 0x040011ED RID: 4589
		private SqlConnection _connection;

		// Token: 0x040011EE RID: 4590
		private SqlTransaction _transaction;

		// Token: 0x040011EF RID: 4591
		private SqlCommand[] _commandCollection;

		// Token: 0x040011F0 RID: 4592
		private bool _clearBeforeFill;
	}
}
