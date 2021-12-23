## System.Array class'i ile diziler Üzerinde İşlemler ##

> Tüm diziler System.Array sınıfı için bir nesne olarak kabul edilir

> System.Array sınıfı her bir dizi bir çok yararlı metot ve özellk sağlar.

|Özellik/Metot Adı|Açıklama| Örnek Kullanim|
|---------|---------|---------|
| IndexOf|verilen elemanı arar. Bulursa index değerini verir, bulamazsa -1 döndürür | Array.IndexOf( diziAdi, object aranacakDeger) |
| BinarySearch| IndexOf ile aynı işlemi yapar. Ancak Daha hızlı yapar.(Öncesinde Sıralama Yapılamlı)|Array.BinarySearch( diziAdi, object aranacakDeger) |
| Clear|Dizinin istenilen kısmındaki verileri temizler|   Array.Clear( diziAdi, baslangıçSırası, uzunluk|
| Resize|Dizinin Boyutunu azaltmaya/arttırmaya yarar|   Array.Resize(diziAdi, yeniBoyut) |
| Sort|Dizideki elemanları artan sıralar.|  Array.Sort(diziAdi)  |
| Reverse|Diziyi ters çevirir |  Array.Reverse(diziAdi) |
| CopyTo|Kaynak dizideki elemanları hedef dizinin istenilen sırasına kopyalar|  kaynakDizi.CopyTo(hedefDizi,indexNo) |
| Clone| Dizinin kopyası verir (Object tipinde döndürür.İStenilen tipe Cast edilmesi gerekir).|  diziadi.Clone() |

**Örnek-1**

> 10 Elemanlı int tipindeki bir dizide klavyeden girilen sayının bulunup bulunmadığının kontrolünü yapan program.
```csharp
static void Main()
        {

            int[] dizi = new int[10] { 65, 22, 45, 36, 96, 454, 85, 65, 312, 258 };
            Console.WriteLine("Aranacak Sayıyı Giriniz");
            int aranacakSayi = Convert.ToInt32(Console.ReadLine());
            int bulunduguSira = Array.IndexOf(dizi, aranacakSayi);
            if (bulunduguSira == -1)
            {
                Console.WriteLine($"{aranacakSayi} Sayısı dizide bulunmamaktadır ");

            }
            else
            {
                Console.WriteLine($"{aranacakSayi} Sayısı dizide {bulunduguSira} sırada bulunmaktadır ");
            }
            
            Console.ReadKey();

        }
```
**Örnek-2**
> Aşağıdaki Verilenlere göre uygulamayı her bir işlem için metot tanımlayarak tasarlayınız.

       a) Aşağıdaki Menüyü "Menu" adından bir metot içerisinde tanımlayınız.
                - ***İşlemler***
                - 1- Rastgele Dizi oluştur (Klavyeden dizinin boyutu girilecek o boyuta göre int dizisi oluşturulacak)
                - 2- Dizideki sayıları ekrana  yanyayan yazdır.
                - 3- Diziyi Sırala
                - 4- Diziyi Ters Çevir
                - 5- Diziyi Genişlet/Daral (Klavyeden girilen boyuta göre genişletilecek veya daraltılacak)
                - 6- Dizinin Kopyasını oluştur.(Herbir sayı Ana dizideki sayının iki katı olacak )
                - 6- Dizide Sayı Arama
                - 7- Çıkış
        b) Yukarıdaki her bir işlem ayrı bir metot içerisinde gerçekleştirilecektir. 
