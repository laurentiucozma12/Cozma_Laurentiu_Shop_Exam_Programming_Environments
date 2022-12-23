namespace PlanteeaShop.Models
{
    public class ProductOrigin
    {
        public int ID { get; set; }

        public string OriginName { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
