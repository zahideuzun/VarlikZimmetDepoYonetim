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
	public class PriceDAL : ISelectRepoId<Price>
	{
		public List<Price> Select(int id)
		{
			List<Price> prices = null;
			SqlDbService sqlDbService = new SqlDbService($"select f.FiyatId, f.GuncelFiyat, pb.ParaBirimiId, pb.ParaBirimiAdi from Fiyat f \r\njoin ParaBirimi pb on f.ParaBirimiId=pb.ParaBirimiId \r\nwhere f.AktifMi = 'True' and f.UrunId = {id}");
			sqlDbService.Open();
			SqlDataReader reader = sqlDbService.ExReader();

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
	}
}
