using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StaniaAPI.Services.Abstractions.RentalUnitAbstractions;

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
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<IActionResult> GetByIdAsync()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync()
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync()
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync()
        {
            throw new NotImplementedException();
        }
    }
}
