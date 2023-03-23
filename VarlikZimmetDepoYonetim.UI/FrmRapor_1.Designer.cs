namespace VarlikZimmetDepoYonetim.UI
{
	partial class FrmRapor_1
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
			this.lstProductPriceReport = new System.Windows.Forms.ListView();
			this.tbReportSearchId = new System.Windows.Forms.TextBox();
			this.btnReportSearch = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// lstProductPriceReport
			// 
			this.lstProductPriceReport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader9,
            this.columnHeader8});
			this.lstProductPriceReport.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lstProductPriceReport.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lstProductPriceReport.HideSelection = false;
			this.lstProductPriceReport.Location = new System.Drawing.Point(0, 114);
			this.lstProductPriceReport.Name = "lstProductPriceReport";
			this.lstProductPriceReport.Size = new System.Drawing.Size(800, 336);
			this.lstProductPriceReport.TabIndex = 0;
			this.lstProductPriceReport.UseCompatibleStateImageBehavior = false;
			this.lstProductPriceReport.View = System.Windows.Forms.View.Details;
			// 
			// tbReportSearchId
			// 
			this.tbReportSearchId.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.tbReportSearchId.Location = new System.Drawing.Point(532, 62);
			this.tbReportSearchId.Name = "tbReportSearchId";
			this.tbReportSearchId.Size = new System.Drawing.Size(116, 22);
			this.tbReportSearchId.TabIndex = 1;
			// 
			// btnReportSearch
			// 
			this.btnReportSearch.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnReportSearch.Location = new System.Drawing.Point(669, 60);
			this.btnReportSearch.Name = "btnReportSearch";
			this.btnReportSearch.Size = new System.Drawing.Size(75, 23);
			this.btnReportSearch.TabIndex = 2;
			this.btnReportSearch.Text = "ARA";
			this.btnReportSearch.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(229, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(297, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Bilgilerini görmek istediğiniz ürün numarasını giriniz: ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
			this.label2.Location = new System.Drawing.Point(51, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(646, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "Aktif olarak herhangi bir ekipte zimmetli olan bir ürünün tüm fiyat değişimleri v" +
    "e zimmet durumları>>";
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Ürün No";
			this.columnHeader1.Width = 66;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Zimmet Nedeni";
			this.columnHeader3.Width = 106;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Ürün Markası";
			this.columnHeader4.Width = 93;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Ürün Modeli";
			this.columnHeader5.Width = 99;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Zimmetli olduğu ekip";
			this.columnHeader6.Width = 134;
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Fiyat";
			this.columnHeader7.Width = 66;
			// 
			// columnHeader8
			// 
			this.columnHeader8.DisplayIndex = 6;
			this.columnHeader8.Text = "Para Birimi";
			this.columnHeader8.Width = 91;
			// 
			// columnHeader9
			// 
			this.columnHeader9.DisplayIndex = 7;
			this.columnHeader9.Text = "Fiyat Değişim Tarihi";
			this.columnHeader9.Width = 138;
			// 
			// FrmRapor_1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnReportSearch);
			this.Controls.Add(this.tbReportSearchId);
			this.Controls.Add(this.lstProductPriceReport);
			this.Name = "FrmRapor_1";
			this.Text = "FrmRapor_1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lstProductPriceReport;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.TextBox tbReportSearchId;
		private System.Windows.Forms.Button btnReportSearch;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}