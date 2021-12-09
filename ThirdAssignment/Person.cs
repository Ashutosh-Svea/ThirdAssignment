using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAssignment
{
    class Person
    {
        public Person (int _age, string _fname, string _lname, double _height, double _weight)
        {
            Age = _age;
            FName = _fname;
            LName = _lname;
            Height = _height;
            Weight = _weight;
        }
        private int age;

        public int Age
        {
            get { return age; }
            set 
            {
                if (value < 0)
                    throw new ArgumentException("Age must be greater than 0");

                age = value; 
            }
        }

        private string fName;

        public string FName
        {
            get { return fName; }
            set 
            {
                if (value == null)
                    throw new ArgumentException("Invalid First Name");
                if (Utils.IsEmptyString(value))
                    throw new ArgumentException("Empty First Name");
                if (!Utils.IsStringInBound(value, 2, 10))
                    throw new ArgumentException("First Name must be atleast 2 character and atmost 10 characters");

                    fName = value; 
            }
        }

        private string lName;

        public string LName
        {
            get { return lName; }
            set 
            {
                if (value == null)
                    throw new ArgumentException("Invalid Last Name");
                if (Utils.IsEmptyString(value))
                    throw new ArgumentException("Empty Last Name");
                if (!Utils.IsStringInBound(value, 3, 15))
                    throw new ArgumentException("Last Name must be atleast 3 character and atmost 15 characters");

                lName = value; 
            }
        }

        private double height;

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        private double weight;

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public override string ToString()
        {
            return $"{FName} {LName}  => Age: {Age}, Height: {Height}, Weight: {Weight}";
        }

    }
}
