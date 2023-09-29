using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace D3_23._09_Pytymko_V.L
{
    internal class Task4

    {
        public class Store
        {
            private string _nameS;
            private string _adress;
            private string _profildescriptionS;
            private string _phones;
                private string _emailS;

            public Store(string nameS, string adress, string profildescriptionS, string phones, string emailS)
            {
                _nameS = nameS;
                _adress = adress;
                _profildescriptionS = profildescriptionS;
                _phones = phones;
                _emailS = emailS;
            }

            public string NameS { get { return _nameS; } }
            public string Adress { get { return _adress;} }
            public string Profil {   get { return _profildescriptionS; } }
            public  string Phones { get { return _phones;} }

            public string EmaiS { get { return _emailS; } }

            public void SetNameS (string newNames) { _nameS = newNames;  }
            public void SetAdress(string newAdress) { _adress = newAdress; }
            public void SetProfil(string newProfil) { _profildescriptionS = newProfil; }
            public void SetPhones(string newPhonees) { _phones = newPhonees; }
            public void SetEmail(string newEmails) {  _emailS = newEmails; }

            public void InputDataStore()
            {
                Console.Write("Введіть назву магазину: ");
                _nameS = Console.ReadLine();

                Console.Write("Введіть адресу магазину: ");
                _adress = Console.ReadLine();

                Console.Write("Введіть опис профілю магазину: ");
                _profildescriptionS = Console.ReadLine();

                Console.Write("Введіть контактний телефон: ");
                _phones = Console.ReadLine();

                Console.Write("Введіть email: ");
                _emailS = Console.ReadLine();
            }

            public void ShowStore() 
            {
                Console.WriteLine("Інформація про магазин:");
                Console.WriteLine(""+_nameS);
                Console.WriteLine("" + _adress);
                Console.WriteLine("" + _profildescriptionS);
                Console.WriteLine("" + _phones);
                Console.WriteLine("" + _emailS);

            }
        }
    }
}
