using DevExpress.XtraEditors;
using System;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.Utils;

namespace SiparisOtomasyonSistemi.UI
{
    public partial class PaymentForm : XtraForm
    {
        private Order _orderManager;
        decimal _totalpaid;
        public PaymentForm(Order order)
        {
            _orderManager = order;
            InitializeComponent();
            _orderManager.TotalAmountOperation();
            PaidTotal();
        }
        private void PaidTotal() =>
            txtKORemaining.Text = txtKKRemaining.Text = txtCORemaining.Text = (_orderManager.TotalAmount - _totalpaid).ToString(CultureInfo.InvariantCulture);

        private void btnCheckPayment_Click(object sender, EventArgs e)
        {
            decimal paid = Convert.ToDecimal(txtCheckPayment.Text);
            if (_orderManager.TotalAmount == _totalpaid)
            {
                XtraMessageBox.Show("Ödene bilecek bir tutar bulunmamaktadır.");
                return;
            }

            if ((_orderManager.TotalAmount - _totalpaid) - paid < 0)
            {
                XtraMessageBox.Show("Ödme işleminiz gerçekleşmiştir para üstü iade edildi");
                paid = _orderManager.TotalAmount - _totalpaid;
            }
            _orderManager.PaymentList.Add(new Check()
            {
                Bank = txtBank.Text,
                Branch = txtBranch.Text,
                CheckHolder = txtCheckHolder.Text,
                AccountNo = txtAccountNo.Text,
                Iban = txtIban.Text,
                CheckWhom = txtCheckWhom.Text,
                CheckDate = Convert.ToDateTime(txtCheckDate.Text),
                CheckNo = txtCheckNo.Text,
                Amount = Convert.ToDecimal(txtCheckPayment.Text)
            });
            _totalpaid += paid;
            PaidTotal();
            XtraMessageBox.Show("Ödeme işleminiz alınmıştır...", "Ödeme Tamamlandı", MessageBoxButtons.OK);
        }

        private void btnCashPayment_Click(object sender, EventArgs e)
        {
            decimal paid = Convert.ToDecimal(txtCashAmount.Text);
            if (_orderManager.TotalAmount == _totalpaid)
            {
                XtraMessageBox.Show("Ödene bilecek bir tutar bulunmamaktadır.");
                return;
            }
            
            if ((_orderManager.TotalAmount - _totalpaid) - paid < 0)
            {
                XtraMessageBox.Show("Ödme işleminiz gerçekleşmiştir para üstü iade edildi");
                paid = _orderManager.TotalAmount - _totalpaid;
            }
            _orderManager.PaymentList.Add(new Cash()
            {
                Amount = paid,
            });
            _totalpaid += paid;
            PaidTotal();
            XtraMessageBox.Show("Ödeme işleminiz alınmıştır...", "Ödeme Tamamlandı", MessageBoxButtons.OK);
        }

        private void btnCreditCartPayment_Click(object sender, EventArgs e)
        {
            decimal paid = Convert.ToDecimal(txtCreditCartPayment.Text);
            if (_orderManager.TotalAmount == _totalpaid)
            {
                XtraMessageBox.Show("Ödene bilecek bir tutar bulunmamaktadır.");
                return;
            }

            if ((_orderManager.TotalAmount - _totalpaid) - paid < 0)
            {
                XtraMessageBox.Show("Ödme işleminiz gerçekleşmiştir para üstü iade edildi");
                paid = _orderManager.TotalAmount - _totalpaid;
            }
            _orderManager.PaymentList.Add(new Credit()
            {
                CartType = txtCartType.Text,
                CartNo = txtCartNo.Text,
                CartMonth = Convert.ToInt32(txtMonth.Text),
                CartCvv = Convert.ToInt32(txtCvv.Text),
                CartYear = Convert.ToInt32(txtCartYear.Text),
                Amount = Convert.ToDecimal(txtCreditCartPayment.Text)
            });
            _totalpaid += paid;
            PaidTotal();
            XtraMessageBox.Show("Ödeme işleminiz alınmıştır...", "Ödeme Tamamlandı", MessageBoxButtons.OK);
        }

        private void btnOrderComplete_Click(object sender, EventArgs e)
        {
            if(_orderManager.TotalAmount == _totalpaid)
            {
                Costumer costumerManager = new Costumer();
                costumerManager.OrderAdd(_orderManager);
                XtraMessageBox.Show("Siparişiniz tamamlanmıştır.", "Tamamlandı", MessageBoxButtons.OK,
                    DefaultBoolean.True);
                _orderManager.OrderDetails.Clear();
                _orderManager.PaymentList.Clear();
                this.Close();
            }
        }
    }
}