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
if (şart)
{
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

### 2. if-else Yapısı ###
> Genel Kullanım
```csharp
if (şart)
{
  // şart doğru olduğunda bu kod bloğu çalışır.
}else
{
  // şart yanlış olduğunda bu kod bloğu çalışır.
}
```

#### Örnek ####

```csharp
 static void Main(string[] args)
        {
            int a = 10;
            //Eğer aşağıdaki şart doğru ise if'in altındaki kod bloğu,yanlış ise else'nin altındaki kod bloğu çalışır.
            if (a > 5)
            {
                Console.WriteLine("a sayısı 5'den büyüktür.");
            }
            else
            {
                Console.WriteLine("a sayısı 5'den küçük veya eşittir.");
            }
            Console.WriteLine("Program Sonlandı");
            Console.ReadKey();
        }
```

**Ekran Çıktısı**
```
a sayısı 5'den büyüktür.
Program Sonlandı
```
#### Örnek ####

```csharp
static void Main(string[] args)
        {
            int c = 10;
             //Eğer aşağıdaki şart doğru ise if'in altındaki kod bloğu,yanlış ise else'nin altındaki kod bloğu çalışır.
            if (c < 5)
            {
                Console.WriteLine("c sayısı 5'den küçüktür.");
            }
            else
            {
                Console.WriteLine("c sayısı 5'den büyük veya eşittir.");
            }
            Console.WriteLine("Program Sonlandı..");
            Console.ReadKey();
        }
```

**Ekran Çıktısı**
```
c sayısı 5'den büyük veya eşittir.
Program Sonlandı..

```
### 3. else-if Yapısı ###
> Genel Kullanım
```csharp
if (şart1)
{
  // şart1 doğru olduğunda bu kod bloğu çalışır.
}
else if (şart2)
{
 // şart2 doğru olduğunda bu kod bloğu çalışır.
}
else if (şart3)
{
 // şart3 doğru olduğunda bu kod bloğu çalışır.
}
else
{
 // Tüm şartlar yanlış olduğunda bu kod bloğu çalışır.
}
```
