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

**Not: Ref Kullanımında değişkene başlangıç değeri verme zorunluluğu vardır. Ancak Out kullanılırsa buna gerek yoktur.**

**Örnek**
> Aşağıdaki örnekte ad değişkenin başlangıç değeri atanmadığı için ref ile referansı gönderildiğinde hata alınacaktır. Bu gibi başlangıç değerinin bulunmadığı durumlarda ref yerine out anahtar kelimesi kullanılır.

```csharp
class Program
    {
        static void Main(string[] args)
        {
            string ad ;
            adDegistir(out ad);
            Console.WriteLine($"[Ana Program] ad:{ad}");
            Console.ReadKey();
        }
        public static void adDegistir(out string ad)
        {
            ad = "Ahmet";
            Console.WriteLine($"[Metod içerisinde] Ad:{ad}");
        }


    }
```

**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/143429363-360acf3c-24f2-4021-885f-519a02e47ac6.png)


**Örnek**
> Parametre olarak aldığı iki sayının değerleri değiştiren program.

```csharp
 class Program
    {
        static void Main(string[] args)
        {
            int s1 = 45;
            int s2 = 50;
            Console.WriteLine($" [ana Program] s1:{s1}   s2:{s2}");

            yerDegistir(ref s1,ref  s2);

            Console.WriteLine($" [ana Program] s1:{s1}   s2:{s2}");
            Console.ReadKey();
        }
        

        static void yerDegistir(ref int s1, ref int s2)
        {
            int gecici;
            gecici = s1;
            s1 = s2;
            s2 = gecici;

            Console.WriteLine($" [Metod içerisi] s1:{s1}   s2:{s2}");
        }


    }
    
 ```
 
 **Ekran Çıktısı**
 
 ![image](https://user-images.githubusercontent.com/28144917/143430448-9c113834-b8f6-45f4-ac0b-1041ad59a0ee.png)
