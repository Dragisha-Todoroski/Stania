using StaniaAPI.Repositories.Abstractions.CountryAbstractions;
using StaniaAPI.Services.Abstractions.CountryAbstractions;
using StaniaAPI.Services.DTOs.CountryDTOs;
using StaniaAPI.Services.Mappers;
using StaniaAPI.Services.ServiceHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaniaAPI.Services.Implementations.CountryImplementations
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;

        public CountryService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        public async Task<IEnumerable<CountryResponse>> GetAllAsync()
        {
            var countryList = await _countryRepository.GetAllAsync();

            return countryList.Select(x => x.ToCountryResponse()).ToList();
        }
        public async Task<CountryResponse?> GetByIdAsync(Guid id)
        {
            if (id == Guid.Empty)
                return null;

            var country = await _countryRepository.GetByIdAsync(id);

            if (country == null)
                return null;

            return country.ToCountryResponse();
        }

        public async Task<CountryResponse> CreateAsync(CountryAddRequest addRequest)
        {
            // Validation
            ValidationHelper.ModelValidation(addRequest);

            // Conversion to Country entity
            var country = addRequest.ToCountry();

            await _countryRepository.CreateAsync(country);

            return country.ToCountryResponse();
        }

        public async Task<CountryResponse?> UpdateAsync(Guid id, CountryUpdateRequest updateRequest)
        {
            // Validation
            ValidationHelper.ModelValidation(updateRequest);

            var country = await _countryRepository.GetByIdAsync(id);

            if (country == null)
                return null;

            // Apply new changes to Country entity
            country.ApplyUpdate(updateRequest);

            await _countryRepository.UpdateAsync(country);

            return country.ToCountryResponse();
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            if (id == Guid.Empty)
                return false;

            return await _countryRepository.DeleteAsync(id);
        }
    }
}
