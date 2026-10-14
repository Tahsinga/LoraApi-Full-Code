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
	// Token: 0x020000A4 RID: 164
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class InsertNewProductTableAdapter : Component
	{
		// Token: 0x17000CF5 RID: 3317
		// (get) Token: 0x060022DC RID: 8924 RVA: 0x00132885 File Offset: 0x00130A85
		// (set) Token: 0x060022DD RID: 8925 RVA: 0x0013288F File Offset: 0x00130A8F
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x060022DE RID: 8926 RVA: 0x00132898 File Offset: 0x00130A98
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public InsertNewProductTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000CF6 RID: 3318
		// (get) Token: 0x060022DF RID: 8927 RVA: 0x001328AC File Offset: 0x00130AAC
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

		// Token: 0x17000CF7 RID: 3319
		// (get) Token: 0x060022E0 RID: 8928 RVA: 0x001328DC File Offset: 0x00130ADC
		// (set) Token: 0x060022E1 RID: 8929 RVA: 0x0013290C File Offset: 0x00130B0C
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

		// Token: 0x17000CF8 RID: 3320
		// (get) Token: 0x060022E2 RID: 8930 RVA: 0x001329D0 File Offset: 0x00130BD0
		// (set) Token: 0x060022E3 RID: 8931 RVA: 0x001329E8 File Offset: 0x00130BE8
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

		// Token: 0x17000CF9 RID: 3321
		// (get) Token: 0x060022E4 RID: 8932 RVA: 0x00132AD0 File Offset: 0x00130CD0
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

		// Token: 0x17000CFA RID: 3322
		// (get) Token: 0x060022E5 RID: 8933 RVA: 0x00132B00 File Offset: 0x00130D00
		// (set) Token: 0x060022E6 RID: 8934 RVA: 0x00132B18 File Offset: 0x00130D18
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

		// Token: 0x060022E7 RID: 8935 RVA: 0x00132B24 File Offset: 0x00130D24
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "InsertNewProduct";
			dataTableMapping.ColumnMappings.Add("id", "id");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x060022E8 RID: 8936 RVA: 0x00132B84 File Offset: 0x00130D84
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString;
		}

		// Token: 0x060022E9 RID: 8937 RVA: 0x00132BA8 File Offset: 0x00130DA8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.InsertNewProduct";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@catid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@productdesc", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@cost", SqlDbType.Float, 8, ParameterDirection.Input, 53, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@sellingprice", SqlDbType.Float, 8, ParameterDirection.Input, 53, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@reorderlevel", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@doneby", SqlDbType.VarChar, 50, ParameterDirection.Input, 0, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@donewhen", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@new_prodtid", SqlDbType.Int, 4, ParameterDirection.InputOutput, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x00132E14 File Offset: 0x00131014
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.InsertNewProductDataTable dataTable, int? catid, string productdesc, double? cost, double? sellingprice, int? reorderlevel, string doneby, int? donewhen, ref int? new_prodtid)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = catid != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = catid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = productdesc == null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = productdesc;
			}
			bool flag3 = cost != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = cost.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag4 = sellingprice != null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = sellingprice.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[4].Value = DBNull.Value;
			}
			bool flag5 = reorderlevel != null;
			if (flag5)
			{
				this.Adapter.SelectCommand.Parameters[5].Value = reorderlevel.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[5].Value = DBNull.Value;
			}
			bool flag6 = doneby == null;
			if (flag6)
			{
				this.Adapter.SelectCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[6].Value = doneby;
			}
			bool flag7 = donewhen != null;
			if (flag7)
			{
				this.Adapter.SelectCommand.Parameters[7].Value = donewhen.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[7].Value = DBNull.Value;
			}
			bool flag8 = new_prodtid != null;
			if (flag8)
			{
				this.Adapter.SelectCommand.Parameters[8].Value = new_prodtid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[8].Value = DBNull.Value;
			}
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			int num = this.Adapter.Fill(dataTable);
			bool flag9 = this.Adapter.SelectCommand.Parameters[8].Value == null || this.Adapter.SelectCommand.Parameters[8].Value.GetType() == typeof(DBNull);
			if (flag9)
			{
				new_prodtid = null;
			}
			else
			{
				new_prodtid = new int?(Conversions.ToInteger(this.Adapter.SelectCommand.Parameters[8].Value));
			}
			return num;
		}

		// Token: 0x060022EB RID: 8939 RVA: 0x001331A4 File Offset: 0x001313A4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.InsertNewProductDataTable GetData(int? catid, string productdesc, double? cost, double? sellingprice, int? reorderlevel, string doneby, int? donewhen, ref int? new_prodtid)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			bool flag = catid != null;
			if (flag)
			{
				this.Adapter.SelectCommand.Parameters[1].Value = catid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[1].Value = DBNull.Value;
			}
			bool flag2 = productdesc == null;
			if (flag2)
			{
				this.Adapter.SelectCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[2].Value = productdesc;
			}
			bool flag3 = cost != null;
			if (flag3)
			{
				this.Adapter.SelectCommand.Parameters[3].Value = cost.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[3].Value = DBNull.Value;
			}
			bool flag4 = sellingprice != null;
			if (flag4)
			{
				this.Adapter.SelectCommand.Parameters[4].Value = sellingprice.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[4].Value = DBNull.Value;
			}
			bool flag5 = reorderlevel != null;
			if (flag5)
			{
				this.Adapter.SelectCommand.Parameters[5].Value = reorderlevel.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[5].Value = DBNull.Value;
			}
			bool flag6 = doneby == null;
			if (flag6)
			{
				this.Adapter.SelectCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[6].Value = doneby;
			}
			bool flag7 = donewhen != null;
			if (flag7)
			{
				this.Adapter.SelectCommand.Parameters[7].Value = donewhen.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[7].Value = DBNull.Value;
			}
			bool flag8 = new_prodtid != null;
			if (flag8)
			{
				this.Adapter.SelectCommand.Parameters[8].Value = new_prodtid.Value;
			}
			else
			{
				this.Adapter.SelectCommand.Parameters[8].Value = DBNull.Value;
			}
			POSDataSet.InsertNewProductDataTable insertNewProductDataTable = new POSDataSet.InsertNewProductDataTable();
			this.Adapter.Fill(insertNewProductDataTable);
			bool flag9 = this.Adapter.SelectCommand.Parameters[8].Value == null || this.Adapter.SelectCommand.Parameters[8].Value.GetType() == typeof(DBNull);
			if (flag9)
			{
				new_prodtid = null;
			}
			else
			{
				new_prodtid = new int?(Conversions.ToInteger(this.Adapter.SelectCommand.Parameters[8].Value));
			}
			return insertNewProductDataTable;
		}

		// Token: 0x04001058 RID: 4184
		private SqlConnection _connection;

		// Token: 0x04001059 RID: 4185
		private SqlTransaction _transaction;

		// Token: 0x0400105A RID: 4186
		private SqlCommand[] _commandCollection;

		// Token: 0x0400105B RID: 4187
		private bool _clearBeforeFill;
	}
}
