using Sevkiyat.UI.Forms;
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
    public partial class FormVehicleList : Form
    {
        public static event EventHandler DeleteVehicleEvent;
        public FormVehicleList()
        {
            InitializeComponent();
            Load += LoadVehicle;
            FormVehicleAdd.AddVehicleEvent += LoadVehicle;
            FormVehicleUpdate.UpdateVehicleEvent += LoadVehicle;
            DeleteVehicleEvent += LoadVehicle;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.MdiBroShow<FormVehicleAdd>();
        }
        
        private void LoadVehicle(object sender,EventArgs e)
        {
            lstVehicles.Yukle<Vehicle>(SingletonDb.Context, "Plate", "ID", v => v.IsDeleted == false);
            UserRoleControl();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = lstVehicles.SelectedItem as Vehicle;
            this.MdiBroShow<FormVehicleUpdate, Vehicle>(vehicle);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = lstVehicles.SelectedItem as Vehicle;
            vehicle.IsDeleted = true;
            SingletonDb.Context.SaveChangesControll(DeleteVehicleEvent);
        }
        private void UserRoleControl()
        {
            int dummy = Session.FindRoleOrRoles();

            if (dummy == 0)
            {
                btnAdd.Visible = false;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
            }
        }
    }
}
