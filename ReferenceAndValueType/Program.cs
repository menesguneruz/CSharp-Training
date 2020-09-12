using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            //int, enum, bool, double, decimal vb değer tipler; class, interface,string, array, abstract classes vb referans tiplerdir.
            int number1 = 10;
            int number2 = 20;
            number2 = number1; // "number2'nin değeri" = "number1'in değeri"
            number1 = 30;

            Console.WriteLine(number2);

            string[] cities1 = new string[]{"Ankara","Adana","Afyon"}; //Diyelim bellekteki yeri: 101
            string[] cities2 = new string[]{"Bursa","Bolu","Balıkesir"}; //Diyelim bellekteki yeri: 205 // 101 oluyor. 205 belleği boşaltılıyor.

            cities2 = cities1; //"cities2'nin referansı = cities1'in referansı"                              ^^^^^
            cities1[0] = "Istanbul";
            Console.WriteLine(cities2[0]); // Ekranda Istanbul yazar.

            Console.ReadLine();
        }
    }
}
