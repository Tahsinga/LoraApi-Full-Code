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
	// Token: 0x0200011B RID: 283
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[HelpKeyword("vs.data.TableAdapter")]
	public class SelectPaymentMethodsTableAdapter : Component
	{
		// Token: 0x17000FBF RID: 4031
		// (get) Token: 0x06002A51 RID: 10833 RVA: 0x0016B796 File Offset: 0x00169996
		// (set) Token: 0x06002A52 RID: 10834 RVA: 0x0016B7A0 File Offset: 0x001699A0
		private virtual SqlDataAdapter _adapter
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06002A53 RID: 10835 RVA: 0x0016B7A9 File Offset: 0x001699A9
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public SelectPaymentMethodsTableAdapter()
		{
			this.ClearBeforeFill = true;
		}

		// Token: 0x17000FC0 RID: 4032
		// (get) Token: 0x06002A54 RID: 10836 RVA: 0x0016B7BC File Offset: 0x001699BC
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

		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x06002A55 RID: 10837 RVA: 0x0016B7EC File Offset: 0x001699EC
		// (set) Token: 0x06002A56 RID: 10838 RVA: 0x0016B81C File Offset: 0x00169A1C
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

		// Token: 0x17000FC2 RID: 4034
		// (get) Token: 0x06002A57 RID: 10839 RVA: 0x0016B8E0 File Offset: 0x00169AE0
		// (set) Token: 0x06002A58 RID: 10840 RVA: 0x0016B8F8 File Offset: 0x00169AF8
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

		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x06002A59 RID: 10841 RVA: 0x0016B9E0 File Offset: 0x00169BE0
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

		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x06002A5A RID: 10842 RVA: 0x0016BA10 File Offset: 0x00169C10
		// (set) Token: 0x06002A5B RID: 10843 RVA: 0x0016BA28 File Offset: 0x00169C28
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

		// Token: 0x06002A5C RID: 10844 RVA: 0x0016BA34 File Offset: 0x00169C34
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new SqlDataAdapter();
			DataTableMapping dataTableMapping = new DataTableMapping();
			dataTableMapping.SourceTable = "Table";
			dataTableMapping.DataSetTable = "SelectPaymentMethods";
			dataTableMapping.ColumnMappings.Add("paymentmethodID", "paymentmethodID");
			dataTableMapping.ColumnMappings.Add("Currency", "Currency");
			dataTableMapping.ColumnMappings.Add("CurrencyIDEltrade", "CurrencyIDEltrade");
			dataTableMapping.ColumnMappings.Add("paymentMethodDesc", "paymentMethodDesc");
			dataTableMapping.ColumnMappings.Add("Uploaded", "Uploaded");
			dataTableMapping.ColumnMappings.Add("Rate", "Rate");
			dataTableMapping.ColumnMappings.Add("FiscalGroup", "FiscalGroup");
			dataTableMapping.ColumnMappings.Add("DiscountPerc", "DiscountPerc");
			dataTableMapping.ColumnMappings.Add("RequiresRef", "RequiresRef");
			dataTableMapping.ColumnMappings.Add("BPNumber", "BPNumber");
			dataTableMapping.ColumnMappings.Add("VATNumber", "VATNumber");
			this._adapter.TableMappings.Add(dataTableMapping);
		}

		// Token: 0x06002A5D RID: 10845 RVA: 0x0016BB70 File Offset: 0x00169D70
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new SqlConnection();
			this._connection.ConnectionString = MySettings.Default.POSConnectionString2;
		}

		// Token: 0x06002A5E RID: 10846 RVA: 0x0016BB94 File Offset: 0x00169D94
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new SqlCommand[1];
			this._commandCollection[0] = new SqlCommand();
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "dbo.SelectPaymentMethods";
			this._commandCollection[0].CommandType = CommandType.StoredProcedure;
			this._commandCollection[0].Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
			this._commandCollection[0].Parameters.Add(new SqlParameter("@coid", SqlDbType.Int, 4, ParameterDirection.Input, 10, 0, null, DataRowVersion.Current, false, null, "", "", ""));
		}

		// Token: 0x06002A5F RID: 10847 RVA: 0x0016BC68 File Offset: 0x00169E68
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		public virtual int Fill(POSDataSet.SelectPaymentMethodsDataTable dataTable, int? coid)
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
			bool clearBeforeFill = this.ClearBeforeFill;
			if (clearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		// Token: 0x06002A60 RID: 10848 RVA: 0x0016BD08 File Offset: 0x00169F08
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		[DataObjectMethod(DataObjectMethodType.Select, true)]
		public virtual POSDataSet.SelectPaymentMethodsDataTable GetData(int? coid)
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
			POSDataSet.SelectPaymentMethodsDataTable selectPaymentMethodsDataTable = new POSDataSet.SelectPaymentMethodsDataTable();
			this.Adapter.Fill(selectPaymentMethodsDataTable);
			return selectPaymentMethodsDataTable;
		}

		// Token: 0x040012AB RID: 4779
		private SqlConnection _connection;

		// Token: 0x040012AC RID: 4780
		private SqlTransaction _transaction;

		// Token: 0x040012AD RID: 4781
		private SqlCommand[] _commandCollection;

		// Token: 0x040012AE RID: 4782
		private bool _clearBeforeFill;
	}
}
