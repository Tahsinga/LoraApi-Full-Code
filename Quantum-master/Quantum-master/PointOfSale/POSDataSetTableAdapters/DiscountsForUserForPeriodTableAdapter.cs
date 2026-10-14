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
	// Token: 0x02000102 RID: 258
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class DiscountsForUserForPeriodTableAdapter : Component
	{
		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x060028C1 RID: 10433 RVA: 0x0015F0DE File Offset: 0x0015D2DE
		// (set) Token: 0x060028C2 RID: 10434 RVA: 0x0015F0E8 File Offset: 0x0015D2E8
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060028C3 RID: 10435 RVA: 0x0015F0F1 File Offset: 0x0015D2F1
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DiscountsForUserForPeriodTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x060028C4 RID: 10436 RVA: 0x0015F104 File Offset: 0x0015D304
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

		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x060028C5 RID: 10437 RVA: 0x0015F134 File Offset: 0x0015D334
		// (set) Token: 0x060028C6 RID: 10438 RVA: 0x0015F164 File Offset: 0x0015D364
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

		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x060028C7 RID: 10439 RVA: 0x0015F228 File Offset: 0x0015D428
		// (set) Token: 0x060028C8 RID: 10440 RVA: 0x0015F240 File Offset: 0x0015D440
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

		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x060028C9 RID: 10441 RVA: 0x0015F328 File Offset: 0x0015D528
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

		// Token: 0x17000F2E RID: 3886
		// (get) Token: 0x060028CA RID: 10442 RVA: 0x0015F358 File Offset: 0x0015D558
		// (set) Token: 0x060028CB RID: 10443 RVA: 0x0015F370 File Offset: 0x0015D570
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

		// Token: 0x060028CC RID: 10444 RVA: 0x0015F37C File Offset: 0x0015D57C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "DiscountsForUserForPeriod";
			dataTableMapping.ColumnMappings.Add("ReceiptDisplayPaymentMethod", "ReceiptDisplayPaymentMethod");
			dataTableMapping.ColumnMappings.Add("PaymentMethodDesc", "PaymentMethodDesc");
			dataTableMapping.ColumnMappings.Add("Discount_Given", "Discount_Given");
			dataTableMapping.ColumnMappings.Add("BaseCurrencyEquiv", "BaseCurrencyEquiv");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x0015F41E File Offset: 0x0015D61E
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString1;
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x0015F444 File Offset: 0x0015D644
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.DiscountsForUserForPeriod";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@shiftdateStart", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@shiftdateEnd", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@theuser", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x060028CF RID: 10447 RVA: 0x0015F600 File Offset: 0x0015D800
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.DiscountsForUserForPeriodDataTable dataTable, int? shiftdateStart, int? shiftdateEnd, int? coid, string branch, string theuser)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = shiftdateStart != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = shiftdateStart.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = shiftdateEnd != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = shiftdateEnd.Value;
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
			bool flag5 = theuser == null;
			if (flag5)
			{
				this.Adapter.SelectCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[5].Value = theuser;
			}
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x0015F7F4 File Offset: 0x0015D9F4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.DiscountsForUserForPeriodDataTable GetData(int? shiftdateStart, int? shiftdateEnd, int? coid, string branch, string theuser)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = shiftdateStart != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = shiftdateStart.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = shiftdateEnd != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = shiftdateEnd.Value;
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
			bool flag5 = theuser == null;
			if (flag5)
			{
				this.Adapter.SelectCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[5].Value = theuser;
			}
			POSDataSet.DiscountsForUserForPeriodDataTable discountsForUserForPeriodDataTable = new POSDataSet.DiscountsForUserForPeriodDataTable();
			this.Adapter.Fill(discountsForUserForPeriodDataTable);
			return discountsForUserForPeriodDataTable;
		}

		// Token: 0x0400122E RID: 4654
		private SqlConnection _connection;

		// Token: 0x0400122F RID: 4655
		private SqlTransaction _transaction;

		// Token: 0x04001230 RID: 4656
		private SqlCommand[] _commandCollection;

		// Token: 0x04001231 RID: 4657
		private bool _clearBeforeFill;
	}
}
