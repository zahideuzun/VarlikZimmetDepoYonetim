using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepoYonetim.DTO
{
	public class InventoryAssignment : BaseDTO
	{
		public int InventoryAssignmentId { get; set; }
		public Product Product { get; set; }
		public InventoryReason AssignmentReason { get; set; }
		public InventoryType AssignmentType { get; set; }
		public string Description { get; set; }
		public ProductWarehouse ProductWarehouse { get; set; }

	}

}
