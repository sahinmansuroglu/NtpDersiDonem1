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

![image](https://user-images.githubusercontent.com/28144917/136355835-492c0206-e4aa-40fb-93f9-d6d9a1eb5aa7.png)


### Kurucu Metoda Parametre Gönderme ###

> Normal metotlarda olduğu gibi kurucu metotlara da parametre gönderebiliriz. Özellikle sınıfların özelliklerine değer ataması yaparken kullanırız

```csharp
class Araba
{
    string renk;

    Araba( string renkParametre) // Kurucu metot dışardan renkParametre adına bir parametre almıştır. bu değer renk özelliğine atanmak için kullanılmıştır.
    {
        renk = renkParametre;
        Console.WriteLine("Yeni bir Nesne oluşturuldu...");
    }

    void bilgileriEkranaYaz()
    {
        Console.WriteLine($"Renk:{renk} ");
    }
    static void Main(string [] args)
    {
        Araba araba1 = new Araba("Kırmızı"); //  Sınıftan nesne oluştururken parantes içinde göreline değerler kurucu metoda gider.
        araba1.bilgileriEkranaYaz();
        Console.ReadKey();
    }
}
```
