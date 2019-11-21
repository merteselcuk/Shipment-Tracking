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
    public partial class FormProductList : Form
    {
        public static event EventHandler DeleteProductEvent;
        public FormProductList()
        {
            InitializeComponent();
            Load += LoadProduct;
            FormProductAdd.AddProductEvent += LoadProduct;
            FormProductUpdate.UpdateProductEvent += LoadProduct;
            DeleteProductEvent += LoadProduct;

        }

        private void LoadProduct(object sender, EventArgs e)
        {
            lstProduct.Yukle<Product>(SingletonDb.Context, "ProductName", "ID", p => p.IsDeleted == false);
        }

        private void BtnProductAdd_Click(object sender, EventArgs e)
        {
            this.MdiBroShow<FormProductAdd>();
        }

        private void BtnProductUpdate_Click(object sender, EventArgs e)
        {
            Product product = lstProduct.SelectedItem as Product;
            this.MdiBroShow<FormProductUpdate, Product>(product);
        }

        private void BtnProductDelete_Click(object sender, EventArgs e)
        {
            Product product = lstProduct.SelectedItem as Product;
            product.IsDeleted = true;
            SingletonDb.Context.SaveChangesControll(DeleteProductEvent);
        }
    }
}
