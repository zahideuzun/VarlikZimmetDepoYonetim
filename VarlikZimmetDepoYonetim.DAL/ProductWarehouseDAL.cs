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
	public class ProductWarehouseDAL : ISelectRepoId<ProductWarehouse>
	{
		/// <summary>
		/// ürün depo tablosunda bulunan ürün depo bilgilerini getiren select sorgusu.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public List<ProductWarehouse> Select(int id)
		{
			List<ProductWarehouse> productWarehouses = null;
			SqlDbService sqlDbService = new SqlDbService($"select ud.UrunDepoId from UrunDepo ud where ud.UrunId = {id}");
			sqlDbService.Open();
			SqlDataReader reader = sqlDbService.ExecuteReader();

			if (reader.HasRows)
			{
				productWarehouses = new List<ProductWarehouse>();
				while (reader.Read())
				{
					productWarehouses.Add(new ProductWarehouse()
					{
						ProductWarehouseId = reader.GetInt32(0)
					});
				}
			}
			sqlDbService.Close();
			return productWarehouses;
		}
	}
}
