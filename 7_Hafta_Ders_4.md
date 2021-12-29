## Lambda İfadeleri (Lambda Expression)  ( "=>" Lambda operatörü ) ##

> Lambda ifadeleri anonim (isimsiz) fonksyionlardır.  Lambda ifadekeri kullanılarak parametre alabilen ve değer döndüren basit fonksiyonlar oluşturulabilir.  Genellikle listeler üzerinde işlem yaparken çok işe yararlar.

> Lamda ifadesi yazabilmek için "=>" operatörünü kullanırız.

### Genel Kullanım ###
 ````csharp
(giriş parametreleri) => çalıştırılıcak İfade
 ````
ya da (bir satırdan fazla çalışıtırılacak ifade varsa)

 ````csharp
(giriş parametreleri) => {

  çalıştırılıcak İfadeler
  
 }
 
  ````

#### Örnek-1  ###
 ````csharp
 
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

            int[] numbers = { 2, 3, 4, 5 };
            var dizininKAresi = numbers.Select(x => x * x);

            //4 - 9 - 16 - 25 yazar
            Console.WriteLine($"Çıktı-4: { string.Join(" - ", dizininKAresi) }"); 
         }
         
    ````
    
    **Ekran Çıktısı**
    
    ![image](https://user-images.githubusercontent.com/28144917/147664405-e965754d-9db8-4335-b57b-b1f7ff2cbde8.png)
