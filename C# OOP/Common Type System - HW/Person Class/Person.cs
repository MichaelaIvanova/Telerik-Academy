using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Class
{
   public class Person
    {
       private string name;
       private uint? age;

       public Person(string name, uint? age = null)
       {
           this.Name = name;
           this.Age = age;
       }


       public string Name { get; private set; }

       public uint? Age { get; private set; }

       //Override ToString() to display the information of a person and if age is not specified – to say so.
       public override string ToString()
       {
           if (this.Age == null)
               return this.Name + " Age is not specified";
           else
           return this.Name + " " + this.Age;
       }
    }
}
