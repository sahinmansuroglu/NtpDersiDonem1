## Metot Gölgeleme (Method Shadowing) ##

> C#' da türetilmiş sınıfın içerisinde temel sınıfdaki bir metodu tekrar tanımladığınızda özel bir durum oluşur. Bu durumda derleyici bunu bilerek yapıp yapmadığımız konusunda bizi uyarır. Bunu bilerek yaptığımızı derleyiciye belirtmek için temel sınıftaki metodu gölgelememiz gerekir. Metot gölgeleme yapmak için türetilmiş sınıfta metot tekrar yazılırken **new** anahtar sözcüğü kullanılır.

**Not**: Metot gölgeleme yapabilmek için Temel sınıftaki metot ile türetilmiş sınıftaki metodun aynı imzaya sahip olması gerekir.

| Methot Shadowing Yapılmadan          | Methot Shadowing Yapılarak    |
:-------------------------:|:-------------------------:
|![image](https://user-images.githubusercontent.com/28144917/144388168-04ab5a7d-166f-41f9-89a9-03eab26466e2.png)|![image](https://user-images.githubusercontent.com/28144917/144388258-f733a6ac-1718-4ccf-86ae-03f169d63379.png)|

**Not**: Yukarıdaki ilk resime bakacak olursak metot gölgeleme yapılmadığı için türetilmiş sınıftaki bilgileriEkranaYaz()  metodunun altı çizilerek derleyici tarafından uyarı verilmiştir.

**Örnek-1** 
```csharp
 class Program
    {
        static void Main(string[] args)
        {
            Ogretmen ogretmen1 = new Ogretmen { Ad = "Şahin", Soyad = "MANSUROĞLU", Brans = "Bilişim Teknolojileri" };
            ogretmen1.bilgileriEkranaYaz();
            Console.ReadKey();
        }
    }

    class Insan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public void bilgileriEkranaYaz()
        {
            Console.WriteLine($"Ad Soyad: {Ad} {Soyad}");
        }
    }

    class Ogretmen : Insan
    {
        public string Brans { get; set; }
        public new void bilgileriEkranaYaz()
        {
            base.bilgileriEkranaYaz();
            Console.WriteLine($"OGretmen Ad Soyad: {Ad} {Soyad} Branşı:{Brans}");
        }


    }
```

**Örnek-2**
> Aşağıdaki verilenlere göre Kare sınıfını oluşturunuz. Ardından Kare sınıfından Dikdortgen Sınıfını turetiniz. Son olarak Kare ve Dikdortgen sınıfından birer nesne oluşturup Alanlarını ve Çevrelerini ekrana yazdırınız. (Methot Shadowing uygulayınız)

| Sınıf Adı      | İçinde Bulunacak Property'ler | İçinde Bulunacak Metotlar |
| ----------- | ----------- |----------- |
| Kare      | KenarA     | alan(), cevre() |
| Dikdortgen   | KenarA, KenarB       |alan(), cevre() |

**Örnek-2 Cevap**

```csharp
 class Program
    {
        static void Main(string[] args)
        {
            Kare kare1 = new Kare { KenarA = 3 };
            Console.WriteLine("*****Kare Bilgileri******");
            Console.WriteLine($"Alan:{kare1.alan()} Çevre:{kare1.cevre()} ");

            Dikdortgen dikdortgen1 = new Dikdortgen { KenarA = 4, KenarB = 5 };
            Console.WriteLine("*****Dikdortgen Bilgileri******");
            Console.WriteLine($"Alan:{dikdortgen1.alan()} Çevre:{dikdortgen1.cevre()} ");
            Console.ReadKey();
        }
    }
    class Kare
    {

        public int KenarA { get; set; }
        public int alan()
        {
            return KenarA * KenarA;
        }
        public int cevre()
        {
            return KenarA * 4;
        }
    }
    
    class Dikdortgen : Kare
    {
        public int KenarB { get; set; }
        public new int alan()
        {
            return KenarA * KenarB;
        }
        public new int cevre()
        {
            return (KenarA+KenarB) * 2;
        }
    }
    
   ```
