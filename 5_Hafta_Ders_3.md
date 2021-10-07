## Sınıf Üyeleri ##

> Sınıf içerisinde tanımlanmış özelliklere ve metotlara sınıf üyeleri denir. 

> Aşağıdaki Örnekte Araba sınıf'ının üyeleri arasında "renk" özelliği ve "bilgileriEkranaYaz()" metodu bulunmaktadır.
```csharp
 class Araba
 {
      string renk="mavi";    // Özellik (field)
      void bilgileriEkranaYaz() // Metot
      {
          Console.WriteLine($"Renk:{renk} ");
      }
 }
```


**Örnek**
> Aşağıdaki örnekte sınıf içerisinde özellikler (field) ve  metotlar bulunmaktadır. bilgileriEkranaYaz() butonu oluşturulan nesnenin bilgilerini ekrana yazmaktadır.

```csharp
 class Araba
{
    string marka = "BMW";
    short yili = 2010;
    double depoKapasitesi = 50.0;
    double ortalamaTuketim = 8.0;
    string yakitTuru = "Benzin";

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
        
        Console.WriteLine("----- Araba Nesnesi - 1 -----");
        arabaNesne1.bilgileriEkranaYaz();

        Araba ArabaNesne2 = new Araba();
        ArabaNesne2.marka = "AUDI";
        ArabaNesne2.yili = 2010;
        ArabaNesne2.depoKapasitesi = 50;
        ArabaNesne2.ortalamaTuketim = 6.0;
        ArabaNesne2.yakitTuru = "Dizel";

        Console.WriteLine("----- Araba Nesnesi - 2 -----");
        ArabaNesne2.bilgileriEkranaYaz();

        Araba ArabaNesne3 = new Araba();
        ArabaNesne3.marka = "JAGUAR";
        ArabaNesne3.yili = 2010;
        ArabaNesne3.depoKapasitesi = 50;
        ArabaNesne3.ortalamaTuketim = 8.0;
        ArabaNesne3.yakitTuru = "Benzin";

        Console.WriteLine("----- Araba Nesnesi - 3 -----");
        ArabaNesne3.bilgileriEkranaYaz();

        Console.ReadKey();
    }
  
}
```
**Örnek** 
> Aşağadaki örnekte olduğu gibi sınıf özelliklerini tanımlama anında boş bırakıp daha sonra nesne oluşturduktan sonra da değer ataması yapabiliriz.


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


> Yukarıdaki örnekte Araba sınıfının renk ve hız özellikleri varsayılan olarak boş bırakılmıştır. 
> Araba sınıfından nesne1 nesnesi oluşturulduktan sonra renk ve hız özellikleri değiştirilmiştir.

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

