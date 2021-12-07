using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersize_3a_Lexicon
{
    class Pelican : Bird
    {
        private string eatsFood;
        public Pelican(string name, double weight, int age, double span, string food) : base(name, weight, age, span)
        {
            eatsFood = food;
        }

        public void DoPelicanThing()
        {
            Console.WriteLine($"poops {eatsFood} bones");
        }
        public override string Stats()
        {
            return base.Stats() + $"\nLikes: {eatsFood}";
        }
    }
}
