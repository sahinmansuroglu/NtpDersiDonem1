## Metotlarda ref ve out Kullanımı ## 
> Ref ve out anahtar kelimeleri metodlara değer turunden parametrelerin referansını geçirebilmek için kullanılır. 


**Örnek - 1**
> Aşağıdaki örnekte ref kullanılarak  int tipindeki sayi değişkeninin refereansı(adresi) metoda geçirilmiştir.Bundan dolayı da metot içerisindeki sayının değişimi ana programda da gözlenmiştir.

```csharp
class Program
    {
        static void Main(string[] args)
        {
            int sayi = 15;
            Console.WriteLine($"[Ana Program] Sayi:{sayi}");
            arttir(ref sayi);
            Console.WriteLine($"[Ana Program] Sayi:{sayi}");
            Console.ReadKey();
        }
        public static void arttir(ref int sayi)
        {
            sayi++;
            Console.WriteLine($"[Metod içerisinde] Sayi:{sayi}");
        }


    }
```

**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/143427252-7d9dac94-a9c2-478d-8d64-53ca894807d6.png)

**Örnek-2**

```csharp
 class Program
    {
        static void Main(string[] args)
        {
            string ad = "Veli";
            Console.WriteLine($"[Ana Program] ad:{ad}");
            adDegistir(ref ad);
            Console.WriteLine($"[Ana Program] ad:{ad}");
            Console.ReadKey();
        }
        public static void adDegistir(ref string ad)
        {
            ad = "Ahmet";
            Console.WriteLine($"[Metod içerisinde] Ad:{ad}");
        }


    }
```


**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/143427455-45795af4-366b-4ca5-97ec-e55d2908c4ac.png)
