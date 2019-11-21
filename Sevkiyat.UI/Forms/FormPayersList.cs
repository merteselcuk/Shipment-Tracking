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
    public partial class FormPayersList : Form
    {
        public static event EventHandler DeletePayerEvent;
        public FormPayersList()
        {
            InitializeComponent();
            Load += LoadPayers;
            FormPayerAdd.AddPayerEvent += LoadPayers;
            FormPayersUpdate.UpdatePayerEvent += LoadPayers;
            DeletePayerEvent += LoadPayers;
        }

        private void btnAddForm_Click(object sender, EventArgs e)
        {
            this.MdiBroShow<FormPayerAdd>();
        }
        private void LoadPayers(object sender, EventArgs e)
        {
            lstPayer.Yukle<Payer>(SingletonDb.Context, "CompanyName", "ID", p => p.IsDeleted == false);
            UserRoleControl();
        }
        private void BtnUpdateForm_Click(object sender, EventArgs e)
        {
            Payer payer = lstPayer.SelectedItem as Payer;
            this.MdiBroShow<FormPayersUpdate, Payer>(payer);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Payer payer = SingletonDb.Context.Payers.Find((lstPayer.SelectedItem as Payer));
            payer.IsDeleted = true;
            SingletonDb.Context.SaveChangesControll(DeletePayerEvent);
        }
        private void UserRoleControl()
        {
            int dummy = Session.FindRoleOrRoles();

            if (dummy == 1)
            {
                btnAddForm.Visible = false;
                btnUpdateForm.Visible = false;
                btnDelete.Visible = false;
            }
        }
    }
}
