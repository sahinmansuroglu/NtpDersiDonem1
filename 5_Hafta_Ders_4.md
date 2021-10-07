## Kurucu Metotlar (Constructor) ##

> Kurucu metotlar bir sınıftan nesne oluşturulma anından çalışan özel metotlardır.
> Kurucu metotlar sınıf ismiyle aynı olmalıdır.
> Kurucu metotlar geriye değer döndürmezler ve aynı zamanda void olarak  da tanımlanmazlar.

**Örnek**
Aşağıdaki örnekte sınıf içerisinde renk özelliğinin değeri tanımlama anında değil kurucu metot içerisinde "Mavi" olarak verilmiştir.

```csharp
class Araba
{
    string renk;
    Araba()
    {
        renk = "Mavi";
        Console.WriteLine("****Yeni bir araba nesnesi oluşturuldu****");
    }
    void bilgileriEkranaYaz() // Metot
    {
        Console.WriteLine($"Renk:{renk} ");
    }

    static void Main(string[] args)
    {
        Araba arabaNesne1 = new Araba();
        arabaNesne1.bilgileriEkranaYaz();
        Console.ReadKey();

    }
}
```

**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/136355635-cba4560f-4345-48cf-972d-a08a90e2061d.png)


