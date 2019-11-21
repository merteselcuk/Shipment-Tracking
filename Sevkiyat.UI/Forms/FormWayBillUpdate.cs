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
    public partial class FormWayBillUpdate : Form
    {
        WayBill _wayBill;
        List<WayBillDetail> _wayBillDetails;
        public FormWayBillUpdate()
        {
            InitializeComponent();
            _wayBill = new WayBill();
            _wayBillDetails = new List<WayBillDetail>();
        }

        private void FormWayBillUpdate_Load(object sender, EventArgs e)
        {
            cbxWayBillID.Yukle<WayBill>(SingletonDb.Context,"ID", "ID");
            LoadCombobox();
        }

        private void LoadCombobox()
        {
            cbxWaybillType.LoadEnum<WayBillType>();
            cbxSender.Yukle<Payer>(SingletonDb.Context,"CompanyName", "ID", d => d.IsDeleted == false, a => a.IsActive == true);
            cbxReceiver.Yukle<Payer>(SingletonDb.Context, "CompanyName", "ID", d => d.IsDeleted == false, a => a.IsActive == true);
            cbxDriver.Yukle<Driver>(SingletonDb.Context, "FirstName", "ID",d=>d.IsDeleted==false,a=>a.IsActive==true);
            cbxVehicle.Yukle<Vehicle>(SingletonDb.Context, "Plate", "ID", d => d.IsDeleted == false, a => a.IsActive == true);
            cbxProduct.Yukle<Product>(SingletonDb.Context, "ProductName", "ID", d => d.IsDeleted == false, a => a.IsActive == true);
            
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
        private void CbxWayBillID_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadComboboxWithInformation();
            _wayBillDetails.Clear();
            ProductAddList();
            ProductList();

        }

        private void LoadComboboxWithInformation()
        {
            _wayBill = cbxWayBillID.SelectedItem as WayBill;
            cbxWaybillType.SelectedValue = _wayBill.BillType;
            cbxSender.SelectedValue = (from p in SingletonDb.Context.Payers where p.ID == _wayBill.SenderID select p.ID).SingleOrDefault();
            cbxReceiver.SelectedValue = (from p in SingletonDb.Context.Payers where p.ID == _wayBill.ReceiverID select p.ID).SingleOrDefault();
            dtpShipDate.Value = (DateTime)_wayBill.ShipmentDate;
            dtpDeliveryDate.Value = (DateTime)_wayBill.DeliveryDate;
            cbxDriver.SelectedValue = (from d in SingletonDb.Context.Drivers where d.ID == _wayBill.DriverID select d.ID).SingleOrDefault();
            cbxVehicle.SelectedValue = (from v in SingletonDb.Context.Vehicles where v.ID == _wayBill.VehicleID select v.ID).SingleOrDefault();
            
        }

        private void ProductList()
        {

            lstViewProducts.Clear();
            lstViewProducts.Columns.Add("ÜrünAdı");
            lstViewProducts.Columns.Add("Miktar Tipi");
            lstViewProducts.Columns.Add("Adet");
            foreach (var item in _wayBillDetails)
            {
                string[] subitems = { ((ProductQuantityPerUnit)item.Product.QuantityPerUnit).ToString(), item.Quantity.ToString() };
                ListViewItem lstItem = new ListViewItem(item.Product.ProductName);
                lstItem.SubItems.AddRange(subitems);
                lstItem.Tag = item;
                lstViewProducts.Items.Add(lstItem);
            }
        }
        private void ProductAddList()
        {
            _wayBill = cbxWayBillID.SelectedItem as WayBill;
            var sorgu = (from wd in SingletonDb.Context.WayBillDetails where wd.WaybillID == _wayBill.ID select wd).ToList();
            foreach (var item in sorgu)
            {
                _wayBillDetails.Add(item);
            }
        }


        private void BtnAdd_Click(object sender, EventArgs e)
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
            ProductList();

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            _wayBillDetails.Remove(lstViewProducts.SelectedItems[0].Tag as WayBillDetail);
            ProductList();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            #region Validation
            if (txtDescription.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Description alanı boş girilemez.");
                return;
            }
            #endregion
            var query = (from wd in SingletonDb.Context.WayBillDetails where wd.WaybillID == _wayBill.ID select wd).ToList();
            foreach (var item in query)
            {
                _wayBill.WayBillDetails.Remove(item);
            }
            _wayBill.DriverID = (Guid)cbxDriver.SelectedValue;
            _wayBill.VehicleID = (Guid)cbxVehicle.SelectedValue;
            _wayBill.SenderID = (Guid)cbxSender.SelectedValue;
            _wayBill.ReceiverID = (Guid)cbxReceiver.SelectedValue;
            _wayBill.ShipmentDate = dtpShipDate.Value;
            _wayBill.DeliveryDate = dtpDeliveryDate.Value;
            _wayBill.BillType = Convert.ToByte(cbxWaybillType.SelectedValue);
            foreach (var item in _wayBillDetails)
            {
                _wayBill.WayBillDetails.Add(item);

            }
            SingletonDb.Context.SaveChangesControll();
        }
    }
}
