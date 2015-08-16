using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_accounts
{
    public class Account
    {
        //All accounts have customer, balance and interest rate (monthly based).
        private Customer customer;
        private double balance;
        private double interestRate;

        public Account (Customer customer, double balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer { get; private set; }

        public double Balance
        {
            get { return this.balance; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Initial Balance cannot be negative, but you can chane it later on:)");
                }

                this.balance = value;
            }
        }

        public double InterestRate { get; private set; }

        // All accounts can calculate their interest amount for a given period (in months).
        //In the common case its is calculated as follows: number_of_months * interest_rate.

        public virtual double InterestAmount (uint months)
        {
            return this.InterestRate * months;
        }
    }
}
