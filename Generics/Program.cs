using Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara","Izmir","Adana"); // Generic metod: Girilen dataları <> içindeki tipte olan bir liste haline getir.

            foreach (var item in result)
            {
                Console.WriteLine(item);   
            }

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer{FirstName = "Ali"}, new Customer{FirstName = "Veli"});

            foreach (var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Utilities
    {
        public List<T> BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    class Product
    {
        
    }

    interface IProductDal: IRepository<Product>
    {
        
    }

    class Customer
    {
        public string FirstName { get; set; }
    }

    interface ICustomerDal: IRepository<Customer> //IRepository'yi inherite etmem yeterli.
    {
        
    }

    interface IRepository<T> where T: class // T harfi type'ı temsil eder. Bu yapıya generic sınıf denir. Bu yapı aynı işlemler içeren interfaceler bulunduğunda tekrar düşmemizi engeller.
    {                       //where T: class yazarak, inherite edilirken class dışındaki (string gibi) tiplerin girilmesini engelledim.
    List<T> GetAll();
    T Get(int id);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    }

    class ProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    class CustomerDal : ICustomerDal
    {
        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
