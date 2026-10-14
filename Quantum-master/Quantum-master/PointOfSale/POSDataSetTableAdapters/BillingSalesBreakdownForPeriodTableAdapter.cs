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
	// Token: 0x02000153 RID: 339
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class BillingSalesBreakdownForPeriodTableAdapter : Component
	{
		// Token: 0x1700110F RID: 4367
		// (get) Token: 0x06002DD5 RID: 11733 RVA: 0x00189978 File Offset: 0x00187B78
		// (set) Token: 0x06002DD6 RID: 11734 RVA: 0x00189982 File Offset: 0x00187B82
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002DD7 RID: 11735 RVA: 0x0018998B File Offset: 0x00187B8B
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BillingSalesBreakdownForPeriodTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17001110 RID: 4368
		// (get) Token: 0x06002DD8 RID: 11736 RVA: 0x001899A0 File Offset: 0x00187BA0
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

		// Token: 0x17001111 RID: 4369
		// (get) Token: 0x06002DD9 RID: 11737 RVA: 0x001899D0 File Offset: 0x00187BD0
		// (set) Token: 0x06002DDA RID: 11738 RVA: 0x00189A00 File Offset: 0x00187C00
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

		// Token: 0x17001112 RID: 4370
		// (get) Token: 0x06002DDB RID: 11739 RVA: 0x00189AC4 File Offset: 0x00187CC4
		// (set) Token: 0x06002DDC RID: 11740 RVA: 0x00189ADC File Offset: 0x00187CDC
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

		// Token: 0x17001113 RID: 4371
		// (get) Token: 0x06002DDD RID: 11741 RVA: 0x00189BC4 File Offset: 0x00187DC4
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

		// Token: 0x17001114 RID: 4372
		// (get) Token: 0x06002DDE RID: 11742 RVA: 0x00189BF4 File Offset: 0x00187DF4
		// (set) Token: 0x06002DDF RID: 11743 RVA: 0x00189C0C File Offset: 0x00187E0C
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

		// Token: 0x06002DE0 RID: 11744 RVA: 0x00189C18 File Offset: 0x00187E18
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "BillingSalesBreakdownForPeriod";
			dataTableMapping.ColumnMappings.Add("PaymentMethod", "PaymentMethod");
			dataTableMapping.ColumnMappings.Add("Sales", "Sales");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002DE1 RID: 11745 RVA: 0x00189C8E File Offset: 0x00187E8E
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002DE2 RID: 11746 RVA: 0x00189CB4 File Offset: 0x00187EB4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.BillingSalesBreakdownForPeriod";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@shiftdateStart", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@shiftdateEnd", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@bytime", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@starttime", SqlDbType.DateTime, 8, ParameterDirection.Input, 23, 3, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@endtime", SqlDbType.DateTime, 8, ParameterDirection.Input, 23, 3, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002DE3 RID: 11747 RVA: 0x00189EE4 File Offset: 0x001880E4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.BillingSalesBreakdownForPeriodDataTable dataTable, int? coid, string branch, int? shiftdateStart, int? shiftdateEnd, int? bytime, DateTime? starttime, DateTime? endtime)
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
			bool flag3 = shiftdateStart != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = shiftdateStart.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag4 = shiftdateEnd != null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = shiftdateEnd.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[4].Value = DBNull.Value;
			}
			bool flag5 = bytime != null;
			if (flag5)
			{
				this.Adapter.SelectCommand.Parameters[5].Value = bytime.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[5].Value = DBNull.Value;
			}
			bool flag6 = starttime != null;
			if (flag6)
			{
				this.Adapter.SelectCommand.Parameters[6].Value = starttime.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[6].Value = DBNull.Value;
			}
			bool flag7 = endtime != null;
			if (flag7)
			{
				this.Adapter.SelectCommand.Parameters[7].Value = endtime.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[7].Value = DBNull.Value;
			}
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x06002DE4 RID: 11748 RVA: 0x0018A198 File Offset: 0x00188398
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.BillingSalesBreakdownForPeriodDataTable GetData(int? coid, string branch, int? shiftdateStart, int? shiftdateEnd, int? bytime, DateTime? starttime, DateTime? endtime)
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
			bool flag3 = shiftdateStart != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = shiftdateStart.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag4 = shiftdateEnd != null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = shiftdateEnd.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[4].Value = DBNull.Value;
			}
			bool flag5 = bytime != null;
			if (flag5)
			{
				this.Adapter.SelectCommand.Parameters[5].Value = bytime.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[5].Value = DBNull.Value;
			}
			bool flag6 = starttime != null;
			if (flag6)
			{
				this.Adapter.SelectCommand.Parameters[6].Value = starttime.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[6].Value = DBNull.Value;
			}
			bool flag7 = endtime != null;
			if (flag7)
			{
				this.Adapter.SelectCommand.Parameters[7].Value = endtime.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[7].Value = DBNull.Value;
			}
			POSDataSet.BillingSalesBreakdownForPeriodDataTable billingSalesBreakdownForPeriodDataTable = new POSDataSet.BillingSalesBreakdownForPeriodDataTable();
			this.Adapter.Fill(billingSalesBreakdownForPeriodDataTable);
			return billingSalesBreakdownForPeriodDataTable;
		}

		// Token: 0x040013C3 RID: 5059
		private SqlConnection _connection;

		// Token: 0x040013C4 RID: 5060
		private SqlTransaction _transaction;

		// Token: 0x040013C5 RID: 5061
		private SqlCommand[] _commandCollection;

		// Token: 0x040013C6 RID: 5062
		private bool _clearBeforeFill;
	}
}
