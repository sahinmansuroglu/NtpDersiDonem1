## Nesneye Yönelik programlama yaklaşımı ##

> Nesneye yönelik programlama kavramı büyük projeleri daha köçük parçalara bölebilmeye (ölçeklendirilebilirlik) ve yazılan kodların başka projelerde de kullanılabilmesini sağlayan populer programlama yaklaşımıdır.
> Ayrıca günlük hayattaki her bir objeyi modelleyerek bilgisayar ortamına kullanmamıza olanak sağlamaktadır.


## Object(Nesne) ve Class(Sınıf) Kavramı ##

> Nesneye Yönelik programlama Modeli temelde Object ve Class yapısı üzerine kuruludur.

> Aşağıda 3 farklı araba nesnesi bulunmaktadır ve herbirinin kendine ait özellikleri bulunmaktadır. 

![image](https://user-images.githubusercontent.com/28144917/135962939-17c547d4-8370-48a3-b92d-617defe5ef8f.png)

> Bu nesneleri bilgisayar ortamında tutmak için  yapılması gereken bir araba modelinin tasarlanmasıdır. Ardından bu modelden 3 tane yukarıdaki gibi nesne oluşturulur. 

> Bu oluşturulan araba modeline  nesneye yönelik programlama yaklaşımında "sınıf(class)" oluşturulan her bir araba nesnesine de "nesne (object)" denilmektedir.

### Sınıf Tanımlama ###
> İlk olarak çok basit bir sınıf oluşturalım. Aşağıdaki sınıfın Araba'dır ve renk isiminde tek bir özelliği vardır.

```csharp 
class Araba
{
    string renk="mavi";
}

```
> **Not:C# da sınıf isimlerinin baş harfi büyük olmalıdır. Ayrıca araba sınıfın içerisinde tanımlanan string tipindeki renk özelliği NTP yaklaşımında field veya attribute olarak adlandırılır.**

### Nesne Oluşturma ###
> C# da nesne oluşturmak için "new" anahtar sözcüğü kullanılır.

> **Not:Bir sınıfı kullanabilmek için o sınıftan bir nesne oluşturmamız gerekir.**

**Temel Kullanım**
```csharp
SinifAdi nesneAdi = new SinifAdi();
```
**Örnek**
> Örnek olarak Araba sınıfından bir nesne oluşturalım. Adı da arabaNesnesi1 olsun.

```csharp
  Araba arabaNesnesi = new Araba();
```
> Yukarıdaki örneği çalışabilen bir uygulama olarak tasarlayalım


```csharp
class Araba
{
    string renk = "mavi";

    static void Main(string[] args)
    {
        Araba arabaNesnesi = new Araba();
        Console.WriteLine($"Nesnemizin Rengi:{arabaNesnesi.renk}");
        Console.ReadKey();
    }
}
```

class Araba
{
    string marka = "BMW";
    short yili = 2010;
    double depoKapasitesi = 50.0;
    string yakitTuru = "Benzin";

    static void Main(string[] args)
    {
        Araba ArabaNesne1 = new Araba();
        Console.WriteLine($"ArabaNesne1 marka:{ArabaNesne1.marka}");
        Console.WriteLine($"ArabaNesne1 yılı:{ArabaNesne1.yili}");
        Console.WriteLine($"ArabaNesne1 depo kapasitesi:{ArabaNesne1.depoKapasitesi} lt");
        Console.WriteLine($"ArabaNesne1 yakıt türü:{ArabaNesne1.yakitTuru}");
        Console.ReadKey();
    }
}
