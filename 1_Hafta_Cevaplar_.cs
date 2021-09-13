1. Soru
static void Main(string[] args)
        {
            string sehirAdi = "Mersin";
            string enGuzelYeri = "Tisan Yarım Adası";
            string neYenir = "Tantuni";

            Console.WriteLine($"{sehirAdi} şehrinin en güzel yeri {enGuzelYeri}, en güzel Yiyeceği de {neYenir}.");

        }
2.Soru
static void Main(string[] args)
        {
            string metin1 = "        Programlama       ";
            string metin2 = "     Öğrenmek           ";
            string metin3 = "        Çok Eğlenceli          ";

            Console.WriteLine($" {metin1.Trim()} {metin2.Trim()} {metin3.Trim()}") ;

        }
3. Soru
using System;

namespace cEgitim
{
    class Program
    {
        static void Main(string[] args)
        {
            string mesaj = "13 Ekim 1923'te TBMM'de ANKARA başkent olarak kabul edilmiştir";
            string kelime1 = "  Ankara   ";
            string kelime2 = "  BAŞKENT   ";

            kelime1 = kelime1.Trim();
            kelime1 = kelime1.ToUpper();
            kelime2 = kelime2.Trim();
            kelime2 = kelime2.ToLower();

            Console.WriteLine(mesaj.Contains(kelime1));
            Console.WriteLine(mesaj.Contains(kelime2));
        }
    }
}
4. Soru
static void Main(string[] args)
        {
            string metin = "Türkiyenin En BÜYÜK Şehri İstanbul'dur ";
            string arananKelime = "Büyük";
            string yeniDegeri = "Kalabalık";
            arananKelime = arananKelime.ToUpper();
            metin = metin.Replace(arananKelime, yeniDegeri);
            Console.WriteLine(metin);
        }
