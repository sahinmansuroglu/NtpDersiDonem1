## Sanal Metotlar (Virtual and Override keyword kullanımı) ##

**Ornek-1**
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


**Ornek-2**

```csharp
  class Program
    {
        static void Main(string[] args)
        {
            A aNesne1 = new A();
            aNesne1.SinifAdiGoster();
            A aNesne2 = new B();
            aNesne2.SinifAdiGoster();
            A aNesne3 = new C();
            aNesne3.SinifAdiGoster();
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

    class C : B
    {
        public override void SinifAdiGoster()
        {
            Console.WriteLine("Burası C Sınıfı");
        }
    }
```

**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/144974908-fd0bb6d8-7be8-4f87-bac4-b79799cf57ca.png)

**Ornek-3**
> Yukarıdaki uygulamada method shadowing (metot gölgeleme) yapılırsa uygulama kodu ve çıktısı aşağıdaki gibi olur

```csharp
  class Program
    {
        static void Main(string[] args)
        {
            A aNesne1 = new A();
            aNesne1.SinifAdiGoster();
            A aNesne2 = new B();
            aNesne2.SinifAdiGoster();
            A aNesne3 = new C();
            aNesne3.SinifAdiGoster();
            Console.ReadKey();
                       
        }
    }
    class A
    {
        public  void SinifAdiGoster()
        {
            Console.WriteLine("Burası A Sınıfı");
        }
    }
    class B:A
    {
        public new void SinifAdiGoster()
        {
            Console.WriteLine("Burası B Sınıfı");
        }
    }

    class C : B
    {
        public new void SinifAdiGoster()
        {
            Console.WriteLine("Burası C Sınıfı");
        }
    }
```

**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/144975536-b36d86de-8eee-4952-8248-49f382cdf4dd.png)
