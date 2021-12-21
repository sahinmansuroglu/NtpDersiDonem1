## Diziler (Arrays) ##

> Programlama dillerinde bir değişkenin içerisinde sadece bir değer tutabiliriz. Ancak dizi yapıları   birden çok veriyi bellekte blok halinde tutabilmemize olanak sağlar.

### Tek boyutlu Diziler ###

![image](https://user-images.githubusercontent.com/28144917/146877163-d1412045-61e2-401a-959a-92062c625edd.png)

**Örnek-1**

```csharp
static void Main()
        {
            //Dizi Tanımlandı ve aynı anda Değerleri de verildi
            int[] dizi1 = new int[5] { 10, 20, 30, 40, 50 };
            Console.WriteLine($"{dizi1[4]}"); // Ekrana 50 yazar.
            dizi1[4] = 60;
            Console.WriteLine($"{dizi1[4]}"); // Ekrana 60 yazar.
            Console.WriteLine($"{dizi1[0]}"); // Ekrana 10 yazar.
            Console.WriteLine($"{dizi1[3]}"); // Ekrana 40 yazar.
           
            //Dizi Tanımlandı ve aynı anda Değerleri de verildi
            string[] dizi2 = new string[5] { "bir", "iki", "üç", "dört", "beş" };
            Console.WriteLine($"{dizi2[2]}"); // Ekrana Üç Yazar
            dizi2[2] = "Yedi";
            Console.WriteLine($"{dizi2[2]}"); // Ekrana Yedi Yazar
            Console.WriteLine($"{dizi2[0]}"); // Ekrana Bir Yazar
            //Console.WriteLine($"{dizi2[10]}"); // IndexOutOfRangeException hatası verir. max index numarası 5 dir

            //Dizi tanımlandı ancak içi boş durumdadır çünkü değerleri verilmemiştir.
            int[] dizi3 = new int[4];
            Console.WriteLine($"{dizi3[2]}"); // int'in varsayılan değer 0 olduğundan ekrana 0 yazmıştır.
            dizi3[0] = 45;
            dizi3[1] = 65;
            dizi3[2] = 32;
            dizi3[3] = 74;
            Console.WriteLine($"{dizi3[2]}"); // Ekrana 32 Yazar
            Console.ReadKey();
        }
```
**Örnek-2**
> İçerisinde 10 adet 0 ile 100 arası puan bulunan bir dizi tanımlayıp tüm puanları ekrana yazdırınız.

```csharp
 static void Main()
        {
            int[] puanlar = new int[10] { 98, 65, 21, 25, 45, 96,63,18,58,59 };
            Console.WriteLine($"1. Puan:{puanlar[0]}");
            Console.WriteLine($"2. Puan:{puanlar[1]}");
            Console.WriteLine($"3. Puan:{puanlar[2]}");
            Console.WriteLine($"4. Puan:{puanlar[3]}");
            Console.WriteLine($"5. Puan:{puanlar[4]}");
            Console.WriteLine($"6. Puan:{puanlar[5]}");
            Console.WriteLine($"7. Puan:{puanlar[6]}");
            Console.WriteLine($"8. Puan:{puanlar[7]}");
            Console.WriteLine($"9. Puan:{puanlar[8]}");
            Console.WriteLine($"10. Puan:{puanlar[9]}");
            Console.ReadKey();
        }
        
```
### Dizi Elemanlarını Döngü Yardımıyla Erişme ###

#### 1- For Döngüsü Kullanılarak Döngü Elemanlarına Erişim ####

```csharp
static void Main()
        {
            int[] puanlar = new int[11] { 98, 65, 21, 25, 45, 96,63,18,58,59,95 };

            Console.WriteLine($"Dizideki elaman Sayısı:{puanlar.Length}");
            for (int i = 0; i < puanlar.Length; i++)
            {
                Console.WriteLine($"{i+1}. Puan:{puanlar[i]}");
            }
            
            
            Console.ReadKey();
        }
```
**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/146888035-18c6eaed-7daa-41e3-8b81-10b9a0ffb4b0.png)

#### 2- Foreach Döngüsü Kullanılarak Döngü Elemanlarına Erişim ####

```csharp
        static void Main()
        {
            int[] puanlar = new int[11] { 98, 65, 21, 25, 45, 96,63,18,58,59,95 };

            foreach (int herBirPuan in puanlar)
            {
                Console.WriteLine(herBirPuan);
            }
            Console.ReadKey();
        }
```
