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
			CustomerProduct customerProduct = new CustomerProduct();
			SqlDbService sqlDbService = new SqlDbService($"select MusteriId from Musteri where MusteriAboneNo = @AboneNo");
			sqlDbService.Open();

			List<SqlParameter> parameter = new List<SqlParameter>();
			parameter.Add(new SqlParameter("@AboneNo", customerProduct.Customer.CustomerSubscriberNo));
			sqlDbService.AddParameters(parameter.ToArray());
			int customerId = customerProduct.Customer.CustomerId;
			customerId = (int)sqlDbService.ExecuteScalar();


			SqlDbService sqlDbService1 =
				new SqlDbService(
					"INSERT INTO MusteriUrun(MusteriId, UrunId, Aciklama) VALUES(@MusteriId, @UrunId, @Aciklama)");
			List<SqlParameter> parameter1 = new List<SqlParameter>();
			parameter1.Add(new SqlParameter("@MusteriId", customerProduct.Customer.CustomerId));
			parameter1.Add(new SqlParameter("@UrunId", customerProduct.Product.ProductId.ToString()));
			parameter1.Add(new SqlParameter("@Aciklama", "tüketim"));
			sqlDbService.ExecuteNonQuery();

			sqlDbService.Close();
			return new MyResult();
		}
	}
}
