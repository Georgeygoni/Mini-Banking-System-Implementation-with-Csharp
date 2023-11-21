using System;
using System.Collections.Generic;
using System.Text;

namespace Banking_System
{
    class BankAccount
    {
        private static Random random = new Random();

        public static int GenerateRandom7DigitNumber()
        {
            int min = 1000000; // Smallest 7-digit number
            int max = 9999999; // Largest 7-digit number

            return random.Next(min, max + 1);
        }

        public readonly int AccountNo = GenerateRandom7DigitNumber();

        public string AccountHolder { get; set; }

        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public void Withdraw (decimal amount)
        {
            
            if(this.Balance < amount)
            {
                Console.WriteLine("Sorry You have Insufficient Funds for this operation.");
            }
            else
            {
                this.Balance -= amount;
            }
        }

        public override string ToString()
        {
            var outString = $"Account {this.AccountNo}: {this.AccountHolder}, Balance: NGN{this.Balance}";
            return outString;
        }
    }
}
