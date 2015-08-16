using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_accounts
{
    public  class MortgageAccount: Account, IDepositable
    {
        public MortgageAccount (Customer customer, double balance, double interestRate)
            : base (customer, balance, interestRate)
        { 
        }

        //Loan and mortgage accounts can only deposit money.

        
        //Mortgage accounts have ½ interest for the first 12 months for companies and 
        //no interest for the first 6 months for individuals.
        public override double InterestAmount(uint months)
        {
            bool halfInterestCompany = months <=12;
            bool noInterestIndividual = months <= 6;

            if (halfInterestCompany && this.Customer is CompanyCustomer)
            {
                return base.InterestAmount(months) / 2;
            }
            if (noInterestIndividual && this.Customer is IndividualCustomer)
            {
                return 0.0;
            }
            else
                return base.InterestAmount(months);
        }

        public void DepositMoney(double money)
        {
            if (money < 0)
            {
                throw new ArgumentOutOfRangeException("Put only positve values for money and donnot bother:)");
            }
            this.Balance += money;
        }
    }
}
