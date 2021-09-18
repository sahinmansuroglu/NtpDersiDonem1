## Döngü yapıları ##
> Genel olarak  döngüler belirli bir kod bloğunu belirlenen koşul doğru olduğu sürece çalıştırmaya yarayan yapılardır.
> Özellikle bir birini tekrar eden kodların bulunduğu durumlarda döngü yapıları daha az kod yazmamıza olanak sağlar

> C#'da kullanılabilecek  döngü yapıları
1. while döngüsü
2. do-while döngüsü
3. for döngüsü

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
}while (şart);
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


> **Not:** Do-while ve While Döngüleri özellikle tekrar edecek kodun  ` __kaç kez tekrar edeceği bilinmediği__` durumlarda kullanılır.
> Yukarıdaki örnekte dikkat edilirse döngünün kaç kez döneceği bilinmediğinden do-while döngüsü tercih edilmiştir.

### 3. For döngüsü ###

För döngüsü tekrar edecek kodun  `kaç kez tekrar edeceği bilindiği` durumlarda kullanılır.
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
