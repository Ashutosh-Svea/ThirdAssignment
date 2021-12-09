using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAssignment
{
    class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, double weight, int age, int strength) : base(name,weight, age,strength)
        {

        }
        public void Talk()
        {
            Console.WriteLine("Wolfman says this in the Talk function of Wolfman!");

        }
    }
}
