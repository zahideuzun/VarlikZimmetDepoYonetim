namespace VarlikZimmetDepoYonetim.UI
{
	partial class FrmTuket
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbDescription = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnConsume = new System.Windows.Forms.Button();
			this.mtbSubscriberNo = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label1.Location = new System.Drawing.Point(55, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tüket";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(44, 82);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(70, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Abone No";
			// 
			// tbDescription
			// 
			this.tbDescription.Location = new System.Drawing.Point(47, 189);
			this.tbDescription.Multiline = true;
			this.tbDescription.Name = "tbDescription";
			this.tbDescription.Size = new System.Drawing.Size(276, 196);
			this.tbDescription.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(44, 157);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Açıklama";
			// 
			// btnConsume
			// 
			this.btnConsume.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnConsume.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnConsume.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnConsume.Location = new System.Drawing.Point(186, 406);
			this.btnConsume.Name = "btnConsume";
			this.btnConsume.Size = new System.Drawing.Size(137, 32);
			this.btnConsume.TabIndex = 5;
			this.btnConsume.Text = "> Tüket";
			this.btnConsume.UseVisualStyleBackColor = false;
			// 
			// mtbSubscriberNo
			// 
			this.mtbSubscriberNo.Location = new System.Drawing.Point(47, 120);
			this.mtbSubscriberNo.Mask = "00000000";
			this.mtbSubscriberNo.Name = "mtbSubscriberNo";
			this.mtbSubscriberNo.Size = new System.Drawing.Size(276, 20);
			this.mtbSubscriberNo.TabIndex = 6;
			this.mtbSubscriberNo.ValidatingType = typeof(int);
			// 
			// FrmTuket
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(368, 450);
			this.Controls.Add(this.mtbSubscriberNo);
			this.Controls.Add(this.btnConsume);
			this.Controls.Add(this.tbDescription);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FrmTuket";
			this.Text = "FrmTuket";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbDescription;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnConsume;
		private System.Windows.Forms.MaskedTextBox mtbSubscriberNo;
	}
}