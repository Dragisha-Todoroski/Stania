using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaniaAPI.Helpers.CustomValidators
{
    // Used for RentalUnit entity's BathroomCount property
    // Ensures BathroomCount goes up in increments of 0.5; e.g. 1.5, 2, 2.5, 7.5, etc.
    public class BathroomCountIncrementAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value == null) return true;

            if (value is double doubleValue)
            {
                return doubleValue * 2 % 1 == 0; // Anything that is a multiple of 0.5 will have no decimals left after multiplying by 2, and will return true
            }

            return false;
        }

        public override string FormatErrorMessage(string name)
        {
            return $"{name} must be in increments of 0.5 (e.g., 1, 1.5, 2, 2.5, etc.).";
        }
    }
}
