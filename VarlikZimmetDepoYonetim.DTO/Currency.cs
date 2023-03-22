using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepoYonetim.DTO
{
	public class Currency : BaseDTO 
	{
		public int CurrencyId { get; set; }
		public string CurrencyName { get; set; }
		public override string ToString()
		{
			return CurrencyName;
		}
	}

}
