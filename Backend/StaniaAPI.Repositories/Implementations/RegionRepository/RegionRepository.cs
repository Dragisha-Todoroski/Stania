using Microsoft.EntityFrameworkCore;
using StaniaAPI.DataAccess;
using StaniaAPI.Domain.Entities;
using StaniaAPI.Repositories.Abstractions.RegionAbstractions;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaniaAPI.Repositories.Implementations.RegionRepository
{
    public class RegionRepository : IRegionRepository
    {
        private readonly ApplicationDbContext _context;

        public RegionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Region>> GetAllAsync()
        {
            var regionList = await _context.Set<Region>().ToListAsync();

            return regionList;
        }

        public async Task<Region?> GetByIdAsync(Guid id)
        {
            var region = await _context.Set<Region>().FindAsync(id);

            return region;
        }

        public async Task<Region> CreateAsync(Region region)
        {
            await _context.Set<Region>().AddAsync(region);
            await _context.SaveChangesAsync();

            return region;
        }

        public async Task<Region?> UpdateAsync(Region region)
        {
            var dbRegion = await _context.Set<Region>().FindAsync(region.Id);

            // Should never trigger with GetByIdAsync being called prior in the Services layer (therefore no double null check there)
            if (dbRegion == null)
                return null;

            _context.Entry(dbRegion).CurrentValues.SetValues(region);
            await _context.SaveChangesAsync();

            return dbRegion;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var dbRegion = await _context.Set<Region>().FindAsync(id);

            if (dbRegion == null)
                return false;

            _context.Set<Region>().Remove(dbRegion);

            return await _context.SaveChangesAsync() > 0;
        }
    }
}
