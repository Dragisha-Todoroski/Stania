using StaniaAPI.Domain.Enums;
using StaniaAPI.Domain.Enums.RentalUnitEnums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StaniaAPI.Domain.Entities
{
    public class RentalUnit
    {
        [Key]
        public Guid Id { get; set; }

        [Column(TypeName = "varchar(300)")]
        public string Title { get; set; } = string.Empty;

        [Column(TypeName = "varchar(1000)")]
        public string? Description { get; set; }


        // Categorization

        public RentalUnitType RentalUnitType { get; set; }
        public RentalUnitTerm RentalUnitTerm { get; set; }


        // Common characteristics

        public int BedroomCount { get; set; } = 0;
        public double BathroomCount { get; set; } = 1;
        public int SquareFootage { get; set; }


        // Optional features

        public int? NumOfFloors { get; set; } // Primarily for houses/entire complexes
        public int? FloorNumber { get; set; } // Primarily for studios/apartments/rooms
        public ParkingOption ParkingOption { get; set; }
        public ParkingCost? ParkingCost { get; set; } // Only used if ParkingOption is not NoParking
        public bool? HasGarage { get; set; }
        public bool? HasGarden { get; set; }


        // Location & pricing

        public Guid RegionId { get; set; }

        [ForeignKey(nameof(RegionId))]
        public Region? Region { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string Address { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public Currency Currency { get; set; }


        // Auto-generated timestamps

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}
