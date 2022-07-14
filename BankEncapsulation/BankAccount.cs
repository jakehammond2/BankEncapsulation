using System;
namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount()
        {
            
        }

        private double balance = 0;

        
        public void Deposit(double inputdep)
        {
            balance += inputdep;
        }

        public double GetBalance()
        {
            return balance; 
        }

        public void Withdrawel(double inputwithdrawel)
        {
            balance -= inputwithdrawel;  
        }

    }
}

