## Hiyerarşik Kalıtım ##

> Nesneye yönelik programlama yaklaşımında türetilmiş bir sınıftan başka bir sınıf türetilebilir. Bu duruma hiyerarşik Kalıtım Denilir.

> Aşağıdaki Örnekte Memeli sınıfı Hayvan sınıfından Kopek sınıfı da Memeli sınıfından türetilmiştir. Hiyerarşik kalıtım yoluyla Kopek sınıfı hem Hayvan hemde Memeli sınıfının üyelerine erişim sağlayabilmektedir.

```csharp
 class Hayvan
    {
        public int ozellik1 { get; set; }
    }

    class Memeli : Hayvan
    {
        public int ozellik2 { get; set; }

    }

    class Kopek : Memeli
    {
        public int ozellik3 { get; set; }

    }
    
   ```
   
   
