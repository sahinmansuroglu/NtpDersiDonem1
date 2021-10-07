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

