using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VarlikZimmetDepoYonetim.Provider;

namespace VarlikZimmetDepoYonetim.UI
{
	public partial class FrmGirisEkrani : Form
	{
		private SqlProviderService sqlProviderService;
		private FrmAnaSayfa frmAnaSayfa;
		public FrmGirisEkrani()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (true)
			{
				//sqlProviderService = new SqlProviderService()
			}
		}

		void Login()
		{

		}
	}
}
