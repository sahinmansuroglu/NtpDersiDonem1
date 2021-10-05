## Metot Kavramı ##

> Programlama dillerinde kodların tekrar tekrar yazılması yerine 

### Metot Tanımlama ###

> Geriye Değer Döndürmeyen Metot Tanımlama

```csharp
void metotadi ()
{

//metot içerisinde gerçekleştirilecek işlemler ;

}
```
**Örnek**

```csharp
 void mesajYaz()
 {
            Console.WriteLine("Merhaba 11 ATBA");
            Console.WriteLine("Bugün Nasılsınız?");
  }
```

> Geriye Değer Döndüren Metot Tanımlama

```csharp
dönüş_tipi metotadi ()
{

  //metot içerisinde gerçekleştirilecek işlemler ;
  return dönüş_Değeri
}

```

**Örnek**

```csharp
  string mesajGetir()
        {
            string mesaJ = "Merhaba 11ATBA \n Bugün Nasılsınız?";
            return mesaJ;
        }
        
```

> Dışardan Parametre Alan  Metot Tanımlama

```csharp
static void Main(string[] args)
        {

           Console.WriteLine( mesajGetir("Ahmet ER"));
           Console.WriteLine(mesajGetir("Ali VELİ"));
           Console.WriteLine(mesajGetir("Mehmet CAN"));
            Console.ReadKey();

        }
        
       static string mesajGetir(string ad)
        {
            string mesaJ = $"Merhaba {ad} \n Bugün Nasılsınız?";
            return mesaJ;
        }
```
