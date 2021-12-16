## Enums (Numaralandırmalar) ##
> Bir enum (enumerations kelimesinin kısaltması) sadece int tipindeki sabitlerden oluşan özel bir sınıftır. 
> Bu değerler sadece okunabilirdir ve değiştirilemez. Enum genellikle programların okunmasını kolaylaştırmak için kullanılır.
> Bir numaralandırma oluşturabilmek için enum anahtar kelimesi ve değerleri birbirinden ayırmak için , (virgül) karakteri kullanılır.

**Örnek-1**

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

**Örnek-2**
> Klavyeden girilen 1-7 arası rakama göre gün adını ekrana yazan uygulamayı Enum yapısını kullanarak tasarlayınız.

```csharp