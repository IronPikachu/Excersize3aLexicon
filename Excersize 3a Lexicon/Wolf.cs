using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersize_3a_Lexicon
{
    class Wolf : Animal
    {
        private bool isAlpha;
        public Wolf(string name, double weight, int age, bool alpha) : base(name, weight, age)
        {
            isAlpha = alpha;
        }

        public override void DoSound()
        {
            Console.WriteLine("Arooooo!");
        }
        public override string Stats()
        {
            return base.Stats() + $"\nAlpha male? {isAlpha}";
        }
    }
}
