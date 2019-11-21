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
    
    public partial class FormProductUpdate : Form
    {
        public static event EventHandler UpdateProductEvent;
        Product _product;
        public FormProductUpdate(Product product)
        {
            InitializeComponent();
            _product = product;
        }

        private void FormProductUpdate_Load(object sender, EventArgs e)
        {
            LoadProductInformation();
        }

        private void LoadProductInformation()
        {
            txtProductName.Text = _product.ProductName;
            cbxProductType.LoadEnum<ProductType>();
            cbxProductType.SelectedIndex = _product.ProductType - 1;
            txtWeight.Text = _product.Weigh.ToString();
            cbxProductQuantityPerUnit.LoadEnum<ProductQuantityPerUnit>();
            cbxProductQuantityPerUnit.SelectedIndex = _product.QuantityPerUnit - 1;
            chxActive.Checked = (bool)_product.IsActive;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            UpdateProduct();
        }

        private void UpdateProduct()
        {
            #region Validation
            if (txtProductName.Text.Trim() == string.Empty
            || txtWeight.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Ürün adı ve ağırlık bos gecilemez..");
            }
            #endregion
            _product = (from p in SingletonDb.Context.Products where p.ID == _product.ID select p).SingleOrDefault();
            _product.ProductName = txtProductName.Text;
            _product.ProductType = Convert.ToByte(cbxProductType.SelectedValue);
            _product.Weigh = Convert.ToInt32(txtWeight.Text);
            _product.QuantityPerUnit = Convert.ToByte(cbxProductQuantityPerUnit.SelectedValue);
            _product.IsActive = chxActive.Checked;
            SingletonDb.Context.SaveChangesControll(UpdateProductEvent);
        }
    }
}
