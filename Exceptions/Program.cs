using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();

            //try
            //{
            //    Find();
            //}
            //catch (RecordNotFound exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}

            HandleException(() =>
            {
                Find();
            });
            


            Console.ReadLine();
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke(); //  Yukarıdaki HandleException(() =>{Find()});  içindeki Find(); kısmını çalıştır demek.
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> {"Engin", "Derin", "Salih"};

            if (!students.Contains("Ahmet"))
            {
                throw new RecordNotFound("Record Not Found!");
            }
            else
            {
                Console.WriteLine("Record Found!");
            }
        }

        private static void ExceptionIntro()
        {
            try // Bu blokta bir hata bulunursa kod catch bloğuna geçer.
            {
                string[] students = new string[3] {"Engin", "Derin", "Salih"};
                students[3] = "Ahmet";
            }
            catch (IndexOutOfRangeException exception) //Hatanın türüne göre bloklar açabiliriz.
            {
                Console.WriteLine(exception.Message);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception) // Hata, yukarıda belirtilen hatalardan biri değilse bu blok çalışırç
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
