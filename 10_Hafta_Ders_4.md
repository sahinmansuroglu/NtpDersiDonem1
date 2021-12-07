## Sanal Metotlar (Virtual and Override keyword kullanımı) ##

```csharp
 class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            A aNesne = new A();
            aNesne.SinifAdiGoster();
            B bNesne = new B();
            bNesne.SinifAdiGoster();
            Console.ReadKey();
            
        }
    }
    class A
    {
        public virtual void SinifAdiGoster()
        {
            Console.WriteLine("Burası A Sınıfı");
        }
    }
    class B:A
    {
        public override void SinifAdiGoster()
        {
            Console.WriteLine("Burası B Sınıfı");
        }
    }
```
