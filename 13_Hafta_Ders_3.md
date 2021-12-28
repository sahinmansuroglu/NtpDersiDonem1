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
 ### Örnek Kullanım ###
  ```csharp
  static void Main(string[] args)
        {
            ArrayList adList = new ArrayList();
            adList.Add("Ahmet");
            adList.Add("Aydın");
            adList.Add("Mehmet");

            foreach (var ad in adList)
            {
                Console.WriteLine($"{ad}");
            }
            Console.ReadKey();
        }
  ```
### Örnek-1 ###
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
  
  ### Örnek-2 ###
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
  
  
  ```
