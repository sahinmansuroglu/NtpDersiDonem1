## Üst Sınıfın (Base vs Parent) üyelerine erişim (Base keyword kullanımı) ##

> C# programlama dilinde base class yani üst sınıfın üyelerine erişim için base keyword'ü kullanılır.

**Örnek**
> Aşağıdaki kod örneğinde ParentSinif class'indan ChildSinif class'i türetilmiştir. Her iki sınıfta da kurucu metot tanımlanmıştır. ancak türetilmiş sınıfın(ChildSinif) kurucu metodundan 
> temel sınıfın(ParentSinif) kurucu metoduna erişebilmek için  türetilmiş sınıfın kurucu metodu ``` public ChildSinif(int sayi2) : base(sayi2)``` şeklinde düzenlenerek ChildSınıfın kurucu metoduna gelen parametre ile ParentClass'ın kurucu metodu çağrılmıştır


```csharp
class Program
    {
        static void Main(string[] args)
        {
            ChildSinif nesne = new ChildSinif(25);
            Console.ReadKey();
        }
    }


    class ParentSinif
    {

        public ParentSinif(int sayi1)
        {
            Console.WriteLine($"Parent Sinif'in Kurucu Metodu (Sayi:{sayi1} )");
        
        }

    }

    class ChildSinif:ParentSinif
    {

        public ChildSinif(int sayi2) : base(sayi2)
        {
            Console.WriteLine("Child Sinif'in Kurucu Metodu");

        }
    }
```
