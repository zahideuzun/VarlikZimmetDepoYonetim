using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
