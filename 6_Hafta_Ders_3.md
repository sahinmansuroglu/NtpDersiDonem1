## Sadece Okunabilir Özellikler## 
> Bir özelliğe (property) değer atamak için set, değerini almak(Okumak) için ise get metodu kullanıldığını biliyoruz. Eğer bir özelliğin sadece get metodu varsa Bu özelliğin sadece değeri okunabilir. Herhangi bir değer ataması yapılamaz.

**Örnek**

```csharp
using System;

public class Dikdortgen
{
    private int uzunKenar;
    private int kisaKenar;
    public Dikdortgen(int uzunKenar, int KisaKenar)
    {
        this.uzunKenar = uzunKenar;
        this.kisaKenar = KisaKenar;
    }
    public int Alan
    {
        get
        {
            return kisaKenar * uzunKenar;
        }
    }

    public int Cevre
    {
        get
        {
            return (kisaKenar + uzunKenar)/2;
        }
    }
}

class program
{
    static void Main(string[] args)
    {
        Dikdortgen dikdortgen1 = new Dikdortgen(45, 66);
        Console.WriteLine($"Alan={dikdortgen1.Alan}");
        Console.WriteLine($"Çevre={dikdortgen1.Cevre}");
    }
}

```

## Sadece Okunabilir Özellikler## 
