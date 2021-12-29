## List<Type> Sınıfı ##
> List  koleksiyonu ile ArrayList koleksiyonu kullanım olarak benzerlik göstermektedir. Temel fark; List koleksiyonunda içerisinde sadece aynı tipte veriler bulunabilmektedir. ArrayList koleksiyonlarında  ise farklı tipte veriler bulunabilmektedir.  

**Not:** Veri tipinin belli olduğu collection'lara Generic Colleciton, veri tipinin belli olmadığı collection'lara da  Non-generic collection denilir.Generic collectionlar'da veri tipi belli olduğu için boxing-unboxing işlemi gerçekleşmez. Örnek olarak List Colection'ı da bir generic colleciton olduğu için boxing-unboxing işlemleri gerçekleşmez. 

### List Tanımlama Örnekleri ###
  
```csharp
            List<int> sayilar = new List<int>();
            sayilar.Add(85);
            sayilar.Add(56);

            List<string> adlar = new List<string>();
            adlar.Add("Ahmet");
            adlar.Add("Mehmet");

            var sehirler = new List<string>() {"Ankara","Adana", "Mersin","Antalya"};
            sehirler.Add("İzmir");
  
            List<Ogrenci> ogrenciler = new List<ogrenci>();
            ogrenciler.Add(new ogrenci { ad = "Ali", yas=23 });
            ogrenciler.Add(new ogrenci { ad = "veli", yas = 96 });
  
```
  
