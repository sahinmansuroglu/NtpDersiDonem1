  ## Örnek-1  ##
 Aşağıdaki Örnek çalıştırıldığında aşağıdaki çıktıyı verebilmesi için noktalı yere yazılması gerekn kodu yazınız.
  
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
    
  > //.......................... (1) satırının olduğu yere  ```csharp ciftSayilar = $"{ciftSayilar} {sayi}";  ```
  
  > //.......................... (2) satırının olduğu yere  ```csharp tekSayilar = $"{tekSayilar} {sayi}";  ```
