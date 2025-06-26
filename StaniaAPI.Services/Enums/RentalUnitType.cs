using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaniaAPI.Services.Enums
{
    public enum RentalUnitType
    {
        Apartment = 1,
        Studio = 2,
        House = 3,

        [Display(Name = "Shared room")]
        SharedRoom = 4,

        [Display(Name = "Private room")]
        PrivateRoom = 5,
    }
}
