using Sevkiyat.UI.Enums;
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
    public partial class FormPayersUpdate : Form
    {
        public static event EventHandler UpdatePayerEvent;
        Payer _payer;
        public FormPayersUpdate(Payer payer)
        {
            InitializeComponent();
            _payer = payer;
        }

        private void FormPayersUpdate_Load(object sender, EventArgs e)
        {
            LoadPayerInformation();
        }

        private void LoadPayerInformation()
        {
            cbxPayerType.LoadEnum<PayerType>();
            txtID.Text = _payer.ID.ToString();
            txtCompanyName.Text = _payer.CompanyName;
            txtContactName.Text = _payer.ContactName;
            txtCity.Text = _payer.City;
            txtPhone.Text = _payer.Phone;
            txtAddress.Text = _payer.Address;
            cbxPayerType.SelectedItem = _payer.TypeID;
            txtID.Enabled = false;
            chxActive.Checked = (bool)_payer.IsActive;
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            UpdatePayer();
        }
        private void UpdatePayer()
        {
            #region Validation
            if (txtCompanyName.Text.Trim() == string.Empty
            || txtContactName.Text.Trim() == string.Empty
            || txtCity.Text.Trim() == string.Empty
            || txtPhone.Text.Trim() == string.Empty
            || txtAddress.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Şirket adı,muhattap kişi,şehir,telefon,adres bilgileri boş bırakılamaz.");
                return;
            }
            #endregion
            _payer = (from p in SingletonDb.Context.Payers where p.ID == _payer.ID select p).SingleOrDefault();
            _payer.CompanyName = txtCompanyName.Text;
            _payer.ContactName = txtContactName.Text;
            _payer.City = txtCity.Text;
            _payer.Phone = txtPhone.Text;
            _payer.Address = txtAddress.Text;
            _payer.TypeID = Convert.ToByte(cbxPayerType.SelectedValue);
            _payer.IsActive = chxActive.Checked;
            SingletonDb.Context.SaveChangesControll(UpdatePayerEvent);
        }

        
    }
}
