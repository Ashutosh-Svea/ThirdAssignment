using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAssignment
{
    class Bird : Animal
    {

        private double  wingSpan;

        public double  WingSpan
        {
            get { return wingSpan; }
            set 
            {
                if (value > 0)
                    wingSpan = value;
                else
                    throw new ArgumentException(" Wingspan of bird must be greater than 0");
            }
        }


        public Bird(string name, double weight, int age, double wingSpan) : base(name, weight, age)
        {
            WingSpan = wingSpan;
        }

        public override void DoSound()
        {
            Console.WriteLine("Bird Chirp!");
        }

        public override string Stats()
        {
            return $"Bird Name: {Name} => Age: {Age}, Wingspan : {WingSpan}, Weight: {Weight}";
        }
    }

}
