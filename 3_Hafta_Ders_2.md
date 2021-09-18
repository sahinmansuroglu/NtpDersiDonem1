## Döngü yapıları ##
> Genel olarak  döngüler belirli bir kod bloğunu belirlenen koşul doğru olduğu sürece çalıştırmaya yarayan yapılardır.
> Özellikle bir birini tekrar eden kodların bulunduğu durumlarda döngü yapıları daha az kod yazmamıza olanak sağlar

> C#'da kullanılabilecek  döngü yapıları
1. while döngüsü
2. do-while döngüsü
3. for döngüsü
4. foreach döngüsü(Diziler-listeler konusuna geçildiğinde anlatılacak)

### 1. while döngüsü ###
> Genel Kullanım
```csharp
while (şart)
{
  // şart doğru olduğu sürece bu kod bloğu sürekli tekrar eder.
  // burada veri işleme, arttırma veya azaltma işlemi yapılabilir
}
```

#### Örnek ####

```csharp
            int i = 1;
            while (i < 10)
            {
                Console.Write($"{i} ");
                i++;
            }
            Console.ReadKey();
```

**Ekran Çıktısı**
```
1 2 3 4 5 6 7 8 9
```
#### Örnek ####
```csharp
            int i = 10;
            while (i > 0)
            {
                Console.Write($"{i} ");
                i--;
            }
            Console.ReadKey();
```

**Ekran Çıktısı**
```
10 9 8 7 6 5 4 3 2 1
```

### 2.Do-while döngüsü ###


> Genel Kullanım
```csharp
do
{
  // şart doğru olduğu sürece bu kod bloğu sürekli tekrar eder.
  // While Döngüsünden farkı başlangıçta şart yanlış bile olsa bu blok en az 1 kere çalışır. Çünkü şart sonda kontrol edilmektedir.
  //  burada veri işleme, arttırma veya azaltma işlemi yapılabilir
} while (şart);
```

#### Örnek ####

```csharp
            int i = 1;
            do
            {
                Console.Write($"{i} ");
                i++;
            } while (i < 10);
            Console.ReadKey();
```

**Ekran Çıktısı**
```
1 2 3 4 5 6 7 8 9
```
#### Örnek ####
```csharp
            int i = 10;
            do
            {
                Console.Write($"{i} ");
                i--;
            } while (i > 0);
            Console.ReadKey();
```

**Ekran Çıktısı**
```
10 9 8 7 6 5 4 3 2 1
```

#### Örnek ####
> Kullanıcıdan sürekli bir sayı girmesi istenecek ve her sayıyı girip enter'a bastıktan sonra girdiği sayının tek mi çift mi olduğu consol ekranında yazdırılacak. Bu işlem kullanıcı 0 sayısını girene kadar sürekli tekrar edecek. 0 sayısını girdiği an döngü sonlandıralacaktır.


```csharp
            static void Main(string[] args)
        {
            int girilenSayi;
            do
            {
                Console.Write("Sayi Giriniz:");
                girilenSayi = Convert.ToInt32(Console.ReadLine());
                if (girilenSayi % 2 == 0)
                {
                    Console.WriteLine("Girilen Sayı Çift");
                }
                else
                {
                    Console.WriteLine("Girilen Sayı Tek");
                }
                
            } while (girilenSayi!=0);

            Console.WriteLine("Program Sonlandı.");
            Console.ReadKey();
        }
```

**Ekran Çıktısı**
```
Sayi Giriniz:45
Girilen Sayı Tek
Sayi Giriniz:23
Girilen Sayı Tek
Sayi Giriniz:34
Girilen Sayı Çift
Sayi Giriniz:56
Girilen Sayı Çift
Sayi Giriniz:0
Girilen Sayı Çift
Program Sonlandı.
```


> **Not:** Do-while ve While Döngüleri özellikle tekrar edecek kodun  ` kaç kez tekrar edeceği bilinmediği` durumlarda kullanılır.
> Yukarıdaki örnekte dikkat edilirse döngünün kaç kez döneceği bilinmediğinden do-while döngüsü tercih edilmiştir.

### 3. For döngüsü ###

För döngüsü tekrar edecek kodun  `kaç kez tekrar edeceği bilindiği` durumlarda kullanılır.

> Genel Kullanım
```csharp
for (başlangıç;şart;adım)
{
  // şart doğru olduğu sürece bu kod bloğu sürekli tekrar eder.
  
}
```

#### Örnek ####

```csharp
            for (int i = 1; i < 10; i++)
            {
                Console.Write($"{i} ");
            }
            
            Console.ReadKey();
```

**Ekran Çıktısı**
```
1 2 3 4 5 6 7 8 9
```
#### Örnek ####
```csharp
       

            for (int i = 10; i > 0; i--)
            {
                Console.Write($"{i} ");
            }
            
            Console.ReadKey();
        
```

**Ekran Çıktısı**
```
10 9 8 7 6 5 4 3 2 1
```

#### Örnek ####
> 10 ile 30 arasındaki çift sayıları ekrana yazdıran programın tasarımı.

#### Çözüm-1 ####
```csharp
           for (int i = 10; i <= 30; i+=2)
            {
                Console.Write($"{i} ");
            }
            
            Console.ReadKey();
```


#### Çözüm-2 ####
```csharp
           for (int i = 10; i <= 30; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.ReadKey();
```

**Ekran Çıktısı**
```
10 12 14 16 18 20 22 24 26 28 30
```

#### Örnek ####
> 1 den 10'a kadar olan sayıların toplamını hesaplayan program tasarımı


```csharp
            int toplam = 0;
            for (int i = 1; i <=10; i++)
            {
                toplam = toplam + i; // toplam += i
            }
            Console.WriteLine($"1. ile 10 arasındaki sayıların toplamı:{toplam} ");
            Console.ReadKey();
```




**Ekran Çıktısı**
```
1. ile 10 arasındaki sayıların toplamı:55
```

#### Örnek ####
> Klavyeden girilen 10 sayının toplamını hesaplayan program tasarımı


```csharp
            int toplam = 0;
            int girilenSayi;
            for (int i = 1; i <=6; i++)
            {
                Console.Write($"{i}. sayıyı Giriniz:");
                girilenSayi = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + girilenSayi; // toplam += girilenSayi
            }
            Console.WriteLine($"Girilen 6 altı sayının toplamı:{toplam} ");
            Console.ReadKey();
```


**Ekran Çıktısı**
```
1. sayıyı Giriniz:45
2. sayıyı Giriniz:65
3. sayıyı Giriniz:77
4. sayıyı Giriniz:23
5. sayıyı Giriniz:34
6. sayıyı Giriniz:54
Girilen 6 altı sayının toplamı:298
```
****

#### Örnek ####
> 8 sayısının faktöriyelini hesaplayan program tasarımı. (8!=8x7x6x5x4x3x2x1)


```csharp
            int fakt = 1;
            
            for (int i = 1; i <=8; i++)
            {
                fakt = fakt * i;  //fakt*=i;
            }
            Console.WriteLine($"8!={fakt} ");
            Console.ReadKey();
```


**Ekran Çıktısı**
```
8!=40320
```
****
