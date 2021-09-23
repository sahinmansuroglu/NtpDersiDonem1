### Soru-1
  int, float, double ,short veri tiplerinin minimum, maximum, varsayılan değerlerini ve bellekte kaç byte yer kapladıklarını ekrana yazdıran programı tasarlayınız.
  ```csharp
  
static void Main(string[] args)
        {

            sbyte maxSbyte = sbyte.MaxValue;
            sbyte minSbyte = sbyte.MinValue;
            sbyte varsayılanSbyte = default(sbyte);
            Console.WriteLine("sbyte veri tipinin değer aralığı:");
            Console.WriteLine($"{minSbyte} .. {maxSbyte}  ");
            Console.WriteLine($"varsayılan değeri:{varsayılanSbyte}");
            Console.WriteLine($"Bellekte kapıldığı alan: {sizeof(sbyte)} Byte");
            Console.WriteLine("________________________________________________");
                       
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            int varsayılanInt = default(int);
            Console.WriteLine("int veri tipinin değer aralığı:");
            Console.WriteLine($"{minInt} .. {maxInt}  ");
            Console.WriteLine($"varsayılan değeri:{varsayılanInt}");
            Console.WriteLine($"Bellekte kapıldığı alan: {sizeof(int)} Byte");
            Console.WriteLine("________________________________________________");

            float maxFloat = float.MaxValue;
            float minFloat = float.MinValue;
            float varsayılanFloat = default(float);
            Console.WriteLine("float veri tipinin değer aralığı:");
            Console.WriteLine($"{minFloat} .. {maxFloat}  ");
            Console.WriteLine($"varsayılan değeri:{varsayılanFloat}");
            Console.WriteLine($"Bellekte kapıldığı alan: {sizeof(float)} Byte");
            Console.WriteLine("________________________________________________");
                        
            double max_double = double.MaxValue;
            double min_double = double.MinValue;
            double varsayılan_double = default(double);
            Console.WriteLine("double veri tipinin değer aralığı:");
            Console.WriteLine($"{min_double} .. {max_double}  ");
            Console.WriteLine($"varsayılan değeri:{varsayılan_double}");
            Console.WriteLine($"Bellekte kapıldığı alan: {sizeof(double)} Byte");
            Console.WriteLine("________________________________________________");

            short max_short = short.MaxValue;
            short min_short = short.MinValue;
            short varsayılan_short = default(short);
            Console.WriteLine("short veri tipinin değer aralığı:");
            Console.WriteLine($"{min_short} .. {max_short}  ");
            Console.WriteLine($"varsayılan değeri:{varsayılan_short}");
            Console.WriteLine($"Bellekte kapıldığı alan: {sizeof(short)} Byte");
            Console.WriteLine("________________________________________________");

            Console.ReadKey();
        }
  ```
  
  **Ekran Çıktısı**
  ```
  sbyte veri tipinin değer aralığı:
-128 .. 127
varsayılan değeri:0
Bellekte kapıldığı alan: 1 Byte
________________________________________________
int veri tipinin değer aralığı:
-2147483648 .. 2147483647
varsayılan değeri:0
Bellekte kapıldığı alan: 4 Byte
________________________________________________
float veri tipinin değer aralığı:
-3,4028235E+38 .. 3,4028235E+38
varsayılan değeri:0
Bellekte kapıldığı alan: 4 Byte
________________________________________________
double veri tipinin değer aralığı:
-1,7976931348623157E+308 .. 1,7976931348623157E+308
varsayılan değeri:0
Bellekte kapıldığı alan: 8 Byte
________________________________________________
short veri tipinin değer aralığı:
-32768 .. 32767
varsayılan değeri:0
Bellekte kapıldığı alan: 2 Byte
________________________________________________

```

### Soru-2 ###
> Uzun ve kısa kenar uzunluğu verilen dikdörtgenin çevresini ve alanını hesalayıp ekrana yazan programı tasarlayınız.

```csharp
static void Main(string[] args)
        {
            int kısaKenar, uzunKenar,alan, cevre;
            Console.Write("Kısa Kenarı giriniz:");
            kısaKenar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Uzun Kenarı  giriniz:");
            uzunKenar = Convert.ToInt32(Console.ReadLine());
            cevre = (kısaKenar + uzunKenar) * 2;
            alan = kısaKenar * uzunKenar;
            Console.WriteLine($"alan={alan}");
            Console.WriteLine($"cevre={cevre}");
            Console.ReadKey();
        }
```
**Ekran Çıktısı**
```
Kısa Kenarı giriniz:23
Uzun Kenarı  giriniz:10
alan=230
cevre=66
```
### Soru-3
> Klavyeden girilen 4 puanın ortalamasını bulan programı tasarlayınız

  ```csharp
  static void Main(string[] args)
        {
            byte puan1, puan2, puan3,puan4;
            Console.Write("1. Puanı Giriniz:");
            puan1 = Convert.ToByte(Console.ReadLine());
            Console.Write("2. Puanı Giriniz:");
            puan2 = Convert.ToByte(Console.ReadLine());
            Console.Write("3. Puanı Giriniz:");
            puan3 = Convert.ToByte(Console.ReadLine());
            Console.Write("4. Puanı Giriniz:");
            puan4 = Convert.ToByte(Console.ReadLine());

            double ortalama = (puan1 + puan2 + puan3 + puan4) / 4.0;
            Console.WriteLine($"{puan1}, {puan2}, {puan3} ve {puan4} puanlarının ortalaması {ortalama}'dır. ");
            Console.ReadKey();
      
        }
  
  ```
  
   **Ekran Çıktısı**
  ```
  1. Puanı Giriniz:10
  2. Puanı Giriniz:20
  3. Puanı Giriniz:30
  4. Puanı Giriniz:40
  10, 20, 30 ve 40 puanlarının ortalaması 25'dır.
 ```
### Soru-4 ###
> Bir öğrencinin girdiği sınavlarda yıl sonu puanı hesaplanırken ilk 2 sınavının % 25'i son  sınavının ise % 50'si toplanarak bulunmaktadır. Buna göre 3 sınav puanı klavyeden girilen bir öğrencinin yıl sonu puanını hesaplayınız.
 
```csharp
    static void Main(string[] args)
        {
            byte puan1, puan2, puan3;
            Console.Write("1. Puanı Giriniz:");
            puan1 = Convert.ToByte(Console.ReadLine());
            Console.Write("2. Puanı Giriniz:");
            puan2 = Convert.ToByte(Console.ReadLine());
            Console.Write("3. Puanı Giriniz:");
            puan3 = Convert.ToByte(Console.ReadLine());

            double yilSonuPuani = puan1 * 0.25 + puan2 * 0.25 + puan3 * 0.5 ;
            Console.WriteLine($"Yıl Sonu Puani {yilSonuPuani}'dır. ");
            Console.ReadKey();
            
        }
```

**Ekran Çıktısı**

```
    1. Puanı Giriniz:45
    2. Puanı Giriniz:80
    3. Puanı Giriniz:20
    Yıl Sonu Puani 41,25'dır.
```
### Soru-5
> Klavyeden Girilen bir sayının tek mi çift mi olduğunu ekrana yazdırınız. (% ve ternary oparatörü kullanılacak)

```csharp
static void Main(string[] args)
        {
            Console.Write("Bir sayı Girin: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            string sonuc = sayi%2==0  ? "Çift" : "Tek";
            Console.WriteLine($"Sonuç:{sonuc}");
            Console.ReadKey();
        }
```
    
** Ekran Çıktısı **
```
Bir sayı Girin: 65
Sonuç:Tek
```
    
### Soru-6
  Klavyeden Girilen 2 puanın ortalamasına göre eğer ortalama 50'den küçükse "Kaldı" büyük veya eşitse "Geçti" yazdıran programı tasarlayınız. (ternary oparatörü kullanılacak)

```csharp
static void Main(string[] args)
        {
            Console.Write("1. Puanınızı Girin: ");
            int puan1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("2. Puanınızı Girin: ");
            int puan2 = Convert.ToInt32(Console.ReadLine());

            double ortalama = (puan1 + puan2) / 2.0;
            string sonuc = ortalama < 50 ? "Kaldınız" : "Geçtiniz";
            Console.WriteLine("Ortalamanız: " + ortalama);
            Console.WriteLine($"Sonuç:{sonuc}");

            Console.ReadKey();
        }
```
    
**Ekran Çıktısı**
```
1. Puanınızı Girin: 95
2. Puanınızı Girin: 65
Ortalamanız: 80
Sonuç:Geçtiniz
```
    
### Soru-7
  Klavyeden Girilen 3 sayının en büyüğünü ekrana yazdıran programı tasarlayınız.

```csharp
static void Main(string[] args)
        {
            Console.Write("A sayısını Girin: ");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("B sayısını Girin: ");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.Write("C sayısını Girin: ");
            int C = Convert.ToInt32(Console.ReadLine());
            string sonuc;
            sonuc = A > B && A > C ? "A En Büyük" : B > C ? "B En Büyük" : "C En büyük";
            Console.WriteLine($"Sonuç:{sonuc}");
            Console.ReadKey();
        }
```
    
**Ekran Çıktıları**

```
A sayısını Girin: 95
B sayısını Girin: 25
C sayısını Girin: 105
Sonuç:C En büyük
```

```
A sayısını Girin: 85
B sayısını Girin: 90
C sayısını Girin: 25
Sonuç:B En Büyük
```
    
### Soru-8
   Klavyeden girilen 3 basamaklı sayının rakamlarını alt alta yazdırınız.

```csharp
static void Main(string[] args)
        {
            int girilenSayi;
            Console.Write("3 Basamaklı sayı giriniz:");
            girilenSayi = Convert.ToInt16(Console.ReadLine());

            int birler, onlar, yuzler;
            birler = girilenSayi % 10;

            girilenSayi = girilenSayi / 10;

            onlar = girilenSayi % 10;

            girilenSayi = girilenSayi / 10;

            yuzler = girilenSayi % 10;

            girilenSayi = girilenSayi / 10;

          

            Console.WriteLine(birler);
            Console.WriteLine(onlar);
            Console.WriteLine(yuzler);
          
            Console.ReadKey();
        }
```
    
**Ekran Çıktısı**
```
3. Basamaklı sayı giriniz:856
6
5
8

```
    
### Soru-9
   Klavyedem 3 basamaklı bir sayı girilecektir. Eğer son rakam tek ise ilk 2 rakamın toplamı ekrana yazdırılacak, çift ise farkı ekrana yazdırılacaktır.((% (Kalan Bulma operatörü) ve ternary oparatörü kullanılacak))

```csharp
static void Main(string[] args)
        {
            int girilenSayi;
            Console.Write("3. Basamaklı sayı giriniz:");
            girilenSayi = Convert.ToInt16(Console.ReadLine());

            int birler, onlar, yuzler;
            birler = girilenSayi % 10;

            girilenSayi = girilenSayi / 10;

            onlar = girilenSayi % 10;
            girilenSayi = girilenSayi / 10;

            yuzler = girilenSayi % 10;
            girilenSayi = girilenSayi / 10;

            int sonuc = birler % 2 == 0 ? yuzler - onlar : yuzler + onlar;

            Console.WriteLine(sonuc);

          
            Console.ReadKey();
        }
```
    
**Ekran Çıktıları**
```
3. Basamaklı sayı giriniz:984
1
```

```
3. Basamaklı sayı giriniz:985
17
```

