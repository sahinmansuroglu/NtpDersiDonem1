## Operatörler
Opetörler işlemleri yerine getirmek için kullanılan sembollerdir. Örneğin '+' sembolü bir operatördür sayılarda toplama işlemi stringlerde ise birleştirme işlemi yapar.
> Operatörler aşağıdaki şekilde sınıflandırılabilir

1. Aritmetik operatörler.
2. Atama Operatörleri
3. Arttırma operatörleri.
4. Bitsel operatörler.
5. Mantıksal operatörler.
6. Atama ve işlemli atama operatörleri.
7. Özel amaçlı operatörler.

### 1. Aritmetik Operatörler

| Operatör| Açıklama 	        | Örnek Kullanım  |   
|---	  |---	                |---	        |
|   +	  |   Toplama 	        |  a + b 	        |
|   -	  |   Çıkartma	        |   a - b	        | 
|   *	  |   Çarpma	        |   a * b	        |   
|   /	  |   Bölme	        |   a / b	        |   	
|   %	  |   Mod alma (Kalan)  |   a % b	|

#### Örnek:
Aşağıdaki uygulama 2 sayı üzerinde toplama, çıkartma, çarpma, bölme, ve mod alma işlemleri yapmaktadır.
```csharp
static void Main(string[] args)
        {
            int sayi1 = 45;
            int sayi2 = 10;
            int toplam = sayi1 + sayi2;
            int fark = sayi1 + sayi2;
            double bolum = sayi1 / sayi2;
            int carpim = sayi1 * sayi2;
            int kalan = sayi1 % sayi2;
            Console.WriteLine($"Toplam:{toplam}");
            Console.WriteLine($"Fark:{fark}");
            Console.WriteLine($"Bölüm:{bolum}");
            Console.WriteLine($"Çarpım:{carpim}");
            Console.WriteLine($"Kalan:{kalan}");
        }
```
**Ekran Çıktısı**
```
Toplam:55
Fark:55
Bölüm:4
Çarpım:450
Kalan:5
```
>  **Not:** Ekran çıktısını incelediğimizde bölme işleminin sonucunu ondalıklı olmasına rağmen çıktıda tam sayı olarak gözükmektedir. Nedeni ise int/int sonucu her zaman int olarak çıkar. Bundan dolayı bölen veya bölünen sayılardan en az birinin tipinin kayan noktalı(float, double) sayı olması gerekmektedir. Çözüm için cast yöntemi dediğimiz yöntemle sayılardan birini double'a çevirebiliriz. 
>  Sonucun ondalıklı çıkabilmesi için çözüm aşağıdadır 
```csharp
double bolum = (double) sayi1 / sayi2;
```
### 2. Atama Operatörleri

| Operatör| Açıklama 	        | Örnek Kullanım  |   Uzun Gösterim |
|---	  |---	                |---	|---
|   =	  |   Atama        |  sayi1 = 5  | |
|   +=	  |   Toplama ve atama        |  sayi1 += 5  | sayi1 = sayi1 + 5 |
|   -=	  |   Çıkartma ve atama	        |   sayi1 -= 5 	        | sayi1 = sayi1 - 5 |
|   \*=	  |   Çarpma ve atama	        |   sayi1 \*= 5 	        | sayi1 = sayi1 * 5 |  
|   / =	  |   Bölme ve atama	         |   sayi1 /= 5 	        |  sayi1 = sayi1 / 5 | 	
|   %=	  |   Mod alma (Kalan) ve atama  |   sayi1 %= 5 	|sayi1 = sayi1 % 5 |

#### Örnek:
Aşağıdaki uygulama 2 sayı üzerinde toplama, çıkartma, çarpma, bölme, ve mod alma işlemleri yapmaktadır.
```csharp
static void Main(string[] args)
        {
            int sayi1 = 10;
            sayi1 += 5;  // sayi1 = sayi1 + 5;
            Console.WriteLine($"+= İşlemi sonrası sayi1:{sayi1}");
            sayi1 -= 3;  // sayi1 = sayi1 - 5;
            Console.WriteLine($"-= İşlemi sonrası sayi1:{sayi1}");
            sayi1 *= 2;  // sayi1 = sayi1 * 5;
            Console.WriteLine($"*= İşlemi sonrası sayi1:{sayi1}");
            sayi1 /= 4;  // sayi1 = sayi1 / 5;
            Console.WriteLine($"/= İşlemi sonrası sayi1:{sayi1}");
            sayi1 %= 5;  // sayi1 = sayi1 % 5;
            Console.WriteLine($"%= İşlemi sonrası sayi1:{sayi1}");

            Console.ReadKey();
        }
```
**Ekran Çıktısı**
```
+= İşlemi sonrası sayi1:15
-= İşlemi sonrası sayi1:12
*= İşlemi sonrası sayi1:24
/= İşlemi sonrası sayi1:6
%= İşlemi sonrası sayi1:1
```
#### Örnek:
Soru: Klavyeden girilen 3 puanın ortalamasını bulan program.
```csharp
static void Main(string[] args)
        {
            short puan1, puan2, puan3;
            Console.Write("1. Puanı giriniz:");
            puan1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2. Puanı giriniz:");
            puan2 = Convert.ToInt16(Console.ReadLine());
            Console.Write("3. Puanı giriniz:");
            puan3 = Convert.ToInt16(Console.ReadLine());

            double ortalama = (puan1 + puan2 + puan3) / 3.0;

            Console.WriteLine($"Girilen 3 puanın ortalaması:{ortalama} ");

            Console.ReadKey();
        }
```


**Ekran Çıktısı**
```
1. Puanı giriniz:85
2. Puanı giriniz:36
3. Puanı giriniz:45
Girilen 3 puanın ortalaması:55,333333333333336
```

### 3. Arttırma Azaltma  Operatörleri

| Operatör| Açıklama 	        |   
|---	  |---	                |
|   n++	  |   Sonra  Arttırma (ilk olarak atama işlemi gerçekleşir sonra arttırılır)  |   
|   ++n	  |   Önce Arttırma   (ilk olarak arttırma işlemi gerçekleşir sonra atama yapılır)	|   
|   n--	  |   Sonra Çıkartma  (ilk olarak atama işlemi gerçekleşir sonra azaltılır)	|   
|   --n	  |   Önce Çıkartma   ((ilk olarak azaltma işlemi gerçekleşir sonra atama yapılır))|    	


#### Örnek:

```csharp
static void Main(string[] args)
        {
            byte a = 6, b=5;

            //a++ yerine a = a + 1 veya a += 1'de yazılabilir
            a++;// a nın değerini 1 arttırır (a = 7 oldu)

            //b-- yerine b = b - 1 veya b -= 1'de yazılabilir
            b--;//b nin değerini 1 azaltır.(b = 4 oldu)

            Console.WriteLine($"a:{a} b:{b}");
                       
            Console.ReadKey();
        }
```




**Ekran Çıktısı**
```
a:7 b:4
```

