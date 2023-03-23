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
	public class InventoryTypeDAL : ISelectRepo<InventoryType>
	{
		/// <summary>
		/// ZimmetTuru tablosunun database baglantisini yaparak select sorgusuyla listeler.
		/// </summary>
		/// <returns></returns>
		public List<InventoryType> Select()
		{
			List<InventoryType> inventoryTypes = null;

			SqlDbService sqlDbService = new SqlDbService("select z.ZimmetTuruId, z.ZimmetTuru from ZimmetTuru z where z.AktifMi = 'True'");
			sqlDbService.Open();
			SqlDataReader reader = sqlDbService.ExecuteReader();

			if (reader.HasRows)
			{
				inventoryTypes = new List<InventoryType>();
				while (reader.Read())
				{
					InventoryType inventoryType = new InventoryType();
					inventoryType.InventoryTypeId = reader.GetInt32(0);
					inventoryType.InventoryTypeName = reader.GetString(1);
					inventoryTypes.Add(inventoryType);
				}
			}
			sqlDbService.Close();
			return inventoryTypes;
		}
	}
}
