## Kapsam ##

Kapsam kavramı bir değişkene veya nesneye sınıf içerisindeyken hangi durumlarda erişilebileceğini ifade eder.

> **Not:** Aşağıdaki gibi  süslü parantezin açılıp kapatıldığı yapıya  blok denir. 
> Bir Blok içerisinde tanımlanan değişken veya nesnelere o blok içerisindeki alt bloklardan erişim sağlanabilir.
```csharp
{

}
```
**Örnek:**

```csharp
{
	
    {
        int a=10;
        {
            // Bu blok içerisinden a Değişkenine ulaşıabilir
        }
    }

    {
        // Bu blok içerisinden a değişkenine ulaşılamaz.
        // Çünkü a  değişkeni farklı bir blok içerisinde tanımlanmıştır.
    }

}
```

Metot Kapsamı

 class Islem
    {

        public void topla()
        {
	    // a ve b değişkenleri topla metodunun blokları içerisinde tanımlandığından 
	    // sadece bu blok içerisinde veya bu bloğun içerisindeki alt bloklardan erişim sağlanır.
            int a = 10; 
            int b = 6;
            int sonuc = a + b;
            Console.WriteLine($"Toplam:{sonuc}");
            
        }
        public void cikar()
        {
            //Hata: a  ve b değişkenine ulaşılamaz. Çünkü a ve değişkeni başka bir diğer metotda tanımlanmıştır.
            int sonuc = a - b;
            Console.WriteLine($"Fark:{sonuc}");
        }
	
    }

Class Kapsamı

class Islem
    {
        // a  ve b değişkeni class kapsamında tanımlandığından
        // tüm metotların içerisinden erişilebilir
        int a = 10;
        int b = 6;
        public void topla()
        {
            
            int sonuc = a + b;
            Console.WriteLine($"Toplam:{sonuc}");
            
        }
        public void cikar()
        {
            int sonuc = a - b;
            Console.WriteLine($"Toplam:{sonuc}");
        }

    }


class Program
    {

        static void Main(string[] args)
        {
            Islem nesne = new Islem();
            nesne.topla();
            nesne.cikar();
            Console.ReadKey();
        }

    }


    class Islem
    {
        // a  ve b değişkeni class kapsamında tanımlandığından
        // tüm metotların içerisinden erişilebilir. 
        int a = 10;
        int b = 6;
        public void topla()
        {
	    
            int a = 45;
            int b = 56;
	    //a ve b değişkenleri metot içerisinde de tanımandığından sonuc hesaplanırken metoto içerisinde tanımlanan
	    // a ve değişkenleri kullanılır
            int sonuc = a + b;
            Console.WriteLine($"Toplam:{sonuc}");
            
        }
        public void cikar()
        {
            int a = 85;
            int b = 15;
            int sonuc = a - b;
            Console.WriteLine($"Fark:{sonuc}");
        }

    }
