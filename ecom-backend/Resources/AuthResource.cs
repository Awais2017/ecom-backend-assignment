using System.ComponentModel.DataAnnotations;

namespace ecom_backend.Resources
{
    public class AuthResource
    {
        [Required]
        public required String Email { get; set; }
        [Required]
        public required String Password { get; set; }

        [Required]
        public required int Role { get; set; }
    }
}
