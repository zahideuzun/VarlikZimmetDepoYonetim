namespace VarlikZimmetDepoYonetim.UI
{
	partial class FrmVarliklar
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
			this.tb = new System.Windows.Forms.TextBox();
			this.btnYeniKayit = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// tb
			// 
			this.tb.Location = new System.Drawing.Point(310, 68);
			this.tb.Name = "tb";
			this.tb.Size = new System.Drawing.Size(156, 20);
			this.tb.TabIndex = 0;
			// 
			// btnYeniKayit
			// 
			this.btnYeniKayit.BackColor = System.Drawing.Color.MediumBlue;
			this.btnYeniKayit.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnYeniKayit.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnYeniKayit.Location = new System.Drawing.Point(63, 171);
			this.btnYeniKayit.Name = "btnYeniKayit";
			this.btnYeniKayit.Size = new System.Drawing.Size(154, 39);
			this.btnYeniKayit.TabIndex = 1;
			this.btnYeniKayit.Text = "Yeni Kayıt";
			this.btnYeniKayit.UseVisualStyleBackColor = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::VarlikZimmetDepoYonetim.UI.Properties.Resources.Screenshot_10;
			this.pictureBox1.Location = new System.Drawing.Point(23, 59);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(214, 106);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// FrmVarliklar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 564);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnYeniKayit);
			this.Controls.Add(this.tb);
			this.Name = "FrmVarliklar";
			this.Text = "FrmVarliklar";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tb;
		private System.Windows.Forms.Button btnYeniKayit;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}