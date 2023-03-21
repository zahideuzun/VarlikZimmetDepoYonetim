using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepoYonetim.DTO
{
	public class ProductType : BaseDTO
	{
		public int ProductTypeId { get; set; }
		public string ProductTypeName { get; set; }
		public override string ToString()
		{
			return ProductTypeName;
		}
	}

}
