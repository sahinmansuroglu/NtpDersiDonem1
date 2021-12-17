## Enums (Numaralandırmalar) ##
> Bir enum (enumerations kelimesinin kısaltması) sadece int tipindeki sabitlerden oluşan özel bir sınıftır. 
> Bu değerler sadece okunabilirdir ve değiştirilemez. Enum genellikle programların okunmasını kolaylaştırmak için kullanılır.
> Bir numaralandırma oluşturabilmek için enum anahtar kelimesi ve değerleri birbirinden ayırmak için de ", (virgül)" karakteri kullanılır.

**Örnek-1**
```csharp
enum puanlar
    {
        Bos,
        Basarisiz,
        Gecer,
        Orta,
        Iyi,
        Pekiyi
    };
    class Program
    {
        static void Main(string[] args)
        {
            puanlar puan1 = (puanlar) 1;
            puanlar puan2 = puanlar.Orta;
            Console.WriteLine($"{(int)puan1}"); // Ekrana 1 Yazar
            Console.WriteLine($"{puan1}"); // Ekrana Basarisiz Yazar
            Console.WriteLine($"{(int) puan2}"); // Ekrana 3 Yazar
            Console.WriteLine($"{puan2}"); // Ekrana Orta Yazar
            Console.ReadKey();
        }
    }
    
```

**Örnek-2**

```csharp
 enum puanlar { 
         Bos,
         Basarisiz,
         Gecer,
         Orta,
         Iyi,
         Pekiyi
    };


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Puanınız:{(int)puanlar.Basarisiz}   -    {puanlar.Basarisiz}");
            Console.WriteLine($"Puanınız:{(int)puanlar.Orta}    -     {puanlar.Orta}");
            Console.WriteLine($"Puanınız:{(int)puanlar.Iyi}    -     {puanlar.Iyi}");
            Console.ReadKey();
        }
    }
```

> enum içindeki değerler 0’dan (sıfır) başlayarak birer birer artar. İstenirse farklı tam sayı değerleri de 
verilebilir. 

```csharp
enum Kategoriler
{
 Bilgisayar = 3,
 Mobilya = 10,
 Kırtasiye = 7,
 Hırdavat, // 8
 Otomobil // 9
}
```

**Örnek-3**
> Klavyeden girilen 1-7 arası rakama göre gün adını ekrana yazan uygulamayı Enum yapısını kullanarak tasarlayınız.

```csharp
 enum Gunler { 
         Pazartesi=1,
         Sali,
         Çarşamba,
         Perşembe,
         Cuma,
         Cumartesi,
         Pazar
    };


    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1 ile 7 arası rakam giriniz:");
            int gunSira = Convert.ToInt32(Console.ReadLine());
            Gunler seciliGun =(Gunler) gunSira;

            Console.WriteLine($"Seçilen Gün:{seciliGun}");
           
            Console.ReadKey();
        }
    }

```

**Program Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/146364037-a3437d3b-09fb-41d9-81f8-a27ac4813da3.png)
