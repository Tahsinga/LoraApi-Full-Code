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
	// Token: 0x0200009A RID: 154
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class FetchAllKeysTableAdapter : Component
	{
		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x0600223C RID: 8764 RVA: 0x0012ECA2 File Offset: 0x0012CEA2
		// (set) Token: 0x0600223D RID: 8765 RVA: 0x0012ECAC File Offset: 0x0012CEAC
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x0600223E RID: 8766 RVA: 0x0012ECB5 File Offset: 0x0012CEB5
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public FetchAllKeysTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x0600223F RID: 8767 RVA: 0x0012ECC8 File Offset: 0x0012CEC8
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

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x06002240 RID: 8768 RVA: 0x0012ECF8 File Offset: 0x0012CEF8
		// (set) Token: 0x06002241 RID: 8769 RVA: 0x0012ED28 File Offset: 0x0012CF28
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

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x06002242 RID: 8770 RVA: 0x0012EDEC File Offset: 0x0012CFEC
		// (set) Token: 0x06002243 RID: 8771 RVA: 0x0012EE04 File Offset: 0x0012D004
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

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x06002244 RID: 8772 RVA: 0x0012EEEC File Offset: 0x0012D0EC
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

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x06002245 RID: 8773 RVA: 0x0012EF1C File Offset: 0x0012D11C
		// (set) Token: 0x06002246 RID: 8774 RVA: 0x0012EF34 File Offset: 0x0012D134
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

		// Token: 0x06002247 RID: 8775 RVA: 0x0012EF40 File Offset: 0x0012D140
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "FetchAllKeys";
			dataTableMapping.ColumnMappings.Add("SerialKey", "SerialKey");
			dataTableMapping.ColumnMappings.Add("used", "used");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002248 RID: 8776 RVA: 0x0012EFB6 File Offset: 0x0012D1B6
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString;
		}

		// Token: 0x06002249 RID: 8777 RVA: 0x0012EFDC File Offset: 0x0012D1DC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.FetchAllKeys";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x0600224A RID: 8778 RVA: 0x0012F074 File Offset: 0x0012D274
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.FetchAllKeysDataTable dataTable)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x0600224B RID: 8779 RVA: 0x0012F0BC File Offset: 0x0012D2BC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.FetchAllKeysDataTable GetData()
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			POSDataSet.FetchAllKeysDataTable fetchAllKeysDataTable = new POSDataSet.FetchAllKeysDataTable();
			this.Adapter.Fill(fetchAllKeysDataTable);
			return fetchAllKeysDataTable;
		}

		// Token: 0x04001026 RID: 4134
		private SqlConnection _connection;

		// Token: 0x04001027 RID: 4135
		private SqlTransaction _transaction;

		// Token: 0x04001028 RID: 4136
		private SqlCommand[] _commandCollection;

		// Token: 0x04001029 RID: 4137
		private bool _clearBeforeFill;
	}
}
