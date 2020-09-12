using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
           //InterfacesIntro();

           

           Console.ReadLine();
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer {Id = 1, FirstName = "Mustafa", LastName = "Guneruz", Address = "Ankara"});

            Student student = new Student
            {
                Id = 1,
                FirstName = "Ali",
                LastName = "Veli",
                Department = "Computer Sciences"
            };
            manager.Add(student);
        }
    }

    interface IPerson
    {
        int Id { get; set;}
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person) // Örneğin Customer customer yazsaydım, main içerisinde manager.Add(student) çağıramazdım.
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
