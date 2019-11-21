using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformHelper;

namespace Sevkiyat.UI.Forms
{
    public partial class FormPasswordChange : Form
    {
        public FormPasswordChange()
        {
            InitializeComponent();
        }

        private void BtnChangePassword_Click(object sender, EventArgs e)
        {
            PasswordChange();

        }

        private void PasswordChange()
        {
            #region Validation
                if(txtOldPassword.Text.Trim()==string.Empty 
                || txtNewPassword.Text.Trim()==string.Empty
                || txtNewPassword2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Şifre alanlarının hiçbiri boş bırakılamaz.");
                return;
            }
            if (Session.CurrentUser.Password != txtOldPassword.Text || txtNewPassword.Text != txtNewPassword2.Text || txtNewPassword.Text.Length < 1)
            {
                MessageBox.Show("Eski şifre hatalı yada yeni şifreler uyuşmuyor.");
                return;
            }
            #endregion
            User user = (from u in SingletonDb.Context.Users where u.ID == Session.CurrentUser.ID select u).SingleOrDefault();
            user.Password = txtNewPassword.Text;
            SingletonDb.Context.SaveChangesControll();
        }
    }
}
