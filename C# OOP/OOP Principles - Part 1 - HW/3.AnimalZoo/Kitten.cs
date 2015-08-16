using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalZoo
{
    public class Kitten: Cat, ISound
    {
        public Kitten(string name, int age): base (name, age, false)// we can hardcore it
        {

        }
        public override void Sound()
        {
            Console.WriteLine("meaw meawwww I am a female Kity");
        }
    }
}
