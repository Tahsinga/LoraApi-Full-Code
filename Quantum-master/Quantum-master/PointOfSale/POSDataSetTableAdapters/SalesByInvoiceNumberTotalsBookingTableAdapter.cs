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
	// Token: 0x02000116 RID: 278
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class SalesByInvoiceNumberTotalsBookingTableAdapter : Component
	{
		// Token: 0x17000FA1 RID: 4001
		// (get) Token: 0x06002A01 RID: 10753 RVA: 0x00168FAC File Offset: 0x001671AC
		// (set) Token: 0x06002A02 RID: 10754 RVA: 0x00168FB6 File Offset: 0x001671B6
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002A03 RID: 10755 RVA: 0x00168FBF File Offset: 0x001671BF
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public SalesByInvoiceNumberTotalsBookingTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x06002A04 RID: 10756 RVA: 0x00168FD4 File Offset: 0x001671D4
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

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x06002A05 RID: 10757 RVA: 0x00169004 File Offset: 0x00167204
		// (set) Token: 0x06002A06 RID: 10758 RVA: 0x00169034 File Offset: 0x00167234
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

		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x06002A07 RID: 10759 RVA: 0x001690F8 File Offset: 0x001672F8
		// (set) Token: 0x06002A08 RID: 10760 RVA: 0x00169110 File Offset: 0x00167310
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

		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x06002A09 RID: 10761 RVA: 0x001691F8 File Offset: 0x001673F8
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

		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x06002A0A RID: 10762 RVA: 0x00169228 File Offset: 0x00167428
		// (set) Token: 0x06002A0B RID: 10763 RVA: 0x00169240 File Offset: 0x00167440
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

		// Token: 0x06002A0C RID: 10764 RVA: 0x0016924C File Offset: 0x0016744C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "SalesByInvoiceNumberTotalsBooking";
			dataTableMapping.ColumnMappings.Add("TotalExcl", "TotalExcl");
			dataTableMapping.ColumnMappings.Add("therate", "therate");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002A0D RID: 10765 RVA: 0x001692C2 File Offset: 0x001674C2
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString1;
		}

		// Token: 0x06002A0E RID: 10766 RVA: 0x001692E8 File Offset: 0x001674E8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.SalesByInvoiceNumberTotalsBooking";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@invoicenum", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002A0F RID: 10767 RVA: 0x001693F4 File Offset: 0x001675F4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.SalesByInvoiceNumberTotalsBookingDataTable dataTable, int? invoicenum, int? coid)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = invoicenum != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = invoicenum.Value;
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
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x06002A10 RID: 10768 RVA: 0x001694F0 File Offset: 0x001676F0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.SalesByInvoiceNumberTotalsBookingDataTable GetData(int? invoicenum, int? coid)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = invoicenum != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = invoicenum.Value;
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
			POSDataSet.SalesByInvoiceNumberTotalsBookingDataTable salesByInvoiceNumberTotalsBookingDataTable = new POSDataSet.SalesByInvoiceNumberTotalsBookingDataTable();
			this.Adapter.Fill(salesByInvoiceNumberTotalsBookingDataTable);
			return salesByInvoiceNumberTotalsBookingDataTable;
		}

		// Token: 0x04001292 RID: 4754
		private SqlConnection _connection;

		// Token: 0x04001293 RID: 4755
		private SqlTransaction _transaction;

		// Token: 0x04001294 RID: 4756
		private SqlCommand[] _commandCollection;

		// Token: 0x04001295 RID: 4757
		private bool _clearBeforeFill;
	}
}
