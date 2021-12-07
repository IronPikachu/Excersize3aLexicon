using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersize_3a_Lexicon
{
    public class Horse: Animal
    {
        private bool canTalk;

        public Horse(string name, double weight, int age, bool talk = false): base(name, weight, age)
        {

        }

        public override void DoSound()
        {
            if (canTalk)
            {
                Console.WriteLine("I can speak!!!");
            }
            else
            {
                Console.WriteLine("Neigh!");
            }
        }
    }
}
