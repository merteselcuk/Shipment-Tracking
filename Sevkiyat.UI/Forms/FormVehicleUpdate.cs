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
    public partial class FormVehicleUpdate : Form
    {
        public static event EventHandler UpdateVehicleEvent;
        Vehicle _vehicle;
        public FormVehicleUpdate(Vehicle vehicle)
        {
            InitializeComponent();
            _vehicle = vehicle;
        }

        private void FormVehicleUpdate_Load(object sender, EventArgs e)
        {
            LoadVehicleInformation();
        }

        private void LoadVehicleInformation()
        {
            txtPlate.Text = _vehicle.Plate;
            txtBrand.Text = _vehicle.Brand;
            txtModel.Text = _vehicle.Model;
            nudCapacity.Value = _vehicle.Capacity;
            chxActive.Checked = (bool)_vehicle.IsActive;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            UpdateVehicle();
        }

        private void UpdateVehicle()
        {
            #region Validation
            if (txtPlate.Text.Trim() == string.Empty
            || txtModel.Text.Trim() == string.Empty
            || txtBrand.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Plaka,model ve marka boş geçilemez..");
                return;
            }
            #endregion
            _vehicle = (from v in SingletonDb.Context.Vehicles where v.ID == _vehicle.ID select v).SingleOrDefault();
            _vehicle.Plate = txtPlate.Text;
            _vehicle.Brand = txtBrand.Text;
            _vehicle.Model = txtModel.Text;
            _vehicle.Capacity = Convert.ToInt32(nudCapacity.Value);
            _vehicle.IsActive = chxActive.Checked;
            SingletonDb.Context.SaveChangesControll(UpdateVehicleEvent);
        }
    }
}
