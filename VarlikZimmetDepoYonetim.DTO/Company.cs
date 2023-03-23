using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepoYonetim.DTO
{
	public class Company : BaseDTO
	{
		public int CompanyId { get; set; }
		public string CompanyName { get; set; }
		public override string ToString()
		{
			return CompanyName;
		}
	}
}
