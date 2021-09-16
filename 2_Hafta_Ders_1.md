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

## Değişken türleri ile ilgili örnekler
### Örnek-1
Aşağıdaki uygulamda sbyte veri tipinini maximum, minimum, varsayılan değeri ve bellek kapladğı alan buldurulup ekran yazdırılmıştır.
```csharp
static void Main(string[] args)
        {
//sbyte veri tipinde max isminde bir değişken tanımlanmış ve bu değişkene sbyte.MaxValue ile sbyte veri tipinin maximum değeri atanmıştır. 
            sbyte max = sbyte.MaxValue;
//sbyte veri tipinde min isminde bir değişken tanımlanmış ve bu değişkene sbyte.MinValue ile sbyte veri tipinin minimum değeri atanmıştır.
            sbyte min = sbyte.MinValue;
//sbyte veri tipinde varsayılan isminde bir değişken tanımlanmış ve bu değişkene default(sbyte) ile sbyte veri tipinin varsayılan değeri atanmıştır.
            sbyte varsayılan = default(sbyte);
         
            Console.WriteLine("sbyte veri tipinin değer aralığı:");
            Console.WriteLine($"{min} .. {max} "); // max ve min değişkenlerinin değerleri ekrana yazdırılmıştır
            Console.WriteLine($"Varsayılan Değeri:{varsayılan}"); // varsayılan değişkeninin değeri ekrana  yazdırılmıştır.
            
//Sizeof komutu ile sbyte veritipinin bellekte kapladığı yer ekrana yazdırılmıştır.
            Console.WriteLine($"Bellekte kapladığı alan:{sizeof(sbyte)} Byte");
        }
 ```
 
 #### Ekran Çıktısı
 ```
 sbyte veri tipinin değer aralığı:
-128 .. 127
Varsayılan Değeri:0
Bellekte kapladığı alan:1 Byte
 ```
 ### Örnek-1
 Aşağıdaki örnekte farklı tip te değişkenler tanımlanmıştır. Bazı değişkenlerin değerleri tanımlanma anında verilmişken bazılarında ise tanımlandıktan sonraki başka bir satırda verilmiştir. Örneğin puan değişkenin değeri tanımlama yapıldıktan sonra verilmişken, nufus değişkeninin değeri tanımlamadan sonraki satırda verilmiştir. Son olarak da tüm değişkenlerin değerleri ekrana yazdırılmıştır.
 ```csharp
 static void Main(string[] args)
        {
            byte puan;
            puan = 95;
            short uzaklik = 1000;
            int nufus = 250000;
            float sicaklik = 23.4f;// float tipinde değer ataması yapılırken değerin sonuna "f" son eki yazılır.
            double ortalama = 34.4565664;
 
            long longSayi = 457825114; 
            decimal decimalSayi = 14353.12m; // deciamal tipinde değer ataması yapılırken değerin sonuna "m" son eki yazılır.
            char cinsiyet = 'E'; //char tipinde karakter ataması yapılırken karakter tek tırnaklar içerisine yerleştirilir.
            bool calisiyorMu = true;
            string mesaj;
            mesaj = "Merhaba dünya";// string tipinde değer ataması yapılırken atanacak karakter dizisi çift tırnaklar arasına yerleştirilir.
            Console.WriteLine($"puan:{puan}");
            Console.WriteLine($"uzaklik:{uzaklik}");
            Console.WriteLine($"nufus:{nufus}");
            Console.WriteLine($"sicaklik:{sicaklik}");
            Console.WriteLine($"ortalama:{ortalama}");
            Console.WriteLine($"longSayi:{longSayi}");
            Console.WriteLine($"decimalSayi:{decimalSayi}");
            Console.WriteLine($"cinsiyet:{cinsiyet}");
            Console.WriteLine($"calisiyorMu:{calisiyorMu}");
            Console.WriteLine($"mesaj:{mesaj}");
        }
 ```
  #### Ekran Çıktısı
 ```
nufus:250000
sicaklik:23,4
ortalama:34,4565664
longSayi:457825114
decimalSayi:14353,12
cinsiyet:E
calisiyorMu:True
mesaj:Merhaba dünya
 ```
## Console Ekranında kullanıcıdan veri alma
Konsole ekranında kullanıcının girdiği veri satırının tümünü okumak için Console.ReadLine() metodu kullanılır. 
Bu metot ile kullanıcının alınan verinin tipi string'dir. 
#### Örnek
Kullanıcıdan alınan ad soyad bilgisi kullanılarak kişiye hoşgeldin mesajı veren uygulama.
```csharp
static void Main(string[] args)
        {

            Console.Write("Lütfen adınızı ve soyadınızı giriniz:");
            string adSoyad = Console.ReadLine();
            Console.WriteLine($"Merhaba sayın {adSoyad}");
            Console.ReadKey();
        }
```
  #### Ekran Çıktısı 
```diff
Lütfen adınızı ve soyadınızı giriniz:  Şahin MANSUROĞLU 
Merhaba sayın Şahin MANSUROĞLU
```


#### Örnek 
> Kullanıcıdan alınan ad soyad, yas ve boy bilgisini ekrana yazdıran program.
> #### Önemli #### Eğer Konsol ekranında kullanıcıdan alınan veri string tipinde değilde başka bir  veri tipinde tanımlanmış bir değişkene atanırsa
girilen değerin o veri tipine dönüştürülmesi gerekir. Örneği yas değişkenin tipi byte tanımlanmıştır. Bundan dolayı kalvyeden girilen veri Convert.ToByte ile string'den byte'a çevrilmiştir.
```csharp
static void Main(string[] args)
        {

            Console.Write("Lütfen adınızı ve soyadınızı giriniz:");
            string adSoyad = Console.ReadLine();

            Console.Write("Lütfen yaşınızı giriniz:");
            byte yas = Convert.ToByte(Console.ReadLine());

            Console.Write("Lütfen boyunuzu giriniz:");
            double boy = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Ad ve Soyadınız:{adSoyad}");
            Console.WriteLine($"Yaşınız:{yas}");
            Console.WriteLine($"Boyunuz:{boy}");

            Console.ReadKey();
        }
```
  #### Ekran Çıktısı
```
Lütfen adınızı ve soyadınızı giriniz: Şahin MANSUROĞLU
Lütfen yaşınızı giriniz:38
Lütfen boyunuzu giriniz:1,77
Ad ve Soyadınız:Şahin MANSUROĞLU
Yaşınız:38
Boyunuz:1,77
```



