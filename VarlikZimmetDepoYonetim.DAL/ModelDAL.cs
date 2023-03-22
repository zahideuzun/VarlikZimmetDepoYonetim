using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VarlikZimmetDepoYonetim.DAL.IRepo;
using VarlikZimmetDepoYonetim.DTO;
using VarlikZimmetDepoYonetim.Provider;

namespace VarlikZimmetDepoYonetim.DAL
{
	public class ModelDAL : ISelectRepoId<Model>
	{
		/// <summary>
		/// Ürün markalarının modellerini idlerine göre select sorgusuyla getiren list metodu.
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public List<Model> Select(int id)
		{

			List<Model> models = null;

			SqlDbService sqlDbService = new SqlDbService($"select m.ModelId ,m.ModelAdi, m.MarkaId, mr.MarkaAdi from Model m \r\njoin Marka mr on mr.MarkaId = m.MarkaId where m.AktifMi = 'True' and m.MarkaId = {id}");
			sqlDbService.Open();
			SqlDataReader reader = sqlDbService.ExecuteReader();

			if (reader.HasRows)
			{
				models = new List<Model>();
				while (reader.Read())
				{
					Model model = new Model();
					model.ModelId = reader.GetInt32(0);
					model.ModelName = reader.GetString(1);
					model.Brand = new Brand()
					{
						BrandId = reader.GetInt32(2),
						BrandName = reader.GetString(3)
					};
					models.Add(model);
				}
			}
			sqlDbService.Close();
			return models;
		}
	}
}
