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
		private FrmVarliklar frmVarliklar;
		private FrmVarlikBilgileri frmVarlikBilgileri;
		private UserRole userLogin;
		public FrmAnaSayfa()
		{
			InitializeComponent();
		}

		public FrmAnaSayfa(UserRole userLogin) : this()
		{
			this.userLogin = userLogin;
		}
		private void allProductsListToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmVarliklar = new FrmVarliklar(userLogin);
			frmVarliklar.MdiParent = this;
			frmVarliklar.Show();
		}

		private void updateProductsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			frmVarlikBilgileri = new FrmVarlikBilgileri();
			frmVarlikBilgileri.MdiParent = this;
			frmVarlikBilgileri.Show();
		}

		private void announcementsToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void frequentlyAskedQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}
