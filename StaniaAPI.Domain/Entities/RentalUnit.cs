using StaniaAPI.Services.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        [Required(ErrorMessage = "{0} is required.")]
        [EnumDataType(typeof(RentalUnitType))]
        public RentalUnitType RentalUnitType { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [EnumDataType(typeof(RentalUnitTerm))]
        public RentalUnitTerm RentalUnitTerm { get; set; }

        // Common characteristics

        [Required(ErrorMessage = "{0} is required.")]
        public int BedroomCount { get; set; } = 0;

        [Required(ErrorMessage = "{0} is required.")]
        public int BathroomCount { get; set; } = 1;

        [Required(ErrorMessage = "{0} is required.")]
        public int SquareFootage { get; set; }

        // Optional features

        [Range(0, int.MaxValue, ErrorMessage = "Number of floors must be non-negative.")]
        public int? NumOfFloors { get; set; } // Primarily for houses/entire complexes

        [Range(0, int.MaxValue, ErrorMessage = "Floor number must be non-negative.")]
        public int? FloorNumber { get; set; } // Primarily for studios/apartments/rooms

        [Required(ErrorMessage = "{0} is required.")]
        [EnumDataType(typeof(ParkingOption))]
        public ParkingOption ParkingOption { get; set; } = ParkingOption.NoParking;

        [EnumDataType(typeof(ParkingCost))]
        public ParkingCost? ParkingCost { get; set; } // Only used if ParkingOption is not NoParking
        public bool? HasGarage { get; set; }
        public bool? HasGarden { get; set; }

        // Location & pricing

        [Required(ErrorMessage = "{0} is required.")]
        public string Address { get; set; } = null!;

        [Required(ErrorMessage = "{0} is required.")]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Price must be non-negative.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [MinLength(1, ErrorMessage = "{0} must not be empty.")]
        [Column(TypeName = "varchar(15)")]
        [StringLength(15, ErrorMessage = "{0} can't be longer than 15 characters.")]
        public string Currency { get; set; } = "EUR";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
