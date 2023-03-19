using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VarlikZimmetDepoYonetim.DAL;
using VarlikZimmetDepoYonetim.DTO;

namespace VarlikZimmetDepoYonetim.UI
{
	public partial class FrmVarliklar : Form
	{
		public FrmVarliklar()
		{
			InitializeComponent();
		}

		private void FrmVarliklar_Load(object sender, EventArgs e)
		{
			// ProductDAL sınıfından bir nesne oluşturun ve Select() metodunu kullanarak List<Product> nesnesini alın
			ProductDAL productDAL = new ProductDAL();
			List<Product> products = productDAL.Select();

			// DataGridView nesnesinin DataSource özelliğini List<Product> nesnesine bağlayın
			dgvProducts.DataSource = products;
		}
	}
}
