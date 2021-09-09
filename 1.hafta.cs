// ad, soyad şeklinde 2 adet değişken tanımlayıp değerlerini atayınız.
// Bu iki değişkenin değerini tek bir console.write line ile başına Merhaba kelimesi gelecek şekilde yazınız
using System;
namespace hafta1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ad = "Şahin";
            var soyad = "MANSUROĞLU";
            var yas = 34;
            var mesaj1 = "Merhaba " + ad + " " + soyad ;
            var mesaj2 = $"Merhaba {ad} {soyad}";
            Console.WriteLine(mesaj1);
            Console.WriteLine(mesaj2);
        }
    }
}
