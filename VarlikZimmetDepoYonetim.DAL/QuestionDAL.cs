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
	public class QuestionDAL : ISelectRepo<Question>
	{
		/// <summary>
		/// Sık sorulan sorular ekranındaki soruların databaseden listeyen select metodu. Databasede örnek sorular kullanılmıştır.
		/// </summary>
		/// <returns></returns>
		public List<Question> Select()
		{
			List<Question> questions = null;

			SqlDbService sqlDbService = new SqlDbService("select s.SoruBasligi as [Soru Başlığı], s.SoruCevabi as [Cevap] from Soru s");
			sqlDbService.Open();
			SqlDataReader reader = sqlDbService.ExecuteReader();

			if (reader.HasRows)
			{
				questions = new List<Question>();
				while (reader.Read())
				{
					Question question = new Question();
					question.QuestionName = reader.GetString(0);
					question.QuestionAnswer = reader.GetString(1);
					questions.Add(question);
				}
			}
			sqlDbService.Close();
			return questions;
		}
	}
}
