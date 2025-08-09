using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaniaAPI.Domain.Entities
{
    public class Country
    {
        [Key]
        public Guid Id { get; set; }

        [Column(TypeName = "varchar(75)")]
        public string Name { get; set; } = string.Empty;
        public ICollection<Region>? Regions { get; set; } = new List<Region>();

        // Auto-generated timestamps
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
