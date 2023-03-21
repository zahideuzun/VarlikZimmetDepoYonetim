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

		private void FrmVarlikBilgileri_Load(object sender, EventArgs e)
		{
			FormLoad();
		}

		void FormLoad()
		{
			cmbModel.Enabled = false;
			ProductDAL productDal = new ProductDAL();
			CurrencyDAL currencyDAL = new CurrencyDAL();
			PriceDAL priceDAL = new PriceDAL();
			ProductTypeDAL productTypeDal = new ProductTypeDAL();
			BrandDAL brandDal = new BrandDAL();


			List<Price> prices = priceDAL.Select(1);
			List<Currency> currencies = currencyDAL.Select();
			List<ProductType> productTypes = productTypeDal.Select();
			List<Product> products = productDal.Select(1);
			List<Brand> brands = brandDal.Select();
			



			//cmbBrand.Items.AddRange(brands.ToArray());

			cmbBrand.DataSource = brands;
			cmbBrand.DisplayMember = "BrandName";
			cmbBrand.ValueMember = "BrandId";


		}

		private void cmbBrand_SelectedIndexChanged(object sender, EventArgs e)
		{
			cmbModel.Enabled = true;
			ModelDAL modelDAL = new ModelDAL();
			List<Model> models = new List<Model>();
			int selectedBrandId = (int)cmbBrand.SelectedValue;
			models = modelDAL.Select(selectedBrandId);
			cmbModel.Items.Clear();
			cmbModel.Items.AddRange(models.ToArray());

		}
	}
}
