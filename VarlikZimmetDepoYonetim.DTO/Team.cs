using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepoYonetim.DTO
{
	public class Team : BaseDTO
	{
		public int TeamId { get; set; }
			public string TeamName { get; set; }
			public Company Company { get; set; }
			public bool IsActive { get; set; }
		

	}
}
