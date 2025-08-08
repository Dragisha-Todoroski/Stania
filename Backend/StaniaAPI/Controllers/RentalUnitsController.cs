using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StaniaAPI.Services.Abstractions.RentalUnitAbstractions;
using StaniaAPI.Services.DTOs.RentalUnitDTOs;

namespace StaniaAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class RentalUnitsController : ControllerBase
    {
        private readonly IRentalUnitService _rentalUnitService;
        public RentalUnitsController(IRentalUnitService rentalUnitService)
        {
            _rentalUnitService = rentalUnitService;
        }

        // GET: api/v1/RentalUnits
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var rentalUnitList = await _rentalUnitService.GetAllAsync();

            return Ok(rentalUnitList);
        }

        // GET: api/v1/RentalUnits/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            var rentalUnit = await _rentalUnitService.GetByIdAsync(id);

            if (rentalUnit == null)
                return NotFound($"Rental unit with ID: {id} not found.");

            return Ok(rentalUnit);
        }

        // POST: api/v1/RentalUnits
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] RentalUnitAddRequest addRequest)
        {
            var createdRentalUnit = await _rentalUnitService.CreateAsync(addRequest);

            return CreatedAtAction(nameof(GetByIdAsync), new { id = createdRentalUnit.Id }, createdRentalUnit);
        }

        // PUT: api/v1/RentalUnits/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] RentalUnitUpdateRequest updateRequest)
        {
            var updatedRentalUnit = await _rentalUnitService.UpdateAsync(id, updateRequest);

            if (updatedRentalUnit == null)
                return NotFound($"Rental unit with ID: {id} not found.");

            return Ok(updatedRentalUnit);
        }

        // DELETE: api/v1/RentalUnits/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            var isRentalUnitDeleted = await _rentalUnitService.DeleteAsync(id);

            if (!isRentalUnitDeleted)
                return NotFound($"Rental unit with ID: {id} not found.");
                
            return NoContent();
        }
    }
}
