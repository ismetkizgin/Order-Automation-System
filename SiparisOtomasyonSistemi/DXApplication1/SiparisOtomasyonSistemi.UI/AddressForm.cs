using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SiparisOtomasyonSistemi.UI
{
    public partial class AddressForm : XtraForm
    {
        private Order _orderManager;
        public AddressForm(Order order)
        {
            _orderManager = order;
            InitializeComponent();
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
            }
        }
    }
}