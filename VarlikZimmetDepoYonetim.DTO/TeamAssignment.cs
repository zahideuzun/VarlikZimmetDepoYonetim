using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepoYonetim.DTO
{
	public class TeamAssignment : BaseDTO
	{
		public Team Team { get; set; }
		public InventoryAssignment InventoryAssignment { get; set; }
		public DateTime AssignmentStartDate { get; set; }
		public DateTime AssignmentEndDate { get; set; }
	}

}
