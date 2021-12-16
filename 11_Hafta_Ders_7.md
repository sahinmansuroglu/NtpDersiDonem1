## Enums (Numaralandırmalar) ##
> Bir enum (enumerations kelimesinin kısaltması) sadece int tipindeki sabitlerden oluşan özel bir sınıftır. 
> Bu değerler sadece okunabilirdir ve değiştirilemez. Enum genellikle programların okunmasını kolaylaştırmak için kullanılır.
> Bir numaralandırma oluşturabilmek için enum anahtar kelimesi ve değerleri birbirinden ayırmak için , (virgül) karakteri kullanılır.

**Örnek**

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
