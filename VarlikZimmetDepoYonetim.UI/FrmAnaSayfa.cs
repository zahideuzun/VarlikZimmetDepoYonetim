using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VarlikZimmetDepoYonetim.DTO;

namespace VarlikZimmetDepoYonetim.UI
{
	public partial class FrmAnaSayfa : Form
	{
		#region Instances

		private FrmVarliklar frmVarliklar;
		private FrmVarlikBilgileri frmVarlikBilgileri;
		private UserRole userRole;
		private FrmSSSorular frmSsSorular;
		FrmDuyurular frmDuyurular;
		private FrmRapor_1 frmRapor1;
		FrmRapor_2 frmRapor_2;

		#endregion

		public FrmAnaSayfa()
		{
			InitializeComponent();
		}


		public FrmAnaSayfa(UserRole userRole) : this()
		{
			this.userRole = userRole;
			
		}

		/// <summary>
		/// tüm varlıklar ekranını acar.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void allProductsListToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmVarliklar = new FrmVarliklar(userRole);
			frmVarliklar.MdiParent = this;
			frmVarliklar.Show();
			frmVarliklar.WindowState = FormWindowState.Maximized;
		}

		/// <summary>
		/// duyurular ekranını acar.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void announcementsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmDuyurular = new FrmDuyurular();
			frmDuyurular.MdiParent = this;
			frmDuyurular.Show();
			frmDuyurular.WindowState = FormWindowState.Maximized;
		}

		/// <summary>
		/// sık sorulan sorular ekranını acar.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void frequentlyAskedQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmSsSorular = new FrmSSSorular();
			frmSsSorular.MdiParent = this;
			frmSsSorular.Show();
			frmSsSorular.WindowState = FormWindowState.Maximized;
		}

		/// <summary>
		/// 1.rapor ekranını açar.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void firstReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmRapor1 = new FrmRapor_1();
			frmRapor1.MdiParent = this;
			frmRapor1.Show();
			frmRapor1.WindowState = FormWindowState.Maximized;
		}

		/// <summary>
		/// 2.rapor ekranını açar.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void secondReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmRapor_2 = new FrmRapor_2();
			frmRapor_2.MdiParent = this;
			frmRapor_2.Show();
			frmRapor_2.WindowState = FormWindowState.Maximized;
		}
	}
}
