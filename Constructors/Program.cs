using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(10); //parametre verilmezse ikinci constructor çalışır.
            customerManager.List(); //"Listed 10 items" ekranda yazar. Parametre verilmezse "Listed 15 items"

            Product product = new Product {Id = 1, Name = "Laptop"};
            Product product2 = new Product(2,"Desktop PC");

            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            employeeManager.Add();

            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Teacher.Number = 10; //Görüldüğü gibi new Teacher() yapmaya gerek yok. --> static

            Utilities.Validate();

            Manager.DoSomething(); // DoSomething metodu static oldugu için new işlemi yapmama gerek yok.

            Manager manager = new Manager();
            manager.DoSomething2();

            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private int _count = 15;

        public CustomerManager(int count)
        {
            _count = count;
        }

        public CustomerManager()
        {
            
        }

        public void List()
        {
            Console.WriteLine("Listed {0}", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added!");
        }
    }


    class Product
    {
        public Product()
        {

        }

        private int _id;
        private string _name;

        public Product(int id, string name)
        {
            _id = id;
            _name = name; 
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to file");
        }
    }

    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!");
        }
    }

    class BaseClass
    {
        private string _entity ;

        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            
            Console.WriteLine("{0} message",_entity);
        }
    }

    class PersonManager : BaseClass
    {
        public PersonManager(string entity): base(entity) //Base class'a bu şekilde parametre yollanabilir
        {
            
        }

        public void Add()
        {
            Console.WriteLine("Added");
            Message();
        }
    }

    static class Teacher  //static class'ları "new"leyemeyiz. Zaten arka planda tek bir nesne oluşturuluyor.
    {
        //static bir class'ın tüm üyelerinin static olması gerekir.
        public static int Number { get; set; }
    }

    static class Utilities
    {
        static Utilities()
        {
            //static bir nesnede mutlaka çalışmasını istediğimiz kod bloklarını buraya yazabiliriz.
        }

        public static void Validate()
        {
            Console.WriteLine("Validation is done!");
        }
    }

    class Manager
    {
        public static void DoSomething() //Class static olmasa da metod static yapılıp kullanılabilir.
        {
            Console.WriteLine("Dne!");
        }

        public void DoSomething2()
        {
            Console.WriteLine("Done2");
        }

    }
}
