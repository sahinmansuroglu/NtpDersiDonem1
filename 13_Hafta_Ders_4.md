## List<Type> Sınıfı ##
> List  koleksiyonu ile ArrayList koleksiyonu kullanım olarak benzerlik göstermektedir. Temel fark; List koleksiyonunda içerisinde sadece aynı tipte veriler bulunabilmektedir. ArrayList koleksiyonlarında  ise farklı tipte veriler bulunabilmektedir.  

**Not:** Veri tipinin belli olduğu collection'lara Generic Colleciton, veri tipinin belli olmadığı collection'lara da  Non-generic collection denilir.Generic collectionlar'da veri tipi belli olduğu için boxing-unboxing işlemi gerçekleşmez. Örnek olarak List Colection'ı da bir generic colleciton olduğu için boxing-unboxing işlemleri gerçekleşmez. 

### List Tanımlama Örnekleri ###
  
```csharp
            List<int> sayilar = new List<int>();
            sayilar.Add(85);
            sayilar.Add(56);

            List<string> adlar = new List<string>();
            adlar.Add("Ahmet");
            adlar.Add("Mehmet");

            var sehirler = new List<string>() {"Ankara","Adana", "Mersin","Antalya"};
            sehirler.Add("İzmir");
  
            List<Ogrenci> ogrenciler = new List<ogrenci>();
            ogrenciler.Add(new ogrenci { ad = "Ali", yas=23 });
            ogrenciler.Add(new ogrenci { ad = "veli", yas = 96 });
  
```
 ### Örnek-1  ###
 > hayvanlar adında bir List tanımlayın içerisine 5 tane hayvan adi ekleyip for döngüsü ile ekrana yazdırınız.
  ```csharp
  //using System.Collections.Generic;    ad uzayı eklenmeli
  static void Main(string[] args)
        {
            List<string> hayvanlar = new List<string>();
            hayvanlar.Add("Aslan");
            hayvanlar.Add("Kaplan");
            hayvanlar.Add("Kurt");
            hayvanlar.Add("Köpek");
            hayvanlar.Add("Tavşan");

            for (int i = 0; i < hayvanlar.Count; i++)
            {
                Console.WriteLine($"{hayvanlar[i]}");
                

            }
            //ekrana yazdırmak için aşağıdaki string.Join yapısı da kullanılabilir                                   
            string listeMetin=string.Join("\n", hayvanlar);
            Console.WriteLine(listeMetin);
            Console.ReadKey();

        }
 ```
### Örnek-2  ###
> puanlar adında bir List tanımlayın içerisine 5 tane puan adi ekleyip foreach döngüsü ile ekrana yazdırınız.
```csharp
  
  //using System.Collections.Generic; ad uzayı eklenmeli
 static void Main(string[] args)
        {
            List<int> puanlar = new List<int>();
            puanlar.Add(96);
            puanlar.Add(96);
            puanlar.Add(65);
            puanlar.Add(24);
            puanlar.Add(32);

            foreach (int puan in puanlar)
            {
                Console.WriteLine($"{puan}");
            }
  
            //ekrana yazdırmak için aşağıdaki string.Join yapısı da kullanılabilir                                   
            string listeMetin=string.Join("\n", puanlar);
            Console.WriteLine(listeMetin);
            Console.ReadKey();

        }  
```
  
### Örnek-3 ###
> Aşağıda verilenleri sırasıyla uygulayarak uygulamayı tamamlayınız.
    
    - İçerisinde AdSoyad ve Yas property'si bulunan Ogrenci adında bir class oluşturunuz.
    - içerisinde Ogrenci nesnelerinin bulubabileceği ogrenciler adında bir List tanımlayın.
    - ogrenciler List'ine 5 tane Ogrenci nesnesi ekleyiniz.
    - ogrenciler List'i içerisindeki Ogrenci nesnelerini foreach döngüsü ile ekrana yazdırınız.
### Aşağıdaki Özellik ve metotlar ArrayList'lerde kullanıldığı gibi List yapılarında da aynı şekilde kullanılırlar ###
  
 |Özellik/Metot Adı|Açıklama| Örnek Kullanim|
|---------|---------|---------|
|Count Özelliği |listedeki eleman sayısını verir. | listeAdi.Count |
|Add()|Listenin sonuna tek bir eleman ekler| hayvanlar.Add("Kedi") |
|AddRange()|Başka bir koleksiyon içindeki tüm elemanları liste sonuna ekler | hayvanlar.AddRange(digerListe) |
|Insert()|Elemanı Listenin istenilen sirasına ekler | hayvanlar.Insert(3,"Koyun"); |
|InsertRange()|Başka bir koleksiyon içindeki tüm elemanları Listenin istenilen sirasına ekler |  hayvanlar.InsertRange(3,digerListe); |
|Remove()|Elemanı Listeden siler | hayvanlar.Remove("Koyun"); |
|RemoveRange()|Başka bir koleksiyon içindeki tüm elemanları Listeden siler |  hayvanlar.RemoveRange(digerListe); |
|RemoveAt()|Index numarası verilen elemanı listeden siler|  hayvanlar.RemoveAt(3); |
| Clear()|Listenin tüm elemanlarını  temizler|  hayvanlar.Clear()|
| Sort()|Listedeki elemanları  sıralar.|  hayvanlar1.Sort( |
| Reverse()|Listeyi ters çevirir |  hayvanlar.Reverse() |
| CopyTo()|Listedeki tüm elemanları bir diziye kopyalar |  hayvanlar.CopyTo(Dizi) |  
| Contains()|Herhangi bir elemanın listede bulunup bulunmadığını test eder. |  hayvanlar.Contains("Kedi") |   
| IndexOf|verilen elemanı arar. Bulursa index değerini verir, bulamazsa -1 döndürür | hayvanlar.IndexOf("Kedi") |
  
 
 ### List koleksiyonlarına özel metotlar ###
 > Aşağıdaki metotlar verilen lambda ifadesini List'deki her bir eleman için çalıştırırlar.
  
 Not: [Lambda İfadelerinin Kullanımına Linkden Ulaşabilirsiniz.. ( "=>" Lambda operatörü )](https://github.com/sahinmansuroglu/NtpDersi/blob/main/7_Hafta_Ders_4.md) 
  
 |Özellik/Metot Adı|Açıklama| Örnek Kullanim|
 |---------|---------|---------|
|ForEach() | Lambda ifadesini her bir eleman için çalıştırır| listeAdi.ForEach( n => { Console.WriteLine(n); } ) |
|Exists() | Lambda ifadesine Göre uygun elemanın olup olmadığını test eder| sayilar.Exists( n => n > 15 )|
|Find() | Lambda ifadesine Göre uygun ilk elemanın kendisini verir| sayilar.Find( n => n > 15 )| 
|FindIndex() | Lambda ifadesine Göre uygun ilk elemanın index no'sunu verir| sayilar.FindIndex( n => n > 15 )| 
|FindLast() | Lambda ifadesine Göre uygun son elemanın kendisini verir| sayilar.FindLast( n => n > 15 )| 
|FindLastIndex() | Lambda ifadesine Göre uygun son elemanın index no'sunu verir| sayilar.FindLastIndex( n => n > 15 )| 
|FindAll() | Lambda ifadesine Göre uygun tüm elemanların listesini verir| sayilar.FindAll( n => n > 15 )| 

  ### Örnek-4 ###
> Aşağıda verilenleri sırasıyla uygulayarak uygulamayı tamamlayınız.
  
  - Int tipinde sayilar, tekSayilar, ciftSayilar adında üç tane List tanımlayın
  - Random class'ını kullanarak sayilar List'ine 20 adet 0-100 arası sayı ekleyiniz.
  - sayilar List'indeki tek sayıları tekSayilar List'ine ekletiniz.
  - sayilar List'indeki çift sayıları ciftSayilar List'ine ekletiniz.
  - sayilar, tekSayilar ve ciftSayilar List'indeki elemanları ayrı ayrı yan yana yazdırınız.
  
**Çözüm**  
  
```csharp  
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                sayilar.Add(random.Next(0, 100));
            }
            List<int> tekSayilar = sayilar.FindAll(n => n % 2 == 1);
            List<int> ciftSayilar = sayilar.FindAll(n => n % 2 == 0);

            listeyiEkranaYazdir(sayilar, "Tüm Sayılar");
            listeyiEkranaYazdir(tekSayilar, "Listedeki Tek Sayılar");
            listeyiEkranaYazdir(ciftSayilar, "Listedeki Çift Sayılar");
            Console.ResetColor();
        }
       static void listeyiEkranaYazdir(List<int> liste,string baslik)
        {
           
         
            Console.WriteLine(baslik);
            foreach (var eleman in liste)
            {
                Console.Write($"{eleman} ");
            }
            Console.WriteLine("");
        }

    }
 ``` 
  
  
  ### Örnek-5 ###
> Aşağıda verilenleri sırasıyla uygulayarak uygulamayı tamamlayınız.
    
  - İçerisinde AdSoyad, DogumYeri ve  Yas property'si bulunan Ogrenci adında bir class oluşturunuz.
  - ogrenciler List'ine 5 tane Ogrenci nesnesi ekleyiniz.
  - Sonsuz while döngüsü içerisinde kullanıcıdan AdSoyad bilgisi alınız
    - Eğer listede girilen AdSoyad'a ait bir öğrenci varsa Yas ve DogumYeri bilgisini de ekrana yazdırınız.
    - Eğer listede girilen AdSoyad'a ait bir öğrenci yoksa bir uyarı mesajını ekrana yazdırınız.
    - AdSoyad boş geçilirse döngü kırılarak program sonlansın.

  
  ### Örnek-6 ###
> Aşağıda verilenleri sırasıyla uygulayarak uygulamayı tamamlayınız.

  - Aşağıda verilenlere göre Ogrenci Adında bir class oluşturunuz.
     - OkulNo, Ad, Soyad adında property olacak
     - puanlar adında ve  içinde istenilen sayıda puan bulunabilecek bir dizi olacak
     - tüm propertylerin değerleri kurucu metot ile verilecek. (Puanlar kurucu metoda dizi olarak gönderilecek)
     - Ortalama ve Durum adında readOnly Property olacak
     - ToString() override edilerek öğrencinin tüm bilgileri yan yana metin haline getirilecek
  - ogrenciler list'inin tüm elemanları ekrana yazdırılacak

  ### Örnek-7 ###
> Aşağıda verilenleri  Örnek-6' da oluşturduğunuz ogrenciler listesini kullanarak yapınız
  
  - kalanOgrenciler adında list tanımlayın ve içerisine ogrenciler listesindeki ortalaması 50'ni altında olan öğrencileri ekleyiniz
  - basariliOgrenciler adında list tanımlayın ve içerisine ogrenciler listesindeki ortalaması 50'den büyük veya eşit  öğrencileri ekleyiniz
 
