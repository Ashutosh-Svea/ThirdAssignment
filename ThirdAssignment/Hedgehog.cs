using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAssignment
{
    class Hedgehog : Animal
    {

        private int noOfSpikes;

        public int NoOfSpikes
        {
            get { return noOfSpikes; }
            set
            {
                if (value < 1)
                    throw new ArgumentException("Hedgehog must have atleast one spike.");
                else
                    noOfSpikes= value;
            }
        }

        public Hedgehog(string name, double weight, int age, int spikes) : base(name, weight, age)
        {
            NoOfSpikes = spikes;
        }

        public override void DoSound()
        {
            Console.WriteLine("hedgehog purrr! shreek! whistle!");
        }

        public override string Stats()
        {
            return $"Hedgehog Name: {Name} => Age: {Age}, No Of Spikes: {NoOfSpikes}, Weight: {Weight}";
        }
    }
}
