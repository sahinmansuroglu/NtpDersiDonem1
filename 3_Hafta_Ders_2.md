## Döngü yapıları ##
> Genel olarak  döngüler belirli bir kod bloğunu belirlenen koşul doğru olduğu sürece çalıştırmaya yarayan yapılardır.

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

