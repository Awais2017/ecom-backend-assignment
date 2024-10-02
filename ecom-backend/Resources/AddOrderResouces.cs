using System.ComponentModel.DataAnnotations;

namespace ecom_backend.Resources
{
    public class AddOrderResouces
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public int NoOfItems { get; set; }
        [Required]
        public string Category { get; set; }
    }
}
