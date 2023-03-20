﻿using System;
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
		public List<Question> Select()
		{
			List<Question> questions = null;

			SqlDbService sqlDbService = new SqlDbService("select s.SoruBasligi as [Soru Başlığı], s.SoruCevabi as [Cevap] from Soru s");
			sqlDbService.Open();
			SqlDataReader reader = sqlDbService.ExReader();

			if (reader.HasRows)
			{
				questions = new List<Question>();
				while (reader.Read())
				{
					Question q = new Question();
					q.QuestionName = reader.GetString(0);
					q.QuestionAnswer = reader.GetString(1);
					questions.Add(q);
				}
			}
			sqlDbService.Close();
			return questions;
		}
	}
}