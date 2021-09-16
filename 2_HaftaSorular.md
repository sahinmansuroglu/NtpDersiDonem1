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
### Soru-3
  Klavyeden girilen 5 sayının ortalamasını bulan programı tasarlayınız
### Soru-3
  Klavyeden girilen 3 basamaklı sayının rakamlarını alt alta yazdırınız.
### Soru-4
  
