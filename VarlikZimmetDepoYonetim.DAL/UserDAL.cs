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
	public class UserDAL : ISelectRepo<User>
	{
		public List<User> Select()
		{
			List<User> users = null;
			SqlDbService sqlDbService = new SqlDbService("select k.KullaniciId, k.KullaniciIsim, k.KullaniciSoyisim from Kullanici k where k.AktifMi = 'True'");
			sqlDbService.Open();
			SqlDataReader reader = sqlDbService.ExecuteReader();

			if (reader.HasRows)
			{
				users = new List<User>();
				while (reader.Read())
				{
					users.Add(new User()
					{
						UserId = reader.GetInt32(0),
						FirstName = reader.GetString(1),
						LastName = reader.GetString(2)
					});
				}
			}
			sqlDbService.Close();
			return users;
		}
	}
}
