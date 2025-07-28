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

        [Required(ErrorMessage = "{0} is required.")]
        [MinLength(1, ErrorMessage = "{0} must not be empty.")]
        [Column(TypeName = "varchar(75)")]
        [StringLength(75, ErrorMessage = "{0} can't be longer than 75 characters.")]
        public string Name { get; set; } = string.Empty;
        public ICollection<Region>? Regions { get; set; } = new List<Region>();
    }
}
