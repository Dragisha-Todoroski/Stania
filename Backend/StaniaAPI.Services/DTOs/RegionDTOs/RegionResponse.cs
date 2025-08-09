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

namespace StaniaAPI.Services.DTOs.RegionDTOs
{
    public class RegionResponse
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public Guid CountryId { get; set; }

        [Display(Name = "Country name")]
        public string? CountryName { get; set; } // Using name for client readability; Data filled with, e.g. region.Country.Name

        [Display(Name = "Created at")]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Last updated")]
        public DateTime UpdatedAt { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != typeof(RegionResponse)) return false;

            var other = (RegionResponse)obj;

            return Id == other.Id &&
                   Name == other.Name &&
                   CountryId == other.CountryId &&
                   CountryName == other.CountryName &&
                   CreatedAt == other.CreatedAt &&
                   UpdatedAt == other.UpdatedAt;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
