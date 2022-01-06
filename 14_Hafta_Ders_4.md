## SortedList Koleksiyonu ##
> SortedList koleksiyonu  Hashtable ve Dictionary koleksiyonuna benzer bir yapıdır. Farkı ise  SortedList koleksiyonu içindeki verileri anahtarın içeriğine göre sıralamasıdır. Eklenmek istenilen anahtar değerleri karışık olsa  dahi sıralı bir şekilde koleksiyona eklenilir.

**Not:** Dictionary Koleksiyonu yapısındaki metot ve özellikler SortedList yapısında  da kullanılır.

**Örnek**

```csharp

            SortedList<int, string> iller = new SortedList<int, string>();
            iller.Add(33, "Mersin");
            iller.Add(35, "İzmit");
            iller.Add(32, "Isparta");
            iller.Add(27, "Gaziantep");
            iller.Add(55, "Samsun");
            foreach (int key in iller.Keys)
            {
                Console.WriteLine($"{key,5} {iller[key],20}");
            }
            Console.ReadKey();
```
**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/148353215-8e1f1859-9a79-4b9f-8841-f15e5eb7a7d7.png)

**Örnek**

```csharp
SortedList<string,string> sehirler = new SortedList<string,string>()
                                    {
                                        {"İstanbul", "TÜRKİYE"},
                                        {"London", "İNGİLTERE"},
                                        { "Paris", "FRANSA"},
                                        {"Johannesburg", "GÜNEY AFRİKA"}
                                    };
```
**Örnek-1**
> Aşağıdaki uygulamada boş bırakılan yerlere istenilen kodu yazınız


```csharp
       //key değeri plakası, value değeri markası olacak şekilde araclar adında bir SortedList Tanımlayın
       //.............................................
       //araclar SortedList'ine 5 adet arac ekleyin
       //.............................................
       //araclar SortedList'inin key değerlerini ekrana yazdırınız.
       //.............................................
       //.............................................
       //.............................................
       //.............................................
       //araclar SortedList'inin value değerlerini ekrana yazdırınız.
       //.............................................
       //.............................................
       //.............................................
       //.............................................
       //araclar SortedList'inin key vevalue değerlerini yanyana ekrana yazdırınız.
       //.............................................
       //.............................................
       //.............................................
       //.............................................
       //araclar  koleksiyonunda "33DL021" plakalı aracın bulunup bulunmadığını test edin
       //.............................................
       //.............................................
       //.............................................
       //araclar  koleksiyonunda "BMW" markalı aracın bulunup bulunmadığını test edin
        //.............................................
       //.............................................
       //.............................................
       //araclar  koleksiyonunda 2 tane plaka-Marka siliniz
       //.............................................
       //.............................................
       Console.ReadKey();
```
**Çözüm**

```csharp
  //key değeri plakası, value değeri markası olacak şekilde araclar adında bir SortedList Tanımlayın

            SortedList<string, string> araclar = new SortedList<string, string>();
            //araclar SortedList'ine 5 adet arac ekleyin
            araclar.Add("33ABC35", "BMW");
            araclar.Add("32ABC35", "TOYOTA");
            araclar.Add("06ABC35", "FIAT");
            araclar.Add("01ABC35", "HONDA");
            araclar.Add("33ASA98", "AUDI");
            //araclar SortedList'inin key değerlerini ekrana yazdırınız.
            foreach (string key in araclar.Keys)
            {
                Console.WriteLine(key);
            }
            //araclar SortedList'inin value değerlerini ekrana yazdırınız.
            foreach (string value in araclar.Values)
            {
                Console.WriteLine(value);
            }
            //araclar SortedList'inin key vevalue değerlerini yanyana ekrana yazdırınız.
            foreach (string key in araclar.Keys)
            {
                Console.WriteLine($"{key}{araclar[key]}");
            }
            //araclar  koleksiyonunda "33DL021" plakalı aracın bulunup bulunmadığını test edin
            Console.WriteLine(araclar.ContainsKey("33DL021"));
            //araclar  koleksiyonunda "BMW" markalı aracın bulunup bulunmadığını test edin
            Console.WriteLine(araclar.ContainsValue("BMW"));
            //araclar  koleksiyonunda 2 tane plaka-Marka siliniz
            araclar.Remove("01ABC35");
            araclar.Remove("33ABC35");
            Console.ReadKey();

```
