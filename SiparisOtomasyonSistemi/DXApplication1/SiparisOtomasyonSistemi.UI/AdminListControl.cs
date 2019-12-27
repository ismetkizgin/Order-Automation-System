using DevExpress.XtraEditors;
using SiparisOtomasyonSistemi.UI.Concrete;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SiparisOtomasyonSistemi.UI
{
    public partial class AdminListControl : XtraUserControl
    {
        Admin _adminManager = new Admin();
        private static AdminListControl _instanceAdminList;
        public static AdminListControl InstanceAdmintList
        {
            get
            {
                if (_instanceAdminList == null)
                    _instanceAdminList = new AdminListControl();
                return _instanceAdminList;
            }
        }
        public AdminListControl()
        {
            InitializeComponent();
        }

        public void AdminListLoad() =>
            gcAdminList.DataSource = _adminManager.GetList().Where(x => x.AdminId != AdminForm.UserId);

        private void AdminListControl_Load(object sender, EventArgs e) => AdminListLoad();

        private void cbtnRefresh_Click(object sender, EventArgs e) => AdminListLoad();

        private void cbtnUpdate_Click(object sender, EventArgs e)
        {
            int adminId = Convert.ToInt32(gvAdminList.GetRowCellValue(gvAdminList.FocusedRowHandle, "AdminId"));
            UserForm userForm = new UserForm(adminId, true);
            userForm.ShowDialog();
            AdminListLoad();
        }

        private void cbtnAdd_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(true);
            userForm.ShowDialog();
            AdminListLoad();
        }

        private void cbtnDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Admini silmek istediğinizden emin misiniz...", "Admin Silme İşlemi",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _adminManager.Delete(
                    Convert.ToInt32(gvAdminList.GetRowCellValue(gvAdminList.FocusedRowHandle, "AdminId")));
                AdminListLoad();
            }
        }
    }
}