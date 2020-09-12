using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program5
    {
        static void Main(string[] args)
        {
            //Intro();

            string sentence = "My name is Mustafa Enes";
            var result = sentence.Length;
            var result2 = sentence.Clone(); // Stringin bir referansını daha (stringin klonunu) oluşturur.
            bool result3 = sentence.EndsWith("s");
            bool result4 = sentence.StartsWith("My name");

            var result5 = sentence.IndexOf("name"); // parantez içindeki ifadenin kaçıncı indexten başladıgını bulur.
            // parantez içindeki ifadeyi bulamazsa -1 değerini döndürür.

            var result6 = sentence.LastIndexOf("Enes"); // ifadeyi aramaya sondan başlar.
            var result7 = sentence.Insert(0,"Hello, "); // stringin belirtilen indexine, girdiğimiz ifadeyi ekler.
            var result8 = sentence.Substring(3); // stringi 3.indexten itibaren al. sentence.Substring(3,7) = "name is" yazdırır.
            var result9 = sentence.ToLower(); // Bütün karakterleri küçük harfe çevirir.
            var result10 = sentence.ToUpper(); // Bütün karakterleri büyük harfe çevirir.
            var result11 = sentence.Replace(" ", "-"); //Stringteki ifadeleri değiştirir.(Boşluk yerine çizgi) 
            var result13 = sentence.Remove(2, 10); //2.indexten itibaren 10 karakter sil.

            Console.WriteLine(result13); // Stringin uzunluğunu yazdırır

            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[1]);

            foreach (var item in city)
            {
                Console.WriteLine(item); //Yukarıdan aşağıya A n k a r a değerlerini yazar.   
            }
        }
    }
}
