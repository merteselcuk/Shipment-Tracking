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

namespace Sevkiyat.UI
{
    public partial class FormDriverAdd : Form
    {
        public static event EventHandler AddDriverEvent;
        public FormDriverAdd()
        {
            InitializeComponent();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            DriverAdd();
        }

        private void DriverAdd()
        {
            #region Validation
            if(txtFirstName.Text.Trim()==string.Empty 
                || txtLastName.Text.Trim()==string.Empty 
                || txtTcNo.Text.Trim()==string.Empty 
                || txtPhone.Text.Trim() == string.Empty)
            {
                MessageBox.Show("TC No,Ad,Soyad,Telefon alanları bos bırakılamaz.");
                return;
            }
            #endregion
            Driver driver = new Driver()
            {
                ID = Guid.NewGuid(),
                TcNo = txtTcNo.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                BirthDate = dtpBirthDate.Value,
                Phone = txtPhone.Text,
                IsDeleted = false,
                IsActive = true
            };
            SingletonDb.Context.Drivers.Add(driver);
            SingletonDb.Context.SaveChangesControll(AddDriverEvent);
        }

    }
}
