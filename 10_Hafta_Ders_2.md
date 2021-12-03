## Hiyerarşik Kalıtım ##

> Nesneye yönelik programlama yaklaşımında türetilmiş bir sınıftan başka bir sınıf türetilebilir ve bu türetilen sınıf üstündeki sınıfların üyelerini miras yoluyla kullanabilir. Bu duruma hiyerarşik Kalıtım denilir.

> Aşağıdaki Örnekte Memeli sınıfı Hayvan sınıfından Kopek sınıfı da Memeli sınıfından türetilmiştir. Hiyerarşik kalıtım yoluyla Kopek sınıfı hem Hayvan hemde Memeli sınıfının üyelerine erişim sağlayabilmektedir.

```csharp
  class Program
    {
        static void Main(string[] args)
        {
            Kopek kopek1 = new Kopek { ozellik1 = "Dişi", ozellik2 = "Evcil", ozellik3 = "Golden" };
            kopek1.bilgileriEkranaYaz();
            Console.ReadKey();
        }
    }
    class Hayvan
    {
        public string ozellik1 { get; set; }
    }

    class Memeli : Hayvan
    {
        public string ozellik2 { get; set; }

    }
    class Kopek : Memeli
    {
        public string ozellik3 { get; set; }

        public void bilgileriEkranaYaz()
        {
            Console.WriteLine($" {ozellik1} {ozellik2} {ozellik3} ");
        }

    }
    
   ```
   **Ornek-1**
   > Aşağıdaki verilenlere göre ilk olarak TemelHesap sınıfını oluşturunuz, ardından DortIslem sınıfını TemelHesap sınıfından türetiniz ve son olarak GelismisHesaplama sınıfını da DortIslem sınıfından türetiniz. Ek olarak GelismisHesaplama sınıfından bir nesne oluşturarak içindeki tüm metotları çağırıp sonuclarını ekrana yazdırınız.

| Sınıf Adı      | İçinde Bulunacak Metotlar |
| ----------- | ----------- |
| TemelHesap      | topla(s1,s2), cikar(s1,s2)        |
| DortIslem   | topla(s1,s2), cikar(s1,s2) , carp(s1,s2),bol(s1,s2)         |
| GelismisHesaplama   | topla(s1,s2), cikar(s1,s2) , carp(s1,s2), bol(s1,s2), kalanBul(s1,s2), karesiniAl(s1)          |

**Çözüm**
```csharp
  class Program
    {
        static void Main(string[] args)
        {
            GelismisHesaplama nesne = new GelismisHesaplama();
            Console.WriteLine($"Toplam: {nesne.topla(45,5)}");
            Console.WriteLine($"Fark: {nesne.cikar(45, 5)}");
            Console.WriteLine($"Çarp: {nesne.carp(45, 5)}");
            Console.WriteLine($"Böl: {nesne.bol(45, 5)}");
            Console.WriteLine($"Kalan: {nesne.kalan(45, 5)}");
            Console.WriteLine($"Karesi: {nesne.karesiniAl( 5)}");
            Console.ReadKey();
        }
    }
    class TemelHesap
    {
        public int topla(int s1, int s2)
        {
            return s1 + s2;
        }
        public int cikar(int s1, int s2)
        {
            return s1 - s2;
        }
    }
    class DortIslem : TemelHesap
    {
        public int carp(int s1, int s2)
        {
            return s1 * s2;
        }
        public int bol(int s1, int s2)
        {
            return s1 / s2;
        }
    }
    class GelismisHesaplama : DortIslem
    {
        public int kalan(int s1, int s2)
        {
            return s1 % s2;
        }
        public int karesiniAl(int s1)
        {
            return s1 * s1;
        }

    }

```
