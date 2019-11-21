using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sevkiyat.UI.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();          
            
        }

        private void btnGir_Click(object sender, EventArgs e)
        {
            UserLogin();
        }

        private void UserLogin()
        {
            #region Validation
                if(txtKullanici.Text.Trim()==string.Empty || txtParola.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Kullanıcı Adı ve Parola Alanları Bos Bırakılamaz");
                return;
            }
            
            Session.CurrentUser = SingletonDb.Context.Users.Where(u => u.UserName == txtKullanici.Text && u.Password == txtParola.Text).SingleOrDefault();
            if (Session.CurrentUser == null)
            {
                MessageBox.Show("Kullanici adi veya Parola hatali...");
                return;
            }
            #endregion
            Session.CurrentRoles = Session.CurrentUser.Roles.ToList();

            FormMain frm = new FormMain();
            frm.Show();
            this.Hide();
        }
    }
}
