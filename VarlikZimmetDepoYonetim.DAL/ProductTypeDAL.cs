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
	public class ProductTypeDAL : ISelectRepo<ProductType>
	{
		/// <summary>
		/// Ürün tiplerini select sorgusuyla databaseden listeleyen select metodu.
		/// </summary>
		/// <returns></returns>
		public List<ProductType> Select()
		{
			List<ProductType> productTypes = null;
			SqlDbService sqlDbService = new SqlDbService("select ut.UrunTipiId, ut.UrunTipiAdi from UrunTipi ut where ut.AktifMi = 'True'");
			sqlDbService.Open();
			SqlDataReader reader = sqlDbService.ExecuteReader();

			if (reader.HasRows)
			{
				productTypes = new List<ProductType>();
				while (reader.Read())
				{
					productTypes.Add(new ProductType()
					{
						ProductTypeId = reader.GetInt32(0),
						ProductTypeName = reader.GetString(1)
					});
				}
			}
			sqlDbService.Close();
			return productTypes;
			
		}
	}
}
