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

namespace VarlikZimmetDepoYonetim.UI
{
	public partial class FrmSSSorular : Form
	{
		public FrmSSSorular()
		{
			InitializeComponent();
		}

		private void FrmSSSorular_Load(object sender, EventArgs e)
		{

		}

		void FormLoad()
		{
			QuestionDAL questionDal = new QuestionDAL();
			questionDal.Select();
		}
	}
}
