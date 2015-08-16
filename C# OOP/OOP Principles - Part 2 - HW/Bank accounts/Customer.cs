using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_accounts
{
    public class Customer
    {
        private string name;
        
        public Customer(string name)
        {
            this.Name = name;
        }
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArithmeticException("You should enter customer's name it is Obligatory!");
                this.name = value; }
        }
    }
}
