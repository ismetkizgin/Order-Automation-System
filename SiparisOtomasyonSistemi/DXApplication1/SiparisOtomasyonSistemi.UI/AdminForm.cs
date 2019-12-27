using System;
using System.Windows.Forms;

namespace SiparisOtomasyonSistemi.UI
{
    public partial class AdminForm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public static int UserId;
        private readonly bool _state;
        public AdminForm(int userId, bool state)
        {
            UserId = userId;
            this._state = state;
            InitializeComponent();
            btndProductOparation.Visible = state;
            btndUserOparation.Visible = state;
            btndOrderOperation.Visible = !(state);
            btnOrderAllList.Visible = state;
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e) =>
            Application.Exit();

        private void btnAccount_Click(object sender, EventArgs e)
        {
            UserForm customerForm = new UserForm(UserId, _state);
            customerForm.ShowDialog();
        }

        private void btnItemList_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ProductListControl.InstanceProductList))
            {
                container.Controls.Add(ProductListControl.InstanceProductList);
                ProductListControl.InstanceProductList.Dock = DockStyle.Fill;
            }
            ProductListControl.InstanceProductList.BringToFront();
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
        }

        private void btnCostumerList_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(CustomerListControl.InstanceCustomertList))
            {
                container.Controls.Add(CustomerListControl.InstanceCustomertList);
                CustomerListControl.InstanceCustomertList.Dock = DockStyle.Fill;
            }
            CustomerListControl.InstanceCustomertList.BringToFront();
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(false);
            userForm.ShowDialog();
        }

        private void btnAdminAdd_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(true);
            userForm.ShowDialog();
        }

        private void btnAdminList_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(AdminListControl.InstanceAdmintList))
            {
                container.Controls.Add(AdminListControl.InstanceAdmintList);
                AdminListControl.InstanceAdmintList.Dock = DockStyle.Fill;
            }
            AdminListControl.InstanceAdmintList.BringToFront();
        }

        private void btnOrderAllList_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(OrderListControl.InstanceOrderList))
            {
                container.Controls.Add(OrderListControl.InstanceOrderList);
                OrderListControl.InstanceOrderList.Dock = DockStyle.Fill;
            }
            OrderListControl.InstanceOrderList.BringToFront();
        }

        private void btnOrderAdd_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(OrderAddControl.InstanceOrderAdd))
            {
                container.Controls.Add(OrderAddControl.InstanceOrderAdd);
                OrderAddControl.InstanceOrderAdd.Dock = DockStyle.Fill;
            }
            OrderAddControl.InstanceOrderAdd.BringToFront();
        }

        private void btnMyOrderList_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(MyOrderListControl.InstanceMyOrderList))
            {
                container.Controls.Add(MyOrderListControl.InstanceMyOrderList);
                MyOrderListControl.InstanceMyOrderList.Dock = DockStyle.Fill;
            }
            MyOrderListControl.InstanceMyOrderList.BringToFront();
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) => Application.Exit();

        private void btnRestart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) =>
            Application.Restart();
    }
}