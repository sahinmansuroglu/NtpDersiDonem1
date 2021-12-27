## Kutulama (Boxing) ve Kutuyu Açma (UnBoxing) ##

> C# veri tipleri da verilerin bellekte nasıl saklanacağına göre değer tipleri veya referans tipleri olmak üzere ikiye ayrılır. Değer tiplerinde sadece değişkenin verisi tutulurken, Referans tiplerinde ise verinin bulunduğu yerin adresi tutulmaktadır. Değer tiplerinde veriler belleğin yığın (Stack) bölümünde tutulurken, Referans tiplerinde veriler belleğin öbek (Heap) bölümünde yer almaktadır.

#### Değer Tipleri (Value Type) ####
"bool", "byte", "char", "decimal", "double", "enum", "float", "int", "long", "sbyte", "short", "struct", "uint", "ulong", "short".

####  Referans Tipleri (Reference Type) ####
"string", "object", "class", "array".

####  Kutulama (Boxing) (Bir Değer Tipinin, Referans Tipine dönüştürülmesi işlemi) ####

> Herhangi value (değer) tipideki değişkenin object (nesne) tipindeki değişkene dönüştürülmesi işlemine  Kutulama (Boxing) denir.
```csharp
     
        //değer tipinde değişken tanımlandı
        int x = 10;

        //referans tipinde değişken tanımlandı
        object obj 
        
        //boxing işlemi  (değer tipinden referans tipine aktarım-  10 değeri Stack'tan Heap'e alındı)
        obj= x;

        System.Console.WriteLine(x); // Çıktı: 10
        System.Console.WriteLine(obj); //Çıktı: 10
```

####  Kutu Açma (Unboxing) (Bir Referans Tipinin, Değer Tipine dönüştürülmesi işlemi) ####

> Object (nesne) tipindeki değişkenin value (değer) tipindeki değişkene dönüştürülmesi işlemine Unboxing işlemi denir. Burada
dikkat edilmesi gereken nokta, dönüştürülmek istenen nesne hangi tipte boxing yapılmış ise aynı tipte Casting yapılması gerekmektedir.

```csharp
            //referans tipinde değişken tanımlandı
            object obj = 10;

            //değer tipinde değişken tanımlandı
            int x;
            
            //Unboxing işlemi  (referans tipinden değer tipine aktarım-  10 değeri Heap'den Stack'a alındı)
            x =(int) obj; //Cast işlemi yapılmazsa hata verir.

            System.Console.WriteLine(x); //Output: 10
            System.Console.WriteLine(obj); //Output: 10
```

**Önemli :** Boxing ve unboxing işlemi esnasına veri Heap ile Stack arasına yer değiştirmektedir ve uygulamaların performansını düşürmektedir. Bundan dolayı aşırı kullanımdan kaçınılmalıdır yada  Object tipindeki listeler yerine değer tipinde dizi veya list yapısı kullanılabilir.
