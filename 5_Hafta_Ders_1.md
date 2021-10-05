## Metot Kavramı ##

> Programlama dillerinde tekrar eden kodları bir kez tanımlayıp daha sonra tekrar tekrar kullanmamıza yarayan yapılara metot denir. Metot kullanımı ile yazılan uygulamalar alt programlara ayrıldığı için de daha anlaşılır hale gelirler. 

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

**Örnek**
> Tek bir Metot içerisinde alınan parametreye göre dikdörtgenin alanı ve çevresine hesaplayıp döndüren metodu tasarlayınız.
```csharp
class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dikdörtgenin Kısa Kenarı:");
            int girilenKisaKenar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dikdörtgenin Uzun Kenarı:");
            int girilenUzunKenar = Convert.ToInt32(Console.ReadLine());
            int alan = hesapla(girilenKisaKenar, girilenUzunKenar, "Alan1");
            int cevre = hesapla(girilenKisaKenar, girilenUzunKenar, "Çevre");
            Console.WriteLine($"Alan: {alan} \nÇevre: {cevre}");
            Console.ReadKey();
        }
        //secim eger "Alan" ise alan hesaplanacak 
        //secim eger "Çevre" ise alan hesaplanacak.
       static int hesapla(int kisaKenar, int uzunKenar, string secim)
        {
            if (secim == "Alan")
            {
                return kisaKenar * uzunKenar;
            }else if (secim == "Çevre")
            {
                return (kisaKenar + uzunKenar) * 2;
            }
            else
            {
                return 0;
            }

        }
    }
```
