namespace SiparisOtomasyonSistemi.UI.Concrete
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public Product Product { get; set; }
        public decimal Total
        {
            get { return Product.UnitPrice * Quantity; }
        }
    }
}