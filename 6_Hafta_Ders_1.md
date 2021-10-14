## Erişim Belirleyiciler (Access Modifiers) ##
> Erişim belirleyiciler sınıflara ve sınıf içerisindeki üyelere (field, methot) hangi durumlarda erişim sağlanabileceğini belirlemek için kullanılır.

### Erişim Belirleyici Türleri ###

| Erişim Belirleyici    | Tanım           | 
| ------------- |:---------------:| 
| Public    		| Bu erişim belirleyicide herhangi bir kısıtlama yoktur. Tüm sınıflar ve projeler tarafından erişilebilir. | 
| Private    		| Bu erişim belirleyicisi ile tanımlanmış üyelere sadece tanımlandığı class içerisinden erişilebilir. | 
| Protected    		| Bu erişim belirleyicisi ile tanımlanmış üyelere tanımlandığı class içerisinden veya bu class'ı miras alan class'lar tarafından erişilebilir.| 
| Internal    		| Sadece  tanımlandığı proje içerisinden erişilebilir. Farklı bir projeden erişilemez   | 
| Internal protected		|  Tanımlandığı proje içerisinden erişilebilir. Farklı bir projeden ise miras alınarak kullanılabilir. | 

**Not-1:**  Internal, bir Class'ın  varsayılan erişim belirleyicisidir. Class'ın başına herhangi bir şey yazılmadığında internal kabul edilir.

**Not-2:**  Bir class üyesinin varsayılan erişim belirleyicisi private'dir.Class'ın başına herhangi bir şey yazılmadığında private kabul edilir.

**Public ve Private kullanımı ile ilgili Örnek**
> Aşağıdaki uygulamada Person sınıfının içerisindeki adSoyad ve yas Alanları ile  bilgileriEkranaYaz metodu  tanımlanmıştır. Ancak başına erişim belirleyicisi yazılmadığı için varsayılan olarak private olarak belirlenmiştir.  Ana programda Person sınıfından kisi1 nesnesi üretimiştir. Ancak adSoyad ve yas Alanları ile  bilgileriEkranaYaz metodu private olduğundan ulaşılmaya çalışıldığında hata vermiştir.

![image](https://user-images.githubusercontent.com/28144917/137266766-c76b531c-3d71-4c2e-a055-e6d8d10bdf93.png)

**Çözüm**
> Yukarıdaki hatayı ortadan kaldırabilmek için adSoyad ve yas Alanları ile  bilgileriEkranaYaz metodunun başına public erişim belirleyicisi yazılmalıdır.


```csharp
using System;

namespace proje3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person kisi1 = new Person();
            kisi1.adSoyad = "Arda AR";
            kisi1.yas = 35;
            kisi1.bilgileriEkranaYaz();
            Console.ReadKey();
        }
    }
    class Person
    {
       public string adSoyad;
       public int yas;
       public void bilgileriEkranaYaz()
        {
            Console.WriteLine($"Ad Soyad:{adSoyad}");
            Console.WriteLine($"Yaş:{yas}");
        }

    }

}
```

**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/137267123-85c562b8-2f25-4fe6-b0fd-ffa0da2b4373.png)


