using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using SiparisOtomasyonSistemi.UI.Concrete;

namespace SiparisOtomasyonSistemi.UI
{
    public partial class ProductListControl : XtraUserControl
    {
        Product productManager = new Product();
        private static ProductListControl _instanceProductList;
        public static ProductListControl InstanceProductList
        {
            get
            {
                if (_instanceProductList == null)
                    _instanceProductList = new ProductListControl();
                return _instanceProductList;
            }
        }

        public ProductListControl()
        {
            InitializeComponent();
        }

        private void ProductListLoad() =>
            gcProductList.DataSource = productManager.GetList();

        private void ProductListControl_Load(object sender, EventArgs e) =>
            ProductListLoad();

        private void cbtnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                ProductId = Convert.ToInt32(gvProductList.GetRowCellValue(gvProductList.FocusedRowHandle, "ProductId")),
                ProductName = gvProductList.GetRowCellValue(gvProductList.FocusedRowHandle, "ProductName").ToString(),
                UnitPrice = Convert.ToDecimal(gvProductList.GetRowCellValue(gvProductList.FocusedRowHandle, "UnitPrice"))
            };
            ProductForm productForm = new ProductForm(product);
            productForm.ShowDialog();
            ProductListLoad();
        }

        private void cbtnDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Ürünü silmek istediğinizden emin misiniz...", "Ürünü Silme İşlemi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                productManager.Delete(
                      Convert.ToInt32(gvProductList.GetRowCellValue(gvProductList.FocusedRowHandle, "ProductId")));
                ProductListLoad();
            }
        }

        private void cbtnRefresh_Click(object sender, EventArgs e) => ProductListLoad();

        private void cbtnAdd_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
            ProductListLoad();
        }
    }
}