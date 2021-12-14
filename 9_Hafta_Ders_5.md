## Statik Üyeler  ##

> Bir sınıfın **statik olmayan** üyelerine(metod, field)  erişmek için öncelikle sınıftan bir nesne oluşturulması gerekir. **Statik üyelere** erişmek için ise nesne oluşturmak yerine  class adı kullanılır.

**Örnek (Static Metotlara Erişimle ilgili)**
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

**Not:** Bir sınıfdaki Static bir metot içerisinden static olmayan metotlara erişim yapılamaz.

| Static Metot içerisinde Static olmayan metoda ulaşılmaya çalışılmış (**HATA**)    | 
| ----------- | 
| ![image](https://user-images.githubusercontent.com/28144917/145557806-8e6b51e9-0541-42f4-97b1-211478e31b64.png)|


### Paylaşılan Alan Oluşturma ###
> Bir class içerisinde static bir field(Alan) oluşturulduğunda dikkat edilmesi gerekir. Çünkü bu oluşturulan alan sınıftan yaratılan tüm nesneler için paylaşılan yani ortak bir alandır.

**Örnek:**
> Aşağıdaki örnekte Ogrenci class'ının içerisinde ogrenciSayisi adında static bir field oluşturulmuştur. Yani bu field oluşturulacak tüm nesneler için ortak olacaktır. ogrenciSayisi field'i her yeni nesne oluşturulduğunda otomatik olarak bir arttırılacaktır. Böylece oluşturulan herhangi bir nesne içerisinden bu field'a ulaşılarak oluşturulan Ogrenci nesnesi sayısına ulaşılabilecektir.


```csharp
class Program
{
    static void Main(string[] args)
    {
        Ogrenci ogrenci1 = new Ogrenci { AdSoyad = "Akın KOÇ" };
        Ogrenci ogrenci2 = new Ogrenci { AdSoyad = "Ahmet SEZGİN" };
        Ogrenci ogrenci3 = new Ogrenci { AdSoyad = "Ali KOÇ" };
        Console.WriteLine($"Öğrenci Sayısı:{ogrenci1.OgrenciSayisi}");
        Console.WriteLine($"Öğrenci Sayısı:{ogrenci2.OgrenciSayisi}");
        Console.WriteLine($"Öğrenci Sayısı:{ogrenci3.OgrenciSayisi}");
        Console.ReadKey();
    }
}

class Ogrenci
{
    static int ogrenciSayisi = 0;
    public int OgrenciSayisi
    {
        get
        {
            return ogrenciSayisi;
        }
    }
    public String AdSoyad { get; set; }
    public Ogrenci(string adSoyad)
    {
        ogrenciSayisi++;
        this.AdSoyad = adSoyad;
    }


}
```

| Durum|Uygulamanın UML Diyagramı|
|:------------:|:------------:|
|Nense oluşturulmamışken|![image](https://user-images.githubusercontent.com/28144917/145949322-49b37ab3-4568-4bf5-9ee5-14bccdbddb84.png)|
|1 Nesne oluşturulduğunda |![image](https://user-images.githubusercontent.com/28144917/145949275-4b5507cf-3aa6-438a-b57d-43b718c16d13.png)|
|2 Nesne oluşturulduğunda|![image](https://user-images.githubusercontent.com/28144917/145949195-930e1b88-e6ef-466c-99c2-975e8a322177.png)|
|3 Nesne oluşturulduğunda|![image](https://user-images.githubusercontent.com/28144917/145949135-1c20f77d-6be5-4e9b-b4d5-954d69aa83da.png)|

