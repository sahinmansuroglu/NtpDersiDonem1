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

| Veri Tipi     | Tanım           | Aralık  |Son ek |
| ------------- |:---------------:| -----:  |-----:|
| byte    		| 8 bitlik işaretsiz tam sayı| 0 .. 255 |  
| sbyte    		| 8 bitlik işaretli tam sayı| -128 .. 127 |
| short    		| 16 bitlik işaretli tam sayı| -32,768 .. 32,767 |
| ushort    	| 16 bitlik işaretsiz tam sayı| 0 .. 65,535 |
| int    		| 32 bitlik işaretli tam sayı| -2,147,483,648 .. 2,147,483,647 |
| uint    		| 32 bitlik işaretsiz tam sayı| 0 .. 4,294,967,295| u |
| long    		| 64 bitlik işaretli tam sayı|-9,223,372,036,854,775,808 .. 9,223,372,036,854,775,807| l |
| ulong    		| 64 bitlik işaretsiz tam sayı|0 .. 18,446,744,073,709,551,615	| ul |
| float    		| 32 bitlik  ondalıklı sayı|-3.402823e38 .. 3.402823e38 |  f |
| double    		| 64 bitlik  ondalıklı sayı|-1.79769313486232e308 .. 1.79769313486232e308 |  d |
| deciamal   		| 128 bitlik  decimal sayı (mali hesaplamalar için)  |-1.79769313486232e308 .. 1.79769313486232e308  |  m |
| `char`   		| 16 bit unicode karakter| Herhangi bir geçerli karakter |
| bool    		| 8 bitlik mantıksal doğru/yanlış değer| True veya False |




### 2. İlkel olmayan veri tipleri
> string, classes, interfaces, structes, Enumaration vb.
> Bu bölümde sadece ilkel olmayan veri tiplerinden string veri tipi incelenecektir. Diğer veri tipleri ilerleyen haftalarda incelenecektir.

> String veri tipi karakter dizileri oluştumak için kullanılır.
> String veri tipindeki değişkenler bellekte karakter sayısı * 2Byte kadar yer kaplar

<span style="color:blue">some *blue* text</span>.
