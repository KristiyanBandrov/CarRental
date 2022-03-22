using System.ComponentModel.DataAnnotations;

namespace CarRental.Infrastructure.Data
{
    public class Client
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string LicenseNumber { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [Required]
        [StringLength(100)]
        public string City { get; set; }

        [StringLength(400)]
        public string Notes { get; set; }
    }
}
