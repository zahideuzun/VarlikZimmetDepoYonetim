namespace VarlikZimmetDepoYonetim.UI
{
	partial class FrmAnaSayfa
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip2 = new System.Windows.Forms.MenuStrip();
			this.varlıkDepoYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.allProductsListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.raporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip2
			// 
			this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.varlıkDepoYönetimiToolStripMenuItem,
            this.raporlamaToolStripMenuItem});
			this.menuStrip2.Location = new System.Drawing.Point(0, 0);
			this.menuStrip2.Name = "menuStrip2";
			this.menuStrip2.Size = new System.Drawing.Size(844, 24);
			this.menuStrip2.TabIndex = 0;
			this.menuStrip2.Text = "menuStrip2";
			// 
			// varlıkDepoYönetimiToolStripMenuItem
			// 
			this.varlıkDepoYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allProductsListToolStripMenuItem});
			this.varlıkDepoYönetimiToolStripMenuItem.Name = "varlıkDepoYönetimiToolStripMenuItem";
			this.varlıkDepoYönetimiToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
			this.varlıkDepoYönetimiToolStripMenuItem.Text = "Varlık-Depo Yönetimi";
			// 
			// allProductsListToolStripMenuItem
			// 
			this.allProductsListToolStripMenuItem.Name = "allProductsListToolStripMenuItem";
			this.allProductsListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.allProductsListToolStripMenuItem.Text = "Tüm Varlıklar";
			this.allProductsListToolStripMenuItem.Click += new System.EventHandler(this.allProductsListToolStripMenuItem_Click);
			// 
			// raporlamaToolStripMenuItem
			// 
			this.raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
			this.raporlamaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
			this.raporlamaToolStripMenuItem.Text = "Raporlama";
			// 
			// FrmAnaSayfa
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(844, 431);
			this.Controls.Add(this.menuStrip2);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip2;
			this.Name = "FrmAnaSayfa";
			this.Text = "Form1";
			this.menuStrip2.ResumeLayout(false);
			this.menuStrip2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.MenuStrip menuStrip2;
		private System.Windows.Forms.ToolStripMenuItem varlıkDepoYönetimiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem allProductsListToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem;
	}
}
	


