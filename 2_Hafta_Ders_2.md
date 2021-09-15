## Operatörler
Opetörler işlemleri yerine getirmek için kullanılan sembollerdir. Örneğin '+' sembolü bir operatördür sayılarda toplama işlemi stringlerde ise birleştirme işlemi yapar.
> Operatörler aşağıdaki şekilde sınıflandırılabilir

1. Aritmetik operatörler.
2. Atama Operatörleri
3. Karşılaştırma operatörleri.
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
|---	  |---	                |---	sayi1 = 5 | 
|   +=	  |   Toplama ve atama        |  sayi1 += 5  | sayi1 = sayi1 + 5 |
|   -=	  |   Çıkartma ve atama	        |   sayi1 -= 5 	        | sayi1 = sayi1 - 5 |
|   \*=	  |   Çarpma ve atama	        |   sayi1 \*= 5 	        | sayi1 = sayi1 * 5 |  
|   / =	  |   Bölme ve atama	         |   sayi1 /= 5 	        |  sayi1 = sayi1 / 5 | 	
|   %=	  |   Mod alma (Kalan) ve atama  |   sayi1 %= 5 	|sayi1 = sayi1 % 5 |
