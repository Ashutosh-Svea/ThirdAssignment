using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAssignment
{
    class Pelican : Bird
    {
        public Utils.BirdColor Color{ get; set; }

        public Pelican(string name, double weight, int age, double wingSpan, Utils.BirdColor color) : base(name, weight,age,wingSpan)
        {
            Color = color;
        }

        public override string Stats()
        {
            return $"Pelican Name: {Name} => Age: {Age}, Wingspan : {WingSpan}, Weight: {Weight}, Color: {Color}";
        }
    }
}
