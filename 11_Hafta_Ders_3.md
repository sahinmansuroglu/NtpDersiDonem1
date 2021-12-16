## Çok Biçimlilik (Polymorphism) ##

Polimorfizm, çok biçimlilik anlamına gelmektedir. Polimorfizm, nesne yönelimli programlama dilinin en önemli kavramlarından biridir. Nesne yönelimli programlamada polimorfizmin en yaygın kullanımı, bir alt sınıf nesnesine başvurmak için bir üst sınıf başvurusu (referansı) kullanıldığında ortaya çıkar. Bu tür durumlarda tanımlanan üst sınıf referansı farklı alt(child) sınıf nesnesini  işaret edebileceği için aynı türdeki başvurunun farklı şekillerde çalışabilmesine olanak sağlayacaktır.

**Örnek**
> Aşağıdaki  örnekte Ogrenci ve Ogretmen sınıfınının Insan sınıfından türetildiğini varsayarsak  oluşturulan insan1, insan2 ve insan3 nesne başvurularının farklı tipte nesneler göstermesi Polimorfizm’e örnektir.

```csharp
    Insan insan1=new Insan();
    Insan insan2=new Ogrenci();
    Insan insan3=new Ogretmen();
````

