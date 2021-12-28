## ArrayList Koleksiyonu ##

> ArrayList koleksiyonu diziler gibi birden fazla veriyi tutmak için kullanılan yapılardır. Ancak ArrayList dinamik bir yapıya sahiptir. Çalışma zamanında ekleme, silme değiştirme ve araya ekleme gibi işlemlere imkan vermektedir.
> ArrayList içine eklenen elemanlar object tipinde olacağı için veri eklerken boxing (kutulama), veri alırken de unboxing (kutu açma) işlemi yapılmaktadır.

**Not:** Eleman sayısının fazla olduğu ArrayList'lerde boxing ve unBoxing işleminden dolayı performans kaybı yaşanabilir. Bu problemi yaşamamak için ay tipte verilerden
liste oluşturulabilmesini sağlayan List<object> yapısı kullanılabilir.
  
## ArrayList'lerde kullanılan Metot ve Özellikler ##
  
|Özellik/Metot Adı|Açıklama| Örnek Kullanim|
|---------|---------|---------|
|Count Özelliği |listedeki eleman sayısını verir. | listeAdi.Count |
|Add()|Listenin sonuna tek bir eleman ekler| hayvanlar.Add("Kedi") |
|AddRange()|Başka bir koleksiyon içindeki tüm elemanları liste sonuna ekler | hayvanlar.AddRange(digerListe) |
|Insert()|Elemanı Listenin istenilen sirasına ekler | hayvanlar.Insert(3,"Koyun"); |
|InsertRange()|Başka bir koleksiyon içindeki tüm elemanları Listenin istenilen sirasına ekler |  hayvanlar.InsertRange(3,digerListe); |
|Remove()|Elemanı Listeden siler | hayvanlar.Remove("Koyun"); |
|RemoveRange()|Başka bir koleksiyon içindeki tüm elemanları Listeden siler |  hayvanlar.RemoveRange(digerListe); |
|RemoveAt()|Index numarası verilen elemanı listeden siler|  hayvanlar.RemoveAt(3); |
| Clear()|Listenin tüm elemanlarını  temizler|  hayvanlar.Clear()|
| Sort()|Listedeki elemanları  sıralar.|  hayvanlar1.Sort( |
| Reverse()|Listeyi ters çevirir |  hayvanlar.Reverse() |
| CopyTo()|Listedeki tüm elemanları bir diziye kopyalar |  hayvanlar.CopyTo(Dizi) |  
| Contains()|Herhangi bir elemanın listede bulunup bulunmadığını test eder. |  hayvanlar.Contains("Kedi") |   
| IndexOf|verilen elemanı arar. Bulursa index değerini verir, bulamazsa -1 döndürür | hayvanlar.IndexOf("Kedi") |
 ### Örnek Kullanım-1 ###
  ```csharp
  static void Main(string[] args)
        {
  
             ArrayList adList = new ArrayList();
            //Listeye Elaman Ekleme
            adList.Add("Ahmet");
            adList.Add("Aydın");
            adList.Add("Mehmet");
            adList.Add("Akın");
            adList.Add("Erdi");
            adList.Remove("Mehmet");// Mehmet Elemanını siler
            adList.RemoveAt(2);// 2 İndex no lu elamanı siler
            adList.Insert(3, "Sezgin");
            Console.Write("Liste:");
            //Ekrana **Liste:Ahmet Aydın Erdi Sezgin** Yazar
            foreach (var ad in adList)
            {
                Console.Write($"{ad} ");
            }
            Console.WriteLine();

            adList.Sort();
            adList.Reverse();

            //Ekrana **Liste: Sezgin Erdi Aydın Ahmet** Yazar
            Console.Write("Liste:");
            foreach (var ad in adList)
            {
                Console.Write($"{ad} ");
            }
            Console.ReadKey();
        }
  ```
  
**Ekran Çıktısı**
  
  ![image](https://user-images.githubusercontent.com/28144917/147539336-d9785171-2105-4c2c-9a15-5d7423c16ce0.png)

  ### Örnek Kullanım-2 ###
  ```csharp
   static void Main(string[] args)
        {
            ArrayList sayilist = new ArrayList();
            //Listeye Elaman Ekleme
            sayilist.Add(68);
            sayilist.Add(25);
            sayilist.Add(96);
            sayilist.Add(25);

            int toplam = (int)sayilist[0] + (int)sayilist[1] + (int)sayilist[2] + (int)sayilist[2];
            double ortalama = (double)toplam / sayilist.Count;

            Console.Write("Sayi Listesi:");
            foreach (var sayi in sayilist)
            {
                Console.Write($"{sayi} ");
            }
            Console.WriteLine();
            Console.WriteLine($" Toplam:{toplam}");
            Console.WriteLine($" Ortalama:{ortalama}");
            Console.ReadKey();
            
        }
  ```
  
**Ekran Çıktısı**
  
![image](https://user-images.githubusercontent.com/28144917/147539692-a6bf4c45-7d4b-4b39-b892-dd1f7408f38d.png)
  
  
  ### Örnek-1 ###
> Aşağıdaki işlemleri sırasıyla yaparak uygulamayı tamamlayınız.
  
      - Liste adında bir ArrayList oluşturun.
      - Klavyeden girilen 10 sayıyı listeye eklettirin
      - Listeyi ekrana yazdırın
      - Listedeki sayıların toplamını hesaplatıp ekrana yazdırın
      - Listedeki tek sayıların adedini hesaplatıp ekrana yazdırın
      - Listedeki çift sayıların adedini hesaplatıp ekrana yazdırın
      - Listeyi sıralatıp ekrana yazdırın

  
 **Çözüm**
  
  ```csharp
  
### Örnek-2 ###
> Aşağıdaki işlemleri sırasıyla yaparak uygulamayı tamamlayınız.
  
      - hayvanlar adında bir ArrayList listesi oluşturunuz.
      - Oluşturduğunuz listeye 5 adet hayvan adı (Kedi, Köpek, Ayı, Aslan, Fil) ekleyiniz.
      - Listedeki hayvan adlarını hem foreach hem de for döngüsü ile ekrana yazdırınız. 
      - Listeyi A'dan Z'ye sıralatarak ekrana yazdırınız.
      - Listenin 2 index numaralı hücresine "Koala" string'ini ekletin.
      - Listenin 3 index numaralı elemanını sildirin.
      - Listenin son halini ekrana yazdırınız.
      - Listede "Zürafa" string'inin olup olmadığını test ederek uygun mesajı ekrana yazdırınız.
      - Listedeki tüm elemanları temizleyiniz.
  
 **Çözüm**
  
  ```csharp
  static void Main(string[] args)
        {
            ArrayList hayvanlar = new ArrayList();
            hayvanlar.Add("Kedi");
            hayvanlar.Add("Köpek");
            hayvanlar.Add("Ayı");
            hayvanlar.Add("Aslan");
            hayvanlar.Add("Fil");
            Console.Write("Listeleme (Foreach):");
            foreach (var hayvan in hayvanlar)
            {
                Console.Write($"{hayvan} ");
            }
            Console.WriteLine();
            Console.Write("Listeleme (For):");
            for (int i = 0; i < hayvanlar.Count; i++)
            {
                Console.Write($"{hayvanlar[i]} ");
            }
            Console.WriteLine();
            hayvanlar.Sort();
            Console.Write("Sıralı Liste:");
            foreach (var hayvan in hayvanlar)
            {
                Console.Write($"{hayvan} ");
            }
            Console.WriteLine();
            hayvanlar.Insert(2, "Koala");
            hayvanlar.RemoveAt(3);
            Console.Write("Ekleme ve Silme Sonrası:");
            foreach (var hayvan in hayvanlar)
            {
                Console.Write($"{hayvan} ");
            }
            //Contains ile
            if (hayvanlar.Contains("Zürafa"))
            {
                Console.WriteLine("Listede zürafa bulunmaktadır ");
            }
            else
            {
                Console.WriteLine("Listede zürafa bulunmamaktadır ");
            }
            //IndexOfla
            if (hayvanlar.IndexOf("Zürafa")!=-1)
            {
                Console.WriteLine("Listede zürafa bulunmaktadır ");
            }
            else
            {
                Console.WriteLine("Listede zürafa bulunmamaktadır ");
            }
            Console.ReadKey();
        }
  
  ```
> Yukarıdaki uygulama methot kullanılarak aşağıdaki gibi daha okunabilir hale getirilebilir
  
  ```csharp
   class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int sayi = random.Next(0, 100);

            ArrayList hayvanlar = new ArrayList();
            hayvanlar.Add("Kedi");
            hayvanlar.Add("Köpek");
            hayvanlar.Add("Ayı");
            hayvanlar.Add("Aslan");
            hayvanlar.Add("Fil");
            listeyiEkranaYazForeachIle(hayvanlar, "Listeleme (Foreach):");
            listeyiEkranaYazForIle(hayvanlar, "Listeleme (For):");
            
            hayvanlar.Sort();
            listeyiEkranaYazForeachIle(hayvanlar, "Sıralı Liste:");
            hayvanlar.Insert(2, "Koala");
            hayvanlar.RemoveAt(3);
            listeyiEkranaYazForeachIle(hayvanlar, "Ekleme ve Silme Sonrası:");
            
            //Contains ile
            if (hayvanlar.Contains("Zürafa"))
            {
                Console.WriteLine("Listede zürafa bulunmaktadır ");
            }
            else
            {
                Console.WriteLine("Listede zürafa bulunmamaktadır ");
            }
            //IndexOfla
            if (hayvanlar.IndexOf("Zürafa")!=-1)
            {
                Console.WriteLine("Listede zürafa bulunmaktadır ");
            }
            else
            {
                Console.WriteLine("Listede zürafa bulunmamaktadır ");
            }
            Console.ReadKey();
        }

        public static void listeyiEkranaYazForIle(ArrayList liste, string baslik)
        {
            Console.WriteLine();
            Console.Write($"{baslik}");
            for (int i = 0; i < liste.Count; i++)
            {
                Console.Write($"{liste[i]} ");
            }
            Console.WriteLine();

        }
        public static void listeyiEkranaYazForeachIle(ArrayList liste, string baslik)
        {
            Console.WriteLine();
            Console.Write($"{baslik}");
            foreach (var eleman in liste)
            {
                Console.Write($"{eleman} ");
            }
            Console.WriteLine();
        }
    }
  ```
  
  ### Örnek-3 ###
> Aşağıdaki işlemleri sırasıyla yaparak uygulamayı tamamlayınız.
  
      - puanlar adında bir ArrayList listesi oluşturunuz.
      - Oluşturduğunuz listeye 30 adet 0-100 arası rasgele puan ekletiniz(Random nesnesi kullanılacak)
      - Listedeki punaları  ekrana yan yana yazdırınız. 
      - Listenin 2 index numaralı hücresine 99 puanını  ekletin.
      - Listenin 10, 11, 12, 13, 14, 15, 16 ve 17 index numaralı elemanlarını sildirip listeyi ekrana yan yana yazdırınız
      - Listeyi büyükten küçüğe sıralayarak ekrana yazdırınız.
      - (__Bonus__) listede 50'nin altında bulunan puanları sildirip listenin son halini ekrana yazdırınız
    
  
 **Çözüm**
  
  ```csharp
  class Program
    {
        static void Main(string[] args)
        {
            ArrayList puanlar = new ArrayList();
            Random random = new Random();
            for (int i = 0; i < 30; i++)
            {
                int rastgelePuan = random.Next(0, 100);
                puanlar.Add(rastgelePuan);
            }
            listeyiEkranaYaz(puanlar, "Puan Listesi:");
            puanlar.Insert(2, 99);
            for (int i = 0; i < 7; i++)
            {
                puanlar.RemoveAt(10);
            }
            listeyiEkranaYaz(puanlar, "Silme Sonrası Puan Listesi:");
            puanlar.Sort();
            puanlar.Reverse();
            listeyiEkranaYaz(puanlar, "Sıralı  Puan Listesi:");
            int elemanSayisi = puanlar.Count;
            for (int i = elemanSayisi-1; i>=0; i--)
            {
                if ((int)puanlar[i] < 50)
                {
                    puanlar.RemoveAt(i);
                }
            }
            listeyiEkranaYaz(puanlar, "Kalanları Silme Sonrası  Puan Listesi:");
            Console.ReadKey();
        }

        
        public static void listeyiEkranaYaz(ArrayList liste, string baslik)
        {
            Console.WriteLine();
            Console.Write($"{baslik}");
            foreach (var eleman in liste)
            {
                Console.Write($"{eleman} ");
            }
            Console.WriteLine();
        }
    } 
  
  ```
