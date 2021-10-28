## Kolay Orta Zor Seçenekli Sayı Oyunu Uygulaması ##
[Uygulamanın Tamalanmış Hali ](https://github.com/sahinmansuroglu/NtpDersi/files/7432101/SayiOyunu.zip)

> Oyun ile ile ilgili temel işlemler  aşağıdaki Oyun class'ı içerisinde tanımlanmıştır.

```csharp
class Oyun
    {
        short tutulanRastgeleSayi;
        byte maxHakSayisi = 10;
        byte kalanHakSayisi;
        int maxDeger;

        public byte KalanHakSayisi
        {
            get
            {
                return kalanHakSayisi;
            }
        }

        public string SayiGirisAciklama{
            get
            {
                return $"0 ile {maxDeger} arasında bir sayı giriniz:";
            }
        }

        public void yeniOyunBaslat(string seviye )
        {
            int minDeger=0,maxDeger=150;
            
            if (seviye == "K")
            {
                maxDeger = 100;
                maxHakSayisi = 15;
            } 
            else if (seviye == "Z")
             {
                maxDeger = 200;
                maxHakSayisi = 5;
            }

       
            this.maxDeger = maxDeger;
            Random randomNesnesi = new Random();
            tutulanRastgeleSayi = (short)randomNesnesi.Next(minDeger, maxDeger);
            kalanHakSayisi = maxHakSayisi;

        }
        public string testEt( short girilenSayi)
        {
            kalanHakSayisi--;
            if (kalanHakSayisi > 1)
            {
                    if (girilenSayi == tutulanRastgeleSayi)
                    {
                        kalanHakSayisi = 0;
                        return "Tebrikler Doğru Tahmin Ettiniz....";
                    }
                    else if (girilenSayi < tutulanRastgeleSayi)
                    {
                        return $"Kalan Hak Sayısı:{kalanHakSayisi}, Lütfen Sayıyı BÜYÜLTÜNÜZ....";
                    }
                    else 
                    {
                        return $"Kalan Hak Sayısı:{kalanHakSayisi},Lütfen Sayıyı KÜÇÜLTÜNÜZ....";
                    }
            }
            else
            {
                return "Kalan Hakkınız Bitmiştir; Oyunu Kaybettiniz..";
            }
        
        }

    }
```

> Ana Program

```csharp
 class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("******Oyun Seçim Menüsü*******");
                Console.WriteLine("K-Kolay \nO-Orta \nZ-Zor \nÇ-Çıkış");
                Console.Write("Seçiminiz (K, O, Z, Ç)--->");
                string secim = Console.ReadLine();
                if (secim == "Ç")
                {
                    Console.WriteLine("Çıkış Yapılıyor");
                    System.Threading.Thread.Sleep(2000);
                    break;

                }
                else
                {
                    yeniOyunBolumuBaslat(secim);

                }
             
            }
        }

        public static void yeniOyunBolumuBaslat(string seviye)
        {
            Console.Clear();
            Oyun oyun = new Oyun();
            oyun.yeniOyunBaslat(seviye);

            while (oyun.KalanHakSayisi > 0)
            {
                Console.Write(oyun.SayiGirisAciklama);
                short girilenSayi = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine(oyun.testEt(girilenSayi));
            }
            Console.WriteLine("Yeni Oyun Menüsüne Dönülüyor....");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
        }
    }
```
