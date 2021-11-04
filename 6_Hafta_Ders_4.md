  ## Örnek-1  ##
 Aşağıdaki Örnek çalıştırıldığında aşağıdaki çıktıyı verebilmesi için sayiEkle metodunun içerisindeki noktalı yerlere yazılması gerekn kodu yazınız.
  
  **Vermesi Gereken Çıktı**
  
  ![image](https://user-images.githubusercontent.com/28144917/140282401-cef8c36e-a8f5-4d0b-bbf9-436460285362.png)


```csharp
   class Program
    {
        static void Main(string[] args)
        {
            Islem islemNesnesi = new Islem();

            islemNesnesi.sayiEkle(95);
            islemNesnesi.sayiEkle(65);
            islemNesnesi.sayiEkle(20);
            islemNesnesi.sayiEkle(24);
            islemNesnesi.sayiEkle(92);

            Console.WriteLine($"Tek Sayilar:{islemNesnesi.TekSayilar}");
            Console.WriteLine($"Çift Sayilar:{islemNesnesi.CiftSayilar}");
            Console.ReadKey();
        }
    }
    public class Islem
    {
        string tekSayilar = "";
        string ciftSayilar = "";
        public string TekSayilar
        {
            get
            {
                return tekSayilar;
            }
        }
        public string CiftSayilar
        {
            get
            {
                return ciftSayilar;
            }
        }
        public void sayiEkle(int sayi)
        {
            if (sayi % 2 == 0)
            {
                //sayi çift ise bu blok çalışır
                //.......................... (1)
            }
            else
            {
                //sayi tek ise bu blok çalışır 
                //.......................... (2)
            }
        }
    }
 ```
 
 **Çözüm**
    

  ```csharp 
   public void sayiEkle(int sayi)
        {
            if (sayi % 2 == 0)
            {
                //sayi çift ise bu blok çalışır
                ciftSayilar = $"{ciftSayilar} {sayi}";
            }
            else
            {
                //sayi tek ise bu blok çalışır 
                tekSayilar = $"{tekSayilar} {sayi}";
            }
        }
  ```

  ## Örnek-2  ##
 > Yukarıdaki örnekte girilen tek sayıların ve çift sayıların adedini, toplamını ve ortalamasını hesaplatabilmek için gereken değişiklikleri işlem sınıf içerisinde yapınız.

  ```csharp 
   class Program
    {
        static void Main(string[] args)
        {
            Islem islemNesnesi = new Islem();

            islemNesnesi.sayiEkle(95);
            islemNesnesi.sayiEkle(65);
            islemNesnesi.sayiEkle(20);
            islemNesnesi.sayiEkle(24);
            islemNesnesi.sayiEkle(92);

            Console.WriteLine($"Tek Sayilar:{islemNesnesi.TekSayilar}");
            Console.WriteLine($"Çift Sayilar:{islemNesnesi.CiftSayilar}");
            Console.WriteLine($"Tek Sayilar adet:{islemNesnesi.TeklerinAdedi}");
            Console.WriteLine($"Çift Sayilar adet:{islemNesnesi.CiftlerinAdedi}");
            Console.WriteLine($"Tek Sayilar toplam:{islemNesnesi.TeklerinToplami}");
            Console.WriteLine($"Çift Sayilar toplam:{islemNesnesi.CiftlerinToplami}");
            Console.WriteLine($"Tek Sayilar ortalama:{islemNesnesi.TeklerinOrtalamasi}");
            Console.WriteLine($"Çift Sayilar ortalama:{islemNesnesi.CiftlerinOrtalamasi}");
            Console.ReadKey();
        }
    }
  public class Islem
    {
        string tekSayilar = "";
        string ciftSayilar = "";
        int teklerinAdedi = 0;
        int teklerinToplami = 0;
        int ciftlerinAdedi = 0;
        int ciftlerinToplami = 0;
        public int TeklerinAdedi
        {
            get
            {
                return teklerinAdedi;
            }
        }
        public int CiftlerinAdedi
        {
            get
            {
                return ciftlerinAdedi;
            }
        }

        public int TeklerinToplami
        {
            get
            {
                return teklerinToplami;
            }
        }

        public int CiftlerinToplami
        {
            get
            {
                return ciftlerinToplami;
            }
        }
        public double TeklerinOrtalamasi 
        {
            get
            {
                return teklerinToplami/teklerinAdedi;
            }
        }
        public double CiftlerinOrtalamasi
        {
            get
            {
                return ciftlerinToplami / ciftlerinAdedi;
            }
        }
        public string TekSayilar
        {
            get
            {
                return tekSayilar;
            }
        }
        public string CiftSayilar
        {
            get
            {
                return ciftSayilar;
            }
        }
        public void sayiEkle(int sayi)
        {
            if (sayi % 2 == 0)
            {
                //sayi çift ise bu blok çalışır
                ciftSayilar = $"{ciftSayilar} {sayi}";
                ciftlerinAdedi++;
                ciftlerinToplami += sayi;
            }
            else
            {
                //sayi tek ise bu blok çalışır 
                tekSayilar = $"{tekSayilar} {sayi}";
                teklerinAdedi++;
                teklerinToplami += sayi;
            }
        }
    }
    
      ```
