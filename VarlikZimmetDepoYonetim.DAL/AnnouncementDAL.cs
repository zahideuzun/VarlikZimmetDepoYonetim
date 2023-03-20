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
	public class AnnouncementDAL : ISelectRepo<Announcement>
	{
		public List<Announcement> Select()
		{
			List<Announcement> announcements = null;

			SqlDbService sqlDbService = new SqlDbService("select d.DuyuruAdi Duyuru, d.DuyuruIcerigi İçeriği  from Duyuru d");
			sqlDbService.Open();
			SqlDataReader reader = sqlDbService.ExReader();

			if (reader.HasRows)
			{
				announcements = new List<Announcement>();
				while (reader.Read())
				{
					Announcement a = new Announcement();
					a.AnnouncementName = reader.GetString(0);
					a.AnnouncementDescription = reader.GetString(1);
					announcements.Add(a);
				}
			}
			sqlDbService.Close();
			return announcements;
		}
	}
}
