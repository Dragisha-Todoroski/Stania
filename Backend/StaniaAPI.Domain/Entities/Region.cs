using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaniaAPI.Domain.Entities
{
    public class Region
    {
        [Key]
        public Guid Id { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Name { get; set; } = string.Empty;
        public Guid CountryId { get; set; }

        [ForeignKey(nameof(CountryId))]
        public Country? Country { get; set; }
        public ICollection<RentalUnit>? RentalUnits { get; set; } = new List<RentalUnit>();

        // Auto-generated timestamps
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
