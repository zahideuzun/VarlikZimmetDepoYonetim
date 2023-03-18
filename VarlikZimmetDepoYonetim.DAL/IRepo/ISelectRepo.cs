using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarlikZimmetDepoYonetim.DAL.IRepo
{
	public interface ISelectRepo<T> where T : class
	{
		List<T> Select();
	}
}
