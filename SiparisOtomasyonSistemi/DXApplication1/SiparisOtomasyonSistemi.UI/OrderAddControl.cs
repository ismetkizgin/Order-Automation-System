using SiparisOtomasyonSistemi.UI.Concrete;
using System;
using System.Linq;

namespace SiparisOtomasyonSistemi.UI
{
    public partial class OrderAddControl : DevExpress.XtraEditors.XtraUserControl
    {
        Order _orderManager = new Order();
        private static OrderAddControl _instanceOrderAdd;
        public static OrderAddControl InstanceOrderAdd
        {
            get
            {
                if (_instanceOrderAdd == null)
                    _instanceOrderAdd = new OrderAddControl();
                return _instanceOrderAdd;
            }
        }
        private void BasketListLoad() => gcBasketList.DataSource = _orderManager.OrderDetails.ToList();
        public OrderAddControl()
        {
            InitializeComponent();
        }

        private void OrderAddControl_Load(object sender, EventArgs e)
        {
            gcProductList.DataSource = _orderManager.ProductGetAllList();
            BasketListLoad();
        }

        private void gvProductList_DoubleClick(object sender, EventArgs e)
        {
            Product productItem = new Product()
            {
                ProductId = Convert.ToInt32(gvProductList.GetRowCellValue(gvProductList.FocusedRowHandle, "ProductId")),
                ProductName = gvProductList.GetRowCellValue(gvProductList.FocusedRowHandle, "ProductName").ToString(),
                UnitPrice = Convert.ToDecimal(gvProductList.GetRowCellValue(gvProductList.FocusedRowHandle, "UnitPrice"))
            };
            

            bool state = true;
            foreach (var item in _orderManager.OrderDetails)
                if (productItem.ProductId == item.ProductId)
                {
                    state = false;
                    item.Quantity += 1;
                }

            if (state)
            {
                OrderDetail orderDetailItem = new OrderDetail()
                {
                    Quantity = 1,
                    ProductId = productItem.ProductId,
                    Product = productItem
                };
                _orderManager.OrderDetails.Add(orderDetailItem);
            }
            BasketListLoad();
        }

        private void cbtnRefresh_Click(object sender, EventArgs e) => BasketListLoad();

        private void cbtnComplateOrder_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm(_orderManager);
            addressForm.ShowDialog();
            BasketListLoad();
        }

        private void cbtnDelete_Click(object sender, EventArgs e)
        {
            _orderManager.OrderDetails.RemoveAll(x =>
                x.ProductId ==
                Convert.ToInt32(gvBasketList.GetRowCellValue(gvBasketList.FocusedRowHandle, "ProductId")));
            BasketListLoad();
        }
    }
}