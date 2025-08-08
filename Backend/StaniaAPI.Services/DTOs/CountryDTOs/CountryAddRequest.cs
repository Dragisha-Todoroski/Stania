using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaniaAPI.Services.DTOs.CountryDTOs
{
    public class CountryAddRequest
    {
        [Required(ErrorMessage = "{0} is required.")]
        [MinLength(1, ErrorMessage = "{0} must not be empty.")]
        [StringLength(75, ErrorMessage = "{0} can't be longer than 75 characters.")]
        public string? Name { get; set; }
    }
}
