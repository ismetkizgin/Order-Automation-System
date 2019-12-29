using System;
using System.Collections.Generic;
using System.Linq;

namespace SiparisOtomasyonSistemi.UI
{
    public partial class MyOrderListControl : DevExpress.XtraEditors.XtraUserControl
    {
        Costumer _costumerManager = new Costumer();
        private static MyOrderListControl _instanceMyOrderList;
        public static MyOrderListControl InstanceMyOrderList
        {
            get
            {
                if (_instanceMyOrderList == null)
                    _instanceMyOrderList = new MyOrderListControl();
                return _instanceMyOrderList;
            }
        }
        private List<Order> OrderData
        {
            get
            {
                return _costumerManager.OrderGetAllList();
            }
        }
        public MyOrderListControl()
        {
            InitializeComponent();
            OrderListLoad();
        }
        private void OrderListLoad() =>
            gcOrderList.DataSource = OrderData.Where(x => x.CostumerId == MainForm.UserId);
        private void cbtnRefresh_Click(object sender, EventArgs e) => OrderListLoad();

        private void gvOrderList_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int orderId = Convert.ToInt32(gvOrderList.GetRowCellValue(gvOrderList.FocusedRowHandle, "OrderId"));
            gcOrderDetailList.DataSource = OrderData.FirstOrDefault(x => x.OrderId == orderId)?.OrderDetails;
        }

        private void cbtnPaidDetail_Click(object sender, EventArgs e)
        {
            PaidDetailForm paidDetailForm = new PaidDetailForm(OrderData.FirstOrDefault(x => x.OrderId == Convert.ToInt32(gvOrderList.GetRowCellValue(gvOrderList.FocusedRowHandle, "OrderId")))?.PaymentList);
            paidDetailForm.ShowDialog();
        }
    }
}