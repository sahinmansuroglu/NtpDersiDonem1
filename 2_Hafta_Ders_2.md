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
  #### Ekran Çıktısı
```diff

+ Lütfen adınızı ve soyadınızı giriniz: - Şahin MANSUROĞLU - +
Merhaba sayın Şahin MANSUROĞLU
+ Green Text
- Red Text

+ some-text +
- some-text -
# some-text #
* some-text *
```


