using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDatabase db = new SqlDatabase();
            db.List();
            Console.ReadLine();
        }
    }
    
    class SqlDatabase : IDatabase
    {
        public void Add()
        {
            Console.WriteLine("Added to SQL");
        }
        public void Update()
        {
            Console.WriteLine("Updated to SQL");
        }
        public void Delete()
        {
            Console.WriteLine("Deleted from SQL");
        }
        public void List()
        {
            Console.WriteLine("Listed from SQL");
        }
    }

    class Oracle : IDatabase
    {
        public void Add()
        {
            Console.WriteLine("Added to Oracle");
        }
        public void Update()
        {
            Console.WriteLine("Updated to Oracle");
        }
        public void Delete()
        {
            Console.WriteLine("Deleted from Oracle");
        }
        public void List()
        {
            Console.WriteLine("Listed from Oracle");
        }
    }
    interface IDatabase
    {
        void Add();
        void Update();
        void Delete();
        void List();

    }
}
