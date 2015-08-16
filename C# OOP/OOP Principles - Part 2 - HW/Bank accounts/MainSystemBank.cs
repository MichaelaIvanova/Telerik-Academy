using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_accounts
{
    class MainSystemBank
    {
        static void Main(string[] args)
        {
            IndividualCustomer pesho = new IndividualCustomer("Pesho");
            CompanyCustomer telerik = new CompanyCustomer("Telerik");

            LoanAccounts loanAcc = new LoanAccounts(pesho, 250, 25);
            DepositAccount depositAcc = new DepositAccount(telerik, 10000, 20);
            
            Console.WriteLine(loanAcc.Balance);
            loanAcc.DepositMoney(200);
            Console.WriteLine(loanAcc.Balance);
            depositAcc.DrawMoney(3300);
            Console.WriteLine(depositAcc.Balance);
            Console.WriteLine(loanAcc.InterestAmount(3));
            Console.WriteLine(loanAcc.InterestAmount(7));
        }
    }
}
