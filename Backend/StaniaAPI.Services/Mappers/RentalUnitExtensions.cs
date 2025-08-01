using StaniaAPI.Domain.Entities;
using StaniaAPI.Services.DTOs.RentalUnitDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaniaAPI.Services.Mappers
{
    public static class RentalUnitExtensions
    {
        public static RentalUnitResponse ToRentalUnitResponse(this RentalUnit rentalUnit)
        {
            if (rentalUnit == null)
                throw new ArgumentNullException(nameof(rentalUnit), "RentalUnit cannot be null");

            return new RentalUnitResponse
            {
                Id = rentalUnit.Id,
                Title = rentalUnit.Title,
                Description = rentalUnit.Description,
                RentalUnitType = rentalUnit.RentalUnitType,
                RentalUnitTerm = rentalUnit.RentalUnitTerm,
                BedroomCount = rentalUnit.BedroomCount,
                BathroomCount = rentalUnit.BathroomCount,
                SquareFootage = rentalUnit.SquareFootage,
                NumOfFloors = rentalUnit.NumOfFloors,
                FloorNumber = rentalUnit.FloorNumber,
                ParkingOption = rentalUnit.ParkingOption,
                ParkingCost = rentalUnit.ParkingCost,
                HasGarage = rentalUnit.HasGarage,
                HasGarden = rentalUnit.HasGarden,
                RegionId = rentalUnit.RegionId,
                RegionName = rentalUnit.Region?.Name,
                Address = rentalUnit.Address,
                Price = rentalUnit.Price,
                Currency = rentalUnit.Currency,
                CreatedAt = rentalUnit.CreatedAt,
                UpdatedAt = rentalUnit.UpdatedAt
            };
        }
    }
}
