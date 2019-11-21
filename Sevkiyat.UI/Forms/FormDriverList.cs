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
    public partial class FormDriverList : Form
    {
        public static event EventHandler DeleteDriverEvent;
        public FormDriverList()
        {
            InitializeComponent();
            Load += ListLoad;
            FormDriverAdd.AddDriverEvent += ListLoad;
            FormDriverUpdate.UpdateDriverEvent += ListLoad;
            DeleteDriverEvent += ListLoad;
        }
        private void ListLoad(object sender, EventArgs e)
        {
            lstDrivers.Yukle<Driver>(SingletonDb.Context,"FirstName", "ID", d => d.IsDeleted == false);
            UserRoleControl();
        }

        private void BtnDriverAdd_Click(object sender, EventArgs e)
        {
            this.MdiBroShow<FormDriverAdd>(); 
        }

        private void BtnDriverUpdate_Click(object sender, EventArgs e)
        {
            Driver driver = lstDrivers.SelectedItem as Driver;
            this.MdiBroShow<FormDriverUpdate, Driver>(driver);
            
        }

        private void BtnDriverDelete_Click(object sender, EventArgs e)
        {
            Driver driver = lstDrivers.SelectedItem as Driver;
            driver.IsDeleted = true;
            SingletonDb.Context.SaveChangesControll(DeleteDriverEvent);
        }

        private void UserRoleControl()
        {
            int dummy = Session.FindRoleOrRoles();

            if (dummy == 0)
            {
                btnDriverAdd.Visible = false;
                btnDriverUpdate.Visible = false;
                btnDriverDelete.Visible = false;
            }
        }
    }
}