using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using VarlikZimmetDepoYonetim.DAL;
using VarlikZimmetDepoYonetim.DTO;

namespace VarlikZimmetDepoYonetim.UI
{
	public partial class FrmDuyurular : Form
	{
		List<Announcement> announcements = new List<Announcement>();
		public FrmDuyurular()
		{
			InitializeComponent();
		}

		/// <summary>
		/// formun loadinda yuklenecek duyuru bilgilerini getiren metot.
		/// </summary>
		void FormLoad()
		{
			AnnouncementDAL announcementDal = new AnnouncementDAL();
			announcements.AddRange(announcementDal.Select().ToArray());
			foreach (Announcement item in announcements)
			{
				treeAnnouncement.Nodes.Add(item.AnnouncementName).Nodes.Add(item.AnnouncementDescription);
			}

		}

		private void FrmDuyurular_Load(object sender, EventArgs e)
		{
			FormLoad();
		}
	}
}
