using System.ComponentModel.DataAnnotations;

namespace ecom_backend.Resources
{
    public class CategoryResource
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public required string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
    }
}
