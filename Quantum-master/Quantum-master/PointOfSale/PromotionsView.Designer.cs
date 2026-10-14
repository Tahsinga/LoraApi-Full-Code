namespace PointOfSale
{
	// Token: 0x02000177 RID: 375
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class PromotionsView : global::System.Windows.Forms.Form
	{
		// Token: 0x060036BE RID: 14014 RVA: 0x001D8E8C File Offset: 0x001D708C
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

		// Token: 0x060036BF RID: 14015 RVA: 0x001D8EDC File Offset: 0x001D70DC
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.GroupBox1 = new global::System.Windows.Forms.GroupBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.DTEndDate = new global::System.Windows.Forms.DateTimePicker();
			this.DTStartDate = new global::System.Windows.Forms.DateTimePicker();
			this.dgvPromotions = new global::System.Windows.Forms.DataGridView();
			this.cboBranch = new global::System.Windows.Forms.ComboBox();
			this.Label17 = new global::System.Windows.Forms.Label();
			this.GroupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvPromotions).BeginInit();
			base.SuspendLayout();
			this.GroupBox1.Controls.Add(this.cboBranch);
			this.GroupBox1.Controls.Add(this.Label17);
			this.GroupBox1.Controls.Add(this.Label4);
			this.GroupBox1.Controls.Add(this.Label3);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.DTEndDate);
			this.GroupBox1.Controls.Add(this.DTStartDate);
			this.GroupBox1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.GroupBox1.Location = new global::System.Drawing.Point(0, 0);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new global::System.Drawing.Size(797, 141);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.Label4.AutoSize = true;
			this.Label4.Location = new global::System.Drawing.Point(60, 48);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(55, 13);
			this.Label4.TabIndex = 12;
			this.Label4.Text = "End Date:";
			this.Label3.AutoSize = true;
			this.Label3.Location = new global::System.Drawing.Point(57, 22);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(58, 13);
			this.Label3.TabIndex = 11;
			this.Label3.Text = "Start Date:";
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(121, 102);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(200, 23);
			this.Button1.TabIndex = 10;
			this.Button1.Text = "View Promotions Given";
			this.Button1.UseVisualStyleBackColor = false;
			this.DTEndDate.Location = new global::System.Drawing.Point(121, 45);
			this.DTEndDate.Name = "DTEndDate";
			this.DTEndDate.Size = new global::System.Drawing.Size(200, 20);
			this.DTEndDate.TabIndex = 9;
			this.DTStartDate.Location = new global::System.Drawing.Point(121, 19);
			this.DTStartDate.Name = "DTStartDate";
			this.DTStartDate.Size = new global::System.Drawing.Size(200, 20);
			this.DTStartDate.TabIndex = 8;
			this.dgvPromotions.AllowUserToAddRows = false;
			this.dgvPromotions.AllowUserToDeleteRows = false;
			this.dgvPromotions.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPromotions.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvPromotions.Location = new global::System.Drawing.Point(0, 141);
			this.dgvPromotions.Name = "dgvPromotions";
			this.dgvPromotions.ReadOnly = true;
			this.dgvPromotions.Size = new global::System.Drawing.Size(797, 274);
			this.dgvPromotions.TabIndex = 1;
			this.cboBranch.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboBranch.FormattingEnabled = true;
			this.cboBranch.Location = new global::System.Drawing.Point(121, 75);
			this.cboBranch.Name = "cboBranch";
			this.cboBranch.Size = new global::System.Drawing.Size(200, 21);
			this.cboBranch.TabIndex = 54;
			this.Label17.AutoSize = true;
			this.Label17.Location = new global::System.Drawing.Point(71, 78);
			this.Label17.Name = "Label17";
			this.Label17.Size = new global::System.Drawing.Size(44, 13);
			this.Label17.TabIndex = 53;
			this.Label17.Text = "Branch:";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(797, 415);
			base.Controls.Add(this.dgvPromotions);
			base.Controls.Add(this.GroupBox1);
			base.Name = "PromotionsView";
			this.Text = "PromotionsView";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvPromotions).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400176E RID: 5998
		private global::System.ComponentModel.IContainer components;
	}
}
