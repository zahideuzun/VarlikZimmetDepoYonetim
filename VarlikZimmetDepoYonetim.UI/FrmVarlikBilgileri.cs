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
		List<Brand> brands;
		private ProductDAL productDal;
		private CurrencyDAL currencyDAL;
		private PriceDAL priceDAL;
		private ProductTypeDAL productTypeDal;
		private BrandDAL brandDal;
		Product product;
		private ProductStatusDAL statusDal;

		#endregion

		public FrmVarlikBilgileri()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Bir önceki formdan (varliklar) gönderilen kullanici zimmet bilgisini karsilayan parametreli const.
		/// </summary>
		/// <param name="selectedUserAssignment"></param>
		public FrmVarlikBilgileri(UserAssignment selectedUserAssignment) : this()
		{
			this.selectedUserAssignment = selectedUserAssignment;
		}

		/// <summary>
		/// Bir önceki formdan (Varliklar) secilen ürünün bu formda karsilandigi parametreli constructor.
		/// </summary>
		/// <param name="selectedProduct"></param>
		public FrmVarlikBilgileri(Product selectedProduct) : this() 
		{
			this.selectedProduct = selectedProduct;
		}

		/// <summary>
		/// Secilen varlikla ilgili aksiyonlarin kontrollerini yapan event. İstenen yalnizca tüketme ve zimmet atama ekranlari oldugu icin yalnizca onlarin kontrolü saglanmistir. Tüm aksiyonlar listelenmekte fakat onlara erişim sağlanmamaktadır.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cmbActions_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbActions.SelectedItem == "Zimmet Ata")
			{
				zimmetAtama = new FrmZimmetAtama(products[0].ProductId);
				zimmetAtama.Show();
			}

			else if (cmbActions.SelectedItem == "Tüket")
			{
				tuket = new FrmTuket(products[0].ProductId);
				tuket.Show();
			}
			else MessageBox.Show("Bu sayfaya giriş yetkiniz yok!");
			cmbActions.SelectedText = null;
		}

		private void FrmVarlikBilgileri_Load(object sender, EventArgs e)
		{
			FormLoad();
		}

		/// <summary>
		/// Form yüklendiginde yüklenmesi gereken tüm kontroller bu metottda yapildi.
		/// </summary>
		void FormLoad()
		{
			#region Instances
			productDal = new ProductDAL();
			currencyDAL = new CurrencyDAL();
			priceDAL = new PriceDAL();
			productTypeDal = new ProductTypeDAL();
			brandDal = new BrandDAL();
			#endregion

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

			#region SelectedProductControl

			//secilen varligin kullanici tarafindan ve poweruser tarafindan secilip secilmedigini kontrol eder. eger kullanici tarafindan secilmisse kullanici yalnizca zimmetlenmis varliklarini görebildigi icin kullanici zimmetteki varlik id olarak geliyor. poweruser ise tüm varliklari görebildigi icin varlik id olarak geliyor.

			if (selectedProduct == null)
			{
				prices = priceDAL.Select(selectedUserAssignment.InventoryAssignment.Product.ProductId);
				products = productDal.Select(selectedUserAssignment.InventoryAssignment.Product.ProductId);
				lblProductName.Text = selectedUserAssignment.InventoryAssignment.Product.ProductId.ToString();
			}
			else
			{
				prices = priceDAL.Select(selectedProduct.ProductId);
				products = productDal.Select(selectedProduct.ProductId);
				lblProductName.Text = selectedProduct.ProductId.ToString();
			}


			#endregion

			#region FormLoadAddItems
			//Formdaki ilgili bölümlerin doldurulduğu kodlar.

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
			tbProductCurrentPrice.Text = prices[0].CurrentPrice.ToString();
			cmbProductPriceCurrency.Items.AddRange(currencies.ToArray());
			cmbProductPriceCurrency.SelectedItem = prices[0].Currency;
			cmbProductPriceCurrency.Text = prices[0].Currency.CurrencyName;
			cmbBrand.SelectedItem = products[0].Brand;
			cmbBrand.Text = products[0].Brand.ToString();
			cmbModel.SelectedItem = products[0].Model;
			cmbModel.Text = products[0].Model.ToString();


			#endregion

			#endregion
		}

		/// <summary>
		/// Ürün güncelleme ekraninda, model bilgileri marka secildikten sonra markaya göre modelleri getirmektedir.Analiz raporunda bu ekran hakkında guncellemeler eksik verilmis bu sebeple ürünün marka ve modeli developer tarafindan güncellemeye kapatilmistir. Su an kullanilan bir event degil. Fakat analiz detaylandirildiginda kullanim ihtiyaci dogabilir.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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

		/// <summary>
		/// İsaretlendiginde barkodsuz ürünler için alınması gereken bilgilerin alanlarini enabled=true yapan event.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cbProductWithoutBarcode_CheckedChanged(object sender, EventArgs e)
		{
			cmbUnit.Enabled = lblAmount.Enabled = (cbProductWithoutBarcode.Checked ? true : false);

		}

		private void btnUpdateProduct_Click(object sender, EventArgs e)
		{
			ProductUpdate();
		}

		/// <summary>
		/// Varlik Bilgileri formundaki ürünün güncellenebilir bilgilerini güncelleyen metot. Güncelle clickte cagirilmistir.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void ProductUpdate()
		{
			bool IsWarrantyValid = cmbGuarente.SelectedIndex == 0;

			MyResult returnResult = productDal.Update(new Product()
			{
				ProductId = products[0].ProductId,
				IsWarrantyValid = IsWarrantyValid,
				Description = tbDescription.Text
			});

			MyResult returnPriceResult = priceDAL.Insert(new Price()
			{
				CurrentPrice = double.Parse(tbProductCurrentPrice.Text),
				Currency = new Currency() { CurrencyId = (cmbProductPriceCurrency.SelectedItem as Currency).CurrencyId },
				Product = new Product() { ProductId = products[0].ProductId }
			});

			MessageBox.Show($"{returnResult.ResultMessage} ve {returnPriceResult.ResultMessage} başarıyla güncellendi!");
		}
	}
}
