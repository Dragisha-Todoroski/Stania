using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaniaAPI.Services.DTOs.CountryDTOs
{
    public class CountryResponse
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }
    }
}
