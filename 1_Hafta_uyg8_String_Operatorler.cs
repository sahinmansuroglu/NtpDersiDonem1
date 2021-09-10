// Contains ile bir metinin başka bir metinin içerisinde bulunup bulunmadığını test etme
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
          
            string orjinalMesaj = "Bugün Hava Çok Güzel    ";

            //"Hava" kelimesi orjinal mesaj'ın içerisinde bulunduğundan dolayı sonuc1'e true atıldı
            var sonuc1 = orjinalMesaj.Contains("Hava");
            
            //"Su" kelimesi orjinal mesaj'ın içerisinde bulunmadığından dolayı sonuc2'e false atıldı
            var sonuc2 = orjinalMesaj.Contains("Su");

            Console.WriteLine(sonuc1);
            Console.WriteLine(sonuc2);



        }
    }
}

