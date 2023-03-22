using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepoYonetim.DTO
{
	public class Model : BaseDTO
	{
		public int ModelId { get; set; }
		public string ModelName { get; set; }
		public Brand Brand { get; set; }
		public override string ToString()
		{
			return ModelName;
		}
	}

}
