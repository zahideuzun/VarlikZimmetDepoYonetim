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
		private FrmAnaSayfa frmAnaSayfa;
		public FrmGirisEkrani()
		{
			InitializeComponent();
			tbUserPassword.PasswordChar = '*'; //kullanici sifre girerken sifrenin yildizla maskelenmesini kontrol eden prop.
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			Login();
		}

		/// <summary>
		/// Kullanıcının mail adresi ve sifresini UserLoginDAL classindan database karsilastirmasini yaparak kullanıcı girisini kontrol eden ve bir sonraki forma yönlendiren metot.
		/// </summary>
		void Login()
		{
			UserLoginDAL userLoginDal = new UserLoginDAL();
			UserRole userRole = userLoginDal.UserLogin(tbUserMailAddress.Text, tbUserPassword.Text);
			if (userRole != null)
			{
				MessageBox.Show("Giriş başarılı.");
				frmAnaSayfa = new FrmAnaSayfa(userRole);
				frmAnaSayfa.Show();
			}
			else
			{
				MessageBox.Show("Hatalı giriş!");
			}
		}

		/// <summary>
		/// Şifreyi göster checkboxina işaretlendiğinde sifreyi gösteren, işaretleme kaldırıldıgında şifreyi maskeleyen event.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
		{
			tbUserPassword.PasswordChar = cbShowPassword.Checked ? '\0' : '*';
		}
	}
}
