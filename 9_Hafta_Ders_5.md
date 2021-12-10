## Statik Üyeler(Field, Property, Metod) ##

> Bir sınıfın statik olmayan üyelerine erişmek için öncelikle sınıftan bir nesne oluşturulması gerekir.Statik üyeler erişmek için ise nesne oluşturmak yerine sadece sadece class adı kullanılır.

**Örnek**
> Aşağıdaki programı inceleyecek olursak Islem sınıfının içerisinde topla(int s1,int s2)  metodu static tanımlandığından dolayı ana programda nesne oluşturmaya gerek kalmadan (Islem.topla(25, 15)) direk sınıf ismini kullanarak topla metodunu çağırabildik.

```csharp
class Program
{
    static void Main(string[] args)
    {
        int sonuc = Islem.topla(25, 15);
        Console.WriteLine($"Toplam:{sonuc}");
        Console.ReadKey();
    }
}

class Islem
{
    public static int topla(int s1,int s2)
    {
        return s1 + s2;
    }
}
```
