using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program1
    {
        static void Main(string[] args)
        {
            //Value types        // Not: 1 byte = 8-bit
            /*
            int number1 = 2147483647; // 4 byte yer kaplar, -2 147 483 648 ile  2 147 483 648 arasında değer alır.
            long number2 = 2454353452345; // 8 byte yer kaplar, -2^63 ile (2^63 - 1) arasında değer alır.
            short number3 = 32767; // 2 byte yer kaplar, -32 768 ile 32 767 arasında değer alır.
            byte number4 = 255; // 1 byte yer kaplar, 0 ile 256 arasında değer alır.  
            double number5 = 50.934234324234234; // 8 byte yer kaplar, (5.0 * 10^-324) ile (1.7 * 10^308) arasında değer alır.
            decimal number6 = 60.123213m; // double'dan daha uzun değerler alabilir.
            Console.WriteLine("Our numbers are {0} {1} {2} {3} {4} {5}", number1, number2, number3, number4, number5, number6);

            bool condition = true; // veya false.
            char character = 'a'; // Bir karakter tutan değişkendir.
            Console.WriteLine("Our character is {0}", character);
            Console.WriteLine("Our boolean value is {0}", condition);*/


            //Şart Blokları:
            var number = 11;
            //Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10"); //sayı 10 mu? evetse ilkini, değilse ikincisini yaz.

            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                default:
                    Console.WriteLine("Number is not 10 or 20");
                    break;
            }



            //Console.WriteLine("Hello World");
            Console.ReadLine();
        }
    }
}
