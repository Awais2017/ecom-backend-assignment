using System.ComponentModel.DataAnnotations;

namespace ecom_backend.Models
{
    public class Category
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public  string Name { get; set; }
        [MaxLength(100)]
        public string Description { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }
    }
}
