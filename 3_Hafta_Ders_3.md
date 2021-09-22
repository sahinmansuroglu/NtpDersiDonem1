## Döngülerde Break ve Continue Kullanımı ##

### Break ### 
> Döngülerde döngü sonunda gelmeden döngüyü sonlandırmak istediğimizde `break` komutunu kullanırız.

#### Örnek-1 ####

Aşağıdaki programda i'nin değeri 6 olduğunda break komutu çalışacağı için döngü sonlanacak ve sadece 1'den  5'e kadar olan sayıları ekrana yazdıracaktır. 

```csharp
            for (int i = 1; i < 10; i++)
            {
                if (i == 6)
                {
                    break;
                }
                Console.Write($"{i} ");
            }
            Console.ReadKey();
```

**Ekran Çıktısı**
```
1 2 3 4 5 
```

### Continue ### 
> Döngülerin bazı adımlarında o adımın atlanıp diğer adıma geçmesi istenebilir. Bu durumlarda Continue komutu kullanılır

#### Örnek-2 ####

> Aşağıdaki programda i'nin değeri 6 olduğunda continue  komutu çalışacağı için kendinden sonraki kodları çalıştırmayıp bir sonraki adıma geçecektir. bundan dolayı 6 sayısını yazmayacaktır.

```csharp
            for (int i = 1; i < 10; i++)
            {
                if (i == 6)
                {
                    continue;
                }
                Console.Write($"{i} ");
            }
            Console.ReadKey();
```

**Ekran Çıktısı**
```
1 2 3 4 5 7 8 9
```

#### Örnek-3 ####

Sonsuz bir while döngü oluşturunuz. Bu sonsuz döngü içerisinde kullanıcıdan  her seferinde 1 sayı girmesini isteyiniz. Bu sayının tek mi? çift mi? olduğunu bulup ekrana yazdırınız. Bu işlem  kullanıcı negatif bir sayı girene kadar devam etsin. Negatif bir sayı girildiği an döngü break ile kırılarak program sonladırılsın.

```csharp
     
     static void Main(string[] args)
        {
            int girilenSayi;

            while (true)
            {
                Console.Write("Sayi Giriniz: ");

                girilenSayi = Convert.ToInt32(Console.ReadLine());
                if (girilenSayi < 0)
                {
                    Console.WriteLine("Program Sonlandırıldı.");
                    break;
                }
                if(girilenSayi%2==0)
                {
                    Console.WriteLine($" {girilenSayi} sayisi çift sayıdır.");
                }
                else
                {
                    Console.WriteLine($" {girilenSayi} sayisi tek sayıdır.");
                }
            }
            
            Console.ReadKey();
        }
```

**Ekran Çıktısı**

```
Sayi Giriniz: 95
 95 sayisi tek sayıdır.
Sayi Giriniz: 65
 65 sayisi tek sayıdır.
Sayi Giriniz: 32
 32 sayisi çift sayıdır.
Sayi Giriniz: 14
 14 sayisi çift sayıdır.
Sayi Giriniz: 0
 0 sayisi çift sayıdır.
Sayi Giriniz: -5
Program Sonlandırıldı.
```

#### Örnek-4 ####



```csharp
           
```

**Ekran Çıktısı**
```

```

#### Örnek-5 ####


```csharp
           
```

**Ekran Çıktısı**
```

```
