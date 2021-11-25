## Metotları değer ile çağırma (call by value) ## 
    
> Bir metod değer tipinde bir parametre gönderilerek çağrıldığında gönderilen parametrenin metod içerisinde bir kopyası oluşturulur ve bu kopya üzerinde değişiklik yapılır. Ancak metodun çağrıldığı yerde gönderilen parametre herhangi bir değişikliğe uğramaz. Bu kullanıma metotları değer ile çağırma adını veriyoruz. 

**Not: Değer türlerinde tanımlanmış parametreler bir metoda geçirilirken arkaplanda  her zaman  kopyası oluşturulurak geçirilir. İstisna olarak string veri tipi referans veri tipi olmasına rağmen bu tipte metoda geçirilirken araka planda kopyası oluşturularak geçirilir. **  

**Örnek**
```csharp
  class Program
    {
        static void Main(string[] args)
        {
            int sayi = 15;
            Console.WriteLine($"[Ana Program] Sayi:{sayi}");
            arttir(sayi);
            Console.WriteLine($"[Ana Program] Sayi:{sayi}");
            Console.ReadKey();
        }
        public static void arttir(int sayi)
        {
            sayi++;
           Console.WriteLine($"[Metod içerisinde] Sayi:{sayi}");
        }

    }
```
> Yukarıdaki kodu ve aşağıdaki çıktısını incelersek arttir metodu int tipindeki sayı parametresi ile çağrılmıştır. Ancak metod içerisinde ana programdaki sayi parametresinin kopyası oluşturulup o sayı arttırıldığı için ana programdaki sayi değişkeni herhangi bir değişime uğramamıştır. 

**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/143385886-8b5b794f-9e32-4438-b730-22fa2a80ddb8.png)


**Örnek**
```csharp
  class Program
    {
         static void Main(string[] args)
        {
            string ad = "Veli";
            Console.WriteLine($"[Ana Program] ad:{ad}");
            adDegistir(ad);
            Console.WriteLine($"[Ana Program] ad:{ad}");
            Console.ReadKey();
        }
        public static void adDegistir(string ad)
        {
            ad = "Ahmet";
            Console.WriteLine($"[Metod içerisinde] Ad:{ad}");
        }

    }
```
> Yukarıdaki kodu ve aşağıdaki çıktısını incelersek adDegistir metodu string tipindeki ad parametresi ile çağrılmıştır. Ancak metod içerisinde ana programdaki ad parametresinin kopyası oluşturulup o ad değişkeninin içeriği değiştirildiği için ana programdaki ad değişkeni herhangi bir değişime uğramamıştır. 

**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/143400976-03c04f17-7c60-4556-8328-abdf9aa33c27.png)

    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr1;
            ogr1 = new Ogrenci();
            ogr1.adSoyad = "Ali Veli";
            ogr1.n1 = 34;
            ogr1.n2 = 60;
            ogr1.n3 = 80;
            ogrencininOrtalamasiniHesapla(ogr1);
            durumHesapla(ogr1);
            Console.WriteLine($"Ortalama:{ogr1.ort}");
            Console.WriteLine($"Durum:{ogr1.durum}");
            Console.ReadKey();
        }
        public static void ogrencininOrtalamasiniHesapla(Ogrenci ogrRef)
        {
            ogrRef.ort = (ogrRef.n1 + ogrRef.n2 + ogrRef.n3) / 3.0;
        }
        public static void durumHesapla(Ogrenci ogr)
        {
            if (ogr.ort < 50)
            {
                ogr.durum = "Kaldınız..";
            }
            else
            {
                ogr.durum = "Geçtiniz..";
            }
        }

    }
    class Ogrenci
    {
        public string adSoyad;
        public int n1;
        public int n2;
        public int n3;
        public double ort;
        public string durum;

    }


## Metotları değer ile çağırma (call by value), referans ile çağırma(call by reference) ## 
