## Console Ekranında Menü Tasarımı ##
> Console ekranında menü tasarlarken while veya do-while dongüsünden faydalanabiliriz. Ayrıca kontrol işlemleri içinde if-else if-else yapısını veya switch case yapısını kullanabıliriz. 
> Bu yöntemler kulanılarak aşağıdaki menünün tasarımı yapılacaktır.

![image](https://user-images.githubusercontent.com/28144917/140269705-6efa3df3-1afa-4b8d-be88-dac90e67312c.png)

### While ve if - else if - else yapıları ile menünün tasarımı ###

```csharp
using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
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
                if (secim == 8)
                {
                    Console.WriteLine("Çıkış Yapılıyor.....");
                    System.Threading.Thread.Sleep(2000);// 2 saniye bekler
                    break;
                }else if (secim==1) {
                    Console.WriteLine("Sayi Ekle Seçildi");
                }
                else if (secim == 2)
                {
                    Console.WriteLine("Tek Sayıları Görüntüle");
                }
                else if (secim == 3)
                {
                    Console.WriteLine("Çift Sayıları Görüntüle");
                }
                else if (secim == 4)
                {
                    Console.WriteLine("Tek Sayıların toplamını Göster");
                }
                else if (secim == 5)
                {
                    Console.WriteLine("Çift Sayıların toplamını Göster");
                }
                else if (secim == 6)
                {
                    Console.WriteLine("Tek Sayıların ortalamasını Göster");
                }
                else if (secim == 7)
                {
                    Console.WriteLine("Çift Sayıların ortalamasını Göster");
                }
                else
                {
                    Console.WriteLine("Lütfen 1-8 Arası Rakam Giriniz...");
                    System.Threading.Thread.Sleep(2000);// 2 saniye bekler
                }
            }
        }

        static void menuyuEkranaBas()
        {
           
        }
    }
}

```
### While ve switch - case yapıları ile menünün tasarımı ###

```csharp
using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
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
                switch (secim)
                {
                    case 8:
                        Console.WriteLine("Çıkış Yapılıyor.....");
                        System.Threading.Thread.Sleep(2000);// 2 saniye bekler
                        return; // switch case yapısında Break ile döngü kırılmayacağından çıkış için return ile metodu sonlandırdık
                    case 1:
                        Console.WriteLine("Sayı Ekle ");
                        break;
                    case 2:
                        Console.WriteLine("Tek Sayıları Görüntüle");
                        break;
                    case 3:
                        Console.WriteLine("Çift Sayıları Görüntüle");
                        break;
                    case 4:
                        Console.WriteLine("Tek Sayıların toplamını Göster");
                        break;
                    case 5:
                        Console.WriteLine("Çift Sayıların toplamını Göster");
                        break;
                    case 6:
                        Console.WriteLine("Tek Sayıların ortalamasını Göster");
                        break;
                    case 7:
                        Console.WriteLine("Çift Sayıların ortalamasını Göster");
                        break;
                    
                    default:
                        Console.WriteLine("Lütfen 1-8 Arası Rakam Giriniz...");
                        System.Threading.Thread.Sleep(2000);// 2 saniye bekler
                        break;
                }
            }
        }

    
    }
}

```

### do-While ve switch - case yapıları ile menünün tasarımı ###
```csharp
using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            do
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
                Console.Write("Seçiminiz:");
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
                switch (secim)
                {
                    case 8:
                        Console.WriteLine("Çıkış Yapılıyor.....");
                        System.Threading.Thread.Sleep(2000);// 2 saniye bekler
                        break;
                    case 1:
                        Console.WriteLine("Sayı Ekle ");
                        break;
                    case 2:
                        Console.WriteLine("Tek Sayıları Görüntüle");
                        break;
                    case 3:
                        Console.WriteLine("Çift Sayıları Görüntüle");
                        break;
                    case 4:
                        Console.WriteLine("Tek Sayıların toplamını Göster");
                        break;
                    case 5:
                        Console.WriteLine("Çift Sayıların toplamını Göster");
                        break;
                    case 6:
                        Console.WriteLine("Tek Sayıların ortalamasını Göster");
                        break;
                    case 7:
                        Console.WriteLine("Çift Sayıların ortalamasını Göster");
                        break;

                    default:
                        Console.WriteLine("Lütfen 1-8 Arası Rakam Giriniz...");
                        System.Threading.Thread.Sleep(2000);// 2 saniye bekler
                        break;
                }


            } while (secim!=8);
        }

    
    }
}

```
