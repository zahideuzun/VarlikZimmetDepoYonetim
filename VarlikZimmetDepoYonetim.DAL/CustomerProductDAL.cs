using System;
using System.Collections.Generic;
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
	public class CustomerProductDAL : IInsertRepo<CustomerProduct>
	{
		public MyResult Insert(CustomerProduct insertedData)
		{
			SqlDbService sqlDbService = new SqlDbService("insert into MusteriUrun (UrunId, Aciklama,MusteriId,AktifMi) values (@UrunId, @Aciklama, @MusteriId, @AktifMi)");
			sqlDbService.Open();
			List<SqlParameter> parameters = new List<SqlParameter>();
			parameters.Add(new SqlParameter("@MusteriId", insertedData.Product.ProductId));
			parameters.Add(new SqlParameter("@Aciklama", insertedData.Description));
			parameters.Add(new SqlParameter("@UrunId", insertedData.Customer.CustomerId));
			parameters.Add(new SqlParameter("@AktifMi", true));
			sqlDbService.AddParameters(parameters.ToArray());
			int rowAffected = sqlDbService.ExecuteNonQuery();

			sqlDbService.Close();
			return new MyResult()
			{
				Result = rowAffected,
				ResultMessage = rowAffected > 0 ? $"varlık {insertedData.Customer.CustomerName} {insertedData.Customer.CustomerSurname} adlı müşteriye atanmıştır. " : "Atama gerçekleşmedi. Lütfen abone numarasını kontrol ediniz!",
				ResultType = rowAffected > 0
			};

		}
	}
}
