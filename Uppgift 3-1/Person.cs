using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_3_1
{
    internal class Person
    {
      
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        // Publika properties med validering och kastning av undantag
        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Ålder måste vara större än 0.");
                }
                age = value;
            }
        }

        public string FName
        {
            get { return fName; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Name, between 2-10 chars");
                }
                fName = value;
            }
        }

        public string LName
        {
            get { return lName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Lastname, between 3-15 chars.");
                }
                lName = value;
            }
        }

        public double Height
        {
            get { return height; }
            set
            {
                height = value;
            }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                 weight = value;
            }
        }

        // Konstruktorn 
        public Person(int age, string fName, string lName, double height, double weight)
        {
            Age = age;
            FName = fName;
            LName = lName;
            Weight = weight;
            Height = height;
        }

        // Overloadar för att kunna skapa utan weight och height
        public Person(int age, string fName, string lName)
        {
            Age = age;
            FName = fName;
            LName = lName;
        }
    }

    }
