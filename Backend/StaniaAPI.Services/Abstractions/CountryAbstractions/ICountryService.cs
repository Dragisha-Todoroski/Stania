using StaniaAPI.Services.DTOs.CountryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaniaAPI.Services.Abstractions.CountryAbstractions
{
    public interface ICountryService : IBaseCrudService<CountryAddRequest, CountryUpdateRequest, CountryResponse>
    {
    }
}
