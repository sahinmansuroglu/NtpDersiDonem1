## Metotlar-2 ##
> [Metotlar-1](https://github.com/sahinmansuroglu/NtpDersi/blob/main/5_Hafta_Ders_1.md) bölümünde  metot kavramını, geriye değer döndüren, geriye değer döndürmeyen ve paramtereli metot kullanımını görd
> k. Bu bölümde ise metotlarda Varsayılan Değerli Parametreler, İsimlendirilmiş Parametreler, Parametre Dizileri kullanımını göreceğiz.

###  Varsayılan Değerli Parametreler ###

>Parametreli metotlarda metotlar çağrılırken parametre değerlerinin de methoda gönderilmesi gerekir. Eğer parametreli 
>bir methodun çağırırken değer göndermeden de çalışabilmesini istiyorsak bu tür durumlarda varsayılan değerli Parametreleri kullanabiliriz.

**Örnek Kullanım**
```csharp
using System;
class ornekSinif
{
    // Aşağıdaki metot çağrılırken sayi1 ve sayi2'nin değerleri gönderilmezse varsayılan olarak 34 ve 56 değerleri toplanır
    public int topla(int sayi1=34,int sayi2 = 56)
    {
        return sayi1 + sayi2;
    }
    //Aşağıdaki metot çağırılırken adSoyad değeri gönderilmezse varsayılan olarak "Mehmet EMİN" gönderilir..
    public void selamVer(string adSoyad="Mehmet EMİN")
    {
        Console.WriteLine($"Merhaba Sayın {adSoyad}");
    }

}

class anaProgram
{
    static void Main(string []args) {
        ornekSinif nesne = new ornekSinif();

        Console.WriteLine($"Toplamın Sonucu: {nesne.topla()}");
        Console.WriteLine($"Toplamın Sonucu: {nesne.topla(25)}");
        Console.WriteLine($"Toplamın Sonucu: {nesne.topla(45,65)}");

        nesne.selamVer();
        nesne.selamVer("Şahin MANSUROĞLU");

        Console.ReadKey();
    }
}
```
**Ekran Çıktısı**

![image](https://user-images.githubusercontent.com/28144917/138216867-e36830e6-18c8-486a-a704-7ed50fd3a702.png)


## İsimlendirilmiş Parametreler ##
> Bir metod parametreler  ile çağrılırken  parametrelerin  tanımlama sırası ile aynı sırada gönderilmesi gerekir. Eğer bu kurala uyulmak istenmiyorsa İsimlendirilmiş parametreler gönderilebilir.

**Örnek Kullanım**
> Örneği incelediğimizde metoda parametre gönderirken parametre adının yanına ":" koyarak sıraya uymadan değer gönderebiliriz.
![image](https://user-images.githubusercontent.com/28144917/138217847-07001129-7ba6-4c14-a085-1f8fa543a4f1.png)

![image](https://user-images.githubusercontent.com/28144917/138217732-825f936d-e938-49bf-95a8-fc8bbe02bc39.png)


