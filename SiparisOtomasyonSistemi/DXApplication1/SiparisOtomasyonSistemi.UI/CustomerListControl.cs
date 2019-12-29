using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace SiparisOtomasyonSistemi.UI
{
    public partial class CustomerListControl : XtraUserControl
    {
        Costumer _costumerManager = new Costumer();
        private static CustomerListControl _instanceCustomerList;
        public static CustomerListControl InstanceCustomertList
        {
            get
            {
                if (_instanceCustomerList == null)
                    _instanceCustomerList = new CustomerListControl();
                return _instanceCustomerList;
            }
        }
        public CustomerListControl()
        {
            InitializeComponent();
        }

        public void CostumerListLoad() =>
            gcCustomerList.DataSource = _costumerManager.GetList();

        private void CustomerListControl_Load(object sender, EventArgs e) => CostumerListLoad();

        private void cbtnRefresh_Click(object sender, EventArgs e) => CostumerListLoad();

        private void cbtnUpdate_Click(object sender, EventArgs e)
        {
            int customerId = Convert.ToInt32(gvCustomerList.GetRowCellValue(gvCustomerList.FocusedRowHandle, "CostumerId"));
            UserForm userForm = new UserForm(customerId,false);
            userForm.ShowDialog();
            CostumerListLoad();
        }

        private void cbtnDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Müşteriyi silmek istediğinizden emin misiniz...", "Müşteri Silme İşlemi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _costumerManager.Delete(
                    Convert.ToInt32(gvCustomerList.GetRowCellValue(gvCustomerList.FocusedRowHandle, "CostumerId")));
                CostumerListLoad();
            }
        }

        private void cbtnAdd_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(false);
            userForm.ShowDialog();
            CostumerListLoad();
        }
    }
}