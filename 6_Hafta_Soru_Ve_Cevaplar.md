
**Soru-1**
> Solution explorer penceresinde iki tane console uygulaması (anaProgram ve hesaplamaProjesi adında) oluşturunuz.
> hesaplamaProjesi içerisinde aşağıdaki verilenler göre Dikdörtgen adında bir sınıf tasarlayınız

**a.** kisaKenarUzunlugu ve uzunKenarUzunlugu alanları bulunacak

**b.** alanHesapla, cevreHesapla bilgileriEkranaYaz metotları olacak

> anaProgram içerisinden  hesaplamaProjesi içerisindeki Dikdortgen class'ından 3 adet  dikdortgen nesnesi oluşturup alanını ve çevresini hesaplatarak ekrana yazdırınız.

**Not: Kurucu metot kullanılmalı**

**Sorunu Çözümü**

>Proje yapısı

![image](https://user-images.githubusercontent.com/28144917/137284968-c3926b1a-8b64-44af-b690-b8b1e2824c6f.png)

> Dikdortgen Class'ı

```csharp

namespace hesaplamaProjesi
{
    public class Dikdortgen
    {
        private int kisaKenarUzunlugu;
        private int uzunKenarUzunlugu;
        public Dikdortgen(int kisaKenarUzunlugu, int uzunKenarUzunlugu)
        {
            this.kisaKenarUzunlugu = kisaKenarUzunlugu;
            this.uzunKenarUzunlugu= uzunKenarUzunlugu;
            
        }

        private int alanHesapla()
        {
            return kisaKenarUzunlugu * uzunKenarUzunlugu;
        }

        private int cevreHesapla()
        {
            return (kisaKenarUzunlugu + uzunKenarUzunlugu) * 2;
        }

        public void bilgileriEkranaYaz()
        {
            Console.WriteLine("------------Bilgiler-------------");
            Console.WriteLine($" Alan: {alanHesapla()}");
            Console.WriteLine($" Çevre: {cevreHesapla()}");
        }
    }
}

```

> Ana Program

```csharp

namespace anaProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            hesaplamaProjesi.Dikdortgen yeniNesne1 = new hesaplamaProjesi.Dikdortgen(35, 26);
            hesaplamaProjesi.Dikdortgen yeniNesne2 = new hesaplamaProjesi.Dikdortgen(15, 52);
            hesaplamaProjesi.Dikdortgen yeniNesne3 = new hesaplamaProjesi.Dikdortgen(10, 24);
            yeniNesne1.bilgileriEkranaYaz();
            yeniNesne2.bilgileriEkranaYaz();
            yeniNesne3.bilgileriEkranaYaz();

            Console.ReadKey();

        }
    }
}

```

> Aşağıda verilenlere göre  bir sınıf tasarlayınız.Ve bu sınıftan klavyeden girilen verilere göre for döngüsü yardımıyla 3 nesne oluşturup bilgilerini ekrana yazdırınız.

1. adSoyad, puan1, puan2, puan3 alanları bulunacak ve aşağıdaki şartlarda kapsüllenecek
    1. adSoyad boş gelirse "Ad Soyad girilmedi" atanacak"
    3. puan1, puan2, puan3 0 ile 100 arasında girilmezse 0 değeri atanacak
3. ortalamaHesapla, kaldıGectiHesapla ve bilgileriEkranaYaz metodları bulunacak.

> **Kurucu metot kullanılmalı**
> **Kapsülleme yapılmalı**

```csharp
using System;
public class Ogrenci
{
    private string adSoyad;
    private short okulNo;
    private short puan1;
    private short puan2;
    private short puan3;

    public string AdSoyad {
        get {
            return adSoyad;
        }

        set {
            if (value == "")
            {
                adSoyad = "Ad Soyad Girilmedi";
            }
            else
            {
                adSoyad =value; 
            }
                   
        } 
    }

    public short OkulNo {
        get {
            return okulNo;
        }
        set {
            okulNo = value;
        } 
    }

    public short Puan1 {
        get {
            return puan1;
        }
        set
        {
            if (value>=0 && value <= 100)
            {
                puan1 = value;
            }
            else
            {
                puan1 = 0;
            }

        } 
    }
    public short Puan2
    {
        get
        {
            return puan2;
        }
        set
        {
            if (value >= 0 && value <= 100)
            {
                puan2 = value;
            }
            else
            {
                puan2 = 0;
            }

        }
    }
    public short Puan3
    {
        get
        {
            return puan3;
        }
        set
        {
            if (value >= 0 && value <= 100)
            {
                puan3 = value;
            }
            else
            {
                puan3 = 0;
            }

        }
    }

    public Ogrenci(string adSoyad,short okulNo,short puan1,short puan2,short puan3)
    {
        this.AdSoyad = adSoyad;
        this.OkulNo = okulNo;
        this.Puan1 = puan1;
        this.Puan2 = puan2;
        this.Puan3 = puan3;
    }

    public double ortalamaHesapla()
    {
        return (puan1 + Puan2 + puan3) / 3.0;
    }
    public string kaldiGectiHesapla()
    {
        if (ortalamaHesapla() < 50)
        {
            return "Kaldı..";
        }
        else
        {
            return "Geçti";
        }
    }
    public void bilgileriEkranaYaz()
    {
        Console.WriteLine("---------Öğrenci Bilgileri----------");
        Console.WriteLine($" Ad Soyad:{adSoyad}");
        Console.WriteLine($" Okul No:{okulNo}");
        Console.WriteLine($" Puan1: {puan1}");
        Console.WriteLine($" Puan2: {puan2}");
        Console.WriteLine($" Puan3: {puan3}");
        Console.WriteLine($" Ortalama:{ortalamaHesapla()}");
        Console.WriteLine($" Durumu:{kaldiGectiHesapla()}");
        
    }
}

class Program
{
    public static void Main(string [] args)
    {
        Ogrenci ogr1 = new Ogrenci("Şahin MANSUROĞLU",256,45,95,100);
        ogr1.bilgileriEkranaYaz();
        Ogrenci ogr2 = new Ogrenci("Ali AR", 615, 52, 95, 50);
        ogr2.bilgileriEkranaYaz();
        Ogrenci ogr3 = new Ogrenci("Mehmet UÇTU", 65, 45, 95, 60);
        ogr3.bilgileriEkranaYaz();
        Console.ReadKey();
    }
}
```
**Program Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/137854309-d4ef593c-585c-4198-989b-36ba944decdd.png)
