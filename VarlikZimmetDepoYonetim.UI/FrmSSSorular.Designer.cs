namespace VarlikZimmetDepoYonetim.UI
{
	partial class FrmSSSorular
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
			this.treeViewQuestions = new System.Windows.Forms.TreeView();
			this.SuspendLayout();
			// 
			// treeViewQuestions
			// 
			this.treeViewQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeViewQuestions.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.treeViewQuestions.Location = new System.Drawing.Point(0, 0);
			this.treeViewQuestions.Name = "treeViewQuestions";
			this.treeViewQuestions.Size = new System.Drawing.Size(610, 350);
			this.treeViewQuestions.TabIndex = 0;
			// 
			// FrmSSSorular
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(610, 350);
			this.Controls.Add(this.treeViewQuestions);
			this.Name = "FrmSSSorular";
			this.Text = "FrmSSSorular";
			this.Load += new System.EventHandler(this.FrmSSSorular_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TreeView treeViewQuestions;
	}
}