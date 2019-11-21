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
    public partial class FormProductAdd : Form
    {
        public static event EventHandler AddProductEvent;
        public FormProductAdd()
        {
            InitializeComponent();
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            AddProduct();
        }

        private void AddProduct()
        {
            #region Validation
                if(txtProductName.Text.Trim()==string.Empty 
                || txtWeight.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ürün adı ve ağırlık bos gecilemez..");
                return;
            }
            #endregion
            Product product = new Product()
            {
                ID = Guid.NewGuid(),
                ProductName = txtProductName.Text,
                ProductType = Convert.ToByte(cbxProductType.SelectedValue),
                Weigh = Convert.ToInt32(txtWeight.Text),
                QuantityPerUnit = Convert.ToByte(cbxProductQuantityPerUnit.SelectedValue),
                IsDeleted = false,
                IsActive=true
                
            };
            SingletonDb.Context.Products.Add(product);
            SingletonDb.Context.SaveChangesControll(AddProductEvent);
        }

        private void FormProductAdd_Load(object sender, EventArgs e)
        {
            cbxProductType.LoadEnum<ProductType>();
            cbxProductQuantityPerUnit.LoadEnum<ProductQuantityPerUnit>();
        }
    }
}
