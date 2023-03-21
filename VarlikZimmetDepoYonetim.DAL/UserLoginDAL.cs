using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarlikZimmetDepoYonetim.DTO;
using VarlikZimmetDepoYonetim.Provider;

namespace VarlikZimmetDepoYonetim.DAL
{
	public class UserLoginDAL
	{
		public UserRole UserLogin(string email, string password)
		{
			UserRole userLogin = null;
			SqlDbService sqlDbService = new SqlDbService($"select k.KullaniciId ,k.KullaniciIsim ,k.KullaniciSoyisim, rl.RolIsmi  from Kullanici k\r\njoin KullaniciRol kr on kr.KullaniciId = k.KullaniciId\r\njoin Rol rl on rl.RolId = kr.RolId where k.KullaniciMail = '{email}' and k.KullaniciSifre = '{password}' and k.AktifMi='True'");
			sqlDbService.Open();
			SqlDataReader reader = sqlDbService.ExReader();
			if (reader.HasRows)
			{
				while (reader.Read())
				{ 
					userLogin = new UserRole()
					{
						User = new User()
						{
							UserId = reader.GetInt32(0),
							FirstName = reader.GetString(1),
							LastName = reader.GetString(2),
						},
						Role = new Role()
						{
							RoleName = reader.GetString(3)
						},
						
					};

				}
				sqlDbService.Close();
				return userLogin;
			}
			else
			{
				return null;
			}

		}
	}
}
