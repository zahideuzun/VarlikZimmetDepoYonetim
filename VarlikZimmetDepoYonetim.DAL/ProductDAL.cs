using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarlikZimmetDepoYonetim.DAL.IRepo;
using VarlikZimmetDepoYonetim.DTO;
using VarlikZimmetDepoYonetim.Provider;

namespace VarlikZimmetDepoYonetim.DAL
{
	public class ProductDAL : ISelectRepo<Product>
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
			sqlDbService.BaglantiKapat();
			return products;
			
		}
	}
}
