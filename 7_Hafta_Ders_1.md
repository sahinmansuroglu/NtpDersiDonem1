## Abstraction ## 
> Encapsulation ile beraber NTP'nin en önemli yaklaşımlarından bir diğeri de Abstraction'dır. Abstraction  bir class içerisinde tanımlanmış üyelere (kulanıcıyı ilgilendirmeyen  erişimi kısıtlayan yaklaşımdır.  
> Temel olarak yapılacak işin nasıl yapılacağına değil de işin ne olacağına odaklanmamıza imkan verir. 
> Aşağıdaki örneği inceleyecek olursak islem sınıfının içerisinde kucuktenBuyugeYaz methodu disindaki tüm sınıf üyeleri private tanımlanmıştır. Yanı bu sınıftan nesne oluşturan bir kullanıcı sadece 
> kucuktenBuyugeYaz methoduna ulaşabilecektir.Ancak dikkaet edilirse sınıfın kucuktenBuyugeYaz methodu parametre olarak gönderilen 2 sayıyı kuçukten büyüğe yazarken private olarak tanımlanmış üyeleri  kullanmıştır.
> Ancak kullanıcı sınıfın içerisinde küçükten büyüğe doğru yazma işleminin nasıl olduğuna odaklanmaz. Sadece parametre olarak 2 sayıyı methoda gönderir ve sonucunu alır. İşte bu yaklaşıma NTP' de Abstraction denilmektedir.



 ```csharp
 
public class islem {
    private int sayi1;
    private int sayi2;
    public void kucuktenBuyugeYaz(int s1,int s2)
    {
        this.sayi1 = s1;
        this.sayi2 = s2;
        if (sayi1 > sayi2)
        {
            sayilariDegistir();
        }

        sayilariEkranaYaz();
    }
   private void sayilariDegistir()
    {
        int gecici = sayi1;
        sayi1 = sayi2;
        sayi2 = gecici;
    }
    private void sayilariEkranaYaz() {
        Console.WriteLine($"{sayi1} {sayi2}");
    }

}

```
 
