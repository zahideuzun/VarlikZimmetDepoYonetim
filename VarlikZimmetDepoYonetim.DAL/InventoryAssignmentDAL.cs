using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarlikZimmetDepoYonetim.DAL.IRepo;
using VarlikZimmetDepoYonetim.DTO;
using VarlikZimmetDepoYonetim.DTO.Result;
using VarlikZimmetDepoYonetim.Provider;

namespace VarlikZimmetDepoYonetim.DAL
{
	public class InventoryAssignmentDAL : IInsertRepo<InventoryAssignment>
	{
		/// <summary>
		/// yeni bir zimmet atama sorgusunu gerceklestiren metot.
		/// </summary>
		/// <param name="insertedData"></param>
		/// <returns></returns>
		public MyResult Insert(InventoryAssignment insertedData)
		{
			SqlDbService sqlDbService =
				new SqlDbService(
					"insert into Zimmet(ZimmetNedeniId,ZimmetTuruId,UrunDepoId,Aciklama,AktifMi, BaslangicTarihi,BitisTarihi)\r\nvalues(@ZimmetNedeniId,@ZimmetTuruId,@UrunDepoId,@Aciklama,@AktifMi, @BaslangicTarihi,@BitisTarihi)");

			sqlDbService.Open();
			List<SqlParameter> parameters = new List<SqlParameter>();
			parameters.Add(new SqlParameter("@ZimmetNedeniId", insertedData.AssignmentReason.InventoryReasonId));
			parameters.Add(new SqlParameter("@ZimmetTuruId", insertedData.AssignmentType.InventoryTypeId));
			parameters.Add(new SqlParameter("@UrunDepoId", insertedData.ProductWarehouse.ProductWarehouseId));
			parameters.Add(new SqlParameter("@Aciklama", insertedData.Description));
			parameters.Add(new SqlParameter("@BaslangicTarihi", insertedData.AssignmentStartDate));
			parameters.Add(new SqlParameter("@BitisTarihi", insertedData.AssignmentEndDate));
			parameters.Add(new SqlParameter("@AktifMi", true));

			sqlDbService.AddParameters(parameters.ToArray());
			int rowAffected = sqlDbService.ExecuteNonQuery();

			sqlDbService.Close();
			return new MyResult()
			{
				Result = rowAffected,
				ResultMessage = rowAffected > 0 ? "zimmete eklendi" : "hata",
				ResultType = rowAffected > 0
			};

		}
		
		/// <summary>
		/// en son eklenen zimmetin idsini getiren metot.
		/// </summary>
		/// <returns></returns>
		public int InventoryAssignmentId()
		{
			SqlDbService sqlDbService =
				new SqlDbService(
					"select Top(1) ZimmetId from Zimmet order by ZimmetId desc");
			sqlDbService.Open();
			return Convert.ToInt32(sqlDbService.ExecuteScalar());
		}

	}

}

