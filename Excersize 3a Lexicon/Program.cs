/* F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det?
 * S: Bird
 * F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
 * S: Animal
 * F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
 * S: Olika datatyper, bara för att de ärver från samma klass betyder inte att de är exakt samma
 * F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
 * S: Animal, basernas basklass. 
 * F: Förklara vad det är som händer.
 * S: Bruh
 * F: Varför inte?
 * S: Animal innehåller inte den metoden, men Dog gör det. Enligt stacken är det en Animal, även om det är en Dog i heapen.
 */
using System;
using System.Collections.Generic;

namespace Excersize_3a_Lexicon
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            List<Animal> list = new List<Animal>();
            string[] names = {"Fido", "Bellman", "Kalle", "Bjorn", "Sture", "Sten", "Herman", "Giovanni", "Chatot", "Karin", "Kerstin", "David", "Anders", "Alice", "Maja", "Elsa", "Astrid", "Wilma", "Freja", "Olivia", "Selma", "Alma", "Ella", "Noah", "William", "Hugo", "Lucas", "Liam", "Oscar", "Oliver", "Matteo", "Elias", "Adam"};
            for(int i = 0; i < 25; i++)
            {
                switch (rnd.Next(10))
                {
                    case 0:
                        list.Add(new Dog(names[rnd.Next(names.Length)], rnd.NextDouble() * 160, rnd.Next(0, 16)));
                        break;
                    case 1:
                        list.Add(new Hedgehog(names[rnd.Next(names.Length)], rnd.NextDouble() * 5, rnd.Next(0, 5), rnd.Next(100, 1000)));
                        break;
                    case 2:
                        bool psn = false;
                        if (rnd.Next(2) == 0)
                            psn = true;
                        list.Add(new Worm(names[rnd.Next(names.Length)], rnd.NextDouble() * 25, rnd.Next(0, 20), psn));
                        break;
                    case 3:
                        list.Add(new Bird(names[rnd.Next(names.Length)], rnd.NextDouble() * 300, rnd.Next(0, 100), rnd.NextDouble() * 300));
                        break;
                    case 4:
                        bool alf = false;
                        if (rnd.Next(16) == 0)
                            alf = true;
                        list.Add(new Wolf(names[rnd.Next(names.Length)], rnd.NextDouble() * 100, rnd.Next(0, 20), alf));
                        break;
                    case 5:
                        list.Add(new Pelican(names[rnd.Next(names.Length)], rnd.NextDouble() * 40, rnd.Next(0, 25), rnd.NextDouble()* 250, "Fish"));
                        break;
                    case 6:
                        list.Add(new Flamingo(names[rnd.Next(names.Length)], rnd.NextDouble() * 30, rnd.Next(0, 30), rnd.NextDouble() * 230));
                        break;
                    case 7:
                        list.Add(new Swan(names[rnd.Next(names.Length)], rnd.NextDouble() * 20, rnd.Next(0, 11), rnd.NextDouble() * 350));
                        break;
                    case 8:
                        list.Add(new Wolfman(names[rnd.Next(names.Length)], rnd.NextDouble() * 160, rnd.Next(0, 83)));
                        break;
                    case 9:
                        bool canTalk = false;
                        if (rnd.Next(100) == 0)
                            canTalk = true;
                        list.Add(new Horse(names[rnd.Next(names.Length)], rnd.NextDouble() * 160, rnd.Next(0, 16), canTalk));
                        break;
                    default:
                        Console.WriteLine("wtf");
                        break;
                }
            }
            foreach(Animal animal in list)
            {
                Console.WriteLine(animal.GetType().Name);
                animal.DoSound();
                if(animal.GetType().Name == "IPerson" || animal.GetType().Name == "Wolfman")
                {
                    ((IPerson)animal).Talk();
                }
                Console.WriteLine();
            }
            Console.WriteLine("-");
            List<Dog> dogs = new List<Dog>();
            for(int i = 0; i < 10; i++)
            {
                dogs.Add(new Dog(names[rnd.Next(names.Length)], rnd.NextDouble() * 160, rnd.Next(0, 16)));
            }
            //dogs.Add(new Horse(names[rnd.Next(names.Length)], rnd.NextDouble() * 160, rnd.Next(0, 16)));
            foreach(Animal animal in list)
            {
                Console.WriteLine(animal.GetType().Name);
                Console.WriteLine(animal.Stats());
                Console.WriteLine();
            }
            Console.WriteLine("-");
            foreach (Animal animal in list)
            {
                if(animal.GetType().Name == "Dog")
                {
                    Console.WriteLine(animal.Stats());
                    Console.WriteLine();
                }
            }
            Console.WriteLine("-");
            foreach (Animal animal in list)
            {
                if (animal.GetType().Name == "Dog")
                {
                    Console.WriteLine(((Dog)animal).DogMethod());
                    Console.WriteLine();
                }
            }
            /*----------------------------------------------------*/
            List<UserError> userErrors = new List<UserError>();
            for(int i = 0; i < 50; i++)
            {
                switch (rnd.Next(5))
                {
                    case 0:
                        userErrors.Add(new NumericInputError());
                        break;
                    case 1:
                        userErrors.Add(new TextInputError());
                        break;
                    case 2:
                        userErrors.Add(new DoubleError());
                        break;
                    case 3:
                        userErrors.Add(new InvalidError());
                        break;
                    case 4:
                        userErrors.Add(new ValidError());
                        break;
                    default:
                        Console.WriteLine("wtf");
                        break;
                }
            }
            foreach(UserError error in userErrors)
            {
                Console.WriteLine(error.UEMessage());
            }
        }
    }
}
