using StaniaAPI.Services.Abstractions.RentalUnitAbstractions;
using StaniaAPI.Services.DTOs.RentalUnitDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaniaAPI.Services.Implementations.RentalUnitImplementations
{
    public class RentalUnitService : IRentalUnitService
    {
        public Task<IEnumerable<RentalUnitResponse>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<RentalUnitResponse?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<RentalUnitResponse> CreateAsync(RentalUnitAddRequest addRequest)
        {
            throw new NotImplementedException();
        }

        public Task<RentalUnitResponse> UpdateAsync(Guid id, RentalUnitUpdateRequest updateRequest)
        {
            throw new NotImplementedException();
        }
    }
}
