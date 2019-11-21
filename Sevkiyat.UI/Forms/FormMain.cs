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

namespace Sevkiyat.UI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void irsaliyeOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormWayBillAdd>();
        }

        private void urunEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormProductAdd>();
        }

        private void UrunListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormProductList>();
        }

        private void aracEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormVehicleAdd>();
        }

        private void aracListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormVehicleList>();
        }

        private void soforEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormDriverAdd>();
        }

        private void SoforListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormDriverList>();
        }

        private void musteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormPayerAdd>();
        }

        private void musteriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormPayersList>();
        }

        private void tsbKullaniciDegistir_Click(object sender, EventArgs e)
        {

            FormLogin frm = new FormLogin();
            frm.Show();
            this.Hide();

        }

        private void TsbCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KullaniciListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormUserList>();
        }

        private void KullaniciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormUserAdd>();
        }

        private void SifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormPasswordChange>();
        }

        private void İrsaliyeDetayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormWaybillDetails>();
        }

        private void İrsaliyeDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormWayBillUpdate>();
        }

        private void UserRoleControl()
        {
            int dummy=Session.FindRoleOrRoles();

            if (dummy == 1)
            {
                kullaniciEkleToolStripMenuItem.Visible = false;
                kullaniciListeleToolStripMenuItem.Visible = false;
            }
            else if (dummy == 0)
            {
                kullaniciEkleToolStripMenuItem.Visible = false;
                kullaniciListeleToolStripMenuItem.Visible = false;
                soforEkleToolStripMenuItem.Visible = false;
                aracEkleToolStripMenuItem.Visible = false;
                urunToolStripMenuItem.Visible = false;
                irsaliyeToolStripMenuItem.Visible = false;
                muhatapToolStripMenuItem.Visible = false;
            }
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            UserRoleControl();
        }
    }
}
