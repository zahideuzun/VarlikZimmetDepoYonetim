using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using VarlikZimmetDepoYonetim.DAL;
using VarlikZimmetDepoYonetim.DTO;

namespace VarlikZimmetDepoYonetim.UI
{
	public partial class FrmVarliklar : Form
	{
		#region Instances

		private UserRole userRole = new UserRole();
		List<TeamAssignment> teamAssignments = new List<TeamAssignment>();
		List<UserAssignment> userAssignments;
		private UserAssignment selectedUserAssignment;
		private List<Product> products;
		private Product selectedProduct;

		#endregion

		public FrmVarliklar()
		{
			InitializeComponent();
		}

		public FrmVarliklar(UserRole userRole) : this()
		{
			lblAllProducts.Enabled = false;
			this.userRole = userRole;
			
		}

		private void FrmVarliklar_Load(object sender, EventArgs e)
		{
			if (userRole.Role.RoleName == "PowerUser" || userRole.Role.RoleName == "Depo Admin") lblAllProducts.Enabled = true;
		}

		/// <summary>
		/// Giris yapan kullanicinin ekibine ait ürünleri listeleyen event.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void lblTeamProducts_Click(object sender, EventArgs e)
		{
			lstProductList.Items.Clear();
			TeamAssignmentDAL teamAssignmentDal = new TeamAssignmentDAL();
			teamAssignments = teamAssignmentDal.Select(userRole.User.Team.TeamId);
			foreach (TeamAssignment teamAssignment in teamAssignments)
			{
				ListViewItem h1 = new ListViewItem(teamAssignment.TeamAssignmentId.ToString());
				h1.SubItems.Add(teamAssignment.InventoryAssignment.Product.ProductBarcode.ToString());
				h1.SubItems.Add(teamAssignment.InventoryAssignment.Product.ProductType.ToString());
				h1.SubItems.Add(teamAssignment.InventoryAssignment.Product.Price.ToString());
				h1.SubItems.Add(teamAssignment.InventoryAssignment.Product.Brand.BrandName);
				h1.SubItems.Add(teamAssignment.InventoryAssignment.Product.Model.ModelName);

				lstProductList.Items.Add(h1);
			}
		}

		/// <summary>
		/// Giris yapan kullanici Depo Admin ya da Power User ise sistemde kayitli tüm varliklari görebilir. Bu click yalnizca bu rollere aciktir.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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

		/// <summary>
		/// Giriş yapan kullanicinin kendisine zimmetlenmis ürünleri görebildigi
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void lblMyProducts_Click(object sender, EventArgs e)
		{
			lstProductList.Items.Clear();
			UserAssignmentDAL userAssignmentDal = new UserAssignmentDAL();
			List<UserAssignment> userAssignments = userAssignmentDal.Select(userRole.User.UserId);
			
			foreach (UserAssignment userAssignment in userAssignments)
			{
				ListViewItem h1 = new ListViewItem(userAssignment.UserAssignmentId.ToString());
				h1.SubItems.Add(userAssignment.InventoryAssignment.Product.ProductBarcode.ToString());
				h1.SubItems.Add(userAssignment.InventoryAssignment.Product.ProductType.ToString());
				h1.SubItems.Add(userAssignment.InventoryAssignment.Product.Price.ToString());
				h1.SubItems.Add(userAssignment.InventoryAssignment.Product.Brand.BrandName);
				h1.SubItems.Add(userAssignment.InventoryAssignment.Product.Model.ModelName);

				lstProductList.Items.Add(h1);
			}
		}

		/// <summary>
		/// giriş yapan kullanıcı rollerinden power user rolü kontrol eder. 
		/// </summary>
		/// <returns></returns>
		private bool PowerUserRole()
		{
			return userRole.Role.RoleName == "PowerUser";
		}

		/// <summary>
		/// seçilen varlığın güncelleme sayfasına yönlendirir.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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

		/// <summary>
		/// duyurular ekranına yönlendirir.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pbAnnouncement_Click(object sender, EventArgs e)
		{
			FrmDuyurular frmDuyurular = new FrmDuyurular();
			frmDuyurular.Show();
		}

		/// <summary>
		/// sık sorulan sorular ekranına yönlendirir.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pbQuestions_Click(object sender, EventArgs e)
		{
			FrmSSSorular frmSsSorular = new FrmSSSorular();
			frmSsSorular.Show();
		}
	}
}
