## Çok Biçimlilik (Polymorphism) ##

Polimorfizm, çok biçimlilik anlamına gelmektedir. Polimorfizm, nesne yönelimli programlama dilinin en önemli kavramlarından biridir. Nesne yönelimli programlamada polimorfizmin en yaygın kullanımı, bir alt sınıf nesnesine başvurmak için bir üst sınıf başvurusu (referansı) kullanıldığında ortaya çıkar. Bu tür durumlarda tanımlanan üst sınıf referansı farklı alt(child) sınıf nesnesini  işaret edebileceği için aynı türdeki başvurunun farklı şekillerde çalışabilmesine olanak sağlayacaktır.

**Örnek-1**
> Aşağıdaki  örnekte Ogrenci ve Ogretmen sınıfınının Insan sınıfından türetildiğini varsayarsak  oluşturulan insan1, insan2 ve insan3 nesne başvurularının farklı tipte nesneler göstermesi Polimorfizm’e örnektir.

```csharp
    Insan insan1=new Insan();
    Insan insan2=new Ogrenci();
    Insan insan3=new Ogretmen();
````


**Örnek-2**
> Aşağıdaki verilenlere Göre Insan Sınıfını türetiniz ve  ardından Insan Sınıfından Ogretmen ve Ogrenci Sınıfını türetiniz. Son olarak Insan, Ogretmen ve Ogrenci sınıflarından nesne oluşturarak bilgilerini ekrana yazdırınız.

**Not1 :** Insan sınıfındaki bilgileriEkranaYaz metodu virtual tanımlanacak olup türetilmiş sınıflarda bu method override edilecektir.
**Not2 :**  Üst sınıfın metodlarına ulaşmak için base keyword'ünü kullanabilirsiniz.
| Sınıf Adı     | Propertyler  | Metodlar|
|:-------------------------:|:-------------------------:|:-------------------------:|
|Insan|Ad, Soyad, DogumTarihi| yasHesapla(), bilgileriEkranaYAz|
|Ogretmen|Ad, Soyad, DogumTarihi, Brans| yasHesapla(), bilgileriEkranaYaz|
|Ogrenci|Ad, Soyad, DogumTarihi, SubeAdi| yasHesapla(), bilgileriEkranaYaz|

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Insan insan1= new Insan { Ad = "Emre", Soyad = "ER", DogumTarih = 1995 };
        insan1.bilgileriEkranaYaz();
        Console.WriteLine("---------------");
        Insan insan2 = new Ogretmen { Ad = "Şahin", Soyad = "MansurOğlu", DogumTarih = 1982, brans = "Bilişim Teknolojileri" };
        insan2.bilgileriEkranaYaz();
        Console.WriteLine("---------------");
        Insan insan3 = new Ogrenci { Ad = "KadirCan", Soyad = "Kulu", DogumTarih = 2004, Sube = "11ATP" };
        insan3.bilgileriEkranaYaz();
        Console.ReadKey();

    }
}
class Insan
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public short DogumTarih { get; set; }

    public int yasHesapla()
    {
        return DateTime.Now.Year - DogumTarih;
    }
    public virtual void bilgileriEkranaYaz()
    {
        Console.WriteLine($"Adınız:{Ad} Soyadınız:{Soyad}");
        Console.WriteLine($"Doğum Tarihi:{DogumTarih} Yaşınız:{yasHesapla()}");
    }
}
class Ogretmen : Insan
{
    public string brans { get; set; }

   
    public override void bilgileriEkranaYaz()
    {
        Console.WriteLine("***Öğretmen Bilgileri***");
        base.bilgileriEkranaYaz();
        Console.WriteLine($"Branşınız:{brans}");
    }
}

class Ogrenci : Insan
{
    public string Sube { get; set; }

    public override void bilgileriEkranaYaz()
    {
        Console.WriteLine("***Öğrenci Bilgileri***");
        base.bilgileriEkranaYaz();
        Console.WriteLine($"Sube:{Sube}");
    }
}

```

**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/144990196-3173e168-bb27-4839-a782-e4c26e2fd716.png)
