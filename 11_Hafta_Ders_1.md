## Soyut Sınıflar (Abstract Classes) ##
> __1.__ Soyut  Sınıflar Nesne tabanlı programlamanın  önemli kavramlarından biridir. 

> __2.__ Birden fazla classın kullanıldığı uygulamalarda ortak özelliklerin bir class içerisinde toplanabilmesi için kullanılır.

> __3.__ Soyut sınıf ve metot tanımlamak için "abstract" keywordu kullanılır.

> __4.__ Soyut Sınıfların içerisinde soyut olmayan metot ve özellikler de bulunabilir.

> __5.__ Soyut sınıflardan nesne oluşturulamaz. Ancak başvurusu(referansı) oluşturulabilir.

> __6.__ Soyut sınıflardan türetilen sınıflar abstract metotları override ederek içerisinde tekrar tanımmalaması gerekir.

**Örnek Kullanım**

````csharp 
public abstract class TemelSinif
{
    public void metot1()
    {
        Console.WriteLine("Temel sınıf içerisinde tanımlanmış bir metot");
    }
    public abstract void metot2();
}
````
**Örnek-1**
```csharp
using System;

    class Program
    {
        static void Main(string[] args)
        {
            Kare kare1 = new Kare { KenarA = 4};
            Console.WriteLine($" Alan:{kare1.alanHesapla()}");
            Console.ReadKey();
        }
    }
    abstract class Alan
    {
        public abstract int alanHesapla();

    }

    class Kare : Alan
    {
        public int KenarA { get; set; }

        public override int alanHesapla()
        {
            return KenarA * KenarA;
        }
    }


```

**Örnek-2**
> 1. Aşağıda verilenlere göre Hesap isimli abstract class oluşturunuz.


    a.  int alan() ve int cevre() adında abstract metot bulunacak.
    b.  Baslik isminde abstract Property bulunacak
    c.  bilgileriEkranaYaz() isimli bir metot bulunacak
    
> 2. Aşağıda verilenlere Hesap isimli class'dan Kare classını türetiniz.

    a. a kenar uzunluğu için KenarA adında bir property tanımlayın.
    b. Baslik isimli property override edilerek değeri "Kare Hesaplama Bilgileri" atanacaktır.
    c. alan() ve cevre() metotları override edilerek hesaplaması yaptırılacak
    
> 3. Aşağıda verilenlere Hesap isimli class'dan Dikdörtgen classını türetiniz.

    a. a kenar uzunluğu için KenarA ve b kenar uzunluğu için KenarB adında  property tanımlayın.
    b. Baslik isimli property override edilerek değeri "Dikdörtgen Hesaplama Bilgileri" atanacaktır.
    c. alan() ve cevre() metotları override edilerek hesaplaması yaptırılacak
  
> 3. Aşağıda verilenlere Hesap isimli class'dan  Dikdörtgen  classını türetiniz.

    a. Yarıçap uzunluğu  için Yaricap adında  bir property tanımlayın.
    b. Baslik isimli property override edilerek değeri "Daire Hesaplama Bilgileri" atanacaktır.
    c. alan() ve cevre() metotları override edilerek hesaplaması yaptırılacak

> 4. Oluşturulan sınıflardan nesneler oluşturarak bilgilerini ekrana yazdırınız.
```csharp
using System;
class Program
{
    static void Main(string[] args)
    {
        Kare kare1 = new Kare { KenarA = 4 };
        kare1.bilgileriEkranaYaz();

        Dikdortgen dikdortgen1 = new Dikdortgen {KenarA = 20, KenarB = 10 };
        dikdortgen1.bilgileriEkranaYaz();

        Daire daire1 = new Daire { Yaricap = 3 };
        daire1.bilgileriEkranaYaz();
        Console.ReadKey();
    }
}
abstract class Hesap
{
    abstract public string Baslik { get; set; }
    abstract public int alan();
    abstract public int cevre();
    public void bilgileriEkranaYaz()
    {
        Console.WriteLine($"{Baslik} Bilgileri");
        Console.WriteLine($"Alan:{alan()}");
        Console.WriteLine($"Çevre:{cevre()}");
    }
}

class Kare : Hesap
{
    public int KenarA { get; set; }
    public override string Baslik { get; set; } = "Kare";

    public override int alan()
    {
        return KenarA * KenarA;
    }

    public override int cevre()
    {
        return KenarA * 4;
    }

}

class Dikdortgen : Hesap
{
    public override string Baslik { get; set; } = "Dikdortgen";
    public int KenarA { get; set; }
    public int KenarB { get; set; }
    public override int alan()
    {
        return KenarA * KenarB;
    }

    public override int cevre()
    {
        return (KenarA + KenarB) * 2;
    }
}

class Daire : Hesap
{
    public override string Baslik { get; set; } = "Daire";
    public int Yaricap { get; set; }

    public override int alan()
    {
        return Convert.ToInt32(Math.PI * Yaricap * Yaricap);
    }

    public override int cevre()
    {
        return Convert.ToInt32(Math.PI * Yaricap * 2);
    }
}
```
**Örnek-3**

> Aşağıdaki Verilenlere Göre Ogrenci abstract class'ını tanımlayınız.

    1. AdSoyad property'si olacak
    2. bilgileriEkranaYaz metodu alacak
    3. enOnemliOlayi() adında bir abstract metodu olacak
    
> LiseOgrencisi isminde bir class'ı Ogrenci Class'ından türetin.
    
    enOnemliOlayi() metodu "LGS Sınavı" şeklinde string döndürsün.
    
> OrtaOkulOgrencisi isminde bir class'ı Ogrenci Classindan türetin
    
    enOnemliOlayi() metodu "YKS Sınavı" şeklinde string döndürsün
    
> Son olarak LiseOgrencisi ve  OrtaOkulOgrencisi  sınıflarından nesne türetip ekrana yazdırınız


