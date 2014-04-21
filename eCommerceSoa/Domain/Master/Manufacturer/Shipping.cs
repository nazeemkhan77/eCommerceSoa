namespace eCommerceSoa.Domain.Master.Manufacturer
{
    public class Shipping
    {
        public Manufacturer Manufacturer { get; set; }

        public long ShippingId { get; set; }
        public string Name { get; set; }
        public decimal Rate { get; set; }

        //ups or usps or fedex
    }
}