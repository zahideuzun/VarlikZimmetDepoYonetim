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
		private UserRole userLogin = new UserRole();
		private FrmVarlikBilgileri frmVarlikBilgileri;
		private User user;
		private List<TeamAssignment> teamAssignments;
		List<UserAssignment> userAssignments;
		private UserAssignment selectedUserAssignment;
		private List<Product> products;
		private Product selectedProduct;
		public FrmVarliklar()
		{
			InitializeComponent();
		}

		public FrmVarliklar(UserRole userLogin) : this()
		{
			lblAllProducts.Enabled = false;
			this.userLogin = userLogin;
		}

		private void FrmVarliklar_Load(object sender, EventArgs e)
		{
			if (userLogin.Role.RoleName == "PowerUser" || userLogin.Role.RoleName == "Depo Admin") lblAllProducts.Enabled = true;
		}

		private void lblTeamProducts_Click(object sender, EventArgs e)
		{
			lstProductList.Items.Clear();
			TeamAssignmentDAL teamAssignmentDal = new TeamAssignmentDAL();
			List<TeamAssignment> teamAssignments = teamAssignmentDal.Select(4);
			int number = 1;
			foreach (TeamAssignment teamAssignment in teamAssignments)
			{
				ListViewItem h1 = new ListViewItem(number++.ToString());
				h1.SubItems.Add(teamAssignment.InventoryAssignment.Product.ProductBarcode.ToString());
				h1.SubItems.Add(teamAssignment.InventoryAssignment.Product.ProductType.ToString());
				h1.SubItems.Add(teamAssignment.InventoryAssignment.Product.Price.ToString());
				h1.SubItems.Add(teamAssignment.InventoryAssignment.Product.Brand.BrandName);
				h1.SubItems.Add(teamAssignment.InventoryAssignment.Product.Model.ModelName);

				lstProductList.Items.Add(h1);
			}
		}

		private void lblAllProducts_Click(object sender, EventArgs e)
		{
			ProductDAL productDAL = new ProductDAL();
			products = productDAL.Select();

			foreach (Product product in products)
			{
				ListViewItem h1 = new ListViewItem(product.ProductId.ToString());
				h1.SubItems.Add(product.ProductBarcode.ToString());
				h1.SubItems.Add(product.ProductType.ToString());
				h1.SubItems.Add(product.Price.ToString());
				h1.SubItems.Add(product.Brand.BrandName);
				h1.SubItems.Add(product.Model.ModelName);

				lstProductList.Items.Add(h1);
			}
		}

		private void lblMyProducts_Click(object sender, EventArgs e)
		{
			lstProductList.Items.Clear();
			UserAssignmentDAL userAssignmentDal = new UserAssignmentDAL();
			List<UserAssignment> userAssignments = userAssignmentDal.Select(2);
			int number = 1;
			foreach (UserAssignment userAssignment in userAssignments)
			{
				ListViewItem h1 = new ListViewItem(number++.ToString());
				h1.SubItems.Add(userAssignment.InventoryAssignment.Product.ProductBarcode.ToString());
				h1.SubItems.Add(userAssignment.InventoryAssignment.Product.ProductType.ToString());
				h1.SubItems.Add(userAssignment.InventoryAssignment.Product.Price.ToString());
				h1.SubItems.Add(userAssignment.InventoryAssignment.Product.Brand.BrandName);
				h1.SubItems.Add(userAssignment.InventoryAssignment.Product.Model.ModelName);

				lstProductList.Items.Add(h1);
			}
		}

		private void lstProductList_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private bool PowerUserRole()
		{
			return userLogin.Role.RoleName == "PowerUser";
		}

		private void btnProductUpdate_Click(object sender, EventArgs e)
		{
			//SelectedItems[0] yani seçtiğimiz itemsin indeksini bize döndürür. Bir adet değer seçtiğimizden dolayı 0 veririz.
			//SubItems ise bize hangi sütunu seçtiğimizi belirtir. 1 ile adı soyadı bilgisini geri döndürür.
			string selectedId = lstProductList.SelectedItems[0].SubItems[0].Text;

			if (!PowerUserRole())
			{
				foreach (UserAssignment userAssignment in userAssignments)
				{
					if (userAssignment.UserAssignmentId == int.Parse(selectedId))
					{
						selectedUserAssignment = userAssignment;
					}
				}
				FrmVarlikBilgileri frmVarlikBilgileri = new FrmVarlikBilgileri(selectedUserAssignment);
				frmVarlikBilgileri.Show();
				this.Tag = selectedUserAssignment.InventoryAssignment.Product;
			}
			else
			{

				foreach (Product product in products)
				{
					if (product.ProductId == int.Parse(selectedId))
					{
						selectedProduct = product;
					}

				}
				FrmVarlikBilgileri frmVarlikBilgileri = new FrmVarlikBilgileri(selectedProduct);
				frmVarlikBilgileri.Show();
				this.Tag = selectedProduct;
			}
		}
		
	}
}
