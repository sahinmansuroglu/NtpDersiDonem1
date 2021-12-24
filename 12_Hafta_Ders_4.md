## System.Array class'i ile diziler Üzerinde İşlemler ##

> Tüm diziler System.Array sınıfı için bir nesne olarak kabul edilir

> System.Array sınıfı her bir dizi bir çok yararlı metot ve özellk sağlar.

|Özellik/Metot Adı|Açıklama| Örnek Kullanim|
|---------|---------|---------|
| IndexOf|verilen elemanı arar. Bulursa index değerini verir, bulamazsa -1 döndürür | Array.IndexOf( diziAdi, object aranacakDeger) |
| BinarySearch| IndexOf ile aynı işlemi yapar. Ancak Daha hızlı yapar.(Öncesinde Sıralama Yapılamlı)|Array.BinarySearch( diziAdi, object aranacakDeger) |
| Clear|Dizinin istenilen kısmındaki verileri temizler|   Array.Clear( diziAdi, baslangıçSırası, uzunluk|
| Resize|Dizinin Boyutunu azaltmaya/arttırmaya yarar|   Array.Resize(diziAdi, yeniBoyut) |
| Sort|Dizideki elemanları artan sıralar.|  Array.Sort(diziAdi)  |
| Reverse|Diziyi ters çevirir |  Array.Reverse(diziAdi) |
| CopyTo|Kaynak dizideki elemanları hedef dizinin istenilen sırasına kopyalar|  kaynakDizi.CopyTo(hedefDizi,indexNo) |
| Clone| Dizinin kopyası verir (Object tipinde döndürür.İStenilen tipe Cast edilmesi gerekir).|  diziadi.Clone() |

**Örnek-1**

> 10 Elemanlı int tipindeki bir dizide klavyeden girilen sayının bulunup bulunmadığının kontrolünü yapan program.
```csharp
static void Main()
        {

            int[] dizi = new int[10] { 65, 22, 45, 36, 96, 454, 85, 65, 312, 258 };
            Console.WriteLine("Aranacak Sayıyı Giriniz");
            int aranacakSayi = Convert.ToInt32(Console.ReadLine());
            int bulunduguSira = Array.IndexOf(dizi, aranacakSayi);
            if (bulunduguSira == -1)
            {
                Console.WriteLine($"{aranacakSayi} Sayısı dizide bulunmamaktadır ");

            }
            else
            {
                Console.WriteLine($"{aranacakSayi} Sayısı dizide {bulunduguSira} sırada bulunmaktadır ");
            }
            
            Console.ReadKey();

        }
```

**Örnek-2**
> 20 Elemanlı 0-1000 arası rastgele sayılardan oluşan bir diz tanımlayarak aşağıdaki istenilenleri sırası ile uygulayınız.

        - Dizinin Büyükten küçüğe ve küçükten büyüğe sıralanmış halini ekrana yazdırınız.
        - Dizideki en büyük ve en küçük sayıları ekrana yazdırınız.
        - Diziyi 10 elemanlı dizi haline getirip elemanlarını ekrana yazdırınız. (resize)
        - 10 elemanlı diziyi  15 elemanlı dizi haline getirerek elemanlarını ekrana yazdırınız. (resize)
**Çözüm**
```csharp
using System;
using System.Linq;
namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[20];

            // Dizi 0-1000 arası Rastgele sayılarla doldurulacak
            Random randomNesnesi = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = randomNesnesi.Next(0, 100);
            }
            //Dizideki Sayıları Listeleme
            Console.Write("Dizideki Elemanlar:");
            foreach (int herBirSayi in dizi)
            {
                Console.Write($"{herBirSayi} ");
            }
            Console.WriteLine();
            //Siralama
            Array.Sort(dizi);
            //Dizideki Sayıları Listeleme
            Console.Write("Sıralı Dizideki Elemanlar:");
            foreach (int herBirSayi in dizi)
            {
                Console.Write($"{herBirSayi} ");
            }
            Console.WriteLine();
            //Reverse İşlemi
            Array.Reverse(dizi);
            //Dizideki Sayıları Listeleme
            Console.Write("Reverse Sonrası Dizideki Elemanlar:");
            foreach (int herBirSayi in dizi)
            {
                Console.Write($"{herBirSayi} ");
            }
            Console.WriteLine();
            Console.Write($"Max: {dizi.Max()} ");
            Console.Write($"Min: {dizi.Min()} ");
            Console.WriteLine();
            //resize ile 10 Elemanlı dizi haline getirme
            Array.Resize(ref dizi, 10);

            Console.Write("Resize Sonrası Dizideki Elemanlar:");
            foreach (int herBirSayi in dizi)
            {
                Console.Write($"{herBirSayi} ");
            }
            Console.WriteLine();
            //resize ile 15 Elemanlı dizi haline getirme
            Array.Resize(ref dizi, 15);

            Console.Write("Resize Sonrası Dizideki Elemanlar:");
            foreach (int herBirSayi in dizi)
            {
                Console.Write($"{herBirSayi} ");
            }
            Console.ReadKey();
        }


    }
}

```

> **Not:**  Yukarıdaki uygulamaya dikkat edilirse foreach döngüsü ile diziyi ekrana yazdırma işlemi 5 kez tekrar etmiştir. bu işlem metot haline getirilirek uygulamadaki kod tekrarı giderilerek daha sade hale getirilebilir.
**Örnek-2**
> Aşağıdaki Verilenlere göre uygulamayı her bir işlem için metot tanımlayarak DiziIslem adında bir class içerisinde tasarlayınız.

       a) Aşağıdaki Menüyü "Menu" adından bir metot içerisinde tanımlayınız.
                - ***İşlemler***
                - 1- Rastgele Dizi oluştur (Klavyeden dizinin boyutu girilecek o boyuta göre int dizisi oluşturulacak)
                - 2- Dizideki sayıları ekrana  yanyayan yazdır.
                - 3- Diziyi Sırala
                - 4- Diziyi Ters Çevir
                - 5- Diziyi Genişlet/Daral (Klavyeden girilen boyuta göre genişletilecek veya daraltılacak)
                - 6- Dizinin Kopyasını oluştur.(Herbir sayı Ana dizideki sayının iki katı olacak )
                - 6- Dizide Sayı Arama
                - 7- Çıkış
        b) Yukarıdaki her bir işlem ayrı bir metot içerisinde gerçekleştirilecektir. 
**Çözüm**

```csharp
using System;
using System.Linq;

namespace ArraysExample
{
    class Program
    {
        static void Main()
        {

            DiziIslem diziIslem = new DiziIslem();
            diziIslem.ProgramıBaslat();
            Console.ReadKey();
        }
    }
    class DiziIslem
    {
        int[] dizi;
        public void MenuEkranaBas()
        { 
          
            Console.WriteLine("*** İşlemler ***");
            Console.WriteLine("1 - Rastgele Dizi oluştur");
            Console.WriteLine("2 - Dizideki sayıları ekrana  yanyana yazdır");
            Console.WriteLine("3 - Diziyi Sırala");
            Console.WriteLine("4 - Diziyi Ters Çevir");
            Console.WriteLine("5 - Diziyi Genişlet / Daralt");
            Console.WriteLine("6 - Dizinin Kopyasını oluştur. (Eski Elemanların 2 Katı ile)");
            Console.WriteLine("7 - Dizide Sayı Arama");
            Console.WriteLine("8 - Çıkış");
        }

        public void ProgramıBaslat()
        {
          
            while (true)
            {
                MenuEkranaBas();
                Console.Write("Seçiminiz:");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim>=1 && secim <= 7)
                {
                    switch (secim)
                    {
                        case 1:
                            Console.WriteLine("Rastgele Dizi oluştur Seçildi");
                            rastgeleDiziOlustur();
                            break;
                        case 2:
                            Console.WriteLine("2 - Dizideki sayıları ekrana  yanyayan yazdır");
                            dizidekiSayilarıEkranaYaz();
                            break;
                        case 3:
                            Console.WriteLine("3 - Diziyi Sırala");
                            diziyiSirala();
                            break;
                        case 4:
                            Console.WriteLine("4 - Diziyi Ters Çevir");
                            diziyiTersCevir();
                            break;
                        case 5:
                            Console.WriteLine("5 - Diziyi Genişlet / Daral");
                            diziyiGenisletDaralt();
                            break;
                        case 6:
                            Console.WriteLine("6 - Dizinin Kopyasını oluştur.");
                            dizininKopyasiniOlustur();
                            break;
                        case 7:
                            Console.WriteLine("7 - Dizide Sayı Arama");
                            dizideElemanAra();
                            break;
                        default:
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Program Sonlandırıldı..");
                    break;
                }

            }

        }

        private void dizideElemanAra()
        {
            Console.Clear();
            Console.Write("Aranacak Sayıyı Giriniz:");
            int aranacakSayi = Convert.ToInt32(Console.ReadLine());
            int bulunanSira = Array.IndexOf(dizi, aranacakSayi);

            if (bulunanSira == -1)
            {
                Console.WriteLine("Sayı Bulunamadı");
            }else
            {
                Console.WriteLine($"Sayı bulundu Sırası:{bulunanSira}");

            }
            Console.ReadKey();
        }

        private void dizininKopyasiniOlustur()
        {
            Console.Clear();
            int [] kopyaDizi =(int []) dizi.Clone();
            for (int i = 0; i < kopyaDizi.Length; i++)
            {
                kopyaDizi[i] *= 2;
            }
            Console.WriteLine("Gerçek Dizi");
            dizidekiSayilarıEkranaYaz();
            Console.WriteLine("Dizinin Klonu");
            Console.Write("Dizideki Sayılar:");
            foreach (var herbirSayi in kopyaDizi)
            {
                Console.Write($"{herbirSayi} ");
            }
            Console.Clear();
        }

        private void diziyiGenisletDaralt()
        {
            Console.Clear();

            Console.WriteLine("Resize Öncesi");
            dizidekiSayilarıEkranaYaz();

            Console.Write("Dizinin yeni Uzunlugunu Giriniz:");
            int yeniDiziUzunlugu = Convert.ToInt32(Console.ReadLine());
            int dizininOncekiUzunlugu = dizi.Length;
            Array.Resize(ref dizi, yeniDiziUzunlugu);
            Random randomNesnesi = new Random();
            if (yeniDiziUzunlugu > dizininOncekiUzunlugu)
            {

                for (int i = dizininOncekiUzunlugu; i < yeniDiziUzunlugu; i++)
                {
                    dizi[i] = randomNesnesi.Next(0, 100);
                }
            }
            Console.WriteLine("Resize Sonrası");
            dizidekiSayilarıEkranaYaz();
        }

        private void diziyiTersCevir()
        {
            Console.Clear();
            Console.WriteLine("Reverse Öncesi");
            dizidekiSayilarıEkranaYaz();
            Array.Reverse(dizi);
            Console.WriteLine("Reverse Sonrası");
            dizidekiSayilarıEkranaYaz();
        }

        private void diziyiSirala()
        {
            Console.Clear();
            Console.WriteLine("Sıralama Öncesi");
            dizidekiSayilarıEkranaYaz();
            Array.Sort(dizi);
            Console.WriteLine("Sıralama Sonrası");
            dizidekiSayilarıEkranaYaz();
        }

        private void dizidekiSayilarıEkranaYaz()
        {
          
            Console.Write("Dizideki Sayılar:");
            foreach (var herbirSayi in dizi)
            {
                Console.Write($"{herbirSayi} ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        private void rastgeleDiziOlustur()
        {
            Console.Clear();
            Console.Write("Dizinin Uzunlugunu Giriniz:");
            int diziUzunlugu = Convert.ToInt32(Console.ReadLine());
            dizi = new int[diziUzunlugu];
             Random randomNesnesi = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = randomNesnesi.Next(0, 100);
            }

            Console.WriteLine("Dizi Oluşturuldu");
            Console.ReadKey();
            dizidekiSayilarıEkranaYaz();


        }
    }

  
}

```
