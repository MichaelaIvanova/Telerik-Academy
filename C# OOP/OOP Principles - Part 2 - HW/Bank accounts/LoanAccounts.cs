using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_accounts
{
    public class LoanAccounts:Account,IDepositable
    {
        public LoanAccounts(Customer customer, double balance, double interestRate)
            : base(customer, balance, interestRate)
        {

        }

        //Loan and mortgage accounts can only deposit money.

        public void DepositMoney(double money)
        {
             if (money <0)
            {
                throw new ArgumentOutOfRangeException("Put only positve values for money and donnot bother:)");
            }
            this.Balance += money;
        }

        //Loan accounts have no interest for the first 3 months if are held by individuals
         //and for the first 2 months if are held by a company.

        public override double InterestAmount(uint months)
        {
            bool noInterestCompany = months == 1 || months == 2;
            bool noInterestIndividual = noInterestCompany || months == 3;
            
            if (noInterestCompany && this.Customer is CompanyCustomer)
            {
                return 0.0;
            }
            if (noInterestIndividual && this.Customer is IndividualCustomer)
            {
                return 0.0;
            }
            if (this.Customer is CompanyCustomer)
                return base.InterestAmount(months-2);
            else
                return base.InterestAmount(months - 3);
        }
   }
}
