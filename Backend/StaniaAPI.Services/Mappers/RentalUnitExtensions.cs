using StaniaAPI.Domain.Entities;
using StaniaAPI.Domain.Enums.RentalUnitEnums;
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

        public static RentalUnit ToRentalUnit(this RentalUnitAddRequest addRequest)
        {
            if (addRequest == null)
                throw new ArgumentNullException(nameof(addRequest), "Add request cannot be null");

            return new RentalUnit
            {
                Title = addRequest.Title,
                Description = addRequest.Description,
                RentalUnitType = addRequest.RentalUnitType!.Value,
                RentalUnitTerm = addRequest.RentalUnitTerm!.Value,
                BedroomCount = addRequest.BedroomCount!.Value,
                BathroomCount = addRequest.BathroomCount!.Value,
                SquareFootage = addRequest.SquareFootage!.Value,
                NumOfFloors = addRequest.NumOfFloors,
                FloorNumber = addRequest.FloorNumber,
                ParkingOption = addRequest.ParkingOption!.Value,
                ParkingCost = addRequest.ParkingCost,
                HasGarage = addRequest.HasGarage,
                HasGarden = addRequest.HasGarden,
                RegionId = addRequest.RegionId!.Value,
                Address = addRequest.Address,
                Price = addRequest.Price!.Value,
                Currency = addRequest.Currency!.Value,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow
            };
        }

        public static void ApplyUpdate(this RentalUnit rentalUnit, RentalUnitUpdateRequest updateRequest)
        {
            if (updateRequest.Title is not null)
                rentalUnit.Title = updateRequest.Title;

            if (updateRequest.Description is not null)
                rentalUnit.Description = updateRequest.Description;

            if (updateRequest.RentalUnitType.HasValue)
                rentalUnit.RentalUnitType = updateRequest.RentalUnitType.Value;

            if (updateRequest.RentalUnitTerm.HasValue)
                rentalUnit.RentalUnitTerm = updateRequest.RentalUnitTerm.Value;

            if (updateRequest.BedroomCount.HasValue)
                rentalUnit.BedroomCount = updateRequest.BedroomCount.Value;

            if (updateRequest.BathroomCount.HasValue)
                rentalUnit.BathroomCount = updateRequest.BathroomCount.Value;

            if (updateRequest.SquareFootage.HasValue)
                rentalUnit.SquareFootage = updateRequest.SquareFootage.Value;

            if (updateRequest.NumOfFloors.HasValue)
                rentalUnit.NumOfFloors = updateRequest.NumOfFloors.Value;

            if (updateRequest.FloorNumber.HasValue)
                rentalUnit.FloorNumber = updateRequest.FloorNumber.Value;

            if (updateRequest.ParkingOption.HasValue)
                rentalUnit.ParkingOption = updateRequest.ParkingOption.Value;

            if (updateRequest.ParkingCost.HasValue)
                rentalUnit.ParkingCost = updateRequest.ParkingCost.Value;

            if (updateRequest.HasGarage.HasValue)
                rentalUnit.HasGarage = updateRequest.HasGarage.Value;

            if (updateRequest.HasGarden.HasValue)
                rentalUnit.HasGarden = updateRequest.HasGarden.Value;

            if (updateRequest.RegionId.HasValue)
                rentalUnit.RegionId = updateRequest.RegionId.Value;

            if (updateRequest.Address is not null)
                rentalUnit.Address = updateRequest.Address;

            if (updateRequest.Price.HasValue)
                rentalUnit.Price = updateRequest.Price.Value;

            if (updateRequest.Currency.HasValue)
                rentalUnit.Currency = updateRequest.Currency.Value;

            rentalUnit.UpdatedAt = DateTime.UtcNow;
        }
    }
}
