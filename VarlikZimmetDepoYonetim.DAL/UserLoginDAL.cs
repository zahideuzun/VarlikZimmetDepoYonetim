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
		/// <summary>
		/// Giriş yapan kullanıcının bilgilerini ve rolünü getiren UserRole tipindeki UserLogin metodu. metot kullanicinin mail adresini ve sifresini parametre olarak alir.
		/// </summary>
		/// <param name="email"></param>
		/// <param name="password"></param>
		/// <returns></returns>
		public UserRole UserLogin(string email, string password)
		{
			UserRole userLogin = null;
			SqlDbService sqlDbService = new SqlDbService($"select k.KullaniciId ,k.KullaniciIsim ,k.KullaniciSoyisim, s.SirketId, s.SirketAdi, e.EkipId, e.EkipAdi , rl.RolIsmi  \r\nfrom Kullanici k \r\njoin KullaniciRol kr on kr.KullaniciId = k.KullaniciId\r\njoin Rol rl on rl.RolId = kr.RolId\r\njoin Sirket s on s.SirketId = k.SirketId\r\njoin Ekip e on e.EkipId = k.EkipId where k.KullaniciMail = '{email}' and k.KullaniciSifre = '{password}'");
			sqlDbService.Open();
			SqlDataReader reader = sqlDbService.ExecuteReader();
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
							Team = new Team() {TeamId = reader.GetInt32(5), TeamName = reader.GetString(6)},
							Company = new Company() {CompanyId = reader.GetInt32(3), CompanyName = reader.GetString(4)}
						},
						Role = new Role()
						{
							RoleName = reader.GetString(7)
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
