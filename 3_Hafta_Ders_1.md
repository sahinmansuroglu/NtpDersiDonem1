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
#### Örnek ####
Aşağıdaki uygulamada plakaKodu değiştikçe programın çalışma akışı da değişecektir.
```csharp
static void Main(string[] args)
        {
            byte plakaKodu=27;
            if (plakaKodu == 33)
            {
                Console.WriteLine("Mersin");
            }
            else if (plakaKodu == 27)
            {
                Console.WriteLine("Gaziantep");
            }
            else if (plakaKodu == 55)
            {
                Console.WriteLine("Samsun");
            }
            else
            {
                Console.WriteLine("Plaka kodu Mersin,Gaziantep ve Samsun'a ait değil ");
            }
            Console.WriteLine("Program Sonlandı..");
            Console.ReadKey();
        }
```

**Ekran Çıktısı**
```
Gaziantep
Program Sonlandı..

```
#### Örnek ####
Klavyeden girilen puanın not karşılığını bulan program
```csharp
static void Main(string[] args)
        {
            Console.Write("Puanınızı Giriniz:");
            byte puan=Convert.ToByte(Console.ReadLine());

            if (puan >= 85 && puan <= 100)
            {
                Console.WriteLine("Notunuz:5");
            }
            else if (puan>=70 && puan<85)
            {
                Console.WriteLine("Notunuz:4");
            }
            else if (puan >= 60 && puan < 70)
            {
                Console.WriteLine("Notunuz:3");
            }
            else if (puan >= 50 && puan < 60)
            {
                Console.WriteLine("Notunuz:2");
            }
            else if (puan >= 0 && puan < 50)
            {
                Console.WriteLine("Notunuz:1");
            }
            else
            {
                Console.WriteLine("Geçersiz Puan");
            }
            Console.WriteLine("Program Sonlandı..");
            Console.ReadKey();
        }
```

**Örnek Ekran Çıktıları**

```
Puanınızı Giriniz:63
Notunuz:3
Program Sonlandı..
```

```
Puanınızı Giriniz:76
Notunuz:4
Program Sonlandı..
```

```
Puanınızı Giriniz:45
Notunuz:1
Program Sonlandı..
```

### 4. Switch-Case Yapısı ###
> Switch case yapısı bir değişkenin değerini bir çok farklı durum için kontrol etmek istediğimiz zaman kullanılırız.

> Genel Kullanım
```csharp
  switch (değişken){
    case değer1:
      //değişkenin değeri değer1'e eşit olduğunda yapılacak işlemler
      break;
    case değer2:
      //değişkenin değeri değer2'e eşit olduğunda yapılacak işlemler;
      break;
    case değer3:
      //değişkenin değeri değer3'e eşit olduğunda yapılacak işlemler;
      break;
    ...
    default:
      //değişken yukarıdaki değerlerden herhangi birine eşit olmadığında yapılacak işlemler;
      break;
  }
```

#### Örnek ####

```csharp
 static void Main(string[] args)
        {
            Console.Write("1-5 Arası notunuzu giriniz:");
            byte ogrNotu= Convert.ToByte(Console.ReadLine());
            string notAciklama;
            switch (ogrNotu)
            {
                case 1:
                    notAciklama = "Başarısız";
                    break;
                case 2:
                    notAciklama = "Geçer";
                    break;
                case 3:
                    notAciklama = "Orta";
                    break;
                case 4:
                    notAciklama = "İyi";
                    break;
                case 5:
                    notAciklama = "Pekiyi";
                    break;
                default:
                    notAciklama = "Geçersiz Not!!!";
                    break;
            }

            Console.WriteLine(notAciklama);
            Console.ReadKey();
    }
 
```

**Farklı veri girişlerine göre Ekran Çıktıları**
```
1-5 Arası notunuzu giriniz:4↵
İyi
```

```
1-5 Arası notunuzu giriniz:2↵
Geçer
```

```
1-5 Arası notunuzu giriniz:10↵
Geçersiz Not!!!
```
#### Örnek ####
> Klavyeden girilen 2 sayı ve işlem (+, - , *, / )'e göre hesaplama yapan  uygulama tasarımı. (hem if-else if hem de switch case yapısı ile ayrı ayrı yapılacak)


**Switch-Case yapısı ile Çözüm**
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

**if-else if yapısı ile Çözüm**
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
 
