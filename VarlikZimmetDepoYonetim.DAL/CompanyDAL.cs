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
	public class CompanyDAL : ISelectRepo<Company>
	{
		/// <summary>
		/// Şirket tablosunu database baglantisi yaparak select sorgusuyla listeler.
		/// </summary>
		/// <returns></returns>
		public List<Company> Select()
		{
			List<Company> companies = null;

			SqlDbService sqlDbService = new SqlDbService("select s.SirketId ,s.SirketAdi from Sirket s where s.AktifMi = 'True'");
			sqlDbService.Open();
			SqlDataReader reader = sqlDbService.ExecuteReader();

			if (reader.HasRows)
			{
				companies = new List<Company>();
				while (reader.Read())
				{
					Company company = new Company();
					company.CompanyId = reader.GetInt32(0);
					company.CompanyName = reader.GetString(1);
					companies.Add(company);
				}
			}
			sqlDbService.Close();
			return companies;
		}
	}
}
