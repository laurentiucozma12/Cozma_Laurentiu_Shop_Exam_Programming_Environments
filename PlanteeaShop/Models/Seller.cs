namespace PlanteeaShop.Models
{
    public class Seller
    {
        public int ID { get; set; }
        public string SellerName { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
