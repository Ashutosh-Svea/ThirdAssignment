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
            Weight = _weight;
            Age = _age;
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Invalid Name");
                if (Utils.IsEmptyString(value))
                    throw new ArgumentException("Empty Name");

                name = value;
            }
        }

        private double weight;
        public double Weight
        {
            get { return weight; }
            set
            {
                if (Utils.IsValidHeight(value))
                    weight = value;
                else
                    throw new ArgumentException("Invalid weight entered.");
            }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (!Utils.IsValidAge(value))
                    throw new ArgumentException("Age must be greater than 0");

                age = value;
            }
        }


        public abstract void DoSound();

        public abstract string Stats();

    }
}
