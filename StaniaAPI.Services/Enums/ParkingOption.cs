using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaniaAPI.Services.Enums
{
    public enum ParkingOption
    {
        [Display(Name = "Street parking")]
        StreetParking = 1,
        Garage = 2,

        [Display(Name = "No parking")]
        NoParking = 3,

        [Display(Name = "Parking lot")]
        ParkingLot = 4,
    }
}
