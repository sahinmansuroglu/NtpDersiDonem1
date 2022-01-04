## Queue (Kuyruk) - Stack (Yığın) Koleksiyonları ##

### 1. Queue (Kuyruk) koleksiyonları (FIFO:First In First Out) ###
> Kuyruk koleksiyonları FIFO mantığına göre çalışır. Yani kolesiyondan bir elaman çıkarılmak istendğinde kuyruğa eklenen ilk eleman çıkarıalcaktır. Enqueue() ve  Dequeue() olmak üzere ik metodu vardır
  - Enqueue(): Kuyruğa eleman eklemek için kullanılır.
  - Dequeue(): Kuyruktan eleman çıkarmak için kullanılır.
  - Peek(): Kuyruktan çıkarılacak olan elemanı Gösterir.


**Not:** Queue ve Stack koleksiyonun kullanılabilmesi için System.Collections.Generic ad uzayının uygulamaya dahil edilmesi gerekir.

**Örnek-1**
```csharp
static void Main(string[] args)
        {
            Queue<string> kuyruk = new Queue<string>();

            kuyruk.Enqueue("Ahmet");
            kuyruk.Enqueue("Mehmet");
            
            Console.WriteLine($"Sıradaki Kişi:{kuyruk.Dequeue()}");
            
            Console.WriteLine($"Sıradaki Kişi:{kuyruk.Dequeue()}");
            Console.ReadKey();

        }
```
**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/148013401-6170d6ad-5773-4725-92e9-a3fa4bd263ef.png)


**Örnek-2**
```csharp
static void Main(string[] args)
        {
            Queue<string> kuyruk = new Queue<string>();


            kuyruk.Enqueue("Mehmet");
            kuyruk.Enqueue("Arda");
            kuyruk.Enqueue("Ali");
     
            Console.WriteLine($"Kuyrugun Son Hali:{string.Join(" ",kuyruk.ToArray())}");
            Console.WriteLine($"Sıradaki Kişi:{kuyruk.Dequeue()}");
            Console.WriteLine($"Kuyrugun Son Hali:{string.Join(" ", kuyruk.ToArray())}");
            Console.WriteLine($"Sıradaki Kişi:{kuyruk.Dequeue()}");
            Console.WriteLine($"Kuyrugun Son Hali:{string.Join(" ", kuyruk.ToArray())}");
            Console.WriteLine($"Sıradaki Kişi:{kuyruk.Dequeue()}");
            Console.ReadKey();

        }
```
v

![image](https://user-images.githubusercontent.com/28144917/148013498-13d18522-4fa1-46f1-96a1-cdb38fa6a9f7.png)

**Örnek-3**
> Aşağıdaki Menüyü oluşturun ve menüdeki her seçeneğe uygun işlemi yaptırın.
  - İşlemler
  - 1-Banka Sırasına Kişi ekle
  - 2-Sıradaki Kişiyi Göster
  - 3-Sıradaki Kişiyi Çıkar
  - 4-Çıkış
  
**Çözüm**

```csharp
static void Main(string[] args)
        {
            Queue<string> kuyruk = new Queue<string>();
            while (true)
            {
                Console.WriteLine("- İşlemler");
                Console.WriteLine("- 1 - Banka Sırasına Kişi ekle");
                Console.WriteLine("- 2 - Sıradaki Kişiyi Göster");
                Console.WriteLine("- 3 - Sıradaki Kişiyi Çıkar");
                Console.WriteLine("- 4 - Çıkış");
                Console.Write("Seçiminiz:");
                string secim = Console.ReadLine();
                if (secim == "4")
                {
                    break;
                }

                if (secim == "1")
                {
                    Console.Write("Sıraya eklenecek Kişinin Adını giriniz:");
                    string ad = Console.ReadLine();
                    kuyruk.Enqueue(ad);
                    Console.WriteLine($"{ad} adlı kişi sıraya eklendi");
                } else if (secim == "2")
                {
                    if (kuyruk.Count == 0)
                    {
                        Console.WriteLine("Kuyrukda Eleman Bulunmamaktadır..");
                    }
                    else
                    {
                        Console.WriteLine(string.Join("<-",kuyruk.ToArray()));
                        Console.WriteLine($"Sıradaki Kişin:{kuyruk.Peek()}");
                    }
                    
                }
                else if (secim == "3")
                {
                    if (kuyruk.Count == 0)
                    {
                        Console.WriteLine("Kuyrukda Eleman Bulunmamaktadır..");
                    }
                    else
                    {
                        Console.WriteLine($"{kuyruk.Dequeue()} adlı kişi sıradan çıkarıldı");
                    }
                   
                }
                else
                {
                    Console.WriteLine("Lütfen 1-4 Arası değer giriniz!!");
                }
                Console.WriteLine("Devam Etmek İçin Bir Tuşa basınız..");
                Console.ReadKey();
                Console.Clear();

            }


            Console.ReadKey();

        }
```

### 2. Stack (Yığın) koleksiyonları (LIFO:Last In First Out) ###
> Stack koleksiyonları LIFO mantığına göre çalışır. Yani kolesiyondan bir elaman çıkarılmak istendiğinde kuyruğa eklenen son eleman çıkarılacaktır. Push() ve  Pop() olmak üzere ik metodu vardır
  - Push(): Yığına eleman eklemek için kullanılır.
  - Pop(): Yığından eleman çıkarmak için kullanılır
  - Peek(): Yığından çıkarılacak olan elemanı Gösterir.


**Örnek-3**
```csharp
static void Main(string[] args)
        {
            Stack<string> yigin = new Stack<string>();

            yigin.Push("Bir");
            yigin.Push("İki");
            yigin.Push("Üç");
            yigin.Push("Dört");
            yigin.Push("Beş");

            Console.WriteLine($"Yığın: {string.Join(" <- ",yigin.ToArray())}");
            Console.WriteLine($"Çıkma Sırasındaki Eleman:{yigin.Peek()}");
            Console.WriteLine($"Yığın: {string.Join(" <- ", yigin.ToArray())}");

            Console.WriteLine($"Yığından çıkarılan Eleman:{yigin.Pop()}");
            Console.WriteLine($"Yığın: {string.Join(" <- ", yigin.ToArray())}");

            Console.WriteLine($"Yığından çıkarılan Eleman:{yigin.Pop()}");
            Console.WriteLine($"Yığın: {string.Join(" <- ", yigin.ToArray())}");

            Console.WriteLine($"Yığından çıkarılan Eleman:{yigin.Pop()}");
            Console.WriteLine($"Yığın: {string.Join(" <- ", yigin.ToArray())}");

            Console.WriteLine($"Yığından çıkarılan Eleman:{yigin.Pop()}");
            Console.WriteLine($"Yığın: {string.Join(" <- ", yigin.ToArray())}");


            Console.ReadKey();
        }

```

**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/148017939-85d78b7c-0ba9-4e80-9766-ebfffce45855.png)


