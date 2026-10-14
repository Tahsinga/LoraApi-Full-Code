namespace PointOfSale
{
	// Token: 0x02000161 RID: 353
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class PriceMatrix : global::System.Windows.Forms.Form
	{
		// Token: 0x06002F06 RID: 12038 RVA: 0x001984A8 File Offset: 0x001966A8
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

		// Token: 0x06002F07 RID: 12039 RVA: 0x001984F8 File Offset: 0x001966F8
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.lblerror = new global::System.Windows.Forms.Label();
			this.txtSearchProductID = new global::System.Windows.Forms.TextBox();
			this.GroupBox2 = new global::System.Windows.Forms.GroupBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.txtNewPrice = new global::System.Windows.Forms.TextBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.txtTo = new global::System.Windows.Forms.TextBox();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.txtFrom = new global::System.Windows.Forms.TextBox();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.txtSellingPrice = new global::System.Windows.Forms.TextBox();
			this.Label6 = new global::System.Windows.Forms.Label();
			this.lblDesc = new global::System.Windows.Forms.TextBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.txtSearchProductCode = new global::System.Windows.Forms.TextBox();
			this.Label7 = new global::System.Windows.Forms.Label();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.DGVSearch = new global::System.Windows.Forms.DataGridView();
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.Button3 = new global::System.Windows.Forms.Button();
			this.Label19 = new global::System.Windows.Forms.Label();
			this.txtsearch = new global::System.Windows.Forms.TextBox();
			this.dgvPrice = new global::System.Windows.Forms.DataGridView();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).BeginInit();
			this.Panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvPrice).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.lblerror);
			this.GroupBox1.Controls.Add(this.txtSearchProductID);
			this.GroupBox1.Controls.Add(this.GroupBox2);
			this.GroupBox1.Controls.Add(this.txtSellingPrice);
			this.GroupBox1.Controls.Add(this.Label6);
			this.GroupBox1.Controls.Add(this.lblDesc);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.txtSearchProductCode);
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Controls.Add(this.GroupBox4);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(1204, 364);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Product Details";
			this.lblerror.AutoSize = true;
			this.lblerror.Location = new global::System.Drawing.Point(481, 173);
			this.lblerror.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblerror.Name = "lblerror";
			this.lblerror.Size = new global::System.Drawing.Size(21, 20);
			this.lblerror.TabIndex = 32;
			this.lblerror.Text = "...";
			this.txtSearchProductID.Location = new global::System.Drawing.Point(942, 25);
			this.txtSearchProductID.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtSearchProductID.Name = "txtSearchProductID";
			this.txtSearchProductID.Size = new global::System.Drawing.Size(190, 26);
			this.txtSearchProductID.TabIndex = 29;
			this.GroupBox2.Controls.Add(this.Button1);
			this.GroupBox2.Controls.Add(this.txtNewPrice);
			this.GroupBox2.Controls.Add(this.Label4);
			this.GroupBox2.Controls.Add(this.txtTo);
			this.GroupBox2.Controls.Add(this.Label3);
			this.GroupBox2.Controls.Add(this.txtFrom);
			this.GroupBox2.Controls.Add(this.Label2);
			this.GroupBox2.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.GroupBox2.Location = new global::System.Drawing.Point(471, 196);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new global::System.Drawing.Size(730, 165);
			this.GroupBox2.TabIndex = 28;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Price Matrix";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(164, 80);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(101, 32);
			this.Button1.TabIndex = 33;
			this.Button1.Text = "SAVE";
			this.Button1.UseVisualStyleBackColor = false;
			this.txtNewPrice.Location = new global::System.Drawing.Point(607, 34);
			this.txtNewPrice.Name = "txtNewPrice";
			this.txtNewPrice.Size = new global::System.Drawing.Size(100, 26);
			this.txtNewPrice.TabIndex = 32;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(518, 37);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(83, 20);
			this.Label4.TabIndex = 31;
			this.Label4.Text = "New Price:";
			this.txtTo.Location = new global::System.Drawing.Point(390, 34);
			this.txtTo.Name = "txtTo";
			this.txtTo.Size = new global::System.Drawing.Size(100, 26);
			this.txtTo.TabIndex = 30;
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(325, 37);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(59, 20);
			this.Label3.TabIndex = 29;
			this.Label3.Text = "Qty To:";
			this.txtFrom.Location = new global::System.Drawing.Point(165, 34);
			this.txtFrom.Name = "txtFrom";
			this.txtFrom.Size = new global::System.Drawing.Size(100, 26);
			this.txtFrom.TabIndex = 28;
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(81, 37);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(78, 20);
			this.Label2.TabIndex = 27;
			this.Label2.Text = "Qty From:";
			this.txtSellingPrice.Location = new global::System.Drawing.Point(636, 147);
			this.txtSellingPrice.Name = "txtSellingPrice";
			this.txtSellingPrice.ReadOnly = true;
			this.txtSellingPrice.Size = new global::System.Drawing.Size(165, 26);
			this.txtSellingPrice.TabIndex = 26;
			this.Label6.AutoSize = true;
			this.Label6.ForeColor = global::System.Drawing.Color.Red;
			this.Label6.Location = new global::System.Drawing.Point(531, 60);
			this.Label6.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label6.Name = "Label6";
			this.Label6.Size = new global::System.Drawing.Size(93, 20);
			this.Label6.TabIndex = 25;
			this.Label6.Text = "Description:";
			this.lblDesc.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblDesc.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblDesc.ForeColor = global::System.Drawing.Color.Red;
			this.lblDesc.Location = new global::System.Drawing.Point(636, 60);
			this.lblDesc.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.lblDesc.Multiline = true;
			this.lblDesc.Name = "lblDesc";
			this.lblDesc.ReadOnly = true;
			this.lblDesc.Size = new global::System.Drawing.Size(562, 79);
			this.lblDesc.TabIndex = 24;
			this.lblDesc.TabStop = false;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(481, 151);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(149, 20);
			this.Label1.TabIndex = 23;
			this.Label1.Text = "Global Selling Price:";
			this.txtSearchProductCode.Location = new global::System.Drawing.Point(636, 24);
			this.txtSearchProductCode.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtSearchProductCode.Name = "txtSearchProductCode";
			this.txtSearchProductCode.Size = new global::System.Drawing.Size(298, 26);
			this.txtSearchProductCode.TabIndex = 21;
			this.Label7.AutoSize = true;
			this.Label7.Location = new global::System.Drawing.Point(514, 28);
			this.Label7.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label7.Name = "Label7";
			this.Label7.Size = new global::System.Drawing.Size(110, 20);
			this.Label7.TabIndex = 22;
			this.Label7.Text = "Product Code:";
			this.GroupBox4.Controls.Add(this.DGVSearch);
			this.GroupBox4.Controls.Add(this.Panel1);
			this.GroupBox4.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.GroupBox4.Location = new global::System.Drawing.Point(3, 22);
			this.GroupBox4.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Padding = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.GroupBox4.Size = new global::System.Drawing.Size(468, 339);
			this.GroupBox4.TabIndex = 20;
			this.GroupBox4.TabStop = false;
			this.DGVSearch.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVSearch.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DGVSearch.Location = new global::System.Drawing.Point(4, 122);
			this.DGVSearch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DGVSearch.Name = "DGVSearch";
			this.DGVSearch.Size = new global::System.Drawing.Size(460, 212);
			this.DGVSearch.TabIndex = 12;
			this.Panel1.Controls.Add(this.Button3);
			this.Panel1.Controls.Add(this.Label19);
			this.Panel1.Controls.Add(this.txtsearch);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel1.Location = new global::System.Drawing.Point(4, 24);
			this.Panel1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(460, 98);
			this.Panel1.TabIndex = 11;
			this.Button3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button3.Location = new global::System.Drawing.Point(345, 40);
			this.Button3.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button3.Name = "Button3";
			this.Button3.Size = new global::System.Drawing.Size(112, 48);
			this.Button3.TabIndex = 13;
			this.Button3.TabStop = false;
			this.Button3.Text = "Show All";
			this.Button3.UseVisualStyleBackColor = true;
			this.Label19.AutoSize = true;
			this.Label19.Location = new global::System.Drawing.Point(3, 11);
			this.Label19.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label19.Name = "Label19";
			this.Label19.Size = new global::System.Drawing.Size(366, 20);
			this.Label19.TabIndex = 12;
			this.Label19.Text = "Type in the space to search by product description:";
			this.txtsearch.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtsearch.Location = new global::System.Drawing.Point(8, 43);
			this.txtsearch.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new global::System.Drawing.Size(326, 39);
			this.txtsearch.TabIndex = 11;
			this.dgvPrice.AllowUserToAddRows = false;
			this.dgvPrice.AllowUserToDeleteRows = false;
			this.dgvPrice.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPrice.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvPrice.Location = new global::System.Drawing.Point(0, 364);
			this.dgvPrice.Name = "dgvPrice";
			this.dgvPrice.ReadOnly = true;
			this.dgvPrice.RowTemplate.Height = 28;
			this.dgvPrice.Size = new global::System.Drawing.Size(1204, 261);
			this.dgvPrice.TabIndex = 1;
			this.Button2.Location = new global::System.Drawing.Point(809, 142);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(188, 38);
			this.Button2.TabIndex = 33;
			this.Button2.Text = "Show Price Matrix";
			this.Button2.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(1204, 625);
			base.Controls.Add(this.dgvPrice);
			base.Controls.Add(this.GroupBox1);
			base.Name = "PriceMatrix";
			this.Text = "Price Matrix";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.GroupBox4.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvPrice).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400142A RID: 5162
		private global::System.ComponentModel.IContainer components;
	}
}
