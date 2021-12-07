using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersize_3a_Lexicon
{
    class Swan : Bird
    {
        public Swan(string name, double weight, int age, double span) : base(name, weight, age, span)
        {
        }
        public void DoSwanThing()
        {
            Console.WriteLine("Screeches");
        }
    }
}
