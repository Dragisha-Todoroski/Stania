using StaniaAPI.Domain.Entities;
using StaniaAPI.Repositories.Abstractions.RentalUnitAbstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaniaAPI.Repositories.Implementations.RentalUnitImplementations
{
    public class RentalUnitRepository : IRentalUnitRepository
    {
        public Task<RentalUnit> CreateAsync(RentalUnit entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<RentalUnit>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<RentalUnit?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<RentalUnit> UpdateAsync(RentalUnit entity)
        {
            throw new NotImplementedException();
        }
    }
}
