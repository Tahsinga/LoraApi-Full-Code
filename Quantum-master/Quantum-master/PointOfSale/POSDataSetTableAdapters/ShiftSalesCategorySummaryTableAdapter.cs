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
	// Token: 0x020000D2 RID: 210
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class ShiftSalesCategorySummaryTableAdapter : Component
	{
		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x060025BC RID: 9660 RVA: 0x00146BA8 File Offset: 0x00144DA8
		// (set) Token: 0x060025BD RID: 9661 RVA: 0x00146BB2 File Offset: 0x00144DB2
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060025BE RID: 9662 RVA: 0x00146BBB File Offset: 0x00144DBB
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public ShiftSalesCategorySummaryTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x060025BF RID: 9663 RVA: 0x00146BD0 File Offset: 0x00144DD0
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

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x060025C0 RID: 9664 RVA: 0x00146C00 File Offset: 0x00144E00
		// (set) Token: 0x060025C1 RID: 9665 RVA: 0x00146C30 File Offset: 0x00144E30
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

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x060025C2 RID: 9666 RVA: 0x00146CF4 File Offset: 0x00144EF4
		// (set) Token: 0x060025C3 RID: 9667 RVA: 0x00146D0C File Offset: 0x00144F0C
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

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x060025C4 RID: 9668 RVA: 0x00146DF4 File Offset: 0x00144FF4
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

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x060025C5 RID: 9669 RVA: 0x00146E24 File Offset: 0x00145024
		// (set) Token: 0x060025C6 RID: 9670 RVA: 0x00146E3C File Offset: 0x0014503C
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

		// Token: 0x060025C7 RID: 9671 RVA: 0x00146E48 File Offset: 0x00145048
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "ShiftSalesCategorySummary";
			dataTableMapping.ColumnMappings.Add("CatDesc", "CatDesc");
			dataTableMapping.ColumnMappings.Add("RevenueDayShift", "RevenueDayShift");
			dataTableMapping.ColumnMappings.Add("RevenueNightShift", "RevenueNightShift");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x00146ED4 File Offset: 0x001450D4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString;
		}

		// Token: 0x060025C9 RID: 9673 RVA: 0x00146EF8 File Offset: 0x001450F8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.ShiftSalesCategorySummary";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@theday", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x060025CA RID: 9674 RVA: 0x00147040 File Offset: 0x00145240
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.ShiftSalesCategorySummaryDataTable dataTable, int? theday, int? coid, string branch)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = theday != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = theday.Value;
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
			bool flag3 = branch == null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = branch;
			}
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x060025CB RID: 9675 RVA: 0x0014718C File Offset: 0x0014538C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.ShiftSalesCategorySummaryDataTable GetData(int? theday, int? coid, string branch)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = theday != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = theday.Value;
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
			bool flag3 = branch == null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = branch;
			}
			POSDataSet.ShiftSalesCategorySummaryDataTable shiftSalesCategorySummaryDataTable = new POSDataSet.ShiftSalesCategorySummaryDataTable();
			this.Adapter.Fill(shiftSalesCategorySummaryDataTable);
			return shiftSalesCategorySummaryDataTable;
		}

		// Token: 0x0400113E RID: 4414
		private SqlConnection _connection;

		// Token: 0x0400113F RID: 4415
		private SqlTransaction _transaction;

		// Token: 0x04001140 RID: 4416
		private SqlCommand[] _commandCollection;

		// Token: 0x04001141 RID: 4417
		private bool _clearBeforeFill;
	}
}
