## Sanal Metotlar (Virtual and Override keyword kullanımı) ##

**Ornek-1**
```csharp
 class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            A aNesne = new A();
            aNesne.SinifAdiGoster();
            B bNesne = new B();
            bNesne.SinifAdiGoster();
            Console.ReadKey();
            
        }
    }
    class A
    {
        public virtual void SinifAdiGoster()
        {
            Console.WriteLine("Burası A Sınıfı");
        }
    }
    class B:A
    {
        public override void SinifAdiGoster()
        {
            Console.WriteLine("Burası B Sınıfı");
        }
    }
```

**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/144972733-f0d246e8-9c5c-4495-8e56-a896a2f9b6f8.png)


**Ornek-2**

```csharp
  class Program
    {
        static void Main(string[] args)
        {
            A aNesne1 = new A();
            aNesne1.SinifAdiGoster();
            A aNesne2 = new B();
            aNesne2.SinifAdiGoster();
            A aNesne3 = new C();
            aNesne3.SinifAdiGoster();
            Console.ReadKey();
                        
        }
    }
    class A
    {
        public virtual void SinifAdiGoster()
        {
            Console.WriteLine("Burası A Sınıfı");
        }
    }
    class B:A
    {
        public override void SinifAdiGoster()
        {
            Console.WriteLine("Burası B Sınıfı");
        }
    }

    class C : B
    {
        public override void SinifAdiGoster()
        {
            Console.WriteLine("Burası C Sınıfı");
        }
    }
```

**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/144974908-fd0bb6d8-7be8-4f87-bac4-b79799cf57ca.png)

**Ornek-3**
> Yukarıdaki uygulamada method shadowing (metot gölgeleme) yapılırsa uygulama kodu ve çıktısı aşağıdaki gibi olur

```csharp
  class Program
    {
        static void Main(string[] args)
        {
            A aNesne1 = new A();
            aNesne1.SinifAdiGoster();
            A aNesne2 = new B();
            aNesne2.SinifAdiGoster();
            A aNesne3 = new C();
            aNesne3.SinifAdiGoster();
            Console.ReadKey();
                       
        }
    }
    class A
    {
        public  void SinifAdiGoster()
        {
            Console.WriteLine("Burası A Sınıfı");
        }
    }
    class B:A
    {
        public new void SinifAdiGoster()
        {
            Console.WriteLine("Burası B Sınıfı");
        }
    }

    class C : B
    {
        public new void SinifAdiGoster()
        {
            Console.WriteLine("Burası C Sınıfı");
        }
    }
```

**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/144975536-b36d86de-8eee-4952-8248-49f382cdf4dd.png)


**Ornek-4**

```csharp
 class Program
    {
        static void Main(string[] args)
        {
            Hesaplama hesap1 = new Kare { KenarA = 4 };
            hesap1.AlanHesapla();
            hesap1.CevreHesapla();
            Hesaplama hesap2 = new Dikdortgen { KenarA = 5, KenarB = 3 };
            hesap2.AlanHesapla();
            hesap2.CevreHesapla();
            Console.ReadKey();
        }
     }
    class Hesaplama
    {
        public virtual void AlanHesapla()
        {
            Console.WriteLine("Herhangi Bir Parametre olmadığı için Alan Hesaplanamadı.");
        }
        public virtual void CevreHesapla()
        {
            Console.WriteLine("Herhangi Bir Parametre olmadığı için Çevre Hesaplanamadı.");
        }
    }
    class Kare : Hesaplama
    {
        public int KenarA { get; set; }
        public override void AlanHesapla()
        {
            Console.WriteLine($"Karenin Alanı:{KenarA*KenarA}");
        }
        public override void CevreHesapla()
        {
            Console.WriteLine($"Karenin ÇEvresi:{KenarA * 4}");
        }
    }

    class Dikdortgen : Kare
    {
        public int KenarB { get; set; }
        public override void AlanHesapla()
        {
            Console.WriteLine($"Dikdörtgenini Alanı:{KenarA * KenarB}");
        }
        public override void CevreHesapla()
        {
            Console.WriteLine($"Dikdörtgenini Çevresi:{(KenarA +KenarB) * 2}");
        }
    }
  ```
  
 **Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/144978180-0e0b54ae-4707-46e4-945d-86b7b095d174.png)   


**Örnek-4**
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



**Örnek-5**

> Yukarıdaki uygulamada  oluşturulan nesneleri kullanıcıdan gelen verilerle doldurmak için ana programı aşağıdaki gibi düzenleyebiliriz.

```csharp

 class Program
    {
        static void Main(string[] args)
        {

            Ogretmen ogretmenNesne = new Ogretmen();
            Ogrenci ogrenciNesne = new Ogrenci();
            kullanicidanVeriAl(ogrenciNesne);
            kullanicidanVeriAl(ogretmenNesne);
            ogretmenNesne.bilgileriEkranaYaz();
            ogrenciNesne.bilgileriEkranaYaz();
            Console.ReadKey();
        }
        static void kullanicidanVeriAl(Insan insanNesne) {
            Console.Write("Ad giriniz:");
            insanNesne.Ad = Console.ReadLine();
            Console.Write("Soyad giriniz:");
            insanNesne.Soyad = Console.ReadLine();
            Console.Write("Dogum Tarihi giriniz:");
            insanNesne.DogumTarihi = Convert.ToInt32(Console.ReadLine());
            if (insanNesne is Ogretmen)
            {
                Console.Write("Branşı Giriniz:");
                ((Ogretmen)insanNesne).Brans = Console.ReadLine();
            }

            if (insanNesne is Ogrenci)
            {
                Console.Write("Şubesini Giriniz:");
                ((Ogrenci)insanNesne).BulunduguSube = Console.ReadLine();
            }


        }
    }
   
```
