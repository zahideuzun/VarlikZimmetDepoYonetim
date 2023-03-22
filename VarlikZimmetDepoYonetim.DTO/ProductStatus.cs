using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepoYonetim.DTO
{
	public class ProductStatus : BaseDTO 
	{
		public int ProductStatusId { get; set; }
		public Status Status { get; set; }
		public Product Product { get; set; }
	}
}
