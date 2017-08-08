using System;
using System.Collections.Generic;

namespace Test_Client
{
    public class TestClient
    {
        public static void Main()
        {
            var accounts = new Dictionary<int, BankAccount>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input.Equals("End"))
                {
                    break;
                }
                else
                {
                    var tokens = input.Split();
                    var command = tokens[0];

                    switch (command)
                    {
                        case "Create":
                            Create(tokens, accounts);
                            break;
                        case "Deposit":
                            Deposit(tokens, accounts);
                            break;
                        case "Withdraw":
                            Withdraw(tokens, accounts);
                            break;
                        case "Print":
                            Print(tokens, accounts);
                            break;
                    }
                }
            }
        }

        private static void Print(string[] tokens, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(tokens[1]);

            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                Console.WriteLine(accounts[id].ToString());
            }
        }

        private static void Withdraw(string[] tokens, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(tokens[1]);
            var amount = double.Parse(tokens[2]);

            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                if (accounts[id].Balance < amount)
                {
                    Console.WriteLine("Insufficient balance");
                }
                else
                {
                    accounts[id].Withdraw(amount);
                }
            }
        }

        private static void Deposit(string[] tokens, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(tokens[1]);
            var amount = double.Parse(tokens[2]);

            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                accounts[id].Deposit(amount);
            }
        }

        private static void Create(string[] tokens, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(tokens[1]);

            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                var account = new BankAccount();
                account.ID = id;
                accounts[id] = account;
            }
        }
    }
}
