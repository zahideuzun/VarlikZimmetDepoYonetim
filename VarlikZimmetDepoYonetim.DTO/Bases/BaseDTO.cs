using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepoYonetim.DTO
{
	public abstract class BaseDTO
	{
		public DateTime? CreateDate { get; set; } = DateTime.Now;
		public string CreatedBy { get; set; }
		public DateTime? ModifiedDate { get; set; } = DateTime.Now;
		public string ModifiedBy { get; set; }
		public bool IsAktive { get; set; } = true;
	}
}
