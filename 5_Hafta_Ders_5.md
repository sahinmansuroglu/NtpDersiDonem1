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
### Kapsam türleri ###
> C# 'da 3 çeşit kapsam türü vardır
1. Metot kapsamı 
2. Class kapsamı
3. İç içe Kapsam


#### 1.Metot Kapsamı ####

```csharp
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
```
#### 2.Class Kapsamı ####

```csharp
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

```

#### 3. İç İçe Kapsamı ####

```csharp
  class Islem
    {

        int puan1=95, puan2 = 65;
        
        public void Durum()
        {
           
            double ortalama = (puan1+puan2)/2.0;
            if (ortalama < 50)
            {
                string sonuc = "Kaldı";
                Console.WriteLine($"Sonuc:{sonuc}");

            }
            else
            {
                string sonuc = "Geçti";
                Console.WriteLine($"Sonuc:{sonuc}");
            }
            //Aşağıda sonuc değişkeninin değeri ekrana yazdırılmaya çalışılırsa hataya neden olur
            //Çünkü sonuc değişkeni içerdeki bir blokda tanımlanmıştır
            //Console.WriteLine($"Sonuc:{sonuc}");

        }

    }
```

**Örnek:**
```csharp
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
    
```

#### Örnek V1 ####
> Aşağıdaki uygulama sınıf yardımıyla klavyeden girilen 2 sayı arasında isteğe göre toplama, çıkartma, bölme ve çarpma işlemlerinden birini yapıp ekrana yazdıran program tasarımı

> **Not:** Aşağıdaki uygulama istenilen işlemleri yapan ve doğru çalışan bir uygulamadır. Ancak çok kod tekrarı bulunmaktadır. Bir sonraki örnekte bu kod tekrarı ortadan kaldırılmıştır.



```csharp
using System;

namespace ConsoleApp4
{
    class Program
    {

        static void Main(string[] args)
        {
            Islem islmeNesne = new Islem();
            while (true)
            {
                Console.WriteLine("*****İşlemler*****");
                Console.WriteLine("1 - Topla");
                Console.WriteLine("2 - Çıkart");
                Console.WriteLine("3 - Çarp");
                Console.WriteLine("4 - Böl");
                Console.WriteLine("5 - Çıkış");
                Console.Write("Seçiminiz (1,  2,   3,  4,  5)---->");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {
                    islmeNesne.topla();
                }
                else if (secim == 2)
                {
                    islmeNesne.cikart();
                }
                else if (secim == 3)
                {
                    islmeNesne.carp();
                }
                else if (secim == 4)
                {
                    islmeNesne.bol();
                }
                else if (secim == 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Lütfen 1 - 5 arası sayı giriniz:");
                }
            }
        }

    }


    class Islem
    {

       public void topla()
        {
            Console.Write("1. Sayıyı Giriniz:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz:");
            int s2 = Convert.ToInt32(Console.ReadLine());
            int sonuc = s1 + s2;
            Console.WriteLine($"Toplam={sonuc}");

        }
        public void cikart()
        {
            Console.Write("1. Sayıyı Giriniz:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz:");
            int s2 = Convert.ToInt32(Console.ReadLine());
            int sonuc = s1 - s2;
            Console.WriteLine($"Fark={sonuc}");

        }
        public void carp()
        {
            Console.Write("1. Sayıyı Giriniz:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz:");
            int s2 = Convert.ToInt32(Console.ReadLine());
            int sonuc = s1 * s2;
            Console.WriteLine($"Çarpım={sonuc}");

        }
        public void bol()
        {
            Console.Write("1. Sayıyı Giriniz:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz:");
            int s2 = Convert.ToInt32(Console.ReadLine());
            int sonuc = s1 / s2;
            Console.WriteLine($"Bolum={sonuc}");

        }
    }
}
```

#### Örnek V2 ####
> Aşağıdaki uygulama bir önceki uygulama ile aynı işlemi yapmaktadır. Anncak değişkenler sınıf kapsamında tanımlanarak kod tekrarı ortadan kaldırılmaya çalışılmıştır.

```csharp
using System;

namespace ConsoleApp4
{
    class Program
    {

        static void Main(string[] args)
        {
            Islem islmeNesne = new Islem();
            while (true)
            {
                islmeNesne.sayilariKullanicidanAl();
                Console.WriteLine("*****İşlemler*****");
                Console.WriteLine("1 - Topla");
                Console.WriteLine("2 - Çıkart");
                Console.WriteLine("3 - Çarp");
                Console.WriteLine("4 - Böl");
                Console.WriteLine("5 - Çıkış");
                Console.Write("Seçiminiz (1,  2,   3,  4,  5)---->");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {
                    islmeNesne.topla();
                }
                else if (secim == 2)
                {
                    islmeNesne.cikart();
                }
                else if (secim == 3)
                {
                    islmeNesne.carp();
                }
                else if (secim == 4)
                {
                    islmeNesne.bol();
                }
                else if (secim == 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Lütfen 1 - 5 arası sayı giriniz:");
                }
                islmeNesne.sonucuEkranaYaz();
           
            }
        }
    }

    class Islem
    {
        int s1, s2,sonuc=0;
       public void sayilariKullanicidanAl()
       {
            Console.Write("1. Sayıyı Giriniz:");
             s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz:");
             s2 = Convert.ToInt32(Console.ReadLine());
       }
        public void sonucuEkranaYaz()
        {
            Console.WriteLine($"Sonuc={sonuc}");
        }
        public void topla()
        {
             sonuc = s1 + s2;
        }
        public void cikart()
        {
            sonuc = s1 - s2;
        }
        public void carp()
        {
            sonuc = s1 * s2;
        }
        public void bol()
        {
            sonuc = s1 / s2;
        }
    }
}
```
