## Temel Sınıfın (Base veya Parent) üyelerine erişim (Base keyword kullanımı) ##

> C# programlama dilinde base class yani üst sınıfın üyelerine erişim için base keyword'ü kullanılır.

**Örnek-1**
> Aşağıdaki kod örneğinde ParentSinif class'indan ChildSinif class'i türetilmiştir. Her iki sınıfta da kurucu metot tanımlanmıştır. ancak türetilmiş sınıfın(ChildSinif) kurucu metodundan 
> temel sınıfın(ParentSinif) kurucu metoduna erişebilmek için  türetilmiş sınıfın kurucu metodu ``` public ChildSinif(int sayi2) : base(sayi2)``` şeklinde düzenlenerek ChildSınıfın kurucu metoduna gelen parametre ile ParentClass'ın kurucu metodu çağrılmıştır


```csharp
class Program
    {
        static void Main(string[] args)
        {
            ChildSinif nesne = new ChildSinif(25);
            Console.ReadKey();
        }
    }


    class ParentSinif
    {

        public ParentSinif(int sayi1)
        {
            Console.WriteLine($"Parent Sinif'in Kurucu Metodu (Sayi:{sayi1} )");
        
        }

    }

    class ChildSinif:ParentSinif
    {
        public ChildSinif(int sayi2) : base(sayi2)
        {
            Console.WriteLine("Child Sinif'in Kurucu Metodu");
        }
    }
```
**Örnek-2**
> Yukarıdaki Örnekteki sınıflara aşağıdaki şekilde eklemeler yapınız. Ardından ana programda ChildSinif'dan nesne oluşturup içerisindeki mesajYaz metodunu çağırınız.

**Not:** ChildSinif'daki mesajYaz metodunun içerisinde ParentSinif'in mesajYaz metodunu çağırınız. 

| Sınıf Adı      | Eklenecek Metod | Açıklama |
| ----------- | ----------- |----------- |
| ParentSinif | mesajYaz() (Virtual)| Ekrana "Merhaba Dünya" Yazacak  |
| ChildSinif | mesajYaz()(Override)| Ekrana "Merhaba Güneş Sistemi" Yazacak  |

**Çözüm**

```csharp
class Program
{
    static void Main(string[] args)
    {
        ChildSinif childNesne = new ChildSinif(25);
        childNesne.mesajYaz();
        Console.ReadKey();
    }
}

class ParentSinif
{

    public virtual void mesajYaz()
    {
        Console.WriteLine("Merhaba Dünya");
    }
    public ParentSinif(int sayi1)
    {
        Console.WriteLine($"Parent Sinif'in Kurucu Metodu (Sayi:{sayi1} )");

    }

}

class ChildSinif : ParentSinif
{
    public ChildSinif(int sayi2):base(sayi2)
    {
        Console.WriteLine("Child Sinif'in Kurucu Metodu");
    }

    public override void mesajYaz()
    {
        //Aşağıdaki kod satırı ile temel (ParentSinif) sınıfın mesajYaz metodu çağrılmıştır.
        base.mesajYaz();
        Console.WriteLine("Merhaba Güneş Sistemi");
    }
}

```

**Örnek-2**

> Aşağıda verilenlere göre ilk olarak kare sınıfını tanımlayınız. Ardından Kare sınıfından Dikdortgen Sınıfını türetiniz. Son olarak Kare ve Dikdortgen sınıfından birer nesne oluşturarak alanını ve çevresini ekrana yazdırınız. Oluşturan nesnelerin kenar uzunlukları kurucu metot ile atanacaktır.

**Not:**  Virtual  override  keywordleri kullanılmalıdır.


| Sınıf Adı      | İçinde Bulunacak Property'ler | İçinde Bulunacak Metotlar |
| ----------- | ----------- |----------- |
| Kare      | KenarA    | alan(), cevre(), bilgileriEkranaYaz() |
| Dikdortgen   | KenarA, KenarB       |alan(), cevre(), bilgileriEkranaYaz()  |

**Çözüm**
```csharp
 class Program
    {
        static void Main(string[] args)
        {
            Kare kare1 = new Kare(33);
            Console.WriteLine("Kare Verileri");
            kare1.bilgileriEkranaYaz();
            Dikdortgen dikdorgen1 = new Dikdortgen(22, 22);
            Console.WriteLine("Dikdörtgen Verileri");
            dikdorgen1.bilgileriEkranaYaz();
            Console.ReadKey();
        }
    }
    class Kare
    {
        public int KenarA { get; set; }
        public Kare(int kenarA)
        {
            this.KenarA = kenarA;
        }
        public virtual int AlanHesapla()
        {
            return KenarA * KenarA;
        }
        public virtual int CevreHesapla()
        {
            return KenarA * 4;
        }
        public virtual void bilgileriEkranaYaz()
        {
            Console.WriteLine($"Alanı:{AlanHesapla()}");
            Console.WriteLine($"Çevresi:{CevreHesapla()}");
        }
    }

    class Dikdortgen : Kare
    {
        public int KenarB { get; set; }
        public Dikdortgen(int kenarA,int bkenar) : base(kenarA)
        {
            this.KenarB = bkenar;
        }
        public override int AlanHesapla()
        {
            return KenarA * KenarB;

        }
        public override int CevreHesapla()
        {
            return (KenarA + KenarB) * 2;
        }
       
    }
 ```
 
 **Ekran Çıktısı**

   
![image](https://user-images.githubusercontent.com/28144917/145364694-21baf714-8980-4f19-845f-8fd5a1f5d71d.png)



**Örnek-3**

> Yukarıdaki örneğe ek olarak aşağıda verilenlere göre Dikdörtgen sınıfından Üçgen sınıfını türetiniz. Son olarak Üçgen sınıfından bir nesne oluşturarak alanını ve çevresini ekrana yazdırınız. Oluşturan nesnenin kenar uzunlukları kurucu metot ile atanacaktır. 

**Not-1:**  Virtual  override  keywordleri kullanılmalıdır.

**Not-2:**  Kenar uzunlukları negatif bit sayı girilirse class hata fırlatmalı ana programdan da bu hata yakalanmalıdır.

| Sınıf Adı      | İçinde Bulunacak Property'ler | İçinde Bulunacak Metotlar |
| ----------- | ----------- |----------- |
| Kare      | KenarA     | alan(), cevre() |
| Dikdortgen   | KenarA, KenarB       |alan(), cevre() |
| Ucgen   | KenarA, KenarB, KenarC       |alan(), cevre() |


| Üç kenarı Bilinen Üçgenin Alanının Hesaplanması    | 
| ----------- |
|![image](https://user-images.githubusercontent.com/28144917/145355111-951084fd-c23b-4077-ba7a-5d6111470aaf.png)|

**Çözüm**
```csharp
class Program
    {
        static void Main(string[] args)
        {
            Ucgen ucgen1 = new Ucgen(15, 10, 24);
            Console.WriteLine("Üçgen Verileri");
            ucgen1.bilgileriEkranaYaz();
            Console.ReadKey();
        }
    }
    class Kare
    {
        int kenarA;
        public int KenarA
        {
            get
            {
                return kenarA;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("A kenar uzunluğu pozitif sayı olmalıdir!!");
                }
                else
                {
                    kenarA = value;
                }
            }
        }
        public Kare(int kenarA)
        {
            this.KenarA = kenarA;
        }
        public virtual double AlanHesapla()
        {
            return KenarA * KenarA;
        }
        public virtual int CevreHesapla()
        {
            return KenarA * 4;
        }
        public  void bilgileriEkranaYaz()
        {
            Console.WriteLine($"Alanı:{AlanHesapla():##.##}");
            Console.WriteLine($"Çevresi:{CevreHesapla()}");
        }
    }
    class Dikdortgen : Kare
    {
        int kenarB;
        public int KenarB
        {
            get
            {
                return kenarB;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("B kenar uzunluğu pozitif sayı olmalıdir!!");
                }
                else
                {
                    kenarB = value;
                }
            }
        }
        public Dikdortgen(int kenarA, int kenarB) : base(kenarA)
        {
            this.KenarB = kenarB;
        }
        public override double AlanHesapla()
        {
            return KenarA * KenarB;

        }
        public override int CevreHesapla()
        {
            return (KenarA + KenarB) * 2;
        }

    }

    class Ucgen : Dikdortgen
    {
        int kenarC;
        public int KenarC
        {
            get
            {
                return kenarC;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("C kenar uzunluğu pozitif sayı olmalıdir!!");
                }
                else
                {
                    kenarC = value;
                }
            }
        }
        public Ucgen(int kenarAparam,int kenarBparam,int kenarCparam) : base(kenarAparam, kenarBparam)
        {
            this.KenarC = kenarCparam;
        }

        public override int CevreHesapla()
        {
            return KenarA+KenarB+KenarC;
        }
        public override double AlanHesapla()
        {
            double u = CevreHesapla() / 2.0;
            double alan = Math.Sqrt(u * ( u - KenarA) * ( u - KenarB) * (u - KenarC));
            return alan;
        }
    }
```


