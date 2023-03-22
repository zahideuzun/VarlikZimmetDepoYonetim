using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepoYonetim.DTO
{
	public class Status : BaseDTO
	{
		public int StatusId { get; set; }
		public string StatusName { get; set; }
		public override string ToString()
		{
			return StatusName;
		}
	}
}
