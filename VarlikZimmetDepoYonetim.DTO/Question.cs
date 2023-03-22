using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepoYonetim.DTO
{
	public class Question : BaseDTO
	{
		public int QuestionId { get; set; }
		public string QuestionName { get; set; }
		public string QuestionAnswer { get; set; }

		public override string ToString()
		{
			return QuestionName;
		}
	}
}
