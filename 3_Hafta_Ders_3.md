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

> Sonsuz bir while döngü oluşturunuz. Bu sonsuz döngü içerisinde kullanıcıdan  her seferinde 1 sayı girmesini isteyiniz. Bu sayının tek mi? çift mi? olduğunu bulup ekrana yazdırınız. Bu işlem  kullanıcı negatif bir sayı girene kadar devam etsin. Negatif bir sayı girildiği an döngü break ile kırılarak program sonladırılsın.

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

> Sonsuz bir while döngü oluşturunuz. Bu sonsuz döngü içerisinde kullanıcıdan  her seferinde 1 sayı girmesini isteyiniz. Girilen sayının kaç tane olduğunu, toplamını ve ortalamasını hesaplatınız. Bu işlem  kullanıcı 0 syısını girene kadar devam etsin. 0 sayısı girildiği an döngü break ile kırılarak  hesaplatılan bilgiler ekranda gösterilerek program sonladırılsın.


```csharp
 
 static void Main(string[] args)
        {
            int girilenSayi;
            int sayac = 1;
            int toplam = 0;

            while (true)
            {
                Console.Write($"{sayac}. Sayıyı Giriniz: ");

                girilenSayi = Convert.ToInt32(Console.ReadLine());
                if (girilenSayi == 0)
                {
                    // son girilen 0 sayısı dahil olmaması için sayacı bir azalttık
                    sayac--;
                    double ortalama =(double) toplam / sayac;
                    Console.WriteLine($"{sayac} tane sayının toplamı:{toplam}");
                    // #.## ifadesi virgülden sonra 2 basamak alınabilmesi içindir.
                    Console.WriteLine($"{sayac} tane sayının ortalaması:{ortalama:#.##}"); 
                    Console.WriteLine("Program Sonlandırıldı.");
                    break;
                }
                else
                {
                    toplam = toplam + girilenSayi;
                    sayac++;
                }
            }
            
            Console.ReadKey();
        }
```

**Ekran Çıktısı**
```
1. Sayıyı Giriniz: 65
2. Sayıyı Giriniz: 25
3. Sayıyı Giriniz: 36
4. Sayıyı Giriniz: 35
5. Sayıyı Giriniz: 85
6. Sayıyı Giriniz: 14
7. Sayıyı Giriniz: 87
8. Sayıyı Giriniz: 0
7 tane sayının toplamı:347
7 tane sayının ortalaması:49,57
Program Sonlandırıldı.
```

#### Örnek-5 ####


```csharp
           
```

**Ekran Çıktısı**
```

```
