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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblMyProducts = new System.Windows.Forms.Label();
			this.lblTeamProducts = new System.Windows.Forms.Label();
			this.lblAllProducts = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lstProductList = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.btnProductUpdate = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// tb
			// 
			this.tb.Location = new System.Drawing.Point(173, 50);
			this.tb.Name = "tb";
			this.tb.Size = new System.Drawing.Size(156, 20);
			this.tb.TabIndex = 0;
			// 
			// btnYeniKayit
			// 
			this.btnYeniKayit.BackColor = System.Drawing.Color.MediumBlue;
			this.btnYeniKayit.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnYeniKayit.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnYeniKayit.Location = new System.Drawing.Point(7, 110);
			this.btnYeniKayit.Name = "btnYeniKayit";
			this.btnYeniKayit.Size = new System.Drawing.Size(126, 29);
			this.btnYeniKayit.TabIndex = 1;
			this.btnYeniKayit.Text = "Yeni Kayıt";
			this.btnYeniKayit.UseVisualStyleBackColor = false;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(562, 41);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(163, 21);
			this.comboBox1.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(180, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Ne arıyorsunuz?";
			// 
			// lblMyProducts
			// 
			this.lblMyProducts.AutoSize = true;
			this.lblMyProducts.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblMyProducts.Location = new System.Drawing.Point(173, 117);
			this.lblMyProducts.Name = "lblMyProducts";
			this.lblMyProducts.Size = new System.Drawing.Size(90, 19);
			this.lblMyProducts.TabIndex = 7;
			this.lblMyProducts.Text = "Varlıklarım";
			this.lblMyProducts.Click += new System.EventHandler(this.lblMyProducts_Click);
			// 
			// lblTeamProducts
			// 
			this.lblTeamProducts.AutoSize = true;
			this.lblTeamProducts.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblTeamProducts.Location = new System.Drawing.Point(313, 117);
			this.lblTeamProducts.Name = "lblTeamProducts";
			this.lblTeamProducts.Size = new System.Drawing.Size(144, 19);
			this.lblTeamProducts.TabIndex = 7;
			this.lblTeamProducts.Text = "Ekibimin Varlıkları";
			this.lblTeamProducts.Click += new System.EventHandler(this.lblTeamProducts_Click);
			// 
			// lblAllProducts
			// 
			this.lblAllProducts.AutoSize = true;
			this.lblAllProducts.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblAllProducts.Location = new System.Drawing.Point(493, 117);
			this.lblAllProducts.Name = "lblAllProducts";
			this.lblAllProducts.Size = new System.Drawing.Size(109, 19);
			this.lblAllProducts.TabIndex = 7;
			this.lblAllProducts.Text = "Tüm Varlıklar";
			this.lblAllProducts.Click += new System.EventHandler(this.lblAllProducts_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label2.Location = new System.Drawing.Point(18, 184);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 17);
			this.label2.TabIndex = 8;
			this.label2.Text = "Depo Yönetimi";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(644, 117);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 19);
			this.label3.TabIndex = 7;
			this.label3.Text = "Alarm";
			// 
			// lstProductList
			// 
			this.lstProductList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.lstProductList.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lstProductList.FullRowSelect = true;
			this.lstProductList.HideSelection = false;
			this.lstProductList.Location = new System.Drawing.Point(171, 186);
			this.lstProductList.Name = "lstProductList";
			this.lstProductList.Size = new System.Drawing.Size(603, 285);
			this.lstProductList.TabIndex = 10;
			this.lstProductList.UseCompatibleStateImageBehavior = false;
			this.lstProductList.View = System.Windows.Forms.View.Details;
			this.lstProductList.SelectedIndexChanged += new System.EventHandler(this.lstProductList_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Kayıt No";
			this.columnHeader1.Width = 63;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Barkod Numarası";
			this.columnHeader2.Width = 110;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Ürün Tipi";
			this.columnHeader3.Width = 137;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Ürün Güncel Fiyatı";
			this.columnHeader4.Width = 113;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Marka";
			this.columnHeader5.Width = 84;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Model";
			this.columnHeader6.Width = 101;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.btnYeniKayit);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(152, 552);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = ".";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::VarlikZimmetDepoYonetim.UI.Properties.Resources.Screenshot_10;
			this.pictureBox1.Location = new System.Drawing.Point(9, 32);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(126, 69);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// button2
			// 
			this.button2.BackgroundImage = global::VarlikZimmetDepoYonetim.UI.Properties.Resources.indir;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button2.Location = new System.Drawing.Point(516, 34);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(40, 32);
			this.button2.TabIndex = 9;
			this.button2.Text = ".";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.BackgroundImage = global::VarlikZimmetDepoYonetim.UI.Properties.Resources.png_transparent_announce_megaphone_icon_megaphone_icon_announcement_icon_symbol_announcement_communication_marketing_speaker_thumbnail;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.Location = new System.Drawing.Point(470, 35);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(40, 30);
			this.button1.TabIndex = 6;
			this.button1.Text = ".";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// btnProductUpdate
			// 
			this.btnProductUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnProductUpdate.Location = new System.Drawing.Point(664, 488);
			this.btnProductUpdate.Name = "btnProductUpdate";
			this.btnProductUpdate.Size = new System.Drawing.Size(100, 47);
			this.btnProductUpdate.TabIndex = 12;
			this.btnProductUpdate.Text = "Varlık Güncelle";
			this.btnProductUpdate.UseVisualStyleBackColor = true;
			this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
			// 
			// FrmVarliklar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(818, 547);
			this.Controls.Add(this.btnProductUpdate);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lstProductList);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.lblAllProducts);
			this.Controls.Add(this.lblTeamProducts);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblMyProducts);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.tb);
			this.Name = "FrmVarliklar";
			this.Text = "FrmVarliklar";
			this.Load += new System.EventHandler(this.FrmVarliklar_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tb;
		private System.Windows.Forms.Button btnYeniKayit;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label lblMyProducts;
		private System.Windows.Forms.Label lblTeamProducts;
		private System.Windows.Forms.Label lblAllProducts;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ListView lstProductList;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnProductUpdate;
	}
}