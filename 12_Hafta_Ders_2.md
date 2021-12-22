## Quiz Soruları ##

### Soru-1 ###
 > adlar isminde 10 elemanlı boş bir dizi oluşturun. Ardından döngü yardımıyla klavyeden girilen adları diziye ekleyiniz. Son olarak foreach döngüsü ile girilen adları ekrana alt alta yazdırınız.

**Çözüm**
```csharp
static void Main()
        {
            string[] adlar = new string[10];
            //Veri Girişi
            for (int i = 0; i < adlar.Length; i++)
            {
                Console.Write($"{i+1}. Adı Giriniz:");
                adlar[i] = Console.ReadLine();
            }

            //Verileri Listeleme
            Console.WriteLine("Girirlen Adlar");
            foreach (var herBirAd in adlar)
            {
                Console.WriteLine($"{herBirAd}");
            }
            Console.ReadKey();
        }
```

### Soru-2 ###
> Aşağıda verilenlere göre int tipinde 20 elemanlı bir dizi oluşturun. 

        - Dizinini elemanlarını Random sınıfını kullanarak 0 ile 100 arasında rastgele değer ile doldurunuz. 
        - Dizinini elemanlarını ekrana yan yana yazdırınız.
        - Dizi içerisindeki sayıların toplamını ve ortalamasını hesaplatınız.
        - Dizi içerisindeki tek sayıları ve çift sayıları ayrı ayrı yan yana yazdırınız.
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
            Console.WriteLine("");// Bir Satır Boşluk
            double ortalama = toplam / dizi.Length;
            Console.WriteLine($"Toplam:{toplam}");
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
            Console.WriteLine("");// Bir Satır Boşluk
            //Çift Sayıları Ekrana YAzdırma
            Console.Write("Dizideki Çift Sayılar:");
            foreach (int herBirSayi in dizi)
            {
                if (herBirSayi % 2 == 0)
                {
                    Console.Write($"{herBirSayi} ");
                }

            }
            Console.WriteLine("");// Bir Satır Boşluk
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

**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/146893903-6abd3187-83a3-4d86-8319-0e757a75cb25.png)
