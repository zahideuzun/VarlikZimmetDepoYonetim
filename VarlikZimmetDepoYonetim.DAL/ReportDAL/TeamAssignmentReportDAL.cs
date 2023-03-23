using System.Collections.Generic;
using System.Data.SqlClient;
using VarlikZimmetDepoYonetim.DAL.IRepo;
using VarlikZimmetDepoYonetim.DTO;
using VarlikZimmetDepoYonetim.Provider;

namespace VarlikZimmetDepoYonetim.DAL.ReportDAL
{
	public class TeamAssignmentReportDAL : ISelectRepoId<TeamAssignment>
	{
		/// <summary>
		/// istenen sirketteki ekiplere göre ekiplere zimmetlenmis aktif varliklari listeleyen select metodu.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public List<TeamAssignment> Select(int id)
		{
			List<TeamAssignment> teamAssignments = null;

			SqlDbService sqlDbService = new SqlDbService($"select e.EkipId,e.EkipAdi Ekip,u.BarkodNo ,mr.MarkaAdi Marka ,m.ModelAdi [Model Adı],z.BaslangicTarihi [Zimmet Başlangıç Tarihi], \r\nz.BitisTarihi [Zimmet Bitiş Tarihi] from Ekip e \r\njoin Sirket s on e.SirketId = s.SirketId \r\njoin EkipZimmet ez on ez.EkipId = e.EkipId \r\njoin Zimmet z on z.ZimmetId = ez.ZimmetId\r\njoin UrunDepo ud on ud.UrunDepoId = z.UrunDepoId\r\njoin Urun u on u.UrunId = ud.UrunId\r\njoin Model m on m.ModelId = u.ModelId\r\njoin Marka mr on mr.MarkaId = m.MarkaId\r\nwhere s.SirketId = {id} and ez.AktifMi = 'True'");
			sqlDbService.Open();
			SqlDataReader reader = sqlDbService.ExecuteReader();

			if (reader.HasRows)
			{
				teamAssignments = new List<TeamAssignment>();
				while (reader.Read())
				{
					TeamAssignment teamAssignment = new TeamAssignment();
					teamAssignment.InventoryAssignment = new InventoryAssignment()
					{
						Product = new Product()
						{
							ProductBarcode = reader.GetGuid(reader.GetOrdinal("BarkodNo")),
							Brand = new Brand() { BrandName = (reader.GetString(3)) },
							Model = new Model() { ModelName = (reader.GetString(4)) }
						}

					};
					teamAssignment.Team = new Team()
					{
						TeamId = reader.GetInt32(0),
						TeamName = reader.GetString(1),
						Company = new Company()
						{
							CompanyName = reader.GetString(3)
						}
						
					};
					
					teamAssignment.InventoryAssignment.AssignmentStartDate = reader.GetDateTime(5);
					teamAssignment.InventoryAssignment.AssignmentEndDate = reader.GetDateTime(6);
					teamAssignments.Add(teamAssignment);
				}
			}
			sqlDbService.Close();
			return teamAssignments;
		}
	}
}
