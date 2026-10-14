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
	// Token: 0x020000DF RID: 223
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class SalesPaymentSummaryPERIODTableAdapter : Component
	{
		// Token: 0x17000E57 RID: 3671
		// (get) Token: 0x0600268C RID: 9868 RVA: 0x0014D25A File Offset: 0x0014B45A
		// (set) Token: 0x0600268D RID: 9869 RVA: 0x0014D264 File Offset: 0x0014B464
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x0014D26D File Offset: 0x0014B46D
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public SalesPaymentSummaryPERIODTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x0600268F RID: 9871 RVA: 0x0014D280 File Offset: 0x0014B480
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

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x06002690 RID: 9872 RVA: 0x0014D2B0 File Offset: 0x0014B4B0
		// (set) Token: 0x06002691 RID: 9873 RVA: 0x0014D2E0 File Offset: 0x0014B4E0
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

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x06002692 RID: 9874 RVA: 0x0014D3A4 File Offset: 0x0014B5A4
		// (set) Token: 0x06002693 RID: 9875 RVA: 0x0014D3BC File Offset: 0x0014B5BC
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

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x06002694 RID: 9876 RVA: 0x0014D4A4 File Offset: 0x0014B6A4
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

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x06002695 RID: 9877 RVA: 0x0014D4D4 File Offset: 0x0014B6D4
		// (set) Token: 0x06002696 RID: 9878 RVA: 0x0014D4EC File Offset: 0x0014B6EC
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

		// Token: 0x06002697 RID: 9879 RVA: 0x0014D4F8 File Offset: 0x0014B6F8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "SalesPaymentSummaryPERIOD";
			dataTableMapping.ColumnMappings.Add("PaymentMethodDesc", "PaymentMethodDesc");
			dataTableMapping.ColumnMappings.Add("Revenue", "Revenue");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002698 RID: 9880 RVA: 0x0014D56E File Offset: 0x0014B76E
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString;
		}

		// Token: 0x06002699 RID: 9881 RVA: 0x0014D594 File Offset: 0x0014B794
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.SalesPaymentSummaryPERIOD";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@startdate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@enddate", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x0600269A RID: 9882 RVA: 0x0014D714 File Offset: 0x0014B914
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.SalesPaymentSummaryPERIODDataTable dataTable, int? startdate, int? enddate, int? coid, string branch)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = startdate != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = startdate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = enddate != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = enddate.Value;
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
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x0600269B RID: 9883 RVA: 0x0014D8BC File Offset: 0x0014BABC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.SalesPaymentSummaryPERIODDataTable GetData(int? startdate, int? enddate, int? coid, string branch)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = startdate != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = startdate.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = enddate != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = enddate.Value;
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
			POSDataSet.SalesPaymentSummaryPERIODDataTable salesPaymentSummaryPERIODDataTable = new POSDataSet.SalesPaymentSummaryPERIODDataTable();
			this.Adapter.Fill(salesPaymentSummaryPERIODDataTable);
			return salesPaymentSummaryPERIODDataTable;
		}

		// Token: 0x0400117F RID: 4479
		private SqlConnection _connection;

		// Token: 0x04001180 RID: 4480
		private SqlTransaction _transaction;

		// Token: 0x04001181 RID: 4481
		private SqlCommand[] _commandCollection;

		// Token: 0x04001182 RID: 4482
		private bool _clearBeforeFill;
	}
}
