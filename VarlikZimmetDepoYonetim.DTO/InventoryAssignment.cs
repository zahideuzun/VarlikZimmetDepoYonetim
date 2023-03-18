using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepoYonetim.DTO
{
	public class InventoryAssignment
	{
		public int InventoryAssignmentId { get; set; }
		public Product Product { get; set; }
		public AssignmentReason AssignmentReason { get; set; }
		public AssignmentType AssignmentType { get; set; }
		public string Description { get; set; }
	}

}
