using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalZoo
{
    public class Animal:ISound
    {
        private string name;
        private int age;
        private bool isMale;

        public Animal(string name, int age, bool isMale)
        {
            this.Name = name;
            this.Age = age;
            this.isMale = isMale;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            private set { this.age = value; }
        }

        public bool IsMale
        {
            get { return this.isMale; }
            set { this.isMale = value; }
        }
        public virtual void Sound()
        {
            Console.WriteLine("no sound yet");
        }
        
        // the common static met
        public static double AverageAge(Animal[] arr)
        {
            return arr.Average(x => x.Age);
        }
    }
}
