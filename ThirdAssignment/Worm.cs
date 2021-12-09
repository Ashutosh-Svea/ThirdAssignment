using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAssignment
{
    class Worm : Animal
    {

        public bool IsPoisonous { get; set; }


        public Worm(string name, double weight, int age, bool isPoisonous) : base(name, weight, age)
        {
            IsPoisonous = isPoisonous;
        }

        public override void DoSound()
        {
            Console.WriteLine("Worm pop!");
        }

        public override string Stats()
        {
            return $"Worm Name: {Name} => Age: {Age}, IsPoisonous: {IsPoisonous}, Weight: {Weight}";
        }
    }
}
