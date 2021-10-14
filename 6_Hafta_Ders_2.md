## Encapsulation  (Kapsülleme) ## 
> Kapsülleme sınıf içerisindeki private olarak tanımlanmış alanlara güvenli bir şekilde erişilebilmesini sağlayan yapılardır.
> Kapsüllemenin temel yapısını get ve set metotları oluşturur. Private tanımlanmış bir alanın(field) değerini çekmek istediğimizde get methodunu, bu alana (field) değer vermek istediğimizde ise set methodunu kullanırız.

**Örnek**
> Aşağıdaki örnekte Dikdortgen sınıfının içerisinde private olarak kisaKenar field'i (Alanı) tanımlanmış  ve bu field'a erişim KisaKenar özelliğinin get ve set metotları kullanılarak gerçekleştirilmiştir. 
```csharp
class Dikdortgen{
        private int kisaKenar; //
        public int KisaKenar
        {
            get { return kisaKenar; }
            set
            {
                if (value < 0)
                { kisaKenar = 0; }
                else
                { kisaKenar = value; }
            }
        }
}
```


namespace kapsullemem
{
    class Dikdortgen
    {
        private int kisaKenar;//field(alan)
        private int uzunKenar;
        public int KisaKenar { //Property
            get { 
                return kisaKenar; 
            }
            set { 
                if (value < 0)
                {
                    kisaKenar = 0;
                }
                else
                {
                    kisaKenar = value;
                }
               
            } 
        
        }

        public int UzunKenar { 
            get  {
                return uzunKenar;
            }
            set
            {
                if (value < 0)
                {
                    uzunKenar = 0;
                }
                else
                {
                    uzunKenar = value;
                }
               
            }
        
        }
        public Dikdortgen(int kisaKenar, int uzunKenar)
        {
            this.KisaKenar = kisaKenar;
            this.UzunKenar= uzunKenar;
        }
       public int alanHesapla()
        {
            return KisaKenar * UzunKenar;
        }
    }
}


using System;

namespace kapsullemem
{
    class Program
    {
        static void Main(string[] args)
        {

            Dikdortgen yeniDikdortgen = new Dikdortgen(-5, 5);

            Console.WriteLine($"Alan={yeniDikdortgen.alanHesapla()}");

            Console.ReadKey();
        }
    }
}
