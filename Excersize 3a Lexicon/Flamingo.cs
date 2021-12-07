using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersize_3a_Lexicon
{
    class Flamingo : Bird
    {
        public Flamingo(string name, double weight, int age, double span) : base(name, weight, age, span)
        {
        }
        public void DoFlamingoThing()
        {
            Console.WriteLine("Floats menacingly...");
        }
    }
}
