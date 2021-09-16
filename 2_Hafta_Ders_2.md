## Operatörler
Opetörler işlemleri yerine getirmek için kullanılan sembollerdir. Örneğin '+' sembolü bir operatördür sayılarda toplama işlemi stringlerde ise birleştirme işlemi yapar.
> Operatörler aşağıdaki şekilde sınıflandırılabilir

1. Aritmetik operatörler.
2. Atama Operatörleri
3. Arttırma-Azaltma operatörleri.
4. Karşılaştırma operatörler.
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
            int fark = sayi1 - sayi2;
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
Fark:35
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
Soru: Klavyeden girilen 2 puanın ortalamasını bulan program.
```csharp
static void Main(string[] args)
        {
            short puan1, puan2 ;
            Console.Write("1. Puanı giriniz:");
            puan1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2. Puanı giriniz:");
            puan2 = Convert.ToInt16(Console.ReadLine());
       

            double ortalama = (puan1 + puan2 ) / 2.0;

            Console.WriteLine($"Girilen 2 puanın ortalaması:{ortalama} ");

            Console.ReadKey();
        }
```


**Ekran Çıktısı**
```
1. Puanı giriniz:85
2. Puanı giriniz:36

Girilen 2 puanın ortalaması:60,5
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

#### Örnek:

```csharp
static void Main(string[] args)
        {
            byte a = 6, c ;
            
            //Aşağıda önce arttır operatörü kullanılmıştır
            c=++a; // ilk olarak a'nın değeri 1 arttırılır ardından a nın değeri c'ye atanır.
            Console.WriteLine($"c:{c} a:{a}");    // c:7 a:7

            //Aşağıda sonra arttır operatörü kullanılmıştır
            c = a++;// ilk olarak a'nın değeri c'ye atanır ardından a nın değeri bir arttırılır
            Console.WriteLine($"c:{c} a:{a}");   // c:7 a:8

            a = 10;

            //Aşağıda önce azalt operatörü kullanılmıştır
            c = --a; // ilk olarak a'nın değeri 1 azaltılıt ardından a nın değeri c'ye atanır.
            Console.WriteLine($"c:{c} a:{a}");   // c:9 a:9
            
            //Aşağıda sonra azalt operatörü kullanılmıştır
            c = a--;// ilk olarak a'nın değeri c'ye atanır ardından a nın değeri bir azaltılır.
            Console.WriteLine($"c:{c} a:{a}");  // c:9 a:8

            Console.ReadKey();
        }
```


**Ekran Çıktısı**
```
c:7 a:7
c:7 a:8
c:9 a:9
c:9 a:8
```
### 4. Karşılaştırma Operatörler
> Karşılaştırma operatörleri 2 değeri kıyaslayarak `true (Doğru)` veya `false (Yanlış)` değeri döndüren operatörlerdir


| Operatör| Açıklama 	        | Örnek Kullanım  |   
|---	  |---	                |---	          |
|   ==	  |   Eşit 	        |   a = b 	  |
|   !=	  |   Eşit değil	|   a != b	  | 
|   <	  |   Küçük	        |   a < b	  |   
|   >	  |   Büyük	        |   a > b	  |   	
|   <=	  |   Küçük Eşit        |   a <= b	  |
|   >=	  |   Büyük Eşit        |   a >= b	  |


```csharp
static void Main(string[] args)
        {
            int a = 5;
            bool sonuc1 = a == 5;
            Console.WriteLine($"sonuc1:{sonuc1}"); // true yazar
            bool sonuc2 = a != 5;
            Console.WriteLine($"sonuc2:{sonuc2}"); // false yazar
            bool sonuc3 = a < 5;
            Console.WriteLine($"sonuc3:{sonuc3}"); // false yazar
            bool sonuc4 = a > 5;
            Console.WriteLine($"sonuc4:{sonuc4}"); // false yazar
            bool sonuc5 = a <= 5;
            Console.WriteLine($"sonuc5:{sonuc5}"); // true yazar
            bool sonuc6 = a >= 5;
            Console.WriteLine($"sonuc6:{sonuc6}"); // true yazar
            Console.ReadKey();
      
        }
```
**Ekran Çıktısı**
```
sonuc1:True
sonuc2:False
sonuc3:False
sonuc4:False
sonuc5:True
sonuc6:True
```

### 5. Mantıksal Operatörler
> Mantıksal operatörler mantıksal ifadeleri(sonucu true veya false olan ifadeler)  birbirine bağlamak için kullanılır. Sonucta 


| Operatör| Açıklama 	        | Örnek Kullanım        |   
|---	  |---	                |---	                |
|   &&	  |     Ve 	        |   a == b &&  a < b	  |
|   ||	  |    veya	        |   a == b ||  a < b	  | 
|   !	  |    değil	        |   !(a < b)	        |   

**&& Operatörü**
> Sadece koşullardan ikisinin de `true` olduğu durumlarda sonucu `true` veren diğer durumlarda `false` değerini veren öperatördür. 

| 1. Koşul| 2. Koşul 	        | `1. Koşul && 2. Koşul`        |   
|---	  |---	                |---	                |
|   false  |    false	        |  `false`	  |
|   false  |     true 	        |   `false`	  |
|   true   |    false	|  `false`	  | 
|   true   |    true	|  `true`	        |   


**|| Operatörü**

> Koşullardan herhandi birinin `true` olduğu durumlarda sonucu `true` veren , diğer durumlarda `false` değeri veren operatördür.

| 1. Koşul| 2. Koşul 	        | `1. Koşul || 2. Koşul`        |   
|---	  |---	                |---	                |
|   false  |    false	        |  `false`	  |
|   false  |     true 	        |   `true`	  |
|   true   |    false	|  `true`	  | 
|   true   |    true	|  `true`	        |

**! Operatörü**

> Mantıksal ifadenin değilini alır. Yani true ise false, false ise true yapar.

| 1. Koşul| `!(1. Koşul)`        |   
|---	  |---	                |
|   true  |    false	        |  
|   false  |     true 	        |  

```csharp

```
**Ekran Çıktısı**
```

```

