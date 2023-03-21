using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepoYonetim.DTO
{
	public class ProductWarehouse : BaseDTO
	{
		public int ProductWarehouseId { get; set; }
		public Product Product { get; set; }
		public Warehouse Warehouse { get; set; }
	}
}
