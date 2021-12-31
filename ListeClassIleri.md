using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ogrenci> ogreciler = new List<Ogrenci>();


            //1. Öğrenci
            Ogrenci ogrenci1 = new Ogrenci { AdSoyad="Ece ER",OkulNo=65};

            List<Ders> dersListesi1 = new List<Ders>();
            dersListesi1.Add(new Ders { DersAdi = "Yazılım", DersSaati = 5, Puanlar = new List<int>() { 95, 65, 36, 31 } });
            dersListesi1.Add(new Ders { DersAdi = "Kimya", DersSaati = 4, Puanlar = new List<int>() {  65, 36, 31 } });
            dersListesi1.Add(new Ders { DersAdi = "Fizik", DersSaati = 4, Puanlar = new List<int>() { 95, 65, 36, } });
            dersListesi1.Add(new Ders { DersAdi = "MAtematik", DersSaati = 6, Puanlar = new List<int>() { 65,  31 } });

            ogrenci1.Dersler = dersListesi1;


            //2. Öğrenci
            Ogrenci ogrenci2 = new Ogrenci { AdSoyad = "Asya KOR", OkulNo = 96 };

            List<Ders> dersListesi2 = new List<Ders>();
            dersListesi2.Add(new Ders { DersAdi = "Nesne", DersSaati = 5, Puanlar = new List<int>() { 95, 65, 36, 30 } });
            dersListesi2.Add(new Ders { DersAdi = "Kimya", DersSaati = 4, Puanlar = new List<int>() { 65, 36, 31,96,45} });
            dersListesi2.Add(new Ders { DersAdi = "Fizik", DersSaati = 4, Puanlar = new List<int>() { 95, 65, 36, } });
            dersListesi2.Add(new Ders { DersAdi = "MAtematik", DersSaati = 6, Puanlar = new List<int>() { 65, 31 } });

            ogrenci2.Dersler = dersListesi2;



            ogreciler.Add(ogrenci1);
            ogreciler.Add(ogrenci2);

            Console.WriteLine( string.Join("\n", ogreciler) ); ;



            Console.ReadKey();

        }
    }

    class Ogrenci
    {
        public string AdSoyad { get; set; }
        public int OkulNo { get; set; }
        public List<Ders> Dersler { get; set; }

        
        public override string ToString()
        {
            return $"{AdSoyad} - {OkulNo} \n Aldığı Dersler: \n{string.Join("\n",Dersler)}";
        }

    }

    class Ders
    {
        public string DersAdi { get; set; }
        public int DersSaati { get; set; }
        public List<int> Puanlar { get; set; }

        public double DersOrtalama
        {
            get
            {
                return Puanlar.Average();
            }
        }

        public string DersDurum
        {
            get
            {
                return DersOrtalama < 50 ? "Kaldı" : "Geçti";
            }
        }

        public override string ToString()
        {
            return $"{DersAdi} ({DersSaati}) : {DersOrtalama} ({string.Join(" ", Puanlar)}))";
        }
    }
}
