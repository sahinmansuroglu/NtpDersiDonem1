## Soyut Sınıflar (Abstract Classes) ##

**Örnek-1**
```csharp
using System;

    class Program
    {
        static void Main(string[] args)
        {
            Kare kare1 = new Kare { KenarA = 4};
            Console.WriteLine($" Alan:{kare1.alanHesapla()}");
            Console.ReadKey();
        }
    }
    abstract class Alan
    {
        public abstract int alanHesapla();

    }

    class Kare : Alan
    {
        public int KenarA { get; set; }

        public override int alanHesapla()
        {
            return KenarA * KenarA;
        }
    }


```

**Örnek-2**

```csharp
using System;


    class Program
    {
        static void Main(string[] args)
        {
            Kare kare1 = new Kare { KenarA = 4,Baslik="Kare" };
            kare1.bilgileriEkranaYaz();

            Dikdortgen dikdortgen1 = new Dikdortgen { Baslik = "Dikdörtgen", KenarA = 20, KenarB = 10 };
            dikdortgen1.bilgileriEkranaYaz();

            Daire daire1 = new Daire { Baslik = "Daire", Yaricap = 3 };
            daire1.bilgileriEkranaYaz();
            Console.ReadKey();
        }
    }
    abstract class Hesap
    {
        public string Baslik = "Boş";
        abstract public int alan();
        abstract public int cevre();
        public void bilgileriEkranaYaz()
        {
            Console.WriteLine($"{Baslik} Bilgileri");
            Console.WriteLine($"Alan:{alan()}");
            Console.WriteLine($"Çevre:{cevre()}");
        }
    }

    class Kare : Hesap
    {
        public int KenarA { get; set; }

        public override int alan()
        {
            return KenarA * KenarA;
        }

        public override int cevre()
        {
            return KenarA * 4;
        }

    }

    class Dikdortgen : Hesap
    {
        public int KenarA { get; set; }
        public int KenarB { get; set; }
        public override int alan()
        {
            return KenarA * KenarB;
        }

        public override int cevre()
        {
            return (KenarA+KenarB) * 2;
        }
    }

    class Daire : Hesap
    {

        public int Yaricap { get; set; }

        public override int alan()
        {
            return Convert.ToInt32(Math.PI * Yaricap * Yaricap);
        }

        public override int cevre()
        {
            return Convert.ToInt32(Math.PI * Yaricap * 2);
        }
    }
```
**Örnek-3**

> Aşağıdaki Verilenlere Göre Ogrenci abstract class'ını tanımlayınız.

    1. AdSoyad property'si olacak
    2. bilgileriEkranaYaz metodu alacak
    3. enOnemliOlayi() adında bir abstract metodu olacak
    
> LiseOgrencisi isminde bir class'ı Ogrenci Class'ından türetin.
    
    enOnemliOlayi() metodu "LGS Sınavı" şeklinde string döndürsün.
    
> OrtaOkulOgrencisi isminde bir class'ı Ogrenci Classindan türetin
    
    enOnemliOlayi() metodu "YKS Sınavı" şeklinde string döndürsün
    
> Son olarak LiseOgrencisi ve  OrtaOkulOgrencisi  sınıflarından nesne türetip ekrana yazdırınız


![media_b77_b77f3c00-7558-48ed-bb77-be8a6a91aa2a_phpMh7bCs](https://user-images.githubusercontent.com/28144917/146252569-f604be53-6e1c-4a41-bba6-f718c7a893f2.png)
![image](https://user-images.githubusercontent.com/28144917/146254137-c125e5cb-46b5-44c6-b906-09310b8234a8.png)

