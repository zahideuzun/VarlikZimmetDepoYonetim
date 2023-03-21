using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepoYonetim.DTO
{
	public class UserRole : BaseDTO
	{
		public User User { get; set; }
		public Role Role { get; set; }
	}

}
