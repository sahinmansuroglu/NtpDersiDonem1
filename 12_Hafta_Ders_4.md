## System.Array class'i ile diziler ÜZerinde İşlemler ##

> Tüm diziler System.Array sınıfı için bir nesne olarak kabul edilir
> System.Array sınıfı her bir dizi bir çok yararlı metot ve özellk sağlar

|Özellik/Metot Adı|Açıklama| Örnek Kullanim|
|---------|---------|---------|
| IndexOf|verilen elemanı arar. Bulursa index değerini verir, bulamazsa -1 döndürür | Array.IndexOf( diziAdi, object aranacakDeger) |
| BinarySearch| IndexOf ile aynı işlemi yapar. Ancak Daha hızlı yapar.(Öncesinde Sıralama Yapılamlı)|Array.BinarySearch( diziAdi, object aranacakDeger) |
| Clear|Dizinin istenilen kısmındaki verileri temizler|   Array.Clear( diziAdi, baslangıçSırası, uzunluk|
| Resize|Dizinin Boyutunu azaltmaya/arttırmaya yarar|   Array.Resize(diziAdi, yeniBoyut) |
| Sort|Dizideki elemanları artan sıralar.|  Array.Reverse(diziAdi)  |
| Reverse|Diziyi ters çevirir | diziadi.First() |
|CopyTo| Dizideki son elemanı verir.|  diziadi.Last() |
|Clone| Dizideki son elemanı verir.|  diziadi.Last() |
