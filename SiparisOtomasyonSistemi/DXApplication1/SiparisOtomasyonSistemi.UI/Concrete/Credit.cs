
namespace SiparisOtomasyonSistemi.UI
{
    public class Credit : Payment
    {
        public int CreditId { get; set; }
        public string CartType { get; set; }
        public string CartNo { get; set; }
        public int CartMonth { get; set; }
        public int CartYear { get; set; }
        public int CartCvv { get; set; }
        public override int PaymentMethod()
        {
            return 0;
        }
    }
}
