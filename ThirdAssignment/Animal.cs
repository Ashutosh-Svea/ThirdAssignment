using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAssignment
{
    abstract class Animal
    {
        public Animal (string _name, double _weight, int _age)
        {
            name = _name;

        }
        public string name { get; set; }
        public double weight { get; set; }
        public int age { get; set; }

        public abstract void DoSound();



    }
}
