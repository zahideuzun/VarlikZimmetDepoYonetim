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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
			
		}

		private void lblTeamProducts_Click(object sender, EventArgs e)
		{

		}

		private void lblAllProducts_Click(object sender, EventArgs e)
		{
			ProductDAL productDAL = new ProductDAL();
			List<Product> products = productDAL.Select();

			foreach (Product product in products)
			{
				ListViewItem h1 = new ListViewItem(product.ProductId.ToString());
				h1.SubItems.Add(product.ProductBarcode.ToString());
				h1.SubItems.Add(product.ProductType.ToString());
				h1.SubItems.Add(product.Price.ToString());
				h1.SubItems.Add(product.Brand.BrandName);
				h1.SubItems.Add(product.Model.ModelName);

				lstProductList.Items.Add(/*new ListViewItem[] {*/ h1);
			}
		}
	}
}
