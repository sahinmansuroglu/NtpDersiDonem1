## Arayüzler (Interfaces) ##

**Örnek-1**

```csharp
using System;


    class Program
    {
        static void Main(string[] args)
        {
            Kare kare1 = new Kare { KenarA = 4 };
            Console.WriteLine($" Alan ={kare1.alanHesapla()}");
            Console.ReadKey();
        }
    }
    interface IAlan
    {
        int alanHesapla();
    }

    class Kare : IAlan
    {
        public int KenarA { get; set; }
        public int alanHesapla()
        {
            return KenarA * KenarA;
        }
    }



```

**Örnek-2**

```csharp

using System;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            Kare kare1 = new Kare { KenarA = 4 };
            Console.WriteLine($"Kare Alan ={kare1.alan()}");
            Console.WriteLine($"Kare ÇEvre ={kare1.cevre()}");
            Dikdortgen dikdortgen1 = new Dikdortgen { KenarA = 4,KenarB=5 };
            Console.WriteLine($"Dikdörtgen Alan ={dikdortgen1.alan()}");
            Console.WriteLine($"Dikdörtgen Çevre ={dikdortgen1.cevre()}");
            Console.ReadKey();
        }
    }
    interface IHesap
    {
        int alan();
        int cevre();
    }
    class Kare : IHesap
    {
        public int KenarA { get; set; }

        public int alan()
        {
            return KenarA * KenarA;
        }

        public int cevre()
        {
            return KenarA * 4;
        }
    }
     class Dikdortgen:IHesap
    {
        public int KenarA { get; set; }
        public int KenarB { get; set; }
        public int alan()
        {
            return KenarA * KenarB;
        }

        public int cevre()
        {
            return (KenarA+KenarB) * 2;
        }
    }
}

```

**Örnek-3**

> Aşağıdaki Verilenlere Göre Ogrenci abstract class'ını tanımlayınız.

    1. AdSoyad property'si olacak
    2. bilgileriEkranaYaz metodu alacak
    3. enOnemliOlayi() adında bir abstract metodu olacak

> İçerisinde matematikİcerigi() metodu bulunan  IMAtematik adında bir interface tanımlayınız
> LiseOgrencisi isminde bir class'ı Ogrenci Class'ı ve IMAtematik interface'inden  türetin. 

    1. enOnemliOlayi() metodu "LGS Sınavı" şeklinde string döndürsün.
    2. matematikİcerigi() metodu " Geometri, Temel Matematik, İleri MAtematik" şeklinde string döndürsün.
    
> OrtaOkulOgrencisi isminde bir class'ı Ogrenci Class'ı ve IMAtematik interface'inden  türetin. 

    1. enOnemliOlayi() metodu "YKS Sınavı" şeklinde string döndürsün.
    2. matematikİcerigi() metodu "Matemaik" şeklinde string döndürsün.
    
> Son olarak LiseOgrencisi ve  OrtaOkulOgrencisi  sınıflarından nesne türetip bilgilerini ekrana yazdırınız


```csharp


```
