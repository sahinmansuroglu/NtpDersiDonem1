## Quiz Sorusu ##
> **Aşağıdaki istenilenler tek bir soru içindir. Verilenleri sırayla takip ederek uygulamayı tamamlayınız.**
1. Aşağıda Verilenlere Göre **```Ogrenci```** adında **```abstract```** bir sınıf tanımlayınız


    - ad, soyad, ogrenciNo, dogumTarihi ve başlamaYili olmak üzere 5 tane **```private field```** bulunacak. 
    - herbir field için birer tane **```property ```** oluşturarak aşağıdaki durumlara göre **```encapsulation```** yapılacak. 
      - Ad ve Soyad boş girilirse **``` throw ```** ile hata fırlatılmalı.
      - OgrenciNo 5 basamaklı bir rakamdan oluşmuyorsa **``` throw ```** ile hata fırlatılmalı.
      - DogumTarihi ve başlamaYili içinde bulunduğumuz yıl ile 1990 arasında değilse **``` throw  ```** ile hata fırlatılmalı.
    - Yas adında **```readonly property```**  tanımlanarak dogumTarihinden yası hesaplattırılacak. (Sadece **```get```** metodu bulunacak)
    - Tanımlanan 5 **``` field ```** için değer ataması kurucu metot içerisinde yapılacak.
    - **```string```** tipinde enOnemliOlayi adından bir **```abstract```** metod tanımlayınız. 
    - Öğrencinin tüm bilgilerini ekrana yazdıran bilgileriEkranaYaz() adında **```virtual```** metot tanımlayınız.


2. Aşağıda verilenlere göre IOgrenciIslem() adında bir **``` interface ```** tanımlayınız.


    - string tipinde matematikDersIcerigi() adında bir metot gövdesi bulunacak
    - int tipinde mezunOlacagiYasiHesapla() adında bir metot gövdesi tanımlayınız.


3. Aşağıda verilenlere göre IlkOkulOgrencisi, OrtaOkulOgrencisi, LiseOgrencisi adında classları Ogrenci class'ından ve IOgrenciIslem interface'inden türetiniz. 
   
   - IlkOkulOgrencisi class'ı

        - ad, soyad, ogrenciNo, dogumTarihi ve başlamaYili parametrelerinin bulunduğu kurucu metot tanımlanacak 
            - (Base kullanılarak temel(parent) sınıfın kurucusu çağrılacak)
        - enOnemliOlayi() metodu "Yaz Kampları" adında bir String döndürecek
        - matematikDersIcerigi()  metodu "İlk Matematik" adında bir String döndürecek
        - mezunOlacagiYasiHesapla() metodu  öğrencinin yasına 4 yıl eklenerek hesaplanacak
        - bilgileriEkranaYaz() metodu override edilerek tüm tüm bilgiler ekrana yazdırılacak.
            - İçerisinde base.bilgileriEkranaYaz() ile temel classın metodu da çağrılacak
        - toString() metodu override edilerek ad Soyad  bilgileri birleştirilerek döndürülecek
        - ortaokuldanMezunOlmaYiliniEkranaYaz() metodu başlamaYili'na 8 ekleyerek hesaplama yapıp sonucu ekrana yazacak
   - OrtaOkulOgrencisi class'ı

        - ad, soyad, ogrenciNo, dogumTarihi ve başlamaYili parametrelerinin bulunduğu kurucu metot tanımlanacak 
            - (Base kullanılarak temel(parent) sınıfın kurucusu çağrılacak)
        - enOnemliOlayi() metodu "LGS Sınavı" adında bir String döndürecek
        - matematikDersIcerigi()  metodu "Temel Matematik" adında bir String döndürecek
        - mezunOlacagiYasiHesapla() metodu  öğrencinin yasına 4 yıl eklenerek hesaplanacak
        - bilgileriEkranaYaz() metodu override edilerek tüm tüm bilgiler ekrana yazdırılacak.
            -İçerisinde base.bilgileriEkranaYaz() ile temel classın metodu da çağrılacak
        - toString() metodu override edilerek ad, Soyad ve ogrenciNo  bilgileri birleştirilerek döndürülecek
        - gidebileceğiOkullariEkranaYaz() metodu ekrana "Gidebileceği Okullar: MTAL, Anadolu Lisesi, Fen Lisesi" metinin yazacak
4.  IlkOkulOgrencisi ve OrtaOkulOgrencisi class'larından birer tane nesne oluşturarak nesnelerin toString() metodunu çağırıp ekrana yazdırınız. Ayrıca oluşturulan nesnelerin içerisindeki bilgileriEkranaYaz() metodlarını da çağırınız.


**Çözüm**

```csharp
using System;

namespace ArraysExample
{
    class Program
    {
        static void Main()
        {
            try
            {
                Ogrenci ogrenci1 = new IlkOkulOgrencisi("Ali", "AKIN", 25410, 1995, 2000);
                Console.WriteLine(ogrenci1);
                ogrenci1.bilgileriEkranaYaz();
                Console.WriteLine("--------------------------------------------------");
                Ogrenci ogrenci2 = new OrtaOkulOgrencisi("Arda", "AYDIN", 15410, 2005, 2008);
                Console.WriteLine(ogrenci2);
                ogrenci2.bilgileriEkranaYaz();
            }
            catch (Exception hata)
            {
                Console.WriteLine($"[HATA]:{hata.Message}");    
              
            }
            

            Console.ReadKey();
        }
    }

    abstract class Ogrenci
    {
        private string ad;
        private string soyad;
        private int ogrenciNo;
        private int dogumTarihi;
        private int baslamaYili;

        public string Ad
        {
            get
            {
                return ad;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new Exception("Ad Değeri boş olamaz");
                }
                else
                {
                    ad = value;
                }
            }
        }
        public string Soyad
        {
            get
            {
                return soyad;
            }
            set
            {
                if (value.Trim().Length == 0)
                {
                    throw new Exception("Soyad Değeri boş olamaz");
                }
                else
                {
                    soyad = value;
                }
            }
        }
        public int OgrenciNo
        {
            get
            {
                return ogrenciNo;
            }
            set
            {
                if (value >= 10000 && value <= 99999)
                {
                    ogrenciNo = value;
                }
                else
                {
                    throw new Exception("Ogrenci No 5 Basamaklı olmalı!!");
                }
            }
        }
        public int DogumTarihi
        {
            get
            {
                return dogumTarihi;
            }
            set
            {
                if (value >= 1990 && value <= DateTime.Now.Year)
                {
                    dogumTarihi = value;
                }
                else
                {
                    throw new Exception("Dogum Tarihi 1990'dan büyük olmalı");
                }
            }
        }
        public int BaslamaYili
        {
            get
            {
                return baslamaYili;
            }
            set
            {
                if (value >= 1990 && value <= DateTime.Now.Year)
                {
                    baslamaYili = value;
                }
                else
                {
                    throw new Exception("Başlama Yılı 1990'dan büyük olmalı");
                }
            }
        }

        public int Yas
        {
            get
            {
                return DateTime.Now.Year - DogumTarihi;
            }
        }

        public Ogrenci(string adP, string soyadP, int ogrenciNoP, int dogumTarihiP, int baslamaYiliP)
        {
            this.Ad = adP;
            this.Soyad = soyadP;
            this.OgrenciNo = ogrenciNoP;
            this.DogumTarihi = dogumTarihiP;
            this.BaslamaYili = baslamaYiliP;
        }

        public abstract string enOnemliOlayi();
        public virtual void bilgileriEkranaYaz()
        {
            Console.WriteLine($"Ad Soyad :{this.Ad} {this.soyad}");
            Console.WriteLine($"Öğrenci No:{this.ogrenciNo}");
            Console.WriteLine($"Dogum Tarihi - Yaş :{this.dogumTarihi} - {this.Yas}");
            Console.WriteLine($" Başlama Tarihi:{this.baslamaYili}");
        }
    }

    interface IOgrenciIslem
    {
        string matematikDersIcerigi();
        int mezunOlacagiYasiHesapla();
    }

    class IlkOkulOgrencisi : Ogrenci, IOgrenciIslem
    {
        public IlkOkulOgrencisi(string adP, string soyadP, int ogrenciNoP, int dogumTarihiP, int baslamaYiliP):base(adP,soyadP,ogrenciNoP,dogumTarihiP,baslamaYiliP)
        {
            Console.WriteLine("Yeni İlkokul öğrenci nesnesi oluşturuldu");

        }
        public override string enOnemliOlayi()
        {
            return "Yaz Kampları";
        }

        public string matematikDersIcerigi()
        {
            return "İlk Matematik";
        }

        public int mezunOlacagiYasiHesapla()
        {
            return Yas + 4;
        }
        public override string ToString()
        {
            return $"{Ad} {Soyad}";
        }

        public override void bilgileriEkranaYaz()
        {
            base.bilgileriEkranaYaz();
            Console.WriteLine($"En Önemli Olayı:{enOnemliOlayi()}");
            Console.WriteLine($"Matematik Ders İçeriği:{matematikDersIcerigi()}");
            Console.WriteLine($"Mezuniyet Yaşı:{mezunOlacagiYasiHesapla()}");
        }
        
        public void  ortaokuldanMezunOlmaYiliniEkranaYaz() {
           Console.WriteLine($"Ortaokuldan Mezun Olma Yılı:{BaslamaYili+8}");
        }
    }
    class OrtaOkulOgrencisi : Ogrenci, IOgrenciIslem
    {
        public OrtaOkulOgrencisi(string adP, string soyadP, int ogrenciNoP, int dogumTarihiP, int baslamaYiliP) : base(adP, soyadP, ogrenciNoP, dogumTarihiP, baslamaYiliP)
        {
            Console.WriteLine("Yeni Ortaokul öğrenci nesnesi oluşturuldu");

        }
        public override string enOnemliOlayi()
        {
            return "LGS Sınavı";
        }

        public string matematikDersIcerigi()
        {
            return "Temel Matematik";
        }

        public int mezunOlacagiYasiHesapla()
        {
            return Yas + 4;
        }
        public override string ToString()
        {
            return $"{Ad} {Soyad}";
        }
        public override void bilgileriEkranaYaz()
        {
            base.bilgileriEkranaYaz();
            Console.WriteLine($"En Önemli Olayı:{enOnemliOlayi()}");
            Console.WriteLine($"Matematik Ders İçeriği:{matematikDersIcerigi()}");
            Console.WriteLine($"Mezuniyet Yaşı:{mezunOlacagiYasiHesapla()}");
        }
        public void gidebileceğiOkullariEkranaYaz(){
            Console.WriteLine($"Gidebileceği Okullar: MTAL, Anadolu Lisesi, Fen Lisesi ");
        }
    }

}

```
**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/146882147-00317b4b-f03f-4c84-916c-35e11143782f.png)
