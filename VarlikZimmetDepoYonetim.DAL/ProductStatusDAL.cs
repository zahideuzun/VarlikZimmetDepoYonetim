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
	public class ProductStatusDAL : ISelectRepoId<ProductStatus>
	{
		public List<ProductStatus> Select(int id)
		{
			List<ProductStatus> status = null;
			SqlDbService sqlDbService = new SqlDbService($"select u.UrunId ,d.DurumId,d.DurumAdi from UrunDurum ud \r\njoin Urun u on u.UrunId = ud.UrunId\r\njoin Durum d on d.DurumId = ud.DurumId \r\nwhere u.UrunId = {id}");
			sqlDbService.Open();
			SqlDataReader reader = sqlDbService.ExecuteReader();

			if (reader.HasRows)
			{
				status = new List<ProductStatus>();
				while (reader.Read())
				{
					status.Add(new ProductStatus()
					{
						Product = new Product()
						{
							ProductId = reader.GetInt32(0)
						},
						Status = new Status()
						{
							StatusId = reader.GetInt32(1),
							StatusName = reader.GetString(2)
						}
						
					});
				}
			}
			sqlDbService.Close();
			return status;
		}
	}
}
