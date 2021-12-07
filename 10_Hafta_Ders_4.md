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

**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/144972733-f0d246e8-9c5c-4495-8e56-a896a2f9b6f8.png)

