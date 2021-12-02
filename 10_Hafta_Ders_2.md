## Hiyerarşik Kalıtım ##

> Nesneye yönelik programlama yaklaşımında türetilmiş bir sınıftan başka bir sınıf türetilebilir. Bu duruma hiyerarşik Kalıtım Denilir.

> Aşağıdaki Örnekte Memeli sınıfı Hayvan sınıfından Kopek sınıfı da Memeli sınıfından türetilmiştir. Hiyerarşik kalıtım yoluyla Kopek sınıfı hem Hayvan hemde Memeli sınıfının üyelerine erişim sağlayabilmektedir.

```csharp
  class Program
    {
        static void Main(string[] args)
        {
            Kopek kopek1 = new Kopek { ozellik1 = "Dişi", ozellik2 = "Evcil", ozellik3 = "Golden" };
            kopek1.bilgileriEkranaYaz();
            Console.ReadKey();
        }
    }
    class Hayvan
    {
        public string ozellik1 { get; set; }
    }

    class Memeli : Hayvan
    {
        public string ozellik2 { get; set; }

    }
    class Kopek : Memeli
    {
        public string ozellik3 { get; set; }

        public void bilgileriEkranaYaz()
        {
            Console.WriteLine($" {ozellik1} {ozellik2} {ozellik3} ");
        }

    }
    
   ```
   
   
