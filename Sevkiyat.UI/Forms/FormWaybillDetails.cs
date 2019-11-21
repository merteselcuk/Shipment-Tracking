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

namespace Sevkiyat.UI.Forms
{
    public partial class FormWaybillDetails : Form
    {
        WayBill _wayBill;
        public FormWaybillDetails()
        {
            InitializeComponent();
            _wayBill = new WayBill();
        }
        private void FormWaybillDetails_Load(object sender, EventArgs e)
        {
            cbxWayBillSelect.Yukle<WayBill>(SingletonDb.Context,"ID", "ID");
        }
        private void CbxWayBillSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadWaybillInfortmation();
        }
        private void ReceiverDetail()
        {
            _wayBill = cbxWayBillSelect.SelectedItem as WayBill;
            lblReceiverContact.Text = (from p in SingletonDb.Context.Payers where p.ID==_wayBill.ReceiverID select p.ContactName).SingleOrDefault();
            lblReceiverPhone.Text = (from p in SingletonDb.Context.Payers where p.ID == _wayBill.ReceiverID select p.Phone).SingleOrDefault();
            lblReceiverAddress.Text = (from p in SingletonDb.Context.Payers where p.ID == _wayBill.ReceiverID select p.Address).SingleOrDefault();
        }

        private void SenderDetail()
        {
            _wayBill = cbxWayBillSelect.SelectedItem as WayBill;
            lblSenderContact.Text = (from p in SingletonDb.Context.Payers where p.ID == _wayBill.SenderID select p.ContactName).SingleOrDefault();
            lblSenderPhone.Text = (from p in SingletonDb.Context.Payers where p.ID == _wayBill.SenderID select p.Phone).SingleOrDefault();
            lblSenderAddress.Text = (from p in SingletonDb.Context.Payers where p.ID == _wayBill.SenderID select p.Address).SingleOrDefault();
        }
        private void LoadWaybillInfortmation()
        {
            _wayBill = cbxWayBillSelect.SelectedItem as WayBill;
            lblBillType.Text = ((WayBillType)_wayBill.BillType).ToString();
            lblSender.Text = SingletonDb.Context.Payers.Where(p => p.ID == _wayBill.SenderID)
                .Select(p => p.CompanyName)
                .SingleOrDefault();
            lblReceiver.Text = (from py in SingletonDb.Context.Payers
                                where py.ID == _wayBill.ReceiverID
                                select py.CompanyName)
                                .SingleOrDefault();
            lblShipmentDate.Text = _wayBill.ShipmentDate.ToString();
            lblDeliveryDate.Text = _wayBill.DeliveryDate.ToString();
            lblDriver.Text = (from d in SingletonDb.Context.Drivers
                              where d.ID == _wayBill.DriverID
                              select d.FirstName)
                              .SingleOrDefault();
            lblVehicle.Text = (from v in SingletonDb.Context.Vehicles
                               where v.ID == _wayBill.VehicleID
                               select v.Plate)
                               .SingleOrDefault();
            SenderDetail();
            ReceiverDetail();
            ProductList();
        }
        private void ProductList()
        {
            _wayBill = cbxWayBillSelect.SelectedItem as WayBill;
            var sorgu = (from wd in SingletonDb.Context.WayBillDetails
                         join p in SingletonDb.Context.Products
                         on wd.ProductID equals p.ID
                         where wd.WaybillID == _wayBill.ID
                         select new { p.ProductName, wd.Quantity, p.QuantityPerUnit })
                                     .ToList();

            lstViewProducts.Clear();
            lstViewProducts.Columns.Add("ÜrünAdı");
            lstViewProducts.Columns.Add("Miktar Tipi");
            lstViewProducts.Columns.Add("Adet");
            foreach (var item in sorgu)
            {
                ListView liv = new ListView();
                string[] subitems = { ((ProductQuantityPerUnit)item.QuantityPerUnit).ToString(), item.Quantity.ToString() };
                lstViewProducts.Items.Add(item.ProductName).SubItems.AddRange(subitems);
            }
        }
    }
}
