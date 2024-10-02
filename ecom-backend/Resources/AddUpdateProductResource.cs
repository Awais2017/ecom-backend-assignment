using System.ComponentModel.DataAnnotations;

namespace ecom_backend.Resources
{
    public class AddUpdateProductResource
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
