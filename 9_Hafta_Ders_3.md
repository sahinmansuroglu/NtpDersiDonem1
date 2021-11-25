 ## Metotları referans ile çağırma(call by reference) ## 
> Referans türündeki parametreler bir metoda geçirildiğinde parametre üzerindeki herhangi bir değişiklik metodun çağrıldığı yere de yansıyacaktır.

> Aşağıdaki programı inceleyecek olursak adDegistir metoduna Kisi sınıfından oluşturulmuş kisi1 nesnesi geçirilmektedir. Sınıflar referans türü olduğundan metoda nesnenin adresi gönderilir. Ve metod içerisinde nesne ile ilgili yapılan değişiklikler metodun çağrıldığı yerde de gözlenir.
```csharp
 class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi1 = new Kisi();
            kisi1.adSoyad = "Veli";
            Console.WriteLine($"[Ana Program] ad:{kisi1.adSoyad}");
            adDegistir(kisi1);
            Console.WriteLine($"[Ana Program] ad:{kisi1.adSoyad}");
            Console.ReadKey();
        }

        static void adDegistir(Kisi kisi)
        {
            kisi.adSoyad = "Ali";
            Console.WriteLine($"[Method] ad:{kisi.adSoyad}");
        }
      
        
    }

    class Kisi
    {
        public string adSoyad;
    }
```
**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/143420085-b84a4f00-ced8-4b29-8660-40f94ba71d4a.png)



**Örnek**
> Aşağıdaki örnek  referans ile metot çağrımına bir örnektir. Oluşturulan ogr1 nesnesinin ortalama ve durum alanları farklı bir metot içerisinde hesaplatılmıştır. Bu metotlara ogr1 nesnesinin referansı geçirildiği için metot içerisinde hesaplanan ortalama ve durum bilgileri ana programdaki nesnenin içerisine yerleşmiştir.

```csharp
 class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr1;
            ogr1 = new Ogrenci();
            ogr1.adSoyad = "Ali Veli";
            ogr1.n1 = 34;
            ogr1.n2 = 60;
            ogr1.n3 = 80;
            ogrencininOrtalamasiniHesapla(ogr1);
            durumHesapla(ogr1);
            Console.WriteLine($"Ortalama:{ogr1.ort}");
            Console.WriteLine($"Durum:{ogr1.durum}");
            Console.ReadKey();
        }
        public static void ogrencininOrtalamasiniHesapla(Ogrenci ogrRef)
        {
            ogrRef.ort = (ogrRef.n1 + ogrRef.n2 + ogrRef.n3) / 3.0;
        }
        public static void durumHesapla(Ogrenci ogr)
        {
            if (ogr.ort < 50)
            {
                ogr.durum = "Kaldınız..";
            }
            else
            {
                ogr.durum = "Geçtiniz..";
            }
        }

    }
    class Ogrenci
    {
        public string adSoyad;
        public int n1;
        public int n2;
        public int n3;
        public double ort;
        public string durum;

    }
```

**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/143422206-2d6d7661-8e93-49b1-aab9-86c6268c9d52.png)


