using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataCanAssignment.Models;

namespace DataCanAssignment.Models
{
    public class BankAccount
    {
        public decimal Balance { get; private set; }

        public BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public void Deposit(decimal amount, CurrencyType currencyType)
        {
            Balance += currencyType.ConvertToCad(amount);
        }

        public void Withdraw(decimal amount, CurrencyType currencyType)
        {
            decimal amountInCad = currencyType.ConvertToCad(amount);
            if (Balance >= amountInCad)
            {
                Balance -= amountInCad;
            }
        }

    }
}