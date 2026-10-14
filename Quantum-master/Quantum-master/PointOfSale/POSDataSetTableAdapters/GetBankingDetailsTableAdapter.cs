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
	// Token: 0x0200015A RID: 346
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class GetBankingDetailsTableAdapter : Component
	{
		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x06002E45 RID: 11845 RVA: 0x0018E0CE File Offset: 0x0018C2CE
		// (set) Token: 0x06002E46 RID: 11846 RVA: 0x0018E0D8 File Offset: 0x0018C2D8
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002E47 RID: 11847 RVA: 0x0018E0E1 File Offset: 0x0018C2E1
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public GetBankingDetailsTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x1700113A RID: 4410
		// (get) Token: 0x06002E48 RID: 11848 RVA: 0x0018E0F4 File Offset: 0x0018C2F4
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

		// Token: 0x1700113B RID: 4411
		// (get) Token: 0x06002E49 RID: 11849 RVA: 0x0018E124 File Offset: 0x0018C324
		// (set) Token: 0x06002E4A RID: 11850 RVA: 0x0018E154 File Offset: 0x0018C354
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

		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x06002E4B RID: 11851 RVA: 0x0018E218 File Offset: 0x0018C418
		// (set) Token: 0x06002E4C RID: 11852 RVA: 0x0018E230 File Offset: 0x0018C430
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

		// Token: 0x1700113D RID: 4413
		// (get) Token: 0x06002E4D RID: 11853 RVA: 0x0018E318 File Offset: 0x0018C518
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

		// Token: 0x1700113E RID: 4414
		// (get) Token: 0x06002E4E RID: 11854 RVA: 0x0018E348 File Offset: 0x0018C548
		// (set) Token: 0x06002E4F RID: 11855 RVA: 0x0018E360 File Offset: 0x0018C560
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

		// Token: 0x06002E50 RID: 11856 RVA: 0x0018E36C File Offset: 0x0018C56C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "GetBankingDetails";
			dataTableMapping.ColumnMappings.Add("BankName", "BankName");
			dataTableMapping.ColumnMappings.Add("Branch", "Branch");
			dataTableMapping.ColumnMappings.Add("Account_Name", "Account_Name");
			dataTableMapping.ColumnMappings.Add("Account_Number", "Account_Number");
			dataTableMapping.ColumnMappings.Add("Swift_Code", "Swift_Code");
			dataTableMapping.ColumnMappings.Add("Currency", "Currency");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002E51 RID: 11857 RVA: 0x0018E43A File Offset: 0x0018C63A
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002E52 RID: 11858 RVA: 0x0018E460 File Offset: 0x0018C660
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.GetBankingDetails";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002E53 RID: 11859 RVA: 0x0018E534 File Offset: 0x0018C734
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.GetBankingDetailsDataTable dataTable, int? coid)
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

		// Token: 0x06002E54 RID: 11860 RVA: 0x0018E5D4 File Offset: 0x0018C7D4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.GetBankingDetailsDataTable GetData(int? coid)
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
			POSDataSet.GetBankingDetailsDataTable getBankingDetailsDataTable = new POSDataSet.GetBankingDetailsDataTable();
			this.Adapter.Fill(getBankingDetailsDataTable);
			return getBankingDetailsDataTable;
		}

		// Token: 0x040013E6 RID: 5094
		private SqlConnection _connection;

		// Token: 0x040013E7 RID: 5095
		private SqlTransaction _transaction;

		// Token: 0x040013E8 RID: 5096
		private SqlCommand[] _commandCollection;

		// Token: 0x040013E9 RID: 5097
		private bool _clearBeforeFill;
	}
}
