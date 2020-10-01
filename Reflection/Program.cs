using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //FourOperations fourOperations= new FourOperations(2,3);
            //Console.WriteLine(fourOperations.Add2());
            //Console.WriteLine(fourOperations.Add(3,4));

            var type = typeof(FourOperations);

            var fourOperations = (FourOperations)Activator.CreateInstance(type,2,3); //new'leme işleminin çalışma anında yapılan hali.
            Console.WriteLine(fourOperations.Add(4, 5));
            Console.WriteLine(fourOperations.Add2());
            Console.WriteLine("-----------------------");

            var methods = type.GetMethods();

            foreach (var info in methods)  // Sınfın metodlarına ulaştım ve her birini ekrana yazdırdım
            {
                Console.WriteLine("Methods name is : {0}",info.Name);
                foreach (var parameterInfo in info.GetParameters()) // Her bir metodun parametrelerine ulaştım ve (varsa) ekrana yazdırdım.
                {
                    Console.WriteLine("Parameter : {0}", parameterInfo.Name);
                }

                foreach (var attribute in info.GetCustomAttributes()) // Attributelara ulaştım ve (varsa) ekrana yazdırdım.
                {
                    Console.WriteLine("Attribute name : {0}", attribute.GetType().Name);   
                }
            }

            Console.ReadLine();
        }
    }

    public class FourOperations
    {
        private int _number1;
        private int _number2;

        public FourOperations(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        public int Multiple(int number1, int number2)
        {
            return number1 * number2;
        }

        public int Add2()
        {
            return _number1 + _number2;
        }

        [MethodName("Multiple")]
        public int Multiple2()
        {
            return _number1 * _number2;
        }
    }

    public class MethodNameAttribute : Attribute
    {
        public MethodNameAttribute(string name)
        {
            
        }
    }
}
