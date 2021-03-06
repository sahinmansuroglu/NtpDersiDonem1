## Metotlar-2 ##
> [Metotlar-1](https://github.com/sahinmansuroglu/NtpDersi/blob/main/5_Hafta_Ders_1.md) bölümünde  metot kavramını, geriye değer döndüren, geriye değer döndürmeyen ve paramtereli metod kullanımını görd
> k. Bu bölümde ise metotlarda Varsayılan Değerli Parametreler, İsimlendirilmiş Parametreler, Parametre Dizileri kullanımını göreceğiz.

###  Varsayılan Değerli Parametreler ###

>Parametreli metodlarda metotlar çağrılırken parametre değerlerinin de methoda gönderilmesi gerekir. Eğer parametreli 
>bir methodun çağırırken değer göndermeden de çalışabilmesini istiyorsak bu tür durumlarda varsayılan değerli Parametreleri kullanabiliriz.

**Örnek Kullanım**
```csharp
using System;
class ornekSinif
{
    // Aşağıdaki metod çağrılırken sayi1 ve sayi2'nin değerleri gönderilmezse varsayılan olarak 34 ve 56 değerleri toplanır
    public int topla(int sayi1=34,int sayi2 = 56)
    {
        return sayi1 + sayi2;
    }
    //Aşağıdaki metod çağırılırken adSoyad değeri gönderilmezse varsayılan olarak "Mehmet EMİN" gönderilir..
    public void selamVer(string adSoyad="Mehmet EMİN")
    {
        Console.WriteLine($"Merhaba Sayın {adSoyad}");
    }

}

class anaProgram
{
    static void Main(string []args) {
        ornekSinif nesne = new ornekSinif();

        Console.WriteLine($"Toplamın Sonucu: {nesne.topla()}");
        Console.WriteLine($"Toplamın Sonucu: {nesne.topla(25)}");
        Console.WriteLine($"Toplamın Sonucu: {nesne.topla(45,65)}");

        nesne.selamVer();
        nesne.selamVer("Şahin MANSUROĞLU");

        Console.ReadKey();
    }
}
```
**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/138216867-e36830e6-18c8-486a-a704-7ed50fd3a702.png)


## İsimlendirilmiş Parametreler ##

> Bir metod parametre  ile çağrılırken  parametrelerin,  tanımlamanma sırası ile aynı sırada gönderilmesi gerekir. Eğer bu kurala uyulmak istenmiyorsa İsimlendirilmiş parametreler kullanılabilir.

**Örnek Kullanım**

> Aşağıdaki örnekte metoda parametre gönderirken parametre adının yanına ":" koyarak parametre sırasına uymadan da değer gönderebiliriz.

![image](https://user-images.githubusercontent.com/28144917/138217847-07001129-7ba6-4c14-a085-1f8fa543a4f1.png)

![image](https://user-images.githubusercontent.com/28144917/138217732-825f936d-e938-49bf-95a8-fc8bbe02bc39.png)


**Örnek**

```csharp
using System;
class ornekSinif
{
    public int farkHesapla(int sayi1, int sayi2)
    {
        return sayi1 - sayi2;
    }

    public void selamVer(string ad, string soyad)
    {
        Console.WriteLine($"Merhaba Sayın {ad} {soyad}");
    }

}

class anaProgram
{
    static void Main(string []args) {

        ornekSinif nesne = new ornekSinif();

        Console.WriteLine($"Toplamın Sonucu: {nesne.farkHesapla(sayi2:25,sayi1:85)}");
        Console.WriteLine($"Toplamın Sonucu: {nesne.farkHesapla( 25,  85)}");

        nesne.selamVer(soyad: "MANSUROĞLU", ad: "Şahin");
        nesne.selamVer( "MANSUROĞLU",  "Şahin");

        Console.ReadKey();
    }
}

```
**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/138220876-12305b53-e7e8-4f91-9ee7-9fe049eda155.png)

## Parametre Dizileri ##
> Methodların parametre sayısının bilinmediği durumlarda parametre dizileri kullanılır. Ve bu işlem için params anahtar kelimesi kullanılır.

> Aşağıdaki method dışardan s1 ve s2 adında iki parametre alır
```csharp
int topla (int s1,int s2){
    return (s1+s2);
}
```
> Aşağıdaki method dışardan s1, s2 ve s3 adında iki parametre alır
```csharp
int topla (int s1,int s2, int s3){
    return (s1+s2+s3);
}
```

> Aşağıdaki method dışardan değişken sayıda parametre alır.

```csharp
    public void sayilariTopla(params int [] sayilar)
    {
        int toplam = 0;
        foreach (var herBirSayi in sayilar)
        {
             toplam += herBirSayi;
        }
       return toplam;
    }
   
   ```
> **Not:** Parametre Dizilerinde metoda gönderilen parametreler metot içerisine bir dizi halinde gelir ve bu  dizi içerisindeki her bir elamana (her bir parametreye) foreach döngüsü ile erişim sağlanıp işlem yaptırılabilir.

**Örnek**
>Parametre olarak aldığı sayıların toplamını hesaplayan metot uygulaması.
```csharp
using System;
public class islem
{

    public void sayilariTopla(params int [] sayilar)
    {
        int toplam = 0;
        foreach (var herBirSayi in sayilar)
        {
            Console.Write($"{herBirSayi} ");
            toplam += herBirSayi;
            
        }
        Console.WriteLine($"Sonuc: {toplam}");
    }
}
class AnaProgram
{
    static void Main(string [] args)
    {
        islem nsn = new islem();
        nsn.sayilariTopla(98,85,56, 78);
        Console.ReadKey();
    }
}
```

**Örnek**
>Parametre olarak aldığı sayıların ortalamasını hesaplayan metot uygulaması.
```csharp
using System;
public class islem
{
    public void ortalamaAl(params int [] sayilar)
    {
        int toplam = 0;
        foreach (var herBirSayi in sayilar)
        {
            Console.Write($"{herBirSayi} ");
            toplam += herBirSayi;
            
        }
        double ortalama = toplam / sayilar.Length;
        Console.WriteLine($"Sonuc: {ortalama}");
    }
}
class AnaProgram
{
    static void Main(string [] args)
    {
        islem nsn = new islem();
        nsn.ortalamaAl(56, 78,98,24);
        Console.ReadKey();
    }
}
```

**Örnek**
>Parametre olarak aldığı kelimeleri Büyük harfe çevirip alt alta ekran yazdıran metot uygulaması
```csharp
using System;
public class OrnekSinif
{

    public void buyukHarfeCevir(params string [] kelimeler)
    {
        foreach (var herBirKelime in kelimeler)
        {
            Console.WriteLine($"{herBirKelime.ToUpper()}");
        }
       
    }
}
class AnaProgram
{
    static void Main(string [] args)
    {
        OrnekSinif nesne = new OrnekSinif();
        nesne.buyukHarfeCevir("ali", "Veli", "Serdar","Ahmet");
        Console.ReadKey();
    }
}
```

**Örnek**
> secim değişkeninin değerine göre  parametre listesini büyük veya küçük harfe çeviren methot

> **Not:** Aşağıdaki  uygulamada olduğu gibi bir metot parametre dizisi ile beraber başka parametreler de alıyorsa params ifadeli parametre her zaman sonda bulunmalıdır. 
>  Ayrıca bir metodda sadece bir tane params anahtar kelimesi kullanılır

```csharp
using System;
public class OrnekSinif
{

    public void buyukKucukHarfeCevir(string secim, params string [] kelimeler)
    {
        Console.WriteLine($"Seçim:{secim}");
        foreach (var herBirKelime in kelimeler)
        {
            if (secim == "Büyük")
            {
                Console.WriteLine($"{herBirKelime.ToUpper()}");

            }else if (secim == "Küçük")
            {
                Console.WriteLine($"{herBirKelime.ToLower()}");
            }
            else
            {
                Console.WriteLine($"{herBirKelime}");
            }
                
        }
       
    }
}
class AnaProgram
{
    static void Main(string [] args)
    {
        OrnekSinif nesne = new OrnekSinif();
        Console.WriteLine("\n-------Çıktı-1....--");
        nesne.buyukKucukHarfeCevir("Büyük", "Veli", "Serdar","Ahmet");
        Console.WriteLine("\n-------Çıktı-2....--");
        nesne.buyukKucukHarfeCevir("Küçük", "Veli", "Serdar", "Ahmet");
        Console.WriteLine("\n-------Çıktı-3....--");
        nesne.buyukKucukHarfeCevir("adasdas", "Veli", "Serdar", "Ahmet");
        Console.ReadKey();
    }
}

```
