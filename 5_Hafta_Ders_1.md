## Metot Kavramı ##

> Programlama dillerinde kodların tekrar tekrar yazılması yerine 

### Metot Tanımlama ###

> Geriye Değer Döndürmeyen Metot Tanımlama

```csharp
void metotadi ()
{

//metot içerisinde gerçekleştirilecek işlemler ;

}
```
**Örnek**

```csharp
 void mesajYaz()
 {
            Console.WriteLine("Merhaba 11 ATBA");
            Console.WriteLine("Bugün Nasılsınız?");
  }
```

> Geriye Değer Döndüren Metot Tanımlama

```csharp
dönüş_tipi metotadi ()
{

  //metot içerisinde gerçekleştirilecek işlemler ;
  return dönüş_Değeri
}

```

**Örnek**

```csharp
  string mesajGetir()
        {
            string mesaJ = "Merhaba 11ATBA \n Bugün Nasılsınız?";
            return mesaJ;
        }
        
```

> Dışardan Parametre Alan  Metot Tanımlama

```csharp
static void Main(string[] args)
        {

           Console.WriteLine( mesajGetir("Ahmet ER"));
           Console.WriteLine(mesajGetir("Ali VELİ"));
           Console.WriteLine(mesajGetir("Mehmet CAN"));
            Console.ReadKey();

        }
        
       static string mesajGetir(string ad)
        {
            string mesaJ = $"Merhaba {ad} \n Bugün Nasılsınız?";
            return mesaJ;
        }
```
> Yukarıdaki örneği Geriye Değer Döndürmeyen Metot ile tasarlayalım

```csharp
namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

           mesajGetir("Ahmet ER");
           mesajGetir("Ali VELİ");
           mesajGetir("Mehmet CAN");
           Console.ReadKey();
        }
        
       static void mesajGetir(string ad)
        {
            string mesaj = $"Merhaba {ad} \n Bugün Nasılsınız?";
            Console.WriteLine(mesaj);
        }
        
}
}
```

**Örnek**
> Parametre alarak aldığı iki sayıyı toplayan geriye değer döndüren metot tanımlayınız...

```csharp
namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

             Console.WriteLine(topla(15, 20));
             Console.ReadKey();
        }
        static int topla(int sayi1,int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            return sonuc;
        }
    }
}
```

**Örnek**
> Yukarıdaki uygulamaya çıkart, çarp ve böl metotlarını da ekleyip ana programda da çağırınız.

```csharp
 class Program
    {
        static void Main(string[] args)
        {

            Console.Write("1. Sayı:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("1. Sayı:");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Toplama işleminin Sonucu:{topla(s1, s2)}");
            Console.WriteLine($"Çıkartma işleminin Sonucu:{cikart(s1, s2)}");
            Console.WriteLine($"Çarpma işleminin Sonucu:{carp(s1, s2)}");
            Console.WriteLine($"Bölme işleminin Sonucu:{bol(s1, s2)}");
            Console.ReadKey();
        }
        static int topla(int sayi1,int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            return sonuc;
        }

     
        static int cikart(int sayi1, int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            return sonuc;
        }
        static int carp(int sayi1, int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            return sonuc;
        }
        static int bol(int sayi1, int sayi2)
        {
            int sonuc = sayi1 / sayi2;
            return sonuc;
        }
    }
```

