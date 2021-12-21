## Diziler (Arrays) ##

> Programlama dillerinde bir değişkenin içerisinde sadece bir değer tutabiliriz. Ancak dizi yapıları   birden çok veriyi bellekte blok halinde tutabilmemize olanak sağlar.
> Yanı aynı tipteki birden fazla değişkeni tanımlamak için dizilerden faydalanırız.




### Dizi Tanımlama ###

![image](https://user-images.githubusercontent.com/28144917/146901675-3a2cb89b-5c32-4648-8704-c1ab86451139.png)

**Not:** Farklı tipte verileri dizide tutmak için değişkenkerin türünü object olarak tanımlayabiliriz

![image](https://user-images.githubusercontent.com/28144917/146902239-4a317a37-9c9d-4982-b6df-68e604fb38ac.png)


### Tek boyutlu Diziler ###
> Tek Boyutulu dizileri aşağıdaki gibi hücrelerden oluşan bir satırlık veri gibi düşünebiliriz

![image](https://user-images.githubusercontent.com/28144917/146899850-b70006e2-1ef9-42d3-b67a-6c5bc319f282.png)


### İki boyutlu Diziler ###
> İki Boyutulu dizileri aşağıdaki gibi satır ve sutunlardan oluşan bir tablo gibi  düşünebiliriz

![image](https://user-images.githubusercontent.com/28144917/146899499-5e05e219-da05-4d35-a4df-3660723e61eb.png)


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

**Örnek-3**
> Aşağıda verilenlere göre int tipinde 20 elemanlı bir dizi oluşturun. 

        - Dizinini elemanlarını Random sınıfını kullanarak 0 ile 100 arasında rastgele değer ile doldurunuz. 
        - Dizinini elemanlarını ekrana yan yana yazdırınız.
        - Dizi içerisindeki sayıların toplamını ve ortalamasını hesaplatınız.
        - Dizi içerisinde kaç adet tek sayı kaç adet çift sayı bulunmaktadır hesaplatıp ekrana yazdırınız.

**Hatırlatma**
> Random sınıfı ile 0 ile 100 arasından rastgele sayı üreten program örneği

```csharp
            Random random = new Random();
            int rastgeleSayi = random.Next(0, 100);
```

**Çözüm:**

```csharp
  static void Main()
        {
            int[] dizi = new int[20];

            // Dizi 0-100 arası Rastgele sayılarla doldurulacak
            Random randomNesnesi = new Random();
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = randomNesnesi.Next(0, 100);
            }
            //Dizideki Sayıları Listeleme
            Console.Write("Dizideki Elemanlar:");
            foreach (int herBirSayi in dizi)
            {
                Console.Write($"{herBirSayi} ");
            }

            //Dizideki sayıların toplamın Hesaplatma
            int toplam = 0;
            foreach (int herBirSayi in dizi)
            {
                toplam += herBirSayi;
            }

            double ortalama = toplam / dizi.Length;
            Console.WriteLine($"\nToplam:{toplam}");
            Console.WriteLine($"Ortalama:{ortalama}");

            //Tek Sayıları Ekrana YAzdırma
            Console.Write("Dizideki Tek Sayılar:");
            foreach (int herBirSayi in dizi)
            {
                if (herBirSayi % 2 == 1)
                {
                    Console.Write($"{herBirSayi} ");
                }
               
            }
            Console.WriteLine("");
            //Tek Sayıları Ekrana YAzdırma
            Console.Write("Dizideki Çift Sayılar:");
            foreach (int herBirSayi in dizi)
            {
                if (herBirSayi % 2 == 0)
                {
                    Console.Write($"{herBirSayi} ");
                }

            }
            Console.WriteLine("");
            //Tek ve Çift sayıların adedini Hesaplatma
            int tekAdet = 0;
            int ciftAdet = 0;
            foreach (int herBirSayi in dizi)
            {
                if (herBirSayi % 2 == 0)
                {
                    ciftAdet++;
                }
                else
                {
                    tekAdet++;
                }
            }

            Console.WriteLine($"Teklerin Adedi:{tekAdet}");
            Console.WriteLine($"Çiftlerin Adedi:{ciftAdet}");

            Console.ReadKey();
        }         
```

**ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/146893903-6abd3187-83a3-4d86-8319-0e757a75cb25.png)
