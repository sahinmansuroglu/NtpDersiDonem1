## List-class-is-foreach kullanımı ##

```csharp
using System;
using System.Collections.Generic;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            ogrenciler.Add(new ilkokulOgrencisi { adSoyad = "Akın SERİN" });
            ogrenciler.Add(new ortaokulOgrencisi { adSoyad = "Ahmet SERİN" });
            ogrenciler.Add(new ilkokulOgrencisi { adSoyad = "Serkan SERİN" });
            ogrenciler.Add(new ortaokulOgrencisi { adSoyad = "Akın SEREN" });

            foreach (var ogrenci in ogrenciler)
            {
                ogrenci.bilgileriEkranaYaz();
                if (ogrenci is ilkokulOgrencisi)
                {
                    ((ilkokulOgrencisi)ogrenci).ortaokuldanMezunOlmaYiliniEkranaYaz();
                }
                if (ogrenci is ortaokulOgrencisi)
                {
                    ((ortaokulOgrencisi)ogrenci).gidebileceğiOkullariEkranaYaz();
                }
                
            }
            Console.ReadKey();
        }
    }


    class Ogrenci
    {
        public string adSoyad { get; set; }
        public  void bilgileriEkranaYaz() {
            Console.WriteLine( $"Ad Soyad:{adSoyad}");
        }
    }

    class ilkokulOgrencisi : Ogrenci
    {

        public void ortaokuldanMezunOlmaYiliniEkranaYaz()
        {
            Console.WriteLine("Başlama yılı:2000");
        }
    }
    class ortaokulOgrencisi : Ogrenci
    {
        public void gidebileceğiOkullariEkranaYaz()
        {
            Console.WriteLine("Gidebileceği Okullar: MTAL, Anadolu Lisesi, Fen Lisesi");
        }
    }
}

```
