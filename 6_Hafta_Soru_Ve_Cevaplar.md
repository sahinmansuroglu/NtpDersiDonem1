
**Soru-1**
> Aşağıda verilenlere göre  bir sınıf tasarlayınız.Ve bu sınıftan 3 nesne oluşturup bilgilerini ve yaşını ekrana yazdırınız.

**a.** adSoyad, dogumTarihi, dogumYeri, okulNo,  alanları bulunacak.

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

**a.** adSoyad, okulNo, puan1,puan2,puan3 alanları bulunacak

**b.** ortalamaHesapla, kaldiGectiHesapla, bilgileriEkranaYaz metotları olacak

> **Not:** Kurucu metot kullanılmalı


**Sorunun Çözümü**

```python
using System;

class Ogrenci
{
    string adSoyad;
    short okulNo;
    int puan1, puan2, puan3;

    Ogrenci(string adSoyad, short okulNo, int puan1, int puan2, int puan3)
    {
        this.adSoyad = adSoyad;
        this.okulNo = okulNo;
        this.puan1 = puan1;
        this.puan2 = puan2;
        this.puan3 = puan3;

        Console.WriteLine("--------Yeni Nesne Oluşturuldu--------");
    }

    double ortalamaHesapla()
    {
        return (puan1 + puan2 + puan3) / 3.0;
    }

    string kaldiGectiHesapla()
    {
        return ortalamaHesapla() < 50 ? "Kaldı":"Geçti";
    }
    //Alttaki metot yukarıdaki ile aynı işi yapmaktadır.
    //Yukarıda ternary(?) operatörü kullanılmıştır.
    string kaldiGectiHesaplaDiger()
    {
        if (ortalamaHesapla()< 50)
        {
            return "Kaldı";
        }
        else
        {
            return "Geçti";
        }
    }
    void bilgileriEkranaYaz()
    {
        Console.WriteLine("-----Öğrenci Bilgileri------");
        Console.WriteLine($"Ad Soyad: {adSoyad}");
        Console.WriteLine($"Okul No: {okulNo}");
        Console.WriteLine($"1. Puan: {puan1}");
        Console.WriteLine($"2. Puan: {puan2}");
        Console.WriteLine($"3. Puan: {puan3}");
        Console.WriteLine($"Ortalama: {ortalamaHesapla()}");
        Console.WriteLine($"Durum: {kaldiGectiHesapla()} ");
    }

    static void Main(string [] args)
    {
        Ogrenci ogrenci1 = new Ogrenci("Ali Veli", 352, 65, 85, 45);
        Ogrenci ogrenci2 = new Ogrenci("Serdar AR", 85, 15, 25, 45);
        Ogrenci ogrenci3 = new Ogrenci("Erhan UÇAR", 241, 100, 85, 45);

        ogrenci1.bilgileriEkranaYaz();
        ogrenci2.bilgileriEkranaYaz();
        ogrenci3.bilgileriEkranaYaz();
        Console.ReadKey();
    }

}
```

**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/136907119-92ebf530-39ef-43d2-8241-1ceaaa66984a.png)


**Soru-3**
> Aşağdaki verilenler göre Dikdörtgen adında bir sınıf tasarlayınız ve 3 farklı dikdortgen nesnesi oluşturup alanını ve çevresini hesaplatarak ekrana yazdırınız.

**a.** kisaKenarUzunlugu ve uzunKenarUzunlugu alanları bulunacak

**b.** alanHesapla, cevreHesapla bilgileriEkranaYaz metotları olacak

> **Not:**  Oluşturulan 3 yeni nesnenin  bilgileri(kisaKenarUzunlugu ve uzunKenarUzunlugu) ana programda for döngüsü yardımı ile kullanıcıdan alınacaktır.


**Sorunun Çözümü**

```python
using System;

class Dikdortgen
{
    int kisaKenarUzunlugu;
    int uzunKenarUzunlugu;
    Dikdortgen(int kisaKenarUzunlugu, int uzunKenarUzunlugu)
    {
        this.kisaKenarUzunlugu = kisaKenarUzunlugu;
        this.uzunKenarUzunlugu = uzunKenarUzunlugu;
    }

    int alanHesapla()
    {
        return kisaKenarUzunlugu * uzunKenarUzunlugu;
    }
    int cevreHesapla()
    {
        return (kisaKenarUzunlugu + uzunKenarUzunlugu) * 2;
    }
    void bilgileriEkranaYaz()
    {
        Console.WriteLine($"Alan={alanHesapla()}");
        Console.WriteLine($"Çevre={cevreHesapla()}");
    }

    static void Main(string [] args)
    {

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{i + 1}. Dikdörtgen Bilgileri");
            Console.Write("Kisa Kenar uzunluğunuzu Giriniz:");
            int girilenKisaKenarUzunlugu =Convert.ToInt32( Console.ReadLine());
            Console.Write("Uzun Kenar uzunluğunuzu Giriniz:");
            int girilenUzunKenarUzunlugu = Convert.ToInt32(Console.ReadLine());

            Dikdortgen yeniNesne = new Dikdortgen(girilenKisaKenarUzunlugu, girilenUzunKenarUzunlugu);

            yeniNesne.bilgileriEkranaYaz();

        }
        Console.ReadKey();

    }

}
```

**Sorunu Çözümü**

![image](https://user-images.githubusercontent.com/28144917/136916693-6b27c637-dde9-4d5a-9f64-c41a0448470f.png)

**Soru-4**
> Solution explorer penceresinde iki tane console uygulaması (anaProgram ve hesaplamaProjesi adında) oluşturunuz.
> hesaplamaProjesi içerisinde aşağıdaki verilenler göre Dikdörtgen adında bir sınıf tasarlayınız

**a.** kisaKenarUzunlugu ve uzunKenarUzunlugu alanları bulunacak

**b.** alanHesapla, cevreHesapla bilgileriEkranaYaz metotları olacak

> anaProgram içerisinden  hesaplamaProjesi içerisindeki Dikdortgen class'ından 3 adet  dikdortgen nesnesi oluşturup alanını ve çevresini hesaplatarak ekrana yazdırınız.

