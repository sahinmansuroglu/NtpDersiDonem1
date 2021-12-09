## Listeler ##

> Liste Oluşturmak için aşağıdaki kütphane uygulamaya dahil edilmeli

```
using System.Collections.Generic;
```

> Liste oluşturmak İçin

```
List<tip> listeAdı = new List<tip>();
```
> Listeye Eleman Ekleme

```csharp
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(15);
            sayiListesi.Add(26);
            sayiListesi.Add(35);
            sayiListesi.Add(14);

            List<string> adListesi = new List<string>();
            adListesi.Add("Ali");
            adListesi.Add("Veli");
            adListesi.Add("Mehmet");
            adListesi.Add("Ahmet");
```
**Örnek

```csharp
           static void Main(string[] args)
        {

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(15);
            sayiListesi.Add(26);
            sayiListesi.Add(35);
            sayiListesi.Add(14);

            List<string> adListesi = new List<string>();
            adListesi.Add("Ali");
            adListesi.Add("Veli");
            adListesi.Add("Mehmet");
            adListesi.Add("Ahmet");
            
            Console.WriteLine("****Sayi Listesi*******");
            sayiListesi.Sort();
            sayiListesi.Reverse();
            foreach (int herBirSayi in sayiListesi)
            {
                Console.WriteLine($"{herBirSayi}");
            }
            adListesi.Sort();
            adListesi.Reverse();
            Console.WriteLine("*******Ad Listesi*********");

            foreach (string herBirAd in adListesi)
            {
                Console.WriteLine($"{herBirAd}");
            }
            
            Console.ReadKey();
        }
```
