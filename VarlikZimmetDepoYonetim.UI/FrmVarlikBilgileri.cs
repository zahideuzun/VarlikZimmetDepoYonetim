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
	
	public partial class FrmVarlikBilgileri : Form
	{
		#region Instances

		FrmZimmetAtama zimmetAtama;
		private FrmTuket tuket;
		private UserAssignment selectedUserAssignment;
		private Product selectedProduct;
		List<Price> prices;
		List<Currency> currencies;
		List<Product> products;
		List<ProductType> productTypes;
		private ProductDAL productDal;
		private CurrencyDAL currencyDAL;
		private PriceDAL priceDAL;
		private ProductTypeDAL productTypeDal;
		private BrandDAL brandDal;
		Product product;

		#endregion

		public FrmVarlikBilgileri()
		{
			InitializeComponent();
		}

		public FrmVarlikBilgileri(UserAssignment selectedUserAssignment) : this()
		{
			this.selectedUserAssignment = selectedUserAssignment;
		}

		public FrmVarlikBilgileri(Product selectedProduct) : this() 
		{
			this.selectedProduct = selectedProduct;
		}

		private void cmbActions_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbActions.SelectedItem == "Zimmet Ata")
			{
				zimmetAtama = new FrmZimmetAtama(product.ProductId);
				zimmetAtama.Show();
			}

			else if (cmbActions.SelectedItem == "Tüket")
			{
				tuket = new FrmTuket(product.ProductId);
				tuket.Show();
			}
			else MessageBox.Show("Bu sayfaya giriş yetkiniz yok!");
			cmbActions.SelectedText = null;
		}

		private void FrmVarlikBilgileri_Load(object sender, EventArgs e)
		{
			FormLoad();
		}

		void FormLoad()
		{
			#region Instances
			productDal = new ProductDAL();
			currencyDAL = new CurrencyDAL();
			priceDAL = new PriceDAL();
			productTypeDal = new ProductTypeDAL();
			brandDal = new BrandDAL();


			#endregion

			ListViewItem h1 = new ListViewItem(selectedProduct.EntryDate.ToString());
			//h1.SubItems.Add(selectedProduct.CreatedById.ToString() = "zahide");
			//h1.SubItems.Add(selectedProduct.ProductStatus.ProductStatusName);
			h1.SubItems.Add(selectedProduct.Description);
			lstProductStatus.Items.Add(h1);


			#region EnabledControl
			cmbUnit.Enabled = false;
			numAmount.Enabled = false;
			cmbModel.Enabled = false;
			dtpProductRetirementDate.Enabled = false;
			tbBarcode.Enabled = false;
			cmbBrand.Enabled = false;
			cmbProductCurrency.Enabled = false;
			cmbProductType.Enabled = false;
			tbProductCost.Enabled = false;
			dtpProductDateOfEntry.Enabled = false;
			#endregion


			#region FormLoadControls

			if (selectedProduct == null)
			{
				prices = priceDAL.Select(selectedUserAssignment.InventoryAssignment.Product.ProductId);
				products = productDal.Select(selectedUserAssignment.InventoryAssignment.Product.ProductId);
				//lblProductName.Text = selectedUserAssignment.InventoryAssignment.Product.ProductId.ToString();
			}
			else
			{
				prices = priceDAL.Select(selectedProduct.ProductId);
				products = productDal.Select(selectedProduct.ProductId);
				//lblProductName.Text = selectedProduct.ProductId.ToString();
			}


			currencies = currencyDAL.Select();
			productTypes = productTypeDal.Select();
			brands = brandDal.Select();
			tbBarcode.Text = products[0].ProductBarcode.ToString();
			cmbProductType.SelectedItem = productTypes[0].ProductTypeName;
			cmbProductType.Text = products[0].ProductType.ProductTypeName;
			cmbGuarente.SelectedItem = (products[0].IsWarrantyValid ? 1 : 0);
			cmbGuarente.Text = products[0].IsWarrantyValid ? "Evet" : "Hayır";
			tbProductCost.Text = products[0].ProductCost.ToString();
			dtpProductDateOfEntry.Value = products[0].EntryDate;
			cmbProductCurrency.SelectedItem = (products[0].ProductCost);
			cmbProductCurrency.Text = products[0].CostCurrency.CurrencyName;
			tbDescription.Text = products[0].Description;
			tbProductCurrentPrice.Text = prices[0] .CurrentPrice.ToString();
			cmbProductPriceCurrency.Items.AddRange(currencies.ToArray());
			cmbProductPriceCurrency.SelectedItem = prices[0].Currency;
			cmbProductPriceCurrency.Text = prices[0].Currency.CurrencyName;
			cmbBrand.SelectedItem = products[0].Brand;
			cmbBrand.Text = products[0].Brand.ToString();
			cmbModel.SelectedItem = products[0].Model;
			cmbModel.Text = products[0].Model.ToString();

			#endregion
		}

		private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
		{
			cmbModel.Enabled = true;
			ModelDAL modelDAL = new ModelDAL();
			List<Model> models = new List<Model>();
			Brand selectedBrand = cmbBrand.SelectedItem as Brand;
			models = modelDAL.Select(selectedBrand.BrandId);
			cmbModel.Items.Clear();
			cmbModel.Items.AddRange(models.ToArray());

		}

		private void cbProductWithoutBarcode_CheckedChanged(object sender, EventArgs e)
		{
			cmbUnit.Enabled = lblAmount.Enabled = (cbProductWithoutBarcode.Checked ? true : false);

		}

		
		private void btnUpdateProduct_Click(object sender, EventArgs e)
		{
			
			bool IsWarrantyValid = cmbGuarente.SelectedIndex == 0;
			foreach (var item in products)
			{
				product = item as Product;
			}
			MyResult returnResult = productDal.Update(new Product()
			{
				ProductId = product.ProductId,
				IsWarrantyValid = IsWarrantyValid,
				Description = tbDescription.Text
			});
			MyResult returnPriceResult = priceDAL.Insert(new Price()
			{
				CurrentPrice = double.Parse(tbProductCurrentPrice.Text),
				Currency = new Currency() {CurrencyId = (cmbProductPriceCurrency.SelectedItem as Currency).CurrencyId},
				Product = new Product() {ProductId = product.ProductId }
				

			});
			MessageBox.Show($"{returnResult.ResultMessage} ve {returnPriceResult.ResultMessage} başarıyla güncellendi!" );
		}
	}
}
