## Değişkenler
Değişkenler programların çalışması boyunca kullanacağı verilerin bellekte tutulduğu alanlardır.
ve bu alanlarda bulunan veriler programın çalışması boyunca değişebilir. 
Diğer bir ifade ile değişkenler aynı kodu farklı değerlerle çalıştırmaya yaran yapılardır.
Değişkenler ram belleğin stack(yığın) bölümünde saklanır

## Değişkenler Nasıl tanımlanır?
### Değer atamadan değişken tanımlama
```
  değişkenTipi değişkenAdı;
```

### Değer atayarak değişken tanımlama
```
  değişkenTipi değişkenAdı=değeri;
```

## Örnek Tanımlar

```csharp
  string adSoyad;
  int yas;
```

## Değişken Tanımlama kuralları
 ### 1.Değişken Adları  boşluk içeremez
  
#### <del>Ogrenci Adi </del> -->Yanlış
#### OgrenciAdi --> Dogru
      
  ### 2.Değişken isimleri içerisinde özel karakter bulunamaz. (alt çizgi hariç)
  
  #### <del>Ogrenci#Adi </del> -->Yanlış
  #### OgrenciAdi --> Dogru
  #### Ogrenci_Adi --> Dogru
     
  ### 3.Değişken isimlendirmede ingiliz alfabesindeki harfler tercih edilir.
  
  ### 4.Aynı isimde birden fazla değişken tanımlanamaz.
          
```csharp
int sayi; 
double sayi:
```

> Yukarıda sayi adında bir değişken hem int hem de  double tipinde tanımlandığından hatalıdır.

### 5.C# kullanılan anahtar kelimeler(komutlar) değişken ismi olarak kullanılamaz

#### <del>string void </del> -->Yanlış
#### <del>string class </del> -->Yanlış
#### <del>string static </del> -->Yanlış

### 5.Değişken isimleri sayı ile başlamamalı

#### <del>string 1Kisi </del> --> Yanlış
#### string kisi1  --> Doğru

## Veri Tipleri 
>ilkel(primitive) ve ilkel olmayan (non primitive) veri tipi olmak üzere ikiye ayrılır. Aralarındaki en büyük fark ilkel veri tipleri içerisinde sadece tek bir veri tutarken ilkel olmayan veri tipleri içerisinde bir veya birden fazla veri tutabilir. 
### 1.İlkel Veri Tipleri
> sbyte, byte, short, ushort,int ,uint, long, ulong,float, double,decimal,char, bool

#### a) sbyte

```csharp
static void Main(string[] args)
        {
            sbyte max = sbyte.MaxValue;
            sbyte min = sbyte.MinValue;
            sbyte boyut = sizeof(sbyte);

            Console.WriteLine($"sbyte tipinde değer aralığı: {max} .. {min}");
            Console.WriteLine($"sbyte tipindeki değişkenin bellekte kapladığı alan: {boyut} Byte'dir.");

            Console.ReadKey();
        }
```

> Konsol Çıktısı
```
sbyte tipinde değer aralığı: 127 .. -128
sbyte tipindeki değişkenin bellekte kapladığı alan: 1 Byte'dir.

```
#### b) byte

```csharp
static void Main(string[] args)
        {
            byte max = byte.MaxValue;
            byte min = byte.MinValue;
            byte boyut = sizeof(byte);

            Console.WriteLine($"byte tipinde değer aralığı: {min} .. {max}");
            Console.WriteLine($"byte tipindeki değişkenin bellekte kapladığı alan: {boyut} Byte'dir.");

            Console.ReadKey();
        }
```

> Konsol Çıktısı
```
byte tipinde değer aralığı: 0 .. 255
byte tipindeki değişkenin bellekte kapladığı alan: 1 Byte'dir.

```
#### c) short

```csharp
static void Main(string[] args)
        {
            sbyte max = sbyte.MaxValue;
            sbyte min = sbyte.MinValue;
            sbyte boyut = sizeof(sbyte);

            Console.WriteLine($"sbyte tipinde değer aralığı: {max} .. {min}");
            Console.WriteLine($"sbyte tipindeki değişkenin bellekte kapladığı alan: {boyut} Byte'dir.");

            Console.ReadKey();
        }
```

> Konsol Çıktısı
```
sbyte tipinde değer aralığı: 127 .. -128
sbyte tipindeki değişkenin bellekte kapladığı alan: 1 Byte'dir.

```
#### d) int

```csharp
static void Main(string[] args)
        {
            sbyte max = sbyte.MaxValue;
            sbyte min = sbyte.MinValue;
            sbyte boyut = sizeof(sbyte);

            Console.WriteLine($"sbyte tipinde değer aralığı: {max} .. {min}");
            Console.WriteLine($"sbyte tipindeki değişkenin bellekte kapladığı alan: {boyut} Byte'dir.");

            Console.ReadKey();
        }
```

> Konsol Çıktısı
```
sbyte tipinde değer aralığı: 127 .. -128
sbyte tipindeki değişkenin bellekte kapladığı alan: 1 Byte'dir.

```
#### a) long

```csharp
static void Main(string[] args)
        {
            sbyte max = sbyte.MaxValue;
            sbyte min = sbyte.MinValue;
            sbyte boyut = sizeof(sbyte);

            Console.WriteLine($"sbyte tipinde değer aralığı: {max} .. {min}");
            Console.WriteLine($"sbyte tipindeki değişkenin bellekte kapladığı alan: {boyut} Byte'dir.");

            Console.ReadKey();
        }
```

> Konsol Çıktısı
```
sbyte tipinde değer aralığı: 127 .. -128
sbyte tipindeki değişkenin bellekte kapladığı alan: 1 Byte'dir.

```
#### a) short

```csharp
static void Main(string[] args)
        {
            sbyte max = sbyte.MaxValue;
            sbyte min = sbyte.MinValue;
            sbyte boyut = sizeof(sbyte);

            Console.WriteLine($"sbyte tipinde değer aralığı: {max} .. {min}");
            Console.WriteLine($"sbyte tipindeki değişkenin bellekte kapladığı alan: {boyut} Byte'dir.");

            Console.ReadKey();
        }
```

> Konsol Çıktısı
```
sbyte tipinde değer aralığı: 127 .. -128
sbyte tipindeki değişkenin bellekte kapladığı alan: 1 Byte'dir.

```
#### a) double

```csharp
static void Main(string[] args)
        {
            sbyte max = sbyte.MaxValue;
            sbyte min = sbyte.MinValue;
            sbyte boyut = sizeof(sbyte);

            Console.WriteLine($"sbyte tipinde değer aralığı: {max} .. {min}");
            Console.WriteLine($"sbyte tipindeki değişkenin bellekte kapladığı alan: {boyut} Byte'dir.");

            Console.ReadKey();
        }
```

> Konsol Çıktısı
```
sbyte tipinde değer aralığı: 127 .. -128
sbyte tipindeki değişkenin bellekte kapladığı alan: 1 Byte'dir.

```
#### a) sbyte

```csharp
static void Main(string[] args)
        {
            sbyte max = sbyte.MaxValue;
            sbyte min = sbyte.MinValue;
            sbyte boyut = sizeof(sbyte);

            Console.WriteLine($"sbyte tipinde değer aralığı: {max} .. {min}");
            Console.WriteLine($"sbyte tipindeki değişkenin bellekte kapladığı alan: {boyut} Byte'dir.");

            Console.ReadKey();
        }
```

> Konsol Çıktısı
```
sbyte tipinde değer aralığı: 127 .. -128
sbyte tipindeki değişkenin bellekte kapladığı alan: 1 Byte'dir.

```


###2. İlkel olmayan veri tipleri
> string, classes, interfaces, structes, Enumarationa

```csharp      
  static void Main(string[] args)
        {

            string ad;
            Console.Write("Adınızı Giriniz:");
            ad = Console.ReadLine();

            Console.WriteLine($"Merhaba sayin {ad}");
            Console.ReadKey();
            
        }
```
