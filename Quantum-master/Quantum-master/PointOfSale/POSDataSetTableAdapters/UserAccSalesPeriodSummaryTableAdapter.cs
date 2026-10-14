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
	// Token: 0x020000E3 RID: 227
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class UserAccSalesPeriodSummaryTableAdapter : Component
	{
		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x060026CC RID: 9932 RVA: 0x0014F321 File Offset: 0x0014D521
		// (set) Token: 0x060026CD RID: 9933 RVA: 0x0014F32B File Offset: 0x0014D52B
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060026CE RID: 9934 RVA: 0x0014F334 File Offset: 0x0014D534
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public UserAccSalesPeriodSummaryTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x060026CF RID: 9935 RVA: 0x0014F348 File Offset: 0x0014D548
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

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x060026D0 RID: 9936 RVA: 0x0014F378 File Offset: 0x0014D578
		// (set) Token: 0x060026D1 RID: 9937 RVA: 0x0014F3A8 File Offset: 0x0014D5A8
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

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x060026D2 RID: 9938 RVA: 0x0014F46C File Offset: 0x0014D66C
		// (set) Token: 0x060026D3 RID: 9939 RVA: 0x0014F484 File Offset: 0x0014D684
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

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x060026D4 RID: 9940 RVA: 0x0014F56C File Offset: 0x0014D76C
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

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x060026D5 RID: 9941 RVA: 0x0014F59C File Offset: 0x0014D79C
		// (set) Token: 0x060026D6 RID: 9942 RVA: 0x0014F5B4 File Offset: 0x0014D7B4
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

		// Token: 0x060026D7 RID: 9943 RVA: 0x0014F5C0 File Offset: 0x0014D7C0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "UserAccSalesPeriodSummary";
			dataTableMapping.ColumnMappings.Add("Total_Acc_Sales", "Total_Acc_Sales");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x060026D8 RID: 9944 RVA: 0x0014F620 File Offset: 0x0014D820
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString;
		}

		// Token: 0x060026D9 RID: 9945 RVA: 0x0014F644 File Offset: 0x0014D844
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.UserAccSalesPeriodSummary";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@shiftdateStart", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@shiftdateEnd", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@theuser", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x060026DA RID: 9946 RVA: 0x0014F800 File Offset: 0x0014DA00
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.UserAccSalesPeriodSummaryDataTable dataTable, int? shiftdateStart, int? shiftdateEnd, int? coid, string branch, string theuser)
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

		// Token: 0x060026DB RID: 9947 RVA: 0x0014F9F4 File Offset: 0x0014DBF4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.UserAccSalesPeriodSummaryDataTable GetData(int? shiftdateStart, int? shiftdateEnd, int? coid, string branch, string theuser)
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
			POSDataSet.UserAccSalesPeriodSummaryDataTable userAccSalesPeriodSummaryDataTable = new POSDataSet.UserAccSalesPeriodSummaryDataTable();
			this.Adapter.Fill(userAccSalesPeriodSummaryDataTable);
			return userAccSalesPeriodSummaryDataTable;
		}

		// Token: 0x04001193 RID: 4499
		private SqlConnection _connection;

		// Token: 0x04001194 RID: 4500
		private SqlTransaction _transaction;

		// Token: 0x04001195 RID: 4501
		private SqlCommand[] _commandCollection;

		// Token: 0x04001196 RID: 4502
		private bool _clearBeforeFill;
	}
}
