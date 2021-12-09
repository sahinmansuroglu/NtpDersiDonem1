## Üst Sınıfın (Base vs Parent) üyelerine erişim (Base keyword kullanımı) ##

> C# programlama dilinde base class yani üst sınıfın üyelerine erişim için base keyword'ü kullanılır.

**Örnek-1**
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


**Örnek-2**

> Aşağıda verilenlere göre ilk olarak kare sınıfını tanımlayınız. Ardından Kare sınıfından Dikdortgen Sınıfını türetiniz. Son olarak Kare ve Dikdortgen sınıfından birer nesne oluşturarak alanını ve çevresini ekrana yazdırınız. Oluşturan nesnelerin kenar uzunlukları kurucu metot ile atanacaktır.

**Not:**  Virtual  override ve is keywordleri kullanılmalıdır.

| Sınıf Adı      | İçinde Bulunacak Property'ler | İçinde Bulunacak Metotlar |
| ----------- | ----------- |----------- |
| Kare      | KenarA     | alan(), cevre() |
| Dikdortgen   | KenarA, KenarB       |alan(), cevre() |


**Örnek-3**

> Yukarıdaki örneğe ek olarak aşağıda verilenlere göre Dikdörtgen sınıfından Üçgen sınıfını türetiniz. Son olarak Üçgen sınıfından birer nesne oluşturarak alanını ve çevresini ekrana yazdırınız. Oluşturan nesnelerin kenar uzunlukları kurucu metot ile atanacaktır. 

**Not:**  Virtual  override ve is keywordleri kullanılmalıdır.

| Sınıf Adı      | İçinde Bulunacak Property'ler | İçinde Bulunacak Metotlar |
| ----------- | ----------- |----------- |
| Kare      | KenarA     | alan(), cevre() |
| Dikdortgen   | KenarA, KenarB       |alan(), cevre() |
| Ucgen   | KenarA, KenarB, KenarC       |alan(), cevre() |


| Üç kenarı Bilinen Üçgenin Alanının Hesaplanması    | 
| ----------- |
|![image](https://user-images.githubusercontent.com/28144917/145355111-951084fd-c23b-4077-ba7a-5d6111470aaf.png)|



