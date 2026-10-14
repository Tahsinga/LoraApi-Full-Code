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
	// Token: 0x02000119 RID: 281
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class SalesbyTaxPeriodTableAdapter : Component
	{
		// Token: 0x17000FB3 RID: 4019
		// (get) Token: 0x06002A31 RID: 10801 RVA: 0x0016A6CC File Offset: 0x001688CC
		// (set) Token: 0x06002A32 RID: 10802 RVA: 0x0016A6D6 File Offset: 0x001688D6
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x0016A6DF File Offset: 0x001688DF
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public SalesbyTaxPeriodTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000FB4 RID: 4020
		// (get) Token: 0x06002A34 RID: 10804 RVA: 0x0016A6F4 File Offset: 0x001688F4
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

		// Token: 0x17000FB5 RID: 4021
		// (get) Token: 0x06002A35 RID: 10805 RVA: 0x0016A724 File Offset: 0x00168924
		// (set) Token: 0x06002A36 RID: 10806 RVA: 0x0016A754 File Offset: 0x00168954
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

		// Token: 0x17000FB6 RID: 4022
		// (get) Token: 0x06002A37 RID: 10807 RVA: 0x0016A818 File Offset: 0x00168A18
		// (set) Token: 0x06002A38 RID: 10808 RVA: 0x0016A830 File Offset: 0x00168A30
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

		// Token: 0x17000FB7 RID: 4023
		// (get) Token: 0x06002A39 RID: 10809 RVA: 0x0016A918 File Offset: 0x00168B18
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

		// Token: 0x17000FB8 RID: 4024
		// (get) Token: 0x06002A3A RID: 10810 RVA: 0x0016A948 File Offset: 0x00168B48
		// (set) Token: 0x06002A3B RID: 10811 RVA: 0x0016A960 File Offset: 0x00168B60
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

		// Token: 0x06002A3C RID: 10812 RVA: 0x0016A96C File Offset: 0x00168B6C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "SalesbyTaxPeriod";
			dataTableMapping.ColumnMappings.Add("ZeroTaxSales", "ZeroTaxSales");
			dataTableMapping.ColumnMappings.Add("TaxSales", "TaxSales");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002A3D RID: 10813 RVA: 0x0016A9E2 File Offset: 0x00168BE2
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002A3E RID: 10814 RVA: 0x0016AA08 File Offset: 0x00168C08
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.SalesbyTaxPeriod";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@shiftdateStart", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@shiftdateEnd", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@theuser", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002A3F RID: 10815 RVA: 0x0016ABC4 File Offset: 0x00168DC4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.SalesbyTaxPeriodDataTable dataTable, int? coid, int? shiftdateStart, int? shiftdateEnd, string branch, string theuser)
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
			bool flag2 = shiftdateStart != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = shiftdateStart.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = shiftdateEnd != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = shiftdateEnd.Value;
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

		// Token: 0x06002A40 RID: 10816 RVA: 0x0016ADB8 File Offset: 0x00168FB8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.SalesbyTaxPeriodDataTable GetData(int? coid, int? shiftdateStart, int? shiftdateEnd, string branch, string theuser)
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
			bool flag2 = shiftdateStart != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = shiftdateStart.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			bool flag3 = shiftdateEnd != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = shiftdateEnd.Value;
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
			POSDataSet.SalesbyTaxPeriodDataTable salesbyTaxPeriodDataTable = new POSDataSet.SalesbyTaxPeriodDataTable();
			this.Adapter.Fill(salesbyTaxPeriodDataTable);
			return salesbyTaxPeriodDataTable;
		}

		// Token: 0x040012A1 RID: 4769
		private SqlConnection _connection;

		// Token: 0x040012A2 RID: 4770
		private SqlTransaction _transaction;

		// Token: 0x040012A3 RID: 4771
		private SqlCommand[] _commandCollection;

		// Token: 0x040012A4 RID: 4772
		private bool _clearBeforeFill;
	}
}
