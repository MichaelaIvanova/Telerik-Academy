using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_accounts
{
    public class DepositAccount: Account, IDepositable, IDrawable
    {
        public DepositAccount (Customer customer, double balance, double interestRate)
            : base (customer, balance, interestRate)
        {

        }
        //Deposit accounts are allowed to deposit and with draw money.
        public void DepositMoney(double money)
        {
            if (money <0)
            {
                throw new ArgumentOutOfRangeException("Put only positve values for money and donnot bother");
            }
            this.Balance += money;
        }

        public void DrawMoney(double money)
        {
            if (money <0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if(money > this.Balance)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.Balance -= money;
        }
       

        //Deposit accounts have no interest if their balance is positive and less than 1000.
        public override double InterestAmount(uint months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                Console.WriteLine("No interest amount for balance les than 1000 and more tha 0, I am a deposit account");
                return 0;
            }
            else
                return base.InterestAmount(months);
        }



        
    }
}
