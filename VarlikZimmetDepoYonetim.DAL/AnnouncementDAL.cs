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
		/// <summary>
		/// Menüdeki duyurular sekmesinin database baglantisini yapan list metodu.
		/// </summary>
		public List<Announcement> Select()
		{
			List<Announcement> announcements = null;

			SqlDbService sqlDbService = new SqlDbService("select d.DuyuruAdi Duyuru, d.DuyuruIcerigi İçeriği  from Duyuru d");
			sqlDbService.Open();
			SqlDataReader reader = sqlDbService.ExecuteReader();

			if (reader.HasRows)
			{
				announcements = new List<Announcement>();
				while (reader.Read())
				{
					Announcement announcement = new Announcement();
					announcement.AnnouncementName = reader.GetString(0);
					announcement.AnnouncementDescription = reader.GetString(1);
					announcements.Add(announcement);
				}
			}
			sqlDbService.Close();
			return announcements;
		}
	}
}
