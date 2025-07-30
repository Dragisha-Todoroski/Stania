using StaniaAPI.Services.DTOs.RentalUnitDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaniaAPI.Services.Abstractions.RentalUnitAbstractions
{
    public interface IRentalUnitService : IBaseCrudService<RentalUnitAddRequest, RentalUnitUpdateRequest, RentalUnitResponse>
    {

    }
}
