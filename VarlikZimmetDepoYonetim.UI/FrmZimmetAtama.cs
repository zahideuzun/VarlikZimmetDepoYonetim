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
	public partial class FrmZimmetAtama : Form
	{
		private int products;

		public FrmZimmetAtama()
		{
			InitializeComponent();
		}

		public FrmZimmetAtama(int product)
		{
			this.products = product;
		}
	}
}
