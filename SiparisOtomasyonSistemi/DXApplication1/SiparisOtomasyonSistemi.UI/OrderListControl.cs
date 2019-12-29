using System;
using System.Collections.Generic;
using System.Deployment.Application;
using System.Linq;

namespace SiparisOtomasyonSistemi.UI
{
    public partial class OrderListControl : DevExpress.XtraEditors.XtraUserControl
    {
        Costumer _costumerManager = new Costumer();
        private static OrderListControl _instanceOrderList;
        public static OrderListControl InstanceOrderList
        {
            get
            {
                if (_instanceOrderList == null)
                    _instanceOrderList = new OrderListControl();
                return _instanceOrderList;
            }
        }
        private List<Order> OrderData
        {
            get
            {
                return _costumerManager.OrderGetAllList();
            }
        }

        public OrderListControl()
        {
            InitializeComponent();
        }

        private void OrderListLoad() =>
            gcOrderList.DataSource = OrderData;

        private void OrderListControl_Load(object sender, EventArgs e) => OrderListLoad();

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

        private void cbtnDelete_Click(object sender, EventArgs e) =>
            _costumerManager.OrderDelete(Convert.ToInt32(gvOrderList.GetRowCellValue(gvOrderList.FocusedRowHandle, "OrderId")));

        private void OrderStateUpdate(string state)
        {
            _costumerManager.OrderStateUpdate(
                Convert.ToInt32(gvOrderList.GetRowCellValue(gvOrderList.FocusedRowHandle, "OrderId")),
                state);
            OrderListLoad();
        }

        private void cST_Click(object sender, EventArgs e) => OrderStateUpdate("Sipariş Tamamlandı");

        private void cK_Click(object sender, EventArgs e) => OrderStateUpdate("Kargo da");

        private void cHA_Click(object sender, EventArgs e) => OrderStateUpdate("Hazırlık Aşamasında");

        private void cOB_Click(object sender, EventArgs e) => OrderStateUpdate("Onay Bekliyor");
    }
}