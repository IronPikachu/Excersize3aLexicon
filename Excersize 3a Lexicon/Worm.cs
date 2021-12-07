using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersize_3a_Lexicon
{
    class Worm : Animal
    {
        private bool isPoisonous;
        public Worm(string name, double weight, int age, bool poisonous) : base(name, weight, age)
        {
            isPoisonous = poisonous;
        }

        public override void DoSound()
        {
            Console.WriteLine("squiggle squiggle");
        }
        public override string Stats()
        {
            return base.Stats() + $"\nPoisonous? {isPoisonous}";
        }
    }
}
