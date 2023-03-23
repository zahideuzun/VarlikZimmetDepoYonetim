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
	public class UserAssignmentDAL : ISelectRepoId<UserAssignment>, IInsertRepo<UserAssignment>
	{
		/// <summary>
		/// Kullanici zimmet tablosuna yeni bir zimmet atamasi yapan insert sorgusu.
		/// </summary>
		/// <param name="insertedData"></param>
		/// <returns></returns>
		public MyResult Insert(UserAssignment insertedData)
		{
			SqlDbService sqlDbService = new SqlDbService("insert into KullaniciZimmet (KullaniciZimmetId, KullaniciId, ZimmetId, AktifMi)\r\nvalues (@KullaniciZimmetId, @KullaniciId, @ZimmetId, @AktifMi)");
			sqlDbService.Open();
			List<SqlParameter> parameters = new List<SqlParameter>();
			parameters.Add(new SqlParameter("@UrunId", insertedData.UserAssignmentId));
			parameters.Add(new SqlParameter("@GuncelFiyat", insertedData.User.UserId));
			parameters.Add(new SqlParameter("@ParaBirimiId", insertedData.InventoryAssignment.InventoryAssignmentId));
			parameters.Add(new SqlParameter("@AktifMi", true));

			sqlDbService.AddParameters(parameters.ToArray());
			int rowAffected = sqlDbService.ExecuteNonQuery();

			sqlDbService.Close();
			return new MyResult()
			{
				Result = rowAffected,
				ResultMessage = rowAffected > 0 ? "kullanıcı zimmet" : "hata",
				ResultType = rowAffected > 0
			};
		}

		/// <summary>
		/// Giris yapan kullanicinin kendisine zimmetlenmis ürünlerini kullanıcı zimmet tablosundan kullanıcı zimmet idsine göre getiren select metodu
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public List<UserAssignment> Select(int id)
		{
			List<UserAssignment> userAssignments = null;

			SqlDbService sqlDbService = new SqlDbService($"select kz.KullaniciZimmetId [Kayıt No],u.BarkodNo, ug.UrunGrubuAdi as [Ürün Tipi],fy.GuncelFiyat as Fiyat ,mr.MarkaAdi as Marka ,mdl.ModelAdi as Model  \r\n\t from KullaniciZimmet kz \r\n\t inner join Kullanici k on kz.KullaniciId = k.KullaniciId\r\n\t inner join Zimmet z on kz.ZimmetId = z.ZimmetId\r\n\t inner join UrunDepo ud on z.UrunDepoId= ud.UrunDepoId\r\n\t inner join Urun u on ud.UrunId = u.UrunId\r\n\t inner join UrunGrubu ug on u.UrunGrubuId= ug.UrunGrubuId\r\n\t inner join Fiyat fy on fy.UrunId = u.UrunId\r\n\t inner join Marka mr on mr.MarkaId = u.MarkaId\r\n\t inner join Model mdl on mdl.ModelId = u.ModelId where kz.AktifMi = 'True' and fy.AktifMi = 'True' and kz.KullaniciId = {id} ");
			sqlDbService.Open();
			SqlDataReader reader = sqlDbService.ExecuteReader();

			if (reader.HasRows)
			{
				userAssignments = new List<UserAssignment>();
				while (reader.Read())
				{

					UserAssignment userAssignment = new UserAssignment();
					userAssignment.InventoryAssignment = new InventoryAssignment()
					{
						Product = new Product()
						{
							ProductId = reader.GetInt32(0),
							ProductBarcode = reader.GetGuid(reader.GetOrdinal("BarkodNo")),
							ProductType = new ProductType() { ProductTypeName = reader.GetString(2) },
							Price = Convert.ToDouble(reader.GetDecimal(3)),
							Brand = new Brand() { BrandName = (reader.GetString(4)) },
							Model = new Model() { ModelName = (reader.GetString(5)) }

						}
					};
					userAssignments.Add(userAssignment);
				}
			}
			sqlDbService.Close();
			return userAssignments;
		}
	}
}
