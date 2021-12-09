using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAssignment
{
    class Dog : Animal
    {

        private string kind;

        public string Kind
        {
            get { return kind; }
            set
            {
                if (Utils.IsEmptyString(value))
                    throw new ArgumentException("Dog must have a valid Kind.");
                else
                    kind = value;
            }
        }

        public Dog(string name, double weight, int age, string kind) : base(name, weight, age)
        {
            Kind = kind;
        }

        public override void DoSound()
        {
            Console.WriteLine("Bark!!Bark!!");
        }
        public override string Stats()
        {
            return $"Dog Name: {Name} => Age: {Age}, Kind: {Kind}, Weight: {Weight}";
        }

        public string Optional(string optional = "Default option")
        {
            return optional;
        }
    }
}
