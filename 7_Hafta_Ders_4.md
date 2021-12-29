## Lambda İfadeleri (Lambda Expression)  ( "=>" Lambda operatörü ) ##

> Lambda ifadeleri anonim (isimsiz) fonksyionlardır.  Lambda ifadekeri kullanılarak parametre alabilen ve değer döndüren basit fonksiyonlar oluşturulabilir.  Genellikle listeler üzerinde işlem yaparken çok işe yararlar.

> Lamda ifadesi yazabilmek için "=>" operatörünü kullanırız.

### Genel Kullanım ###

```csharp
(giriş parametreleri) => çalıştırılıcak İfade
```
ya da (bir satırdan fazla çalışıtırılacak ifade varsa)

```csharp
(giriş parametreleri) => {

  çalıştırılıcak İfadeler
  
 }
 
```

#### Örnek-1  ###

```csharp
 
 // using System.Linq; eklenmeli
 
static void Main(string[] args)
        {
            //Değer Döndürecekse Funx kullanılır
            Func<int, int> kareAl = x => x * x;
            Func<int, int,int> topla = (x,y) => x + y;
            Func<int, int, double> bolum = (x, y) => (double)x / y;
            
            // 25 Yazar
            Console.WriteLine($"Çıktı-1: {kareAl(5) }");
            // 20 Yazar
            Console.WriteLine($"Çıktı-2: {topla(5,15)}");
            // 0.5 Yazar
            Console.WriteLine($"Çıktı-3: {bolum(5, 10)}");

         }
         
```
    
**Ekran Çıktısı**
    
![image](https://user-images.githubusercontent.com/28144917/147664405-e965754d-9db8-4335-b57b-b1f7ff2cbde8.png)
    
#### Örnek-2 ###
```csharp
 
 // using System.Linq; eklenmeli
 
 static void Main(string[] args)
        {

            //Değer Döndürmeyecekse Action kullanılır
            Action<string> selamla = ad =>
            {
                string mesaj = $"Merhaba {ad}!";
                Console.WriteLine(mesaj);
            };

            selamla("Şahin");
            selamla("Arda");

        }
         
```
    
**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/147664833-a9f718a7-dcfd-4cca-b89a-f8d9266b83e5.png)



           
            
#### Örnek-3 ###

```csharp
 
 // using System.Linq; eklenmeli
 
 static void Main(string[] args)
        {

             int[] numbers = { 2, 3, 4, 5 };
            var dizininKAresi = numbers.Select(x => x * x);

            //4 - 9 - 16 - 25 yazar
            Console.WriteLine($"Çıktı-4: { string.Join(" - ", dizininKAresi) }"); 

        }
         
```
    
**Ekran Çıktısı**
    
![image](https://user-images.githubusercontent.com/28144917/147665447-f8eb5956-bd33-4db2-a239-9f2e0d81e8c2.png)

    
#### Örnek-4 ###

```csharp
 
 // using System.Linq; eklenmeli
  static void Main(string[] args)
        {

            int[] sayilar = { 2, 6, 7, 5, 4, 1, 3, 9, 8  };
            int tekSayilar = sayilar.Count(n => n % 2 == 1);
            Console.WriteLine($"Sayılar: {string.Join(" ", sayilar)}" );
            Console.WriteLine($" {tekSayilar}  tane tek sayı vardır ");

        }
       
```
    
**Ekran Çıktısı**
    
![image](https://user-images.githubusercontent.com/28144917/147665391-d41904ab-d04d-42b1-b6fa-6faf8ac03ae1.png)
