## Hashtable Koleksiyonu ##
> Hashtable, non-generic bir koleksiyondur. Veriler Dictionary yapısındaki gibi  key-value ikilisi şeklinde saklanır. Ancak Dictionary'den farkı key değeri hesaplamada hashing denen bir mekanızma kullanıldığından dolayı verilere erişim daha hızlıdır.

**Örnek-1**

```csharp
            Hashtable hashtable = new Hashtable();
            hashtable.Add(45, "ahmet");
            hashtable.Add("65", "ahmet");
```

**Örnek-2**

```csharp
           
            Hashtable hashtable = new Hashtable();
            hashtable.Add(45, "ahmet");
            hashtable.Add("65", "Ali");
            foreach (var item in hashtable.Keys)
            {
                Console.WriteLine(item);
            }
            
```

![image](https://user-images.githubusercontent.com/28144917/148027394-5c29cc2b-45f2-4f0a-9946-3cb4f4118e78.png)

**Örnek-3**

```csharp
           
            Hashtable hashtable = new Hashtable();
            hashtable.Add(45, "ahmet");
            hashtable.Add("65", "Arda");
            foreach (var item in hashtable.Values)
            {
                Console.WriteLine(item);
            }
            
```

![image](https://user-images.githubusercontent.com/28144917/148027362-fa01180c-ba6d-4836-8382-8cf1cc1fdc4e.png)

**Örnek-4**

```csharp
           
            Hashtable sehirler = new Hashtable();
            sehirler.Add(33, "Mersin");
            sehirler.Add(34, "İstanbul");
            sehirler.Add("01", "Adana");
            sehirler.Add("06", "Ankara");
            foreach (var plakaNo in sehirler.Keys)
            {
                Console.WriteLine($"{plakaNo} - {sehirler[plakaNo]}" );
            }
            Console.ReadKey();
```

![image](https://user-images.githubusercontent.com/28144917/148027672-e54d48fd-c9b5-4626-bc62-4761aa315c93.png)

