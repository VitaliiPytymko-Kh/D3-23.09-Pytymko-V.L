using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace D3_23._09_Pytymko_V.L
{
    internal class Task1
    {
        
      public  class BankAccount
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
     public   class ATM
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


      

   }
    
}
