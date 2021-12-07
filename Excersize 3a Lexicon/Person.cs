using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersize_3a_Lexicon
{
    class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException($"{nameof(Age)}, {value} is too young!");
                }
                age = value;
            }
        }
        public string FName
        {
            get
            {
                return fName;
            }
            set
            {
                if(value.Length < 2)
                {
                    throw new ArgumentException($"{nameof(FName)}, {value} is too short!");
                }
                else if(value.Length > 10)
                {
                    throw new ArgumentException($"{nameof(FName)}, {value} is too long!");
                }
                fName = value;
            }
        }
        public string LName
        {
            get
            {
                return lName;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException($"{nameof(LName)}, {value} is too short!");
                }
                else if (value.Length > 15)
                {
                    throw new ArgumentException($"{nameof(LName)}, {value} is too long!");
                }
                lName = value;
            }
        }
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }

        public Person(string fname, string lname)
        {
            FName = fname;
            LName = lname;
        }
    }
}
