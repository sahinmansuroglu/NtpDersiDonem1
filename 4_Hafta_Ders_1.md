## Hata Ayıklama  (Try-Catch-Finally) ##
> Bir programın çalışması esnasında herhangi bir hata oluştuğunda program hatadan kaynaklı sonlandırılır. Örneğin 2 sayıyı bir birine böldürürken bölen sayısı eğer 0 olursa 0'a bölme hatası oluşur ve program sonlanır. Başka bir örnek verecek olursak; kullanıcının sayı girmesi gerekirken metin girdiği durumlarda tip dönüşümü esnasında hatadan kaynaklı program sonlanır. Bu istenmeyen durumları ortadan kaldırmak için kodu yazan kişi programda çalışma esnasında oluşabilecek hataları tespit edip bunlara uygun önlem alması gerekir.  Bunun için de C# da try-catch-finally yapısı kullanılır.


> Genel Kullanım

```csharp
            try
            {
                // Hata oluşturabilme ihtimali bulunan kodlar bu bloğa yazılır
            }
            catch 
            {
                //try bloğunda herhangi bir hata olduğunda çalışacak olan kod lar bu bloğa yazılır
            }
            finally
            {
                        // Hata oluşsa da oluşmasa da çalıştırlacak kodların bu bloğa yazılır
                        // Finally bloğu isteğe bağlıdır. yazma zorunluluğu yoktur.
            }
```

#### Örnek ####

```csharp
            int i = 1;
            while (i < 10)
            {
                Console.Write($"{i} ");
                i++;
            }
            Console.ReadKey();
```

**Ekran Çıktısı**
```
1 2 3 4 5 6 7 8 9
```
