using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program2
    {
        static void Main(string[] args)
        {
            //var result = Add(25, 45);
            //Console.WriteLine(result);

            //var added = Add2(); // Parametre vermezsem default değerleri(40,70) verilmiş kabul eder.

            //int num1 = 20;
            //int num2 = 100;
            //var result2 = Add3(ref num1, num2); //ref keywordu, metod içinde yapılan değişikliğin kalıcı olmasını sağlar.
            //// yani ref keywordu num1'in bellekteki konumuna gidip orada işlem yapılmasını sağlar.
            //Console.WriteLine(result2);
            //Console.WriteLine(num1);                

            Console.WriteLine(Multiply(2,5));
            Console.WriteLine(Multiply(6,2,12));
            Console.WriteLine(Add4(2,3,4,5,8,25,250,11,46));

            Console.ReadLine();
        }

        //static int Add(int number1, int number2)
        //{
        //    return number1 + number2;
        //}

        static int Add2(int number1 = 40, int number2 = 70)
        {
            return number1 + number2;
        }

        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        //Method Overloading: Aynı isimli metodlara farklı sayıda parametre göndererek kullanabiliriz.
        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        //params keywordu:
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();    //Sum() metodu hazır metoddur.
        }
    }
}
