## Class ve Dizi Kullanımı ile ilgili Örnek ##

Aşağıda verilenleri sırasıyla uygulayarak projeyi  tanımlayınız

    1. Aşağıda verilenlere göre Ogrenci Adında bir class oluşturunuz.
       - id, ad, Soyad, adında property olacak
       - puanlar adında bir içinde istenilen sayıda puan bulunabilecek bir dizi olacak
       - tüm propertylerin değerleri kurucu metot ile verilecek. (Puanlar kurucu metoda dizi olarak gönderilecek)
       - Ortalama ve Durum adında readOnly Property olacak
       - bilgileriEkranaYaz adında bir metot bulunacak
     2. Ana Programda Ogrenci Nesnelerinden oluşan 5 elemanlı bir dizi tanımlayın.
     3. Dizideki tüm Ogrenci nesnelerinin bilgilerini forach döngüsi ile ekrana yazdırınız.

Not: id değeri Aşağıdaki kod örneği kullanılarak class içerisinde otomatik oluşturulacaktır.

```csharp
    // GUID (Globally Unique IDentifier), bilgisayar yazılımlarında tanımlayıcı olarak kullanılan benzersiz bir referans numarasıdır. 
    Guid guid = Guid.NewGuid();
    string str = guid.ToString("N");
```

