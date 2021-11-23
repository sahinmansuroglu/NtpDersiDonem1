## Değer ve Referans Tipleri (Value Type and Reference Type) ##
>  C# veri tipleri da verilerin bellekte nasıl saklanacağına göre değer tipleri veya referans tipleri olmak üzere ikiye ayrılır.
>  Değer tiplerinde sadece  değişkenin verisi tutulurken, Referans tiplerinde ise  verinin  bulunduğu yerin adresi tutulmaktadır.
>  Değer tiplerinde veriler belleğin yığın (Stack) bölümünde tutulurken, Referans tiplerinde veriler belleğin öbek (Heap) bölümünde yer almaktadır.

### 1. Değer Tipleri (Value Type) ###

> "bool", "byte", "char", "decimal", "double", "enum", "float", "int", "long", "sbyte", "short", "struct", "uint", "ulong", "short".

#### Değer tiplerinin bellekte yerleşimi ####
> Aşağıdaki örnekte a ve aKopya değişkenlerinin belleğin yığın bölümündeki yerleşimi gözükmektedir.
![image](https://user-images.githubusercontent.com/28144917/142982944-01a5bcde-ca89-4b7f-b770-3a9509963d6f.png)

> Aşağıdaki örnekte a ve aKopya değişkenlerinin belleğin yığın bölümündeki yerleşimi gözükmektedir. Ancak bu iki değişken farklı bellek hücrelerini gösterdiği için herhangi birisindeki değişiklik diğerini etkilememektedir.
![image](https://user-images.githubusercontent.com/28144917/142983245-f1b2b212-c7d4-4e96-a7f5-765a906cea1b.png)


### 2. Referans Tipleri (Reference Type) ###

>  "string", "object", "class",  "array".

#### Referans tiplerinin bellekte yerleşimi ####
>Aşağıdaki Örnekte Kare tipinde yeniKare adında bir referans oluşturulmuş ancak new ile bir nesne oluşturup atama yapılmadğından referans olarak **null** değeri bulunmaktadır
![image](https://user-images.githubusercontent.com/28144917/142981838-565fef99-894b-4b87-8ad5-4fee1ef22310.png)

>Aşağıdaki Örnekte Kare tipinde yeniKare adında bir referans oluşturulmuş ve ardında  new ile bir nesne oluşturup atama yapıldığından dolayı yeniKare'ye  heap'de oluşturulan yeni nesnenin adresi atılmıştır.
![image](https://user-images.githubusercontent.com/28144917/142982203-62079f19-7a0f-4b3e-b9f3-b546757244e1.png)

>Aşağıdaki Örnekte Kare tipinde kare1 ve kare2  adında iki farklı referans oluşturulmuş ve ardında  new ile heap'de bir nesne oluşturup oluşturulan bu oluşturulan nesneninin adresi hem kare1 hem de kare2' ye atılmıştır. Yani kare1 ve kare2 aynı nesneyi göstermektedir. 
![image](https://user-images.githubusercontent.com/28144917/142982345-33cae51a-ae10-419e-8f61-32f7a74e4e0c.png)


**Soru-1**

> Aşağıdaki verilenlere göre bir Öğrenci Sınıfı oluşturunuz. Bu ogrenci Sınıfında 3 tane nesnere referansı oluşturup aynı nesneyi bu üç nesne referansına da atayarark bilgilerini ekrana yazdırınız.
a) Ad Soyad ve dogum Tarihi alanları bulunacak
b) Bilgileri Ekrana yazdıran bir metot  bulunanacak.
