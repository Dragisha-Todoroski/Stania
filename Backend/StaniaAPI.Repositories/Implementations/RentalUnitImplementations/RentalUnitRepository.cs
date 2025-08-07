using Microsoft.EntityFrameworkCore;
using StaniaAPI.DataAccess;
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
        private readonly ApplicationDbContext _context;

        public RentalUnitRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<RentalUnit>> GetAllAsync()
        {
            var rentalUnitList = await _context.Set<RentalUnit>()
                .Include(x => x.Region).ToListAsync();

            return rentalUnitList;
        }

        public async Task<RentalUnit?> GetByIdAsync(Guid id)
        {
            var rentalUnit = await  _context.Set<RentalUnit>()
                .Include(x => x.Region)
                .FirstOrDefaultAsync(x => x.Id == id);

            return rentalUnit;
        }

        public async Task<RentalUnit> CreateAsync(RentalUnit rentalUnit)
        {
            await _context.Set<RentalUnit>().AddAsync(rentalUnit);
            await _context.SaveChangesAsync();

            return rentalUnit;
        }

        public async Task<RentalUnit?> UpdateAsync(RentalUnit rentalUnit)
        {
            var dbRentalUnit = await _context.Set<RentalUnit>().FirstOrDefaultAsync(x => x.Id == rentalUnit.Id);

            // Should never trigger with GetByIdAsync being called prior in the Services layer (therefore no double null check there)
            if (dbRentalUnit == null)
                return null;

            _context.Entry(dbRentalUnit).CurrentValues.SetValues(rentalUnit);
            await _context.SaveChangesAsync();

            return dbRentalUnit;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var dbRentalUnit = await _context.Set<RentalUnit>().FirstOrDefaultAsync(x => x.Id == id);

            if (dbRentalUnit == null)
                return false;

            _context.Set<RentalUnit>().Remove(dbRentalUnit);

            return await _context.SaveChangesAsync() > 0;

        }
    }
}
