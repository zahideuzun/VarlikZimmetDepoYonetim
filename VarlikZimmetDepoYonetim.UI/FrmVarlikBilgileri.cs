using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VarlikZimmetDepoYonetim.UI
{
	
	public partial class FrmVarlikBilgileri : Form
	{
		FrmZimmetAtama zimmetAtama;
		private FrmTuket tuket;
		public FrmVarlikBilgileri()
		{
			InitializeComponent();
		}

		private void cmbActions_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbActions.SelectedItem == "Zimmet Ata")
			{
				zimmetAtama = new FrmZimmetAtama();
				zimmetAtama.Show();
			}

			else if (cmbActions.SelectedItem == "Tüket")
			{
				tuket = new FrmTuket();
				tuket.Show();
			}
			else MessageBox.Show("Bu sayfaya giriş yetkiniz yok!");
			cmbActions.SelectedText = null;
		}
	}
}
