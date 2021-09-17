## Karar ve Kontrol Deyimler ##
> Programın çalışmasını belli şartlara göre değiştirmek istediğimizde `Karar ve Kontrol Deyimlerini` kullanırız



> C#'da kullanılabilecek karar ve kontrol deyimleri
1. if
2. if-else
3. else if
4. Switch case



### 1. if Yapısı ###
> Genel Kullanım
```csharp
if (şart){
  // şart doğru olduğunda bu kod bloğu çalışır.
}
```
> __*Şart Mantıksal bir ifade olmalı*__

> **Not:** C#'da aşağıdaki gibi süslü parantezin açılıp kapatıldığı yağıya blok denilmektedir. 
```csharp
  {
    //Kod Bloğu
  }
```
#### Örnek ####

```csharp
 static void Main(string[] args)
        {
            int a = 10;
            //Alttaki şart doğru ise if'in altındaki blok çalışır.
            if (a > 5)
            {
                Console.WriteLine("a sayısı 5'den büyüktür.");
            }
            Console.WriteLine("Program Sonlandı..");
            Console.ReadKey();
        }
```

**Ekran Çıktısı**
```
a sayısı 5'den büyüktür.
Program Sonlandı..
```
#### Örnek ####

```csharp
 static void Main(string[] args)
        {
            int c = 10;
            //Alttaki şart doğru ise if'in altındaki blok çalışır
            if (c < 5)
            {
                Console.WriteLine("c sayısı 5'den küçüktür.");
            }
            Console.WriteLine("Program Sonlandı..");
            Console.ReadKey();
        }
```

**Ekran Çıktısı**
```
Program Sonlandı..
```
