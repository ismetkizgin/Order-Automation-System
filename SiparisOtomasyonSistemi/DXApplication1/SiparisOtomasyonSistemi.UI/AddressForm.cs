using System;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SiparisOtomasyonSistemi.UI
{
    public partial class AddressForm : XtraForm
    {
        private Order _orderManager;
        public AddressForm(Order order)
        {
            Costumer costumer = new Costumer();
            _orderManager = order;
            costumer = costumer.CostumerGet(AdminForm.UserId);
            _orderManager.OwnerName = string.Format("{0} {1}", costumer.FirstName, costumer.LastName);
            InitializeComponent();
            lblOrderDate.Text = DateTime.Now.Date.ToString("d");
            lblOwnerName.Text = _orderManager.OwnerName;
            _orderManager.TotalAmountOperation();
            lblTotalAmount.Text = _orderManager.TotalAmount.ToString(CultureInfo.InvariantCulture);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text == string.Empty)
                XtraMessageBox.Show("Lütfen adress bilginizi giriniz...", "Bilgi Eksik!", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            else
            {
                _orderManager.Address = txtAddress.Text;
                PaymentForm paymentForm = new PaymentForm(_orderManager);
                paymentForm.ShowDialog();
                this.Close();
            }
        }

        private void btnClose_Click(object sender, EventArgs e) =>
            this.Close();
    }
}