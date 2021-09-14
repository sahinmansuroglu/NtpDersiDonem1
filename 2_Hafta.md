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
