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

**Örnek**
> Bir Araba classı tasarlayınız. Bu oluşturduğunuz Araba class'ının "marka", "yıl", "depoKapasitesi", "ortalamaTuketim", "yakitTuru" adında özellikleri(field, attribute) olsun. Son olarak Main metodu içerisinde oluşturdugunuz Araba class'ından aşağıdaki gibi bir nesne oluşturarak tüm özelliklerini ekrana yazdırınız.

![image](https://user-images.githubusercontent.com/28144917/136508050-604f937c-a892-4ad1-b76c-1cd6dd1c6ffb.png)


```csharp
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

```

**Örnek**
> Bir Araba class'ı tasarlayınız. Tasarladığınız class'dan aşağıdaki gibi 3 farklı nesne oluşturup bilgilerini ekrana yazdırınız. 
![image](https://user-images.githubusercontent.com/28144917/136335354-b4bb7d0d-b119-4bba-8fd7-c7d2b703d74c.png)



```csharp
class Araba
{
    string marka = "BMW";
    short yili = 2010;
    double depoKapasitesi = 50.0;
    double ortalamaTuketim = 8.0;
    string yakitTuru = "Benzin";

    static void Main(string[] args)
    {
        Araba ArabaNesne1 = new Araba();
        Console.WriteLine($"ArabaNesne1 marka:{ArabaNesne1.marka}");
        Console.WriteLine($"ArabaNesne1 yılı:{ArabaNesne1.yili}");
        Console.WriteLine($"ArabaNesne1 depo kapasitesi:{ArabaNesne1.depoKapasitesi} lt");
        Console.WriteLine($"ArabaNesne1 ortalama Tüketim:{ArabaNesne1.ortalamaTuketim} lt/100km");
        Console.WriteLine($"ArabaNesne1 yakıt türü:{ArabaNesne1.yakitTuru}");
        Console.WriteLine("---------------");
        Araba ArabaNesne2 = new Araba();
        ArabaNesne2.marka = "AUDI";
        ArabaNesne2.yili = 2010;
        ArabaNesne2.depoKapasitesi = 50;
        ArabaNesne2.ortalamaTuketim = 6.0;
        ArabaNesne2.yakitTuru = "Dizel";
        Console.WriteLine($"ArabaNesne2 marka:{ArabaNesne2.marka}");
        Console.WriteLine($"ArabaNesne2 yılı:{ArabaNesne2.yili}");
        Console.WriteLine($"ArabaNesne2 depo kapasitesi:{ArabaNesne2.depoKapasitesi} lt");
        Console.WriteLine($"ArabaNesne2 ortalama Tüketim:{ArabaNesne2.ortalamaTuketim} lt/100km");
        Console.WriteLine($"ArabaNesne2 yakıt türü:{ArabaNesne2.yakitTuru}");

        Console.WriteLine("---------------");
        Araba ArabaNesne3 = new Araba();
        ArabaNesne3.marka = "JAGUAR";
        ArabaNesne3.yili = 2010;
        ArabaNesne3.depoKapasitesi = 50;
        ArabaNesne3.ortalamaTuketim = 8.0;
        ArabaNesne3.yakitTuru = "Benzin";
        Console.WriteLine($"ArabaNesne3 marka:{ArabaNesne3.marka}");
        Console.WriteLine($"ArabaNesne3 yılı:{ArabaNesne3.yili}");
        Console.WriteLine($"ArabaNesne3 depo kapasitesi:{ArabaNesne3.depoKapasitesi} lt");
        Console.WriteLine($"ArabaNesne3 ortalama Tüketim:{ArabaNesne3.ortalamaTuketim} lt/100km");
        Console.WriteLine($"ArabaNesne3 yakıt türü:{ArabaNesne3.yakitTuru}");
        Console.ReadKey();
    }
}

```

**Ekran Çıktısı**


![image](https://user-images.githubusercontent.com/28144917/136336496-35f9d0d9-f007-4d2f-9aed-c262e8010fc5.png)

