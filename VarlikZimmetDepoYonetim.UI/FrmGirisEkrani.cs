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
using VarlikZimmetDepoYonetim.Provider;

namespace VarlikZimmetDepoYonetim.UI
{
	public partial class FrmGirisEkrani : Form
	{
		private SqlProviderService sqlProviderService;
		private FrmAnaSayfa frmAnaSayfa;
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
			string email = tbUserMailAddress.Text;
			string password = tbUserPassword.Text;
			
			SqlDbService sqlDbService =
				new SqlDbService(
					"select KullaniciSifre from Kullanici where KullaniciMail = @Email");

			sqlDbService.Open();
			List<SqlParameter> parameterList = new List<SqlParameter>();
			parameterList.Add(new SqlParameter("@Email", email));
			sqlDbService.AddParameter(parameterList.ToArray());
			SqlDataReader reader = sqlDbService.ExReader();

			if (reader.Read())
			{
				string dbPassword = reader["KullaniciSifre"].ToString();

				if (dbPassword == password)
				{
					MessageBox.Show("Login successful.");
					FrmAnaSayfa frmAnaSayfa = new FrmAnaSayfa();
					frmAnaSayfa.Show();
					// TODO: Kullanıcı rolüne göre uygun sayfaya yönlendirme yapılabilir.
				}
				else
				{
					MessageBox.Show("Invalid password.");
				}
			}
			else
			{
				MessageBox.Show("Invalid email.");
			}
		}

		private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
		{
			tbUserPassword.PasswordChar = cbShowPassword.Checked ? '\0' : '*';
		}
	}
}
