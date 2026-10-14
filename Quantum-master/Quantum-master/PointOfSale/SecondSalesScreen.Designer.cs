namespace PointOfSale
{
	// Token: 0x020001B6 RID: 438
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SecondSalesScreen : global::System.Windows.Forms.Form
	{
		// Token: 0x06004F7E RID: 20350 RVA: 0x002F91B0 File Offset: 0x002F73B0
		[global::System.Diagnostics.DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				bool flag = disposing && this.components != null;
				if (flag)
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x06004F7F RID: 20351 RVA: 0x002F9200 File Offset: 0x002F7400
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::PointOfSale.SecondSalesScreen));
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new global::System.Windows.Forms.DataGridViewCellStyle();
			global::System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new global::System.Windows.Forms.DataGridViewCellStyle();
			this.gbSales = new global::System.Windows.Forms.GroupBox();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.AxWindowsMediaPlayer1 = new global::AxWMPLib.AxWindowsMediaPlayer();
			this.Timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.DataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.ProdtID = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ProductCode = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Desc = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UnitPrice = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Qty = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Tax = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Total = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UnitCost = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CouponNumber = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OldPrice = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PriceChange = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IsAirtime = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MNO = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IsWholesalePrice = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.WholesaleQtyDiscount = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiscDetails = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiscPaymethod = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiscAmount2 = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BatchNumber = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ExpiryDate = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Taxr = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PromStatus = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OtherDetail = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IsVoucher = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Comments = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.RowNumber = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txtTotal = new global::System.Windows.Forms.Label();
			this.gbSales.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.AxWindowsMediaPlayer1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			base.SuspendLayout();
			this.gbSales.Controls.Add(this.DataGridView1);
			this.gbSales.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.gbSales.Location = new global::System.Drawing.Point(0, 184);
			this.gbSales.Name = "gbSales";
			this.gbSales.Size = new global::System.Drawing.Size(850, 155);
			this.gbSales.TabIndex = 0;
			this.gbSales.TabStop = false;
			this.GroupBox2.Controls.Add(this.txtTotal);
			this.GroupBox2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.GroupBox2.Location = new global::System.Drawing.Point(0, 141);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new global::System.Drawing.Size(850, 43);
			this.GroupBox2.TabIndex = 1;
			this.GroupBox2.TabStop = false;
			this.AxWindowsMediaPlayer1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.AxWindowsMediaPlayer1.Enabled = true;
			this.AxWindowsMediaPlayer1.Location = new global::System.Drawing.Point(0, 0);
			this.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1";
			this.AxWindowsMediaPlayer1.OcxState = (global::System.Windows.Forms.AxHost.State)componentResourceManager.GetObject("AxWindowsMediaPlayer1.OcxState");
			this.AxWindowsMediaPlayer1.Size = new global::System.Drawing.Size(850, 141);
			this.AxWindowsMediaPlayer1.TabIndex = 2;
			this.Timer1.Interval = 1000;
			this.DataGridView1.AllowUserToAddRows = false;
			this.DataGridView1.AutoSizeColumnsMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = global::System.Drawing.SystemColors.Control;
			dataGridViewCellStyle.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle.ForeColor = global::System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = global::System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = global::System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = global::System.Windows.Forms.DataGridViewTriState.True;
			this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.DataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[]
			{
				this.ProdtID, this.ProductCode, this.Desc, this.UnitPrice, this.Qty, this.Tax, this.Total, this.UnitCost, this.CouponNumber, this.OldPrice,
				this.PriceChange, this.IsAirtime, this.MNO, this.IsWholesalePrice, this.WholesaleQtyDiscount, this.DiscDetails, this.DiscPaymethod, this.DiscAmount2, this.BatchNumber, this.ExpiryDate,
				this.Taxr, this.PromStatus, this.OtherDetail, this.IsVoucher, this.Comments, this.RowNumber
			});
			this.DataGridView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DataGridView1.Location = new global::System.Drawing.Point(3, 16);
			this.DataGridView1.Name = "DataGridView1";
			dataGridViewCellStyle2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.DataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.DataGridView1.Size = new global::System.Drawing.Size(844, 136);
			this.DataGridView1.TabIndex = 1;
			this.DataGridView1.TabStop = false;
			dataGridViewCellStyle3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ProdtID.DefaultCellStyle = dataGridViewCellStyle3;
			this.ProdtID.HeaderText = "Product ID";
			this.ProdtID.Name = "ProdtID";
			this.ProdtID.ReadOnly = true;
			this.ProdtID.Visible = false;
			this.ProductCode.HeaderText = "Product Code";
			this.ProductCode.Name = "ProductCode";
			this.ProductCode.ReadOnly = true;
			dataGridViewCellStyle4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Desc.DefaultCellStyle = dataGridViewCellStyle4;
			this.Desc.HeaderText = "Description";
			this.Desc.Name = "Desc";
			this.Desc.ReadOnly = true;
			dataGridViewCellStyle5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.UnitPrice.DefaultCellStyle = dataGridViewCellStyle5;
			this.UnitPrice.HeaderText = "Unit Price $";
			this.UnitPrice.Name = "UnitPrice";
			this.UnitPrice.ReadOnly = true;
			dataGridViewCellStyle6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Qty.DefaultCellStyle = dataGridViewCellStyle6;
			this.Qty.HeaderText = "Quantity";
			this.Qty.Name = "Qty";
			this.Qty.ReadOnly = true;
			this.Tax.HeaderText = "Tax $";
			this.Tax.Name = "Tax";
			this.Tax.ReadOnly = true;
			dataGridViewCellStyle7.Alignment = global::System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Total.DefaultCellStyle = dataGridViewCellStyle7;
			this.Total.HeaderText = "Total $";
			this.Total.Name = "Total";
			this.Total.ReadOnly = true;
			this.UnitCost.HeaderText = "Column1";
			this.UnitCost.Name = "UnitCost";
			this.UnitCost.Visible = false;
			this.CouponNumber.HeaderText = "CouponNumber";
			this.CouponNumber.Name = "CouponNumber";
			this.CouponNumber.Visible = false;
			this.OldPrice.HeaderText = "OldPrice";
			this.OldPrice.Name = "OldPrice";
			this.OldPrice.Visible = false;
			this.PriceChange.HeaderText = "PriceChange";
			this.PriceChange.Name = "PriceChange";
			this.PriceChange.Visible = false;
			this.IsAirtime.HeaderText = "IsAirtime";
			this.IsAirtime.Name = "IsAirtime";
			this.IsAirtime.Visible = false;
			this.MNO.HeaderText = "MNO";
			this.MNO.Name = "MNO";
			this.MNO.Visible = false;
			this.IsWholesalePrice.HeaderText = "IsWholesalePrice";
			this.IsWholesalePrice.Name = "IsWholesalePrice";
			this.IsWholesalePrice.Visible = false;
			this.WholesaleQtyDiscount.HeaderText = "WholesaleQtyDiscount";
			this.WholesaleQtyDiscount.Name = "WholesaleQtyDiscount";
			this.WholesaleQtyDiscount.Visible = false;
			this.DiscDetails.HeaderText = "Discount Details";
			this.DiscDetails.Name = "DiscDetails";
			this.DiscDetails.Visible = false;
			this.DiscPaymethod.HeaderText = "Discount Paymethod";
			this.DiscPaymethod.Name = "DiscPaymethod";
			this.DiscPaymethod.Visible = false;
			this.DiscAmount2.HeaderText = "Discount Amount";
			this.DiscAmount2.Name = "DiscAmount2";
			this.DiscAmount2.Visible = false;
			this.BatchNumber.HeaderText = "BatchNumber";
			this.BatchNumber.Name = "BatchNumber";
			this.BatchNumber.Visible = false;
			this.ExpiryDate.HeaderText = "ExpiryDate";
			this.ExpiryDate.Name = "ExpiryDate";
			this.ExpiryDate.Visible = false;
			this.Taxr.HeaderText = "Taxr";
			this.Taxr.Name = "Taxr";
			this.Taxr.Visible = false;
			this.PromStatus.HeaderText = "PromStatus";
			this.PromStatus.Name = "PromStatus";
			this.PromStatus.Visible = false;
			this.OtherDetail.HeaderText = "OtherDetail";
			this.OtherDetail.Name = "OtherDetail";
			this.OtherDetail.Visible = false;
			this.IsVoucher.HeaderText = "IsVoucher";
			this.IsVoucher.Name = "IsVoucher";
			this.IsVoucher.Visible = false;
			this.Comments.HeaderText = "Comments";
			this.Comments.Name = "Comments";
			this.Comments.Visible = false;
			this.RowNumber.HeaderText = "RowNumber";
			this.RowNumber.Name = "RowNumber";
			this.RowNumber.Visible = false;
			this.txtTotal.AutoSize = true;
			this.txtTotal.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 15f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtTotal.Location = new global::System.Drawing.Point(52, 11);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new global::System.Drawing.Size(24, 25);
			this.txtTotal.TabIndex = 0;
			this.txtTotal.Text = "0";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(850, 339);
			base.Controls.Add(this.AxWindowsMediaPlayer1);
			base.Controls.Add(this.GroupBox2);
			base.Controls.Add(this.gbSales);
			base.Name = "SecondSalesScreen";
			this.Text = "SecondSalesScreen";
			this.gbSales.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.AxWindowsMediaPlayer1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04002374 RID: 9076
		private global::System.ComponentModel.IContainer components;
	}
}
