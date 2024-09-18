using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_3_1
{
    internal abstract class Animal
    {
        public abstract string Name { get; set; }
        public abstract uint Age { get; set; }
        public abstract double Weight { get; set; }

        public abstract string DoSound();

        public abstract string Stats();


        public Animal(string name, double weight, uint age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

    }

    internal class Horse : Animal
    {
        public Horse(string name, double weight, uint age) : base(name, weight, age)
        {
        }
        public Horse(string name, double weight, uint age, bool riding) : base(name, weight, age)
        {
            Riding = riding;
        }
            
        public bool Riding { get; set; }
        public override string Name { get; set; }
        public override double Weight { get; set; }
        public override uint Age { get; set; }

        public override string DoSound()
        {
            return "Gnägg";
        }

        public override string Stats()
        {
            return $"{Name} {Weight} {Age} {Riding}";
        }
    }

    internal class Dog : Animal
    {
        public Dog(string name, double weight, uint age) : base(name, weight, age)
        {
        }
        public Dog(string name, double weight, uint age, bool ispurebreed) : base(name, weight, age)
        {
            IsPureBreed = ispurebreed;
        }

        public bool IsPureBreed { get; set; }

        public override string Name { get; set; }
        public override double Weight { get; set; }
        public override uint Age { get; set; }


        // 15
        public string SomeString()
        {
            return "Some string about dogs, they bark and smell. Some bite..";
        }
        public override string DoSound()
        {
            return "Bark";
        }

        public override string Stats()
        {
            return $"{Name} {Weight} {Age} {IsPureBreed}";

        }
        
    }
    internal class Hedgehog : Animal
    {
        public Hedgehog(string name, double weight, uint age) : base(name, weight, age)
        {
        }
        public Hedgehog(string name, double weight, uint age, bool likesmilk) : base(name, weight, age)
        {
            LikesMilk = likesmilk;
        }
        public bool LikesMilk { get; set; }
        public override string Name { get; set; }
        public override double Weight { get; set; }
        public override uint Age { get; set; }

        public override string DoSound()
        {
            return "Beeping";
        }

        public override string Stats()
        {
            return $"{Name} {Weight} {Age} {LikesMilk}";
        }
    }
    internal class Worm : Animal
    {
        public Worm(string name, double weight, uint age) : base(name, weight, age)
        {
        }
        public Worm(string name, double weight, uint age, bool ispoisonous) : base(name, weight, age)
        {
            IsPoisonous = ispoisonous;
        }

        public bool IsPoisonous { get; set; }
        public override string Name { get; set; }
        public override double Weight { get; set; }
        public override uint Age { get; set; }

        public override string DoSound()
        {
            return "Sssssssilent";
        }

        public override string Stats()
        {
            return $"{Name} {Weight} {Age} {IsPoisonous}";
        }
    }
    internal class Bird : Animal
    {
        public Bird(string name, double weight, uint age) : base(name, weight, age)
        {
        }
        public Bird(string name, double weight, uint age, bool ismoving) : base(name, weight, age)
        {
            IsMoving = ismoving;
        }
        public bool IsMoving { get; set; }

        public override string Name { get; set; }
        public override double Weight { get; set; }
        public override uint Age { get; set; }

        public override string DoSound()
        {
            return "Tweet";
        }

        public override string Stats()
        {
            return $"{Name} {Weight} {Age} {IsMoving}";
        }
    }
    internal class Wolf : Animal
    {
        public Wolf(string name, double weight, uint age) : base(name, weight, age)
        {
        }
        public Wolf(string name, double weight, uint age, bool isalpha) : base(name, weight, age)
        {
            IsAlpha = isalpha;
        }
        public bool IsAlpha { get; set; }
        public override string Name { get; set; }
        public override double Weight { get; set; }
        public override uint Age { get; set; }

        public override string DoSound()
        {
            return "Howling";
        }

        public override string Stats()
        {
            return $"{Name} {Weight} {Age} {IsAlpha}";
        }
    }

    internal class Pelican : Bird
    {
        public Pelican(string name, double weight, uint age) : base(name, weight, age)
        {
        }

        public Pelican(string name, double weight, uint age, bool ismoving) : base(name, weight, age, ismoving)
        {
        }

        public bool Flying { get; set; }
        public override string Stats()
        {
            return $"{Name} {Weight} {Age} {Flying}";
        }

    }
    internal class Flamingo :Bird
    {
        public Flamingo(string name, double weight, uint age) : base(name, weight, age)
        {
        }

        public Flamingo(string name, double weight, uint age, bool ismoving) : base(name, weight, age, ismoving)
        {
        }

        public bool Fishing { get; set; }
        public override string Stats()
        {
            return $"{Name} {Weight} {Age} {Fishing}";
        }
    }
        
    internal class Swan :Bird
    {
        public Swan(string name, double weight, uint age) : base(name, weight, age)
        {
        }

        public Swan(string name, double weight, uint age, bool ismoving) : base(name, weight, age, ismoving)
        {
        }

        public bool Diving { get; set; }
        public override string Stats()
        {
            return $"{Name} {Weight} {Age} {Diving}";
        }
    }
    internal interface IPerson
    {
        string Name { get; set; }
        string Talk();
    }
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, double weight, uint age) : base(name, weight, age)
        {
        }

        public Wolfman(string name, double weight, uint age, bool isalpha) : base(name, weight, age, isalpha)
        {
        }

        public string Talk()
        {
            return "I'm a werewolf";
        }
        public override string Stats()
        {
            return $"{Name} {Weight} {Age} {IsAlpha}";
        }
    }

}







