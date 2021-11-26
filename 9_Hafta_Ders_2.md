## Metotları değer ile çağırma (call by value) ## 
    
> Bir metod değer tipinde bir parametre gönderilerek çağrıldığında gönderilen parametrenin metod içerisinde bir kopyası oluşturulur ve bu kopya üzerinde değişiklik yapılır. Ancak metodun çağrıldığı yerde gönderilen parametre herhangi bir değişikliğe uğramaz. Bu kullanıma metotları değer ile çağırma adını veriyoruz. 

**Not: Değer türlerinde tanımlanmış parametreler bir metoda geçirilirken arkaplanda  her zaman  kopyası oluşturulurak geçirilir. İstisna olarak string veri tipi referans veri tipi olmasına rağmen bu tipte metoda geçirilirken arka planda kopyası oluşturularak geçirilir.**  

**Örnek - 1**
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


**Örnek - 2**
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

 
