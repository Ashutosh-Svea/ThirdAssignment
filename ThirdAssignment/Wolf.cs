using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAssignment
{
    class Wolf : Animal
    {
        private int strength;

        public int Strength
        {
            get { return strength; }
            set
            {
                if (value > 0)
                    strength = value;
                else
                    throw new ArgumentException("Strength of wolf must be greater than 0");
            }
        }

        public Wolf(string name, double weight, int age, int strength) : base(name, weight, age)
        {
            Strength = strength;
        }

        public override void DoSound()
        {
            Console.WriteLine("Wolf Howl!");
        }

        public override string Stats()
        {
            return $"Wolf Name: {Name} => Age: {Age}, Wolf Strength : {Strength}, Weight: {Weight}";
        }
    }
}

