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
    public partial class FormWayBillAdd : Form
    {
        List<WayBillDetail> _wayBillDetails;

        public FormWayBillAdd()
        {
            InitializeComponent();
            _wayBillDetails = new List<WayBillDetail>();
        }

        private void FormWayBillAdd_Load(object sender, EventArgs e)
        {
            LoadCombobox();

            ReceiverDetail();
        }
        private void CbxSender_SelectedIndexChanged(object sender, EventArgs e)
        {
            SenderDetail();
        }
        private void CbxReceiver_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReceiverDetail();
        }
        private void ReceiverDetail()
        {
            Payer payer = cbxReceiver.SelectedItem as Payer;
            lblReceiverContact.Text = payer.ContactName;
            lblReceiverPhone.Text = payer.Phone;
            lblReceiverAddress.Text = payer.Address;
        }

        private void SenderDetail()
        {
            Payer payer = cbxSender.SelectedItem as Payer;
            lblSenderContact.Text = payer.ContactName;
            lblSenderPhone.Text = payer.Phone;
            lblSenderAddress.Text = payer.Address;
        }

        private void LoadCombobox()
        {
            cbxBillType.LoadEnum<WayBillType>();
            cbxSender.Yukle<Payer>(SingletonDb.Context, "CompanyName", "ID", p => p.IsDeleted == false, p => p.IsActive == true);
            cbxReceiver.Yukle<Payer>(SingletonDb.Context, "CompanyName", "ID", p => p.IsDeleted == false, p => p.IsActive == true);
            cbxDriver.Yukle<Driver>(SingletonDb.Context, "FirstName", "ID", d => d.IsDeleted == false, d => d.IsActive == true);
            cbxVehicle.Yukle<Vehicle>(SingletonDb.Context, "Plate", "ID", v => v.IsDeleted == false, v => v.IsActive == true);
            cbxProduct.Yukle<Product>(SingletonDb.Context, "ProductName", "ID", p => p.IsDeleted == false, p => p.IsActive == true);
            lstViewWayBill.Columns.Add("ÜrünAdı");
            lstViewWayBill.Columns.Add("Miktar Tipi");
            lstViewWayBill.Columns.Add("Adet");
        }

        private void BtnProductConfirm_Click(object sender, EventArgs e)
        {
            AddItemToListView();
        }

        private void AddItemToListView()
        {
            WayBillDetail wayBillDetail = new WayBillDetail()
            {
                Product = cbxProduct.SelectedItem as Product,
                Quantity = (short)nudQuantity.Value,
                Description = txtDescription.Text
            };
            #region Validation
            if (wayBillDetail.Quantity == 0)
            {
                MessageBox.Show("Adet sayısı 0 dan fazla girilmelidir.");
                    return;
            }
            #endregion
            bool equality = false;
            foreach (var item in _wayBillDetails)
            {
                if (item.Product.ID == wayBillDetail.Product.ID)
                {
                    equality = true;
                }
                else
                {
                    equality = false;
                }
            }
            if (equality == false)
            {
                _wayBillDetails.Add(wayBillDetail);

            }
            else
            {
                MessageBox.Show("Aynı ürün eklenemez..");
            }
            WayBillDetailLoad();


        }

        private void WayBillDetailLoad()
        {
            lstViewWayBill.Items.Clear();
            foreach (var item in _wayBillDetails)
            {
                string[] subitems = { ((ProductQuantityPerUnit)item.Product.QuantityPerUnit).ToString(), item.Quantity.ToString() };
                lstViewWayBill.Items.Add(item.Product.ProductName.ToString()).SubItems.AddRange(subitems);
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            _wayBillDetails.Clear();
            WayBillDetailLoad();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            #region Validation
            if (txtDescription.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Description alanı boş girilemez.");
                return;
            }
            #endregion
            WayBill wayBill = new WayBill();
            wayBill.ID = Guid.NewGuid();
            wayBill.DriverID = (Guid)cbxDriver.SelectedValue;
            wayBill.VehicleID = (Guid)cbxVehicle.SelectedValue;
            wayBill.SenderID = (Guid)cbxSender.SelectedValue;
            wayBill.ReceiverID = (Guid)cbxReceiver.SelectedValue;
            wayBill.ShipmentDate = dtpShipmentDate.Value;
            wayBill.DeliveryDate = dtpDeliveryDate.Value;
            wayBill.BillType = Convert.ToByte(cbxBillType.SelectedValue);
            wayBill.CreatedDate = DateTime.Now;
            wayBill.CreatedUserID = Session.CurrentUser.ID;

            foreach (var item in _wayBillDetails)
            {
                wayBill.WayBillDetails.Add(item);

            }

            SingletonDb.Context.WayBills.Add(wayBill);
            SingletonDb.Context.SaveChanges();

        }




        //CREATED USER - CREATED DATE 
        //BU 2 İRSALİYE KOLONU ELLE GİRİLMEYECEĞİ İÇİN FORMDA YOK
    }
}
