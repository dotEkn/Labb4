using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb4
{
    public class Person
    {
        //Egenskaper: Gör det lätt för att läsa & exekvera data i ett privatfält. Det gör det lättare att ha
        //kontrollerad och säkrare tillgång till data, med hjälp av Private Set.
        public string firstName { get; set; }
        public string lastName { get;  set; }
        public int age { get; set; }
        public Gender gender { get;  set; }
        public Hair HairInfo { get; set; }
        public string eyeColor { get;  set; }
        public DateTime birthday { get;  set; }

        //Constructor: Gör det lätt att kontrollera instantiering, skriva kod som är lätt att läsa. Måste matcha namnet som klassen. 
        //Constructor: Sparar en del tid, då man inte behöver skriva så mycket kod. (W3schools.com/cs/cs_csontructor.php)
        //Constructor: En metod i klassen som anropas vid instantiering.


        public override string ToString()
        {
            return $"Name: {firstName} {lastName}" +
                $"\nAge: {age}" +
                $"\nGender: {gender}" +
                $"\nHair: {HairInfo.Color} {HairInfo.Length}" +
                $"\nEye Color: {eyeColor}" +
                $"\nBirthday: {birthday:yyyy/MM/dd}"; 
        }
    }
}
