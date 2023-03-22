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
	public class UserAssignmentDAL : ISelectRepoId<UserAssignment>
	{
		public List<UserAssignment> Select(int id)
		{
			List<UserAssignment> userAssignments = null;

			SqlDbService sqlDbService = new SqlDbService($"select kz.KullaniciZimmetId [Kayıt No],u.BarkodNo, ug.UrunGrubuAdi as [Ürün Tipi],fy.GuncelFiyat as Fiyat ,mr.MarkaAdi as Marka ,mdl.ModelAdi as Model  \r\n\t from KullaniciZimmet kz \r\n\t inner join Kullanici k on kz.KullaniciId = k.KullaniciId\r\n\t inner join Zimmet z on kz.ZimmetId = z.ZimmetId\r\n\t inner join UrunDepo ud on z.UrunDepoId= ud.UrunDepoId\r\n\t inner join Urun u on ud.UrunId = u.UrunId\r\n\t inner join UrunGrubu ug on u.UrunGrubuId= ug.UrunGrubuId\r\n\t inner join Fiyat fy on fy.UrunId = u.UrunId\r\n\t inner join Marka mr on mr.MarkaId = u.MarkaId\r\n\t inner join Model mdl on mdl.ModelId = u.ModelId where kz.AktifMi = 'True' and kz.KullaniciId = {id} ");
			sqlDbService.Open();
			SqlDataReader reader = sqlDbService.ExReader();

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
