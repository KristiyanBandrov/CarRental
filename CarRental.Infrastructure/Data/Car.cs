using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Data
{
    public class Car
    {
        [Key]
        public Guid MyProperty { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(50)]
        public string Model { get; set; }

        [Required]
        [StringLength(50)]
        public string Make { get; set; }

        [Required]
        [StringLength(20)]
        public string PlateNumber { get; set; }

        [Required]
        public DateTime CarYear { get; set; }

        [Required]
        public Guid CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public CarCategory Category { get; set; }

        [StringLength(400)]
        public string Description { get; set; }

        public IList<Reservation> Reservations { get; set; } = new List<Reservation>();
    }
}
