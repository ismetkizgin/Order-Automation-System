using SiparisOtomasyonSistemi.UI.Concrete;
using System;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SiparisOtomasyonSistemi.UI
{
    public partial class ProductForm : XtraForm
    {
        Product _productManager = new Product();
        private readonly Product _product;
        private readonly bool _statu = true;

        public ProductForm()
        {
            InitializeComponent();
        }

        public ProductForm(Product product)
        {
            _product = product;
            _statu = false;
            InitializeComponent();
        }

        private Product ItemGetData()
        {
            return new Product()
            {
                ProductId = _product != null ? _product.ProductId : 0,
                ProductName = txtProductName.Text,
                UnitPrice = Convert.ToDecimal(txtUnitPrice.Text)
            };

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            if (_statu)
            {
                this.Text = @"Ürün Ekle";
            }
            else
            {
                this.Text = @"Ürün Güncelleme";
                txtUnitPrice.Text = _product.UnitPrice.ToString(CultureInfo.InvariantCulture);
                txtProductName.Text = _product.ProductName;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtProductName.Text != string.Empty && txtUnitPrice.Text != string.Empty)
            {
                _productManager = ItemGetData();
                if (_statu)
                {
                    _productManager.Add();
                    this.Close();

                }
                else
                    _productManager.Update();
            }
            else
                XtraMessageBox.Show("Lütfen tüm alanları doğru doldurduğunuzdan emin olunuz.", "Hatalı Bilgi !",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCik_Click(object sender, EventArgs e) => this.Close();
    }
}