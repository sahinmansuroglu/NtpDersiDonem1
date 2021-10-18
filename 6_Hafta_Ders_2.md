## Encapsulation  (Kapsülleme) ## 
> Kapsülleme sınıf içerisindeki private olarak tanımlanmış alanlara güvenli bir şekilde erişilebilmesini sağlayan bir yaklaşımdır ve Nesneye Yönelik Programlama kavramının en önemli yaklaşımlarından biridir.
> Kapsüllemenin temel yapısını get ve set metotları oluşturur. Private tanımlanmış bir alanın(field) değerini çekmek istediğimizde get methodunu, bu alana (field) değer vermek istediğimizde ise set methodunu kullanırız.

**Temel Kullanıma Örnek**
```csharp
class Dikdortgen{
        private int kisaKenar; // Field (Alan)
        public int KisaKenar   // property (Özellik)
        {
            get {              //KısaKenar property'sinin değerini okydyğ
                return kisaKenar; 
            }
            set
            {
               kisaKenar = value; 
            }
        }
}
```

**Örnek**
> Aşağıdaki örnekte Dikdortgen sınıfının içerisinde private olarak kisaKenar field'i (Alanı) tanımlanmış  ve bu field'a erişim KisaKenar özelliğinin get ve set metotları kullanılarak gerçekleştirilmiştir. 
```csharp
class Dikdortgen{
        private int kisaKenar; // Field (Alan)
        public int KisaKenar  // property (Özellik)
        {
            get { return kisaKenar; }
            set
            {
                if (value < 0)
                { kisaKenar = 0; }
                else
                { kisaKenar = value; }
            }
        }
}
```

**Örnek**
Aşağıdaki uygulama dikdörtgen sınıfındaki kisaKenar ve uzunKenar alanları(field) negatif değer girmeye karşı kapsüllenmiştir.


**Dikdortgen Class'ı**
```csharp
    class Dikdortgen
    {
        private int kisaKenar;//field(alan)
        private int uzunKenar;
        public int KisaKenar { //Property
            get { 
                return kisaKenar; 
            }
            set { 
                if (value < 0)
                {
                    kisaKenar = 0;
                }
                else
                {
                    kisaKenar = value;
                }
               
            } 
        
        }

        public int UzunKenar { 
            get  {
                return uzunKenar;
            }
            set
            {
                if (value < 0)
                {
                    uzunKenar = 0;
                }
                else
                {
                    uzunKenar = value;
                }
               
            }
        
        }
        public Dikdortgen(int kisaKenar, int uzunKenar)
        {
            this.KisaKenar = kisaKenar;
            this.UzunKenar= uzunKenar;
        }
       public int alanHesapla()
        {
            return KisaKenar * UzunKenar;
        }
    }

```
**Dikdortgen Class'ını kullanan ana program**
```csharp
 class Program
    {
        static void Main(string[] args)
        {

            Dikdortgen yeniDikdortgen = new Dikdortgen(-5, 5);

            Console.WriteLine($"Alan={yeniDikdortgen.alanHesapla()}");

            Console.ReadKey();
        }
    }

```
**Örnek**
> Aşağıdaki örnekte Araba class'ı tanımlanmış içerisinde yili, markasi ve hizi alanları tanımlanmıştır. Kapsülleme ile yili'nın 1900 den büyük olması, hizi'nın negatif sayı olmaması ve marka bilgisinin boş metin girildiği  durumlarda "Marka  Girilmedi" verisinin girilmesi sağlanmıştır.


**Araba Class'ı**
```csharp
 class Araba
    {
        int yili;
        public int Yili {
            get
            {
                return yili;
            }
            set
            {
                if (value < 1900)
                {
                    yili = 0;
                }
                else
                {
                    yili = value;
                }
                
            }
        }
        int hizi;
        public int Hizi
        {
            get
            {
                return hizi;
            }
            set
            {
                if (value < 0)
                {
                    hizi = 0;
                }
                else
                {
                    hizi = value;
                }

            }
        }

        string markasi;
        public string Markasi
        {
            get
            {
                return markasi;
            }
            set
            {
                if (value == "")
                {
                    markasi = "Marka Girilmedi";
                }
                else
                {
                    markasi = value;
                }
               
            }
        }
        
    }
  
  ```
  **Araba Class'ını kullanan ana program**
  
  ```csharp
   class Program
    {
        static void Main(string[] args)
        {
            Araba yeniAraba = new Araba();
            yeniAraba.Hizi = 50;
            yeniAraba.Yili = 1990;
            yeniAraba.Markasi = "BMW";

            

            Console.WriteLine($"Hiz={yeniAraba.Hizi}");
            Console.WriteLine($"Yili={yeniAraba.Yili}");
            Console.WriteLine($"Markasi={yeniAraba.Markasi}");

            Console.ReadKey();
        }
    }
  ```
