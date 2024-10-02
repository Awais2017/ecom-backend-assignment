using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;

namespace ecom_backend.Resources
{
    public class GetAllProducts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public int Quantity { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }
    }
}
