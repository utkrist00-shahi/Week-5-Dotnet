using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class BankAccount
    {
        private string accountNumber;
        private double balance;

        public String getAccountNumber()
        {
            return accountNumber;
        }
        public double getBalance()
        {
            return balance;
        }
        private void setBalance(double value)
        {
            if (value < 0) value = 0;
            balance = value;  
        }
        public BankAccount(string acc)
        {
            accountNumber = acc;
        }
        public void Deposit(double amount)
        {
            if (amount <= 0) return;
            setBalance(getBalance() + amount);
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0 || amount > getBalance()) return;
           setBalance(getBalance() - amount);
        }

    }
}
