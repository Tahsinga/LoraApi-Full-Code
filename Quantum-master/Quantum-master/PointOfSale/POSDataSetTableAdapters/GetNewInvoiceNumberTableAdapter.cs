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
	// Token: 0x020000A2 RID: 162
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class GetNewInvoiceNumberTableAdapter : Component
	{
		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x060022BC RID: 8892 RVA: 0x00131A76 File Offset: 0x0012FC76
		// (set) Token: 0x060022BD RID: 8893 RVA: 0x00131A80 File Offset: 0x0012FC80
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x00131A89 File Offset: 0x0012FC89
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public GetNewInvoiceNumberTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x060022BF RID: 8895 RVA: 0x00131A9C File Offset: 0x0012FC9C
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

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x060022C0 RID: 8896 RVA: 0x00131ACC File Offset: 0x0012FCCC
		// (set) Token: 0x060022C1 RID: 8897 RVA: 0x00131AFC File Offset: 0x0012FCFC
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

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x060022C2 RID: 8898 RVA: 0x00131BC0 File Offset: 0x0012FDC0
		// (set) Token: 0x060022C3 RID: 8899 RVA: 0x00131BD8 File Offset: 0x0012FDD8
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

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x060022C4 RID: 8900 RVA: 0x00131CC0 File Offset: 0x0012FEC0
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

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x060022C5 RID: 8901 RVA: 0x00131CF0 File Offset: 0x0012FEF0
		// (set) Token: 0x060022C6 RID: 8902 RVA: 0x00131D08 File Offset: 0x0012FF08
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

		// Token: 0x060022C7 RID: 8903 RVA: 0x00131D14 File Offset: 0x0012FF14
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "GetNewInvoiceNumber";
			dataTableMapping.ColumnMappings.Add("id", "id");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x060022C8 RID: 8904 RVA: 0x00131D74 File Offset: 0x0012FF74
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString;
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x00131D98 File Offset: 0x0012FF98
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.GetNewInvoiceNumber";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@desc", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@newinvoicenum", SqlDbType.Int, 4, ParameterDirection.InputOutput, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x00131EA4 File Offset: 0x001300A4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.GetNewInvoiceNumberDataTable dataTable, string desc, ref int? newinvoicenum)
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
			bool flag2 = newinvoicenum != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = newinvoicenum.Value;
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
				newinvoicenum = null;
			}
			else
			{
				newinvoicenum = new int?(Conversions.ToInteger(this.Adapter.SelectCommand.Parameters[2].Value));
			}
			return num;
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x00132018 File Offset: 0x00130218
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.GetNewInvoiceNumberDataTable GetData(string desc, ref int? newinvoicenum)
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
			bool flag2 = newinvoicenum != null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = newinvoicenum.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			POSDataSet.GetNewInvoiceNumberDataTable getNewInvoiceNumberDataTable = new POSDataSet.GetNewInvoiceNumberDataTable();
			this.Adapter.Fill(getNewInvoiceNumberDataTable);
			bool flag3 = this.Adapter.SelectCommand.Parameters[2].Value == null || this.Adapter.SelectCommand.Parameters[2].Value.GetType() == typeof(DBNull);
			if (flag3)
			{
				newinvoicenum = null;
			}
			else
			{
				newinvoicenum = new int?(Conversions.ToInteger(this.Adapter.SelectCommand.Parameters[2].Value));
			}
			return getNewInvoiceNumberDataTable;
		}

		// Token: 0x0400104E RID: 4174
		private SqlConnection _connection;

		// Token: 0x0400104F RID: 4175
		private SqlTransaction _transaction;

		// Token: 0x04001050 RID: 4176
		private SqlCommand[] _commandCollection;

		// Token: 0x04001051 RID: 4177
		private bool _clearBeforeFill;
	}
}
