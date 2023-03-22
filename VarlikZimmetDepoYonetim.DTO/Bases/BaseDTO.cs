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
		public int CreatedById { get; set; } = 1;
		public DateTime? ModifiedDate { get; set; } = DateTime.Now;
		public int ModifiedById { get; set; } = 1;
		public bool IsAktive { get; set; } = true;
	}
}
