using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarlikZimmetDepoYonetim.DAL.IRepo;
using VarlikZimmetDepoYonetim.DTO;
using VarlikZimmetDepoYonetim.Provider;

namespace VarlikZimmetDepoYonetim.DAL.ReportDAL
{
	/// <summary>
	/// 
	/// </summary>
	public class TeamAssignmentReportDAL : ISelectRepoId<TeamAssignment>
	{
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
							ProductType = new ProductType() { ProductTypeName = reader.GetString(2) },
							Price = Convert.ToDouble(reader.GetDecimal(3)),
							Brand = new Brand() { BrandName = (reader.GetString(4)) },
							Model = new Model() { ModelName = (reader.GetString(5)) }

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
					

					teamAssignment.TeamAssignmentId = reader.GetInt32(0);
					teamAssignments.Add(teamAssignment);
				}
			}
			sqlDbService.Close();
			return teamAssignments;
		}
	}
}
