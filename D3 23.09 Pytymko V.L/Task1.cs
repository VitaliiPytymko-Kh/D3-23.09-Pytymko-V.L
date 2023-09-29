using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static D3_23._09_Pytymko_V.L.Task2;

namespace D3_23._09_Pytymko_V.L
{
   class Task1
    {
        
        class BankAccount
        {
            public string Accname { get; }
            public decimal Balance { get; private set; }

            public BankAccount(string accname, decimal balance)
            {
                if (balance < 0)
                {
                    throw new ArgumentException("Початковий баланс не може бути від'ємним.", nameof(balance));
                }

                Accname = accname;
                Balance = balance;
            }

            public void Deposit(decimal wallet)
            {
                if (wallet < 0)
                {
                    throw new ArgumentException("Сума для внесення повинна бути більша за 0.", nameof(wallet));
                }

                Balance += wallet;
                Console.WriteLine($"Баланс {Accname} поповнено на {wallet} грн.");
            }

            public void Withdraw(decimal wallet)
            {
                if (wallet < 0)
                {
                    throw new ArgumentException("Сума для зняття повинна бути більша за 0.", nameof(wallet));
                }

                if (Balance >= wallet)
                {
                    Balance -= wallet;
                    Console.WriteLine($"Ваш баланс {Accname} зменшено на {wallet} грн.");
                }
                else
                {
                    throw new ArgumentException($"На балансі ({Accname}) недостатньо коштів !!!");
                }
            }

            public void PrintBalance()
            {
                Console.WriteLine($"На Вашому рахунку {Accname}: {Balance} грн.");
            }
        }
        class ATM
        {
            public static void WithdrawMoney(BankAccount accname, decimal amount)
            {
                try
                {
                    accname.Withdraw(amount);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Помилка: {ex.Message}");
                }
            }
        }


        public static void Main()
        {
            BankAccount account = new BankAccount("P", 1000.0m);

            // Виведення початкового балансу
            account.PrintBalance();

            // Внесення коштів на рахунок
            account.Deposit(500.0m);
            account.PrintBalance();

            // Зняття коштів з рахунку через ATM
            ATM.WithdrawMoney (account, 200.0m);
            account.PrintBalance();

            // Спроба зняти більше коштів, ніж на рахунку
            ATM.WithdrawMoney(account, 10000.0m);
            account.PrintBalance();


            Website web1 = new Website("", "", "", "");
            web1.CreaedtWebsite();
            web1.PrintWebsite();

            web1.SetName("New Name ");
            web1.SetDescription(" New description bla bla bla");
            web1.SetUrl(" New URL ");
            web1.SetIp("New IP 1111 111 1 1 1 1");

            web1.PrintWebsite();
          

            Console.WriteLine();
        }

   }
    
}
