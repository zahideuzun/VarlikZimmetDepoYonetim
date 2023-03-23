using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VarlikZimmetDepoYonetim.DAL;
using VarlikZimmetDepoYonetim.DTO;

namespace VarlikZimmetDepoYonetim.UI
{
	public partial class FrmSSSorular : Form
	{
		private List<Question> questions = new List<Question>();
		public FrmSSSorular()
		{
			InitializeComponent();
		}

		private void FrmSSSorular_Load(object sender, EventArgs e)
		{
			FormLoad();
		}

		/// <summary>
		/// formun loadinda yuklenecek olan soru bilgilerini getirir.
		/// </summary>
		void FormLoad()
		{
			QuestionDAL questionDal = new QuestionDAL();
			questions.AddRange(questionDal.Select().ToArray());
			foreach (Question item in questions)
			{
				treeViewQuestions.Nodes.Add(item.QuestionName).Nodes.Add(item.QuestionAnswer);
			}

		}
	}
}
