using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Banking_System
{
    class Bank
    {
        public List<BankAccount> AllAccounts = new List<BankAccount>();
        public void CreateAccount(string AccountHolderName)
        {
            var newBankAccount = new BankAccount();

            newBankAccount.AccountHolder = AccountHolderName;
            newBankAccount.Balance = 0;

            AllAccounts.Add(newBankAccount);
            
            Console.WriteLine("A new Account number has been created with the following details: " + newBankAccount.ToString());
        }

        public BankAccount GetAccount(int AccountNo)
        {
            
            var bankAccount = AllAccounts.FirstOrDefault(p => p.AccountNo == AccountNo);

            if (bankAccount != null)
                return bankAccount;
            else
                Console.WriteLine("No Bank account found with that account number, Please check the number and try again");

            return null;
            
        }

        public void PrintAllAccounts()
        {
            if (AllAccounts.Count() > 0)
            {
                foreach (var account in AllAccounts)
                {
                    Console.WriteLine(account.ToString());
                }
            }
            else
                Console.WriteLine("No new accounts created");
        }

        public void Withdrawal(int accountNo, decimal amount)
        {
            var account = GetAccount(accountNo);

            if (account != null)
            {
                account.Withdraw(amount);
            }
            else
                Console.WriteLine("Invalid Account");
                
        }

        public void DepositToAccount(int accountNo, decimal amount)
        {
            var account = GetAccount(accountNo);

            if (account != null)
            {
                account.Deposit(amount);
            }
            else
                Console.WriteLine("Invalid Account");
        }
    }
}
