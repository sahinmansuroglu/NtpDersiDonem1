## Dictionary Koleksiyonu ##

> Dizilerde ve ArrayList yapılarında her bir elemana 0'dan başlayarak index numarası verilir ve her bir index numarasına karşılık gelen bir değer bulunmaktadır. Dictionary yapısınında ise index-değer yapısına karşılık key-value(Anahtar-Değer) yapısı kullanılır. Dictionary yapısında her bir değere ulaşmak için anahtar değeri kullanılır. Kullanılacak olan anahtar ve değerin tipi Dictionary yapısı tanımlanırken verilir

**Temel Kullanım**

```csharp
Dictionary<Key_Tipi, Value_Tipi> Referans_Adi = new Dictionary<Key_Tipi, Value_Tipi>();
```

**Örnek-1**
```csharp
static void Main(string[] args)
        {
            Dictionary<int, string> ogrenci = new Dictionary<int, string>();
            ogrenci.Add(658, "Ahmet");
            ogrenci.Add(95, "Arda");
            ogrenci.Add(24, "Veli");
            ogrenci.Add(68, "Serdar");
            //24 numaralı ogrenciyi gösterir
            Console.WriteLine(ogrenci[24]);//ekrana "Veli" Yazar
            Console.ReadKey();
        }
```

### Metotlar ve Özellikler ###
  1- ContainsKey(Aranan_Key) Metodu
>   Koleksiyon içerisinde, parametre olarak girilen değerde bir Anahtar (Key) mevcutsa TRUE  değilse FALSE döndürecektir.
    ```csharp
            Dictionary<int, string> ogrenci = new Dictionary<int, string>();
            ogrenci.Add(658, "Ahmet");
            ogrenci.Add(95, "Arda");
            ogrenci.Add(24, "Veli");
            ogrenci.Add(68, "Serdar");
         
            Console.WriteLine(ogrenci.ContainsKey(45));//False Yazar
            Console.WriteLine(ogrenci.ContainsKey(68));//True Yazar
    ```

  2- ContainsValue(Aranan_Value) Metodu
Koleksiyon içerisinde, parametre olarak girilen değerde bir Değer (Value) mevcutsa TRUE  değilse FALSE döndürecektir.
 ```csharp
            Dictionary<int, string> ogrenci = new Dictionary<int, string>();
            ogrenci.Add(658, "Ahmet");
            ogrenci.Add(95, "Arda");
            ogrenci.Add(24, "Veli");
            ogrenci.Add(68, "Serdar");
         
            Console.WriteLine(ogrenci.ContainsValue("Ece"));//False Yazar
            Console.WriteLine(ogrenci.ContainsValue("Veli"));//True Yazar
    ```
3- Clear() Metodu
Koleksiyon içerisinde yer alan tüm Anahtar-Değer çiftlerini silmektedir.
Ogrenci.Clear();
Count Özelliği
Koleksiyon içinde bulunan anahtar/değer çiftlerinin sayısını döndürmektedir.
int ElemanSayisi = Ogrenci.Count;
Remove(Silinecek_Key) Metodu
Koleksiyon içerisinde, parametre olarak girilen değerde bir Anahtar (Key) mevcutsa; Anahtarı ve anahtarla ilişkili Değeri silip TRUE döndürecektir. Anahtar mevcut değilse FALSE döndürecektir.
bool SilindiMi = Ogrenci.Remove(1558);
Keys Özelliği
Anahtarları (Keys) içeren bir koleksiyon döndürmektedir.
Dictionary<int, string> Ogrenci = new Dictionary<int, string>();
Ogrenci.Add(134, "Tolga Demirer");
Ogrenci.Add(158, "Ümit Özkan");
Ogrenci.Add(115, "Kadir Aydemir");
Ogrenci.Add(174, "Cemal Çiftçi");
Dictionary<int, string>.KeyCollection AnahtarListesi = Ogrenci.Keys;
foreach (int Anahtar in AnahtarListesi)
    Console.WriteLine(Anahtar);
Values Özelliği
Değerleri (Values) içeren bir koleksiyon döndürmektedir.
