namespace ecom_backend.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public int Amount { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
