using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Transactions
{
    public  class Transactions
    {
        public int cash=5000;
        public void Desposit()
        {
            Console.WriteLine("Enter the amount that want to deposite");
            int mon=Convert.ToInt32(Console.ReadLine());
            cash= mon + cash;
            Console.WriteLine("The Remaining balance is " + cash);
        }
        public void Withdrawal()
        {
            Console.WriteLine("Enter the amount that want to withdraw");
            int mon = Convert.ToInt32(Console.ReadLine());
            if(cash<mon)
            {
                Console.WriteLine("The account has a insufficient amount");
            }
            else if(cash<=mon)
            {
                Console.WriteLine("The account should have a minimum balance");
            }
            else
            {
                cash = cash - mon;
                Console.WriteLine("The Money Withdrawal successfully");
                Console.WriteLine("The Remaining balance is " +cash);

            }
        }
        public void CheckBalance()
        {
            Console.WriteLine("The Total balance is "+cash);
        }
    }
}
