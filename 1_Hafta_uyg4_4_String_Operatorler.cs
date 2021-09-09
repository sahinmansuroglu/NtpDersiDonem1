// String ifadenin bir bölümünü alma
using System;


namespace hafta1
{
    class Program
    {
        static void Main(string[] args)
        {
            // orjinal mesajın ilk 5 karakterini boşluksuz almaya çalışalım

            string orjinalMesaj = "    Bugün Hava Çok Güzel    ";
            // orjinal mesajın başındaki ve sonundaki boşluklar atıldıktan sonra 
            // 6. karakterden itibaren 4 karakter msj1'e atılır. ("Hava" kelimesi atanır)
            string msj1 = orjinalMesaj.Trim().Substring(6, 4);

            // orjinal mesajın başındaki ve sonundaki boşluklar atıldıktan sonra 
            // 0. karakterden itibaren 5 karakter msj2'e atılır.("Bugün" kelimesi atanır)
            string msj2 = orjinalMesaj.Trim().Substring(0, 5);


            // orjinal mesajın başındaki ve sonundaki boşluklar atıldıktan sonra 
            // 15. karakterden itibaren 5 karakter msj3'e atılır.("Güzel" kelimesi atanır)
            string msj3 = orjinalMesaj.Trim().Substring(15, 5);

            Console.WriteLine($"msj1:{msj1}");
            
            Console.WriteLine($"msj2:{msj2}");
            Console.WriteLine($"msj3:{msj3}");



        }
    }
}
