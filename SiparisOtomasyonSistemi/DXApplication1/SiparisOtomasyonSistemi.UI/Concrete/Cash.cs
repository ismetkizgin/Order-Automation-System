
namespace SiparisOtomasyonSistemi.UI
{
    public class Cash:Payment
    {
        public int CashId { get; set; }

        public override int PaymentMethod()
        {
            return 2;
        }
    }
}