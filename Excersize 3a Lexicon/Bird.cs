using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersize_3a_Lexicon
{
    class Bird : Animal
    {
        private double wingSpan;
        public Bird(string name, double weight, int age, double span) : base(name, weight, age)
        {
            wingSpan = span; 
        }

        public override void DoSound()
        {
            Console.WriteLine("Cacaw!");
        }
        public override string Stats()
        {
            return base.Stats() + $"\nWingspan: {wingSpan}";
        }
    }
}
