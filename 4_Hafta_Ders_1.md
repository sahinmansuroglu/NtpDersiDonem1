## Hata Ayıklama  (Try-Catch-Finally) ##
> Programın çalışması esnasında herhangi bir hata olduğu an program sonlanır. Örneğin 2 sayıyı bir birine böldürürken bölen sayısı eğer 0 olursa 0'a bölme hatası oluşur ve program sonlanır. Başka bir örnek verecek olursak; kullanıcının sayı girmesi gerekirken metin girdiği durumlarda tip dönüşümü esnasında hatadan kaynaklı program sonlanır. Bu istenmeyen durumları ortadan kaldırmak için kodu yazan kişi programda çalışma esnasında oluşabilecek hataları tespit edip bunlara uygun önlem alması gerekir.  Bunun içinde C# da try-catch-finally yapısı kullanılır.


> Genel Kullanım

```csharp
            try
            {
                // Hata oluşturabilme ihtimali bulunan kodların yazılacağı blok
            }
            catch 
            {

                //try bloğunda herhangi bir hata olduğunda çalışacak olan kod bloğu
            }
            finally
            {
            // Hata oluşsa da oluşmasa da çalıştırlacak kodların yazılacağı  kod bloğu

            }
```
