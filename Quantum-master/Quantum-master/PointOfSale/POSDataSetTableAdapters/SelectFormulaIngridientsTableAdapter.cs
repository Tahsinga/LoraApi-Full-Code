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
	// Token: 0x0200010B RID: 267
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class SelectFormulaIngridientsTableAdapter : Component
	{
		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x06002951 RID: 10577 RVA: 0x00163BC8 File Offset: 0x00161DC8
		// (set) Token: 0x06002952 RID: 10578 RVA: 0x00163BD2 File Offset: 0x00161DD2
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002953 RID: 10579 RVA: 0x00163BDB File Offset: 0x00161DDB
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public SelectFormulaIngridientsTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x06002954 RID: 10580 RVA: 0x00163BF0 File Offset: 0x00161DF0
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

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x06002955 RID: 10581 RVA: 0x00163C20 File Offset: 0x00161E20
		// (set) Token: 0x06002956 RID: 10582 RVA: 0x00163C50 File Offset: 0x00161E50
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

		// Token: 0x17000F62 RID: 3938
		// (get) Token: 0x06002957 RID: 10583 RVA: 0x00163D14 File Offset: 0x00161F14
		// (set) Token: 0x06002958 RID: 10584 RVA: 0x00163D2C File Offset: 0x00161F2C
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

		// Token: 0x17000F63 RID: 3939
		// (get) Token: 0x06002959 RID: 10585 RVA: 0x00163E14 File Offset: 0x00162014
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

		// Token: 0x17000F64 RID: 3940
		// (get) Token: 0x0600295A RID: 10586 RVA: 0x00163E44 File Offset: 0x00162044
		// (set) Token: 0x0600295B RID: 10587 RVA: 0x00163E5C File Offset: 0x0016205C
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

		// Token: 0x0600295C RID: 10588 RVA: 0x00163E68 File Offset: 0x00162068
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "SelectFormulaIngridients";
			dataTableMapping.ColumnMappings.Add("productid", "productid");
			dataTableMapping.ColumnMappings.Add("ProductDesc", "ProductDesc");
			dataTableMapping.ColumnMappings.Add("qty", "qty");
			dataTableMapping.ColumnMappings.Add("EntryNo", "EntryNo");
			dataTableMapping.ColumnMappings.Add("Cost", "Cost");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x0600295D RID: 10589 RVA: 0x00163F20 File Offset: 0x00162120
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString1;
		}

		// Token: 0x0600295E RID: 10590 RVA: 0x00163F44 File Offset: 0x00162144
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.SelectFormulaIngridients";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@formulaname", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x0600295F RID: 10591 RVA: 0x00164050 File Offset: 0x00162250
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.SelectFormulaIngridientsDataTable dataTable, int? coid, string formulaname)
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
			bool flag2 = formulaname == null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = formulaname;
			}
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x00164140 File Offset: 0x00162340
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.SelectFormulaIngridientsDataTable GetData(int? coid, string formulaname)
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
			bool flag2 = formulaname == null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = formulaname;
			}
			POSDataSet.SelectFormulaIngridientsDataTable selectFormulaIngridientsDataTable = new POSDataSet.SelectFormulaIngridientsDataTable();
			this.Adapter.Fill(selectFormulaIngridientsDataTable);
			return selectFormulaIngridientsDataTable;
		}

		// Token: 0x0400125B RID: 4699
		private SqlConnection _connection;

		// Token: 0x0400125C RID: 4700
		private SqlTransaction _transaction;

		// Token: 0x0400125D RID: 4701
		private SqlCommand[] _commandCollection;

		// Token: 0x0400125E RID: 4702
		private bool _clearBeforeFill;
	}
}
