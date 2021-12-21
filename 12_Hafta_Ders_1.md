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




