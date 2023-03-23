using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using VarlikZimmetDepoYonetim.DAL.IRepo;
using VarlikZimmetDepoYonetim.DTO;
using VarlikZimmetDepoYonetim.DTO.Result;
using VarlikZimmetDepoYonetim.Provider;

namespace VarlikZimmetDepoYonetim.DAL
{
	public class TeamAssignmentDAL : ISelectRepoId<TeamAssignment> , IInsertRepo<TeamAssignment>
	{
		/// <summary>
		/// Giriş yapan kullanıcının ekip idsine göre ekibine zimmetlenmis ürünleri getiren select metodu.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public List<TeamAssignment> Select(int id)
		{
			List<TeamAssignment> teamAssignments = null;

			SqlDbService sqlDbService = new SqlDbService($"select  ez.EkipZimmetId [kayit no] ,u.BarkodNo, ut.UrunTipiAdi as [Ürün Tipi],fy.GuncelFiyat as Fiyat ,mr.MarkaAdi as Marka ,mdl.ModelAdi as Model  \r\n\t from EkipZimmet ez \r\n\t inner join Ekip e on ez.EkipId = e.EkipId\r\n\t inner join Zimmet z on ez.ZimmetId = z.ZimmetId\r\n\t inner join UrunDepo ud on z.UrunDepoId= ud.UrunDepoId\r\n\t inner join Urun u on ud.UrunId = u.UrunId\r\n\t inner join UrunTipi ut on u.UrunTipiId= ut.UrunTipiId\r\n\t inner join Fiyat fy on fy.UrunId = u.UrunId\r\n\t inner join Marka mr on mr.MarkaId = u.MarkaId\r\n\t inner join Model mdl on mdl.ModelId = u.ModelId where ez.AktifMi = 'True' and fy.AktifMi = 'True' and ez.EkipId = {id}");
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
					teamAssignment.TeamAssignmentId = reader.GetInt32(0);
					teamAssignments.Add(teamAssignment);
				}
			}
			sqlDbService.Close();
			return teamAssignments;
		}

		/// <summary>
		/// ekip zimmet tablosuna yeni bir zimmet atamasi yapan metot.
		/// </summary>
		/// <param name="insertedData"></param>
		/// <returns></returns>
		public MyResult Insert(TeamAssignment insertedData)
		{
			SqlDbService sqlDbService = new SqlDbService("insert into EkipZimmet ( EkipId, ZimmetId, AktifMi)\r\nvalues (@EkipId, @ZimmetId, @AktifMi)");
			sqlDbService.Open();
			List<SqlParameter> parameters = new List<SqlParameter>();
			parameters.Add(new SqlParameter("@EkipId", insertedData.Team.TeamId));
			parameters.Add(new SqlParameter("@ZimmetId", insertedData.InventoryAssignment.InventoryAssignmentId));
			parameters.Add(new SqlParameter("@AktifMi", true));

			sqlDbService.AddParameters(parameters.ToArray());
			int rowAffected = sqlDbService.ExecuteNonQuery();

			sqlDbService.Close();
			return new MyResult()
			{
				Result = rowAffected,
				ResultMessage = rowAffected > 0 ? "ekip zimmet" : "hata",
				ResultType = rowAffected > 0
			};
		}
	}
}
