using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace D3_23._09_Pytymko_V.L
{
    internal class Task3
    {public class Journal 
        
        {
            private string _title;
            private int _yearFounded;
            private string _discription;
            private string _contactPhone;
            private string _email;

            public  Journal(string title, int yearFounded, string discription, string contactPhone, string email)
            {
                _title = title;
                    _yearFounded = yearFounded;
                        _discription = discription;
                    _contactPhone = contactPhone;
                    _email = email;
               
            }

            public void CreatedJournal()
            {
                Console.WriteLine("Введіть назву журналу:");
                _title = Console.ReadLine();

                bool isValidYear = false;
                do
                {
                    Console.WriteLine("Введіть рік заснування:");
                    try
                    {
                        _yearFounded = int.Parse(Console.ReadLine());
                        isValidYear = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Помилка: Введіть правильний формат року (ціле число).");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Помилка: Введіть рік в межах допустимого діапазону.");
                    }
                } while (!isValidYear);

                Console.WriteLine("Введіть опис журналу:");
                _discription = Console.ReadLine();

                Console.WriteLine("Введіть контактний телефон:");
                _contactPhone = Console.ReadLine();

                Console.WriteLine("Введіть email:");
                _email = Console.ReadLine();
            }

            public void PrintJournal()
            {
                Console.WriteLine($"Назва сайту:"+ _title);
                Console.WriteLine($"Pік заснування:"+ _yearFounded);
                Console.WriteLine($"Опис сайту:"+_discription);
                Console.WriteLine($" контактний телефон:"+_contactPhone);
                Console.WriteLine($"emailу:"+_email);
            }

            public string GetTitle() { return _title; }
            public int GetYear() {  return _yearFounded; }
            public string GetDiscription() { return _discription; }
            public string GetPhone() { return _contactPhone; }
            public string GetEmail() { return _email; }

            public void SetTitle(string newTitle) { _title = newTitle; }
            public void SetYear(int newYear) {  _yearFounded = newYear; }
            public void SetDescription(string newDiscription) { _discription = newDiscription; }
            public void SetPhone(string newPhone) { _contactPhone = newPhone; }
            public void SetEmail(string newEmail) {  _email = newEmail; }
            

        }

    }
}

