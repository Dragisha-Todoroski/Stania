using StaniaAPI.Domain.Entities;
using StaniaAPI.Domain.Enums;
using StaniaAPI.Domain.Enums.RentalUnitEnums;
using StaniaAPI.Services.DTOs.RentalUnitDTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StaniaAPI.Services.DTOs.CountryDTOs
{
    public class CountryResponse
    {
        public Guid Id { get; set; }

        public string? Name { get; set; }

        [Display(Name = "Created at")]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Last updated")]
        public DateTime UpdatedAt { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != typeof(CountryResponse)) return false;

            var other = (CountryResponse)obj;

            return Id == other.Id &&
                   Name == other.Name &&
                   CreatedAt == other.CreatedAt &&
                   UpdatedAt == other.UpdatedAt;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
