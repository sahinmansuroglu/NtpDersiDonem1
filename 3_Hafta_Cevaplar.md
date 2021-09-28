### Soru-1 ###
> Klavyeden girilen 3 notun ortalamasına göre Eğer 50'den küçükse ekrana "Kaldı" büyük veya eşitse "Geçti" yazdıran programı if-else yapısını kullanarak tasarlayınız.

```csharp
static void Main(string[] args)
        {
            byte puan1, puan2, puan3;
            Console.Write("1. puanı gir:");
            puan1 = Convert.ToByte(Console.ReadLine());
            Console.Write("2. puanı gir:");
            puan2 = Convert.ToByte(Console.ReadLine());
            Console.Write("3. puanı gir:");
            puan3 = Convert.ToByte(Console.ReadLine());
            double ortalama = (puan1 + puan2 + puan3) / 3.0;
            Console.WriteLine($"Ortalamanız:{ortalama}");
            if (ortalama < 50)
            {
                Console.WriteLine("Kaldınız");
            }
            else
            {
                Console.WriteLine("Geçtiniz");
            }
            Console.ReadKey();
        }
```

__Ekran Çıktısı__

```
1. puanı gir:65
2. puanı gir:85
3. puanı gir:25
Ortalamanız:58,333333333333336
Geçtiniz
```

### Soru-2 ###
> Klavyeden girilen kullanıcı adı ve şifreye göre doğruysa giriş başarılı yanlışsa giriş başarısız yazdıran prograöı tasarlayınız. (kullanıcı adı Admin şifre de sfr1357 olsun)
```csharp
static void Main(string[] args)
        {
            string kullaniciAdi,kullaniciSifre;

            Console.Write("Lütfen kullanıcı adınızı giriniz:");
            kullaniciAdi = Console.ReadLine();

            Console.Write("Lütfen kullanıcı şifrenizi giriniz:");
            kullaniciSifre = Console.ReadLine();

            if (kullaniciAdi=="Admin" && kullaniciSifre== "sfr1357")
            {
                Console.WriteLine("Giriş Başarılı");
            }
            else
            {
                Console.WriteLine("Yanlış kullanıcı adı veya şifre");
            }

            Console.ReadKey();
        }
```
__Ekran Çıktıları__
```
Lütfen kullanıcı adınızı giriniz:Şahin
Lütfen kullanıcı şifrenizi giriniz:1234
Yanlış kullanıcı adı veya şifre
```

```
Lütfen kullanıcı adınızı giriniz:Admin
Lütfen kullanıcı şifrenizi giriniz:sfr1357
Giriş Başarılı
```

### Soru-3 ###
> Klavyeden girilen 2 sayı ve işleme göre hesaplama yaptıran programı tasarlayınız (4 işlemden hangisi girilirse ona göre hesaplama yapılacak). (if - else if - else yapısı kullanılacak) 

**Örnek Çıktı**
```
1. Sayıyı Giriniz:25
2. Sayıyı Giriniz:32
İşlem  giriniz(+, -, *, /):+
Sonuç=57
```


```csharp
 static void Main(string[] args)
        {
            Console.Write("1. Sayıyı giriniz:");
            int sayi1= Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İşlem giriniz(+,-,*,/) :");
            char islem = Console.ReadLine()[0];
            double sonuc=0;
            
            if (islem == '+')
            {
                sonuc = sayi1+sayi2;
            }
            else if (islem == '-')
            {
                sonuc = sayi1 - sayi2;
            }
            else if (islem == '*')
            {
                sonuc = sayi1 * sayi2;
            }
            else if (islem == '/')
            {
                sonuc = (double)sayi1 / sayi2;
            }
            else
            {
                Console.WriteLine("Hatalı işlem girdiniz....");
            }
            Console.WriteLine($"sonuç={sonuc}");
            Console.ReadKey();
        }
 
```

**Farklı veri girişlerine göre Ekran Çıktıları**
```
1. Sayıyı giriniz:65
2. Sayıyı giriniz:13
İşlem giriniz(+,-,*,/) :/
sonuç=5
```

```
1. Sayıyı giriniz:45
2. Sayıyı giriniz:25
İşlem giriniz(+,-,*,/) :+
sonuç=70
```
 


### Soru-4 ###
> 3. Sorunun aynısını switch case yapısını kullanarak tasarlayınız.
```csharp
 static void Main(string[] args)
        {
            Console.Write("1. Sayıyı giriniz:");
            int sayi1= Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İşlem giriniz(+,-,*,/) :");
            char islem = Console.ReadLine()[0];
            double sonuc=0;
            
            switch (islem)
            {
                case '+':
                    sonuc = sayi1+sayi2;
                    break;
                case '-':
                    sonuc = sayi1 - sayi2;
                    break;
                case '*':
                    sonuc = sayi1 * sayi2;
                    break;
                case '/':
                    sonuc = (double)sayi1 / sayi2;
                    break;
                default:
                    Console.WriteLine("Hatalı işlem girdiniz....");
                    break;
            }

            Console.WriteLine($"sonuç={sonuc}");
            Console.ReadKey();
        }
 
```
### Soru-5 ###
> Klavyeden girilen 3 sayıyı büyükten küçüğe sıralayan programı tasarlayınız.

```csharp
static void Main(string[] args)
        {
            Console.Write("1. Sayıyı Giriniz:");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz:");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. Sayıyı Giriniz:");
            int s3 = Convert.ToInt32(Console.ReadLine());
            int gecici;

            if (s1 < s2)
            {
                gecici = s1;
                s1 = s2;
                s2 = gecici;
            }
            if (s1 < s3)
            {
                gecici = s1;
                s1 = s3;
                s3 = gecici;
            }
            if (s2 < s3)
            {
                gecici = s2;
                s2 = s3;
                s3 = gecici;
            }

            Console.WriteLine($"Büyükten Küçüğe: {s1}  {s2}  {s3}");
            Console.WriteLine("Program Sonlandı");
            Console.ReadKey();
        }
```

**Ekran Çıktısı**
```

```
### Soru-6 ###
>  Aşağıdaki çıktıyı veren programı tasarlayınız  (Uygulamayı Hem for hem while hem de do-while döngüsü ile tasarlayınız.)(3 Farklı Program olacak)

1 2 3 4 5 6 7 8 9 10 11 12


```csharp
static void Main(string[] args)
        {
            Console.WriteLine("*** For Döngüsü İle ***");
            for (int i = 1; i <= 12; i++)
            {
                Console.Write($"{i} ");
            }
            
            Console.WriteLine(" \n\n *** While Döngüsü İle ***");
            int sayac = 1;
            while (sayac <= 12)
            {
                Console.Write($"{sayac} ");
                sayac++;
            }

            Console.WriteLine(" \n\n ***Do - While Döngüsü İle ***");
             sayac = 1;
            do
            {
                Console.Write($"{sayac} ");
                sayac++;
            }while (sayac <= 12) ;

            Console.WriteLine(" \n\n Program Sonlandı..");
            Console.ReadKey();
        }
```

**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/135034178-e65a2f50-369f-46ac-87b7-68106da11c68.png)


### Soru-7 ###
>  Aşağıdaki çıktıyı veren programı tasarlayınız (Döngü yapıları kullanılacak)

1 2 3 4 5 8 9 10 11 12


```csharp
static void Main(string[] args)
        {
          
            for (int i = 1; i <= 12; i++)
            {
                if (i==7 || i==8)
                {
                    continue;
                }
                Console.Write($"{i} ");
            }
            
           
            Console.WriteLine(" \n\n Program Sonlandı..");
            Console.ReadKey();
        }

```

**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/135037264-e5d800a3-5a7b-499c-aa7e-9570af6ba51f.png)


### Soru-8 ###
>  Aşağıdaki çıktıyı veren programı tasarlayınız (Döngü yapıları kullanılacak)

12 11 10 9 8 7 6 5 4 3 2 1


```csharp
static void Main(string[] args)
        {
          
            for (int i = 12; i >=1; i--)
            {
                
                Console.Write($"{i} ");
            }
            
           
            Console.WriteLine(" \n\n Program Sonlandı..");
            Console.ReadKey();
        }
```

**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/135037422-368be9bc-2ebd-4b28-ac47-19b80ecb57bf.png)


### Soru-9 ###
>  Aşağıdaki çıktıyı veren programı tasarlayınız (Döngü yapıları kullanılacak)

12 11 10 9 6 5 4 3 2 1


```csharp

 static void Main(string[] args)
        {
          
            for (int i = 12; i >=1; i--)
            {
                if (i == 7 || i == 8)
                {
                    continue;
                }

                Console.Write($"{i} ");
            }
            
           
            Console.WriteLine(" \n\n Program Sonlandı..");
            Console.ReadKey();
        }
```

**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/135037559-8b902bd2-4705-48d4-bb4e-155978a3be09.png)



### Soru-10 ###
>  Aşağıdaki çıktıyı veren programı tasarlayınız (Döngü yapıları kullanılacak)

12 10 8  6  4  2 0

**1. Yol**
```csharp
static void Main(string[] args)
        {
          
            for (int i = 12; i >=0; i-=2)
            {
                Console.Write($"{i} ");
            }
            
           
            Console.WriteLine(" \n\n Program Sonlandı..");
            Console.ReadKey();
        }
```

**2. Yol**

```csharp
static void Main(string[] args)
        {
          
            for (int i = 12; i >=0; i--)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            
           
            Console.WriteLine(" \n\n Program Sonlandı..");
            Console.ReadKey();
        }
```

**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/135037675-bf3f296a-5360-4e27-9510-6ced669ff4b0.png)


### Soru-11 ###
>  Aşağıdaki çıktıyı veren programı tasarlayınız (Döngü yapıları kullanılacak)

3 6 9 12 15 18 21 24 27 30

**1. Yol**
```csharp
static void Main(string[] args)
        {
          
            for (int i = 3; i<=30; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            
           
            Console.WriteLine(" \n\n Program Sonlandı..");
            Console.ReadKey();
        }
```


**2. Yol**

```csharp
static void Main(string[] args)
        {
          
            for (int i = 3; i<=30; i+=3)
            {
              
                    Console.Write($"{i} ");
              
            }
            
           
            Console.WriteLine(" \n\n Program Sonlandı..");
            Console.ReadKey();
        }
```

**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/135037975-23a55a83-19c1-4514-9c6b-2301be5900cc.png)



### Soru-12 ###
>  10 ile 20 arasındaki sayıların toplamını hesaplatınız. (Döngü yapıları kullanılacak)


```csharp
static void Main(string[] args)
        {

            int toplam = 0;
            for (int i = 10; i<=20; i++)
            {

                toplam = toplam + i;
              
            }

            Console.WriteLine($"10 ile 20 arasındaki sayıların toplamı:{toplam }");
            Console.WriteLine(" \n\n Program Sonlandı..");
            Console.ReadKey();
        }
```

**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/135038795-44d8fcd8-77e8-4d40-a568-01e16d1e72d6.png)



### Soru-13 ###
>  Döngü yardımıyla kullanıcının sürekli  sayı girmesini sağlayınız. Ne zaman 0 sayısını girerse döngüyü sonlandırıp girdiği sayı adedini ekrana yazdırınız


```csharp

```

**Ekran Çıktısı**
```


### Soru-14 ###
>  Döngü yardımıyla kullanıcının sürekli  sayı girmesini sağlayınız. Ne zaman 0 sayısını girerse döngüyü sonlandırıp girdiği sayıların ortalamasını hesaplatınız.


```csharp
 static void Main(string[] args)
        {

            int girilenSayi;
            int toplam = 0;
            int sayac = 0;
            while (true)
            {

                Console.Write($" {sayac + 1}. Sayıyı Giriniz:");
                girilenSayi = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + girilenSayi;
                if (girilenSayi == 0)
                {
                    double ortalama = (double)toplam / sayac;
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

![image](https://user-images.githubusercontent.com/28144917/135039036-1d44288f-05e0-4c12-9d51-22596d500a0c.png)


### Soru-15 ###
> Aşağıdaki gibi bir menü sistemini console ekranında while Döngüsünü ve switch case yapısını kullanarak tasarlayınız 

![image](https://user-images.githubusercontent.com/28144917/134159505-077f2260-2da3-4f41-a9b4-9a6bc012e5e7.png)



```csharp

```

**Ekran Çıktısı**
```
