using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;

namespace PointOfSale.POSDataSetTableAdapters
{
	// Token: 0x020000A3 RID: 163
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class GetSalesInvoiceNumberTableAdapter : Component
	{
		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x060022CC RID: 8908 RVA: 0x0013217D File Offset: 0x0013037D
		// (set) Token: 0x060022CD RID: 8909 RVA: 0x00132187 File Offset: 0x00130387
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060022CE RID: 8910 RVA: 0x00132190 File Offset: 0x00130390
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public GetSalesInvoiceNumberTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x060022CF RID: 8911 RVA: 0x001321A4 File Offset: 0x001303A4
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

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x060022D0 RID: 8912 RVA: 0x001321D4 File Offset: 0x001303D4
		// (set) Token: 0x060022D1 RID: 8913 RVA: 0x00132204 File Offset: 0x00130404
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

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x060022D2 RID: 8914 RVA: 0x001322C8 File Offset: 0x001304C8
		// (set) Token: 0x060022D3 RID: 8915 RVA: 0x001322E0 File Offset: 0x001304E0
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

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x060022D4 RID: 8916 RVA: 0x001323C8 File Offset: 0x001305C8
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

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x060022D5 RID: 8917 RVA: 0x001323F8 File Offset: 0x001305F8
		// (set) Token: 0x060022D6 RID: 8918 RVA: 0x00132410 File Offset: 0x00130610
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

		// Token: 0x060022D7 RID: 8919 RVA: 0x0013241C File Offset: 0x0013061C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "GetSalesInvoiceNumber";
			dataTableMapping.ColumnMappings.Add("id", "id");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x060022D8 RID: 8920 RVA: 0x0013247C File Offset: 0x0013067C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString;
		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x001324A0 File Offset: 0x001306A0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.GetSalesInvoiceNumber";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@desc", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@newinvoicenumber", SqlDbType.Int, 4, ParameterDirection.InputOutput, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x060022DA RID: 8922 RVA: 0x001325AC File Offset: 0x001307AC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.GetSalesInvoiceNumberDataTable dataTable, string desc, ref int? newinvoicenumber)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = desc == null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = desc;
			}
			bool flag2 = newinvoicenumber != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = newinvoicenumber.Value;
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
			int num = this.Adapter.Fill(dataTable);
			bool flag3 = this.Adapter.SelectCommand.Parameters[2].Value == null || this.Adapter.SelectCommand.Parameters[2].Value.GetType() == typeof(DBNull);
			if (flag3)
			{
				newinvoicenumber = null;
			}
			else
			{
				newinvoicenumber = new int?(Conversions.ToInteger(this.Adapter.SelectCommand.Parameters[2].Value));
			}
			return num;
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x00132720 File Offset: 0x00130920
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.GetSalesInvoiceNumberDataTable GetData(string desc, ref int? newinvoicenumber)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = desc == null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = desc;
			}
			bool flag2 = newinvoicenumber != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = newinvoicenumber.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			POSDataSet.GetSalesInvoiceNumberDataTable getSalesInvoiceNumberDataTable = new POSDataSet.GetSalesInvoiceNumberDataTable();
			this.Adapter.Fill(getSalesInvoiceNumberDataTable);
			bool flag3 = this.Adapter.SelectCommand.Parameters[2].Value == null || this.Adapter.SelectCommand.Parameters[2].Value.GetType() == typeof(DBNull);
			if (flag3)
			{
				newinvoicenumber = null;
			}
			else
			{
				newinvoicenumber = new int?(Conversions.ToInteger(this.Adapter.SelectCommand.Parameters[2].Value));
			}
			return getSalesInvoiceNumberDataTable;
		}

		// Token: 0x04001053 RID: 4179
		private SqlConnection _connection;

		// Token: 0x04001054 RID: 4180
		private SqlTransaction _transaction;

		// Token: 0x04001055 RID: 4181
		private SqlCommand[] _commandCollection;

		// Token: 0x04001056 RID: 4182
		private bool _clearBeforeFill;
	}
}
