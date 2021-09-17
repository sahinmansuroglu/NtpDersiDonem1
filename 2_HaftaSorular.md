### Soru-1
  int, float, double ,short veri tiplerinin minimum, maximum, varsayılan değerlerini ve bellekte kaç byte yer kapladıklarını ekrana yazdıran programı tasarlayınız.
  ```csharp
  
static void Main(string[] args)
        {

            sbyte maxSbyte = sbyte.MaxValue;
            sbyte minSbyte = sbyte.MinValue;
            sbyte varsayılanSbyte = default(sbyte);
            Console.WriteLine("sbyte veri tipinin değer aralığı:");
            Console.WriteLine($"{minSbyte} .. {maxSbyte}  ");
            Console.WriteLine($"varsayılan değeri:{varsayılanSbyte}");
            Console.WriteLine($"Bellekte kapıldığı alan: {sizeof(sbyte)} Byte");
            Console.WriteLine("________________________________________________");
                       
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            int varsayılanInt = default(int);
            Console.WriteLine("int veri tipinin değer aralığı:");
            Console.WriteLine($"{minInt} .. {maxInt}  ");
            Console.WriteLine($"varsayılan değeri:{varsayılanInt}");
            Console.WriteLine($"Bellekte kapıldığı alan: {sizeof(int)} Byte");
            Console.WriteLine("________________________________________________");

            float maxFloat = float.MaxValue;
            float minFloat = float.MinValue;
            float varsayılanFloat = default(float);
            Console.WriteLine("float veri tipinin değer aralığı:");
            Console.WriteLine($"{minFloat} .. {maxFloat}  ");
            Console.WriteLine($"varsayılan değeri:{varsayılanFloat}");
            Console.WriteLine($"Bellekte kapıldığı alan: {sizeof(float)} Byte");
            Console.WriteLine("________________________________________________");
                        
            double max_double = double.MaxValue;
            double min_double = double.MinValue;
            double varsayılan_double = default(double);
            Console.WriteLine("double veri tipinin değer aralığı:");
            Console.WriteLine($"{min_double} .. {max_double}  ");
            Console.WriteLine($"varsayılan değeri:{varsayılan_double}");
            Console.WriteLine($"Bellekte kapıldığı alan: {sizeof(double)} Byte");
            Console.WriteLine("________________________________________________");

            short max_short = short.MaxValue;
            short min_short = short.MinValue;
            short varsayılan_short = default(short);
            Console.WriteLine("short veri tipinin değer aralığı:");
            Console.WriteLine($"{min_short} .. {max_short}  ");
            Console.WriteLine($"varsayılan değeri:{varsayılan_short}");
            Console.WriteLine($"Bellekte kapıldığı alan: {sizeof(short)} Byte");
            Console.WriteLine("________________________________________________");

            Console.ReadKey();
        }
  ```
  
  **Ekran Çıktısı**
  ```
  sbyte veri tipinin değer aralığı:
-128 .. 127
varsayılan değeri:0
Bellekte kapıldığı alan: 1 Byte
________________________________________________
int veri tipinin değer aralığı:
-2147483648 .. 2147483647
varsayılan değeri:0
Bellekte kapıldığı alan: 4 Byte
________________________________________________
float veri tipinin değer aralığı:
-3,4028235E+38 .. 3,4028235E+38
varsayılan değeri:0
Bellekte kapıldığı alan: 4 Byte
________________________________________________
double veri tipinin değer aralığı:
-1,7976931348623157E+308 .. 1,7976931348623157E+308
varsayılan değeri:0
Bellekte kapıldığı alan: 8 Byte
________________________________________________
short veri tipinin değer aralığı:
-32768 .. 32767
varsayılan değeri:0
Bellekte kapıldığı alan: 2 Byte
________________________________________________

```

### Soru-2
  Klavyeden girilen 4 puanın ortalamasını bulan programı tasarlayınız
  ```csharp
  static void Main(string[] args)
        {
            byte puan1, puan2, puan3,puan4;
            Console.Write("1. Puanı Giriniz:");
            puan1 = Convert.ToByte(Console.ReadLine());
            Console.Write("2. Puanı Giriniz:");
            puan2 = Convert.ToByte(Console.ReadLine());
            Console.Write("3. Puanı Giriniz:");
            puan3 = Convert.ToByte(Console.ReadLine());
            Console.Write("4. Puanı Giriniz:");
            puan4 = Convert.ToByte(Console.ReadLine());

            double ortalama = (puan1 + puan2 + puan3 + puan4) / 4.0;
            Console.WriteLine($"{puan1}, {puan2}, {puan3} ve {puan4} puanlarının ortalaması {ortalama}'dır. ");
            Console.ReadKey();
      
        }
  
  ```
  
   **Ekran Çıktısı**
  ```
  1. Puanı Giriniz:10
  2. Puanı Giriniz:20
  3. Puanı Giriniz:30
  4. Puanı Giriniz:40
  10, 20, 30 ve 40 puanlarının ortalaması 25'dır.
 ```
### Soru-3
  Bir öğrencinin girdiği sınavlarda yıl sonu puanı hesaplanırken ilk 2 sınavının % 25'i son  sınavının ise % 50'si toplanarak bulunmaktadır. Buna göre 3 sınav puanı klavyeden girilen bir öğrencinin yıl sonu puanını hesaplayınız.
  
### Soru-4
  Klavyeden Girilen bir sayının tek mi çift mi olduğunu ekrana yazdırınız. (% ve ternary oparatörü kullanılacak)
  
### Soru-5
  Klavyeden Girilen 2 puanın ortalamasına göre eğer ortalama 50'den küçükse "Kaldı" büyük veya eşitse "Geçti" yazdıran programı tasarlayınız. (ternary oparatörü kullanılacak)
  
### Soru-6
   Klavyeden girilen 3 basamaklı sayının rakamlarını alt alta yazdırınız.
   
### Soru-7
   Klavyedem 3 basamaklı bir sayı girilecektir. Eğer son rakam tek ise ilk 2 rakamın toplamı ekrana yazdırılacak, çift ise farkı ekrana yazdırılacaktır.((% ve ternary oparatörü kullanılacak))
