using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersize_3a_Lexicon
{
    class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, double weight, int age, bool alpha = false) : base(name, weight, age, alpha)
        {
        }

        void IPerson.Talk()
        {
            Console.WriteLine("I'm not a werewolf. I am WOLFMAN!");
        }
    }
}
