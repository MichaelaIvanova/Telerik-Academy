using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalZoo
{
    public class TomCat: Cat, ISound
    {
        public TomCat(string name, int age): base (name, age, true)// we can hardcore it
        {

        }
        public override void Sound()
        {
            Console.WriteLine("meaw meawwww I am a Male TomCat");
        }
    }
}
