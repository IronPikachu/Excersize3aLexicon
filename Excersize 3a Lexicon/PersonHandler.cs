using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersize_3a_Lexicon
{
    class PersonHandler
    {
        public List<Person> peoples = new List<Person>();
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            return new Person
            {
                Age = age,
                FName = fname,
                LName = lname,
                Height = height,
                Weight = weight
            };
        }
        public void AddPerson(int age, string fname, string lname, double height, double weight)
        {
            peoples.Add(CreatePerson(age, fname, lname, height, weight));
        }
        public int Age(int i)
        {
            peoples[i].Age++;
            Console.WriteLine($"{peoples[i].FName} {peoples[i].LName} is now {peoples[i].Age} years old.");
            Random rnd = new Random();
            if(peoples[i].Age >= 150)
            {
                Console.WriteLine($"{peoples[i].FName} has died of age...");
                peoples.Remove(peoples[i]);
                return --i;
            }
            else if(rnd.Next(150 - peoples[i].Age) == 0)
            {
                Console.WriteLine($"{peoples[i].FName} has died of age...");
                peoples.Remove(peoples[i]);
                return --i;
            }
            return i;
        }
        public void GrowOrShrink(int i, double delta)
        {
            peoples[i].Height += delta;
            Console.WriteLine($"{peoples[i].FName} {peoples[i].LName} is now {peoples[i].Height} cm tall.");
        }
        public void GainOrLoseWeight(int i, double delta)
        {
            peoples[i].Weight += delta;
            Console.WriteLine($"{peoples[i].FName} {peoples[i].LName} now weights {peoples[i].Weight} kg.");
        }
    }
}
