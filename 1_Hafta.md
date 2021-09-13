## ad, soyad şeklinde 2 adet değişken tanımlayıp değerlerini atayınız.
## Bu iki değişkenin değerini tek bir console.write line ile başına Merhaba kelimesi gelecek şekilde yazınız

## Açıklama: var ile değişken tanımlarken değişkenin tipi ilk atanan değere göre ayarlanır. 
## Not: C# programlama dilinde bir değişkeni kullanmadan önce tanımlamamız gerekir.
```csharp

using System;
namespace hafta1{
    class Program
    {
        static void Main(string[] args)
        {
            var ad = "Şahin";
            var soyad = "MANSUROĞLU";
                   
            var mesaj1 = "Merhaba " + ad + " " + soyad ; // metinleri "+" operatörü ile birleştirdik 
            var mesaj2 = $"Merhaba {ad} {soyad}"; // metinleri String interpolation yöntemi ile birleştirdik
            
            Console.WriteLine(mesaj1);
            Console.WriteLine(mesaj2);
        }
    }
}

```

##Stringler
```csharp
using System;


namespace hafta1
{
    class Program
    {
        static void Main(string[] args)
        {


            string metin1 = "";// içi boş bir string değişken tanımlandı.
            string metin2 = string.Empty;// içi boş bir string değişken tanımlandı.
            metin1 = "En büyük ";
            metin2 = "Galatasaray";
            string birlestirilmisMetin = $"{metin1} {metin2} !!";

            Console.WriteLine(birlestirilmisMetin);

        }
    }
}

```

## Null ve Empty Kavramı

```csharp
using System;


namespace hafta1
{
    class Program
    {
        static void Main(string[] args)
        {

           
            string metin1 = "";// içi boş bir string değişken tanımlandı.
            string metin2 = string.Empty;// içi boş bir string değişken tanımlandı.
            string metin3 = null;

            // metin3'un değeri null olduğu için  Aşağıdaki kod  hata verir..
            //Console.WriteLine($" metin3'ün karakter Sayısı={metin3.Length}");

            // metin1'in içi boş olduğu olduğu için  karakter sayısı 0 olur
            Console.WriteLine($"metin1'ün karakter Sayısı={metin1.Length}");

            // metin1'in içi boş olduğu olduğu için  karakter sayısı 0 olur
            Console.WriteLine($"metin2'ün karakter Sayısı={metin2.Length}");


        }
    }
}
```
## string operatörleri
```csharp
using System;


namespace hafta1
{
    class Program
    {
        static void Main(string[] args)
        {

            string sayi1 = "35";
            string sayi2 = "65";
            //+ operatörü stringlerde birleştirme yapar Bundan dolayı sonuc "3565" dir
            string sonuc = sayi1 + sayi2;
            Console.WriteLine(sonuc);


        }
    }
}

```
```csharp
using System;


namespace hafta1
{
    class Program
    {
        static void Main(string[] args)
        {
            string orjinalMesaj = "Bugün HAVA Çok Güzel...";

            //orjinalMesaj ToUpper ile  tüm harfleri büyük hale getirilir ve msj1'e atılır
            string msj1 = orjinalMesaj.ToUpper();
            //orjinalMesaj ToLower ile  tüm harfleri küçük hale getirilir ve msj2'ye atılır
            string msj2 = orjinalMesaj.ToLower();

            Console.WriteLine($"Tum harfler büyük:{msj1}");
            Console.WriteLine($"Tum harfler küçük:{msj2}");

            string msj3 = "Mezitli MTAL".ToUpper();
            Console.WriteLine($"Tum harfler büyük:{msj3}");
        }
    }
}
```

## String ifadenin başındaki ve sonundaki boşlukları silme

```csharp
using System;


namespace hafta1
{
    class Program
    {
        static void Main(string[] args)
        {
            string orjinalMesaj = "    Bugün Hava Çok Güzel    ";
            Console.WriteLine($"msj:{orjinalMesaj}!");

            // orjinalMesajın başındaki boşlukları TrimStart ile silerek msj1'e atadık
            string msj1 = orjinalMesaj.TrimStart();
            Console.WriteLine($"msj1:{msj1}!");

            // orjinalMesajın sonundaki boşlukları TrimEnd ile silerek msj2'e atadık
            string msj2 = orjinalMesaj.TrimEnd();
            Console.WriteLine($"msj2:{msj2}!");

            // orjinalMesajın başındaki ve sonundaki boşlukları Trim ile silerek msj3'e atadık
            string msj3 = orjinalMesaj.Trim();
            Console.WriteLine($"msj3:{msj3}!");


        }
    }
}

```

## String ifadenin bir bölümünü alma
```csharp
using System;


namespace hafta1
{
    class Program
    {
        static void Main(string[] args)
        {
            // orjinal mesajın ilk 5 karakterini boşluksuz almaya çalışalım

            string orjinalMesaj = "    Bugün Hava Çok Güzel    ";
            // orjinal mesajın başındaki ve sonundaki boşluklar atıldıktan sonra 
            // 6. karakterden itibaren 4 karakter msj1'e atılır. ("Hava" kelimesi atanır)
            string msj1 = orjinalMesaj.Trim().Substring(6, 4);

            // orjinal mesajın başındaki ve sonundaki boşluklar atıldıktan sonra 
            // 0. karakterden itibaren 5 karakter msj2'e atılır.("Bugün" kelimesi atanır)
            string msj2 = orjinalMesaj.Trim().Substring(0, 5);


            // orjinal mesajın başındaki ve sonundaki boşluklar atıldıktan sonra 
            // 15. karakterden itibaren 5 karakter msj3'e atılır.("Güzel" kelimesi atanır)
            string msj3 = orjinalMesaj.Trim().Substring(15, 5);


            // orjinal mesajın son 10 karakterini alma
            string msj4 = orjinalMesaj.Substring(orjinalMesaj.Length-10, 10);

            Console.WriteLine($"msj1:{msj1}.");
            
            Console.WriteLine($"msj2:{msj2}.");
            Console.WriteLine($"msj3:{msj3}.");
            Console.WriteLine($"msj4:{msj4}.");



        }
    }
}
```
## Contains ile bir metinin başka bir metinin içerisinde bulunup bulunmadığını test etme
```csharp
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
          
            string orjinalMesaj = "Bugün Hava Çok Güzel    ";

            //"Hava" kelimesi orjinal mesaj'ın içerisinde bulunduğundan dolayı sonuc1'e true atıldı
            var sonuc1 = orjinalMesaj.Contains("Hava");
            
            //"Su" kelimesi orjinal mesaj'ın içerisinde bulunmadığından dolayı sonuc2'e false atıldı
            var sonuc2 = orjinalMesaj.Contains("Su");

            Console.WriteLine(sonuc1);
            Console.WriteLine(sonuc2);



        }
    }
}

```
## Replace ile cümleninin herhangi bir bölümünü değiştirme
```csharp
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
          
            string orjinalMesaj = "Bugün Hava Çok Güzel";

            //orjinal mesajda "Güzel" kelimesi "Kötü" kelimesi ile değiştirilmiştir
            string yeniMesaj = orjinalMesaj.Replace("Güzel", "Kötü");

            Console.WriteLine($"orjinal mesaj:{orjinalMesaj}");

            Console.WriteLine($"yeni mesaj:{yeniMesaj}");





        }
    }
}
```
