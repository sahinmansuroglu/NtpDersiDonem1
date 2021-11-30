## Kalıtım (Inheritance) ##

> C# da bir sınıfın metot ve özelliklerini başka bir sınıftan miras olarak alıp kullanmak mümkündür. Bu kullanıma kalıtım denilmektedir.
> Kalıtım yaklaşımını iki kategoriye ayırabiliriz.

  **1. Türetilmiş Sınıf (Derived Class veya Child Class):** Metotları ve özellikleri **miras alan** sınıf
  
  **2. Temel Sınıf (Base Class veya Parent Class):** Metotları ve özellikleri **miras alınan** sınıf
  

> Bir sınıftan miras almak için ":" sembolü kullanılır

### Örnek-1 ###
>Aşağıdaki örnekde hayvan sınıfından kedi sınıfı türetilmiştir. Bu örnekte kedi sınıfı türetilen sınıf, hayvan sınıfı da temel sınıftır. (Her bir kedi aynı zamanda hayvandır.)

```csharp
class Hayvan
{
    public void yemekYe()
    {
        Console.WriteLine("Yemek yiyor");
    }
}
class Kedi:Hayvan
{
    public void miyavla()
    {
        Console.WriteLine("Kedi Miyavlıyor.");
    }

}
class Program
{
    static void Main(string[] args)
    {
        Kedi kedi1 = new Kedi();
        kedi1.yemekYe();
        kedi1.miyavla();
        Console.ReadKey();
    }
}

```

**Not:** Türetilen sınıf temel sınıfın üyelerine  erişebiliyorken, temel sınıf türetilen sınıfın üyelerine erişemez.

### Örnek-2 ###
> Aşağıdaki örnekte kare sınıfından dikdörtgen sınıfı türetilmiştir.


```csharp
 class Program
    {
        static void Main(string[] args)
        {
            // Aşağıdaki şekilde de nesne oluşturup property'lerine değer ataması yapılabilir.
            // Dikdortgen dikdortgen1 = new Dikdortgen{ aKenar = 45, bKenar = 60};

            Dikdortgen dikdortgen1 = new Dikdortgen();
            dikdortgen1.aKenar = 45;
            dikdortgen1.bKenar = 60;

            Console.WriteLine($"Alan:{dikdortgen1.alan()}");
            Console.ReadKey();

        }
    }
    class Kare
    {
        public int aKenar { get; set; }

    }

    class Dikdortgen : Kare
    {
        public int bKenar { get; set; }

        public int alan()
        {
            return aKenar * bKenar;
        }
    }

```

### Örnek-3 ###
> Aşağıdaki verilenlere göre ilk olarak Insan sınıfını oluşturunuz ardından Insan sınıfından Ogretmen ve Ogrenci sınıfını türeterek bilgilerini ekrana yazdırınız.

1. Insan sınıfında Ad, Soyad özellikleri bulunacak
2. Ogretmen sınıfı Insan sınıfından türetilecek ve ek olarak Brans özelligi ve bilgileriEkranaYaz metodu bulunacak
3. Ogrenci sınıfı Insan sınıfından türetilecek ve ek olarak BulunduguSube özelligi ve bilgileriEkranaYaz metodu bulunacak

```csharp
  class Program
    {
        static void Main(string[] args)
        {
            Ogretmen ogretmen1 = new Ogretmen { Ad = "Arda", Soyad = "AR", Brans = "Matematik" };
            Ogrenci ogrenci1 = new Ogrenci { Ad = "Erhan", Soyad = "KAÇAR", BulunduguSube = "11ATBA" };
            ogretmen1.bilgileriEkranaYaz();
            ogrenci1.bilgileriEkranaYaz();
            Console.ReadKey();

        }
    }
    class Insan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }

    class Ogretmen : Insan
    {
        public string Brans { get; set; }
        public void bilgileriEkranaYaz()
        {

            Console.WriteLine($"{Ad} {Soyad} {Brans}");
        }
    }

    class Ogrenci : Insan
    {
        public string BulunduguSube { get; set; }
        public void bilgileriEkranaYaz()
        {
            Console.WriteLine($"{Ad} {Soyad} {BulunduguSube}");
        }
    }
```

**Not:** C# programlama dilinde bir sınıf sadece bir sınıftan türetilebilir. Ancak Burada tek bir istisna vardır. Object sınıfı tüm sınıfların üst sınıfıdır. Yani tüm sınıflar object sınıfından türetilmiştir.

### Örnek-4 ###
> Aşağıdaki örneği incelersek Kare sınıfında herhangi bir özellik ve metot olmamasına rağmen yeniKare nesnesinde dört tane metot gözükmektedir. Nedeni ise arka planda örtülü olarak Kare sınıfı Object sınıfından türetilmiştir ve bu dört metot object sınıfında miras yoluyla alınmıştır.

![image](https://user-images.githubusercontent.com/28144917/143864036-20ceb9cc-8e12-43df-9cec-f61eaeb7bd06.png)

### Örnek-5 ###
> Aşağıdaki örnekte Kare sınıfında ToString() metodu olmamasına rağmen Kare sınıfı örtülü olarak object sınıfında türetildiğinden kalıtım yoluyla alındı. Ve Çıktısı da varsayılan olarak sınıfın adıdırç

```csharp
class Kare
{
   
}

class Program
{
    static void Main(string[] args)
    {
        Kare kare1 = new Kare();
        Console.WriteLine(kare1.ToString());
     
    }
}
```


### Örnek-5 ###

> Yukarıdaki örnekte istersek aşağıdaki gibi kendi toString metodumuzu da yazabiliriz. 

```csharp
class Kare
    {
        public int AKenar { get; set; }
        public string ToString()
        {
            return $"Kenar uzunluğu {AKenar} olan bir Kare Nesnesi";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Kare kare1 = new Kare { AKenar = 34 };
            Console.WriteLine(kare1.ToString());
            Console.ReadKey();
        }
    }
 ```   
