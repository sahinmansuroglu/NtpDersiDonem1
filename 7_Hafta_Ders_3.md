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
> Aşağıdaki örneği inceleyecek olursak farklı sayıdaki tip ve parametreli 6 tane  topla iisminde methot tanımlanmıştır. Aynı isimde birden fazla topla methodu bulunduğundan topla methodu aşırı yüklenmiştir.

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

    public int topla(params int [] sayilar)
    {
        int sonuc = 0;
        foreach (var herBirSayi in sayilar)
        {
            sonuc += herBirSayi;
        }
        return sonuc;
    }
    public double topla(params double[] sayilar)
    {
        double sonuc = 0;
        foreach (var herBirSayi in sayilar)
        {
            sonuc += herBirSayi;
        }
        return sonuc;
    }
}


class program
{
    static void Main(string[] args)
    {
        Islem nesne = new Islem();
        Console.WriteLine($" Sonuç:{ nesne.topla(25,95) } \t (nesne.topla(25,95))  ");
        Console.WriteLine($" Sonuç:{ nesne.topla(25.02, 95) } \t (nesne.topla(25.02, 95)) ");
        Console.WriteLine($" Sonuç:{ nesne.topla(90, 25, 95) } \t (nesne.topla(90, 25, 95)) ");
        Console.WriteLine($" Sonuç:{ nesne.topla(85.685, 95.2, 95.4):.##} \t (nesne.topla(85.685, 95,2, 95.4))  ");
        Console.WriteLine($" Sonuç:{ nesne.topla(68, 95, 98,46)} \t (nesne.topla(68, 95, 98,46))  ");
        Console.ReadKey();
    }
}

```





