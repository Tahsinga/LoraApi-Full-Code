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
	// Token: 0x020000F0 RID: 240
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class BillingSalesBreakdownForUserPeriodTableAdapter : Component
	{
		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x0600279C RID: 10140 RVA: 0x00155D3D File Offset: 0x00153F3D
		// (set) Token: 0x0600279D RID: 10141 RVA: 0x00155D47 File Offset: 0x00153F47
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600279E RID: 10142 RVA: 0x00155D50 File Offset: 0x00153F50
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public BillingSalesBreakdownForUserPeriodTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x0600279F RID: 10143 RVA: 0x00155D64 File Offset: 0x00153F64
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

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x060027A0 RID: 10144 RVA: 0x00155D94 File Offset: 0x00153F94
		// (set) Token: 0x060027A1 RID: 10145 RVA: 0x00155DC4 File Offset: 0x00153FC4
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

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x060027A2 RID: 10146 RVA: 0x00155E88 File Offset: 0x00154088
		// (set) Token: 0x060027A3 RID: 10147 RVA: 0x00155EA0 File Offset: 0x001540A0
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

		// Token: 0x17000EC1 RID: 3777
		// (get) Token: 0x060027A4 RID: 10148 RVA: 0x00155F88 File Offset: 0x00154188
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

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x060027A5 RID: 10149 RVA: 0x00155FB8 File Offset: 0x001541B8
		// (set) Token: 0x060027A6 RID: 10150 RVA: 0x00155FD0 File Offset: 0x001541D0
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

		// Token: 0x060027A7 RID: 10151 RVA: 0x00155FDC File Offset: 0x001541DC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "BillingSalesBreakdownForUserPeriod";
			dataTableMapping.ColumnMappings.Add("PaymentMethod", "PaymentMethod");
			dataTableMapping.ColumnMappings.Add("Sales", "Sales");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x060027A8 RID: 10152 RVA: 0x00156052 File Offset: 0x00154252
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString;
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x00156078 File Offset: 0x00154278
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.BillingSalesBreakdownForUserPeriod";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@theuser", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@shiftdateStart", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@shiftdateEnd", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x060027AA RID: 10154 RVA: 0x00156234 File Offset: 0x00154434
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.BillingSalesBreakdownForUserPeriodDataTable dataTable, int? coid, string branch, string theuser, int? shiftdateStart, int? shiftdateEnd)
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
			bool flag3 = theuser == null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = theuser;
			}
			bool flag4 = shiftdateStart != null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = shiftdateStart.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[4].Value = DBNull.Value;
			}
			bool flag5 = shiftdateEnd != null;
			if (flag5)
			{
				this.Adapter.SelectCommand.Parameters[5].Value = shiftdateEnd.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[5].Value = DBNull.Value;
			}
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x060027AB RID: 10155 RVA: 0x00156428 File Offset: 0x00154628
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.BillingSalesBreakdownForUserPeriodDataTable GetData(int? coid, string branch, string theuser, int? shiftdateStart, int? shiftdateEnd)
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
			bool flag3 = theuser == null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = theuser;
			}
			bool flag4 = shiftdateStart != null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = shiftdateStart.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[4].Value = DBNull.Value;
			}
			bool flag5 = shiftdateEnd != null;
			if (flag5)
			{
				this.Adapter.SelectCommand.Parameters[5].Value = shiftdateEnd.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[5].Value = DBNull.Value;
			}
			POSDataSet.BillingSalesBreakdownForUserPeriodDataTable billingSalesBreakdownForUserPeriodDataTable = new POSDataSet.BillingSalesBreakdownForUserPeriodDataTable();
			this.Adapter.Fill(billingSalesBreakdownForUserPeriodDataTable);
			return billingSalesBreakdownForUserPeriodDataTable;
		}

		// Token: 0x040011D4 RID: 4564
		private SqlConnection _connection;

		// Token: 0x040011D5 RID: 4565
		private SqlTransaction _transaction;

		// Token: 0x040011D6 RID: 4566
		private SqlCommand[] _commandCollection;

		// Token: 0x040011D7 RID: 4567
		private bool _clearBeforeFill;
	}
}
