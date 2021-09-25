## Hata Ayıklama  (Try-Catch-Finally) ##
> Programın çalışması esnasında herhangi bir hata olduğu an program sonlanır. Örneğin 2 sayıyı bir birine böldürürken bölen sayısı eğer 0 olursa 0'a bölme hatası oluşur ve program sonlanır. Başka bir örnek verecek olursak; kullanıcının sayı girmesi gerekirken metin girdiği durumlarda tip dönüşümü esnasında hatadan kaynaklı program sonlanır. Bu istenmeyen durumları ortadan kaldırmak için kodu yazan kişi programda çalışma esnasında oluşabilecek hataları tespit edip bunlara uygun önlem alması gerekir.  Bunun içinde C# da try-catch-finally yapısı kullanılır.


> Genel Kullanım

```
try
            {
                int a = 5;
            }
            catch 
            {

                throw;
            }
            finally
            {

            }
```

