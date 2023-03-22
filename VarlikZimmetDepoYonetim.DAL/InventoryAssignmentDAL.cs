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
		public MyResult Insert(InventoryAssignment insertedData)
		{
			SqlDbService sqlDbService = new SqlDbService("select u.UrunId as [Kayıt Numarası], u.BarkodNo, ug.UrunGrubuAdi as [Ürün Tipi], f.GuncelFiyat as [Ürünün Güncel Fiyatı], mr.MarkaAdi as Marka, mo.ModelAdi as Model from Urun u \r\n\t join UrunGrubu ug on u.UrunGrubuId = ug.UrunGrubuId\r\n\t join Marka mr on mr.MarkaId = u.MarkaId\r\n\t join Model mo on mo.ModelId = u.ModelId\r\n\t join Fiyat f on f.UrunId = u.UrunId");




			return new MyResult();
		}

		
		}

	}
}
