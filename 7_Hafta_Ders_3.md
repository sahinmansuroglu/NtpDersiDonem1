## Metotların Aşırı Yüklenmesi ##
> Her bir metodun kendine özel imza bilgileri bulunmaktadır 
> Bu imza Bilgilerini;
   1. Metot Adı 
   2. Parametre Tipi
   3. Parametre Sayısı 
 oluşturmaktadır.

> Aynı imza bilgisine sahip birden fazla metot tanımlanamaz. Ancak  bu 3 bilgiden biri değiştirilerek farklı metotlar tanımlanabilir. Eğer Metot adı aynı iken Parametre tipi ve/veya
> sayısı farklı metotlar tanımlanırsa buna Metotların aşırı yüklenmesi denir.

### Örnek: ###
> Aşağıdaki örneği inceleyecek olursak farklı sayıdaki tip ve parametreli 4 tane  topla isminde methot tanımlanmıştır. Aynı isimde birden fazla topla methodu bulunduğundan topla methodu aşırı yüklenmiştir.
```csharp
using System;

class Islem
{
    public int topla(int s1,int s2)
    {
        return s1 + s2;
    }
    public double topla(double s1, double s2)
    {
        return s1 + s2;
    }
    public int topla(int s1, int s2, int s3)
    {
        return s1 + s2 + s3;
    }
    public double topla(double s1, double s2, double s3)
    {
        return s1 + s2 + s3;
    }

}


class program
{
    static void Main(string[] args)
    {
        Islem nesne = new Islem();
        
        Console.WriteLine($" Sonuç:{ nesne.topla(25, 95) } \t (nesne.topla(25,95))  ");
        Console.WriteLine($" Sonuç:{ nesne.topla(25.2, 95.6) } \t (nesne.topla(25.2, 95.6)) ");
        Console.WriteLine($" Sonuç:{ nesne.topla(90, 25, 95) } \t (nesne.topla(90, 25, 95)) ");
        Console.WriteLine($" Sonuç:{ nesne.topla(90.1, 25.2, 95.3) } \t (nesne.topla(90.1, 25.2, 95.3)) ");

        Console.ReadKey();
    }
}

```

**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/138703104-ec66bd1d-38a4-4476-9a3b-2bd8f1e1265d.png)

### Örnek: ###

> Aşağıdaki örnekde topla metodu 3 kez tanımlanarak aşırı yüklenmiştir.

```csharp
using System;

class Islem
{
    // Tek Parametreli çağrıldığında karesini hesaplayıp döndürür.
    public int hesapla(int s1)
    {
        return s1 * s1;
    }
    // İki Parametreli çağrıldığında toplamını hesaplayıp döndürür.
    public int hesapla(int s1,int s2)
    {
        return s1 + s2;
    }
    // 3 Parametreli çağrıldığında ortalamasını hesaplayıp döndürür.
    public double hesapla(int s1, int s2,int s3)
    {
        return (s1 + s2 + s3) / 3.0;
    }

}

class program
{
    static void Main(string[] args)
    {
        Islem nesne = new Islem();
        Console.WriteLine($" Sonuç:{ nesne.hesapla(5) } \t (nesne.hesapla(5))  ");
        Console.WriteLine($" Sonuç:{ nesne.hesapla(5 , 15) } \t (nesne.hesapla(5 , 15))  ");
        Console.WriteLine($" Sonuç:{ nesne.hesapla(5, 15,37)} \t (nesne.hesapla(5 , 15 , 37))  ");
        Console.ReadKey();
    }
}

```


**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/138704533-fbf570df-2242-47b7-8781-1bdd036ae9f6.png)


