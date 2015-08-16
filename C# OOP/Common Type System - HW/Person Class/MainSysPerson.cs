using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person_Class
{
   public  class MainSysPerson
    {
        static void Main(string[] args)
        {
            Person pesho = new Person("Pesho", 20);
            Console.WriteLine(pesho.ToString());
            Person gosho = new Person("Gosho");
            Console.WriteLine(gosho.ToString());
        }
    }
}
