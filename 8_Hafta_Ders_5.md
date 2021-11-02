## Version-1 ##

using System;

namespace ConsoleApp4
{
    class Program
    {

        static void Main(string[] args)
        {
            Islem islmeNesne = new Islem();
            while (true)
            {
                Console.WriteLine("*****İşlemler*****");
                Console.WriteLine("1 - Topla");
                Console.WriteLine("2 - Çıkart");
                Console.WriteLine("3 - Çarp");
                Console.WriteLine("4 - Böl");
                Console.WriteLine("5 - Çıkış");
                Console.Write("Seçiminiz (1,  2,   3,  4,  5)---->");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {
                    islmeNesne.topla();
                }
                else if (secim == 2)
                {
                    islmeNesne.cikart();
                }
                else if (secim == 3)
                {
                    islmeNesne.carp();
                }
                else if (secim == 4)
                {
                    islmeNesne.bol();
                }
                else if (secim == 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Lütfen 1 - 5 arası sayı giriniz:");
                }
            }
        }

    }


    class Islem
    {

       public void topla()
        {
            Console.Write("1. Sayıyı Giriniz:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz:");
            int s2 = Convert.ToInt32(Console.ReadLine());
            int sonuc = s1 + s2;
            Console.WriteLine($"Toplam={sonuc}");

        }
        public void cikart()
        {
            Console.Write("1. Sayıyı Giriniz:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz:");
            int s2 = Convert.ToInt32(Console.ReadLine());
            int sonuc = s1 - s2;
            Console.WriteLine($"Fark={sonuc}");

        }
        public void carp()
        {
            Console.Write("1. Sayıyı Giriniz:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz:");
            int s2 = Convert.ToInt32(Console.ReadLine());
            int sonuc = s1 * s2;
            Console.WriteLine($"Çarpım={sonuc}");

        }
        public void bol()
        {
            Console.Write("1. Sayıyı Giriniz:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz:");
            int s2 = Convert.ToInt32(Console.ReadLine());
            int sonuc = s1 / s2;
            Console.WriteLine($"Bolum={sonuc}");

        }
    }
}

## Version-2 ##
using System;

namespace ConsoleApp4
{
    class Program
    {

        static void Main(string[] args)
        {
            Islem islmeNesne = new Islem();
            while (true)
            {
                islmeNesne.sayilariKullanicidanAl();
                Console.WriteLine("*****İşlemler*****");
                Console.WriteLine("1 - Topla");
                Console.WriteLine("2 - Çıkart");
                Console.WriteLine("3 - Çarp");
                Console.WriteLine("4 - Böl");
                Console.WriteLine("5 - Çıkış");
                Console.Write("Seçiminiz (1,  2,   3,  4,  5)---->");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {
                    islmeNesne.topla();
                }
                else if (secim == 2)
                {
                    islmeNesne.cikart();
                }
                else if (secim == 3)
                {
                    islmeNesne.carp();
                }
                else if (secim == 4)
                {
                    islmeNesne.bol();
                }
                else if (secim == 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Lütfen 1 - 5 arası sayı giriniz:");
                }
                islmeNesne.sonucuEkranaYaz();
           
            }
        }
    }

    class Islem
    {
        int s1, s2,sonuc=0;
       public void sayilariKullanicidanAl()
       {
            Console.Write("1. Sayıyı Giriniz:");
             s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz:");
             s2 = Convert.ToInt32(Console.ReadLine());
       }
        public void sonucuEkranaYaz()
        {
            Console.WriteLine($"Sonuc={sonuc}");
        }
        public void topla()
        {
             sonuc = s1 + s2;
        }
        public void cikart()
        {
            sonuc = s1 - s2;
        }
        public void carp()
        {
            sonuc = s1 * s2;
        }
        public void bol()
        {
            sonuc = s1 / s2;
        }
    }
}
