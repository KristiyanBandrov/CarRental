using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Infrastructure.Data
{
    public class CarCategory
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        [StringLength(50)]
        public string Label { get; set; }

        [Required]
        public decimal DailyRate { get; set; }

        [Required]
        public decimal WeeklyRate { get; set; }

        [Required]
        public decimal MonthlyRate { get; set; }

        public IList<Car> Cars { get; set; } = new List<Car>();
    }
}
