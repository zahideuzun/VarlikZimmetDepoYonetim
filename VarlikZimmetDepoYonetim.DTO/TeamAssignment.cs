﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepoYonetim.DTO
{
	public class TeamAssignment : BaseDTO
	{
		public int TeamAssignmentId { get; set; }
		public Team Team { get; set; }
		public InventoryAssignment InventoryAssignment { get; set; }
		
	}

}
