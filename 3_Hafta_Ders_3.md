## Döngülerde Break ve Continue Kullanımı ##

### Break### 
> Döngülerde döngü sonunda gelmeden döngüyü sonlandırmak istediğimizde `break` komutunu kullanırız.

#### Örnek ####

Aşağıdaki programda i'nin değeri 6 olduğunda break komutu çalışacağı için döngü sonlanacak ve sadece 1'den  5'e kadar olan sayıları ekrana yazdıracaktır. 

```csharp
            for (int i = 1; i < 10; i++)
            {
                if (i == 6)
                {
                    break;
                }
                Console.Write($"{i} ");
            }
            Console.ReadKey();
```

**Ekran Çıktısı**
```
1 2 3 4 5 
```

### Continue ### 
> Döngülerin bazı adımlarında o adımın atlanıp diğer adıma geçmesi istenebilir. Bu durumlarda Continue komutu kullanılır

#### Örnek ####

> Aşağıdaki programda i'nin değeri 6 olduğunda continue  komutu çalışacağı için kendinden sonraki kodları çalıştırmayıp bir sonraki adıma geçecektir. bundan dolayı 6 sayısını yazmayacaktır.

```csharp
            for (int i = 1; i < 10; i++)
            {
                if (i == 6)
                {
                    continue;
                }
                Console.Write($"{i} ");
            }
            Console.ReadKey();
```

**Ekran Çıktısı**
```
1 2 3 4 5 7 8 9
```
