## Console Ekranında kullanıcıdan veri alma
Konsole ekranında kullanıcının girdiği veri satırının tümünü okumak için Console.ReadLine() metodu kullanılır. 
Bu metot ile kullanıcının alınan verinin tipi string'dir. 
#### Örnek
Kullanıcıdan alınan ad soyad bilgisi kullanılarak kişiye hoşgeldin mesajı veren uygulama.
```csharp
static void Main(string[] args)
        {

            Console.Write("Lütfen adınızı ve soyadınızı giriniz:");
            string adSoyad = Console.ReadLine();
            Console.WriteLine($"Merhaba sayın {adSoyad}");
            Console.ReadKey();
        }
```
  #### Ekran Çıktısı :rocket
```diff
Lütfen adınızı ve soyadınızı giriniz:  Şahin MANSUROĞLU 
Merhaba sayın Şahin MANSUROĞLU
```


#### Örnek :rocket
Kullanıcıdan alınan ad soyad, yas ve boy bilgisini ekrana yazdıran program.

```csharp
static void Main(string[] args)
        {

            Console.Write("Lütfen adınızı ve soyadınızı giriniz:");
            string adSoyad = Console.ReadLine();

            Console.Write("Lütfen yaşınızı giriniz:");
            byte yas = Convert.ToByte(Console.ReadLine());

            Console.Write("Lütfen boyunuzu giriniz:");
            double boy = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Ad ve Soyadınız:{adSoyad}");
            Console.WriteLine($"Yaşınız:{yas}");
            Console.WriteLine($"Boyunuz:{boy}");

            Console.ReadKey();
        }
```
  #### Ekran Çıktısı
```
Lütfen adınızı ve soyadınızı giriniz: Şahin MANSUROĞLU
Lütfen yaşınızı giriniz:38
Lütfen boyunuzu giriniz:1,77
Ad ve Soyadınız:Şahin MANSUROĞLU
Yaşınız:38
Boyunuz:1,77
```
