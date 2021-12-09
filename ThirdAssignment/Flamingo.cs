using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAssignment
{
    class Flamingo : Bird
    {

        private double height;

        public double Height
        {
            get { return height; }
            set 
            { 
                if (Utils.IsValidHeight(height))
                    height = value; 
                else
                    throw new ArgumentException("Invalid height entered.");

            }
        }

        public Flamingo(string name, double weight, int age, double wingSpan, double height) : base(name, weight, age, wingSpan)
        {
            Height = height;
        }

        public override string Stats()
        {
            return $"Flamingo Name: {Name} => Age: {Age}, Wingspan : {WingSpan}, Weight: {Weight}, Height: {height}";
        }
    }
}
