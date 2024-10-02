using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;

namespace ecom_backend.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public string OrderId { get; set; }
        public int Amount { get; set; }

        public int Quanitity { get; set; }

        public DateTime OrderDate { get; set; }
    }
}
