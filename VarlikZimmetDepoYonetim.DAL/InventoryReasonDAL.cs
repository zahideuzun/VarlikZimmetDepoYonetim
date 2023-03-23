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
	public class InventoryReasonDAL : ISelectRepo<InventoryReason>
	{
		/// <summary>
		/// ZimmetNedeni tablosunun database baglantisini yaparak select sorgusuyla listeler.
		/// </summary>
		/// <returns></returns>
		public List<InventoryReason> Select()
		{
			List<InventoryReason> inventoryReasons = null;

			SqlDbService sqlDbService = new SqlDbService("select z.ZimmetNedeniId, z.ZimmetNedeni from ZimmetNedeni z where z.AktifMi = 'True'");
			sqlDbService.Open();
			SqlDataReader reader = sqlDbService.ExecuteReader();

			if (reader.HasRows)
			{
				inventoryReasons = new List<InventoryReason>();
				while (reader.Read())
				{
					InventoryReason inventoryReason = new InventoryReason();
					inventoryReason.InventoryReasonId = reader.GetInt32(0);
					inventoryReason.InventoryReasonName = reader.GetString(1);
					inventoryReasons.Add(inventoryReason);
				}
			}
			sqlDbService.Close();
			return inventoryReasons;
		}
	}
}
