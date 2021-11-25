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

**Soru-2**

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
            if (value.trim() == "")
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

**Soru-3**

> Aşağıda verilenlere göre  bir sınıf tasarlayınız.Ve bu sınıftan klavyeden girilen verilere göre for döngüsü yardımıyla 3 nesne oluşturup bilgilerini ekrana yazdırınız.

1. adSoyad, puan1, puan2 alanları bulunacak ve aşağıdaki şartlarda kapsüllenecek
    1. adSoyad boş gelirse "Ad Soyad girilmedi" atanacak"
    2. puan1, puan2 0 ile 100 arasında girilmezse 0 değeri atanacak
2.  ortalamaPuan ve kaldıGectiDurumu adında sadece okunabilir  property olacak.
3.  bilgileriEkranaYaz metodları bulunacak.

> **Kurucu metot kullanılmalı**
> **Kapsülleme yapılmalı**


**Çözümü**

```csharp
using System;
class Ogrenci
{
    private string adSoyad;
    public string AdSoyad
    {
        get
        {
            return adSoyad;
        }
        set
        {
            if (value.Trim() == "")
            {
                Console.WriteLine("Ad Soyad boş girildiği için hata oluştu ");
                adSoyad = "Ad Soyad Girilmedi...";
            }
            else
            {
                adSoyad = value;
            }
        }
    }
    private short puan1;
    public short Puan1
    {
        get
        {
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
                Console.WriteLine("Puan1 Geçersiz puan girildiğinden 0 atandı.");
                puan1 = 0;
                
            }
        }
    }
    private short puan2;
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
                Console.WriteLine("Puan2 Geçersiz puan girildiğinden 0 atandı.");
                puan2 = 0;

            }
        }
    }
    public Ogrenci(string adSoyad, short puan1, short puan2)
    {
        this.AdSoyad = adSoyad;
        this.Puan1 = puan1;
        this.Puan2 = puan2;
    }

   public double OrtalamaPuan
    {
        get
        {
            return (Puan1 + Puan2) / 2.0;
        }
    }

    public string kaldıGectiDurumu
    {
        get
        {
            return OrtalamaPuan < 50 ? "KALDI.." : "GEÇTİ";
        }
    }

    public void bilgileriEkranaYaz()
    {
        Console.WriteLine("----------Öğrenci Bilgileri---------");
        Console.WriteLine($"Ad Soyad:{AdSoyad}");
        Console.WriteLine($"Puan1:{Puan1}");
        Console.WriteLine($"Puan2:{Puan2}");
        Console.WriteLine($"Ortalama:{OrtalamaPuan}");
        Console.WriteLine($"Durum:{kaldıGectiDurumu}");

    }
}

class AnaProgram
{
    static void Main(string [] args)
    {
        for (int i = 1; i < 4; i++)
        {
            Console.WriteLine($"{i}. Öğrenci Bilgileri Girişi");
            Console.Write("Ad Soyad Giriniz:");
            string adSoyad = Console.ReadLine();
            Console.Write("1. Puanı Giriniz:");
            short puan1 = Convert.ToInt16( Console.ReadLine());
            Console.Write("2. Puanı Giriniz:");
            short puan2 = Convert.ToInt16(Console.ReadLine());
            Ogrenci ogrNesne = new Ogrenci(adSoyad, puan1, puan2);
            ogrNesne.bilgileriEkranaYaz();
        }
    
        Console.ReadKey();
    }
}
```

**Program Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/138228177-140fb1d5-72be-4d30-8ba5-7150c62b4da4.png)

**Soru-4**
> Aşağıdaki verilenler göre Araba adında bir sınıf tasarlayınız. Bu sınıftan bir nesne oluşturarak  araba nesnesi oluşturup metodlarını çağırınız.


a. marka, model, yil, mevcutHiz, maxHiz alanları bulunacak.

b. hizDegistir (pozit değer hızlandıracaki negatif değer yavaşlatacak) ve bilgileriEkranaYaz metodları bulunacak.

d. Property kullanılmalı 

Not: Nesne ilk Oluşturulduğunda mevcut hız maximum hızın yarısı olacak. Ek olarak araba durana kadar  hızı -50 ve +50 arasında rastgele hızlar ile değiştirilecektir.
**Araba Classı**
  class Araba
    {
        string marka;
        public string Marka
        {
            get
            {
                return marka;
            }
            set
            {
                if (value.Trim() == "")
                {
                    throw new Exception("Marka Boş Geçilemez");
                }
                else
                {
                    marka = value;
                }
            }
        }
        string model;
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                if (value.Trim() == "")
                {
                    throw new Exception("Model Boş Geçilemez");
                }
                else
                {
                    model = value;
                }
            }
        }
        int yil;
        public int Yil
        {
            get
            {
                return yil;
            }
            set
            {
                int guncelYil = DateTime.Now.Year;

                if (value<=guncelYil && value >= 1900)
                {
                    yil = value;
                }
                else
                {
                    throw new Exception($"yil 1900 ile {guncelYil} arasında olmalı");

                }
                
            }
        }
        int maxHiz;

        public int MaxHiz
        {
            get
            {
                return maxHiz;
            }
            set { 
                if (value >=150 && value <= 320)
                {
                    maxHiz = value;
                }
                else
                {
                    throw new Exception("Max hiz 150 ile 320 arasında olmalı");
                }
            }
        }
        int mevcutHiz;
        public int MevcutHiz{
            get
            {
                return mevcutHiz;
            }
            set
            {
                if (value >= maxHiz)
                {
                    mevcutHiz = maxHiz;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Maximum hıza ulaşıldı");
                    Console.WriteLine($"Mevcut Hızınız:{mevcutHiz}");
                    Console.ResetColor();
                }
                else if (value<=0)
                {
                    mevcutHiz = 0;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Araç Durmuştur");
                    Console.ResetColor();
                }
                else
                {
                    mevcutHiz = value;
                }
            }
        }

     
        public void hizDegistir(int hiz)
        {
            MevcutHiz += hiz;
        }
        

        public void bilgileriEkranaYaz()
        {
            Console.WriteLine($"Marka:{Marka}");
            Console.WriteLine($"Model:{Model}");
            Console.WriteLine($"Yil:{Yil}");
            Console.WriteLine($"Max Hiz:{MaxHiz}");
            
        }
    }
**Ana Program**

 class Program
    {
        static void Main(string[] args)
        {
            Random rastNesne = new Random();
            try
            {
                Araba yeniAraba = new Araba();
                Console.Write("Lütfen Aracın Markasını Giriniz:");
                yeniAraba.Marka=Console.ReadLine();
                Console.Write("Lütfen Aracın Modelini Giriniz:");
                yeniAraba.Model= Console.ReadLine();
                Console.Write("Lütfen Aracın Yılını Giriniz:");
                yeniAraba.Yil = Convert.ToInt32(Console.ReadLine());
                Console.Write("Lütfen Aracın Max Hızını Giriniz:");
                yeniAraba.MaxHiz = Convert.ToInt32(Console.ReadLine());
                yeniAraba.MevcutHiz = yeniAraba.MaxHiz / 2;
                
                yeniAraba.bilgileriEkranaYaz();

                while (yeniAraba.MevcutHiz != 0)
                {
                    int hizDegeri = rastNesne.Next(-50, 50);
                    yeniAraba.hizDegistir(hizDegeri);
                    Console.WriteLine($"Hız Değeri: {hizDegeri}  Mevcut Hiz:{yeniAraba.MevcutHiz}");
                    System.Threading.Thread.Sleep(200);
                }
            }
            catch (Exception hata)
            {

                Console.WriteLine($"[HATA] {hata.Message}");
            }
            
            Console.ReadKey();
        }
        

    }
