
**Soru-1**
> Aşağıda verilenlere göre  bir sınıf tasarlayınız.Ve bu sınıftan 3 nesne oluşturup bilgilerini ve yaşını ekrana yazdırınız.

**a.** adSoyad, dogumTarihi, dogumYeri, okulNo,  özellikleri bulunacak.

**b.** yasHesapla ve bilgileriEkranaYaz metodları bulunacak

> **Not:** Kurucu metot kullanılmalı


**Sorunun Çözümü**

```python

using System;

class Personel
{
    string adSoyad;
    int dogumTarihi;
    string dogumYeri;
    short okulNo;

    Personel(string adSoyad, int dogumTarihi, string dogumYeri,short okulNo)
    {
        this.adSoyad = adSoyad;
        this.dogumTarihi = dogumTarihi;
        this.dogumYeri = dogumYeri;
        this.okulNo = okulNo;
        Console.WriteLine("-----Yeni Nesne oluşturuldu------");
    }

    void bilgileriEkranaYaz()
    {
        Console.WriteLine($"Ad Soyad:{adSoyad}");
        Console.WriteLine($"Doğum Tarihi:{dogumTarihi}");
        Console.WriteLine($"Doğum yeri:{dogumYeri}");
        Console.WriteLine($"Okul No:{okulNo}");
        Console.WriteLine($"Yaşınız: {yasHesapla(2021)}");
    }
    int yasHesapla(int hangiYil)
    {
        return hangiYil - dogumTarihi;
    }


    static void Main(string [] args)
    {
        Personel personel1 = new Personel("Arda TURAN", 1985, "İstanbul", 254);
        personel1.bilgileriEkranaYaz();

        Personel personel2 = new Personel("Serhat AKIN", 1962, "Mersin", 250);
        personel2.bilgileriEkranaYaz();

        Personel personel3 = new Personel("Fatih TERİM", 1950, "Adana", 300);
        personel3.bilgileriEkranaYaz();
        Console.ReadKey();

    }
    

}

```

**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/136901701-33404da5-4c38-4c37-9bcc-b761f3463e98.png)


**Soru-2**
> Aşağdaki verilenler göre Ogrenci adında bir sınıf tasarlayınız ve 3 farklı öğrenci nesnesi oluşturup bilgilerini ekrana yazdırınız

**a.** adSoyad, okulNo, puan1,puan2,puan3 özellikleri bulunacak

**b.** ortalamaHesapla, kaldiGectiHesapla, bilgileriEkranaYaz metotları olacak

> **Not:** Kurucu metot kullanılmalı


**Sorunun Çözümü**

```python

```

**Ekran Çıktısı**
