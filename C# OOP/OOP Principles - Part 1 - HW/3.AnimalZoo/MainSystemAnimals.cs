using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalZoo
{
    class MainSystemAnimals
    {
        static void Main(string[] args)
        {
            //Test
            Animal mammal = new Animal("mammal", 2, true);
            mammal.Sound();
            Dog doggy = new Dog("Doggu", 1, true);
            Console.WriteLine(doggy.Name);
            doggy.Sound();
            Kitten kity = new Kitten("kity", 9);
            kity.Sound();

            //Create arrays of different kinds of animals and calculate the average 
            //age of each kind of animal using a static method (you may use LINQ).
            Dog[] dogs = new Dog[]
            {
                new Dog("Jaro", 7, true),
                new Dog("Sharo", 3, true),
                new Dog("Doge", 5, true),
                new Dog("Estel", 10, false)
            };

            Frog[] frogs = new Frog[]
            {
                new Frog("Kikirica", 13, false),
                new Frog("Jaba", 15, false),
                new Frog("Froggy", 5, true),
                new Frog("Nikoleta Lozanova", 10, false)
            };

            Cat[] cats = new Cat[] 
            {
                new Cat("Street Excellent", 3, false),
                new Cat("Home Excellent", 5, false),
                new Cat("Persiiko", 1, true),
                new Cat("Garfield", 7, true)
            };

            Kitten[] kittens = new Kitten[]
            {
                new Kitten("Malcho", 1),
                new Kitten("Palcho", 2),
                new Kitten("Shalco", 1)
            
            };

            TomCat[] tomcats = new TomCat[]
            {
                new TomCat("Kotio", 5),
                new TomCat("Gosho", 4),
                new TomCat("Pesho", 8)
            };

            double dogsAverageAge = Animal.AverageAge(dogs);
            double frogsAverageAge = Animal.AverageAge(frogs);
            double catsAverageAge = Animal.AverageAge(cats);
            double kittensAverageAge = Animal.AverageAge(kittens);
            double tomcatsAverageAge = Animal.AverageAge(tomcats);

            Console.WriteLine("Average age of the dogs: {0:F2}", dogsAverageAge);
            Console.WriteLine("Average age of the frogs: {0:F2}", frogsAverageAge);
            Console.WriteLine("Average age of the cats: {0:F2}", catsAverageAge);
            Console.WriteLine("Average age of the kittens: {0:F2}", kittensAverageAge);
            Console.WriteLine("Average age of the tomcats: {0:F2}", tomcatsAverageAge);

        }
    }
}
