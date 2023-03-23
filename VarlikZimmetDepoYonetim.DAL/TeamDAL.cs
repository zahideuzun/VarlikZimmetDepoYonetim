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
	public class TeamDAL : ISelectRepo<Team>
	{
		public List<Team> Select()
		{
			List<Team> teams = null;
			SqlDbService sqlDbService = new SqlDbService("select e.EkipId, e.EkipAdi from Ekip e where e.AktifMi = 'True'");
			sqlDbService.Open();
			SqlDataReader reader = sqlDbService.ExecuteReader();

			if (reader.HasRows)
			{
				teams = new List<Team>();
				while (reader.Read())
				{
					teams.Add(new Team()
					{
						TeamId = reader.GetInt32(0),
						TeamName = reader.GetString(1)
					});
				}
			}
			sqlDbService.Close();
			return teams;
		}
	}
}
