using StaniaAPI.Services.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaniaAPI.Domain.Entities
{
    public class RentalUnit
    {
        public Guid Id { get; set; }

        // Categorization
        public RentalUnitType RentalUnitType { get; set; }
        public RentalUnitTerm RentalUnitTerm { get; set; }

        // Common characteristics
        public int BedroomCount { get; set; } = 0;
        public int BathroomCount { get; set; } = 1;
        public int SquareFootage { get; set; }

        // Optional features
        public int? NumOfFloors { get; set; } // primarily for houses/entire complexes
        public int? FloorNumber { get; set; } // primarily for studios/apartments/rooms
        public ParkingOption ParkingOption { get; set; }
        public ParkingCost ParkingCost { get; set; }
        public bool HasGarage { get; set; }
        public bool HasGarden { get; set; }

        // Location, pricing & description
        public string Address { get; set; } = null!;
        public decimal Price { get; set; }
        public string Currency { get; set; } = "EUR";
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
