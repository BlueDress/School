using System;

namespace Methods
{
    public class Methods
    {
        public static void Main()
        {
            var bankAccount = new BankAccount();

            bankAccount.ID = 1;
            bankAccount.Deposit(15);
            bankAccount.Withdraw(5);

            Console.WriteLine(bankAccount.ToString());
        }
    }
}
