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
			this.btnProductUpdate = new System.Windows.Forms.Button();
			this.pbQuestions = new System.Windows.Forms.PictureBox();
			this.pbAnnouncement = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbQuestions)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbAnnouncement)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// lblMyProducts
			// 
			this.lblMyProducts.AutoSize = true;
			this.lblMyProducts.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblMyProducts.Location = new System.Drawing.Point(203, 117);
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
			this.lblTeamProducts.Location = new System.Drawing.Point(362, 117);
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
			this.lblAllProducts.Location = new System.Drawing.Point(559, 117);
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
			this.label2.Location = new System.Drawing.Point(204, 154);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 17);
			this.label2.TabIndex = 8;
			this.label2.Text = "Depo Yönetimi";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(736, 117);
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
			this.lstProductList.Size = new System.Drawing.Size(702, 285);
			this.lstProductList.TabIndex = 10;
			this.lstProductList.UseCompatibleStateImageBehavior = false;
			this.lstProductList.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Kayıt No";
			this.columnHeader1.Width = 63;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Barkod Numarası";
			this.columnHeader2.Width = 143;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Ürün Tipi";
			this.columnHeader3.Width = 137;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Ürün Güncel Fiyatı";
			this.columnHeader4.Width = 141;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Marka";
			this.columnHeader5.Width = 109;
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
			this.groupBox1.Location = new System.Drawing.Point(3, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(152, 552);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = ".";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::VarlikZimmetDepoYonetim.UI.Properties.Resources.Screenshot_28;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(152, 546);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
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
			// pbQuestions
			// 
			this.pbQuestions.Image = global::VarlikZimmetDepoYonetim.UI.Properties.Resources.Screenshot_27;
			this.pbQuestions.Location = new System.Drawing.Point(791, 26);
			this.pbQuestions.Name = "pbQuestions";
			this.pbQuestions.Size = new System.Drawing.Size(43, 45);
			this.pbQuestions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbQuestions.TabIndex = 15;
			this.pbQuestions.TabStop = false;
			this.pbQuestions.Click += new System.EventHandler(this.pbQuestions_Click);
			// 
			// pbAnnouncement
			// 
			this.pbAnnouncement.Image = global::VarlikZimmetDepoYonetim.UI.Properties.Resources.Screenshot_26;
			this.pbAnnouncement.Location = new System.Drawing.Point(750, 26);
			this.pbAnnouncement.Name = "pbAnnouncement";
			this.pbAnnouncement.Size = new System.Drawing.Size(40, 45);
			this.pbAnnouncement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbAnnouncement.TabIndex = 14;
			this.pbAnnouncement.TabStop = false;
			this.pbAnnouncement.Click += new System.EventHandler(this.pbAnnouncement_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::VarlikZimmetDepoYonetim.UI.Properties.Resources.Screenshot_25;
			this.pictureBox2.Location = new System.Drawing.Point(152, 2);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(682, 101);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 13;
			this.pictureBox2.TabStop = false;
			// 
			// FrmVarliklar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(926, 547);
			this.Controls.Add(this.pbQuestions);
			this.Controls.Add(this.pbAnnouncement);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.btnProductUpdate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lstProductList);
			this.Controls.Add(this.lblAllProducts);
			this.Controls.Add(this.lblTeamProducts);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblMyProducts);
			this.Name = "FrmVarliklar";
			this.Text = "FrmVarliklar";
			this.Load += new System.EventHandler(this.FrmVarliklar_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbQuestions)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbAnnouncement)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblMyProducts;
		private System.Windows.Forms.Label lblTeamProducts;
		private System.Windows.Forms.Label lblAllProducts;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ListView lstProductList;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnProductUpdate;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pbAnnouncement;
		private System.Windows.Forms.PictureBox pbQuestions;
	}
}