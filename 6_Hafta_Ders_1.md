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

**Örnek**
> Aşağıdaki uygulamada Person sınıfının içerisindeki adSoyad ve yas Alanları ile  bilgileriEkranaYaz metodu  tanımlanmıştır. Ancak başına erişim belirleyicisi yazılmadığı için varsayılan olarak private olarak belirlenmiştir.  Ana programda Person sınıfından kisi1 nesnesi üretimiştir. Ancak adSoyad ve yas Alanları ile  bilgileriEkranaYaz metodu private olduğundan ulaşılmaya çalışıldığında hata vermiştir.

![image](https://user-images.githubusercontent.com/28144917/137263672-8490fef1-c8b0-4d0a-aa87-c9da99a1e793.png)

**Çözüm**
> Yukarıdaki hatayı ortadan kaldırabilmek için adSoyad ve yas Alanları ile  bilgileriEkranaYaz metodunun başına public erişim belirleyicisi yazılmalıdır.


```csharp
using System;

namespace proje3
{
    class Program
    {
        int a;
        static void Main(string[] args)
        {
            Person kisi1 = new Person();
            kisi1.adSoyad = "Arda AR";
            kisi1.yas = 35;
            kisi1.bilgileriEkranaYaz();
            Console.WriteLine("Hello World!");
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

![image](https://user-images.githubusercontent.com/28144917/137266405-b83b0898-dd9d-42e5-8c4a-c74e53140130.png)

