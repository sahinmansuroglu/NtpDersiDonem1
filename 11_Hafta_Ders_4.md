## Statik Sınıflar (Static Classes) ##
> Statik sınıflar statik sınıflara benzerdir ancak 2 önemli farkı vardır. Bunlar;
  
   1. Static Sınıfların tüm üyeleri static tanımlanmalıdır.
   2. Static Sınıfların normal sınıflar gibi "new" ile  nesnesi oluşturulamaz. İçerisindeki metotlara erişim için Sınıf adı kullanılır.


**Örnek**

```csharp
 class Program
    {
        static void Main(string[] args)
        {
            Islemler.topla(65, 35);
            Islemler.carp(66, 32);
            Islemler.bol(66, 32);
            Islemler.cikart(66, 32);
            Console.ReadKey();
        }
    }
    
   static class Islemler
    {
        public static void topla(int s1,int s2)
        {
            Console.WriteLine($"Toplam:{s1+s2}");
        }
        public static void carp(int s1, int s2)
        {
            Console.WriteLine($"Çarpım:{s1 * s2}");
        }
         public static void bol(int s1,int s2)
        {
            Console.WriteLine($"Bölüm:{s1+s2}");
        }
        public static void cikart(int s1, int s2)
        {
            Console.WriteLine($"Fark:{s1 * s2}");
        }

    }
    
    
