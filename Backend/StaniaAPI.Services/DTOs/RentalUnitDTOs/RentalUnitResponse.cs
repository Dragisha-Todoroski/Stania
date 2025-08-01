using StaniaAPI.Domain.Enums;
using StaniaAPI.Domain.Enums.RentalUnitEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaniaAPI.Services.DTOs.RentalUnitDTOs
{
    public class RentalUnitResponse
    {
        public Guid Id { get; set; }

        public string? Title { get; set; }
        public string? Description { get; set; }

        [Display(Name = "Rental unit type")]
        public RentalUnitType RentalUnitType { get; set; }

        [Display(Name = "Rental term")]
        public RentalUnitTerm RentalUnitTerm { get; set; }

        [Display(Name = "Bedrooms")]
        public int BedroomCount { get; set; }

        [Display(Name = "Bathrooms")]
        public double BathroomCount { get; set; }

        [Display(Name = "Square footage")]
        public int SquareFootage { get; set; }

        public int? NumOfFloors { get; set; }
        public int? FloorNumber { get; set; }

        [Display(Name = "Parking option")]
        public ParkingOption ParkingOption { get; set; }

        [Display(Name = "Parking cost")]
        public ParkingCost? ParkingCost { get; set; }
        public bool? HasGarage { get; set; }
        public bool? HasGarden { get; set; }

        public Guid RegionId { get; set; }

        [Display(Name = "Region name")]
        public string? RegionName { get; set; } // Using name for client readability; Data filled with, e.g. rentalUnit.Region.Name

        public string Address { get; set; } = string.Empty;

        public decimal Price { get; set; }
        public Currency Currency { get; set; }

        [Display(Name = "Created at")]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Last updated")]
        public DateTime UpdatedAt { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != typeof(RentalUnitResponse)) return false;

            var other = (RentalUnitResponse)obj;

            return Id == other.Id &&
                   Title == other.Title &&
                   Description == other.Description &&
                   RentalUnitType == other.RentalUnitType &&
                   RentalUnitTerm == other.RentalUnitTerm &&
                   BedroomCount == other.BedroomCount &&
                   BathroomCount == other.BathroomCount &&
                   SquareFootage == other.SquareFootage &&
                   NumOfFloors == other.NumOfFloors &&
                   FloorNumber == other.FloorNumber &&
                   ParkingOption == other.ParkingOption &&
                   ParkingCost == other.ParkingCost &&
                   HasGarage == other.HasGarage &&
                   HasGarden == other.HasGarden &&
                   RegionId == other.RegionId &&
                   RegionName == other.RegionName &&
                   Address == other.Address &&
                   Price == other.Price &&
                   Currency == other.Currency &&
                   CreatedAt == other.CreatedAt &&
                   UpdatedAt == other.UpdatedAt;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
