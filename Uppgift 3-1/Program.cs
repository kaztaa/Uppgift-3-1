
using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace Uppgift_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ovning3_1();

            //Ovning3_2();

            //Ovning3_3();

            Ovning3_4();


        }

        private static void Ovning3_4()
        {
            Horse h1 = new Horse("Pålle", 759, 12);
            Horse h2 = new Horse("Sven", 759, 12);
            Horse h3 = new Horse("Raketen", 759, 12);
            Horse h4 = new Horse("Slöhög", 759, 12);
            Wolfman w1 = new Wolfman("Wolfie", 150, 43, true);
            Console.WriteLine(h1.Stats());
            
            List<Animal> animals = new List<Animal>();
            animals.Add(h1);
            animals.Add(h2);
            animals.Add(h3);
            animals.Add(w1);


            foreach (Animal animal in animals)
            {
                Console.WriteLine($"Animal: {animal.Name}, Weight: {animal.Weight} kg, Age: {animal.Age} yrs");

                if (animal is IPerson person)
                {
                    Console.WriteLine(person.Talk()); // Anropa Talk-metoden om det är en IPerson
                }
                else
                {
                    Console.WriteLine(animal.DoSound());
                }
            }


            List<Dog> dogs = new List<Dog>();

            List<Animal> animales = new List<Animal>();

            Dog d1 = new Dog("Fido", 34, 6);
            Dog d2 = new Dog("Difo", 22, 11);
            Dog d3 = new Dog("Odif", 40, 12);
            Pelican p1 = new Pelican("Birdie", 2, 4);
            Horse h5 = new Horse("Raketen", 759, 12);

            dogs.Add(d1);
            dogs.Add(d2);
            dogs.Add(d3);

            animales.Add(d1);
            animales.Add(d2);
            animales.Add(d3);
            animales.Add(p1);
            animales.Add(h5);
                

            // Fråga
            // 9 - Det är en lista för klassen Dog, då går det inte med en annan klass tex Horse
            // 10 - Animals

            foreach (Animal a in animales)
            {
                Console.WriteLine($"Stats: {a.Stats()} ");
            }

            // 13 - Gjorde en lista till för Animal men vet inte om det var syftet.
            // Blir konstigt med frågorna annars.


            // 14
            foreach (Animal a in animales)
            {
                if (a is Dog doggie )
                Console.WriteLine($"Stats: {a.Stats()} ");
            }

            //d3.SomeString()
            // 16 - nej
            // 17 - raden         public abstract string SomeString();   saknas i klassen Animal

            foreach (Animal a in animales)
            {
                if (a is Dog doggie)
                    Console.WriteLine($"Stats: {} ");
            }

        }




        private static void Ovning3_3()
        {

            Horse horse = new Horse("Pålle", 759, 12);

            Wolf wolf = new Wolf("Wolfie", 78, 5);
            wolf.IsAlpha = true;
            Wolf wolf2 = new Wolf("Wolfie", 78, 5, true);
            Console.WriteLine(wolf2.IsAlpha);
            Console.WriteLine(wolf2.DoSound());

            Console.WriteLine(horse.Riding);

            Pelican pelle = new Pelican("Pelle", 1, 4);
            pelle.Flying = true;
            Console.WriteLine(pelle.Flying);

            Wolfman ww = new Wolfman("Wolfie", 120, 44);
            Console.WriteLine(ww.Talk());

            // Frågor
            // 13 - Birds för alla fåglar
            // 14 - Animal för alla djur



        }

        private static void Ovning3_2()
        {
            List<UserError> userErrors = new List<UserError>();

            userErrors.Add(new NumericInputError());
            userErrors.Add(new NumericInputError());
            userErrors.Add(new NumericInputError());
            userErrors.Add(new TextInputError());
            userErrors.Add(new TextInputError());
            userErrors.Add(new TextInputError());


            foreach (UserError item in userErrors)
            {
                Console.WriteLine(item.UEMessage());
            }
        }

        private static void Ovning3_1()
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
            Person pers = personHandler.CreatePerson(34, "Sten", "Stanley", 179, 88);

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
