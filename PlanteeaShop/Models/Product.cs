namespace Shop.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int? SellerID { get; set; }
        public Seller? Seller { get; set; }

        public int? ProductOriginID { get; set; }
        public ProductOrigin? ProductOrigin { get; set; }
    }
}
