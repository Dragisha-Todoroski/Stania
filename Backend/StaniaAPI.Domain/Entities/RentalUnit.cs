using StaniaAPI.Services.Enums;
using StaniaAPI.Services.Enums.RentalUnitEnums;
using StaniaAPI.Services.ServiceHelpers.CustomValidators;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StaniaAPI.Domain.Entities
{
    public class RentalUnit
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [MinLength(1, ErrorMessage = "{0} must not be empty.")]
        [Column(TypeName = "varchar(300)")]
        [StringLength(300, ErrorMessage = "{0} can't be longer than 300 characters.")]
        public string Title { get; set; } = string.Empty;

        [MinLength(1, ErrorMessage = "{0} must not be empty.")]
        [Column(TypeName = "varchar(1000)")]
        [StringLength(1000, ErrorMessage = "{0} can't be longer than 1000 characters.")]
        public string? Description { get; set; }


        // Categorization

        [EnumDataType(typeof(RentalUnitType), ErrorMessage = "Invalid rental unit type.")]
        public RentalUnitType RentalUnitType { get; set; }

        [EnumDataType(typeof(RentalUnitTerm), ErrorMessage = "Invalid rental unit term.")]
        public RentalUnitTerm RentalUnitTerm { get; set; }


        // Common characteristics

        [Range(0, int.MaxValue, ErrorMessage = "Number of bedrooms must be non-negative.")]
        public int BedroomCount { get; set; } = 0;

        [Range(1, double.MaxValue, ErrorMessage = "Number of bathrooms must be at least 1.")]
        [BathroomCountIncrement]
        public double BathroomCount { get; set; } = 1;

        [Range(1, int.MaxValue, ErrorMessage = "Square footage must be at least 1.")]
        public int SquareFootage { get; set; }


        // Optional features

        [Range(0, int.MaxValue, ErrorMessage = "Number of floors must be non-negative.")]
        public int? NumOfFloors { get; set; } // Primarily for houses/entire complexes

        [Range(0, int.MaxValue, ErrorMessage = "Floor number must be non-negative.")]
        public int? FloorNumber { get; set; } // Primarily for studios/apartments/rooms

        [EnumDataType(typeof(ParkingOption), ErrorMessage = "Invalid parking option.")]
        public ParkingOption ParkingOption { get; set; }

        [EnumDataType(typeof(ParkingCost), ErrorMessage = "Invalid parking cost.")]
        public ParkingCost? ParkingCost { get; set; } // Only used if ParkingOption is not NoParking
        public bool? HasGarage { get; set; }
        public bool? HasGarden { get; set; }


        // Location & pricing

        public Guid RegionId { get; set; }

        [ForeignKey(nameof(RegionId))]
        public Region? Region { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [Column(TypeName = "varchar(500)")]
        [MinLength(1, ErrorMessage = "{0} must not be empty.")]
        [StringLength(500, ErrorMessage = "{0} can't be longer than 500 characters.")]
        public string Address { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Price must be non-negative.")]
        public decimal Price { get; set; }

        [EnumDataType(typeof(Currency), ErrorMessage = "Invalid currency.")]
        public Currency Currency { get; set; }


        // Auto-generated timestamps

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
