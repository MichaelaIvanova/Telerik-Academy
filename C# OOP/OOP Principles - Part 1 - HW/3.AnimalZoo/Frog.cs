using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalZoo
{
    public class Frog:Animal, ISound
    {
        public Frog (string name, int age, bool isMale):base(name, age, isMale)
        {

        }

        public override void Sound()
        {
            Console.WriteLine("kwarK kwak");
        }
    }
}
