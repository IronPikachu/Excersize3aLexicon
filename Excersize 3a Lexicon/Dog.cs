using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersize_3a_Lexicon
{
    class Dog : Animal
    {
        private bool isDangerous;
        public Dog(string name, double weight, int age, bool danger = false) : base(name, weight, age)
        {
            isDangerous = danger;
        }

        public override void DoSound()
        {
            if (isDangerous)
            {
                Console.WriteLine("Bork bork bork!");
            }
            else
            {
                Console.WriteLine("Woof!");
            }
        }
        public override string Stats()
        {
            return base.Stats() + $"\nDangerous? {isDangerous}";
        }
        public string DogMethod()
        {
            return "Dog Method";
        }
    }
}
