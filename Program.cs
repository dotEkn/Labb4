using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Labb4
{
    internal class Program
    {

        static void Main()
        {
            string MenyAlternativ;

            List<Person> Persons = new List<Person>();

            // Meny med Whileloop, bool(true).
            //Menyval med hjälp av knapptryck, navigation med hjälp av siffror.
            while (true)
            {



                Console.WriteLine("Välkommen till programmet!");
                Console.WriteLine("Navigera med hjälp av siffror!");


                Console.WriteLine($"\n1: Lägg till personer!" +
                    $"\n2: Lista på personer!" +
                    $"\n3: Avsluta programmet!");

                Console.WriteLine("Välj vilket menyval du vill använda.");
                MenyAlternativ = Console.ReadLine();



                switch (MenyAlternativ)
                {
                    case "1":
                        Console.Clear();
                        AddPerson(Persons);
                        break;
                    case "2":
                        DisplayPeople(Persons);
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice. Try again.");
                        break;


                }
            }
        }


        //Metod för att lägga till personer i listan.
        //Skriver in information om personen i programmet, och allt sparas.
        //Anropar People.Add(newPerson) för att lägga till i listan.

        static void AddPerson(List<Person> Persons)
        {
            Person newPerson = new Person();
            Console.WriteLine("Enter your name: ");
            newPerson.firstName = Console.ReadLine();

            Console.WriteLine("Enter Age: ");
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                newPerson.age = age;
            }
            else
            {
                Console.WriteLine("Invalid Input, age must be a number.");
                return;
            }
            //Lägger till födelsedag.
            Console.WriteLine("Enter Birthday (MM/DD/YYYY): ");
            if(DateTime.TryParse(Console.ReadLine(), out DateTime birthDay))
            {
                newPerson.birthday = birthDay;
            }
            else
            {
                Console.WriteLine("Invalid input. Enter a valid date.");
                return;
            }


            //Räknar upp inom Enum Hair, där du sedan väljer hårfärg med hjälp av siffror.
            //Hårlängden skriver du in innan.
            Console.WriteLine("Enter Hair Length (it will be displayed in cm): ");
            {
                if (int.TryParse(Console.ReadLine(), out int hairLength))
                {
                    //Omvandla sträng till värde av angiven ENUM-typ.
                    Console.WriteLine("Enter Haircolor (1.Blonde, 2.Brunette, 3.Red, 4.Black, 5.Other.)");
                    if (Enum.TryParse(Console.ReadLine(), true, out Haircolor haircolor))
                    {
                        newPerson.HairInfo = new Hair(hairLength, haircolor);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input. Enter a valid input.");
                        return;
                    }
                }

                else
                {
                    Console.WriteLine("Invalid input, must be in numbers.");
                    return;
                }
                //Metod som lägger till ögonfärg.
                Console.WriteLine("Enter your eye color: ");
                newPerson.eyeColor = Console.ReadLine();

                //Metod som lägger till kön, där man får välja mellan 3 olika.
                //Räknar upp inom ENUM Gender för att söka efter vad användaren är för kön, navigerar med hjälp av siffror.
                Console.WriteLine("Select Gender: ");
                Console.WriteLine("1. Male");
                Console.WriteLine("2. Female");
                Console.WriteLine("3. Other");
                //Kontrollerar om ett givet värde är specificerat i Gender, den returnerar true om det är det.
                if (int.TryParse(Console.ReadLine(), out int genderChoice) && Enum.IsDefined(typeof(Gender), genderChoice - 1))
                {
                    newPerson.gender = (Gender)(genderChoice - 1);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid gender.");
                    return;
                }
                //Lägger till personen, och meddelar även användaren om att den är tillagd.
                Persons.Add(newPerson);
                Console.WriteLine("Person added succesfully!");
            }
        }

        //Metod för att displaya personerna som är tillagda. Ett meddelande kommer upp om det inte finns några personer tillagda.
        //Med hjälp av en foreach loop så kollar den igenom listan och söker efter person.
        static void DisplayPeople(List<Person> persons)
        {
            if (persons.Count == 0)
            {
                Console.WriteLine("No people to display!");
            }
            else
            {
                Console.WriteLine("People Information: ");
                foreach (Person person in persons)
                {
                    Console.WriteLine(person);
                }
            }
        }
    }
}


            


