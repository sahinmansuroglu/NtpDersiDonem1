## Bir Boyutlu Dizilerde kullanılan Metot ve Özellikler ##

|Özellik/Metot Adı|Açıklama| Örnek Kullanim|
|---------|---------|---------|
| Length Özelliği|Dizideki eleman sayısını verir. | diziadi.Length |
| Rank Özelliği| Dizideki boyut sayısını verir.| diziadi.Rank |
| Max Metodu|Dizideki en büyük sayıyı verir.|  diziadi.Max() |
| Min Metodu|Dizideki en küçük sayıyı verir.|  diziadi.Min() |
| Sum Metodu|Dizideki sayıların toplamını verir.|  diziadi.Sum() |
| Average Metodu| Dizideki sayıların ortalamasını verir.|  diziadi.Average() |
| First Metodu|Dizideki ilk elemanı verir. | diziadi.First() |
| Last Metodu| Dizideki son elemanı verir.|  diziadi.Last() |

**Not:** Yukarıdaki Metotların kullanılabilmesi için uygulamaya ```System.Linq;``` kütüphanesinin dahil olması gerekir.

Örnek-1
> Aşağıda verilenlere göre Eleman sayısı 10 olan bir int tipinde dizi oluşturun.
  
  - Dizinin elemanlarını 0 ile 100 arasında rastgele puan ile doldurun.
  - Dizideki tüm puanları foreach döngüsü ile ekrana yazdırınız.
  - Dizideki en büyük ve en küçük puanı ekrana yazdırınız.
  - Dizideki ilk puanı ve son puanı ekrana yazdırınız.
  - Dizideki puanların toplamını hesaplatıp ekrana yazdırınız.
  - Dizideki puanların ortalamasını hesaplatıp ekrana yazdırınız.
  - foreach ile ortalamanın altında ve üstünde kaç puan var bunun adedini hesaplatıp ekrana yazdırınız.

**Çözüm:**

```csharp
static void Main()
        {
            int[] puanlar = new int[10];
            //Dizinin elemanları rastgele puanlar ile doldurma
            Random randomNesnesi = new Random();
            for (int i = 0; i < puanlar.Length; i++)
            {
                puanlar[i] = randomNesnesi.Next(0, 100);
            }
            //Puanları Ekrana Yazdırma
            Console.Write("Dizideki Puanlar:");
            foreach (int herbirPuan in puanlar)
            {
                Console.Write($"{herbirPuan} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Dizideki En Küçük Puan:{puanlar.Min()}");
            Console.WriteLine($"Dizideki En Büyük Puan:{puanlar.Max()}");
            Console.WriteLine($"Dizideki İlk Puan:{puanlar.First()}");
            Console.WriteLine($"Dizideki Son Puan:{puanlar.Last()}");
            Console.WriteLine($"Dizideki puanların Toplamı:{puanlar.Sum()}");
            Console.WriteLine($"Dizideki puanların Ortalaması:{puanlar.Average()}");
            //OrtalamanınAltında ve üstündeki puan sayısı hesaplatma
            int ortalamaAlti = 0, ortalamaUstu = 0;
            foreach (var herbirPuan in puanlar)
            {
                if (herbirPuan < puanlar.Average())
                {
                    ortalamaAlti++;

                }
                else
                {
                    ortalamaUstu++;
                }

            }
            Console.WriteLine($"Ortalama Altı Puan Sayısı:{ortalamaAlti}");
            Console.WriteLine($"Ortalama Üstü Puan Sayısı:{ortalamaUstu}");
            Console.ReadKey();

        }

```

**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/147201103-e0a150ff-53b2-4787-b8c2-d9f3d54aa283.png)
