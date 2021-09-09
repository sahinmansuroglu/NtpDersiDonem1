// Null ve Empty Kavramı
using System;


namespace hafta1
{
    class Program
    {
        static void Main(string[] args)
        {

           
            string metin1 = "";// içi boş bir string değişken tanımlandı.
            string metin2 = string.Empty;// içi boş bir string değişken tanımlandı.
            string metin3 = null;

            // metin3'un değeri null olduğu için  Aşağıdaki kod  hata verir..
            //Console.WriteLine($" metin3'ün karakter Sayısı={metin3.Length}");

            // metin1'in içi boş olduğu olduğu için  karakter sayısı 0 olur
            Console.WriteLine($"metin1'ün karakter Sayısı={metin1.Length}");

            // metin1'in içi boş olduğu olduğu için  karakter sayısı 0 olur
            Console.WriteLine($"metin2'ün karakter Sayısı={metin2.Length}");


        }
    }
}
