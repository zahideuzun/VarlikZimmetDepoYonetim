using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarlikZimmetDepoYonetim.DTO.Result;

namespace VarlikZimmetDepoYonetim.DAL.IRepo
{
	public interface IDeleteRepo<T> where T : class
	{
		MyResult Delete(T deletedData);
	}
}
