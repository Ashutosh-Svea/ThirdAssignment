using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAssignment
{
    class Horse : Animal
    {

        private int speed;

        public int Speed
        {
            get { return speed; }
            set 
            {
                if (value > 0)
                    speed = value; 
                else
                    throw new ArgumentException("Speed of horse must be greater than 0");
            }
        }

        public Horse(string name, double weight, int age, int speed) : base (name, weight, age)
        {
            Speed = speed;
        }

        public override void DoSound()
        {
            Console.WriteLine("Neigh!!Neigh!!");
        }
        public override string Stats()
        {
            return $"Horse Name: {Name} => Age: {Age}, Speed: {Speed}, Weight: {Weight}";
        }
    }
}
