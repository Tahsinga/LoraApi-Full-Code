namespace PointOfSale
{
	// Token: 0x0200000B RID: 11
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated]
	public partial class ADF_SalesReport_Dubai : global::System.Windows.Forms.UserControl
	{
		// Token: 0x06000214 RID: 532 RVA: 0x00012BF4 File Offset: 0x00010DF4
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

		// Token: 0x06000215 RID: 533 RVA: 0x00012C44 File Offset: 0x00010E44
		[global::System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.Panel1 = new global::System.Windows.Forms.Panel();
			this.chkHidePayMethods = new global::System.Windows.Forms.CheckBox();
			this.chkHideCogs = new global::System.Windows.Forms.CheckBox();
			this.Label4 = new global::System.Windows.Forms.Label();
			this.Button2 = new global::System.Windows.Forms.Button();
			this.Button1 = new global::System.Windows.Forms.Button();
			this.Label3 = new global::System.Windows.Forms.Label();
			this.Label2 = new global::System.Windows.Forms.Label();
			this.DTenddate = new global::System.Windows.Forms.DateTimePicker();
			this.DTstartdate = new global::System.Windows.Forms.DateTimePicker();
			this.Label1 = new global::System.Windows.Forms.Label();
			this.dgvR = new global::System.Windows.Forms.DataGridView();
			this.SaveFileDialog1 = new global::System.Windows.Forms.SaveFileDialog();
			this.Panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvR).BeginInit();
			base.SuspendLayout();
			this.Panel1.Controls.Add(this.chkHidePayMethods);
			this.Panel1.Controls.Add(this.chkHideCogs);
			this.Panel1.Controls.Add(this.Label4);
			this.Panel1.Controls.Add(this.Button2);
			this.Panel1.Controls.Add(this.Button1);
			this.Panel1.Controls.Add(this.Label3);
			this.Panel1.Controls.Add(this.Label2);
			this.Panel1.Controls.Add(this.DTenddate);
			this.Panel1.Controls.Add(this.DTstartdate);
			this.Panel1.Controls.Add(this.Label1);
			this.Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.Panel1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new global::System.Drawing.Size(1328, 209);
			this.Panel1.TabIndex = 1;
			this.chkHidePayMethods.AutoSize = true;
			this.chkHidePayMethods.Location = new global::System.Drawing.Point(846, 160);
			this.chkHidePayMethods.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.chkHidePayMethods.Name = "chkHidePayMethods";
			this.chkHidePayMethods.Size = new global::System.Drawing.Size(200, 24);
			this.chkHidePayMethods.TabIndex = 12;
			this.chkHidePayMethods.Text = "Hide Payment Methods";
			this.chkHidePayMethods.UseVisualStyleBackColor = true;
			this.chkHideCogs.AutoSize = true;
			this.chkHideCogs.Location = new global::System.Drawing.Point(543, 162);
			this.chkHideCogs.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.chkHideCogs.Name = "chkHideCogs";
			this.chkHideCogs.Size = new global::System.Drawing.Size(271, 24);
			this.chkHideCogs.TabIndex = 11;
			this.chkHideCogs.Text = "Hide Cost of Goods sold columns";
			this.chkHideCogs.UseVisualStyleBackColor = true;
			this.Label4.AutoSize = true;
			this.Label4.BackColor = global::System.Drawing.Color.Red;
			this.Label4.Dock = global::System.Windows.Forms.DockStyle.Right;
			this.Label4.ForeColor = global::System.Drawing.Color.Black;
			this.Label4.Location = new global::System.Drawing.Point(1279, 0);
			this.Label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new global::System.Drawing.Size(49, 20);
			this.Label4.TabIndex = 10;
			this.Label4.Text = "Close";
			this.Button2.BackColor = global::System.Drawing.Color.Yellow;
			this.Button2.Location = new global::System.Drawing.Point(1072, 155);
			this.Button2.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button2.Name = "Button2";
			this.Button2.Size = new global::System.Drawing.Size(250, 35);
			this.Button2.TabIndex = 9;
			this.Button2.Text = "Export to CSV File";
			this.Button2.UseVisualStyleBackColor = false;
			this.Button1.BackColor = global::System.Drawing.Color.Lime;
			this.Button1.Location = new global::System.Drawing.Point(219, 154);
			this.Button1.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Button1.Name = "Button1";
			this.Button1.Size = new global::System.Drawing.Size(300, 35);
			this.Button1.TabIndex = 7;
			this.Button1.Text = "View Report";
			this.Button1.UseVisualStyleBackColor = false;
			this.Label3.AutoSize = true;
			this.Label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.Label3.Location = new global::System.Drawing.Point(122, 14);
			this.Label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new global::System.Drawing.Size(703, 32);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "ADF SALES REPORT SPECIAL DUBAI FORMATTING";
			this.Label2.AutoSize = true;
			this.Label2.Location = new global::System.Drawing.Point(128, 122);
			this.Label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new global::System.Drawing.Size(81, 20);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "End Date:";
			this.DTenddate.Location = new global::System.Drawing.Point(219, 114);
			this.DTenddate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTenddate.Name = "DTenddate";
			this.DTenddate.Size = new global::System.Drawing.Size(298, 26);
			this.DTenddate.TabIndex = 2;
			this.DTstartdate.Location = new global::System.Drawing.Point(219, 74);
			this.DTstartdate.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.DTstartdate.Name = "DTstartdate";
			this.DTstartdate.Size = new global::System.Drawing.Size(298, 26);
			this.DTstartdate.TabIndex = 1;
			this.Label1.AutoSize = true;
			this.Label1.Location = new global::System.Drawing.Point(123, 80);
			this.Label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.Size = new global::System.Drawing.Size(87, 20);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Start Date:";
			this.dgvR.AllowUserToAddRows = false;
			this.dgvR.AllowUserToDeleteRows = false;
			this.dgvR.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvR.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.dgvR.Location = new global::System.Drawing.Point(0, 209);
			this.dgvR.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvR.Name = "dgvR";
			this.dgvR.ReadOnly = true;
			this.dgvR.Size = new global::System.Drawing.Size(1328, 473);
			this.dgvR.TabIndex = 2;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 20f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.dgvR);
			base.Controls.Add(this.Panel1);
			base.Margin = new global::System.Windows.Forms.Padding(4, 5, 4, 5);
			base.Name = "ADF_SalesReport_Dubai";
			base.Size = new global::System.Drawing.Size(1328, 682);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.dgvR).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040000E5 RID: 229
		private global::System.ComponentModel.IContainer components;
	}
}
