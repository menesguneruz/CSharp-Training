using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] cities = new string[2]{"Ankara","Istanbul"};
            //Yukarıdaki stringe 3. bir eleman eklemek istersem sıkıntı yaşarım. Bu noktada koleksiyonlar kullanılabilir.

            //ArrayList();

            //List();

            Dictionary<string,string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book","kitap");
            dictionary.Add("Hello","Merhaba");
            dictionary.Add("Computer", "Bilgisayar");

            //Console.WriteLine(dictionary["book"]);
            //Console.WriteLine(dictionary["glass"]); // Anahtar sözlükte bulunamadı hatası verir.

            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }

            dictionary.ContainsKey("glass"); //False döndürür.
            dictionary.ContainsValue("kitap"); // True döndürür.

            Console.ReadLine();
        }

        private static void List()
        {
            List<string> cities = new List<string>(); //sadece string değerler içerebilen dizi tanımladım.
            cities.Add("Ankara");
            cities.Add("Corum");

            //Console.WriteLine(cities.Contains("Ankara")); //cities listesinde "Ankara" değeri varsa True, yoksa False döner.

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer{Id = 1, FirstName = "Ahmet"});
            //customers.Add(new Customer{Id = 2,FirstName = "Mehmet"});

            List<Customer> customers = new List<Customer>
            {
                new Customer {Id = 1, FirstName = "Ahmet"},
                new Customer {Id = 2, FirstName = "Mehmet"}
            };


            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Fatma"
            };
            customers.Add(customer2);

            customers.AddRange(new Customer[2]
            {
                new Customer {Id = 4, FirstName = "Salih"},
                new Customer {Id = 5, FirstName = "Derin"}
            });

            // customers.Clear(); // Listeyi temizle, sil.

            var index = customers.IndexOf(customer2); //Elemenanın listedeki sırasını(indexini) verir.
            Console.WriteLine("Index : {0}", index);

            var index2 = customers.LastIndexOf(customer2); // Elemanın listedeki sondan index değerini verir.
            Console.WriteLine("Index : {0}", index2);

            customers.Insert(0, customer2); // Eklemek istediğimiz sıraya, eklemek istediğimiz değeri girebiliriz

            customers.Remove(customer2); // Bellekte buldugu ilk customer2 değerini silecek.Buldugu anda aramayı bitirir.
            //Yani 3 tane customer2 eklemişsem 1 tanesini siler ve durur.
            customers.RemoveAll(c => c.FirstName == "Fatma"); // İsmi fatma olan tüm Customer değerlerini siler.

            Console.WriteLine(customers.Contains(customer2));

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
            }

            var count = customers.Count; // customers koleksiyonunun eleman sayısını verir.

            Console.WriteLine("Count : {0}", count);
        }

        private static void ArrayList()
        {
            //ArrayList tip güvenli bir yöntem değildir. Yani diziye her tipte değer ekleyebiliriz.
            //Bu, pek tercih ettiğimiz bir durum değildir.

            ArrayList cities = new ArrayList();
            cities.Add("Ankara"); // cities[0] = "Ankara"
            cities.Add("Adana"); // cities[1] = "Adana"

            cities.Add("Istanbul");
            Console.WriteLine(cities[2]); //Istanbul
            cities.Add(1);
            cities.Add('A');

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
