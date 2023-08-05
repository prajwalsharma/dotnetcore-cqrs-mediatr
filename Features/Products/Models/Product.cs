namespace CQRSMediatRDemo.Features.Products.Models
{
    public class Product
    {
        public Product(Guid id, string name, string category, int quantity)
        {
            Id = id;
            Name = name;
            Category = category;
            Quantity = quantity;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
    }
}