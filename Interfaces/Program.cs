using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person()
            {
                Id = 1,
                FirstName = "Simge",
                LastName = "Işık"
            };
            Console.WriteLine("ID: " + person1.Id + ", Adı: " + person1.FirstName + ", Soyadı: " + person1.LastName);

            Person person2 = new Person()
            {
                Id = 2,
                FirstName = "Eymen Çınar",
                LastName = "Işık"
            };
            Console.WriteLine("ID: " + person2.Id + ", Adı: " + person2.FirstName + ", Soyadı: " + person2.LastName);

            Customer customer1 = new Customer()
            {
                Address = "Adana",
                Id = 3,
                FirstName = "Yağız",
                LastName = "Yılmaz"
            };
            Customer customer2 = new Customer();
            customer2.FirstName = "Yahya";
            customer2.LastName = "Önder";
            customer2.Id = 4;
            customer2.Address = "Çorum";

            IPerson customer3 = new Customer(); //IPerson değişken üzerinden newledik
            customer3.Id = 5;
            customer3.FirstName = "Melik";
            customer3.LastName = "Baykal";

            IPerson customer4 = new Customer() //Adress e bu şekilde yazarak ulaşabiliriz
            {
                Address = "İstanbul",
                FirstName = "Boğaçhan",
                LastName = "Bakkaloğlu",
                Id = 6
            };

            //Customer customer44 = (Customer)customer4;
            Customer customer44 = customer4 as Customer;
            Console.WriteLine($"ID: {customer44.Id}, Adı: {customer44.FirstName}, Soyadı: {customer44.LastName}, Adres: {customer44.Address}");
            int sayi = (int)2.0;

            Console.ReadLine();
        }
    }
    interface IPerson //soyut : abstract (new leyemeyiz)
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }
    class Person : IPerson // classlar somut(concrete) yapılardır implemente ediyoruz
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string  Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }


    }
}
