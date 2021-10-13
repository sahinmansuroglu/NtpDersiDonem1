## Sınıf Üyeleri ##

> Sınıf içerisinde tanımlanmış alan (field, attribute) ve metotlara sınıf üyeleri denir. 

> Aşağıdaki Örnekte Araba sınıf'ının üyeleri olarak "renk" alanı ve "bilgileriEkranaYaz()" metodu bulunmaktadır.
```csharp
 class Araba
 {
      string renk="mavi";    // Alan (field)
      void bilgileriEkranaYaz() // Metot
      {
          Console.WriteLine($"Renk:{renk} ");
      }
 }
```
> Yukarıdaki sınıftan nesne oluşturan Uygulama aşağıdadir.

```csharp
class Araba
{
    string renk = "mavi";    // Alan (field)
    void bilgileriEkranaYaz() // Metot
    {
        Console.WriteLine($"Renk:{renk} ");
    }

    static void Main(string[] args)
    {
        Araba arabaNesne1 = new Araba(); // Araba sınıfından arabaNesne1 nesnesi oluşturulmustur.
        arabaNesne1.bilgileriEkranaYaz();

        Console.ReadKey();

    }
}
```
**Örnek** 
> Aşağadaki örnekte olduğu gibi sınıf alanları tanımlama anında boş bırakıp nesne oluşturduktan sonra da değer ataması yapabiliriz.

```csharp
 class Araba
 {
      string renk;    // alan (field)
      void bilgileriEkranaYaz() // Metot
      {
          Console.WriteLine($"Renk:{renk} ");
      }
 }
```

```csharp
class Araba
{
    string renk;
    int hiz;
    void bilgileriEkranaYaz()
    {
        Console.WriteLine($"Renk:{renk}");
        Console.WriteLine($"Hız:{hiz}");
    }
    static void Main(string [] args)
    {
        Araba nesne1 = new Araba();
        nesne1.renk = "Beyaz";
        nesne1.hiz = 170;
        nesne1.bilgileriEkranaYaz();
        Console.ReadKey();
    }
}

```
**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/136350459-8a7b1ad7-eed1-439b-8acf-90e050de1a2e.png)


> Yukarıdaki örnekte Araba sınıfının renk ve hız alanı değerleri varsayılan olarak boş bırakılmıştır. 
> Araba sınıfından nesne1 nesnesi oluşturulduktan sonra renk ve hız alanlarının değerleri değiştirilmiştir.

**Örnek**
> İstersek aşağıdaki uygulamada olduğu gibi renk ve hız bilgilerini kullanıcıdan da alabiliriz.

```csharp
class Araba
{
    string renk;
    int hiz;
    void bilgileriEkranaYaz()
    {
        Console.WriteLine($"Renk:{renk}");
        Console.WriteLine($"Hız:{hiz}");
    }
    static void Main(string [] args)
    {


        Araba nesne1 = new Araba();
        Console.Write("Arabanın rengini giriniz:");
        nesne1.renk = Console.ReadLine();
        Console.Write("Arabanın hızını giriniz:");
        nesne1.hiz =Convert.ToInt32( Console.ReadLine());
        nesne1.bilgileriEkranaYaz();
        Console.ReadKey();

    }
```
**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/136349987-b68ac841-5459-4aaa-acde-543e150afb76.png)



**Örnek**
> Aşağıdaki örnekte sınıf içerisinde alanlar (field) ve  metotlar bulunmaktadır. bilgileriEkranaYaz() metodu oluşturulan nesnenin bilgilerini ekrana yazmaktadır.

```csharp
 class Araba
{
    string marka;
    short yili;
    double depoKapasitesi;
    double ortalamaTuketim;
    string yakitTuru;

    void bilgileriEkranaYaz()
    {
        Console.WriteLine($"Marka:{marka} ");
        Console.WriteLine($"Yılı:{yili} ");
        Console.WriteLine($"Depo Kapasitesi:{depoKapasitesi} ");
        Console.WriteLine($"Ortalama Tüketim:{ortalamaTuketim} ");
        Console.WriteLine($"Yakıt türü:{yakitTuru} ");
    }

    static void Main(string [] paramatreler)
    {
        Araba arabaNesne1 = new Araba();
        arabaNesne1.marka = "BMW";
        arabaNesne1.yili = 2010;
        arabaNesne1.depoKapasitesi = 50;
        arabaNesne1.ortalamaTuketim = 8.0;
        arabaNesne1.yakitTuru = "Benzin";

        Console.WriteLine("----- Araba Nesnesi - 1 -----");
        arabaNesne1.bilgileriEkranaYaz();

        Araba arabaNesne2 = new Araba();
        arabaNesne2.marka = "AUDI";
        arabaNesne2.yili = 2010;
        arabaNesne2.depoKapasitesi = 50;
        arabaNesne2.ortalamaTuketim = 6.0;
        arabaNesne2.yakitTuru = "Dizel";

        Console.WriteLine("----- Araba Nesnesi - 2 -----");
        arabaNesne2.bilgileriEkranaYaz();

        Araba arabaNesne3 = new Araba();
        arabaNesne3.marka = "JAGUAR";
        arabaNesne3.yili = 2010;
        arabaNesne3.depoKapasitesi = 50;
        arabaNesne3.ortalamaTuketim = 8.0;
        arabaNesne3.yakitTuru = "Benzin";

        Console.WriteLine("----- Araba Nesnesi - 3 -----");
        arabaNesne3.bilgileriEkranaYaz();

        Console.ReadKey();
    }
  
}
```
