## İsimsiz Sınıflar(Anonymous Classes) ##

> İsimsiz sınıflar yalnızca salt okunur özellikleri  içeren ve adı olmayan sınıflardır. Alan, metot gibi  diğer ögeleri barındıramaz. Sınıf özelliklerinin 
veri tipleri, aldığı değere göre otomatik olarak  belirlenir.

Bir isimsiz sınıf, var anahtar kelimesi ile tanımlanır ve new anahtar kelimesi ile oluşturulur.

**Örnek-1**
```csharp
   class Program
    {
        static void Main(string[] args)
        {
            var Ogrenci = new    {
                Ad = "Ahmet",
                soyad="EREN",
                Puan1 = 45,
                Puan2 = 33
            };
            //Aşağıdaki kod hata verecektir Çünkü isimsizi sınıfların içeriği değiştirelemez Sadece okunabilirdir.
           // Ogrenci.Ad = "Veli"; 
            Console.WriteLine($" Ad Soyad: {Ogrenci.Ad} {Ogrenci.soyad}");
            Console.WriteLine($"Puan1: {Ogrenci.Puan1} {Ogrenci.Puan2}");
            Console.ReadKey();
        }
    }
    

```
**Örnek-2**
```csharp

           var Ogrenci = new    {
                Ad = "Ahmet",
                Soyad="EREN",
                DogumYeri=new {
                    il="Mersin",
                    ilce="Mezitli"
                },

                Puanlar=new
                {
                    Puan1 = 45,
                    Puan2 = 33,
                }
            };
  
            Console.WriteLine($"Ad Soyad: {Ogrenci.Ad} {Ogrenci.Soyad}");
            Console.WriteLine($"Puan1: {Ogrenci.Puanlar.Puan1} {Ogrenci.Puanlar.Puan2}");
            Console.WriteLine($"Dogum Yeri: {Ogrenci.DogumYeri.il} {Ogrenci.DogumYeri.ilce}");
            Console.ReadKey();
```
