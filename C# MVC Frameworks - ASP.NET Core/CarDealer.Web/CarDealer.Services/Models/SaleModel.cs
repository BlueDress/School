namespace CarDealer.Services.Models
{
    public class SaleModel
    {
        public CarWithPartsModel CarWithParts { get; set; }

        public OrderedCustomersModel Customer { get; set; }

        public decimal FullPrice { get; set; }

        public decimal PriceWithDiscount { get; set; }

        public int Discount { get; set; }
    }
}
