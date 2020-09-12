using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program4
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop(number);
            //Console.WriteLine("Now number is {0}", number); // Ekranda -10 çıkacak.
            //DoWhileLoop();
            //ForEachLoop();

            if (IsPrimeNumber(6))
            
                Console.WriteLine("This is a prime number");
            else
                Console.WriteLine("This is not a prime number");

            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    i = number; // Diğer tüm sayıları tek tek denememesi için...
                }
            }

            return result;
        }

        private static void ForEachLoop()
        {
            string[] students = new string[3] {"Ali", "Veli", "Ahmet"};

            foreach (var student in students) // student ismini kendimiz veriyoruz.
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 0);
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number -= 10;
            }
        }

        private static void ForLoop()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
