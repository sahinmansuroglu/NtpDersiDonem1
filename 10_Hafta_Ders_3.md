## Metot Gölgeleme (Method Shadowing) ##






**Örnek** 

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

**Örnek1**
Aşağıdaki verilenlere göre Kare sınıfını oluşturunuz. Ardından Kare sınıfından Dikdortgen Sınıfını turetiniz. Son olarak Kare ve Dikdortgen sınıfından birer nesne oluşturup Alanlarını ve Çevrelerini ekrana yazdırınız. (Methot Shadowing uygulayınız)

| Sınıf Adı      | İçinde Bulunacak Property'ler | İçinde Bulunacak Metotlar |
| ----------- | ----------- |----------- |
| Kare      | KenarA     | alan(), cevre() |
| Dikdortgen   | KenarA, KenarB       |alan(), cevre() |


