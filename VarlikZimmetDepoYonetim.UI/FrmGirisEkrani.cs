using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VarlikZimmetDepoYonetim.DAL;
using VarlikZimmetDepoYonetim.DTO;
using VarlikZimmetDepoYonetim.Provider;

namespace VarlikZimmetDepoYonetim.UI
{
	public partial class FrmGirisEkrani : Form
	{
		private SqlProviderService sqlProviderService;
		private FrmAnaSayfa frmAnaSayfa;
		private User loginUser;
		public FrmGirisEkrani()
		{
			InitializeComponent();
			tbUserPassword.PasswordChar = '*';
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			Login();
		}

		void Login()
		{
			UserLoginDAL userLogin = new UserLoginDAL();
			UserRole userRole = userLogin.UserLogin(tbUserMailAddress.Text, tbUserPassword.Text);
			if (userRole != null)
			{
				MessageBox.Show("Login successful.");
				userRole.User = loginUser;
				FrmAnaSayfa frmAnaSayfa = new FrmAnaSayfa(userRole,loginUser);
				frmAnaSayfa.Show();
			}
			else
			{
				MessageBox.Show("Invalid password.");
			}
		}

		private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
		{
			tbUserPassword.PasswordChar = cbShowPassword.Checked ? '\0' : '*';
		}
	}
}
