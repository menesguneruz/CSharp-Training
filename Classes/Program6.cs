using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program6
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager= new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara"; //set
            customer.ID = 1; //set
            customer.FirstName = "Mustafa Enes"; //set
            customer.LastName = "Güneruz"; //set

            Customer customer2 = new Customer
            {
                FirstName = "Melek", ID = 2, City = "Adana", LastName = "Ulker" //set
            };

            Console.WriteLine(customer2.FirstName); //get

            Console.ReadLine();
        }
    }
}
