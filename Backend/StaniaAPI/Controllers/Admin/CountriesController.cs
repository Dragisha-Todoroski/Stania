using Microsoft.AspNetCore.Mvc;
using StaniaAPI.Services.Abstractions.CountryAbstractions;
using StaniaAPI.Services.DTOs.CountryDTOs;

namespace StaniaAPI.Controllers.Admin
{
    [Route("api/v1/admin/[controller]")]
    [ApiController]
    //[Authorize(Roles = "Admin")]
    public class CountriesController : ControllerBase
    {
        private readonly ICountryService _countryService;

        public CountriesController(ICountryService countryService)
        {
            _countryService = countryService;
        }

        // GET: api/v1/admin/Countries
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var countryList = await _countryService.GetAllAsync();

            return Ok(countryList);
        }

        // GET: api/v1/admin/Countries/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            var country = await _countryService.GetByIdAsync(id);

            if (country == null)
                return NotFound($"Country with ID: {id} not found.");

            return Ok(country);
        }

        // POST: api/v1/admin/Countries
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] CountryAddRequest addRequest)
        {
            var createdCountry = await _countryService.CreateAsync(addRequest);

            return CreatedAtAction(nameof(GetByIdAsync), new { id = createdCountry.Id }, createdCountry);
        }

        // PUT: api/v1/admin/Countries/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] CountryUpdateRequest updateRequest)
        {
            var updatedCountry = await _countryService.UpdateAsync(id, updateRequest);

            if (updatedCountry == null)
                return NotFound($"Country with ID: {id} not found.");

            return Ok(updatedCountry);
        }

        // DELETE: api/v1/admin/Countries/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            var isCountryDeleted = await _countryService.DeleteAsync(id);

            if (!isCountryDeleted)
                return NotFound($"Country with ID: {id} not found.");

            return NoContent();
        }
    }
}
