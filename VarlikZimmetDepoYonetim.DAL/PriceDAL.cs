using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarlikZimmetDepoYonetim.DAL.IRepo;
using VarlikZimmetDepoYonetim.DTO;
using VarlikZimmetDepoYonetim.DTO.Result;
using VarlikZimmetDepoYonetim.Provider;

namespace VarlikZimmetDepoYonetim.DAL
{
	public class PriceDAL : ISelectRepoId<Price> , IInsertRepo<Price>
	{
		/// <summary>
		/// Ürünlerin fiyatlarını fiyat tablosundaki ürünid değerine göre select sorgusuyla listeleyen metot.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public List<Price> Select(int id)
		{
			List<Price> prices = null;
			SqlDbService sqlDbService = new SqlDbService($"select f.FiyatId, f.GuncelFiyat, pb.ParaBirimiId, pb.ParaBirimiAdi from Fiyat f \r\njoin ParaBirimi pb on f.ParaBirimiId=pb.ParaBirimiId \r\nwhere f.AktifMi = 'True' and f.UrunId = {id}");
			sqlDbService.Open();
			SqlDataReader reader = sqlDbService.ExecuteReader();

			if (reader.HasRows)
			{
				prices = new List<Price>();
				while (reader.Read())
				{
					prices.Add(new Price()
					{
						PriceId = reader.GetInt32(0),
						CurrentPrice = Convert.ToDouble(reader.GetDecimal(1)),
						Currency = new Currency()
						{
							CurrencyId = reader.GetInt32(2),
							CurrencyName = reader.GetString(3)
						}
					});
				}
			}
			sqlDbService.Close();
			return prices;
		}

		/// <summary>
		/// Ürün bilgilerini güncelleme ekraninda güncellenen fiyat bilgisini fiyat tablosuna ekleyen insert metodu. Ürün fiyat bilgilerinin tüm geçmişi görüntülenebilsin diye ürünlerin fiyat bilgileri ayri bir fiyat tablosunda tutuldu.
		/// </summary>
		/// <param name="insertedData"></param>
		/// <returns></returns>
		public MyResult Insert(Price insertedData)
		{
			SqlDbService sqlDbService = new SqlDbService("insert into Fiyat (UrunId, GuncelFiyat,GuncellemeTarihi,ParaBirimiId, AktifMi) values (@UrunId, @GuncelFiyat, @GuncellemeTarihi, @ParaBirimiId, @AktifMi)");
			sqlDbService.Open();
			List<SqlParameter> parameters = new List<SqlParameter>();
			parameters.Add(new SqlParameter("@UrunId", insertedData.Product.ProductId));
			parameters.Add(new SqlParameter("@GuncelFiyat", insertedData.CurrentPrice));
			parameters.Add(new SqlParameter("@GuncellemeTarihi", DateTime.Now));
			parameters.Add(new SqlParameter("@ParaBirimiId", insertedData.Currency.CurrencyId));
			parameters.Add(new SqlParameter("@AktifMi", true));

			sqlDbService.AddParameters(parameters.ToArray());
			int rowAffected = sqlDbService.ExecuteNonQuery();

			sqlDbService.Close();
			return new MyResult()
			{
				Result = rowAffected,
				ResultMessage = rowAffected > 0 ? "Fiyat Bilgisi" : "hata var",
				ResultType = rowAffected > 0
			};
		}
	}
}
