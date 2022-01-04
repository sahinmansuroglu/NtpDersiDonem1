## Queue (Kuyruk) - Stack (Yığın) Koleksiyonları ##

### 1. Queue (Kuyruk) koleksiyonları (FIFO:First In First Out) ###
> Kuyruk koleksiyonları FIFO mantığına göre çalışır. Yani kolesiyondan bir elaman çıkarılmak istendğinde kuyruğa eklenen ilk eleman çıkarıalcaktır. Enqueue() ve  Dequeue() olmak üzere ik metodu vardır
  - Enqueue(): Kuyruğa eleman eklemek için kullanılır.
  - Dequeue(): Kuyruktan eleman çıkarmak için kullanılır
**Not:** Queue ve Stack koleksiyonun kullanılabilmesi için System.Collections ad uzayının uygulamaya dahil edilmesi gerekir.

**Örnek-1**
```csharp
static void Main(string[] args)
        {
            Queue kuyruk = new Queue();

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
            Queue kuyruk = new Queue();


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
**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/148013498-13d18522-4fa1-46f1-96a1-cdb38fa6a9f7.png)

**Örnek-3**
> Aşağıdaki Menüyü oluşturun ve menüdeki her seçeneğe uygun işlemi yaptırın.
  - İşlemler
  - 1-Banka Sırasına Kişi ekle
  - 2-Sıradaki Kişiyi Göster
  - 3-Sıradaki Kişiyi Çıkar
  - 4-Çıkış


### 2. Stack (Yığın) koleksiyonları (LIFO:Last In First Out) ###
> Stack koleksiyonları LIFO mantığına göre çalışır. Yani kolesiyondan bir elaman çıkarılmak istendiğinde kuyruğa eklenen son eleman çıkarılacaktır. Push() ve  Pop() olmak üzere ik metodu vardır
  - Push(): Yığına eleman eklemek için kullanılır.
  - Pop(): Yığından eleman çıkarmak için kullanılır
