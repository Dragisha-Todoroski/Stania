using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaniaAPI.Services.DTOs.RegionDTOs
{
    public class RegionUpdateRequest
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [MinLength(1, ErrorMessage = "{0} must not be empty.")]
        [StringLength(100, ErrorMessage = "{0} can't be longer than 100 characters.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Country is required.")]
        public Guid CountryId { get; set; }
    }
}
