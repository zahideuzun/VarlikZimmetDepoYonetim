﻿namespace VarlikZimmetDepoYonetim.UI
{
	partial class FrmGirisEkrani
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
			this.tbUserMailAddress = new System.Windows.Forms.TextBox();
			this.tbUserPassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.cbShowPassword = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// tbUserMailAddress
			// 
			this.tbUserMailAddress.Location = new System.Drawing.Point(427, 335);
			this.tbUserMailAddress.Name = "tbUserMailAddress";
			this.tbUserMailAddress.Size = new System.Drawing.Size(147, 20);
			this.tbUserMailAddress.TabIndex = 0;
			// 
			// tbUserPassword
			// 
			this.tbUserPassword.Location = new System.Drawing.Point(427, 378);
			this.tbUserPassword.Name = "tbUserPassword";
			this.tbUserPassword.Size = new System.Drawing.Size(147, 20);
			this.tbUserPassword.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(260, 335);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Kullanıcı Mail Adresi: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(302, 381);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Kullanıcı Şifre: ";
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.SystemColors.Control;
			this.btnLogin.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnLogin.ForeColor = System.Drawing.Color.DodgerBlue;
			this.btnLogin.Location = new System.Drawing.Point(461, 422);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(113, 28);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "Giriş Yap";
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// cbShowPassword
			// 
			this.cbShowPassword.AutoSize = true;
			this.cbShowPassword.Location = new System.Drawing.Point(486, 404);
			this.cbShowPassword.Name = "cbShowPassword";
			this.cbShowPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cbShowPassword.Size = new System.Drawing.Size(88, 17);
			this.cbShowPassword.TabIndex = 3;
			this.cbShowPassword.Text = "Şifreyi Göster";
			this.cbShowPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cbShowPassword.UseVisualStyleBackColor = true;
			this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
			// 
			// FrmGirisEkrani
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::VarlikZimmetDepoYonetim.UI.Properties.Resources.Screenshot_11;
			this.ClientSize = new System.Drawing.Size(664, 462);
			this.Controls.Add(this.cbShowPassword);
			this.Controls.Add(this.btnLogin);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbUserPassword);
			this.Controls.Add(this.tbUserMailAddress);
			this.Name = "FrmGirisEkrani";
			this.Text = "FrmGirisEkrani";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbUserMailAddress;
		private System.Windows.Forms.TextBox tbUserPassword;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.CheckBox cbShowPassword;
	}
}