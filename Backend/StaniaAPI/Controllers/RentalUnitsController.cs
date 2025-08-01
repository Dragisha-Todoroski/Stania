using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StaniaAPI.Services.Abstractions.RentalUnitAbstractions;
using StaniaAPI.Services.DTOs.RentalUnitDTOs;

namespace StaniaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalUnitsController : ControllerBase
    {
        private readonly IRentalUnitService _rentalUnitService;
        public RentalUnitsController(IRentalUnitService rentalUnitService)
        {
            _rentalUnitService = rentalUnitService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var rentalUnitList = await _rentalUnitService.GetAllAsync();

            return Ok(rentalUnitList);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            var rentalUnit = await _rentalUnitService.GetByIdAsync(id);

            if (rentalUnit == null)
                return NotFound("Rental unit with given ID was not found.");

            return Ok(rentalUnit);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] RentalUnitAddRequest addRequest)
        {
            var createdRentalUnit = await _rentalUnitService.CreateAsync(addRequest);

            return CreatedAtAction(nameof(GetByIdAsync), new { id = createdRentalUnit.Id }, createdRentalUnit);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] RentalUnitUpdateRequest updateRequest)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
