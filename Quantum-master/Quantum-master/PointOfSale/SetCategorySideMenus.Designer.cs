namespace PointOfSale
{
	// Token: 0x020001DA RID: 474
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class SetCategorySideMenus : global::System.Windows.Forms.Form
	{
		// Token: 0x06005310 RID: 21264 RVA: 0x00304A3C File Offset: 0x00302C3C
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

		// Token: 0x06005311 RID: 21265 RVA: 0x00304A8C File Offset: 0x00302C8C
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.lblerror = new global::System.Windows.Forms.Label();
			this.txtBarCode = new global::System.Windows.Forms.TextBox();
			this.lblDesc = new global::System.Windows.Forms.TextBox();
			this.txtSearchProductCode = new global::System.Windows.Forms.TextBox();
			this.Label15 = new global::System.Windows.Forms.Label();
			this.Panel4 = new global::System.Windows.Forms.Panel();
			this.DGVSearch = new global::System.Windows.Forms.DataGridView();
			this.GroupBox4 = new global::System.Windows.Forms.GroupBox();
			this.Label10 = new global::System.Windows.Forms.Label();
			this.Button4 = new global::System.Windows.Forms.Button();
			this.Label16 = new global::System.Windows.Forms.Label();
			this.txtsearch = new global::System.Windows.Forms.TextBox();
			this.DataGridView1 = new global::System.Windows.Forms.DataGridView();
			this.ComboBox1 = new global::System.Windows.Forms.ComboBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.GroupBox1.SuspendLayout();
			this.Panel4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).BeginInit();
			this.GroupBox4.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.ComboBox1);
			this.GroupBox1.Controls.Add(this.lblerror);
			this.GroupBox1.Controls.Add(this.txtBarCode);
			this.GroupBox1.Controls.Add(this.lblDesc);
			this.GroupBox1.Controls.Add(this.txtSearchProductCode);
			this.GroupBox1.Controls.Add(this.Label15);
			this.GroupBox1.Controls.Add(this.Panel4);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(747, 220);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.lblerror.AutoSize = true;
			this.lblerror.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lblerror.Location = new global::System.Drawing.Point(319, 204);
			this.lblerror.Name = "lblerror";
			this.lblerror.Size = new global::System.Drawing.Size(16, 13);
			this.lblerror.TabIndex = 38;
			this.lblerror.Text = "...";
			this.txtBarCode.Location = new global::System.Drawing.Point(475, 80);
			this.txtBarCode.Name = "txtBarCode";
			this.txtBarCode.Size = new global::System.Drawing.Size(157, 20);
			this.txtBarCode.TabIndex = 37;
			this.txtBarCode.TabStop = false;
			this.lblDesc.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblDesc.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.lblDesc.ForeColor = global::System.Drawing.Color.Red;
			this.lblDesc.Location = new global::System.Drawing.Point(326, 9);
			this.lblDesc.Multiline = true;
			this.lblDesc.Name = "lblDesc";
			this.lblDesc.ReadOnly = true;
			this.lblDesc.Size = new global::System.Drawing.Size(409, 65);
			this.lblDesc.TabIndex = 35;
			this.lblDesc.TabStop = false;
			this.txtSearchProductCode.Location = new global::System.Drawing.Point(475, 106);
			this.txtSearchProductCode.Name = "txtSearchProductCode";
			this.txtSearchProductCode.Size = new global::System.Drawing.Size(100, 20);
			this.txtSearchProductCode.TabIndex = 34;
			this.txtSearchProductCode.Visible = false;
			this.Label15.AutoSize = true;
			this.Label15.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label15.Location = new global::System.Drawing.Point(323, 84);
			this.Label15.Name = "Label15";
			this.Label15.Size = new global::System.Drawing.Size(148, 13);
			this.Label15.TabIndex = 36;
			this.Label15.Text = "SEARCH BY BAR CODE:";
			this.Panel4.BackColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.Panel4.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.Panel4.Controls.Add(this.DGVSearch);
			this.Panel4.Controls.Add(this.GroupBox4);
			this.Panel4.Dock = global::System.Windows.Forms.DockStyle.Left;
			this.Panel4.Location = new global::System.Drawing.Point(3, 16);
			this.Panel4.Name = "Panel4";
			this.Panel4.Size = new global::System.Drawing.Size(316, 201);
			this.Panel4.TabIndex = 33;
			this.DGVSearch.AllowUserToAddRows = false;
			this.DGVSearch.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DGVSearch.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DGVSearch.Location = new global::System.Drawing.Point(0, 69);
			this.DGVSearch.Name = "DGVSearch";
			this.DGVSearch.ReadOnly = true;
			this.DGVSearch.Size = new global::System.Drawing.Size(312, 128);
			this.DGVSearch.TabIndex = 5;
			this.GroupBox4.Controls.Add(this.Label10);
			this.GroupBox4.Controls.Add(this.Button4);
			this.GroupBox4.Controls.Add(this.Label16);
			this.GroupBox4.Controls.Add(this.txtsearch);
			this.GroupBox4.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox4.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox4.Name = "GroupBox4";
			this.GroupBox4.Size = new global::System.Drawing.Size(312, 69);
			this.GroupBox4.TabIndex = 0;
			this.GroupBox4.TabStop = false;
			this.Label10.AutoSize = true;
			this.Label10.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 7.5f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label10.ForeColor = global::System.Drawing.Color.Red;
			this.Label10.Location = new global::System.Drawing.Point(259, 13);
			this.Label10.Name = "Label10";
			this.Label10.Size = new global::System.Drawing.Size(48, 13);
			this.Label10.TabIndex = 48;
			this.Label10.Text = "Page Up";
			this.Button4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Button4.Location = new global::System.Drawing.Point(233, 32);
			this.Button4.Name = "Button4";
			this.Button4.Size = new global::System.Drawing.Size(75, 31);
			this.Button4.TabIndex = 10;
			this.Button4.TabStop = false;
			this.Button4.Text = "Show All";
			this.Button4.UseVisualStyleBackColor = true;
			this.Label16.AutoSize = true;
			this.Label16.Location = new global::System.Drawing.Point(5, 13);
			this.Label16.Name = "Label16";
			this.Label16.Size = new global::System.Drawing.Size(249, 13);
			this.Label16.TabIndex = 9;
			this.Label16.Text = "Type in the space to search by product description:";
			this.txtsearch.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.txtsearch.Location = new global::System.Drawing.Point(8, 34);
			this.txtsearch.Name = "txtsearch";
			this.txtsearch.Size = new global::System.Drawing.Size(219, 29);
			this.txtsearch.TabIndex = 0;
			this.txtsearch.TabStop = false;
			this.DataGridView1.AllowUserToAddRows = false;
			this.DataGridView1.AllowUserToDeleteRows = false;
			this.DataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.DataGridView1.Location = new global::System.Drawing.Point(0, 220);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.ReadOnly = true;
			this.DataGridView1.Size = new global::System.Drawing.Size(747, 186);
			this.DataGridView1.TabIndex = 1;
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Items.AddRange(new object[] { "Meat Preparation", "Dips", "Chip sauce", "Side", "Polony", "Base Options", "Sauces" });
			this.ComboBox1.Location = new global::System.Drawing.Point(475, 141);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new global::System.Drawing.Size(157, 21);
			this.ComboBox1.TabIndex = 39;
			this.Label1.AutoSize = true;
			this.Label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label1.Location = new global::System.Drawing.Point(344, 144);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(125, 13);
			this.Label1.TabIndex = 40;
			this.Label1.Text = "Select Side Menu to link:";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(475, 168);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(100, 23);
			this.Button1.TabIndex = 41;
			this.Button1.Text = "Save";
			this.Button1.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(747, 406);
			base.Controls.Add(this.DataGridView1);
			base.Controls.Add(this.GroupBox1);
			base.Name = "SetCategorySideMenus";
			this.Text = "Set Product Side Menus : Applies to Restaurant Setups only";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.Panel4.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.DGVSearch).EndInit();
			this.GroupBox4.ResumeLayout(false);
			this.GroupBox4.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.DataGridView1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400243A RID: 9274
		private global::System.ComponentModel.IContainer components;
	}
}
