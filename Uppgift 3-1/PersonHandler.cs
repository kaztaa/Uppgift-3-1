﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_3_1
{
    internal class PersonHandler
    {
        public Person CreatePerson(int age, string fName, string lName, double height, double weight)
        {
            return new Person(age, fName, lName, height, weight);

        }

        public Array PrintPerson(Person person)
        {
            string[] per = {person.FName, person.LName };
            
            Console.WriteLine($"Age: {person.Age}");
            Console.WriteLine($"Name: {person.LName}");
            Console.WriteLine($"Last name: {person.FName}");
            Console.WriteLine($"Height: {person.Height}");
            Console.WriteLine($"Weight: {person.Weight}");
            return per;

        }


        // Sätter olika värden hos Person
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
        public void SetFName(Person pers, string fName)
        {
            pers.FName = fName;
        }
        public void SetLName(Person pers, string LName)
        {
            pers.LName = LName;
        }
        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }
        public void SetWeight(Person pers, double wheight)
        {
            pers.Weight = wheight;
        }


        // Returnerar olika värden hos Person
        public int GetAge(Person pers, int age)
        {
            return age;
        }
        public string GetFName(Person pers, string fName)
        {
            return fName;
        }
        public string GetLName(Person pers, string LName)
        {
            return LName;
        }
        public double GetHeight(Person pers, double height)
        {
            return height;
        }
        public double GetWheight(Person pers, double wheight)
        {
            return wheight;
        }
    }
}