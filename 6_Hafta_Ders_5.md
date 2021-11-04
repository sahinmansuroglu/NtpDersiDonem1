##Soru:##

Uygulamanın Tamalanmış Hali

> Aşağıdaki işlemlerin yapılabileceği bir sınıf tanımlayınız ve ana programda bu sınıftan nesne oluşturarak çalıştırınız

1- Sınıfın Adı Islem olsun
2- Ekle adında bir metot olsun
   Parametre olarak verilen sayı tek ise tek sayıların Bulunduğu bir string (tekSayilar) listeye ekleyecek
   Parametre olarak verilen sayı çift ise çift sayıların Bulunduğu bir string (ciftSayilar)listeye ekleyecek
   istenildiğinde bu liste ekrana yazdırılabilecek

3- İstenildiğinde bu tek sayıların ve çift sayıların adedini, toplamı ve ortalaması öğrenilebilecek

Ana Programda bulunacak olan Menü

*****İşlemler*******
1- Sayi Ekle
2- Tek Sayıları Görüntüle
3- Çift Sayıları Görüntüle
4- Tek Sayıların toplamını Göster
5- Çift Sayıların toplamını Göster
6- Tek Sayıların ortalamasını Göster
7- Çift Sayıların ortalamasını Göster
8- Çıkış

### Islem sınıfının kodları ###

```csharp
 public class Islem
    {
        string tekSayilar = "";
        string ciftSayilar = "";
        int teklerinAdedi = 0;
        int teklerinToplami = 0;
        int ciftlerinAdedi = 0;
        int ciftlerinToplami = 0;
        public double TeklerinOrtalamasi 
        {
            get
            {
                return (double)teklerinToplami /teklerinAdedi;
            }
        }
        public double CiftlerinOrtalamasi
        {
            get
            {
                return (double) ciftlerinToplami / ciftlerinAdedi;
            }
        }
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

### Ana Program kodları ###

```csharp
 class Program
    {
        static void Main(string[] args)
        {
            Islem islemNesne = new Islem();

            while (true)
            {
                menuyuEkranaBas();
                Console.Write("Seçiminiz:");
                int secim;
                try
                {
                   secim = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Hatalı Seçim yapıldı...");
                    Console.WriteLine("Çıkış Yapılıyor.....");
                    System.Threading.Thread.Sleep(2000);// 2 saniye bekler
                    break;    // return ile de yapılabilir.

                }
                Console.Clear();
                switch (secim)
                {
                    case 8:
                        Console.WriteLine("Çıkış Yapılıyor.....");
                        System.Threading.Thread.Sleep(2000);// 2 saniye bekler
                        return; // switch case yapısında  break zaten kullanıldığı için Break  komutu ile ile döngü kırılamaz. Çkış için return ile metod sonlandırıldı.
                    case 1:
                        Console.Clear();
                        Console.Write("Lütfen bir sayı giriniz:");
                        int sayi = Convert.ToInt32(Console.ReadLine());
                        islemNesne.sayiEkle(sayi);
                        break;
                    case 2:
                        Console.WriteLine($"Tek Sayılar:{islemNesne.TekSayilar} ");
                        break;
                    case 3:
                        Console.WriteLine($"Çift Sayılar:{islemNesne.CiftSayilar} ");
                        break;
                    case 4:
                        Console.WriteLine($"Tek Sayılar:{islemNesne.TekSayilar} ");
                        Console.WriteLine($"Tek Sayılar toplam:{islemNesne.TeklerinToplami} ");
                        break;
                    case 5:
                        Console.WriteLine($"Çift Sayılar:{islemNesne.CiftSayilar} ");
                        Console.WriteLine($"Çift Sayılar toplam:{islemNesne.CiftlerinToplami} ");
                        break;
                    case 6:
                        Console.WriteLine($"Tek Sayılar:{islemNesne.TekSayilar} ");
                        Console.WriteLine($"Tek Sayılar ortalama:{islemNesne.TeklerinOrtalamasi} ");
                        break;
                    case 7:
                        Console.WriteLine($"Çift Sayılar:{islemNesne.CiftSayilar} ");
                        Console.WriteLine($"Çift Sayılar ortalama:{islemNesne.CiftlerinOrtalamasi} ");

                        break;
                    
                    default:
                        Console.WriteLine("Lütfen 1-8 Arası Rakam Giriniz...");
                        System.Threading.Thread.Sleep(2000);// 2 saniye bekler
                        break;
                }
                Console.WriteLine("Devam etmek için bir tuşa basınız....");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void menuyuEkranaBas()
        {
            Console.WriteLine("*****İşlemler * ******");
            Console.WriteLine("1 - Sayi Ekle");
            Console.WriteLine("2 - Tek Sayıları Görüntüle");
            Console.WriteLine("3 - Çift Sayıları Görüntüle");
            Console.WriteLine("4 - Tek Sayıların toplamını Göster");
            Console.WriteLine("5 - Çift Sayıların toplamını Göster");
            Console.WriteLine("6 - Tek Sayıların ortalamasını Göster");
            Console.WriteLine("7 - Çift Sayıların ortalamasını Göster");
            Console.WriteLine("8 - Çıkış");
        }
    }
```
