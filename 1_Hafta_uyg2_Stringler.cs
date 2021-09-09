
using System;


namespace hafta1
{
    class Program
    {
        static void Main(string[] args)
        {


            string metin1 = "";// içi boş bir string değişken tanımlandı.
            string metin2 = string.Empty;// içi boş bir string değişken tanımlandı.
            metin1 = "En büyük ";
            metin2 = "Galatasaray";
            string birlestirilmisMetin = $"{metin1} {metin2} !!";

            Console.WriteLine(birlestirilmisMetin);

        }
    }
}
