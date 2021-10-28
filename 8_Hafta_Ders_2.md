## Basit Sayı Oyunu Uygulaması ##

[Uygulamanın Tamalanmış Hali ](https://github.com/sahinmansuroglu/NtpDersi/files/7431587/SayiOyunu.zip)

> Basit Sayı Oyunu uygulaması bilgiyarın 0-100 arasında tuttuğu rastgele sayıyı 10 hakta tahmin etmemizi sağlayan bir uygulamadır.

> Oyun ile ile ilgili temel işlemler  aşağıdaki Oyun class'ı içerisinde tanımlanmıştır.

```csharp
  class Oyun
    {
        short tutulanRastgeleSayi;
        byte maxHakSayisi=10;
        byte kalanHakSayisi;

        public byte KalanHakSayisi
        {
            get
            {
                return kalanHakSayisi;
            }
        }
        public Oyun()
        {
            yeniOyunBaslat();
        }
        public void yeniOyunBaslat()
        {
            Random randomNesnesi = new Random();
            tutulanRastgeleSayi = (short)randomNesnesi.Next(1, 100);
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
            Oyun oyun = new Oyun();
            oyun.yeniOyunBaslat();

            while (oyun.KalanHakSayisi>0)
            {
                Console.Write("Lütfen 1-100 arası Sayı Giriniz:");
                short girilenSayi = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine(oyun.testEt(girilenSayi));
            }
            Console.ReadKey();
        }
    }
```
