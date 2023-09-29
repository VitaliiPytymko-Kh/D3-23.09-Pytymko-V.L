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

            public void CreaedJournal()
            {
                Console.WriteLine(" Введіть назву :");
                _title = Console.ReadLine();
                Console.WriteLine(" Введіть рік заснування:");
                _yearFounded = Console.Read();
                Console.WriteLine("Введіть опис :");
                _discription = Console.ReadLine();
                Console.WriteLine("Введіть contactPhone: ");
                _contactPhone = Console.ReadLine();
                Console.WriteLine("Введіть email сайту: ");
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

