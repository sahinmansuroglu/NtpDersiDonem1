## İşlem Önceliği

> Programlama dillerin de işlemler belli bir öncelik sırasına göre yapılmaktadır.
> Bu öncelik sırası aşağıda verilmektedir.

1. Parantez içleri
2. Üs alma
3. Çarpma ve Bölme
4. Toplama ve Çıkarma

> **Not:** Aynı önceliğe sahip işlemlerde işlemler soldan soğa yapılır

**Örnekler**
```csharp
double sonuc;
sonuc = 45 - 65 * 2 + 5;
Console.WriteLine(sonuc);     // -80 Yazar
```

```csharp
double sonuc;
sonuc = 45 / 5 - 5 * 4 / 2 + 5;
Console.WriteLine(sonuc);   // 4 Yazar
```

```csharp
double sonuc;
sonuc = 15 - 9 % 2 * 5 + 10 / 5;
Console.WriteLine(sonuc);   // 12 Yazar
```

```csharp
int a = 55;
int b = 35;
double sonuc=(a + b) / 2 - 5 * 3;
Console.WriteLine(sonuc); // 30 yazar
```

```csharp
int a = 5;
int b = 2;
double sonuc=a / b + a * b;
Console.WriteLine(sonuc); // 12 yazar
```

```csharp
int a = 5;
int b = 2;
double sonuc=(double) a / b + a * b;
Console.WriteLine(sonuc); // 12,5 yazar
```

```csharp           
int puan = 55;
bool sonuc = puan <= 100 && puan >= 50;
Console.WriteLine(sonuc); // true yazar
```

```csharp           
int puan = 55;
bool sonuc = puan <= 100 && puan >= 50;
string durum = sonuc==true ? "Geçti" : "Kaldı";
Console.WriteLine(durum); // Geçti yazar
```
