namespace VarlikZimmetDepoYonetim.UI
{
	partial class FrmRapor_2
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
			this.lstCompanyTeamProduct = new System.Windows.Forms.ListView();
			this.btnCompany = new System.Windows.Forms.Button();
			this.cmbCompany = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbTeams = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// lstCompanyTeamProduct
			// 
			this.lstCompanyTeamProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.lstCompanyTeamProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lstCompanyTeamProduct.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lstCompanyTeamProduct.HideSelection = false;
			this.lstCompanyTeamProduct.Location = new System.Drawing.Point(0, 111);
			this.lstCompanyTeamProduct.Name = "lstCompanyTeamProduct";
			this.lstCompanyTeamProduct.Size = new System.Drawing.Size(800, 339);
			this.lstCompanyTeamProduct.TabIndex = 0;
			this.lstCompanyTeamProduct.UseCompatibleStateImageBehavior = false;
			this.lstCompanyTeamProduct.View = System.Windows.Forms.View.Details;
			// 
			// btnCompany
			// 
			this.btnCompany.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCompany.Location = new System.Drawing.Point(647, 57);
			this.btnCompany.Name = "btnCompany";
			this.btnCompany.Size = new System.Drawing.Size(75, 23);
			this.btnCompany.TabIndex = 1;
			this.btnCompany.Text = "ARA";
			this.btnCompany.UseVisualStyleBackColor = true;
			// 
			// cmbCompany
			// 
			this.cmbCompany.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbCompany.FormattingEnabled = true;
			this.cmbCompany.Location = new System.Drawing.Point(478, 24);
			this.cmbCompany.Name = "cmbCompany";
			this.cmbCompany.Size = new System.Drawing.Size(121, 24);
			this.cmbCompany.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label1.Location = new System.Drawing.Point(23, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(338, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "İstenilen şirketteki ekiplere zimmetlenmiş varlıklar>>";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(385, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 16);
			this.label2.TabIndex = 4;
			this.label2.Text = "Şirket Seçiniz:";
			// 
			// cmbTeams
			// 
			this.cmbTeams.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cmbTeams.FormattingEnabled = true;
			this.cmbTeams.Location = new System.Drawing.Point(478, 59);
			this.cmbTeams.Name = "cmbTeams";
			this.cmbTeams.Size = new System.Drawing.Size(121, 24);
			this.cmbTeams.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(388, 62);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Ekip Seçiniz: ";
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Ekip Adı";
			this.columnHeader1.Width = 100;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Ürün Barkod No";
			this.columnHeader2.Width = 216;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Marka";
			this.columnHeader3.Width = 91;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Model";
			this.columnHeader4.Width = 83;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Zimmet Başlangıç";
			this.columnHeader5.Width = 152;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Zimmet Bitiş";
			this.columnHeader6.Width = 154;
			// 
			// FrmRapor_2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbTeams);
			this.Controls.Add(this.cmbCompany);
			this.Controls.Add(this.btnCompany);
			this.Controls.Add(this.lstCompanyTeamProduct);
			this.Name = "FrmRapor_2";
			this.Text = "FrmRapor_2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lstCompanyTeamProduct;
		private System.Windows.Forms.Button btnCompany;
		private System.Windows.Forms.ComboBox cmbCompany;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbTeams;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
	}
}