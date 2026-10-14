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
	// Token: 0x0200015B RID: 347
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class GetBankingDetails2TableAdapter : Component
	{
		// Token: 0x1700113F RID: 4415
		// (get) Token: 0x06002E55 RID: 11861 RVA: 0x0018E667 File Offset: 0x0018C867
		// (set) Token: 0x06002E56 RID: 11862 RVA: 0x0018E671 File Offset: 0x0018C871
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002E57 RID: 11863 RVA: 0x0018E67A File Offset: 0x0018C87A
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public GetBankingDetails2TableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17001140 RID: 4416
		// (get) Token: 0x06002E58 RID: 11864 RVA: 0x0018E68C File Offset: 0x0018C88C
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

		// Token: 0x17001141 RID: 4417
		// (get) Token: 0x06002E59 RID: 11865 RVA: 0x0018E6BC File Offset: 0x0018C8BC
		// (set) Token: 0x06002E5A RID: 11866 RVA: 0x0018E6EC File Offset: 0x0018C8EC
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

		// Token: 0x17001142 RID: 4418
		// (get) Token: 0x06002E5B RID: 11867 RVA: 0x0018E7B0 File Offset: 0x0018C9B0
		// (set) Token: 0x06002E5C RID: 11868 RVA: 0x0018E7C8 File Offset: 0x0018C9C8
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

		// Token: 0x17001143 RID: 4419
		// (get) Token: 0x06002E5D RID: 11869 RVA: 0x0018E8B0 File Offset: 0x0018CAB0
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

		// Token: 0x17001144 RID: 4420
		// (get) Token: 0x06002E5E RID: 11870 RVA: 0x0018E8E0 File Offset: 0x0018CAE0
		// (set) Token: 0x06002E5F RID: 11871 RVA: 0x0018E8F8 File Offset: 0x0018CAF8
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

		// Token: 0x06002E60 RID: 11872 RVA: 0x0018E904 File Offset: 0x0018CB04
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "GetBankingDetails2";
			dataTableMapping.ColumnMappings.Add("BankName", "BankName");
			dataTableMapping.ColumnMappings.Add("Branch", "Branch");
			dataTableMapping.ColumnMappings.Add("Account_Name", "Account_Name");
			dataTableMapping.ColumnMappings.Add("Account_Number", "Account_Number");
			dataTableMapping.ColumnMappings.Add("Swift_Code", "Swift_Code");
			dataTableMapping.ColumnMappings.Add("Currency", "Currency");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002E61 RID: 11873 RVA: 0x0018E9D2 File Offset: 0x0018CBD2
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002E62 RID: 11874 RVA: 0x0018E9F8 File Offset: 0x0018CBF8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.GetBankingDetails2";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002E63 RID: 11875 RVA: 0x0018EACC File Offset: 0x0018CCCC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.GetBankingDetails2DataTable dataTable, int? coid)
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
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x06002E64 RID: 11876 RVA: 0x0018EB6C File Offset: 0x0018CD6C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.GetBankingDetails2DataTable GetData(int? coid)
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
			POSDataSet.GetBankingDetails2DataTable getBankingDetails2DataTable = new POSDataSet.GetBankingDetails2DataTable();
			this.Adapter.Fill(getBankingDetails2DataTable);
			return getBankingDetails2DataTable;
		}

		// Token: 0x040013EB RID: 5099
		private SqlConnection _connection;

		// Token: 0x040013EC RID: 5100
		private SqlTransaction _transaction;

		// Token: 0x040013ED RID: 5101
		private SqlCommand[] _commandCollection;

		// Token: 0x040013EE RID: 5102
		private bool _clearBeforeFill;
	}
}
