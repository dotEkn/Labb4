using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4
{

    // Constructor som initialiserar objekt i en klass.
    // Dessa dyker upp igen när vi bestämmer vilken typ av hår som personen har i Person.cs.
    public struct Hair
    {
        public int Length;
        public Haircolor Color;
        //Struct för hårfärg, där användaren får skriva in hårlängd och hårfärg.
        //Den kallar på enum Haircolor.
        public Hair(int length, Haircolor color)
        {
            Length = length;
            Color = color;
        }
  
    }
}
