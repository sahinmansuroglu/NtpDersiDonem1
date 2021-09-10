// string operatörleri
using System;


namespace hafta1
{
    class Program
    {
        static void Main(string[] args)
        {
            string orjinalMesaj = "Bugün HAVA Çok Güzel...";

            //orjinalMesaj ToUpper ile  tüm harfleri büyük hale getirilir ve msj1'e atılır
            string msj1 = orjinalMesaj.ToUpper();
            //orjinalMesaj ToLower ile  tüm harfleri küçük hale getirilir ve msj2'ye atılır
            string msj2 = orjinalMesaj.ToLower();

            Console.WriteLine($"Tum harfler büyük:{msj1}");
            Console.WriteLine($"Tum harfler küçük:{msj2}");

            string msj3 = "Mezitli MTAL".ToUpper();
            Console.WriteLine($"Tum harfler büyük:{msj3}");
        }
    }
}
