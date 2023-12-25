## Sınav  Sorusu ##
> **Aşağıdaki istenilenler tek bir soru içindir. Verilenleri sırayla takip ederek uygulamayı tamamlayınız.**
1. Aşağıda Verilenlere Göre **```Ogrenci```** adında **```abstract```** bir sınıf tanımlayınız _**```(25 Puan)```**_

    - ad, soyad, ogrenciNo, dogumTarihi ve başlamaYili olmak üzere 5 tane **```private field```** bulunacak. 
    - herbir field için birer tane **```property ```** oluşturarak aşağıdaki durumlara göre **```encapsulation```** yapılacak. 

      - Ad ve Soyad boş girilirse **``` throw ```** ile hata fırlatılmalı.
      - OgrenciNo 3 basamaklı bir rakamdan oluşmuyorsa **``` throw ```** ile hata fırlatılmalı.
      - DogumTarihi ve başlamaYili 2023  ile 1990 arasında değilse **``` throw  ```** ile hata fırlatılmalı.
        
    - Yas adında **```readonly property```**  tanımlanarak dogumTarihinden yası hesaplattırılacak. (Sadece **```get```** metodu bulunacak)
    - Tanımlanan 5 **``` field ```** için değer ataması kurucu metot içerisinde yapılacak.
    - **```string```** tipinde enOnemliOlayi adından bir **```abstract```** metod tanımlayınız. 
    - Öğrencinin tüm bilgilerini ekrana yazdıran bilgileriEkranaYaz() adında **```virtual```** metot tanımlayınız.


2. Aşağıda verilenlere göre IOgrenciIslem() adında bir **``` interface ```** tanımlayınız. _**```(5 Puan)```**_


    - string tipinde matematikDersIcerigi() adında bir metot gövdesi bulunacak


3. Aşağıda verilenlere göre IlkOkulOgrencisi ve OrtaOkulOgrencisi  adlarında classları Ogrenci class'ından ve IOgrenciIslem interface'inden türetiniz. 
   
   - IlkOkulOgrencisi class'ı _**```(15 Puan)```**_

        - ad, soyad, ogrenciNo, dogumTarihi ve başlamaYili parametrelerinin bulunduğu kurucu metot tanımlanacak
         
            - (Base kullanılarak temel(parent) sınıfın kurucusu çağrılacak)
              
        - enOnemliOlayi() metodu "Yaz Kampları" adında bir String döndürecek
        - matematikDersIcerigi()  metodu "İlk Matematik" adında bir String döndürecek
        - bilgileriEkranaYaz() metodu override edilerek Aşağıdaki bilgiler ekrana yazdırılacak
          
            - ad, soyad, ogrenciNo, dogumTarihi, başlamaYili, yas, enOnemliOlayi ve matematikDersIcerigi
            - İçerisinde base.bilgileriEkranaYaz() ile temel classın metodu da çağrılacak
              
        - ortaokuldanMezunOlmaYiliniEkranaYaz() metodu başlamaYili'na 8 ekleyerek  sonucu ekrana yazacak
        
   - OrtaOkulOgrencisi class'ı  _**```(15 Puan)```**_

        - ad, soyad, ogrenciNo, dogumTarihi ve başlamaYili parametrelerinin bulunduğu kurucu metot tanımlanacak
          
            - (Base kullanılarak temel(parent) sınıfın kurucusu çağrılacak)
              
        - enOnemliOlayi() metodu "LGS Sınavı" adında bir String döndürecek
        - matematikDersIcerigi()  metodu "Temel Matematik" adında bir String döndürecek
        - bilgileriEkranaYaz() metodu override edilerek Aşağıdaki bilgiler ekrana yazdırılacak
          
            - ad, soyad, ogrenciNo, dogumTarihi, başlamaYili, yas, enOnemliOlayi ve matematikDersIcerigi
            - İçerisinde base.bilgileriEkranaYaz() ile temel classın metodu da çağrılacak
              
        - toString() metodu override edilerek ad, Soyad ve ogrenciNo  bilgileri birleştirilerek döndürülecek
        - gidebileceğiOkullariEkranaYaz() metodu ekrana "Gidebileceği Okullar: MTAL, Anadolu Lisesi, Fen Lisesi" metinin yazacak
        

4. Ana Program Class'ında EkranaYaz adında bir static method tanımlayarak bu method içerisinde Parametre olarak aldığı öğrencinin  bilgileriEkranaYaz() methodu çağrılmalı . _**```(20 Puan)```**_

    - Ayrıca;
    - Eğer Öğrenci İlkokul öğrencisi ise ortaokuldanMezunOlmaYiliniEkranaYaz()  metodunu da çağırın.
    - Eğer Öğrenci Ortaokul öğrencisi ise gidebileceğiOkullariEkranaYaz()  metodunu da çağırın.

5. Ana Programda Aşağıdaki gibi  2 Adet İlkokul öğrencisi ve 2 adet ortaokul Öğrencisi nesnesi oluşturunuz.  _**```(15 Puan)```**_

        - OrtaOkulOgrencisi("Zehra", "ACI", 354, 2009, 2019);
        - IlkOkulOgrencisi("Esra", "ZEYBEK", 985, 2014, 2000);
        - OrtaOkulOgrencisi("Ali", "AKIN", 654, 2010, 2020);
        - IlkOkulOgrencisi("Ahmet", "EKER", 387, 2015, 2000);
   
7. Her bir Öğrenci nesnesini 5. adımda oluşturulan EkranaYaz methoduna parametre olarak göndererek bilgileri ekrana yazdırınız.



## Cevap-1 Ogrenci Sınıfı ## 

```csharp
abstract class Ogrenci
    {
        string ad;
        string soyad;
        int ogrenciNo;
        int dogumTarihi;
        int baslamaYili;

        public string Ad { 
            get => ad;
            set {
                if (value.Trim() == String.Empty) {
                    throw new Exception("Ad Boşluk olamaz");
                }
                else
                {
                    ad = value;
                }
               
            } 
        }
        public string Soyad { get => soyad; set
            {
                if (value.Trim() == String.Empty)
                {
                    throw new Exception("Soyad Boşluk olamaz");
                }
                else
                {
                    soyad = value;
                }

            }
        }
        public int OgrenciNo { 
            get => ogrenciNo;
            set {
                if (value<=999 & value>=100)
                {
                    ogrenciNo = value;
                }
                else
                {
                    throw new Exception("Okul No 3 basamaklı bir sayı olmalı");
                }
                
            }
        
        }
        public int DogumTarihi { get => dogumTarihi; 
            set
            {
                if (value <= 2023 & value >= 1990)
                {
                    dogumTarihi = value;
                }
                else
                {
                    throw new Exception("Doğum Tarihi 2023 ile 1990 arasında olmalı");
                }

            }
        }
        public int BaslamaYili { get => baslamaYili;
            set
            {
                if (value <= 2023 & value >= 1990)
                {
                    baslamaYili = value;
                }
                else
                {
                    throw new Exception("Baslama yılı 2023 ile 1990 arasında olmalı");
                }

            }
        }
        public int Yas { get { return 2023 - dogumTarihi; } }

        protected Ogrenci(string ad, string soyad, int ogrenciNo, int dogumTarihi, int baslamaYili)
        {
            Ad = ad;
            Soyad = soyad;
            OgrenciNo = ogrenciNo;
            DogumTarihi = dogumTarihi;
            BaslamaYili = baslamaYili;
        }
        public abstract string enOnemliOlay();
        public virtual void bilgileriEkranaYaz()
        {
            Console.WriteLine("*************************************");
            Console.WriteLine($"Ad:{Ad}");
            Console.WriteLine($"Soyad:{Soyad}");
            Console.WriteLine($"OgrenciNo:{ogrenciNo}");
            Console.WriteLine($"DogumTarihi:{DogumTarihi}");
            Console.WriteLine($"BaslamaYili:{BaslamaYili}");
            Console.WriteLine($"Yaş:{Yas}");
            Console.WriteLine($"En Önemli Olayı:{enOnemliOlay()}");
        }
    }
```


## Cevap-2 IOgrenciIslem Arayüzü ## 

```csharp
 internal interface IOgrenciIslem
    {
        string matematikDersIcerigi();
    }
```


## Cevap-3-A IlkOkulOgrencisi  Sınıfı ## 

```csharp
   internal class IlkOkulOgrencisi : Ogrenci, IOgrenciIslem
    {
        public IlkOkulOgrencisi(string ad, string soyad, int ogrenciNo, int dogumTarihi, int baslamaYili) : base(ad, soyad, ogrenciNo, dogumTarihi, baslamaYili)
        {
        }

        public override string enOnemliOlay()
        {
            return "Yaz Kampları";
        }

        public string matematikDersIcerigi()
        {
            return "İlk Matematik";
        }
       

        public override void bilgileriEkranaYaz()
        {
            base.bilgileriEkranaYaz();
            Console.WriteLine($"Matematik Ders İçerisiği:{matematikDersIcerigi()}");
        }


        public void ortaokuldanMezunOlmaYiliniEkranaYaz()
        {
            Console.WriteLine($"Ortaokuldan Mezun olma Yılı:{BaslamaYili+8}");
        }
    }
```

## Cevap-3-B OrtaOkulOgrencisi   Sınıfı ## 

```csharp
    internal class OrtaOkulOgrencisi : Ogrenci, IOgrenciIslem
    {
        public OrtaOkulOgrencisi(string ad, string soyad, int ogrenciNo, int dogumTarihi, int baslamaYili) : base(ad, soyad, ogrenciNo, dogumTarihi, baslamaYili)
        {
        }

        public override void bilgileriEkranaYaz()
        {
            base.bilgileriEkranaYaz();
            Console.WriteLine($"Matematik Ders İçerisiği:{matematikDersIcerigi()}");
      
        }

        public override string enOnemliOlay()
        {
            return "LGS Sınavı";
        }

        public string matematikDersIcerigi()
        {
            return "Temel Matematik";
        }

        
        public override string? ToString()
        {
            return $"{Ad} {Soyad} {OgrenciNo}";
        }

        public void gidebileceğiOkullariEkranaYaz()
        {
            Console.WriteLine("Gidebileceği Okullar: MTAL, Anadolu Lisesi, Fen Lisesi");
        }
    }
```

## Cevap-4,5,6 Ana Program Sınıfı ## 

```csharp
  internal class Program
    {
        public static void Main(String[] args)
        {
            Ogrenci ogrenci1=  new OrtaOkulOgrencisi("Zehra", "ACI", 354, 2009, 2019);
            Ogrenci ogrenci2 = new IlkOkulOgrencisi("Esra", "ZEYBEK", 985, 2014, 2000);
            Ogrenci ogrenci3 = new OrtaOkulOgrencisi("Ali", "AKIN", 654, 2010, 2020);
            Ogrenci ogrenci4 = new IlkOkulOgrencisi("Ahmet", "EKER", 387, 2015, 2000);

            ekranaYaz(ogrenci1);
            ekranaYaz(ogrenci2);
            ekranaYaz(ogrenci3);
            ekranaYaz(ogrenci4);

        }

        public static void ekranaYaz(Ogrenci ogrenci)
        {
            ogrenci.bilgileriEkranaYaz();

            if (ogrenci is IlkOkulOgrencisi)
            {
                ((IlkOkulOgrencisi)ogrenci).ortaokuldanMezunOlmaYiliniEkranaYaz();
            }
            if (ogrenci is OrtaOkulOgrencisi)
            {
                ((OrtaOkulOgrencisi)ogrenci).gidebileceğiOkullariEkranaYaz();
            }
        }

    }
```

