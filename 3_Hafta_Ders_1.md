## Karar ve Kontrol Deyimler ##
> Programın çalışmasını belli şartlara göre değiştirmek istediğimizde `Karar ve Kontrol Deyimlerini` kullanırız



> C#'da kullanılabilecek karar ve kontrol deyimleri
1. if
2. if-else
3. else if
4. Switch case



### 1. if Yapısı ###
> Genel Kullanım
```csharp
if (şart){
  // şart doğru olduğunda bu kod bloğu çalışır.
}
```
> __*Şart Mantıksal bir ifade olmalı*__

> **Not:** C#'da aşağıdaki gibi süslü parantezin açılıp kapatıldığı yağıya blok denilmektedir. 
```csharp
  {
    //Kod Bloğu
  }
```
#### Örnek ####
> Aşağdaki örnek uygulamada int tipinde a değişkeni tanımlanmış ve değeri 10 olarak verilmiştir. if ile de a değerinin 5'den büyük olup olmadığı kontrol edilmiştir.Eğer büyük ise if'den sonraki kod bloğu çalışmış ve ekrana "a sayısı 5'den büyüktür." yazmıştır.
```csharp
int a = 10;
            if (a > 5)
            {
                Console.WriteLine("a sayısı 5'den büyüktür.");
            }
           ```
