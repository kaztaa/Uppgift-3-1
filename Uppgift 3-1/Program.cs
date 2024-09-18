
using System.Collections.Concurrent;

namespace Uppgift_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //try
            //{
            //    // Test med ogiltiga värden
            //    Person pers = new Person(-1, "mr", "lee");

            //    Console.WriteLine($"Name: {pers.FName} {pers.LName}");
            //}
            //catch (ArgumentException ex)
            //{
            //    // Fångar och hanterar undantaget
            //    Console.WriteLine($"Error: {ex.Message}");
            //}


            // Skapar Person med hjälp av PersonHandler
            PersonHandler personHandler = new PersonHandler();
            Person pers = personHandler.CreatePerson(34, "Sten", "Stanley", 179,88);

            Console.WriteLine(pers.Age);
            Console.WriteLine(pers.FName);
            Console.WriteLine(pers.LName);
            Console.WriteLine(pers.Height);
            Console.WriteLine(pers.Weight);

            // Skriver ut Person med metod
            personHandler.PrintPerson(pers);

            // Sätter ny ålder med metod
            personHandler.SetAge(pers, 12);
            personHandler.PrintPerson(pers);


        }
    }
}
