using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4
{
    // Uppräkningstyp ENUM, användning av dessa namn i koden gör så att man slipper hårdkoda "i" koden.
    // Mer läsbar och underlättar hantering.
    // Dessa dyker upp i Person.cs igen när vi beskriver "Gender.Man".
    public enum Gender
    {
            Man,
            Woman,
            Other

    }
}
