using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepoYonetim.DTO
{
	public class Warehouse : BaseDTO 
	{
		public int WarehouseId { get; set; }
		public string WarehouseName { get; set; }
		public Company Company { get; set; }
		public bool IsActive { get; set; }
	}

}
