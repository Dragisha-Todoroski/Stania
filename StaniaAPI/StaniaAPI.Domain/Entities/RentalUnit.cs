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

        // Categorization

        [Required]
        [EnumDataType(typeof(RentalUnitType))]
        public RentalUnitType RentalUnitType { get; set; }

        [Required]
        [EnumDataType(typeof(RentalUnitTerm))]
        public RentalUnitTerm RentalUnitTerm { get; set; }

        // Common characteristics

        [Required]
        public int BedroomCount { get; set; } = 0;

        [Required]
        public int BathroomCount { get; set; } = 1;

        [Required]
        public int SquareFootage { get; set; }

        // Optional features

        [Range(0, int.MaxValue, ErrorMessage = "Number of floors must be non-negative.")]
        public int? NumOfFloors { get; set; } // Primarily for houses/entire complexes

        [Range(0, int.MaxValue, ErrorMessage = "Floor number must be non-negative.")]
        public int? FloorNumber { get; set; } // Primarily for studios/apartments/rooms

        [Required]
        [EnumDataType(typeof(ParkingOption))]
        public ParkingOption ParkingOption { get; set; } = ParkingOption.NoParking;

        [EnumDataType(typeof(ParkingCost))]
        public ParkingCost? ParkingCost { get; set; } // Only used if ParkingOption is not NoParking
        public bool? HasGarage { get; set; }
        public bool? HasGarden { get; set; }

        // Location, pricing & description
        
        [Required]
        public string Address { get; set; } = null!;

        [Required]
        [Range(typeof(decimal), "0", "79228162514264337593543950335", ErrorMessage = "Price must be non-negative.")]
        public decimal Price { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(15)")]
        [StringLength(15, ErrorMessage = "{0} can't be longer than 15 characters.")]
        public string Currency { get; set; } = "EUR";

        [Column(TypeName = "nvarchar(1000)")]
        [StringLength(1000, ErrorMessage = "{0} can't be longer than 1000 characters.")]
        public string? Description { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
