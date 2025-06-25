using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaniaAPI.Services.Enums
{
    public enum RentalUnitTerm
    {
        [Display(Name = "Short-term")]
        ShortTerm = 1,

        [Display(Name = "Long-term")]
        LongTerm = 2,
    }
}
