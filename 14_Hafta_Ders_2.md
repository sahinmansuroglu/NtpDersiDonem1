## Dictionary Koleksiyonu ##

> Dizilerde ve ArrayList yapılarında her bir elemana 0'dan başlayarak index numarası verilir ve her bir index numarasına karşılık gelen bir değer bulunmaktadır. Dictionary yapısınında ise index-değer yapısına karşılık key-value(Anahtar-Değer) yapısı kullanılır. Dictionary yapısında her bir değere ulaşmak için anahtar değeri kullanılır. Kullanılacak olan anahtar ve değerin tipi Dictionary yapısı tanımlanırken verilir

**Temel Kullanım**

```csharp
Dictionary<Key_Tipi, Value_Tipi> Referans_Adi = new Dictionary<Key_Tipi, Value_Tipi>();
```

**Örnek**

```csharp
static void Main(string[] args)
        {
            Dictionary<int, string> ogrenci = new Dictionary<int, string>();
            ogrenci.Add(658, "Ahmet");
            ogrenci.Add(95, "Arda");
            ogrenci.Add(24, "Veli");
            ogrenci.Add(68, "Serdar");
            //24 numaralı ogrenciyi gösterir
            Console.WriteLine(ogrenci[24]);//ekrana "Veli" Yazar
            Console.ReadKey();
        }
```

### Metotlar ve Özellikler ###
 #### 1- ContainsKey(Aranan_Key) Metodu ####
> Koleksiyon içerisinde, parametre olarak girilen değerde bir Anahtar (Key) mevcutsa TRUE  değilse FALSE döndürecektir.

```csharp
            Dictionary<int, string> ogrenci = new Dictionary<int, string>();
            ogrenci.Add(658, "Ahmet");
            ogrenci.Add(95, "Arda");
            ogrenci.Add(24, "Veli");
            ogrenci.Add(68, "Serdar");
         
            Console.WriteLine(ogrenci.ContainsKey(45));//False Yazar
            Console.WriteLine(ogrenci.ContainsKey(68));//True Yazar
```

#### 2- ContainsValue(Aranan_Value) Metodu ####
> Koleksiyon içerisinde, parametre olarak girilen değerde bir Değer (Value) mevcutsa TRUE  değilse FALSE döndürecektir.
 
```csharp
            Dictionary<int, string> ogrenci = new Dictionary<int, string>();
            ogrenci.Add(658, "Ahmet");
            ogrenci.Add(95, "Arda");
            ogrenci.Add(24, "Veli");
            ogrenci.Add(68, "Serdar");
         
            Console.WriteLine(ogrenci.ContainsValue("Ece"));//False Yazar
            Console.WriteLine(ogrenci.ContainsValue("Veli"));//True Yazar
```
    
#### 3- Clear() Metodu ####
> Koleksiyon içerisinde yer alan tüm Anahtar-Değer çiftlerini silmektedir.

```csharp
            Dictionary<int, string> ogrenci = new Dictionary<int, string>();
            ogrenci.Add(658, "Ahmet");
            ogrenci.Add(95, "Arda");
            ogrenci.Add(24, "Veli");
            ogrenci.Add(68, "Serdar");
            ogrenci.Clear();
```
    

#### 4- Count Özelliği ####
> Eleman Sayısını döndürür

```csharp
            Dictionary<int, string> ogrenci = new Dictionary<int, string>();
            ogrenci.Add(658, "Ahmet");
            ogrenci.Add(95, "Arda");
            ogrenci.Add(24, "Veli");
            ogrenci.Add(68, "Serdar");
            Console.WriteLine(ogrenci.Count);// Ekrana 4 yazar
```

#### 5- Remove(Silinecek_Key) Metodu ####
> Koleksiyon içerisinde, parametre olarak girilen değerde bir Anahtar (Key) mevcutsa; Anahtarı ve anahtarla ilişkili Değeri silip TRUE döndürecektir. Anahtar mevcut değilse FALSE döndürecektir.

```csharp
            Dictionary<int, string> ogrenci = new Dictionary<int, string>();
            ogrenci.Add(658, "Ahmet");
            ogrenci.Add(95, "Arda");
            ogrenci.Add(24, "Veli");
            ogrenci.Add(68, "Serdar");
            bool SilindiMi = ogrenci.Remove(658);
            if (SilindiMi)
            {
                Console.WriteLine("658 Numaralı ogrenci silindi");
            }
            else
            {
                Console.WriteLine("658 Numaralı ogrenci bulunamadı");
            }
```

#### 6- Keys Özelliği ####
> Anahtarları (Keys) içeren bir koleksiyon döndürmektedir.

```csharp
      Dictionary<int, string> ogrenci = new Dictionary<int, string>();
            ogrenci.Add(658, "Ahmet");
            ogrenci.Add(95, "Arda");
            ogrenci.Add(24, "Veli");
            ogrenci.Add(68, "Serdar");
            //Key değerlerinden liste oluşturur
            Dictionary<int, string>.KeyCollection ogrenciNoList = ogrenci.Keys;
            //Ogrenci key yani noları ekrana yazar (658 95 24 68)   
```
#### 7-Values Özelliği ####
> Değerleri (Values) içeren bir koleksiyon döndürmektedir.

```csharp
      Dictionary<int, string> ogrenci = new Dictionary<int, string>();
            ogrenci.Add(658, "Ahmet");
            ogrenci.Add(95, "Arda");
            ogrenci.Add(24, "Veli");
            ogrenci.Add(68, "Serdar");
            //Value değerlerinden liste oluşturur
            Dictionary<int, string>.ValueCollection ogrenciAdList = ogrenci.Values;
            //Ogrenci value yani adları ekrana yazar (Ahmet Arda Veli Serdar)
            Console.WriteLine(string.Join(" ", ogrenciAdList));
```

**Örnek**

> ogrenciler adında bir dictionary oluşturun ardından aşağıdaki menuyu tasarlayarak uygun işlemleri oluşturulan dictioary üzerinde yaptırın.

         İşlemler
         1- Ogrenci Ekle (Numarası ile ekle) (Aynı Numarada 2 öğrenci olamaz)
         2- Öğrencileri  listele
         3- Öğrenci Sil
         4- Çıkış
  
**Çözüm**
```csharp
using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> ogrenciler = new Dictionary<int, string>();

            while (true)
            {
                Console.WriteLine("İşlemler");
                Console.WriteLine("1 - Ogrenci Ekle(Numarası ile ekle)(Aynı Numarada 2 öğrenci olamaz)");
                Console.WriteLine("2 - Öğrencileri  listele");
                Console.WriteLine("3 - Öğrenci Sil");
                Console.WriteLine("4 - Çıkış");
                Console.Write("Seçiminiz:");
                string secim = Console.ReadLine();
                if (secim=="4")
                {
                    break;
                }
                if (secim=="1")
                {
                    Console.Write("Öğrenci No Giriniz:");
                    int ogrNo = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Öğrenci adı Giriniz:");
                    string ogrAdi = Console.ReadLine();
                    if (ogrenciler.ContainsKey(ogrNo))
                    {
                        Console.WriteLine($"{ogrNo} zaten bulunmaktadır. Ekleme İşlemi Başarısız..");
                    }
                    else
                    {
                        ogrenciler.Add(ogrNo, ogrAdi);
                        Console.WriteLine("ekleme İşlemi Başarılı");

                    }
                    
                }
                else if (secim == "2")
                {
                    Console.WriteLine($"{"Ogrenci No",10} {"Ogrenci Adı",20}");
                    foreach (int ogrNo in ogrenciler.Keys)
                    {
                        Console.WriteLine($"{ogrNo,10} {ogrenciler[ogrNo],20}");
                    }
                }
                else if (secim == "3")
                {
                    Console.Write("Silinecek Öğrenci No Giriniz:");
                    int ogrNo = Convert.ToInt32(Console.ReadLine());
                    if (ogrenciler.ContainsKey(ogrNo))
                    {
                        ogrenciler.Remove(ogrNo);
                        Console.WriteLine($"{ogrNo} numaralı öğrenci silinlmiştir");
                    }
                    else
                    {
                       Console.WriteLine("Girilen noya ait Öğrenci Bulunamadı");
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen 1-4 arası rakam giriniz..");
                }
                Console.WriteLine("Devam Etmek İçin bir tuşa basınız.");
                Console.ReadKey();
                Console.Clear();
     
     
            }
            Console.WriteLine("Program sonlandı..");
            Console.ReadKey();
        }
    }
}
```
