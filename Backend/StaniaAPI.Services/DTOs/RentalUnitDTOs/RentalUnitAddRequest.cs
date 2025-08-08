using StaniaAPI.Domain.Enums;
using StaniaAPI.Domain.Enums.RentalUnitEnums;
using StaniaAPI.Helpers.CustomValidators;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaniaAPI.Services.DTOs.RentalUnitDTOs
{
    public class RentalUnitAddRequest
    {
        [Required(ErrorMessage = "{0} is required.")]
        [MinLength(1, ErrorMessage = "{0} must not be empty.")]
        [StringLength(300, ErrorMessage = "{0} can't be longer than 300 characters.")]
        public string? Title { get; set; }

        [MinLength(1, ErrorMessage = "{0} must not be empty.")]
        [StringLength(1000, ErrorMessage = "{0} can't be longer than 1000 characters.")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Rental unit type is required.")]
        [EnumDataType(typeof(RentalUnitType), ErrorMessage = "Invalid rental unit type.")]
        public RentalUnitType? RentalUnitType { get; set; }

        [Required(ErrorMessage = "Rental unit term is required.")]
        [EnumDataType(typeof(RentalUnitTerm), ErrorMessage = "Invalid rental unit term.")]
        public RentalUnitTerm? RentalUnitTerm { get; set; }

        [Required(ErrorMessage = "Number of bedrooms is required.")]
        [Range(0, int.MaxValue, ErrorMessage = "Number of bedrooms must be non-negative.")]
        public int? BedroomCount { get; set; }

        [Required(ErrorMessage = "Number of bathrooms is required.")]
        [Range(1, double.MaxValue, ErrorMessage = "Number of bathrooms must be at least 1.")]
        [BathroomCountIncrement]
        public double? BathroomCount { get; set; }

        [Required(ErrorMessage = "Square footage is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Square footage must be at least 1.")]
        public int? SquareFootage { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Number of floors must be non-negative.")]
        public int? NumOfFloors { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Floor number must be non-negative.")]
        public int? FloorNumber { get; set; }

        [Required(ErrorMessage = "Parking option is required.")]
        [EnumDataType(typeof(ParkingOption), ErrorMessage = "Invalid parking option.")]
        public ParkingOption? ParkingOption { get; set; }

        [EnumDataType(typeof(ParkingCost), ErrorMessage = "Invalid parking cost.")]
        public ParkingCost? ParkingCost { get; set; }

        public bool? HasGarage { get; set; }
        public bool? HasGarden { get; set; }

        [Required(ErrorMessage = "Region is required.")]
        public Guid? RegionId { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [MinLength(1, ErrorMessage = "{0} must not be empty.")]
        [StringLength(500, ErrorMessage = "Address can't be longer than 500 characters.")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Price is required.")]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Price must be non-negative.")]
        public decimal? Price { get; set; }

        [Required(ErrorMessage = "Currency is required.")]
        [EnumDataType(typeof(Currency), ErrorMessage = "Invalid currency.")]
        public Currency? Currency { get; set; }
    }
}
