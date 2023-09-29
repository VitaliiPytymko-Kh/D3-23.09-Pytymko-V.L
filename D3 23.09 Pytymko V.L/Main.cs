using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static D3_23._09_Pytymko_V.L.Task2;
using static D3_23._09_Pytymko_V.L.Task1;

namespace D3_23._09_Pytymko_V.L
{
    class Program
    {
        public static void Main()
        {
            ///Task1
            BankAccount account = new BankAccount("P", 1000.0m);

            // Виведення початкового балансу
            account.PrintBalance();

            // Внесення коштів на рахунок
            account.Deposit(500.0m);
            account.PrintBalance();

            // Зняття коштів з рахунку через ATM
            ATM.WithdrawMoney(account, 200.0m);
            account.PrintBalance();

            // Спроба зняти більше коштів, ніж на рахунку
            ATM.WithdrawMoney(account, 10000.0m);
            account.PrintBalance();


            ///Task2
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
