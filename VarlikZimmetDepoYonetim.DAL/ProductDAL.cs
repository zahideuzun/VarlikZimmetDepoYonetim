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

			SqlDbService sqlDbService = new SqlDbService("select u.UrunId as [Kayıt Numarası], u.BarkodNo, ug.UrunGrubuAdi as [Ürün Tipi], f.GuncelFiyat as [Ürünün Güncel Fiyatı], mr.MarkaAdi as Marka, mo.ModelAdi as Model from Urun u \r\n\t join UrunGrubu ug on u.UrunGrubuId = ug.UrunGrubuId\r\n\t join Marka mr on mr.MarkaId = u.MarkaId\r\n\t join Model mo on mo.ModelId = u.ModelId\r\n\t join Fiyat f on f.UrunId = u.UrunId");
			sqlDbService.Open();
			SqlDataReader reader = sqlDbService.ExReader();

			if (reader.HasRows)
			{
				products = new List<Product>();
				while (reader.Read())
				{
					Price pr = new Price();
					Product p = new Product();
					p.ProductId = reader.GetInt32(0);
					Guid guidValue = reader.GetGuid(reader.GetOrdinal("BarkodNo"));
					p.ProductBarcode = guidValue;
					p.ProductType = new ProductType() { ProductTypeName = (reader.GetString(2))};
					p.Price = Convert.ToDouble(reader.GetDecimal(3)) ;
					p.Brand = new Brand() { BrandName = (reader.GetString(4))};
					p.Model = new Model() { ModelName = (reader.GetString(5)) };
					products.Add(p);
				}
			}
			sqlDbService.Close();
			return products;
			
		}

		public List<Product> Select(int id)
		{
			List<Product> updateProducts = null;
			SqlDbService sqlDbService = new SqlDbService($"select u.BarkodNo, ug.UrunGrubuAdi [Ürün Grubu], m.MarkaAdi Marka, md.ModelAdi Model, \r\nIIF (u.GarantiliMi = 1 , 'Var','Yok') [Garanti Durumu]\r\n, u.Aciklama Açıklama , u.UrunGirisTarihi [Ürünün Giriş Tarihi] ,u.UrunEmeklilikTarihi [Ürün Emeklilik Tarihi] ,\r\nu.UrunMaliyeti [Ürün Maliyeti] , p.ParaBirimiAdi [Ürünün Para Birimi], f.GuncelFiyat [Güncel Fiyat] from Urun u\r\njoin UrunGrubu ug on ug.UrunGrubuId = u.UrunGrubuId\r\njoin Marka m on m.MarkaId = u.MarkaId\r\njoin Model md on md.ModelId = u.ModelId\r\njoin Fiyat f on f.UrunId = u.UrunId\r\njoin ParaBirimi p on p.ParaBirimiId = f.ParaBirimiId where u.UrunId = {id}");
			sqlDbService.Open();
			SqlDataReader reader = sqlDbService.ExReader();

			if (reader.HasRows)
			{
				updateProducts = new List<Product>();
				while (reader.Read())
				{
					Price pr = new Price();
					Product p = new Product();
					Guid guidValue = reader.GetGuid(reader.GetOrdinal("BarkodNo"));
					p.ProductBarcode = guidValue;
					p.ProductType = new ProductType() { ProductTypeName = (reader.GetString(2)) };
					p.Price = Convert.ToDouble(reader.GetDecimal(3));
					p.Brand = new Brand() { BrandName = (reader.GetString(4)) };
					p.Model = new Model() { ModelName = (reader.GetString(5)) };
					updateProducts.Add(p);
				}
			}
			sqlDbService.Close();
			return updateProducts;

		}
	}
}
