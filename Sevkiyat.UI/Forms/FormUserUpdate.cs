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
    public delegate void HaberTipi();
    public partial class FormUserUpdate : Form
    {
        public event HaberTipi RoleChange;
        public static event EventHandler UpdateUserEvent;
        User _user;
        HashSet<Role> _role;
        public FormUserUpdate(User user)
        {
            InitializeComponent();
            _user = user;
            _role = new HashSet<Role>();
            foreach (var item in _user.Roles.ToList())
            {
                _role.Add(item);
            }
            Load += FormLoad;
            RoleChange += RoleListLoad;

        }
        private void FormLoad(object sender, EventArgs e)
        {           
            txtUserName.Text = _user.UserName;
            chbActive.Checked = (bool)_user.IsActive;
            cbxRoles.Yukle<Role>(SingletonDb.Context, "RoleName", "ID");
            lstRole.Yukle<Role>(_role, "RoleName", "ID");
        }

        private void RoleListLoad()
        {
            lstRole.Yukle<Role>(_role, "RoleName", "ID");
        }
        private void BtnRoleAdd_Click(object sender, EventArgs e)
        {
            Role role = cbxRoles.SelectedItem as Role;
            _role.Add(role);
            RoleChange();
        }

        private void BtnRoleSil_Click(object sender, EventArgs e)
        {
            Role role = lstRole.SelectedItem as Role;
            _role.Remove(role);
            RoleChange();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            #region Validation
            if (txtUserName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş girilemez.");
                return;
            }
            #endregion
            _user.Roles.Clear();
            _user.UserName = txtUserName.Text;
            _user.IsActive = chbActive.Checked;
            foreach (var item in _role)
            {
                _user.Roles.Add(item);
            }
            SingletonDb.Context.SaveChangesControll(UpdateUserEvent);
        }

    }
}
