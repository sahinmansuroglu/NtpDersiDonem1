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
  
### Örnek-2  ###
> puanlar adında bir List tanımlayın içerisine 5 tane puan adi ekleyip foreach döngüsü ile ekrana yazdırınız.
  
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
  
 |Özellik/Metot Adı|Açıklama| Örnek Kullanim|
 |---------|---------|---------|
|ForEach() |Verilen Lambda ifadesini her bir eleman için çalıştırır| listeAdi.ForEach( n => { Console.WriteLine(n); } ) |
|Exists() |Verilen Lambda ifadesine Göre uygun elemanın olup olmadığını test eder (true veya false döndürür)| sayilar.Exists( n => n > 15 )|
  
