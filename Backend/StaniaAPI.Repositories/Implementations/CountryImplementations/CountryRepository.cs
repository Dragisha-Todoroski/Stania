using Microsoft.EntityFrameworkCore;
using StaniaAPI.DataAccess;
using StaniaAPI.Domain.Entities;
using StaniaAPI.Repositories.Abstractions.CountryAbstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaniaAPI.Repositories.Implementations.CountryImplementations
{
    public class CountryRepository : ICountryRepository
    {
        private readonly ApplicationDbContext _context;

        public CountryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Country>> GetAllAsync()
        {
            var countryList = await _context.Set<Country>().ToListAsync();

            return countryList;
        }

        public async Task<Country?> GetByIdAsync(Guid id)
        {
            var country = await _context.Set<Country>().FindAsync(id);

            return country;
        }

        public async Task<Country> CreateAsync(Country country)
        {
            await _context.Set<Country>().AddAsync(country);
            await _context.SaveChangesAsync();

            return country;
        }

        public async Task<Country?> UpdateAsync(Country country)
        {
            var dbCountry = await _context.Set<Country>().FindAsync(country.Id);

            // Should never trigger with GetByIdAsync being called prior in the Services layer (therefore no double null check there)
            if (dbCountry == null)
                return null;

            _context.Entry(dbCountry).CurrentValues.SetValues(country);
            await _context.SaveChangesAsync();

            return dbCountry;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var dbCountry = await _context.Set<Country>().FindAsync(id);

            if (dbCountry == null)
                return false;

            _context.Set<Country>().Remove(dbCountry);

            return await _context.SaveChangesAsync() > 0;
        }
    }
}
