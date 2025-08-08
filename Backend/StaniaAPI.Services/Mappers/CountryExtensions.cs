using StaniaAPI.Domain.Entities;
using StaniaAPI.Services.DTOs.CountryDTOs;
using StaniaAPI.Services.DTOs.RentalUnitDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaniaAPI.Services.Mappers
{
    public static class CountryExtensions
    {
        public static CountryResponse ToCountryResponse(this Country country)
        {
            if (country == null)
                throw new ArgumentNullException(nameof(country), "Country cannot be null");

            return new CountryResponse
            {
                Id = country.Id,
                Name = country.Name,
                CreatedAt = country.CreatedAt,
                UpdatedAt = country.UpdatedAt,
            };
        }

        public static Country ToCountry(this CountryAddRequest addRequest)
        {
            if (addRequest == null)
                throw new ArgumentNullException(nameof(addRequest), "Add request cannot be null");

            return new Country
            {
                Id = Guid.NewGuid(),
                Name = addRequest.Name!,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };
        }

        public static void ApplyUpdate(this Country country, CountryUpdateRequest updateRequest)
        {
            if (updateRequest.Name is not null)
                country.Name = updateRequest.Name;

            country.UpdatedAt = DateTime.UtcNow;
        }
    }
}
