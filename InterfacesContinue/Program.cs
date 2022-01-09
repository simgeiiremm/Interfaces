using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IService service = new CustomerService(); //new StudentService();
            service.Add();
            service.List();

            service = new StudentService();
            service.Add();
            service.List();

            Console.ReadLine();
        }
    }
    interface IService // 2. kullanımı: Method tanımları üzerinden kullanılır      //interface : protokol
    {
        void Add(); //geriye bir şey dönmeyen bir method
        void List();
    }
    class CustomerService : IService
    {
        public void Add()
        {
            Console.WriteLine("Customer added to DB");
        }

        public void List()
        {
            Console.WriteLine("Customers listed from DB");
        }

        public void Shop()
        {
            Console.WriteLine("Customer shopped");
        }
    }

    class StudentService : IService
    {
        public void Add()
        {
            Console.WriteLine("Student added to DB");
        }

        public void List()
        {
            Console.WriteLine("Students listed from DB");
        }
    }
}
