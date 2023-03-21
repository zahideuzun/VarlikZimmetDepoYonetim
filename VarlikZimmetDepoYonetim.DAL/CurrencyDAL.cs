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
	public class CurrencyDAL : ISelectRepo<Currency>
	{
		public List<Currency> Select()
		{
			List<Currency> currencies = null;
			SqlDbService sqlDbService = new SqlDbService($"select p.ParaBirimiId, p.ParaBirimiAdi from ParaBirimi p where p.AktifMi = 'True'");
			sqlDbService.Open();
			SqlDataReader reader = sqlDbService.ExReader();

			if (reader.HasRows)
			{
				currencies = new List<Currency>();
				while (reader.Read())
				{
					currencies.Add(new Currency()
					{
						CurrencyId = reader.GetInt32(0),
						CurrencyName = reader.GetString(1)
					});
				}
			}
			sqlDbService.Close();
			return currencies;
		}
	}
}
