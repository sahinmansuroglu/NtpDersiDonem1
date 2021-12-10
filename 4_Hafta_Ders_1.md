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
                //try bloğunda herhangi bir hata olduğunda çalışacak olan kodlar bu bloğa yazılır
            }
            finally
            {
                        // Hata oluşsa da oluşmasa da çalıştırlacak kodlar bu bloğa yazılır
                        // Finally bloğu isteğe bağlıdır. yazma zorunluluğu yoktur.
            }
```

#### Örnek ####
> Aşağıdaki programda klavyeden girilen iki sayı üzerinde bölme işlemi gerçekleştirilmiş ve sonuç ekrana yazdırılmıştır.
> Uygulama çalıştırıldığında klavyeden rakam yerine rakam dışında bir karakter girilirse girilen değer tam sayıya çevirilirken program hata verip kapanacaktır. Ayrıca sayi2' ye 0 girilirse sayi2 bölen sayı olduğu için 0'a bölünme hatası verip  program sonlanacaktır.

```csharp
        static void Main(string[] args)
        {

            Console.Write("1. Sayıyı Giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Sayıyı Giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            double sonuc = sayi1 / sayi2;

            Console.WriteLine($"Bölme İşleminin Sonucu={sonuc}");
           
          
            Console.ReadKey();
        }
```
> Yukarıdaki programı oluşabilecek hatalara karşı koruyabilmek için try catch yapısını kullanarak tekrar yazalım.

```csharp
static void Main(string[] args)
        {
            try
            {
                Console.Write("1. Sayıyı Giriniz:");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2. Sayıyı Giriniz:");
                int sayi2 = Convert.ToInt32(Console.ReadLine());
                double sonuc = sayi1 / sayi2;
                Console.WriteLine($"Bölme İşleminin Sonucu={sonuc}");
            }
            catch (Exception hata)
            {
                Console.WriteLine("Hata Oluştu Program Kapanacak");
                Console.WriteLine($"Oluşan Hata: {hata.Message}");
               
            }
            Console.ReadKey();
        }

```

**Örnek Ekran Çıktıları**

![image](https://user-images.githubusercontent.com/28144917/134907763-8b77bc09-04f2-48b1-b648-d0baf3180f65.png)

![image](https://user-images.githubusercontent.com/28144917/134907805-af46fccf-245a-4667-b18a-8fe7a4d8db32.png)

![image](https://user-images.githubusercontent.com/28144917/134907867-e1c5d0a7-4ee3-40c2-a324-684e0e0270e8.png)

> Yukarıdaki örnekte oluşabilecek her bir hatayı farklı bir catch bloğu ile  de yakalayabiliriz. Bunun için aşağıdaki programı inceleyelim.

```csharp
 static void Main(string[] args)
        {
            
            try
            {
                Console.Write("1. Sayıyı Giriniz:");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("2. Sayıyı Giriniz:");
                int sayi2 = Convert.ToInt32(Console.ReadLine());
                double sonuc = sayi1 / sayi2;
                Console.WriteLine($"Bölme İşleminin Sonucu={sonuc}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Rakam Girilmediği için sonuç hesaplanamadı ");
             }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Bölen Sayı 0 girildiği için sonuç hesaplanamadı");
            }
            
            Console.ReadKey();
        }
```

**Örnek Ekran Çıktıları**

![image](https://user-images.githubusercontent.com/28144917/134908933-d0e3858d-ef0d-460e-9139-058a237060dd.png)

![image](https://user-images.githubusercontent.com/28144917/134909021-9f9db3aa-7453-45c7-9a28-f21196370c2a.png)

![image](https://user-images.githubusercontent.com/28144917/134909115-711627ef-1b02-46a7-a021-ec54c5066355.png)


### Örnek ###

```csharp
 static void Main(string[] args)
    {
		while (true)
		{
			try
			{
				Console.Write("Lütfen Puan Giriniz:");
				int puan = Convert.ToInt32(Console.ReadLine());

				if (puan > 100 || puan < 0)
				{
					throw new Exception("Puan 0 ile 100 arasında olmalı");
				}
				if (puan < 50)
				{
					Console.WriteLine("Kaldınız...");
				}
				else
				{
					Console.WriteLine("Geçtiniz...");
				}
			}
			catch (FormatException hata)
			{
				Console.WriteLine("Rakam Girilmediği için hata sonlandı...");

			}
			catch (Exception hata)
			{
				Console.WriteLine(hata.Message);
			}
		}
		
		
    }

```


![image](https://user-images.githubusercontent.com/28144917/145569386-3934baf3-6070-4c26-b422-da2c2faf6126.png)

