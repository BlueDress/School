namespace CarDealer.Services.Models
{
    public class ViewSaleModel
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public int CarId { get; set; }

        public string CarMakeModel { get; set; }

        public string Discount { get; set; }

        public decimal Price { get; set; }

        public decimal FinalPrice { get; set; }
    }
}
