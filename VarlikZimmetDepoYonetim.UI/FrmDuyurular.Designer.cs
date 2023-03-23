namespace VarlikZimmetDepoYonetim.UI
{
	partial class FrmDuyurular
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
			this.treeAnnouncement = new System.Windows.Forms.TreeView();
			this.SuspendLayout();
			// 
			// treeAnnouncement
			// 
			this.treeAnnouncement.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.treeAnnouncement.Location = new System.Drawing.Point(0, 12);
			this.treeAnnouncement.Name = "treeAnnouncement";
			this.treeAnnouncement.Scrollable = false;
			this.treeAnnouncement.Size = new System.Drawing.Size(617, 355);
			this.treeAnnouncement.TabIndex = 0;
			// 
			// FrmDuyurular
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(617, 367);
			this.Controls.Add(this.treeAnnouncement);
			this.Name = "FrmDuyurular";
			this.Text = "FrmDuyurular";
			this.Load += new System.EventHandler(this.FrmDuyurular_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView treeAnnouncement;
	}
}