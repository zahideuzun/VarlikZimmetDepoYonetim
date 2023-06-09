﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepoYonetim.DTO
{
	public class User : BaseDTO
	{
		public int UserId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public User Manager { get; set; }
		public Team Team { get; set; }
		public Company Company { get; set; }
		public override string ToString()
		{
			return FirstName + " " + LastName;
		}
	}

}
