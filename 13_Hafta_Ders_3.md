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
|RemoveAt()|Index numarası verilen elemanı listeden siler|  hayvanlar.InsertRange(3,digerListe); |
| Clear|Listenin tüm elemanlarını  temizler|  hayvanlar.Clear()|
| Sort|Listedeki elemanları  sıralar.|  hayvanlar1.Sort( |
| Reverse|Listeyi ters çevirir |  hayvanlar.Reverse() |
| CopyTo|Listedeki tüm elemanları bir diziye kopyalar |  hayvanlar.CopyTo(Dizi) |  
