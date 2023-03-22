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
using VarlikZimmetDepoYonetim.DTO.Result;

namespace VarlikZimmetDepoYonetim.UI
{
	public partial class FrmTuket : Form
	{
		private int productId;
		CustomerProductDAL customerProduct;
		private Product product;


		public FrmTuket()
		{
			InitializeComponent();
		}

		public FrmTuket(int product) : this()
		{
			this.productId = product;
		}

		private void btnConsume_Click(object sender, EventArgs e)
		{
			customerProduct = new CustomerProductDAL();

			MyResult insertedCustomer = customerProduct.Insert(new CustomerProduct()
			{
				Description = tbDescription.Text,
				Customer = new Customer() { CustomerId = int.Parse(tbSubscriberNo.Text)},
				Product = new Product() { ProductId = product.ProductId }
			});
			MessageBox.Show(insertedCustomer.ResultMessage);

		}
	}
}
