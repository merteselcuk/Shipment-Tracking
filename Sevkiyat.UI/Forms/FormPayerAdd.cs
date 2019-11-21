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
    public partial class FormPayerAdd : Form
    {
        public static event EventHandler AddPayerEvent;
        public FormPayerAdd()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbxMusteriTipi.LoadEnum<PayerType>();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            PayerAdd();
        }

        private void PayerAdd()
        {
            #region Validation
                if(txtCompanyName.Text.Trim()==string.Empty 
                || txtContactName.Text.Trim()==string.Empty
                || txtCity.Text.Trim()==string.Empty
                || txtPhone.Text.Trim()==string.Empty
                || txtAddress.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Şirket adı,muhattap kişi,şehir,telefon,adres bilgileri boş bırakılamaz.");
                return;
            }
            #endregion
            Payer payer = new Payer();
            payer.ID = Guid.NewGuid();
            payer.CompanyName = txtCompanyName.Text;
            payer.ContactName = txtContactName.Text;
            payer.City = txtCity.Text;
            payer.Phone = txtPhone.Text;
            payer.Address = txtAddress.Text;
            payer.TypeID = Convert.ToByte(cbxMusteriTipi.SelectedValue);
            payer.IsDeleted = false;
            payer.IsActive = true;
            SingletonDb.Context.Payers.Add(payer);
            SingletonDb.Context.SaveChangesControll(AddPayerEvent);
        }
    }
}
