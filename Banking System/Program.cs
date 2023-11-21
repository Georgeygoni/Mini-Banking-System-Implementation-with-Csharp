using System;

namespace Banking_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var newBank = new Bank();
            end:
            Console.WriteLine("Hello Welcome to The Prestige Banking System");
            Console.WriteLine("What Will you like to do Today? Please input your selection");
            Console.WriteLine();
        begin:
            Console.Write("1. Open or Create An Account \n 2. Check Account Balance \n 3. Deposit To Account \n 4. Widthraw From Account \n 5. Check Account Details \n 6. List All Accounts");
            Console.WriteLine();
            var input = Convert.ToInt32(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Please Input Account Holder Full Name");
                    var accountHolderName = Console.ReadLine();
                    newBank.CreateAccount(accountHolderName);
                    break;
                case 2:
                    Console.WriteLine("Please Input Account Number");
                    var accountNo = Convert.ToInt32(Console.ReadLine());
                    var account = newBank.GetAccount(accountNo);
                    if (account != null)
                    {
                        var balance = account.Balance;
                        Console.WriteLine("Account Balance is: " + balance);
                    }
                    else
                    {
                        Console.WriteLine("Invalid Account Number");
                    }
                    break;
                case 3:
                    Console.WriteLine("Please Input Account Number: ");
                    var dep_accountNo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please Input Amount to Deposit: ");
                    var dep_amount = Convert.ToDecimal(Console.ReadLine());
                    newBank.DepositToAccount(dep_accountNo, dep_amount);
                    var dep_account = newBank.GetAccount(dep_accountNo);
                    if(dep_account != null)
                    {
                        var new_balance = dep_account.Balance;
                        Console.WriteLine("New Account Balance: " + new_balance);
                    }
                    break;
                case 4:
                    Console.WriteLine("Please Input Account Number: ");
                    var withdraw_accountNo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please Input Amount to Withdraw: ");
                    var withdraw_amount = Convert.ToDecimal(Console.ReadLine());
                    newBank.Withdrawal(withdraw_accountNo, withdraw_amount);
                    var withdraw_account = newBank.GetAccount(withdraw_accountNo);
                    if (withdraw_account != null)
                    {
                        var new_balance = withdraw_account.Balance;
                        Console.WriteLine("New Account Balance: " + new_balance);
                    }
                    break;
                case 5:
                    Console.WriteLine("Please Input Account Number");
                    var det_accountNo = Convert.ToInt32(Console.ReadLine());
                    var det_account = newBank.GetAccount(det_accountNo);
                    if (det_account != null)
                    {
                        var account_balance = det_account.Balance;
                        var account_name = det_account.AccountHolder;
                        var account_number = det_account.AccountNo;
                        Console.WriteLine("-------Your Account Details------------");
                        Console.Write("Account Number: " + account_number + "\n Account Holder Name: " + account_name + "\n Account Balance: " + account_balance);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Account Number");
                    }
                    break;
                case 6:
                    Console.WriteLine("-------All Accounts------------");
                    Console.WriteLine("-#---------Account Holder-----------Balance");
                    newBank.PrintAllAccounts();
                    break;
                    
                default:
                    Console.WriteLine("Invalid Option Selected. Please Select options 1-6");
                    break;
            }
            Console.WriteLine("Enter 1 to go back to main menu or 0 to exit!");
            var endOperation = Convert.ToInt32(Console.ReadLine());

            if (endOperation == 1)
            {
                goto begin;
            }
            else if (endOperation == 0)
            {
                goto end;
            }
              
        }
    }
}
