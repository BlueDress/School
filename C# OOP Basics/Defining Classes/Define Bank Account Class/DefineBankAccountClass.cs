using System;

namespace Define_Bank_Account_Class
{
    public class DefineBankAccountClass
    {
        public static void Main()
        {
            var bankAccount = new BankAccount();

            bankAccount.ID = 1;
            bankAccount.Balance = 15;

            Console.WriteLine($"Account {bankAccount.ID}, balance {bankAccount.Balance}");
        }
    }
}
