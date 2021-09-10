// Replace ile cümleninin herhangi bir bölümünü değiştirme
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
          
            string orjinalMesaj = "Bugün Hava Çok Güzel";

            //orjinal mesajda "Güzel" kelimesi "Kötü" kelimesi ile değiştirilmiştir
            string yeniMesaj = orjinalMesaj.Replace("Güzel", "Kötü");

            Console.WriteLine($"orjinal mesaj:{orjinalMesaj}");

            Console.WriteLine($"yeni mesaj:{yeniMesaj}");





        }
    }
}

