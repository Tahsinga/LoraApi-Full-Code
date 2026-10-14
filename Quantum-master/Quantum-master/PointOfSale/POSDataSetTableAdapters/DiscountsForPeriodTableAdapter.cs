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
	// Token: 0x02000101 RID: 257
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class DiscountsForPeriodTableAdapter : Component
	{
		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x060028B1 RID: 10417 RVA: 0x0015E8B9 File Offset: 0x0015CAB9
		// (set) Token: 0x060028B2 RID: 10418 RVA: 0x0015E8C3 File Offset: 0x0015CAC3
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060028B3 RID: 10419 RVA: 0x0015E8CC File Offset: 0x0015CACC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public DiscountsForPeriodTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x060028B4 RID: 10420 RVA: 0x0015E8E0 File Offset: 0x0015CAE0
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

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x060028B5 RID: 10421 RVA: 0x0015E910 File Offset: 0x0015CB10
		// (set) Token: 0x060028B6 RID: 10422 RVA: 0x0015E940 File Offset: 0x0015CB40
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

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x060028B7 RID: 10423 RVA: 0x0015EA04 File Offset: 0x0015CC04
		// (set) Token: 0x060028B8 RID: 10424 RVA: 0x0015EA1C File Offset: 0x0015CC1C
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

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x060028B9 RID: 10425 RVA: 0x0015EB04 File Offset: 0x0015CD04
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

		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x060028BA RID: 10426 RVA: 0x0015EB34 File Offset: 0x0015CD34
		// (set) Token: 0x060028BB RID: 10427 RVA: 0x0015EB4C File Offset: 0x0015CD4C
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

		// Token: 0x060028BC RID: 10428 RVA: 0x0015EB58 File Offset: 0x0015CD58
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "DiscountsForPeriod";
			dataTableMapping.ColumnMappings.Add("ReceiptDisplayPaymentMethod", "ReceiptDisplayPaymentMethod");
			dataTableMapping.ColumnMappings.Add("PaymentMethodDesc", "PaymentMethodDesc");
			dataTableMapping.ColumnMappings.Add("Discount_Given", "Discount_Given");
			dataTableMapping.ColumnMappings.Add("BaseCurrencyEquiv", "BaseCurrencyEquiv");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x060028BD RID: 10429 RVA: 0x0015EBFA File Offset: 0x0015CDFA
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString1;
		}

		// Token: 0x060028BE RID: 10430 RVA: 0x0015EC20 File Offset: 0x0015CE20
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.DiscountsForPeriod";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@shiftdateStart", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@shiftdateEnd", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@branch", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x060028BF RID: 10431 RVA: 0x0015EDA0 File Offset: 0x0015CFA0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.DiscountsForPeriodDataTable dataTable, int? shiftdateStart, int? shiftdateEnd, int? coid, string branch)
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
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x060028C0 RID: 10432 RVA: 0x0015EF48 File Offset: 0x0015D148
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.DiscountsForPeriodDataTable GetData(int? shiftdateStart, int? shiftdateEnd, int? coid, string branch)
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
			POSDataSet.DiscountsForPeriodDataTable discountsForPeriodDataTable = new POSDataSet.DiscountsForPeriodDataTable();
			this.Adapter.Fill(discountsForPeriodDataTable);
			return discountsForPeriodDataTable;
		}

		// Token: 0x04001229 RID: 4649
		private SqlConnection _connection;

		// Token: 0x0400122A RID: 4650
		private SqlTransaction _transaction;

		// Token: 0x0400122B RID: 4651
		private SqlCommand[] _commandCollection;

		// Token: 0x0400122C RID: 4652
		private bool _clearBeforeFill;
	}
}
