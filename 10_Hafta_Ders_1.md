## Kalıtım (Inheritance) ##

> C# da bir sınıfın metot ve özelliklerini başka bir sınıftan miras olarak alıp kullanmak mümkündür. Bu kullanıma kalıtım denilmektedir.
> Kalıtım yaklaşımını iki kategoriye ayırabiliriz.

  **1. Türetilmiş Sınıf (Derived Class veya Child Class):** Metotları ve özellikleri **miras alan** sınıf
  
  **2. Temel Sınıf (Base Class veya Parent Class):** Metotları ve özellikleri **miras alınan** sınıf
  
  
> Bir sınıftam miras almak için ":" sembolü kullanılır

###Örnek Kullanım###
>Aşağıdaki örnekde hayvan sınıfından kedi sınıfı türetilmiştir. Bu örnekte kedi sınıfı türetilen sınıf hayvan sınıfı da temel sınıftır.

```csharp
class Hayvan
{
    public void yemekYe()
    {
        Console.WriteLine("Yemek yiyor");
    }
}
class Kedi:Hayvan
{
    public void miyavla()
    {
        Console.WriteLine("Kedi Miyavlıyor.");
    }

}
class Program
{
    static void Main(string[] args)
    {
        Kedi kedi1 = new Kedi();
        kedi1.yemekYe();
        kedi1.miyavla();
        Console.ReadKey();
    }
}

```


