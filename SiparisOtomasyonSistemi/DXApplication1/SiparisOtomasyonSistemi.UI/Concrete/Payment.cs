
namespace SiparisOtomasyonSistemi.UI
{
    public abstract class Payment
    {
        public int PaymentId { get; set; }
        public decimal Amount { get; set; }
        public abstract int PaymentMethod();
    }
}
