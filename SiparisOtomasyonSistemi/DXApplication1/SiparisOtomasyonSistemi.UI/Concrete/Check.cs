using System;

namespace SiparisOtomasyonSistemi.UI
{
    public class Check:Payment
    {
        public int CheckId { get; set; }
        public string Bank { get; set; }
        public string Branch { get; set; }
        public string CheckHolder { get; set; }
        public string AccountNo { get; set; }
        public string Iban { get; set; }
        public string CheckWhom { get; set; }
        public DateTime CheckDate { get; set; }
        public string CheckNo { get; set; }
        public override int PaymentMethod()
        {
            return 1;
        }
    }
}