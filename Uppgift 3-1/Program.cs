namespace Uppgift_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Test med ogiltiga värden (t.ex. negativ ålder)
                Person pers = new Person(10, "s", "wee"); // Ålder är negativ

                Console.WriteLine($"Namn: {pers.FName} {pers.LName}");
                Console.WriteLine($"Ålder: {pers.Age}");
                Console.WriteLine($"Längd: {pers.Height} m");
                Console.WriteLine($"Vikt: {pers.Weight} kg");
            }
            catch (ArgumentException ex)
            {
                // Fångar och hanterar undantaget
                Console.WriteLine($"Ett fel uppstod: {ex.Message}");
            }

        }
    }
}
