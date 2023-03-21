using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepoYonetim.DTO
{
	public class Price : BaseDTO
	{
		public int PriceId { get; set; }
		public double CurrentPrice { get; set; }
		public DateTime LastPriceUpdateDate { get; set; }
		public Currency Currency { get; set; }
		public Product Product { get; set; }
	}

}
