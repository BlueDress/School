using Microsoft.EntityFrameworkCore;
using P01_BillsPaymentSystem.Data;
using P01_BillsPaymentSystem.Data.Models;
using System;
using System.Globalization;
using System.Linq;

namespace P01_BillsPaymentSystem
{
    public class Startup
    {
        public static void Main()
        {
            var db = new BillsPaymentSystemContext();

            using (db)
            {
                db.Database.Migrate();

                var userId = int.Parse(Console.ReadLine());

                var user = db.User
                    .Where(u => u.UserId == userId)
                    .Select(u => new
                    {
                        Name = $"{u.FirstName} {u.LastName}",
                        BankAccounts = u.PaymentMethods.Where(pm => pm.Type.Equals(PaymentMethodType.BankAccount)).Select(pm => pm.BankAccount).ToList(),
                        CreditCards = u.PaymentMethods.Where(pm => pm.Type.Equals(PaymentMethodType.CreditCard)).Select(pm => pm.CreditCard)
                    })
                    .FirstOrDefault();

                if (user == null)
                {
                    Console.WriteLine($"User with id {userId} not found!");
                }
                else
                {
                    Console.WriteLine($"User: {user.Name}");

                    if (user.BankAccounts.Any())
                    {
                        Console.WriteLine("Bank Accounts:");

                        foreach (var bankAccount in user.BankAccounts)
                        {
                            Console.WriteLine($"-- ID: {bankAccount.BankAccountId}");
                            Console.WriteLine($"--- Balance: {bankAccount.Balance}");
                            Console.WriteLine($"--- Bank: {bankAccount.BankName}");
                            Console.WriteLine($"--- SWIFT: {bankAccount.SwiftCode}");

                        }
                    }

                    if (!user.CreditCards.Any())
                    {
                        Console.WriteLine("Credit Cards:");

                        foreach (var creditCard in user.CreditCards)
                        {
                            Console.WriteLine($"-- ID: {creditCard.CreditCardId}");
                            Console.WriteLine($"--- Limit: {creditCard.Limit}");
                            Console.WriteLine($"--- Money Owed: {creditCard.MoneyOwed}");
                            Console.WriteLine($"--- Limit Left:: {creditCard.LimitLeft}");
                            Console.WriteLine($"--- Expiration Date: {creditCard.ExpirationDate.ToString("yyyy/MM", CultureInfo.InvariantCulture)}");
                        }
                    }
                }
            }
        }
    }
}
