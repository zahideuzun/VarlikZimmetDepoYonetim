using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using VarlikZimmetDepoYonetim.DAL.IRepo;
using VarlikZimmetDepoYonetim.DTO;
using VarlikZimmetDepoYonetim.DTO.Result;
using VarlikZimmetDepoYonetim.Provider;

namespace VarlikZimmetDepoYonetim.DAL
{
	public class ProductDAL : ISelectRepo<Product> , ISelectRepoId<Product>, IUpdateRepo<Product>
	{
		public List<Product> Select()
		{
			List<Product> products = null;

			SqlDbService sqlDbService = new SqlDbService("select u.UrunId as [Kayıt Numarası], u.BarkodNo, ut.UrunTipiAdi as [Ürün Tipi], f.GuncelFiyat as [Ürünün Güncel Fiyatı], mr.MarkaAdi as Marka, \r\nmo.ModelAdi as Model from Urun u \r\njoin UrunTipi ut on u.UrunTipiId = ut.UrunTipiId\r\njoin Marka mr on mr.MarkaId = u.MarkaId\r\njoin Model mo on mo.ModelId = u.ModelId\r\njoin Fiyat f on f.UrunId = u.UrunId where u.AktifMi = 'True'");
			sqlDbService.Open();
			SqlDataReader reader = sqlDbService.ExReader();

			if (reader.HasRows)
			{
				products = new List<Product>();
				while (reader.Read())
				{
					Product p = new Product
					{
						ProductId = reader.GetInt32(0),
						ProductBarcode = reader.GetGuid(reader.GetOrdinal("BarkodNo")),
						ProductType = new ProductType { ProductTypeName = reader.GetString(2) },
						Price = Convert.ToDouble(reader.GetDecimal(3)),
						Brand = new Brand { BrandName = reader.GetString(4) },
						Model = new Model { ModelName = reader.GetString(5) }
					};
					products.Add(p);
				}

			}
			sqlDbService.Close();
			return products;
			
		}

		public List<Product> Select(int id)
		{
			List<Product> productsInfo = null;
			SqlDbService sqlDbService = new SqlDbService($"select u.BarkodNo, ut.UrunTipiId [ürün tipi id] , ut.UrunTipiAdi [Ürün Tipi], m.MarkaId [marka id] ,\r\nm.MarkaAdi Marka,md.ModelId [model id], md.ModelAdi Model, \r\nIIF (u.GarantiliMi = 1 , 'Var','Yok') [Garanti Durumu]\r\n, u.Aciklama Açıklama , u.UrunGirisTarihi [Ürünün Giriş Tarihi] ,\r\nu.UrunMaliyeti [Ürün Maliyeti] ,p.ParaBirimiId [p birimi id] ,p.ParaBirimiAdi [Ürünün Para Birimi],\r\n f.GuncelFiyat [Güncel Fiyat], u.UrunId from Urun u\r\njoin UrunTipi ut on ut.UrunTipiId = u.UrunTipiId\r\njoin Marka m on m.MarkaId = u.MarkaId\r\njoin Model md on md.ModelId = u.ModelId\r\njoin Fiyat f on f.UrunId = u.UrunId\r\njoin ParaBirimi p on p.ParaBirimiId = f.ParaBirimiId where u.AktifMi = 'True' and u.UrunId = {id}");
			sqlDbService.Open();
			SqlDataReader reader = sqlDbService.ExReader();

			if (reader.HasRows)
			{
				productsInfo = new List<Product>();
				while (reader.Read())
				{
					Product product = new Product()
					{
						ProductId = reader.GetInt32(14),
						ProductBarcode = reader.GetGuid(reader.GetOrdinal("BarkodNo")),
						ProductType = new ProductType
						{
							ProductTypeId = reader.GetInt32(1),
							ProductTypeName = reader.GetString(2)
						},
						Brand = new Brand
						{
							BrandId = reader.GetInt32(3),
							BrandName = reader.GetString(4)
						},
						Model = new Model
						{
							ModelId = reader.GetInt32(5),
							ModelName = reader.GetString(6)
						},
						IsWarrantyValid = (reader.GetString(7) == "Var"),
						Description = reader.GetString(8),
						EntryDate = reader.GetDateTime(9),
						ProductCost = Convert.ToDouble(reader.GetDecimal(10)),
						CostCurrency = new Currency
						{
							CurrencyId = reader.GetInt32(11),
							CurrencyName = reader.GetString(12)
						},

						Price = Convert.ToDouble(reader.GetDecimal(13))
					};
					productsInfo.Add(product);
				}

			}
			sqlDbService.Close();
			return productsInfo;

		}

		public MyResult Update(Product updatedData)
		{
			SqlDbService sqlDbService = new SqlDbService("update Urun set \r\n GarantiliMi = @GarantiliMi, \r\n    Aciklama = @Aciklama \r\n where UrunId = @UrunId");
			sqlDbService.Open();
			List<SqlParameter> parameters = new List<SqlParameter>();
			parameters.Add(new SqlParameter("@GarantiliMi", updatedData.IsWarrantyValid));
			parameters.Add(new SqlParameter("@Aciklama", updatedData.Description));
			parameters.Add(new SqlParameter("@UrunId", updatedData.ProductId));
			sqlDbService.AddParameters(parameters.ToArray());
			int rowAffected = sqlDbService.ExecuteNonQuery();

			sqlDbService.Close();
			return new MyResult()
			{
				Result = rowAffected,
				ResultMessage = rowAffected > 0 ? "garanti durumu ve açıklama" : "hata var",
				ResultType = rowAffected > 0
			};
		}
	}
}
