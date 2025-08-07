using StaniaAPI.Repositories.Abstractions.RentalUnitAbstractions;
using StaniaAPI.Services.Abstractions.RentalUnitAbstractions;
using StaniaAPI.Services.DTOs.RentalUnitDTOs;
using StaniaAPI.Services.Mappers;
using StaniaAPI.Services.ServiceHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaniaAPI.Services.Implementations.RentalUnitImplementations
{
    public class RentalUnitService : IRentalUnitService
    {
        private readonly IRentalUnitRepository _rentalUnitRepository;

        public RentalUnitService(IRentalUnitRepository rentalUnitRepository)
        {
            _rentalUnitRepository = rentalUnitRepository;
        }

        public async Task<IEnumerable<RentalUnitResponse>> GetAllAsync()
        {
            var rentalUnitList = await _rentalUnitRepository.GetAllAsync();

            return rentalUnitList.Select(x => x.ToRentalUnitResponse()).ToList();
        }

        public async Task<RentalUnitResponse?> GetByIdAsync(Guid id)
        {
            if (id == Guid.Empty)
                return null;

            var rentalUnit = await _rentalUnitRepository.GetByIdAsync(id);

            if (rentalUnit == null)
                return null;

            return rentalUnit.ToRentalUnitResponse();
        }

        public async Task<RentalUnitResponse> CreateAsync(RentalUnitAddRequest addRequest)
        {
            // Validation
            ValidationHelper.ModelValidation(addRequest);

            // Conversion to RentalUnit entity
            var rentalUnit = addRequest.ToRentalUnit();

            await _rentalUnitRepository.CreateAsync(rentalUnit);

            return rentalUnit.ToRentalUnitResponse();
        }

        public async Task<RentalUnitResponse?> UpdateAsync(Guid id, RentalUnitUpdateRequest updateRequest)
        {
            // Validation
            ValidationHelper.ModelValidation(updateRequest);

            var rentalUnit = await _rentalUnitRepository.GetByIdAsync(id);

            if (rentalUnit == null)
                return null;

            // Apply new changes to RentalUnit entity
            rentalUnit.ApplyUpdate(updateRequest);

            await _rentalUnitRepository.UpdateAsync(rentalUnit);

            return rentalUnit.ToRentalUnitResponse();
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            if (id == Guid.Empty)
                return false;

            var rentalUnit = await _rentalUnitRepository.GetByIdAsync(id);

            if (rentalUnit == null)
                return false;

            await _rentalUnitRepository.DeleteAsync(id);

            return true;
        }
    }
}
