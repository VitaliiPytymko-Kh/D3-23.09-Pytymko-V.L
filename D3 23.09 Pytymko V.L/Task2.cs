using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace D3_23._09_Pytymko_V.L
{
    internal class Task2
    {
        public class Website
        {
        private string _name;
            private string _description;
            private string _url;
            private string _ip;

            public Website (string name, string description, string url, string ip)
            {
                _name = name;
                _description = description;
                _url = url;
                _ip = ip;
            }
            public void CreaedtWebsite()
            {
                Console.WriteLine(" Введіть назву сайту:");
                _name=Console.ReadLine();
                Console.WriteLine("Введіть опис сайту:");
                _description=Console.ReadLine();
                Console.WriteLine("Введіть шлях до сайту: ");
                _url=Console.ReadLine();
                Console.WriteLine("Введіть IP-адресу сайту: ");
                _ip=Console.ReadLine();
              
            }

            public void PrintWebsite()
            {
                Console.WriteLine($"Назва сайту: {_name}");
                Console.WriteLine($"Опис сайту: {_description}");
                Console.WriteLine($" Шлях до сайту: {_url}");
                Console.WriteLine($"IP-адреса сайту: {_ip}");
            }
            public string GetName() {return _name; }
            public string GetDescription()  { return _description;} 
            public string GetUrl() { return _url;}
            public string GetIp() { return _ip;}

            public void SetName(string newName) { _name = newName; }
            public void SetDescription(string newDescription) { _description = newDescription; }
            public void SetUrl(string newUrl) {  _url = newUrl; }
            public void SetIp(string newIp) {  _ip = newIp; }
        
        }

       
    }
    
}
