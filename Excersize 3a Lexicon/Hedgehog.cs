using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersize_3a_Lexicon
{
    class Hedgehog : Animal
    {
        private int nrOfSpikes;
        public Hedgehog(string name, double weight, int age, int spikes) : base(name, weight, age)
        {
            nrOfSpikes = spikes;
        }

        public override void DoSound()
        {
            Console.WriteLine("Squeal? SQL?");
        }
        public override string Stats()
        {
            return base.Stats() + $"\nSpikes: {nrOfSpikes}";
        }
    }
}
