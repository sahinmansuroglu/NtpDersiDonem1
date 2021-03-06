## Değer ve Referans Tipleri (Value Type and Reference Type) ##
>  C# veri tipleri da verilerin bellekte nasıl saklanacağına göre değer tipleri veya referans tipleri olmak üzere ikiye ayrılır.
>  Değer tiplerinde sadece  değişkenin verisi tutulurken, Referans tiplerinde ise  verinin  bulunduğu yerin adresi tutulmaktadır.
>  Değer tiplerinde veriler belleğin yığın (Stack) bölümünde tutulurken, Referans tiplerinde veriler belleğin öbek (Heap) bölümünde yer almaktadır.

### 1. Değer Tipleri (Value Type) ###

> "bool", "byte", "char", "decimal", "double", "enum", "float", "int", "long", "sbyte", "short", "struct", "uint", "ulong", "short".

#### Değer tiplerinin bellekte yerleşimi ####
> Aşağıdaki örnekte a ve aKopya değişkenlerinin belleğin yığın bölümündeki yerleşimi gözükmektedir.
![image](https://user-images.githubusercontent.com/28144917/142982944-01a5bcde-ca89-4b7f-b770-3a9509963d6f.png)

> Aşağıdaki örnekte a ve aKopya değişkenlerinin belleğin yığın bölümündeki yerleşimi gözükmektedir. Ancak bu iki değişken farklı bellek hücrelerini gösterdiği için herhangi birisindeki değişiklik diğerini etkilememektedir.
![image](https://user-images.githubusercontent.com/28144917/142983245-f1b2b212-c7d4-4e96-a7f5-765a906cea1b.png)

**Örnek**
```csharp
 class Program
    {
        static void Main(string[] args)
        {
            int sayi = 45;
            int sayiKopya = sayi;
            sayi = 56;
            Console.WriteLine($"sayi: {sayi}");
            Console.WriteLine($"sayiKopya: {sayiKopya}");



            Console.ReadKey();
        }
    }
```
### 2. Referans Tipleri (Reference Type) ###

>  "string", "object", "class",  "array".

#### Referans tiplerinin bellekte yerleşimi ####
>Aşağıdaki Örnekte Kare tipinde yeniKare adında bir referans oluşturulmuş ancak new ile bir nesne oluşturup atama yapılmadğından referans olarak **null** değeri bulunmaktadır
![image](https://user-images.githubusercontent.com/28144917/142981838-565fef99-894b-4b87-8ad5-4fee1ef22310.png)

>Aşağıdaki Örnekte Kare tipinde yeniKare adında bir referans oluşturulmuş ve ardında  new ile bir nesne oluşturup atama yapıldığından dolayı yeniKare'ye  heap'de oluşturulan yeni nesnenin adresi atılmıştır.
![image](https://user-images.githubusercontent.com/28144917/142982203-62079f19-7a0f-4b3e-b9f3-b546757244e1.png)

>Aşağıdaki Örnekte Kare tipinde kare1 ve kare2  adında iki farklı referans oluşturulmuş ve ardında  new ile heap'de bir nesne oluşturup oluşturulan bu oluşturulan nesneninin adresi hem kare1 hem de kare2' ye atılmıştır. Yani kare1 ve kare2 aynı nesneyi göstermektedir. 
![image](https://user-images.githubusercontent.com/28144917/142982345-33cae51a-ae10-419e-8f61-32f7a74e4e0c.png)

**Örnek**
```csharp
class Program
    {
        static void Main(string[] args)
        {
            Kare kare1 = new Kare();
            kare1.Kenar = 10;
            Kare kare2 = kare1;
            kare1.Kenar = 20;
            Console.WriteLine($" Kare1 kenar uzunluğu:{kare1.Kenar}");
            Console.WriteLine($" Kare2 kenar uzunluğu:{kare2.Kenar}");
            Console.ReadKey();
        }
    }
    class Kare
    {
        int kenar;
        public int Kenar
        {
            get
            {
                return kenar;
            }
            set
            {
                kenar = value;
            }
        }
    }
```
**Yukarıdaki uygulamada bulununan verilerin bellekteki yerleşimi
![image](https://user-images.githubusercontent.com/28144917/142995271-8c115a0e-f4be-437a-b644-c7d264a6d007.png)

**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/142995378-a21f7bda-d6d4-4b4b-a591-62821383864f.png)

**Örnek**
```csharp
  class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen1;
            Dikdortgen dikdortgen2;
            Dikdortgen dikdortgen3;
            dikdortgen1 = new Dikdortgen();
            dikdortgen2 = dikdortgen1;
            dikdortgen3 = dikdortgen1;
            dikdortgen1.kisaKenarUzunlugu = 10;
            dikdortgen1.alanHesaplaEkranaYaz();
            dikdortgen2.alanHesaplaEkranaYaz();
            dikdortgen3.alanHesaplaEkranaYaz();
            Console.ReadKey();
        }
    }


    class Dikdortgen
    {
        public int kisaKenarUzunlugu=4;
        public int uzunKenarUzunlugu=6;
        public void alanHesaplaEkranaYaz()
        {
            Console.WriteLine($"Alan: {kisaKenarUzunlugu * uzunKenarUzunlugu}");
        }
    }
```

**Soru-1**

> Aşağıdaki verilenlere göre bir Öğrenci Sınıfı oluşturunuz. Bu ogrenci Sınıfından 3 tane nesne referansı oluşturup aynı nesneyi bu üç nesne referansına da atayarak bilgilerini ekrana yazdırınız.
> 1. Ad Soyad ve dogum Tarihi alanları bulunacak
> 2. Bilgileri Ekrana yazdıran bir metot  bulunanacak.

**Çözüm**

```csharp
class Program
    {
        static void Main(string[] args)
        {

            Ogrenci nesne1;
            Ogrenci nesne2;
            Ogrenci nesne3;
            nesne1 = new Ogrenci();
            nesne2 = nesne1;
            nesne3 = nesne1;

            nesne1.adSoyad = "Serdar AY";
            nesne1.dogumtarihi = 2005;
            nesne1.bilgileriEkranaYaz();
            nesne2.bilgileriEkranaYaz();
            nesne3.bilgileriEkranaYaz();

            Console.ReadKey();
            
        }
    }
    class Ogrenci
    {
        public string adSoyad = "Ahmet SEV";
        public int dogumtarihi = 2004;

        public void bilgileriEkranaYaz()
        {
            Console.WriteLine($"Ad Soyad : {adSoyad}\nDogum Tarihi:{dogumtarihi}");
            Console.WriteLine("--------------------------------------------------");

        }
    }
   
```

**Ekran Çıktısı**
![image](https://user-images.githubusercontent.com/28144917/143006180-77ffcb8d-80bc-48d5-8775-d36bb85d410f.png)
