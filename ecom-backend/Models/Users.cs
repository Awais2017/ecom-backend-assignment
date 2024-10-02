using System.ComponentModel.DataAnnotations;

namespace ecom_backend.Models
{
    public class Users
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(100)]
        public string Password { get; set; }
        [Required]
        [StringLength(50)]
        public int RoleId { get; set; }

    }
}
