using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepoYonetim.DTO
{
	public class UserAssignment
	{
		public User User { get; set; }
		public EquipmentAssignment EquipmentAssignment { get; set; }
		public DateTime AssignmentStartDate { get; set; }
		public DateTime AssignmentEndDate { get; set; }
	}

}
