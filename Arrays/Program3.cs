using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program3
    {
        static void Main(string[] args)
        {
            //string[] students = new string[3]; // veya string[] students = new string[3] {"Ali", "Veli", "Ahmet"};
            //students[0] = "Ali";
            //students[1] = "Veli";
            //students[2] = "Ahmet";

            //string[] students2 = new[] {"Ali", "Veli", "Ahmet"};  // veya string[] students2 = {"Ali", "Veli", "Ahmet"};

            //foreach (var student  in students) //foreach döngüsü bir array'i gezmek için kullanılır.
            //{
            //    Console.WriteLine(student);
            //}

            //Çok boyutlu diziler:
            string[,] regions = new string[7, 3]
            {
                {"Istanbul", "İzmit", "Balıkesir"},
                {"Ankara", "Konya", "Kırıkkale"},
                {"Antalya", "Adana", "Mersin"},
                {"İzmir", "Muğla", "Manisa"},
                {"Van", "Iğdır", "Ağrı"},
                {"Diyarbakır", "Gaziantep", "Şanlıurfa"},
                {"Samsun", "Trabzon", "Ordu"},
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("***********");
            }


            Console.ReadLine();
        }
    }
}
