using System;
using System.Collections.Generic;
using System.Linq;

namespace SiparisOtomasyonSistemi.UI
{
    public partial class PaidDetailForm : DevExpress.XtraEditors.XtraForm
    {
        public PaidDetailForm(List<Payment> paymentList)
        {
            InitializeComponent();
            gcCashDetail.DataSource = paymentList.Where(x => x.PaymentMethod() == 2);
            gcCreditDetail.DataSource = paymentList.Where(x => x.PaymentMethod() == 0);
            gcCheckDetail.DataSource = paymentList.Where(x => x.PaymentMethod() == 1);
        }

        private void PaidDetailForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}