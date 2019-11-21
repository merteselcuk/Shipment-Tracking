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
    public partial class FormUserAdd : Form
    {
        public static event EventHandler AddUserEvent;
        public FormUserAdd()
        {
            InitializeComponent();
        }

        private void FormUserAdd_Load(object sender, EventArgs e)
        {
            lstRole.Yukle<Role>(SingletonDb.Context, "RoleName", "ID");

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddUser();
        }

        private void AddUser()
        {
            #region Validation
                if(txtUserName.Text.Trim()==string.Empty || txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş girilemez.");
                return;
            }
            #endregion
            User user = new User();
            user.ID = Guid.NewGuid();
            user.Password = txtPassword.Text;
            user.UserName = txtUserName.Text;
            user.IsDeleted = false;
            user.IsActive = true;

            foreach (var item in lstRole.SelectedItems)
            {
                user.Roles.Add((Role)item);
                SingletonDb.Context.Users.Add(user);

            }
            SingletonDb.Context.SaveChangesControll(AddUserEvent);
        }
    }
}
