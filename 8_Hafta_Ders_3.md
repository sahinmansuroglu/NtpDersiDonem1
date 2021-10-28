## Bitmeyen  Sayı Oyunu Uygulaması ##

[Uygulamanın Tamalanmış Hali](https://github.com/sahinmansuroglu/NtpDersi/files/7431847/SayiOyunu.zip)


> Bu uygulamada oyun sürekli her kazanılan level sonrası bir üst levelden çalışmaya devam etmiştir.

> Oyun ile ile ilgili temel işlemler aşağıdaki Oyun class'ı içerisinde tanımlanmıştır.
```csharp

  class Oyun
    {
        short tutulanRastgeleSayi;
        byte maxHakSayisi=10;
        byte kalanHakSayisi;
        byte seviye = 1;
        string oyunDurum = "Devam";
        string levelDurum = "Devam";
        public string LevelDurum
        {
            get
            {
                return levelDurum;
            }
        }
        public string OyunDurum
        {
            get
            {
                return oyunDurum;
            }
        }

       public  string veriGirisiAciklama
        {
            get
            {
                return $" Seviye: {seviye}  \n Lütfen 1 ile {seviye * 50} arası sayı giriniz:";
            }
        }



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
            tutulanRastgeleSayi = (short)randomNesnesi.Next(1, seviye*50);
            kalanHakSayisi = maxHakSayisi;
            levelDurum = "Devam";
        }
        public string testEt( short girilenSayi)
        {
            kalanHakSayisi--;
            if (kalanHakSayisi > 1)
            {
                    if (girilenSayi == tutulanRastgeleSayi)
                    {
                        levelDurum = "Tamamlandi";
                        seviye++;
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
                oyunDurum = "Bitti";
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

            while (oyun.OyunDurum!="Bitti")
            {
              
                Console.Write(oyun.veriGirisiAciklama);
                short girilenSayi = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine(oyun.testEt(girilenSayi));

                if (oyun.LevelDurum== "Tamamlandi")
                {
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Bir Üst Level Hazırlanıyor");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    oyun.yeniOyunBaslat();

                }
            }
            Console.ReadKey();
        }
    }
    
    ```
