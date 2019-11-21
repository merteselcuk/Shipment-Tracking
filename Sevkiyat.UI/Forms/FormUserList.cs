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
    public partial class FormUserList : Form
    {
        public static event EventHandler DeleteUserEvent;
        public FormUserList()
        {
            InitializeComponent();
            Load += LoadUser;
            FormUserAdd.AddUserEvent += LoadUser;
            DeleteUserEvent += LoadUser;
            FormUserUpdate.UpdateUserEvent += LoadUser;
        }
        private void LoadUser(object sender, EventArgs e)
        {
            lstUsers.Yukle<User>(SingletonDb.Context, "UserName", "ID", u => u.IsDeleted == false);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            User user = lstUsers.SelectedItem as User;
            user.IsDeleted = true;
            SingletonDb.Context.SaveChangesControll(DeleteUserEvent);

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            User user = lstUsers.SelectedItem as User;
            this.MdiBroShow<FormUserUpdate,User>(user);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.MdiBroShow<FormUserAdd>();
        }
    }
}
