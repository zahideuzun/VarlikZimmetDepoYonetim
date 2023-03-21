using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepoYonetim.DTO
{
	public class CustomerProduct
	{
		public Customer Customer { get; set; }
		public Product Product { get; set; }
		public string Description { get; set; }
	}
}
