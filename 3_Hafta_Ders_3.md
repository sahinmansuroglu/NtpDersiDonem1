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
                
                if(girilenSayi%2==0)
                {
                    Console.WriteLine($" {girilenSayi} sayisi çift sayıdır.");
                }
                else
                {
                    Console.WriteLine($" {girilenSayi} sayisi tek sayıdır.");
                }
                if (girilenSayi < 0)
                {
                    Console.WriteLine("Program Sonlandırıldı.");
                    break;
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
            int toplam = 0;
            int sayac = 0;
            while (true)
            {
                
                Console.Write($" {sayac+1}. Sayıyı Giriniz:");
                girilenSayi = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + girilenSayi;
                if (girilenSayi == 0)
                {
                    double ortalama =(double)toplam / sayac;
                    Console.WriteLine($"Sayi Adedi:{sayac}");
                    Console.WriteLine($"Toplam:{toplam}");
                    Console.WriteLine($"Ortalama:{ortalama}");
                    Console.WriteLine("Program Sonlandırıldı..");
                    break;
                }
                else
                {
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
> Aşağıdaki gibi bir menü oluşturarak kullanıcının isteğine uygun işlemleri yapan uygulamayı tasarlayınız


```
Yapılacak İşlemler
A) 2 Sayıyı Topla
B) 2 Sayının Ortalaması hesapla
C) 2 Sayıdan büyük olanı bul
D) 1 Sayının karesini bul
E) Çıkış
Seçiminiz(A, B, C, D, E)==>A
```

__Program Kodu__
```csharp
   static void Main(string[] args)
        {

            int sayi1, sayi2,toplam;

            double ortalama;
            char secim;
            do
            {
                Console.WriteLine("Yapılacak İşlemler");
                Console.WriteLine("A) 2 Sayıyı Topla");
                Console.WriteLine("B) 2 Sayının Ortalaması hesapla");
                Console.WriteLine("C) 2 Sayıdan büyük olanı bul");
                Console.WriteLine("D) 1 Sayının karesini bul");
                Console.WriteLine("E) Çıkış");
                Console.Write("Seçiminiz(A, B, C, D, E)==>");
                secim = Console.ReadLine()[0];
                switch (secim)
                {
                    case 'A':
                        Console.Write("1. Sayıyı Giriniz:");
                        sayi1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("2. Sayıyı Giriniz:");
                        sayi2 = Convert.ToInt32(Console.ReadLine());
                        toplam = sayi1 + sayi2;
                        Console.WriteLine($"{sayi1} ve {sayi2} sayısının toplamı:{toplam} ");
                        Console.ReadKey();
                        break;
                    case 'B':
                        Console.Write("1. Sayıyı Giriniz:");
                        sayi1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("2. Sayıyı Giriniz:");
                        sayi2 = Convert.ToInt32(Console.ReadLine());
                        ortalama = (sayi1 + sayi2) / 2.0;
                        Console.WriteLine($"{sayi1} ve {sayi2} sayısının ortalaması:{ortalama} ");
                        Console.ReadKey();
                        break;
                    case 'C':
                        Console.Write("1. Sayıyı Giriniz:");
                        sayi1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("2. Sayıyı Giriniz:");
                        sayi2 = Convert.ToInt32(Console.ReadLine());
                        if (sayi1 > sayi2)
                        {
                            Console.WriteLine("1. Sayı daha büyük");
                        }
                        else if (sayi2 > sayi1)
                        {
                            Console.WriteLine("2. Sayı daha büyük");
                        }
                        else
                        {
                            Console.WriteLine("Sayılar birbirine eşittir.");
                        }
                        Console.ReadKey();
                        break;
                    case 'D':
                        Console.Write("Bir Sayı Giriniz:");
                        sayi1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine($"{sayi1} sayısının karesi: {sayi1 * sayi1}");
                        Console.ReadKey();
                        break;
                    default:
                        break;
                }
            }while (secim != 'E') ;

            Console.WriteLine("Program Sonlandırıldı..");
            
            
            
        }         
```

**Ekran Çıktısı**
```
Yapılacak İşlemler
A) 2 Sayıyı Topla
B) 2 Sayının Ortalaması hesapla
C) 2 Sayıdan büyük olanı bul
D) 1 Sayının karesini bul
E) Çıkış
Seçiminiz(A, B, C, D, E)==>A
1. Sayıyı Giriniz:25
2. Sayıyı Giriniz:65
25 ve 65 sayısının toplamı:90
Yapılacak İşlemler
A) 2 Sayıyı Topla
B) 2 Sayının Ortalaması hesapla
C) 2 Sayıdan büyük olanı bul
D) 1 Sayının karesini bul
E) Çıkış
Seçiminiz(A, B, C, D, E)==>C
1. Sayıyı Giriniz:65
2. Sayıyı Giriniz:85
2. Sayı daha büyük
Yapılacak İşlemler
A) 2 Sayıyı Topla
B) 2 Sayının Ortalaması hesapla
C) 2 Sayıdan büyük olanı bul
D) 1 Sayının karesini bul
E) Çıkış
Seçiminiz(A, B, C, D, E)==>D
Bir Sayı Giriniz:12
12 sayısının karesi: 144
Yapılacak İşlemler
A) 2 Sayıyı Topla
B) 2 Sayının Ortalaması hesapla
C) 2 Sayıdan büyük olanı bul
D) 1 Sayının karesini bul
E) Çıkış
Seçiminiz(A, B, C, D, E)==>E
Program Sonlandırıldı..
```
