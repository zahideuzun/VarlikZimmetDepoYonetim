using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepoYonetim.DTO
{
	public class InventoryReason : BaseDTO 
	{
		public int InventoryReasonId { get; set; }
		public string InventoryReasonName { get; set; }

	}
}
