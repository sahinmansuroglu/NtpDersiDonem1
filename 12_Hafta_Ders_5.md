## Class ve Dizi Kullanımı ile ilgili Örnekler ##

**Örnek-1**
> Aşağıda verilenleri sırasıyla uygulayarak projeyi  tanımlayınız

     1. Aşağıda verilenlere göre Ogretmen Adında bir class oluşturunuz.
       - AdSoyad  adında property olacak,
       - GirdigiDersler  adında ve  içinde istenilen sayıda Ders adı bulunabilecek bir dizi yapısında property olacak,
       - bilgileriEkranaYaz adında bir metot bulunacak. Bu metot Ad Soyad ve girdiği tüm dersleri ekrana yazdıracak.
     2. Ana Programda Ogretmen Nesnelerinden oluşan 5 elemanlı bir dizi tanımlayın.
     3. Dizideki tüm Ogretmen nesnelerinin bilgilerini foreach döngüsi ile ekrana yazdırınız.
     
     
**Çözüm**

```csharp
using System;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogretmen[] ogretmenler = new Ogretmen[5];
            ogretmenler[0] = new Ogretmen { AdSoyad = "AKIN SAK", GirdigiDersler = new string[] { "Kimya", "Matematik" } };
            string[] dersler1 = new string[] { "Fizik", "Mat", "Beden" };
            ogretmenler[1] = new Ogretmen { AdSoyad = "İrem SAK", GirdigiDersler = dersler1 };
            ogretmenler[2] = new Ogretmen { AdSoyad = "Mehmet SAK", GirdigiDersler = new string[] { "Fizik", "Matematik" } };
            ogretmenler[3] = new Ogretmen { AdSoyad = "Arda SAK", GirdigiDersler = new string[] { "Fizik", "Matematik","Kimya" } };
            ogretmenler[4] = new Ogretmen { AdSoyad = "Mehmet SAK", GirdigiDersler = new string[] { "Fizik", "Mat","Bil.","Tarih" } };

            foreach (var herBirOgretmen in ogretmenler)
            {
                herBirOgretmen.BilgileriEkranaYaz();
            }
            Console.ReadKey();
        }
    }

    class Ogretmen
    {
        public string AdSoyad { get; set; }
        public string [] GirdigiDersler { get; set; }

        public void BilgileriEkranaYaz()
        {
            Console.WriteLine("");
            Console.WriteLine($"Ad Soyad,:{AdSoyad}");
            Console.Write($"Girdiği Dersler:");
            foreach (var herBirDers in GirdigiDersler)
            {
                Console.Write($"{herBirDers} ");
            }
            Console.WriteLine("");
        }

    }
}
   
```
     
**Örnek-2**
Aşağıda verilenleri sırasıyla uygulayarak projeyi  tanımlayınız

    1. Aşağıda verilenlere göre Ogrenci Adında bir class oluşturunuz.
       - id, ad, Soyad, adında property olacak
       - puanlar adında ve  içinde istenilen sayıda puan bulunabilecek bir dizi olacak
       - tüm propertylerin değerleri kurucu metot ile verilecek. (Puanlar kurucu metoda dizi olarak gönderilecek)
       - Ortalama ve Durum adında readOnly Property olacak
       - bilgileriEkranaYaz adında bir metot bulunacak
     2. Ana Programda Ogrenci Nesnelerinden oluşan 5 elemanlı bir dizi tanımlayın.
     3. Dizideki tüm Ogrenci nesnelerinin bilgilerini foreach döngüsi ile ekrana yazdırınız.

Not: id değeri Aşağıdaki kod örneği kullanılarak class içerisinde otomatik oluşturulacaktır.

```csharp
    // GUID (Globally Unique IDentifier), bilgisayar yazılımlarında tanımlayıcı olarak kullanılan benzersiz bir referans numarasıdır. 
    Guid guid = Guid.NewGuid();
    string str = guid.ToString("N");
```

```csharp
  using System;
using System.Linq;
namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci[] ogrenciDizisi = new Ogrenci[5];
            int[] puanDizi1 = new int[] { 65, 35, 96, 78 };
            ogrenciDizisi[0] = new Ogrenci("Ali", "AYDIN",puanDizi1 );
            ogrenciDizisi[1] = new Ogrenci("Ahmet", "ECE", new int[] { 20, 35, 96, 78,15 });
            ogrenciDizisi[2] = new Ogrenci("Serdar", "AT", new int[] { 65,  78, 96 });
            ogrenciDizisi[3] = new Ogrenci("Sezgin", "TOL", new int[] { 65, 35, 96, 78, 96,52});
            ogrenciDizisi[4] = new Ogrenci("Akın", "EYMEN", new int[] { 78, 96 });

            foreach (Ogrenci ogrenci in ogrenciDizisi)
            {
                Console.ForegroundColor = Console.ForegroundColor == ConsoleColor.White? ConsoleColor.Red : ConsoleColor.White;
                ogrenci.bilgileriEkranaYaz();
            }

            Console.ReadKey();
        }


    }

    class Ogrenci
    {
        string id;
        public string ID { 
            get {
                return id;
            }
        }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int[] Puanlar { get; set; }
        public double Ortalama
        {
            get
            {
                return Puanlar.Average();
            }
        }

        public String Durum
        {
            get
            {
                return Ortalama < 50 ? "Kaldı" : "Geçti";

            }
        }
        public Ogrenci(string ad, string soyad, int [] puanlar)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.Puanlar = puanlar;
            Guid guid = Guid.NewGuid();
            this.id = guid.ToString("N");
        }
        
        public void bilgileriEkranaYaz()
        {
            
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Ad Soyad : {Ad} {Soyad}");
            Console.Write($"Puanlar:");
            foreach (var herbirPuan in Puanlar)
            {
                Console.Write($"{herbirPuan} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Ortalama:{Ortalama}");
            Console.WriteLine($"Durum:{Durum}");
        }

    }
}



```

**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/147231239-00c238f0-59d9-44e0-a516-102ba75abe29.png)
