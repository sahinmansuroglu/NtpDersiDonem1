    ## Metotları değer ile çağırma (call by value), referans ile çağırma(call by reference) ## 
    > Bir metod parametre gönderilerek çağrıldığında gönderilen parametreler üzerinde değişiklik yapılıp yapılmayacağı denetlenebilir bir durumdur.
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr1;
            ogr1 = new Ogrenci();
            ogr1.adSoyad = "Ali Veli";
            ogr1.n1 = 34;
            ogr1.n2 = 60;
            ogr1.n3 = 80;
            ogrencininOrtalamasiniHesapla(ogr1);
            durumHesapla(ogr1);
            Console.WriteLine($"Ortalama:{ogr1.ort}");
            Console.WriteLine($"Durum:{ogr1.durum}");
            Console.ReadKey();
        }
        public static void ogrencininOrtalamasiniHesapla(Ogrenci ogrRef)
        {
            ogrRef.ort = (ogrRef.n1 + ogrRef.n2 + ogrRef.n3) / 3.0;
        }
        public static void durumHesapla(Ogrenci ogr)
        {
            if (ogr.ort < 50)
            {
                ogr.durum = "Kaldınız..";
            }
            else
            {
                ogr.durum = "Geçtiniz..";
            }
        }

    }
    class Ogrenci
    {
        public string adSoyad;
        public int n1;
        public int n2;
        public int n3;
        public double ort;
        public string durum;

    }
