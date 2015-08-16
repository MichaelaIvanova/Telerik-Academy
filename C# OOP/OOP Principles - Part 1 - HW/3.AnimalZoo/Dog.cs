using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalZoo
{
    public class Dog : Animal, ISound
    {
        public Dog(string name, int age, bool isMale)
            : base(name, age, isMale)
        {

        }

        public override void Sound()
        {
            Console.WriteLine("bau bau");
        }
    }
}
