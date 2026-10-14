using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using AxWMPLib;
using Microsoft.VisualBasic.CompilerServices;
using PointOfSale.My;
using WMPLib;

namespace PointOfSale
{
	// Token: 0x020001B6 RID: 438
	[DesignerGenerated]
	public partial class SecondSalesScreen : Form
	{
		// Token: 0x06004F7D RID: 20349 RVA: 0x002F9190 File Offset: 0x002F7390
		public SecondSalesScreen()
		{
			base.Load += this.SecondSalesScreen_Load;
			this.InitializeComponent();
		}

		// Token: 0x17001D30 RID: 7472
		// (get) Token: 0x06004F80 RID: 20352 RVA: 0x002F9EC4 File Offset: 0x002F80C4
		// (set) Token: 0x06004F81 RID: 20353 RVA: 0x002F9ECE File Offset: 0x002F80CE
		internal virtual GroupBox gbSales
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D31 RID: 7473
		// (get) Token: 0x06004F82 RID: 20354 RVA: 0x002F9ED7 File Offset: 0x002F80D7
		// (set) Token: 0x06004F83 RID: 20355 RVA: 0x002F9EE1 File Offset: 0x002F80E1
		internal virtual GroupBox GroupBox2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D32 RID: 7474
		// (get) Token: 0x06004F84 RID: 20356 RVA: 0x002F9EEA File Offset: 0x002F80EA
		// (set) Token: 0x06004F85 RID: 20357 RVA: 0x002F9EF4 File Offset: 0x002F80F4
		internal virtual AxWindowsMediaPlayer AxWindowsMediaPlayer1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D33 RID: 7475
		// (get) Token: 0x06004F86 RID: 20358 RVA: 0x002F9EFD File Offset: 0x002F80FD
		// (set) Token: 0x06004F87 RID: 20359 RVA: 0x002F9F08 File Offset: 0x002F8108
		internal virtual Timer Timer1
		{
			[CompilerGenerated]
			get
			{
				return this._Timer1;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = new EventHandler(this.Timer1_Tick);
				Timer timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick -= eventHandler;
				}
				this._Timer1 = value;
				timer = this._Timer1;
				if (timer != null)
				{
					timer.Tick += eventHandler;
				}
			}
		}

		// Token: 0x17001D34 RID: 7476
		// (get) Token: 0x06004F88 RID: 20360 RVA: 0x002F9F4B File Offset: 0x002F814B
		// (set) Token: 0x06004F89 RID: 20361 RVA: 0x002F9F55 File Offset: 0x002F8155
		internal virtual DataGridView DataGridView1
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D35 RID: 7477
		// (get) Token: 0x06004F8A RID: 20362 RVA: 0x002F9F5E File Offset: 0x002F815E
		// (set) Token: 0x06004F8B RID: 20363 RVA: 0x002F9F68 File Offset: 0x002F8168
		internal virtual DataGridViewTextBoxColumn ProdtID
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D36 RID: 7478
		// (get) Token: 0x06004F8C RID: 20364 RVA: 0x002F9F71 File Offset: 0x002F8171
		// (set) Token: 0x06004F8D RID: 20365 RVA: 0x002F9F7B File Offset: 0x002F817B
		internal virtual DataGridViewTextBoxColumn ProductCode
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D37 RID: 7479
		// (get) Token: 0x06004F8E RID: 20366 RVA: 0x002F9F84 File Offset: 0x002F8184
		// (set) Token: 0x06004F8F RID: 20367 RVA: 0x002F9F8E File Offset: 0x002F818E
		internal virtual DataGridViewTextBoxColumn Desc
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D38 RID: 7480
		// (get) Token: 0x06004F90 RID: 20368 RVA: 0x002F9F97 File Offset: 0x002F8197
		// (set) Token: 0x06004F91 RID: 20369 RVA: 0x002F9FA1 File Offset: 0x002F81A1
		internal virtual DataGridViewTextBoxColumn UnitPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D39 RID: 7481
		// (get) Token: 0x06004F92 RID: 20370 RVA: 0x002F9FAA File Offset: 0x002F81AA
		// (set) Token: 0x06004F93 RID: 20371 RVA: 0x002F9FB4 File Offset: 0x002F81B4
		internal virtual DataGridViewTextBoxColumn Qty
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D3A RID: 7482
		// (get) Token: 0x06004F94 RID: 20372 RVA: 0x002F9FBD File Offset: 0x002F81BD
		// (set) Token: 0x06004F95 RID: 20373 RVA: 0x002F9FC7 File Offset: 0x002F81C7
		internal virtual DataGridViewTextBoxColumn Tax
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D3B RID: 7483
		// (get) Token: 0x06004F96 RID: 20374 RVA: 0x002F9FD0 File Offset: 0x002F81D0
		// (set) Token: 0x06004F97 RID: 20375 RVA: 0x002F9FDA File Offset: 0x002F81DA
		internal virtual DataGridViewTextBoxColumn Total
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D3C RID: 7484
		// (get) Token: 0x06004F98 RID: 20376 RVA: 0x002F9FE3 File Offset: 0x002F81E3
		// (set) Token: 0x06004F99 RID: 20377 RVA: 0x002F9FED File Offset: 0x002F81ED
		internal virtual DataGridViewTextBoxColumn UnitCost
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D3D RID: 7485
		// (get) Token: 0x06004F9A RID: 20378 RVA: 0x002F9FF6 File Offset: 0x002F81F6
		// (set) Token: 0x06004F9B RID: 20379 RVA: 0x002FA000 File Offset: 0x002F8200
		internal virtual DataGridViewTextBoxColumn CouponNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D3E RID: 7486
		// (get) Token: 0x06004F9C RID: 20380 RVA: 0x002FA009 File Offset: 0x002F8209
		// (set) Token: 0x06004F9D RID: 20381 RVA: 0x002FA013 File Offset: 0x002F8213
		internal virtual DataGridViewTextBoxColumn OldPrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D3F RID: 7487
		// (get) Token: 0x06004F9E RID: 20382 RVA: 0x002FA01C File Offset: 0x002F821C
		// (set) Token: 0x06004F9F RID: 20383 RVA: 0x002FA026 File Offset: 0x002F8226
		internal virtual DataGridViewTextBoxColumn PriceChange
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D40 RID: 7488
		// (get) Token: 0x06004FA0 RID: 20384 RVA: 0x002FA02F File Offset: 0x002F822F
		// (set) Token: 0x06004FA1 RID: 20385 RVA: 0x002FA039 File Offset: 0x002F8239
		internal virtual DataGridViewTextBoxColumn IsAirtime
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D41 RID: 7489
		// (get) Token: 0x06004FA2 RID: 20386 RVA: 0x002FA042 File Offset: 0x002F8242
		// (set) Token: 0x06004FA3 RID: 20387 RVA: 0x002FA04C File Offset: 0x002F824C
		internal virtual DataGridViewTextBoxColumn MNO
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D42 RID: 7490
		// (get) Token: 0x06004FA4 RID: 20388 RVA: 0x002FA055 File Offset: 0x002F8255
		// (set) Token: 0x06004FA5 RID: 20389 RVA: 0x002FA05F File Offset: 0x002F825F
		internal virtual DataGridViewTextBoxColumn IsWholesalePrice
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D43 RID: 7491
		// (get) Token: 0x06004FA6 RID: 20390 RVA: 0x002FA068 File Offset: 0x002F8268
		// (set) Token: 0x06004FA7 RID: 20391 RVA: 0x002FA072 File Offset: 0x002F8272
		internal virtual DataGridViewTextBoxColumn WholesaleQtyDiscount
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D44 RID: 7492
		// (get) Token: 0x06004FA8 RID: 20392 RVA: 0x002FA07B File Offset: 0x002F827B
		// (set) Token: 0x06004FA9 RID: 20393 RVA: 0x002FA085 File Offset: 0x002F8285
		internal virtual DataGridViewTextBoxColumn DiscDetails
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D45 RID: 7493
		// (get) Token: 0x06004FAA RID: 20394 RVA: 0x002FA08E File Offset: 0x002F828E
		// (set) Token: 0x06004FAB RID: 20395 RVA: 0x002FA098 File Offset: 0x002F8298
		internal virtual DataGridViewTextBoxColumn DiscPaymethod
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D46 RID: 7494
		// (get) Token: 0x06004FAC RID: 20396 RVA: 0x002FA0A1 File Offset: 0x002F82A1
		// (set) Token: 0x06004FAD RID: 20397 RVA: 0x002FA0AB File Offset: 0x002F82AB
		internal virtual DataGridViewTextBoxColumn DiscAmount2
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D47 RID: 7495
		// (get) Token: 0x06004FAE RID: 20398 RVA: 0x002FA0B4 File Offset: 0x002F82B4
		// (set) Token: 0x06004FAF RID: 20399 RVA: 0x002FA0BE File Offset: 0x002F82BE
		internal virtual DataGridViewTextBoxColumn BatchNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D48 RID: 7496
		// (get) Token: 0x06004FB0 RID: 20400 RVA: 0x002FA0C7 File Offset: 0x002F82C7
		// (set) Token: 0x06004FB1 RID: 20401 RVA: 0x002FA0D1 File Offset: 0x002F82D1
		internal virtual DataGridViewTextBoxColumn ExpiryDate
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D49 RID: 7497
		// (get) Token: 0x06004FB2 RID: 20402 RVA: 0x002FA0DA File Offset: 0x002F82DA
		// (set) Token: 0x06004FB3 RID: 20403 RVA: 0x002FA0E4 File Offset: 0x002F82E4
		internal virtual DataGridViewTextBoxColumn Taxr
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D4A RID: 7498
		// (get) Token: 0x06004FB4 RID: 20404 RVA: 0x002FA0ED File Offset: 0x002F82ED
		// (set) Token: 0x06004FB5 RID: 20405 RVA: 0x002FA0F7 File Offset: 0x002F82F7
		internal virtual DataGridViewTextBoxColumn PromStatus
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D4B RID: 7499
		// (get) Token: 0x06004FB6 RID: 20406 RVA: 0x002FA100 File Offset: 0x002F8300
		// (set) Token: 0x06004FB7 RID: 20407 RVA: 0x002FA10A File Offset: 0x002F830A
		internal virtual DataGridViewTextBoxColumn OtherDetail
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D4C RID: 7500
		// (get) Token: 0x06004FB8 RID: 20408 RVA: 0x002FA113 File Offset: 0x002F8313
		// (set) Token: 0x06004FB9 RID: 20409 RVA: 0x002FA11D File Offset: 0x002F831D
		internal virtual DataGridViewTextBoxColumn IsVoucher
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D4D RID: 7501
		// (get) Token: 0x06004FBA RID: 20410 RVA: 0x002FA126 File Offset: 0x002F8326
		// (set) Token: 0x06004FBB RID: 20411 RVA: 0x002FA130 File Offset: 0x002F8330
		internal virtual DataGridViewTextBoxColumn Comments
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D4E RID: 7502
		// (get) Token: 0x06004FBC RID: 20412 RVA: 0x002FA139 File Offset: 0x002F8339
		// (set) Token: 0x06004FBD RID: 20413 RVA: 0x002FA143 File Offset: 0x002F8343
		internal virtual DataGridViewTextBoxColumn RowNumber
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x17001D4F RID: 7503
		// (get) Token: 0x06004FBE RID: 20414 RVA: 0x002FA14C File Offset: 0x002F834C
		// (set) Token: 0x06004FBF RID: 20415 RVA: 0x002FA156 File Offset: 0x002F8356
		internal virtual Label txtTotal
		{
			get; [MethodImpl(MethodImplOptions.Synchronized)]
			set;
		}

		// Token: 0x06004FC0 RID: 20416 RVA: 0x002FA160 File Offset: 0x002F8360
		private void SecondSalesScreen_Load(object sender, EventArgs e)
		{
			try
			{
				this.DataGridView1.Columns.Clear();
				this.Timer1.Start();
				this.AxWindowsMediaPlayer1.uiMode = "none";
				this.AxWindowsMediaPlayer1.settings.setMode("Loop", true);
				this.AxWindowsMediaPlayer1.URL = MyProject.Forms.Form1.AdvertPath;
				base.WindowState = FormWindowState.Maximized;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error loading second screen form. Detail: " + ex.Message);
			}
		}

		// Token: 0x06004FC1 RID: 20417 RVA: 0x002FA210 File Offset: 0x002F8410
		private void AxWindowsMediaPlayer1_MediaError(object sender, _WMPOCXEvents_MediaErrorEvent e)
		{
			try
			{
				IWMPMedia2 iwmpmedia = (IWMPMedia2)e.pMediaObject;
				IWMPErrorItem error = iwmpmedia.Error;
				MessageBox.Show("Media error " + error.errorCode.ToString("X") + " in " + iwmpmedia.sourceURL);
			}
			catch (InvalidCastException ex)
			{
				MessageBox.Show("Player error");
			}
		}

		// Token: 0x06004FC2 RID: 20418 RVA: 0x002FA290 File Offset: 0x002F8490
		private void Timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				DataTable salesdatagrid = MyProject.Forms.Form1.salesdatagrid;
				salesdatagrid.Columns.Remove("ProdtID");
				salesdatagrid.Columns.Remove("ProductCode");
				salesdatagrid.Columns.Remove("UnitCost");
				salesdatagrid.Columns.Remove("CouponNumber");
				salesdatagrid.Columns.Remove("PriceChange");
				salesdatagrid.Columns.Remove("IsAirtime");
				salesdatagrid.Columns.Remove("MNO");
				salesdatagrid.Columns.Remove("IsWholesalePrice");
				salesdatagrid.Columns.Remove("WholesaleQtyDiscount");
				salesdatagrid.Columns.Remove("DiscDetails");
				salesdatagrid.Columns.Remove("DiscPaymethod");
				salesdatagrid.Columns.Remove("DiscAmount2");
				salesdatagrid.Columns.Remove("BatchNumber");
				salesdatagrid.Columns.Remove("ExpiryDate");
				salesdatagrid.Columns.Remove("Taxr");
				salesdatagrid.Columns.Remove("PromStatus");
				salesdatagrid.Columns.Remove("OldPrice");
				salesdatagrid.Columns.Remove("OtherDetail");
				salesdatagrid.Columns.Remove("IsVoucher");
				salesdatagrid.Columns.Remove("Comments");
				salesdatagrid.Columns.Remove("RowNumber");
				this.DataGridView1.DataSource = salesdatagrid;
				this.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				this.CalcTotalSale();
			}
			catch (Exception ex)
			{
			}
		}

		// Token: 0x06004FC3 RID: 20419 RVA: 0x002FA464 File Offset: 0x002F8664
		private void CalcTotalSale()
		{
			decimal num = 0m;
			decimal num2 = 0m;
			decimal num3 = 0m;
			try
			{
				foreach (DataGridView dataGridView in this.gbSales.Controls.OfType<DataGridView>())
				{
					try
					{
						foreach (object obj in ((IEnumerable)dataGridView.Rows))
						{
							DataGridViewRow dataGridViewRow = (DataGridViewRow)obj;
							num = decimal.Add(num, Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Total"].Value)));
							num2 = decimal.Add(num2, Convert.ToDecimal(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Tax"].Value)));
						}
					}
					finally
					{
						IEnumerator enumerator2;
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
				}
			}
			finally
			{
				IEnumerator<DataGridView> enumerator;
				if (enumerator != null)
				{
					enumerator.Dispose();
				}
			}
			num = Math.Round(num, 2, MidpointRounding.AwayFromZero);
			num = decimal.Subtract(num, num3);
			this.txtTotal.Text = "Total: " + Math.Round(num, 2, MidpointRounding.AwayFromZero).ToString();
		}
	}
}
