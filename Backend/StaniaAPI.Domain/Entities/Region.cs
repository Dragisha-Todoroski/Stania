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

        [Required(ErrorMessage = "{0} is required.")]
        [MinLength(1, ErrorMessage = "{0} must not be empty.")]
        [Column(TypeName = "varchar(100)")]
        [StringLength(100, ErrorMessage = "{0} can't be longer than 100 characters.")]
        public string Name { get; set; } = string.Empty;

        public Guid CountryId { get; set; }

        [ForeignKey(nameof(CountryId))]
        public Country? Country { get; set; }
        public ICollection<RentalUnit>? RentalUnits { get; set; } = new List<RentalUnit>();
    }
}
