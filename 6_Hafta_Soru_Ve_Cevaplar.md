
**Soru-1**
> Solution explorer penceresinde iki tane console uygulaması (anaProgram ve hesaplamaProjesi adında) oluşturunuz.
> hesaplamaProjesi içerisinde aşağıdaki verilenler göre Dikdörtgen adında bir sınıf tasarlayınız

**a.** kisaKenarUzunlugu ve uzunKenarUzunlugu alanları bulunacak

**b.** alanHesapla, cevreHesapla bilgileriEkranaYaz metotları olacak

> anaProgram içerisinden  hesaplamaProjesi içerisindeki Dikdortgen class'ından 3 adet  dikdortgen nesnesi oluşturup alanını ve çevresini hesaplatarak ekrana yazdırınız.

**Not: Kurucu metot kullanılmalı **

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
