namespace PointOfSale
{
	// Token: 0x02000185 RID: 389
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class RestrictUserCategories : global::System.Windows.Forms.Form
	{
		// Token: 0x060039CF RID: 14799 RVA: 0x001F6854 File Offset: 0x001F4A54
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

		// Token: 0x060039D0 RID: 14800 RVA: 0x001F68A4 File Offset: 0x001F4AA4
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.cboUsers = new global::System.Windows.Forms.ComboBox();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.dgvCats = new global::System.Windows.Forms.DataGridView();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.lblCurrent = new global::System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvCats).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.lblCurrent);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.cboUsers);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(696, 192);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(39, 113);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(65, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Select User:";
			this.cboUsers.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboUsers.FormattingEnabled = true;
			this.cboUsers.Location = new global::System.Drawing.Point(110, 110);
			this.cboUsers.Name = "cboUsers";
			this.cboUsers.Size = new global::System.Drawing.Size(182, 21);
			this.cboUsers.TabIndex = 1;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(110, 133);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(182, 23);
			this.Button1.TabIndex = 2;
			this.Button1.Text = "Select Categories for User";
			this.Button1.UseVisualStyleBackColor = false;
			this.dgvCats.AllowUserToAddRows = false;
			this.dgvCats.AllowUserToDeleteRows = false;
			this.dgvCats.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCats.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvCats.Location = new global::System.Drawing.Point(0, 192);
			this.dgvCats.Name = "dgvCats";
			this.dgvCats.ReadOnly = true;
			this.dgvCats.Size = new global::System.Drawing.Size(696, 193);
			this.dgvCats.TabIndex = 1;
			this.Label2.AutoSize = true;
			this.Label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label2.Location = new global::System.Drawing.Point(33, 16);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(426, 24);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "RESTRICT PRODUCT CATEGORIES FOR USER";
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(39, 60);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(531, 13);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "*If you do not select any categories for a user - it means that user can view every category when making a sale.";
			this.Label4.AutoSize = true;
			this.Label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label4.Location = new global::System.Drawing.Point(39, 82);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(504, 13);
			this.Label4.TabIndex = 5;
			this.Label4.Text = "*if you select categories for a user it means that they will only be able to sell products in that category only.";
			this.lblCurrent.AutoSize = true;
			this.lblCurrent.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.lblCurrent.Location = new global::System.Drawing.Point(3, 176);
			this.lblCurrent.Name = "lblCurrent";
			this.lblCurrent.Size = new global::System.Drawing.Size(0, 13);
			this.lblCurrent.TabIndex = 6;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(696, 385);
			base.Controls.Add(this.dgvCats);
			base.Controls.Add(this.GroupBox1);
			base.Name = "RestrictUserCategories";
			this.Text = "Restrict User Categories";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvCats).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040018A3 RID: 6307
		private global::System.ComponentModel.IContainer components;
	}
}
