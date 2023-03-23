namespace VarlikZimmetDepoYonetim.UI
{
	partial class FrmZimmetAtama
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
			this.tbDescription = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.cmbInventoryReason = new System.Windows.Forms.ComboBox();
			this.cmbInventoryType = new System.Windows.Forms.ComboBox();
			this.dtpInventoryEntry = new System.Windows.Forms.DateTimePicker();
			this.dtpInventoryEnd = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.btnInvertoryAdd = new System.Windows.Forms.Button();
			this.cmbInventoryPerson = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(34, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Zimmet Sahibi Kişi";
			// 
			// tbDescription
			// 
			this.tbDescription.Location = new System.Drawing.Point(37, 327);
			this.tbDescription.Multiline = true;
			this.tbDescription.Name = "tbDescription";
			this.tbDescription.Size = new System.Drawing.Size(261, 40);
			this.tbDescription.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(34, 101);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Zimmet Nedeni";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(35, 149);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 17);
			this.label3.TabIndex = 0;
			this.label3.Text = "Zimmet Türü";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(35, 197);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(158, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "Zimmet Başlangıç Tarihi";
			// 
			// cmbInventoryReason
			// 
			this.cmbInventoryReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbInventoryReason.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbInventoryReason.FormattingEnabled = true;
			this.cmbInventoryReason.Location = new System.Drawing.Point(38, 121);
			this.cmbInventoryReason.Name = "cmbInventoryReason";
			this.cmbInventoryReason.Size = new System.Drawing.Size(262, 25);
			this.cmbInventoryReason.TabIndex = 2;
			// 
			// cmbInventoryType
			// 
			this.cmbInventoryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbInventoryType.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbInventoryType.FormattingEnabled = true;
			this.cmbInventoryType.Location = new System.Drawing.Point(37, 169);
			this.cmbInventoryType.Name = "cmbInventoryType";
			this.cmbInventoryType.Size = new System.Drawing.Size(262, 25);
			this.cmbInventoryType.TabIndex = 2;
			this.cmbInventoryType.SelectedIndexChanged += new System.EventHandler(this.cmbInventoryType_SelectedIndexChanged);
			// 
			// dtpInventoryEntry
			// 
			this.dtpInventoryEntry.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.dtpInventoryEntry.Location = new System.Drawing.Point(37, 217);
			this.dtpInventoryEntry.Name = "dtpInventoryEntry";
			this.dtpInventoryEntry.Size = new System.Drawing.Size(262, 23);
			this.dtpInventoryEntry.TabIndex = 3;
			// 
			// dtpInventoryEnd
			// 
			this.dtpInventoryEnd.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.dtpInventoryEnd.Location = new System.Drawing.Point(38, 272);
			this.dtpInventoryEnd.Name = "dtpInventoryEnd";
			this.dtpInventoryEnd.Size = new System.Drawing.Size(262, 23);
			this.dtpInventoryEnd.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label5.Location = new System.Drawing.Point(34, 19);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(98, 19);
			this.label5.TabIndex = 0;
			this.label5.Text = "Zimmet Ata";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(35, 252);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(127, 17);
			this.label6.TabIndex = 0;
			this.label6.Text = "Zimmet Bitiş Tarihi";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(35, 307);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(64, 17);
			this.label7.TabIndex = 0;
			this.label7.Text = "Açıklama";
			// 
			// btnInvertoryAdd
			// 
			this.btnInvertoryAdd.BackColor = System.Drawing.Color.DodgerBlue;
			this.btnInvertoryAdd.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnInvertoryAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnInvertoryAdd.Location = new System.Drawing.Point(161, 387);
			this.btnInvertoryAdd.Name = "btnInvertoryAdd";
			this.btnInvertoryAdd.Size = new System.Drawing.Size(137, 32);
			this.btnInvertoryAdd.TabIndex = 4;
			this.btnInvertoryAdd.Text = "> Zimmet Ata";
			this.btnInvertoryAdd.UseVisualStyleBackColor = false;
			this.btnInvertoryAdd.Click += new System.EventHandler(this.btnInvertoryAdd_Click);
			// 
			// cmbInventoryPerson
			// 
			this.cmbInventoryPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbInventoryPerson.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbInventoryPerson.FormattingEnabled = true;
			this.cmbInventoryPerson.Location = new System.Drawing.Point(38, 73);
			this.cmbInventoryPerson.Name = "cmbInventoryPerson";
			this.cmbInventoryPerson.Size = new System.Drawing.Size(262, 25);
			this.cmbInventoryPerson.TabIndex = 2;
			// 
			// FrmZimmetAtama
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(337, 431);
			this.Controls.Add(this.btnInvertoryAdd);
			this.Controls.Add(this.dtpInventoryEnd);
			this.Controls.Add(this.dtpInventoryEntry);
			this.Controls.Add(this.cmbInventoryType);
			this.Controls.Add(this.cmbInventoryPerson);
			this.Controls.Add(this.cmbInventoryReason);
			this.Controls.Add(this.tbDescription);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label1);
			this.Name = "FrmZimmetAtama";
			this.Text = "FrmZimmetAtama";
			this.Load += new System.EventHandler(this.FrmZimmetAtama_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbDescription;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cmbInventoryReason;
		private System.Windows.Forms.ComboBox cmbInventoryType;
		private System.Windows.Forms.DateTimePicker dtpInventoryEntry;
		private System.Windows.Forms.DateTimePicker dtpInventoryEnd;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnInvertoryAdd;
		private System.Windows.Forms.ComboBox cmbInventoryPerson;
	}
}