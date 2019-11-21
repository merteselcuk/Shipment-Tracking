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
    public partial class FormDriverUpdate : Form
    {
        public static event EventHandler UpdateDriverEvent;
        Driver _driver;
        public FormDriverUpdate(Driver driver)
        {
            InitializeComponent();
            _driver = driver;
        }

        private void FormDriverUpdate_Load(object sender, EventArgs e)
        {
            LoadDriverInformation();

        }

        private void LoadDriverInformation()
        {
            txtFirstName.Text = _driver.FirstName;
            txtLastName.Text = _driver.LastName;
            txtTcNo.Text = _driver.TcNo;
            txtPhone.Text = _driver.Phone;
            dtpBirthDate.Value = (DateTime)_driver.BirthDate;
            chxActive.Checked = (bool)_driver.IsActive;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            UpdateDriver();
            
        }

        private void UpdateDriver()
        {
            #region Validation
            if (txtFirstName.Text.Trim() == string.Empty
                || txtLastName.Text.Trim() == string.Empty
                || txtTcNo.Text.Trim() == string.Empty
                || txtPhone.Text.Trim() == string.Empty)
            {
                MessageBox.Show("TC No,Ad,Soyad,Telefon alanları bos bırakılamaz.");
                return;
            }
            #endregion
            _driver = (from d in SingletonDb.Context.Drivers where d.ID == _driver.ID select d).SingleOrDefault();
            _driver.FirstName = txtFirstName.Text;
            _driver.LastName = txtLastName.Text;
            _driver.TcNo = txtTcNo.Text;
            _driver.Phone = txtPhone.Text;
            _driver.BirthDate = dtpBirthDate.Value;
            _driver.IsActive = chxActive.Checked;
            SingletonDb.Context.SaveChangesControll(UpdateDriverEvent);
        }
    }
}
