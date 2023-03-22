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
	
	public class BrandDAL : ISelectRepo<Brand>
	{
		/// <summary>
		/// Ürün markalarının database bağlantısını yapan list metodu.
		/// </summary>
		public List<Brand> Select()
		{
			List<Brand> brands = null;

			SqlDbService sqlDbService = new SqlDbService("select m.MarkaId ,m.MarkaAdi from Marka m where m.AktifMi = 'True'");
			sqlDbService.Open();
			SqlDataReader reader = sqlDbService.ExecuteReader();

			if (reader.HasRows)
			{
				brands = new List<Brand>();
				while (reader.Read())
				{
					Brand brand = new Brand();
					brand.BrandId = reader.GetInt32(0);
					brand.BrandName = reader.GetString(1);
					brands.Add(brand);
				}
			}
			sqlDbService.Close();
			return brands;
		}
	}
}
