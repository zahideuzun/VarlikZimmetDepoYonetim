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
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.lblQuestion1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Location = new System.Drawing.Point(346, 168);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(232, 152);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// lblQuestion1
			// 
			this.lblQuestion1.AutoSize = true;
			this.lblQuestion1.Location = new System.Drawing.Point(75, 42);
			this.lblQuestion1.Name = "lblQuestion1";
			this.lblQuestion1.Size = new System.Drawing.Size(35, 13);
			this.lblQuestion1.TabIndex = 1;
			this.lblQuestion1.Text = "label1";
			// 
			// FrmSSSorular
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(610, 350);
			this.Controls.Add(this.lblQuestion1);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "FrmSSSorular";
			this.Text = "FrmSSSorular";
			this.Load += new System.EventHandler(this.FrmSSSorular_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label lblQuestion1;
	}
}