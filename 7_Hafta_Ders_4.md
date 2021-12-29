## Lambda İfadeleri (Lambda Expression)  ( "=>" Lambda operatörü ) ##

> Lambda ifadeleri anonim (isimsiz) fonksyionlardır.  Lambda ifadeleri kullanılarak parametre alabilen ve değer döndüren basit fonksiyonlar oluşturulabilir.  Genellikle listeler üzerinde işlem yaparken çok işe yararlar.

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
            //Değer Döndürecekse Func kullanılır
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
            Console.WriteLine($"Çıktı { string.Join(" - ", dizininKAresi) }"); 

        }
         
```
    
**Ekran Çıktısı**
    
![image](https://user-images.githubusercontent.com/28144917/147666324-4ccb0ad3-64e6-4249-9abe-d5089bc7f675.png)

    
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

#### Örnek-5 ###

```csharp
 
 // using System.Linq; eklenmeli
    class Program
    {
        static void Main(string[] args)
        {
            List<Araba> arabalar = new List<Araba>();
            arabalar.Add(new Araba { Markasi = "Toyota", Model="Corolla", ModelYili = 1980 });
            arabalar.Add(new Araba { Markasi = "Citroen", Model = "C3", ModelYili = 2005 });
            arabalar.Add(new Araba { Markasi = "Toyota", Model = "Avensis", ModelYili = 2020 });
            arabalar.Add(new Araba { Markasi = "BMW", Model = "X5", ModelYili = 2019 });
            arabalar.Add(new Araba { Markasi = "Toyota", Model = "Auris", ModelYili = 2001 });
            arabalar.Add(new Araba { Markasi = "Audi", Model = "Q7", ModelYili = 2010 });

            Console.WriteLine("Tüm Arabalar");
            Console.WriteLine(string.Join("\n", arabalar));

            List<Araba> toyotaMarkaArabalar = arabalar.FindAll(n => n.Markasi == "Toyota");
            Console.WriteLine("Toyota Marka Arabalar");
            Console.WriteLine(string.Join("\n", toyotaMarkaArabalar));

            Araba bulunanAraba1 = arabalar.Find(n => n.Markasi == "BMW");
            Console.WriteLine($"Bulunan Araba 1:{bulunanAraba1}");

            Araba bulunanAraba2 = arabalar.Find(n => n.Markasi == "Toyota" & n.Model=="Avensis");
            Console.WriteLine($"Bulunan Araba 2:{bulunanAraba2}");

            int siraNo= arabalar.FindIndex(n => n.Markasi == "Citroen");

            Console.WriteLine($"Citroen Sıra No:{siraNo}");



        }
        
        

    }
    class Araba
    {
        public string Markasi { get; set; }
        public string Model { get; set; }
        public int ModelYili { get; set; }

       public override string ToString()
        {
            return $"{Markasi} - {Model} - {ModelYili}";
        }
    }
       
```
    
**Ekran Çıktısı**
    
![image](https://user-images.githubusercontent.com/28144917/147667794-f451fb63-4b7d-4572-b99a-4eef20c3027d.png)
