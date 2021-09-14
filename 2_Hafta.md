## Değişkenler
Değişkenler programların çalışması boyunca kullanacağı verilerin bellekte tutulduğu alanlardır.
ve bu alanlarda bulunan veriler programın çalışması boyunca değişebilir. 
Diğer bir ifade ile değişkenler aynı kodu farklı değerlerle çalıştırmaya yaran yapılardır.
Değişkenler ram belleğin stack(yığın) bölümünde saklanır

## Değişkenler Nasıl tanımlanır?
### Değer atamadan değişken tanımlama
```
  değişkenTipi değişkenAdı;
```

### Değer atayarak değişken tanımlama
```
  değişkenTipi değişkenAdı=değeri;
```

## Örnek Tanımlar

```csharp
  string adSoyad;
  int yas;
```

## Değişken Tanımlama kuralları
  1.  Değişken Adları  boşluk içeremez
      #### <del>Ogrenci Adi </del> -->Yanlış
      #### OgrenciAdi --> Dogru
  2.  Değişken isimleri içerisinde özel karakter bulunamaz. (alt çizgi hariç)
     #### <del>Ogrenci#Adi </del> -->Yanlış
     #### OgrenciAdi --> Dogru
     #### Ogrenci_Adi --> Dogru
  3. Değişken isimlendirmede ingiliz alfabesindeki harfler tercih edilir.
  4. Aynı isimde birden fazla değişken tanımlanamaz.
     #### |<del>int sayi; \newline double sayi: </del>| -->Yanlış


