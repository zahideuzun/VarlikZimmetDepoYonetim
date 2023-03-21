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
	public class ProductDAL : ISelectRepo<Product> , ISelectRepoId<Product>
	{
		public List<Product> Select()
		{
			List<Product> products = null;

			SqlDbService sqlDbService = new SqlDbService("select u.UrunId as [Kayıt Numarası], u.BarkodNo, ut.UrunTipiAdi as [Ürün Tipi], f.GuncelFiyat as [Ürünün Güncel Fiyatı], mr.MarkaAdi as Marka, \r\nmo.ModelAdi as Model from Urun u \r\njoin UrunTipi ut on u.UrunTipiId = ut.UrunTipiId\r\njoin Marka mr on mr.MarkaId = u.MarkaId\r\njoin Model mo on mo.ModelId = u.ModelId\r\njoin Fiyat f on f.UrunId = u.UrunId");
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
			List<Product> updateProducts = null;
			SqlDbService sqlDbService = new SqlDbService($"select u.BarkodNo, ug.UrunGrubuId [ürün grubu id] , ug.UrunGrubuAdi [Ürün Grubu], m.MarkaId [marka id] ,\r\nm.MarkaAdi Marka,md.ModelId [model id], md.ModelAdi Model, \r\nIIF (u.GarantiliMi = 1 , 'Var','Yok') [Garanti Durumu]\r\n, u.Aciklama Açıklama , u.UrunGirisTarihi [Ürünün Giriş Tarihi] ,u.UrunEmeklilikTarihi [Ürün Emeklilik Tarihi] ,\r\nu.UrunMaliyeti [Ürün Maliyeti] ,p.ParaBirimiId [p birimi id] ,p.ParaBirimiAdi [Ürünün Para Birimi],\r\n f.FiyatId [fiyat id],f.GuncelFiyat [Güncel Fiyat] from Urun u\r\njoin UrunGrubu ug on ug.UrunGrubuId = u.UrunGrubuId\r\njoin Marka m on m.MarkaId = u.MarkaId\r\njoin Model md on md.ModelId = u.ModelId\r\njoin Fiyat f on f.UrunId = u.UrunId\r\njoin ParaBirimi p on p.ParaBirimiId = f.ParaBirimiId where u.UrunId = {id}");
			sqlDbService.Open();
			SqlDataReader reader = sqlDbService.ExReader();

			if (reader.HasRows)
			{
				updateProducts = new List<Product>();
				while (reader.Read())
				{
					Product product = new Product
					{
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
						IsWarrantyValid = reader.GetBoolean(7),
						Description = reader.GetString(8),
						EntryDate = reader.GetDateTime(9),
						RetirementDate = reader.GetDateTime(10),
						ProductCost = reader.GetDouble(11),
						CostCurrency = new Currency
						{
							CurrencyId = reader.GetInt32(12),
							CurrencyName = reader.GetString(13)
						},
						Price = Convert.ToDouble(reader.GetDecimal(14))
					};
					updateProducts.Add(product);
				}

			}
			sqlDbService.Close();
			return updateProducts;

		}
	}
}
