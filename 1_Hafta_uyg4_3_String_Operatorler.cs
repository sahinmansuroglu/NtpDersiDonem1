// String ifadenin başındaki ve sonundaki boşlukları silme
using System;


namespace hafta1
{
    class Program
    {
        static void Main(string[] args)
        {
            string orjinalMesaj = "    Bugün Hava Çok Güzel    ";
            Console.WriteLine($"msj:{orjinalMesaj}!");

            // orjinalMesajın başındaki boşlukları TrimStart ile silerek msj1'e atadık
            string msj1 = orjinalMesaj.TrimStart();
            Console.WriteLine($"msj1:{msj1}!");

            // orjinalMesajın sonundaki boşlukları TrimEnd ile silerek msj2'e atadık
            string msj2 = orjinalMesaj.TrimEnd();
            Console.WriteLine($"msj2:{msj2}!");

            // orjinalMesajın başındaki ve sonundaki boşlukları Trim ile silerek msj3'e atadık
            string msj3 = orjinalMesaj.Trim();
            Console.WriteLine($"msj3:{msj3}!");


        }
    }
}
