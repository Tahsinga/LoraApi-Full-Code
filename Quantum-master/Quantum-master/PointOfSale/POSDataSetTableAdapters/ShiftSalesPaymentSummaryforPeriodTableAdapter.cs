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
	// Token: 0x02000155 RID: 341
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class ShiftSalesPaymentSummaryforPeriodTableAdapter : Component
	{
		// Token: 0x1700111B RID: 4379
		// (get) Token: 0x06002DF5 RID: 11765 RVA: 0x0018AF01 File Offset: 0x00189101
		// (set) Token: 0x06002DF6 RID: 11766 RVA: 0x0018AF0B File Offset: 0x0018910B
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002DF7 RID: 11767 RVA: 0x0018AF14 File Offset: 0x00189114
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public ShiftSalesPaymentSummaryforPeriodTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x06002DF8 RID: 11768 RVA: 0x0018AF28 File Offset: 0x00189128
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

		// Token: 0x1700111D RID: 4381
		// (get) Token: 0x06002DF9 RID: 11769 RVA: 0x0018AF58 File Offset: 0x00189158
		// (set) Token: 0x06002DFA RID: 11770 RVA: 0x0018AF88 File Offset: 0x00189188
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

		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x06002DFB RID: 11771 RVA: 0x0018B04C File Offset: 0x0018924C
		// (set) Token: 0x06002DFC RID: 11772 RVA: 0x0018B064 File Offset: 0x00189264
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

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x06002DFD RID: 11773 RVA: 0x0018B14C File Offset: 0x0018934C
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

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x06002DFE RID: 11774 RVA: 0x0018B17C File Offset: 0x0018937C
		// (set) Token: 0x06002DFF RID: 11775 RVA: 0x0018B194 File Offset: 0x00189394
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

		// Token: 0x06002E00 RID: 11776 RVA: 0x0018B1A0 File Offset: 0x001893A0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "ShiftSalesPaymentSummaryforPeriod";
			dataTableMapping.ColumnMappings.Add("PaymentMethodDesc", "PaymentMethodDesc");
			dataTableMapping.ColumnMappings.Add("Revenue", "Revenue");
			dataTableMapping.ColumnMappings.Add("USDEquivalent", "USDEquivalent");
			dataTableMapping.ColumnMappings.Add("COGS", "COGS");
			dataTableMapping.ColumnMappings.Add("Gross", "Gross");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002E01 RID: 11777 RVA: 0x0018B258 File Offset: 0x00189458
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002E02 RID: 11778 RVA: 0x0018B27C File Offset: 0x0018947C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.ShiftSalesPaymentSummaryforPeriod";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@shiftdatestart", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@shiftdateend", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@bytime", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@starttime", SqlDbType.DateTime, 8, ParameterDirection.Input, 23, 3, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@endtime", SqlDbType.DateTime, 8, ParameterDirection.Input, 23, 3, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002E03 RID: 11779 RVA: 0x0018B4AC File Offset: 0x001896AC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.ShiftSalesPaymentSummaryforPeriodDataTable dataTable, int? shiftdatestart, int? shiftdateend, int? coid, string branch, int? bytime, DateTime? starttime, DateTime? endtime)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = shiftdatestart != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = shiftdatestart.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = shiftdateend != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = shiftdateend.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = coid != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = coid.Value;
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

		// Token: 0x06002E04 RID: 11780 RVA: 0x0018B764 File Offset: 0x00189964
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.ShiftSalesPaymentSummaryforPeriodDataTable GetData(int? shiftdatestart, int? shiftdateend, int? coid, string branch, int? bytime, DateTime? starttime, DateTime? endtime)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = shiftdatestart != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = shiftdatestart.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = shiftdateend != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = shiftdateend.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = coid != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = coid.Value;
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
			POSDataSet.ShiftSalesPaymentSummaryforPeriodDataTable shiftSalesPaymentSummaryforPeriodDataTable = new POSDataSet.ShiftSalesPaymentSummaryforPeriodDataTable();
			this.Adapter.Fill(shiftSalesPaymentSummaryforPeriodDataTable);
			return shiftSalesPaymentSummaryforPeriodDataTable;
		}

		// Token: 0x040013CD RID: 5069
		private SqlConnection _connection;

		// Token: 0x040013CE RID: 5070
		private SqlTransaction _transaction;

		// Token: 0x040013CF RID: 5071
		private SqlCommand[] _commandCollection;

		// Token: 0x040013D0 RID: 5072
		private bool _clearBeforeFill;
	}
}
