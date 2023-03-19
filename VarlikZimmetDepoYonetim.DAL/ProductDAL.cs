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
			List<Product> products = new List<Product>();

			SqlProviderService sqlProviderService = new SqlProviderService("Select * From Urun");

				SqlDataReader reader = sqlProviderService.ExecuteReader();
				
					while (reader.Read())
					{
						Product p = new Product();
						p.ProductId = Convert.ToInt32(reader["UrunId"]);
						Guid guidValue = reader.GetGuid(reader.GetOrdinal("BarkodNo"));
						p.ProductBarcode = guidValue;
						p.Description = Convert.ToString(reader["Açıklama"]);
						products.Add(p);
					}
					
			return products;
		}
	}
}
