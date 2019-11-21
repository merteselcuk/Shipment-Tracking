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
    public partial class FormVehicleAdd : Form
    {
        public static event EventHandler AddVehicleEvent;
        public FormVehicleAdd()
        {
            InitializeComponent();

        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddVehicle();

        }
        private void AddVehicle()
        {
            #region Validation
                if(txtPlate.Text.Trim()==string.Empty
                || txtModel.Text.Trim()==string.Empty
                || txtBrand.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Plaka,model ve marka boş geçilemez..");
                return;
            }
            #endregion
            Vehicle vehicle = new Vehicle()
            {
                ID = Guid.NewGuid(),
                Plate = txtPlate.Text,
                Capacity = (int)nudCapacity.Value,
                Brand = txtBrand.Text,
                Model = txtModel.Text,
                IsDeleted = false,
                IsActive = true

            };
            SingletonDb.Context.Vehicles.Add(vehicle);
            SingletonDb.Context.SaveChangesControll(AddVehicleEvent);
        }
    }
}
